using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDesk
{
    public partial class Form4 : Form
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";

        public Form4()
        {
            InitializeComponent();
            this.FormClosing += Form4_FormClosing;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string razaoSocial = textBox1.Text;
            string cnpj = textBox2.Text;

            
            if (!ValidarCnpj(cnpj))
            {
                MessageBox.Show("CNPJ inválido. Por favor, insira um CNPJ válido com 14 dígitos.", "CNPJ Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (VerificarClienteExistente(razaoSocial, cnpj))
            {
                MessageBox.Show("A razão social ou CNPJ já estão cadastrados.", "Cliente já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CadastrarCliente(razaoSocial, cnpj);
        }

        private bool VerificarClienteExistente(string razaoSocial, string cnpj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM cliente WHERE Nome = @RazaoSocial OR CnpjCliente = @Cnpj";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RazaoSocial", razaoSocial);
                    command.Parameters.AddWithValue("@Cnpj", cnpj);
                    int count = (int)command.ExecuteScalar();
                    return count > 0; 
                }
            }
        }

        private void CadastrarCliente(string razaoSocial, string cnpj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("CadastroCliente", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RazaoSocial", razaoSocial);
                        command.Parameters.AddWithValue("@Cnpj", cnpj);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 14)
            {
                textBox2.Text = textBox2.Text.Substring(0, 14);
            }
        }

        private bool ValidarCnpj(string cnpj)
        {
            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                return false;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCnpj, digito;
            int soma, resto;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
