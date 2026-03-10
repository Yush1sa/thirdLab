namespace thirdLab
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            FirstVecX = new TextBox();
            FirstVecY = new TextBox();
            FirstVecZ = new TextBox();
            SecondVecZ = new TextBox();
            SecondVecY = new TextBox();
            SecondVecX = new TextBox();
            result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbOperation = new ComboBox();
            LenFirstVec = new Label();
            LenSecondVec = new Label();
            SuspendLayout();
            // 
            // FirstVecX
            // 
            FirstVecX.Location = new Point(59, 26);
            FirstVecX.Margin = new Padding(3, 2, 3, 2);
            FirstVecX.Name = "FirstVecX";
            FirstVecX.Size = new Size(51, 23);
            FirstVecX.TabIndex = 0;
            FirstVecX.Text = "0";
            FirstVecX.TextChanged += onValueChanged;
            // 
            // FirstVecY
            // 
            FirstVecY.Location = new Point(127, 26);
            FirstVecY.Margin = new Padding(3, 2, 3, 2);
            FirstVecY.Name = "FirstVecY";
            FirstVecY.Size = new Size(51, 23);
            FirstVecY.TabIndex = 1;
            FirstVecY.Text = "0";
            FirstVecY.TextChanged += onValueChanged;
            // 
            // FirstVecZ
            // 
            FirstVecZ.Location = new Point(196, 26);
            FirstVecZ.Margin = new Padding(3, 2, 3, 2);
            FirstVecZ.Name = "FirstVecZ";
            FirstVecZ.Size = new Size(51, 23);
            FirstVecZ.TabIndex = 2;
            FirstVecZ.Text = "0";
            FirstVecZ.TextChanged += onValueChanged;
            // 
            // SecondVecZ
            // 
            SecondVecZ.Location = new Point(196, 53);
            SecondVecZ.Margin = new Padding(3, 2, 3, 2);
            SecondVecZ.Name = "SecondVecZ";
            SecondVecZ.Size = new Size(51, 23);
            SecondVecZ.TabIndex = 5;
            SecondVecZ.Text = "0";
            SecondVecZ.TextChanged += onValueChanged;
            // 
            // SecondVecY
            // 
            SecondVecY.Location = new Point(127, 53);
            SecondVecY.Margin = new Padding(3, 2, 3, 2);
            SecondVecY.Name = "SecondVecY";
            SecondVecY.Size = new Size(51, 23);
            SecondVecY.TabIndex = 4;
            SecondVecY.Text = "0";
            SecondVecY.TextChanged += onValueChanged;
            // 
            // SecondVecX
            // 
            SecondVecX.Location = new Point(59, 53);
            SecondVecX.Margin = new Padding(3, 2, 3, 2);
            SecondVecX.Name = "SecondVecX";
            SecondVecX.Size = new Size(51, 23);
            SecondVecX.TabIndex = 3;
            SecondVecX.Text = "0";
            SecondVecX.TextChanged += onValueChanged;
            // 
            // result
            // 
            result.Location = new Point(59, 90);
            result.Margin = new Padding(3, 2, 3, 2);
            result.Name = "result";
            result.Size = new Size(188, 23);
            result.TabIndex = 6;
            result.TextChanged += onValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 7);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 9;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 7);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 10;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 7);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 11;
            label3.Text = "z";
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "&" });
            cmbOperation.Location = new Point(12, 69);
            cmbOperation.Margin = new Padding(3, 2, 3, 2);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(41, 23);
            cmbOperation.TabIndex = 12;
            cmbOperation.Text = "+";
            cmbOperation.TextChanged += onValueChanged;
            // 
            // LenFirstVec
            // 
            LenFirstVec.AutoSize = true;
            LenFirstVec.Location = new Point(266, 29);
            LenFirstVec.Name = "LenFirstVec";
            LenFirstVec.Size = new Size(100, 15);
            LenFirstVec.TabIndex = 13;
            LenFirstVec.Text = "Длина вектора: 0";
            LenFirstVec.TextChanged += onValueChanged;
            // 
            // LenSecondVec
            // 
            LenSecondVec.AutoSize = true;
            LenSecondVec.Location = new Point(266, 56);
            LenSecondVec.Name = "LenSecondVec";
            LenSecondVec.Size = new Size(100, 15);
            LenSecondVec.TabIndex = 14;
            LenSecondVec.Text = "Длина вектора: 0";
            LenSecondVec.TextChanged += onValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 117);
            Controls.Add(LenSecondVec);
            Controls.Add(LenFirstVec);
            Controls.Add(cmbOperation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result);
            Controls.Add(SecondVecZ);
            Controls.Add(SecondVecY);
            Controls.Add(SecondVecX);
            Controls.Add(FirstVecZ);
            Controls.Add(FirstVecY);
            Controls.Add(FirstVecX);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox FirstVecX;
        private TextBox FirstVecY;
        private TextBox FirstVecZ;
        private TextBox SecondVecZ;
        private TextBox SecondVecY;
        private TextBox SecondVecX;
        private TextBox result;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbOperation;
        private Label LenFirstVec;
        private Label LenSecondVec;
    }
}
