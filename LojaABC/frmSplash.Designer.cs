
namespace LojaABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctLOGO = new System.Windows.Forms.PictureBox();
            this.lgbNumero = new System.Windows.Forms.Label();
            this.lgbPorcentagem = new System.Windows.Forms.Label();
            this.PGB = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLOGO
            // 
            this.pctLOGO.Image = ((System.Drawing.Image)(resources.GetObject("pctLOGO.Image")));
            this.pctLOGO.Location = new System.Drawing.Point(288, 155);
            this.pctLOGO.Name = "pctLOGO";
            this.pctLOGO.Size = new System.Drawing.Size(266, 202);
            this.pctLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLOGO.TabIndex = 0;
            this.pctLOGO.TabStop = false;
            // 
            // lgbNumero
            // 
            this.lgbNumero.AutoSize = true;
            this.lgbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lgbNumero.Location = new System.Drawing.Point(402, 360);
            this.lgbNumero.Name = "lgbNumero";
            this.lgbNumero.Size = new System.Drawing.Size(18, 20);
            this.lgbNumero.TabIndex = 1;
            this.lgbNumero.Text = "0";
            this.lgbNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lgbPorcentagem
            // 
            this.lgbPorcentagem.AutoSize = true;
            this.lgbPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lgbPorcentagem.Location = new System.Drawing.Point(415, 360);
            this.lgbPorcentagem.Name = "lgbPorcentagem";
            this.lgbPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lgbPorcentagem.TabIndex = 2;
            this.lgbPorcentagem.Text = "%";
            this.lgbPorcentagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // PGB
            // 
            this.PGB.Location = new System.Drawing.Point(288, 383);
            this.PGB.Name = "PGB";
            this.PGB.Size = new System.Drawing.Size(266, 25);
            this.PGB.TabIndex = 3;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PGB);
            this.Controls.Add(this.lgbPorcentagem);
            this.Controls.Add(this.lgbNumero);
            this.Controls.Add(this.pctLOGO);
            this.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.Text = "b";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLOGO;
        private System.Windows.Forms.Label lgbNumero;
        private System.Windows.Forms.Label lgbPorcentagem;
        private System.Windows.Forms.ProgressBar PGB;
    }
}