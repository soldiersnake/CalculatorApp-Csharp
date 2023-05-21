namespace Calculator
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
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnOpAdd = new Button();
            btnOpSubs = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnOpMult = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnOpDiv = new Button();
            btnEquals = new Button();
            btnNum0 = new Button();
            btnClear = new Button();
            txtValue = new TextBox();
            SuspendLayout();
            // 
            // btnNum7
            // 
            btnNum7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum7.Location = new Point(32, 102);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(112, 89);
            btnNum7.TabIndex = 0;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += NumberAction_Click;
            // 
            // btnNum8
            // 
            btnNum8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum8.Location = new Point(150, 102);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(112, 89);
            btnNum8.TabIndex = 1;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += NumberAction_Click;
            // 
            // btnNum9
            // 
            btnNum9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum9.Location = new Point(268, 102);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(112, 89);
            btnNum9.TabIndex = 2;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += NumberAction_Click;
            // 
            // btnOpAdd
            // 
            btnOpAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpAdd.Location = new Point(386, 102);
            btnOpAdd.Name = "btnOpAdd";
            btnOpAdd.Size = new Size(112, 89);
            btnOpAdd.TabIndex = 3;
            btnOpAdd.Text = "+";
            btnOpAdd.UseVisualStyleBackColor = true;
            btnOpAdd.Click += OperatorAction_Click;
            // 
            // btnOpSubs
            // 
            btnOpSubs.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpSubs.Location = new Point(386, 197);
            btnOpSubs.Name = "btnOpSubs";
            btnOpSubs.Size = new Size(112, 89);
            btnOpSubs.TabIndex = 7;
            btnOpSubs.Text = "-";
            btnOpSubs.UseVisualStyleBackColor = true;
            btnOpSubs.Click += OperatorAction_Click;
            // 
            // btnNum6
            // 
            btnNum6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum6.Location = new Point(268, 197);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(112, 89);
            btnNum6.TabIndex = 6;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += NumberAction_Click;
            // 
            // btnNum5
            // 
            btnNum5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum5.Location = new Point(150, 197);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(112, 89);
            btnNum5.TabIndex = 5;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += NumberAction_Click;
            // 
            // btnNum4
            // 
            btnNum4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum4.Location = new Point(32, 197);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(112, 89);
            btnNum4.TabIndex = 4;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += NumberAction_Click;
            // 
            // btnOpMult
            // 
            btnOpMult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpMult.Location = new Point(386, 292);
            btnOpMult.Name = "btnOpMult";
            btnOpMult.Size = new Size(112, 89);
            btnOpMult.TabIndex = 11;
            btnOpMult.Text = "*";
            btnOpMult.UseVisualStyleBackColor = true;
            btnOpMult.Click += OperatorAction_Click;
            // 
            // btnNum3
            // 
            btnNum3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum3.Location = new Point(268, 292);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(112, 89);
            btnNum3.TabIndex = 10;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += NumberAction_Click;
            // 
            // btnNum2
            // 
            btnNum2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum2.Location = new Point(150, 292);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(112, 89);
            btnNum2.TabIndex = 9;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += NumberAction_Click;
            // 
            // btnNum1
            // 
            btnNum1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum1.Location = new Point(32, 292);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(112, 89);
            btnNum1.TabIndex = 8;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += NumberAction_Click;
            // 
            // btnOpDiv
            // 
            btnOpDiv.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpDiv.Location = new Point(386, 387);
            btnOpDiv.Name = "btnOpDiv";
            btnOpDiv.Size = new Size(112, 89);
            btnOpDiv.TabIndex = 15;
            btnOpDiv.Text = "/";
            btnOpDiv.UseVisualStyleBackColor = true;
            btnOpDiv.Click += OperatorAction_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(268, 387);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(112, 89);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnNum0
            // 
            btnNum0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum0.Location = new Point(150, 387);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(112, 89);
            btnNum0.TabIndex = 13;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(32, 387);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 89);
            btnClear.TabIndex = 12;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtValue.Location = new Point(32, 33);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(466, 43);
            txtValue.TabIndex = 16;
            txtValue.Text = "0";
            txtValue.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 508);
            Controls.Add(txtValue);
            Controls.Add(btnOpDiv);
            Controls.Add(btnEquals);
            Controls.Add(btnNum0);
            Controls.Add(btnClear);
            Controls.Add(btnOpMult);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnOpSubs);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnOpAdd);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnOpAdd;
        private Button btnOpSubs;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnOpMult;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnOpDiv;
        private Button btnEquals;
        private Button btnNum0;
        private Button btnClear;
        private TextBox txtValue;
    }
}