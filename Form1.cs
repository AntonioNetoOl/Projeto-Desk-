using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoDesk
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=pim_scripts;User Id=Terraverde.unip.pim;Password=Unip1234;";


        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senha = textBox2.Text;

            if (ValidateUser(email, senha))
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }

        private bool ValidateUser(string email, string senha)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE email = @Email AND senha = HASHBYTES('SHA2_256', CONVERT(varchar(100), @Senha))";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(194, 399);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(194, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(395, 399);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(395, 417);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(622, 410);
            button1.Name = "button1";
            button1.Size = new Size(147, 36);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // Form1
            // 
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 463);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Terra Verde";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Resize(object sender, EventArgs e)
        {


            textBox2.Location = new Point(this.ClientSize.Width - textBox2.Width - 20, this.ClientSize.Height - textBox2.Height - 20);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}