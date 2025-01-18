using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjetoDesk
{
    public partial class Form8 : Form
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";

        public Form8()
        {
            InitializeComponent();
            this.Resize += Form8_Resize;
            this.FormClosing += Form8_FormClosing;
        }

        private void Form8_Resize(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                AjustarPainel();
                button1.Location = new Point(200, 240);
                button1.Size = new Size(190, 51);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {                
                panel1.Size = new System.Drawing.Size(400, 300); 
                panel1.Location = new System.Drawing.Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2);
                button1.Size = new Size(180, 48);
                button1.Location = new Point(97, 176);
            }
        }

        
        private void AjustarPainel()
        {
            
            int novoLargura = (int)(this.ClientSize.Width * 0.4); 
            int novoAltura = (int)(this.ClientSize.Height * 0.5); 

            panel1.Size = new System.Drawing.Size(novoLargura, novoAltura); 
            panel1.Location = new System.Drawing.Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2); // Centraliza o painel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePicker1.Value;
            GerarRelatorioDeVendasPDF(dataInicial);

           
        }

        private void GerarRelatorioDeVendasPDF(DateTime dataInicial)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("RelatorioVendasPorData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DataInicial", dataInicial);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            string caminhoPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioVendas.pdf");

                            
                            Document document = new Document();
                            PdfWriter.GetInstance(document, new FileStream(caminhoPDF, FileMode.Create));
                            document.Open();

                            
                            iTextSharp.text.Font tituloFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
                            Paragraph titulo = new Paragraph("Relatório de Vendas", tituloFont)
                            {
                                Alignment = Element.ALIGN_CENTER,
                                SpacingAfter = 20f
                            };
                            document.Add(titulo);

                            
                            iTextSharp.text.Font subTituloFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12);
                            Paragraph dataRelatorio = new Paragraph("Data Inicial: " + dataInicial.ToString("dd/MM/yyyy"), subTituloFont)
                            {
                                Alignment = Element.ALIGN_CENTER,
                                SpacingAfter = 20f
                            };
                            document.Add(dataRelatorio);

                            
                            PdfPTable tabela = new PdfPTable(4)
                            {
                                WidthPercentage = 100,
                                SpacingBefore = 20f
                            };
                            tabela.SetWidths(new float[] { 2f, 1.5f, 2f, 2f }); 

                            
                            iTextSharp.text.Font fonteCabecalho = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                            PdfPCell cabecalho;

                            cabecalho = new PdfPCell(new Phrase("Produto", fonteCabecalho))
                            {
                                BackgroundColor = BaseColor.DARK_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5f
                            };
                            tabela.AddCell(cabecalho);

                            cabecalho = new PdfPCell(new Phrase("Valor Total", fonteCabecalho))
                            {
                                BackgroundColor = BaseColor.DARK_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5f
                            };
                            tabela.AddCell(cabecalho);

                            cabecalho = new PdfPCell(new Phrase("Data e Hora", fonteCabecalho))
                            {
                                BackgroundColor = BaseColor.DARK_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5f
                            };
                            tabela.AddCell(cabecalho);

                            cabecalho = new PdfPCell(new Phrase("Cliente", fonteCabecalho))
                            {
                                BackgroundColor = BaseColor.DARK_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5f
                            };
                            tabela.AddCell(cabecalho);

                            decimal valorTotalGeral = 0; 
                            iTextSharp.text.Font fonteDados = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 10);
                            while (reader.Read())
                            {
                                string produto = reader["produto"] != DBNull.Value ? reader["produto"].ToString() : "N/A";
                                decimal valorTotal = reader["ValorTotal"] != DBNull.Value ? Convert.ToDecimal(reader["ValorTotal"]) : 0;
                                valorTotalGeral += valorTotal; 
                                DateTime dataHoraVenda = reader["DataHoraVenda"] != DBNull.Value ? Convert.ToDateTime(reader["DataHoraVenda"]) : DateTime.MinValue;
                                string nomeCliente = reader["NomeCliente"] != DBNull.Value ? reader["NomeCliente"].ToString() : "N/A";

                                tabela.AddCell(new PdfPCell(new Phrase(produto, fonteDados)) { Padding = 5f });
                                tabela.AddCell(new PdfPCell(new Phrase(valorTotal.ToString("C"), fonteDados)) { Padding = 5f });
                                tabela.AddCell(new PdfPCell(new Phrase(dataHoraVenda.ToString("dd/MM/yyyy HH:mm"), fonteDados)) { Padding = 5f });
                                tabela.AddCell(new PdfPCell(new Phrase(nomeCliente, fonteDados)) { Padding = 5f });
                            }

                            
                            document.Add(tabela);

                            
                            Paragraph totalGeraral = new Paragraph($"Total Geral: {valorTotalGeral:C}", fonteDados)
                            {
                                SpacingBefore = 20f,
                                Alignment = Element.ALIGN_RIGHT
                            };
                            document.Add(totalGeraral);

                            
                            document.Close();

                            
                            MessageBox.Show("Relatório de vendas em PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = caminhoPDF,
                                UseShellExecute = true
                            };
                            Process.Start(psi);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
