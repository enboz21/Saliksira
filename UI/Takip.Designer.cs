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
            dok = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dok.Properties).BeginInit();
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
            onay.Location = new Point(8, 40);
            onay.Name = "onay";
            onay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            onay.Size = new Size(153, 80);
            onay.TabIndex = 1;
            onay.Text = "Tamamlandı";
            onay.Click += onay_Click;
            // 
            // dok
            // 
            dok.Location = new Point(8, 12);
            dok.Name = "dok";
            dok.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            dok.Size = new Size(155, 22);
            dok.TabIndex = 48;
            dok.EditValueChanged += dok_EditValueChanged;
            // 
            // Takip
            // 
            Appearance.BackColor = Color.Lime;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 712);
            Controls.Add(dok);
            Controls.Add(onay);
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Takip";
            Text = "Takip";
            Load += Takip_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dok.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton onay;
        private DevExpress.XtraEditors.LookUpEdit dok;
    }
}