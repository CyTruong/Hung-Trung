namespace HungTrung
{
    partial class Highscorses
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
            this.lvHightScores = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".Vn3DH", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGH SCORE";
            // 
            // lvHightScores
            // 
            this.lvHightScores.Location = new System.Drawing.Point(13, 91);
            this.lvHightScores.Name = "lvHightScores";
            this.lvHightScores.Size = new System.Drawing.Size(267, 249);
            this.lvHightScores.TabIndex = 2;
            this.lvHightScores.UseCompatibleStateImageBehavior = false;
            this.lvHightScores.View = System.Windows.Forms.View.Details;
            // 
            // Highscorses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 352);
            this.Controls.Add(this.lvHightScores);
            this.Controls.Add(this.label1);
            this.Name = "Highscorses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Highscorses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHightScores;
    }
}