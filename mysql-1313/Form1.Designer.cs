﻿namespace mysql_1313
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnElestiriForm = new System.Windows.Forms.Button();
            this.btnElestiri2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(12, 183);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.Size = new System.Drawing.Size(554, 155);
            this.dgwFilmler.TabIndex = 0;
            // 
            // btnElestiriForm
            // 
            this.btnElestiriForm.Location = new System.Drawing.Point(12, 115);
            this.btnElestiriForm.Name = "btnElestiriForm";
            this.btnElestiriForm.Size = new System.Drawing.Size(94, 62);
            this.btnElestiriForm.TabIndex = 1;
            this.btnElestiriForm.Text = "Eleştiri";
            this.btnElestiriForm.UseVisualStyleBackColor = true;
            this.btnElestiriForm.Click += new System.EventHandler(this.btnElestiriForm_Click);
            // 
            // btnElestiri2
            // 
            this.btnElestiri2.Location = new System.Drawing.Point(112, 115);
            this.btnElestiri2.Name = "btnElestiri2";
            this.btnElestiri2.Size = new System.Drawing.Size(94, 62);
            this.btnElestiri2.TabIndex = 2;
            this.btnElestiri2.Text = "Eleştiri2";
            this.btnElestiri2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 352);
            this.Controls.Add(this.btnElestiri2);
            this.Controls.Add(this.btnElestiriForm);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnElestiriForm;
        private System.Windows.Forms.Button btnElestiri2;
    }
}

