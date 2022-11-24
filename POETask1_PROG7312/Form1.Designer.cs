namespace POETask1_PROG7312
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplacingBooks = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(334, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dewey Decimal System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReplacingBooks
            // 
            this.ReplacingBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReplacingBooks.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplacingBooks.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ReplacingBooks.Location = new System.Drawing.Point(434, 428);
            this.ReplacingBooks.Name = "ReplacingBooks";
            this.ReplacingBooks.Size = new System.Drawing.Size(224, 40);
            this.ReplacingBooks.TabIndex = 2;
            this.ReplacingBooks.Text = "Replacing books";
            this.ReplacingBooks.UseVisualStyleBackColor = true;
            this.ReplacingBooks.Click += new System.EventHandler(this.ReplacingBooks_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(434, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Identifying areas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.IdentifyingAreas_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(434, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Finding call numbers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Finding_Call_Numbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReplacingBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dewey Decimal System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplacingBooks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

