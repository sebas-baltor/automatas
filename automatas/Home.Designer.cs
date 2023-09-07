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
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            ValidateBtn = new Button();
            SelectFileBtn = new Button();
            input = new TextBox();
            SelectedFileName = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 450);
            panel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 351);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 12;
            label15.Text = "q1 q2 q1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 336);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 11;
            label14.Text = "-- q1 q0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 321);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 10;
            label13.Text = "q2 q1 q2";
            // 
            // label12
            // 
            label12.Location = new Point(13, 260);
            label12.Name = "label12";
            label12.Size = new Size(321, 61);
            label12.TabIndex = 9;
            label12.Text = "Linea 5 en adelante: tabla de transiciones donde cada fila representa cada conjunto y cada columna tu alfabeto un \"--\" significa que no hay transicion debe estar separado por \" \"";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 231);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 8;
            label11.Text = "q2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 216);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 7;
            label10.Text = "Linea 4: estado final";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 178);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 6;
            label9.Text = "q0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 163);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 5;
            label8.Text = "Linea 3: estado inicial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 124);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 4;
            label7.Text = "a b c ó a,b,c";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 109);
            label6.Name = "label6";
            label6.Size = new Size(210, 15);
            label6.TabIndex = 3;
            label6.Text = "Linea 2: alfabeto, separado por \",\" o \" \"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 73);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 2;
            label5.Text = "q0 q1 q2 ó q0,q1,q2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 58);
            label4.Name = "label4";
            label4.Size = new Size(231, 15);
            label4.TabIndex = 1;
            label4.Text = "Linea 1: Tú conjunto, separado por \",\" o \" \"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 9);
            label3.Name = "label3";
            label3.Size = new Size(259, 25);
            label3.TabIndex = 0;
            label3.Text = "Estructura de tu archivo .txt";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}