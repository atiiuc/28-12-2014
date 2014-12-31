namespace ResultCalculationApp
{
    partial class ResultCalculatorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.physicsTextBox = new System.Windows.Forms.TextBox();
            this.chemistryTextBox = new System.Windows.Forms.TextBox();
            this.mathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.gradeLetterTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemistry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Math";
            // 
            // physicsTextBox
            // 
            this.physicsTextBox.Location = new System.Drawing.Point(105, 38);
            this.physicsTextBox.Name = "physicsTextBox";
            this.physicsTextBox.Size = new System.Drawing.Size(132, 20);
            this.physicsTextBox.TabIndex = 3;
            // 
            // chemistryTextBox
            // 
            this.chemistryTextBox.Location = new System.Drawing.Point(105, 72);
            this.chemistryTextBox.Name = "chemistryTextBox";
            this.chemistryTextBox.Size = new System.Drawing.Size(132, 20);
            this.chemistryTextBox.TabIndex = 4;
            // 
            // mathTextBox
            // 
            this.mathTextBox.Location = new System.Drawing.Point(105, 104);
            this.mathTextBox.Name = "mathTextBox";
            this.mathTextBox.Size = new System.Drawing.Size(132, 20);
            this.mathTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Grade Letter";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(105, 165);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(132, 20);
            this.averageTextBox.TabIndex = 3;
            // 
            // gradeLetterTextBox
            // 
            this.gradeLetterTextBox.Location = new System.Drawing.Point(105, 200);
            this.gradeLetterTextBox.Name = "gradeLetterTextBox";
            this.gradeLetterTextBox.Size = new System.Drawing.Size(132, 20);
            this.gradeLetterTextBox.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(255, 167);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(107, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "out of 100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "out of 100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "out of 100";
            // 
            // ResultCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 285);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.mathTextBox);
            this.Controls.Add(this.gradeLetterTextBox);
            this.Controls.Add(this.chemistryTextBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.physicsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultCalculatorUI";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox physicsTextBox;
        private System.Windows.Forms.TextBox chemistryTextBox;
        private System.Windows.Forms.TextBox mathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.TextBox gradeLetterTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

