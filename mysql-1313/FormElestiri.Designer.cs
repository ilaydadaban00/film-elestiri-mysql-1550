namespace mysql_1313
{
    partial class FormElestiri
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnElestiri = new System.Windows.Forms.Button();
            this.btnElestiri2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(4, 183);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.Size = new System.Drawing.Size(585, 192);
            this.dgwFilmler.TabIndex = 0;
            // 
            // btnElestiri
            // 
            this.btnElestiri.Location = new System.Drawing.Point(4, 123);
            this.btnElestiri.Name = "btnElestiri";
            this.btnElestiri.Size = new System.Drawing.Size(92, 54);
            this.btnElestiri.TabIndex = 1;
            this.btnElestiri.Text = "Eleştiri";
            this.btnElestiri.UseVisualStyleBackColor = true;
            this.btnElestiri.Click += new System.EventHandler(this.btnElestiri_Click);
            // 
            // btnElestiri2
            // 
            this.btnElestiri2.Location = new System.Drawing.Point(102, 123);
            this.btnElestiri2.Name = "btnElestiri2";
            this.btnElestiri2.Size = new System.Drawing.Size(92, 54);
            this.btnElestiri2.TabIndex = 2;
            this.btnElestiri2.Text = "Eleştiri2";
            this.btnElestiri2.UseVisualStyleBackColor = true;
            // 
            // FormElestiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 394);
            this.Controls.Add(this.btnElestiri2);
            this.Controls.Add(this.btnElestiri);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "FormElestiri";
            this.Text = "FormElestiri";
            this.Load += new System.EventHandler(this.FormElestiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnElestiri;
        private System.Windows.Forms.Button btnElestiri2;
    }
}