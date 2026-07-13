namespace Project_30___Simple_Calculator_Form__
{
    partial class frmSimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleCalculator));
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeTheme.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangeTheme.FlatAppearance.BorderSize = 5;
            this.btnChangeTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChangeTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTheme.ForeColor = System.Drawing.Color.Green;
            this.btnChangeTheme.Location = new System.Drawing.Point(12, 733);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(132, 100);
            this.btnChangeTheme.TabIndex = 0;
            this.btnChangeTheme.Tag = "ChangeTheme";
            this.btnChangeTheme.Text = "Change Theme";
            this.btnChangeTheme.UseVisualStyleBackColor = false;
            this.btnChangeTheme.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 5;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Green;
            this.btn0.Location = new System.Drawing.Point(170, 733);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(132, 100);
            this.btn0.TabIndex = 1;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPoint.FlatAppearance.BorderSize = 5;
            this.btnPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.Green;
            this.btnPoint.Location = new System.Drawing.Point(328, 733);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(132, 100);
            this.btnPoint.TabIndex = 2;
            this.btnPoint.Tag = ".";
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Green;
            this.btnEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.BorderSize = 5;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(486, 733);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(132, 100);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Tag = "=";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Green;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 5;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(486, 607);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(132, 100);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 5;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Green;
            this.btn3.Location = new System.Drawing.Point(328, 607);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(132, 100);
            this.btn3.TabIndex = 6;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 5;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Green;
            this.btn2.Location = new System.Drawing.Point(170, 607);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(132, 100);
            this.btn2.TabIndex = 5;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 5;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Green;
            this.btn1.Location = new System.Drawing.Point(12, 607);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(132, 100);
            this.btn1.TabIndex = 4;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Green;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.BorderSize = 5;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(486, 481);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(132, 100);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Tag = "-";
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 5;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Green;
            this.btn6.Location = new System.Drawing.Point(328, 481);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(132, 100);
            this.btn6.TabIndex = 10;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 5;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Green;
            this.btn5.Location = new System.Drawing.Point(170, 481);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(132, 100);
            this.btn5.TabIndex = 9;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 5;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Green;
            this.btn4.Location = new System.Drawing.Point(12, 481);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(132, 100);
            this.btn4.TabIndex = 8;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Green;
            this.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.BorderSize = 5;
            this.btnMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(486, 355);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(132, 100);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Tag = "×";
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 5;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Green;
            this.btn9.Location = new System.Drawing.Point(328, 355);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(132, 100);
            this.btn9.TabIndex = 14;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 5;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Green;
            this.btn8.Location = new System.Drawing.Point(170, 355);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(132, 100);
            this.btn8.TabIndex = 13;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 5;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Green;
            this.btn7.Location = new System.Drawing.Point(12, 355);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(132, 100);
            this.btn7.TabIndex = 12;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Green;
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.BorderSize = 5;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(486, 229);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(132, 100);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Tag = "÷";
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.Green;
            this.btnPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPercentage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPercentage.FlatAppearance.BorderSize = 5;
            this.btnPercentage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPercentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(328, 229);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(132, 100);
            this.btnPercentage.TabIndex = 18;
            this.btnPercentage.Tag = "%";
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(170, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 100);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Green;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 5;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 100);
            this.btnClear.TabIndex = 16;
            this.btnClear.Tag = "Clear";
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.Black;
            this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.ForeColor = System.Drawing.Color.White;
            this.txtScreen.Location = new System.Drawing.Point(10, 12);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScreen.Size = new System.Drawing.Size(607, 202);
            this.txtScreen.TabIndex = 20;
            this.txtScreen.WordWrap = false;
            // 
            // frmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 845);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnChangeTheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimpleCalculator";
            this.Text = "Simple Calculator Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeTheme;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtScreen;
    }
}

