namespace Evaluator.UI.Windows
{
    partial class Form1
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
            txtDisplay = new TextBox();
            label1 = new Label();
            btnPunto = new Button();
            btnZero = new Button();
            btnEquals = new Button();
            btnDelete = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnClear = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnPC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPA = new Button();
            btnDivision = new Button();
            btnMultiplicacion = new Button();
            btnPotencia = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDisplay.BackColor = Color.Silver;
            txtDisplay.Location = new Point(2, 72);
            txtDisplay.Margin = new Padding(4, 5, 4, 5);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(374, 26);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 35);
            label1.TabIndex = 1;
            label1.Text = "Evaluator";
            // 
            // btnPunto
            // 
            btnPunto.Anchor = AnchorStyles.Bottom;
            btnPunto.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(2, 398);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(70, 60);
            btnPunto.TabIndex = 2;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnZero
            // 
            btnZero.Anchor = AnchorStyles.Bottom;
            btnZero.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(78, 398);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(70, 60);
            btnZero.TabIndex = 3;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnEquals
            // 
            btnEquals.Anchor = AnchorStyles.Bottom;
            btnEquals.BackColor = Color.LightSeaGreen;
            btnEquals.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(154, 398);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 60);
            btnEquals.TabIndex = 4;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(230, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 60);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Bottom;
            btn1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(2, 330);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 60);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Bottom;
            btn2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(78, 330);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 60);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Bottom;
            btn3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(154, 330);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 60);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.Crimson;
            btnClear.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(308, 132);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 258);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Bottom;
            btn4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(2, 264);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 60);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Bottom;
            btn5.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(78, 263);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 60);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Bottom;
            btn6.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(154, 264);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 60);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnPC
            // 
            btnPC.Anchor = AnchorStyles.Bottom;
            btnPC.BackColor = Color.Gold;
            btnPC.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPC.Location = new Point(78, 132);
            btnPC.Name = "btnPC";
            btnPC.Size = new Size(70, 60);
            btnPC.TabIndex = 13;
            btnPC.Text = ")";
            btnPC.UseVisualStyleBackColor = false;
            btnPC.Click += btnPC_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Bottom;
            btn7.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(2, 198);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 60);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Bottom;
            btn8.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(78, 198);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 60);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Bottom;
            btn9.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(154, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 60);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnPA
            // 
            btnPA.Anchor = AnchorStyles.Bottom;
            btnPA.BackColor = Color.Gold;
            btnPA.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPA.Location = new Point(2, 132);
            btnPA.Name = "btnPA";
            btnPA.Size = new Size(70, 60);
            btnPA.TabIndex = 17;
            btnPA.Text = "(";
            btnPA.UseVisualStyleBackColor = false;
            btnPA.Click += btnPA_Click;
            // 
            // btnDivision
            // 
            btnDivision.Anchor = AnchorStyles.Bottom;
            btnDivision.BackColor = Color.Gold;
            btnDivision.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(231, 132);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(70, 60);
            btnDivision.TabIndex = 18;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Anchor = AnchorStyles.Bottom;
            btnMultiplicacion.BackColor = Color.Gold;
            btnMultiplicacion.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacion.Location = new Point(231, 198);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(70, 60);
            btnMultiplicacion.TabIndex = 19;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Anchor = AnchorStyles.Bottom;
            btnPotencia.BackColor = Color.Gold;
            btnPotencia.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(154, 132);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(70, 60);
            btnPotencia.TabIndex = 20;
            btnPotencia.Text = "^";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnResta
            // 
            btnResta.Anchor = AnchorStyles.Bottom;
            btnResta.BackColor = Color.Gold;
            btnResta.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(230, 264);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(70, 60);
            btnResta.TabIndex = 21;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnSuma
            // 
            btnSuma.Anchor = AnchorStyles.Bottom;
            btnSuma.BackColor = Color.Gold;
            btnSuma.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(231, 332);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(70, 60);
            btnSuma.TabIndex = 22;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(383, 470);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnPotencia);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnDivision);
            Controls.Add(btnPA);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPC);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnClear);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDelete);
            Controls.Add(btnEquals);
            Controls.Add(btnZero);
            Controls.Add(btnPunto);
            Controls.Add(label1);
            Controls.Add(txtDisplay);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Funtion Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Label label1;
        private Button btnPunto;
        private Button btnZero;
        private Button btnEquals;
        private Button btnDelete;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnClear;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnPC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPA;
        private Button btnDivision;
        private Button btnMultiplicacion;
        private Button btnPotencia;
        private Button btnResta;
        private Button btnSuma;
    }
}
