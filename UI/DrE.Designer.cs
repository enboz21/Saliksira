namespace UI
{
    partial class DrE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrE));
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ChAct = new DevExpress.XtraEditors.CheckEdit();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)ChAct.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton1.Location = new Point(242, 113);
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(35, 28);
            simpleButton1.TabIndex = 19;
            simpleButton1.Text = "\r\n";
            // 
            // ChAct
            // 
            ChAct.EditValue = true;
            ChAct.Location = new Point(121, 115);
            ChAct.Name = "ChAct";
            ChAct.Properties.Caption = "Aktifmi";
            ChAct.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            ChAct.Size = new Size(74, 24);
            ChAct.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(108, 16);
            label4.TabIndex = 17;
            label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 16;
            label3.Text = "Uzmanlık Alanı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(92, 16);
            label2.TabIndex = 15;
            label2.Text = "Doktor Soyismi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 14;
            label1.Text = "Doktor İsmi";
            // 
            // textEdit4
            // 
            textEdit4.EditValue = "";
            textEdit4.Location = new Point(121, 87);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(156, 22);
            textEdit4.TabIndex = 13;
            // 
            // textEdit3
            // 
            textEdit3.EditValue = "";
            textEdit3.Location = new Point(121, 59);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(156, 22);
            textEdit3.TabIndex = 12;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "";
            textEdit2.Location = new Point(121, 31);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 11;
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(121, 3);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(156, 22);
            textEdit1.TabIndex = 10;
            // 
            // DrE
            // 
            Appearance.BackColor = Color.FromArgb(128, 255, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 151);
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
            Name = "DrE";
            Text = "DrE";
            ((System.ComponentModel.ISupportInitialize)ChAct.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit ChAct;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}