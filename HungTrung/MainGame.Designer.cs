namespace HungTrung
{
    partial class MainGame
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
            this.lbScores = new System.Windows.Forms.Label();
            this.lbobj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbScores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbScores.Location = new System.Drawing.Point(690, 21);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(70, 26);
            this.lbScores.TabIndex = 0;
            this.lbScores.Text = "label1";
            // 
            // lbobj
            // 
            this.lbobj.AutoSize = true;
            this.lbobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbobj.ForeColor = System.Drawing.Color.White;
            this.lbobj.Location = new System.Drawing.Point(695, 74);
            this.lbobj.Name = "lbobj";
            this.lbobj.Size = new System.Drawing.Size(70, 26);
            this.lbobj.TabIndex = 1;
            this.lbobj.Text = "label1";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbobj);
            this.Controls.Add(this.lbScores);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGame";
            this.Text = "Hứng Trứng";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.Label lbobj;
    }
}

