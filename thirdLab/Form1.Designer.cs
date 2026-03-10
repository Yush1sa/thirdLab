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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // FirstVecX
            // 
            FirstVecX.Location = new Point(119, 35);
            FirstVecX.Name = "FirstVecX";
            FirstVecX.Size = new Size(46, 27);
            FirstVecX.TabIndex = 0;
            FirstVecX.Text = "0";
            // 
            // FirstVecY
            // 
            FirstVecY.Location = new Point(171, 35);
            FirstVecY.Name = "FirstVecY";
            FirstVecY.Size = new Size(46, 27);
            FirstVecY.TabIndex = 1;
            FirstVecY.Text = "0";
            // 
            // FirstVecZ
            // 
            FirstVecZ.Location = new Point(223, 35);
            FirstVecZ.Name = "FirstVecZ";
            FirstVecZ.Size = new Size(46, 27);
            FirstVecZ.TabIndex = 2;
            FirstVecZ.Text = "0";
            // 
            // SecondVecZ
            // 
            SecondVecZ.Location = new Point(223, 68);
            SecondVecZ.Name = "SecondVecZ";
            SecondVecZ.Size = new Size(46, 27);
            SecondVecZ.TabIndex = 5;
            SecondVecZ.Text = "0";
            // 
            // SecondVecY
            // 
            SecondVecY.Location = new Point(171, 68);
            SecondVecY.Name = "SecondVecY";
            SecondVecY.Size = new Size(46, 27);
            SecondVecY.TabIndex = 4;
            SecondVecY.Text = "0";
            // 
            // SecondVecX
            // 
            SecondVecX.Location = new Point(119, 68);
            SecondVecX.Name = "SecondVecX";
            SecondVecX.Size = new Size(46, 27);
            SecondVecX.TabIndex = 3;
            SecondVecX.Text = "0";
            // 
            // result
            // 
            result.Location = new Point(119, 120);
            result.Name = "result";
            result.Size = new Size(150, 27);
            result.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 9;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 9);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 10;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 9);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 11;
            label3.Text = "z";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(46, 28);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 156);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
    }
}
