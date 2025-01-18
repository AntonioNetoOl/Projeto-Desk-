using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDesk
{
    public partial class Form5 : Form
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";

        public Form5()
        {
            InitializeComponent();
            LoadClientes();
            LoadProdutos();
            LoadFormasPagamento();
            this.FormClosing += Form5_FormClosing;
        }

        
        private void LoadClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Nome FROM cliente", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Nome"].ToString());
                    }
                }
            }
        }

        
        private void LoadProdutos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT NomeProduto FROM produto", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["NomeProduto"].ToString());
                    }
                }
            }
        }

        
        private void LoadFormasPagamento()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT FormaPagamento FROM FormaPagamento", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["FormaPagamento"].ToString());
                    }
                }
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduto = comboBox2.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedProduto))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ValorProduto FROM produto WHERE NomeProduto = @NomeProduto", connection))
                    {
                        command.Parameters.AddWithValue("@NomeProduto", selectedProduto);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            decimal valorProduto = Convert.ToDecimal(result);
                            if (int.TryParse(textBox3.Text, out int quantidade))
                            {
                                textBox4.Text = (valorProduto * quantidade).ToString("F2");
                            }
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && int.TryParse(textBox3.Text, out int quantidade))
            {
                comboBox2_SelectedIndexChanged(sender, e);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cliente = comboBox1.SelectedItem.ToString();
            string produto = comboBox2.SelectedItem.ToString();
            int quantidade = int.Parse(textBox3.Text);
            decimal valorTotal = decimal.Parse(textBox4.Text);
            string formaPagamento = comboBox3.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("RegistrarVenda", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NomeCliente", cliente);
                    command.Parameters.AddWithValue("@Produto", produto);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@ValorTotal", valorTotal);
                    command.Parameters.AddWithValue("@FormaPagamento", formaPagamento);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Venda registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
