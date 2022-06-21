
namespace _03_PersonelEkleme
{
    partial class Form2
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
            this.grpKayit = new System.Windows.Forms.GroupBox();
            this.lblKayit = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.grpKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKayit
            // 
            this.grpKayit.Controls.Add(this.lblKayit);
            this.grpKayit.Location = new System.Drawing.Point(40, 27);
            this.grpKayit.Name = "grpKayit";
            this.grpKayit.Size = new System.Drawing.Size(350, 233);
            this.grpKayit.TabIndex = 0;
            this.grpKayit.TabStop = false;
            this.grpKayit.Text = "Kayıtlar";
            // 
            // lblKayit
            // 
            this.lblKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKayit.Location = new System.Drawing.Point(6, 25);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(324, 188);
            this.lblKayit.TabIndex = 0;
            // 
            // btnIleri
            // 
            this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Location = new System.Drawing.Point(301, 291);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(89, 50);
            this.btnIleri.TabIndex = 1;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle2.Location = new System.Drawing.Point(173, 291);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(89, 50);
            this.btnTemizle2.TabIndex = 2;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(40, 291);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(89, 50);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(40, 358);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(350, 40);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Kayıt Ekranına Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnTemizle2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.grpKayit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpKayit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKayit;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGeriDon;
    }
}