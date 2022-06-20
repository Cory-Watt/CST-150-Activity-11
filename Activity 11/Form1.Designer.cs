namespace Activity_11
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RollDice = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.numOne = new System.Windows.Forms.Label();
            this.numTwo = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollDice
            // 
            this.RollDice.Location = new System.Drawing.Point(8, 12);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(174, 50);
            this.RollDice.TabIndex = 7;
            this.RollDice.Text = "Roll Dice!";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(8, 109);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(174, 45);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // numOne
            // 
            this.numOne.AutoSize = true;
            this.numOne.Location = new System.Drawing.Point(253, 12);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(0, 13);
            this.numOne.TabIndex = 9;
            // 
            // numTwo
            // 
            this.numTwo.AutoSize = true;
            this.numTwo.Location = new System.Drawing.Point(253, 49);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(0, 13);
            this.numTwo.TabIndex = 10;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(197, 109);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 11;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(197, 12);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(49, 13);
            this.l1.TabIndex = 12;
            this.l1.Text = "Die One:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Die Two: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RollDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label numOne;
        private System.Windows.Forms.Label numTwo;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label2;
    }
}

