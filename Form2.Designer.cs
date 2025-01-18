namespace ProjetoDesk
{
    partial class Form2
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(195, 67);
            button1.TabIndex = 0;
            button1.Text = "Insumos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(222, 272);
            button2.Name = "button2";
            button2.Size = new Size(195, 67);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(437, 272);
            button3.Name = "button3";
            button3.Size = new Size(195, 67);
            button3.TabIndex = 2;
            button3.Text = "Efetuar vendas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(651, 272);
            button4.Name = "button4";
            button4.Size = new Size(195, 67);
            button4.TabIndex = 3;
            button4.Text = "Relatório";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(858, 488);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Terra Verde";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}