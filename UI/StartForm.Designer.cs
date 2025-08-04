namespace UI
{
    partial class StartForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            Giris = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textEdit1);
            panel1.Controls.Add(Giris);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 610);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textEdit3);
            panel2.Controls.Add(textEdit2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 610);
            panel2.TabIndex = 6;
            // 
            // textEdit3
            // 
            textEdit3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textEdit3.EditValue = "";
            textEdit3.Location = new Point(12, 358);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.BackColor = Color.White;
            textEdit3.Properties.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textEdit3.Properties.Appearance.ForeColor = Color.Red;
            textEdit3.Properties.Appearance.Options.UseBackColor = true;
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Properties.Appearance.Options.UseForeColor = true;
            textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit3.Properties.UseMaskAsDisplayFormat = true;
            textEdit3.RightToLeft = RightToLeft.No;
            textEdit3.Size = new Size(838, 74);
            textEdit3.TabIndex = 7;
            // 
            // textEdit2
            // 
            textEdit2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textEdit2.EditValue = "";
            textEdit2.Location = new Point(12, 223);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.BackColor = Color.White;
            textEdit2.Properties.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textEdit2.Properties.Appearance.ForeColor = Color.Red;
            textEdit2.Properties.Appearance.Options.UseBackColor = true;
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.Appearance.Options.UseForeColor = true;
            textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit2.Properties.UseMaskAsDisplayFormat = true;
            textEdit2.RightToLeft = RightToLeft.No;
            textEdit2.Size = new Size(838, 74);
            textEdit2.TabIndex = 6;
            // 
            // textEdit1
            // 
            textEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(12, 379);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.BackColor = Color.White;
            textEdit1.Properties.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textEdit1.Properties.Appearance.ForeColor = Color.Red;
            textEdit1.Properties.Appearance.Options.UseBackColor = true;
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Properties.Appearance.Options.UseForeColor = true;
            textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit1.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            textEdit1.Properties.MaskSettings.Set("mask", "###########");
            textEdit1.Properties.UseMaskAsDisplayFormat = true;
            textEdit1.RightToLeft = RightToLeft.No;
            textEdit1.Size = new Size(838, 74);
            textEdit1.TabIndex = 5;
            textEdit1.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // Giris
            // 
            Giris.AutoSize = true;
            Giris.Font = new Font("Tahoma", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Giris.Location = new Point(36, 99);
            Giris.Name = "Giris";
            Giris.Size = new Size(517, 36);
            Giris.TabIndex = 4;
            Giris.Text = "Litfen Tc kimlik numarınızı giriniz";
            Giris.TextAlign = ContentAlignment.MiddleCenter;
            Giris.Click += Giris_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 610);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            Text = "StartForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private Label Giris;
        private Panel panel2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
    }
}