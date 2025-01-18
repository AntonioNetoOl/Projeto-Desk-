using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDesk
{
    public partial class Form6 : Form
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!decimal.TryParse(textBox3.Text, out decimal valorProduto))
            {
                MessageBox.Show("Por favor, insira um valor válido para o produto.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InserirProduto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NomeProduto", textBox1.Text);
                    command.Parameters.AddWithValue("@ValorProduto", valorProduto);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            textBox1.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_click(object sender, EventArgs e)
        {

        }
    }
}
