namespace automatas
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            ValidateBtn = new Button();
            SelectFileBtn = new Button();
            input = new TextBox();
            SelectedFileName = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ValidateBtn);
            panel2.Controls.Add(SelectFileBtn);
            panel2.Controls.Add(input);
            panel2.Controls.Add(SelectedFileName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(340, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 450);
            panel2.TabIndex = 1;
            // 
            // ValidateBtn
            // 
            ValidateBtn.Location = new Point(295, 198);
            ValidateBtn.Name = "ValidateBtn";
            ValidateBtn.Size = new Size(75, 23);
            ValidateBtn.TabIndex = 5;
            ValidateBtn.Text = "Validar";
            ValidateBtn.UseVisualStyleBackColor = true;
            ValidateBtn.Click += ValidateBtn_Click;
            // 
            // SelectFileBtn
            // 
            SelectFileBtn.Location = new Point(295, 64);
            SelectFileBtn.Name = "SelectFileBtn";
            SelectFileBtn.Size = new Size(75, 23);
            SelectFileBtn.TabIndex = 4;
            SelectFileBtn.Text = "Seleccionar";
            SelectFileBtn.UseVisualStyleBackColor = true;
            SelectFileBtn.Click += SelectFileBtn_Click;
            // 
            // input
            // 
            input.Location = new Point(53, 198);
            input.Name = "input";
            input.Size = new Size(206, 23);
            input.TabIndex = 3;
            // 
            // SelectedFileName
            // 
            SelectedFileName.AutoSize = true;
            SelectedFileName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            SelectedFileName.Location = new Point(53, 72);
            SelectedFileName.Name = "SelectedFileName";
            SelectedFileName.Size = new Size(157, 15);
            SelectedFileName.TabIndex = 2;
            SelectedFileName.Text = "Ningun archivo seleccionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 180);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cadena";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 56);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Archivo seleccionado:";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ValidateBtn;
        private Button SelectFileBtn;
        private TextBox input;
        private Label SelectedFileName;
        private Label label2;
        private Label label1;
    }
}