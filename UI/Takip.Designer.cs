namespace UI
{
    partial class Takip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Takip));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            onay = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(181, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(479, 688);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // onay
            // 
            onay.ImageOptions.Image = (Image)resources.GetObject("onay.ImageOptions.Image");
            onay.Location = new Point(12, 38);
            onay.Name = "onay";
            onay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            onay.Size = new Size(153, 80);
            onay.TabIndex = 1;
            onay.Text = "Tamamlandı";
            onay.Click += onay_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new Point(12, 124);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton2.Size = new Size(153, 80);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "Tamamlanamadı";
            // 
            // Takip
            // 
            Appearance.BackColor = Color.Lime;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 712);
            Controls.Add(simpleButton2);
            Controls.Add(onay);
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Takip";
            Text = "Takip";
            Load += Takip_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton onay;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}