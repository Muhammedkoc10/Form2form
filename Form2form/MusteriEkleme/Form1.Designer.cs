
namespace MusteriEkleme
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
            this.lbxMusteriler = new System.Windows.Forms.ListBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMusteriler
            // 
            this.lbxMusteriler.FormattingEnabled = true;
            this.lbxMusteriler.Location = new System.Drawing.Point(75, 27);
            this.lbxMusteriler.Name = "lbxMusteriler";
            this.lbxMusteriler.Size = new System.Drawing.Size(350, 290);
            this.lbxMusteriler.TabIndex = 0;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Location = new System.Drawing.Point(75, 334);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(350, 64);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "YENİ MÜŞTERİ EKLE";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lbxMusteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMusteriler;
        private System.Windows.Forms.Button btnYeniMusteri;
    }
}

