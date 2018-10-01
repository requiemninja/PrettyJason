namespace PrettyJason
{
    partial class Main
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
            this.uglyTextBox = new System.Windows.Forms.TextBox();
            this.prettyTextBox = new System.Windows.Forms.TextBox();
            this.prettyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uglyTextBox
            // 
            this.uglyTextBox.Location = new System.Drawing.Point(12, 12);
            this.uglyTextBox.Multiline = true;
            this.uglyTextBox.Name = "uglyTextBox";
            this.uglyTextBox.Size = new System.Drawing.Size(709, 59);
            this.uglyTextBox.TabIndex = 0;
            // 
            // prettyTextBox
            // 
            this.prettyTextBox.Location = new System.Drawing.Point(12, 77);
            this.prettyTextBox.Multiline = true;
            this.prettyTextBox.Name = "prettyTextBox";
            this.prettyTextBox.Size = new System.Drawing.Size(709, 400);
            this.prettyTextBox.TabIndex = 1;
            // 
            // prettyButton
            // 
            this.prettyButton.Location = new System.Drawing.Point(321, 483);
            this.prettyButton.Name = "prettyButton";
            this.prettyButton.Size = new System.Drawing.Size(75, 23);
            this.prettyButton.TabIndex = 2;
            this.prettyButton.Text = "Prettify";
            this.prettyButton.UseVisualStyleBackColor = true;
            this.prettyButton.Click += new System.EventHandler(this.prettyButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 513);
            this.Controls.Add(this.prettyButton);
            this.Controls.Add(this.prettyTextBox);
            this.Controls.Add(this.uglyTextBox);
            this.Name = "Main";
            this.Text = "Json Prettifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uglyTextBox;
        private System.Windows.Forms.TextBox prettyTextBox;
        private System.Windows.Forms.Button prettyButton;
    }
}

