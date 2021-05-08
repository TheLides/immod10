
namespace Lab10
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
            this.buttonFairDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerRoll = new System.Windows.Forms.Label();
            this.rivalRoll = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.buttonUnfairDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFairDice
            // 
            this.buttonFairDice.Location = new System.Drawing.Point(162, 328);
            this.buttonFairDice.Name = "buttonFairDice";
            this.buttonFairDice.Size = new System.Drawing.Size(184, 72);
            this.buttonFairDice.TabIndex = 0;
            this.buttonFairDice.Text = "Roll dice";
            this.buttonFairDice.UseVisualStyleBackColor = true;
            this.buttonFairDice.Click += new System.EventHandler(this.buttonFairDice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rival\'s result:";
            // 
            // playerRoll
            // 
            this.playerRoll.AutoSize = true;
            this.playerRoll.Location = new System.Drawing.Point(150, 41);
            this.playerRoll.Name = "playerRoll";
            this.playerRoll.Size = new System.Drawing.Size(16, 17);
            this.playerRoll.TabIndex = 3;
            this.playerRoll.Text = "0";
            // 
            // rivalRoll
            // 
            this.rivalRoll.AutoSize = true;
            this.rivalRoll.Location = new System.Drawing.Point(667, 42);
            this.rivalRoll.Name = "rivalRoll";
            this.rivalRoll.Size = new System.Drawing.Size(16, 17);
            this.rivalRoll.TabIndex = 4;
            this.rivalRoll.Text = "0";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(357, 218);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result";
            // 
            // buttonUnfairDice
            // 
            this.buttonUnfairDice.Location = new System.Drawing.Point(413, 328);
            this.buttonUnfairDice.Name = "buttonUnfairDice";
            this.buttonUnfairDice.Size = new System.Drawing.Size(184, 72);
            this.buttonUnfairDice.TabIndex = 9;
            this.buttonUnfairDice.Text = "Roll special dice";
            this.buttonUnfairDice.UseVisualStyleBackColor = true;
            this.buttonUnfairDice.Click += new System.EventHandler(this.buttonUnfairDice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUnfairDice);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rivalRoll);
            this.Controls.Add(this.playerRoll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFairDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFairDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerRoll;
        private System.Windows.Forms.Label rivalRoll;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button buttonUnfairDice;
    }
}

