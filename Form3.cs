using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDesk
{
    public partial class Form3 : Form
    {

        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";

        
        
        

        public Form3()
        {
            InitializeComponent();
            
            this.FormClosing += Form3_FormClosing;
        }

       



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }




        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string nomeInsumo = textBox2.Text;
            string origem = textBox3.Text;


            InserirInsumo(nomeInsumo, origem);
        }


        private void InserirInsumo(string nomeInsumo, string origem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("InserirInsumo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@NomeInsumo", nomeInsumo);
                        command.Parameters.AddWithValue("@Origem", origem);


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Insumo registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao registrar insumo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
