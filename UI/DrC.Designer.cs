namespace UI
{
    partial class DrC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrC));
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ChAct = new DevExpress.XtraEditors.CheckEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChAct.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(122, 9);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(156, 22);
            textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "";
            textEdit2.Location = new Point(122, 37);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            textEdit3.EditValue = "";
            textEdit3.Location = new Point(122, 65);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(156, 22);
            textEdit3.TabIndex = 2;
            // 
            // textEdit4
            // 
            textEdit4.EditValue = "";
            textEdit4.Location = new Point(122, 93);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(156, 22);
            textEdit4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 4;
            label1.Text = "Doktor İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 43);
            label2.Name = "label2";
            label2.Size = new Size(92, 16);
            label2.TabIndex = 5;
            label2.Text = "Doktor Soyismi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 6;
            label3.Text = "Uzmanlık Alanı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 99);
            label4.Name = "label4";
            label4.Size = new Size(108, 16);
            label4.TabIndex = 7;
            label4.Text = "Telefon Numarası";
            // 
            // ChAct
            // 
            ChAct.EditValue = true;
            ChAct.Location = new Point(122, 121);
            ChAct.Name = "ChAct";
            ChAct.Properties.Caption = "Aktifmi";
            ChAct.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            ChAct.Size = new Size(74, 24);
            ChAct.TabIndex = 8;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton1.Location = new Point(243, 119);
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(35, 28);
            simpleButton1.TabIndex = 9;
            simpleButton1.Text = "\r\n";
            simpleButton1.Click += Conf_Click;
            // 
            // DrC
            // 
            ActiveGlowColor = Color.FromArgb(255, 128, 128);
            Appearance.BackColor = Color.FromArgb(255, 255, 128);
            Appearance.BorderColor = Color.Blue;
            Appearance.ForeColor = Color.Red;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseBorderColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 152);
            Controls.Add(simpleButton1);
            Controls.Add(ChAct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DrC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DrCE";
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChAct.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DevExpress.XtraEditors.CheckEdit ChAct;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}