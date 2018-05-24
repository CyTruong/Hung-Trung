namespace HungTrung
{
    partial class AddHightsScore
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScores.Location = new System.Drawing.Point(78, 23);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(125, 33);
            this.lbScores.TabIndex = 0;
            this.lbScores.Text = "SCORES :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(55, 106);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(243, 20);
            this.tbname.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddHightsScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbScores);
            this.Name = "AddHightsScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddHightsScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button button1;
    }
}