
namespace ProjetoDesk
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(91, 167);
            button1.Name = "button1";
            button1.Size = new Size(120, 51);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 12;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 9);
            label3.Name = "label3";
            label3.Size = new Size(240, 32);
            label3.TabIndex = 13;
            label3.Text = "Cadastro de produto";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(294, 242);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Terra Verde";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}