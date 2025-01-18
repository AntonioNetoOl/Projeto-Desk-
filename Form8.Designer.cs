namespace ProjetoDesk
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(250, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 245);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(77, 91);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Data início ";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(97, 176);
            button1.Name = "button1";
            button1.Size = new Size(180, 48);
            button1.TabIndex = 8;
            button1.Text = "Emitir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 15);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 1;
            label1.Text = "Relatório";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(77, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(891, 502);
            Controls.Add(button2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            Text = "Terra Verde";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label2;
        private Button button1;
    }
}