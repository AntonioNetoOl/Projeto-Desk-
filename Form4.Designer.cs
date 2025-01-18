namespace ProjetoDesk
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(233, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 239);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 114);
            label4.Name = "label4";
            label4.Size = new Size(91, 13);
            label4.TabIndex = 8;
            label4.Text = "somente números";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(123, 174);
            button1.Name = "button1";
            button1.Size = new Size(161, 41);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 6;
            label3.Text = "CNPJ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 54);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 5;
            label2.Text = "Razão social";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de clientes";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 478);
            Controls.Add(button2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Terra Verde";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label4;
    }
}