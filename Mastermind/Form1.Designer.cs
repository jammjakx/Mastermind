namespace Mastermind
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
            this.Guessbox1 = new System.Windows.Forms.TextBox();
            this.Checkbutton = new System.Windows.Forms.Button();
            this.Guessbox2 = new System.Windows.Forms.TextBox();
            this.Guessbox4 = new System.Windows.Forms.TextBox();
            this.Guessbox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guessbox1
            // 
            this.Guessbox1.Location = new System.Drawing.Point(12, 12);
            this.Guessbox1.Name = "Guessbox1";
            this.Guessbox1.Size = new System.Drawing.Size(23, 20);
            this.Guessbox1.TabIndex = 0;
            this.Guessbox1.TextChanged += new System.EventHandler(this.Guessbox1_TextChanged);
            // 
            // Checkbutton
            // 
            this.Checkbutton.Location = new System.Drawing.Point(12, 38);
            this.Checkbutton.Name = "Checkbutton";
            this.Checkbutton.Size = new System.Drawing.Size(75, 23);
            this.Checkbutton.TabIndex = 1;
            this.Checkbutton.Text = "Controleren";
            this.Checkbutton.UseVisualStyleBackColor = true;
            this.Checkbutton.Click += new System.EventHandler(this.Checkbutton_Click);
            // 
            // Guessbox2
            // 
            this.Guessbox2.Location = new System.Drawing.Point(41, 12);
            this.Guessbox2.Name = "Guessbox2";
            this.Guessbox2.Size = new System.Drawing.Size(23, 20);
            this.Guessbox2.TabIndex = 2;
            this.Guessbox2.TextChanged += new System.EventHandler(this.Guessbox2_TextChanged);
            // 
            // Guessbox4
            // 
            this.Guessbox4.Location = new System.Drawing.Point(99, 12);
            this.Guessbox4.Name = "Guessbox4";
            this.Guessbox4.Size = new System.Drawing.Size(23, 20);
            this.Guessbox4.TabIndex = 4;
            this.Guessbox4.TextChanged += new System.EventHandler(this.Guessbox4_TextChanged);
            // 
            // Guessbox3
            // 
            this.Guessbox3.Location = new System.Drawing.Point(70, 12);
            this.Guessbox3.Name = "Guessbox3";
            this.Guessbox3.Size = new System.Drawing.Size(23, 20);
            this.Guessbox3.TabIndex = 5;
            this.Guessbox3.TextChanged += new System.EventHandler(this.Guessbox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Guessbox3);
            this.Controls.Add(this.Guessbox4);
            this.Controls.Add(this.Guessbox2);
            this.Controls.Add(this.Checkbutton);
            this.Controls.Add(this.Guessbox1);
            this.Name = "Form1";
            this.Text = "Mastermind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Guessbox1;
        private System.Windows.Forms.Button Checkbutton;
        private System.Windows.Forms.TextBox Guessbox2;
        private System.Windows.Forms.TextBox Guessbox4;
        private System.Windows.Forms.TextBox Guessbox3;
    }
}

