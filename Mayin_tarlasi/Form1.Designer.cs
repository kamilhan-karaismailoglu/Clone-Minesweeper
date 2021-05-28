
namespace Mayin_tarlasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTarla = new System.Windows.Forms.Panel();
            this.labelMayinSayisi = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelMinus = new System.Windows.Forms.Label();
            this.textBoxMinus = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelÜst = new System.Windows.Forms.Panel();
            this.panelSagSayac = new System.Windows.Forms.Panel();
            this.labelSaniye = new System.Windows.Forms.Label();
            this.panelSolSayac = new System.Windows.Forms.Panel();
            this.buttonFace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSS = new System.Windows.Forms.Button();
            this.panelÜst.SuspendLayout();
            this.panelSagSayac.SuspendLayout();
            this.panelSolSayac.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTarla
            // 
            this.panelTarla.BackColor = System.Drawing.SystemColors.Control;
            this.panelTarla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.panelTarla.Location = new System.Drawing.Point(5, 113);
            this.panelTarla.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelTarla.Name = "panelTarla";
            this.panelTarla.Size = new System.Drawing.Size(406, 285);
            this.panelTarla.TabIndex = 0;
            // 
            // labelMayinSayisi
            // 
            this.labelMayinSayisi.AutoSize = true;
            this.labelMayinSayisi.Font = new System.Drawing.Font("Digiface", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMayinSayisi.ForeColor = System.Drawing.Color.Red;
            this.labelMayinSayisi.Location = new System.Drawing.Point(-4, -3);
            this.labelMayinSayisi.Name = "labelMayinSayisi";
            this.labelMayinSayisi.Size = new System.Drawing.Size(85, 49);
            this.labelMayinSayisi.TabIndex = 0;
            this.labelMayinSayisi.Text = "000";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWidth.Location = new System.Drawing.Point(9, 20);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(51, 15);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width :";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxWidth.Location = new System.Drawing.Point(68, 16);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(37, 22);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinus_KeyPress);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeight.Location = new System.Drawing.Point(113, 20);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 15);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height :";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHeight.Location = new System.Drawing.Point(178, 16);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(37, 22);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinus_KeyPress);
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMinus.Location = new System.Drawing.Point(223, 20);
            this.labelMinus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(54, 15);
            this.labelMinus.TabIndex = 8;
            this.labelMinus.Text = "Minus :";
            // 
            // textBoxMinus
            // 
            this.textBoxMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMinus.Location = new System.Drawing.Point(281, 16);
            this.textBoxMinus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinus.Name = "textBoxMinus";
            this.textBoxMinus.Size = new System.Drawing.Size(37, 22);
            this.textBoxMinus.TabIndex = 2;
            this.textBoxMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinus_KeyPress);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightGray;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.Location = new System.Drawing.Point(330, 14);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(74, 25);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.SystemColors.Control;
            this.panelÜst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelÜst.Controls.Add(this.panelSagSayac);
            this.panelÜst.Controls.Add(this.panelSolSayac);
            this.panelÜst.Controls.Add(this.buttonFace);
            this.panelÜst.Location = new System.Drawing.Point(5, 50);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(406, 60);
            this.panelÜst.TabIndex = 10;
            // 
            // panelSagSayac
            // 
            this.panelSagSayac.BackColor = System.Drawing.Color.Black;
            this.panelSagSayac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSagSayac.Controls.Add(this.labelSaniye);
            this.panelSagSayac.Location = new System.Drawing.Point(321, 3);
            this.panelSagSayac.Name = "panelSagSayac";
            this.panelSagSayac.Size = new System.Drawing.Size(76, 50);
            this.panelSagSayac.TabIndex = 2;
            // 
            // labelSaniye
            // 
            this.labelSaniye.AutoSize = true;
            this.labelSaniye.Font = new System.Drawing.Font("Digiface", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaniye.ForeColor = System.Drawing.Color.Red;
            this.labelSaniye.Location = new System.Drawing.Point(-4, -3);
            this.labelSaniye.Name = "labelSaniye";
            this.labelSaniye.Size = new System.Drawing.Size(85, 49);
            this.labelSaniye.TabIndex = 1;
            this.labelSaniye.Text = "000";
            // 
            // panelSolSayac
            // 
            this.panelSolSayac.BackColor = System.Drawing.Color.Black;
            this.panelSolSayac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSolSayac.Controls.Add(this.labelMayinSayisi);
            this.panelSolSayac.Location = new System.Drawing.Point(5, 3);
            this.panelSolSayac.Name = "panelSolSayac";
            this.panelSolSayac.Size = new System.Drawing.Size(76, 50);
            this.panelSolSayac.TabIndex = 1;
            // 
            // buttonFace
            // 
            this.buttonFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFace.FlatAppearance.BorderSize = 0;
            this.buttonFace.Location = new System.Drawing.Point(176, 3);
            this.buttonFace.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFace.Name = "buttonFace";
            this.buttonFace.Size = new System.Drawing.Size(50, 50);
            this.buttonFace.TabIndex = 4;
            this.buttonFace.UseVisualStyleBackColor = true;
            this.buttonFace.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSS
            // 
            this.buttonSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSS.BackgroundImage")));
            this.buttonSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSS.FlatAppearance.BorderSize = 0;
            this.buttonSS.Location = new System.Drawing.Point(374, 402);
            this.buttonSS.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.buttonSS.Name = "buttonSS";
            this.buttonSS.Size = new System.Drawing.Size(37, 33);
            this.buttonSS.TabIndex = 5;
            this.buttonSS.UseVisualStyleBackColor = true;
            this.buttonSS.Click += new System.EventHandler(this.buttonSS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(416, 438);
            this.Controls.Add(this.buttonSS);
            this.Controls.Add(this.panelÜst);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxMinus);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.panelTarla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelÜst.ResumeLayout(false);
            this.panelSagSayac.ResumeLayout(false);
            this.panelSagSayac.PerformLayout();
            this.panelSolSayac.ResumeLayout(false);
            this.panelSolSayac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTarla;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.TextBox textBoxMinus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.Button buttonFace;
        private System.Windows.Forms.Label labelMayinSayisi;
        private System.Windows.Forms.Panel panelSolSayac;
        private System.Windows.Forms.Panel panelSagSayac;
        private System.Windows.Forms.Label labelSaniye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSS;
    }
}

