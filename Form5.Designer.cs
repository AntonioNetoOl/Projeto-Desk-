namespace ProjetoDesk
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            button3 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
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
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(217, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 408);
            panel1.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(20, 269);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 23);
            comboBox3.TabIndex = 17;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(224, 128);
            button3.Name = "button3";
            button3.Size = new Size(43, 23);
            button3.TabIndex = 16;
            button3.Text = "Novo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(198, 23);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 64);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 13;
            label6.Text = "Razão social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 203);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 11;
            label5.Text = "Valor total";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 249);
            label4.Name = "label4";
            label4.Size = new Size(135, 17);
            label4.TabIndex = 10;
            label4.Text = "Forma de pagamento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(123, 339);
            button1.Name = "button1";
            button1.Size = new Size(161, 41);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 6;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 108);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 5;
            label2.Text = "Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 12);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de vendas";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(848, 485);
            Controls.Add(button2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Terra Verde";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Button button3;
        private ComboBox comboBox3;
    }
}