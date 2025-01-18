namespace ProjetoDesk
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(253, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 265);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 137);
            label4.Name = "label4";
            label4.Size = new Size(133, 17);
            label4.TabIndex = 7;
            label4.Text = "Nome do fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 70);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 6;
            label3.Text = "Nome do insumo";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(103, 199);
            button2.Name = "button2";
            button2.Size = new Size(161, 41);
            button2.TabIndex = 4;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(63, 11);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastre seus insumos";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 473);
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Terra Verde";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}
