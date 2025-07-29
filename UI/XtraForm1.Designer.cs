namespace UI
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            Ptce = new DevExpress.XtraEditors.SimpleButton();
            PtD = new DevExpress.XtraEditors.SimpleButton();
            DrD = new DevExpress.XtraEditors.SimpleButton();
            Drce = new DevExpress.XtraEditors.SimpleButton();
            hastalar = new DevExpress.XtraEditors.SimpleButton();
            DrRefresh = new DevExpress.XtraEditors.SimpleButton();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            LeftGridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            RightGridControl = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel1).BeginInit();
            splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel2).BeginInit();
            splitContainerControl2.Panel2.SuspendLayout();
            splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LeftGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // splitContainerControl2
            // 
            splitContainerControl2.Dock = DockStyle.Fill;
            splitContainerControl2.Horizontal = false;
            splitContainerControl2.Location = new Point(0, 0);
            splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            splitContainerControl2.Panel1.Controls.Add(Ptce);
            splitContainerControl2.Panel1.Controls.Add(PtD);
            splitContainerControl2.Panel1.Controls.Add(DrD);
            splitContainerControl2.Panel1.Controls.Add(Drce);
            splitContainerControl2.Panel1.Controls.Add(hastalar);
            splitContainerControl2.Panel1.Controls.Add(DrRefresh);
            splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            splitContainerControl2.Panel2.Controls.Add(splitContainerControl1);
            splitContainerControl2.Panel2.Text = "Panel2";
            splitContainerControl2.Size = new Size(1199, 592);
            splitContainerControl2.SplitterPosition = 332;
            splitContainerControl2.TabIndex = 5;
            // 
            // Ptce
            // 
            Ptce.ImageOptions.Image = (Image)resources.GetObject("Ptce.ImageOptions.Image");
            Ptce.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            Ptce.ImageOptions.ImageUri.Uri = "Add";
            Ptce.Location = new Point(1038, 257);
            Ptce.Name = "Ptce";
            Ptce.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            Ptce.Size = new Size(71, 64);
            Ptce.TabIndex = 11;
            Ptce.Text = "Hasta Ekle";
            Ptce.Click += Ptce_Click;
            // 
            // PtD
            // 
            PtD.ImageOptions.Image = (Image)resources.GetObject("PtD.ImageOptions.Image");
            PtD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            PtD.ImageOptions.ImageUri.Uri = "Add";
            PtD.Location = new Point(961, 257);
            PtD.Name = "PtD";
            PtD.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            PtD.Size = new Size(71, 64);
            PtD.TabIndex = 10;
            PtD.Text = "Hasta Sil";
            PtD.Click += PtD_Click;
            // 
            // DrD
            // 
            DrD.ImageOptions.Image = (Image)resources.GetObject("DrD.ImageOptions.Image");
            DrD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            DrD.ImageOptions.ImageUri.Uri = "Add";
            DrD.Location = new Point(147, 262);
            DrD.Name = "DrD";
            DrD.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            DrD.Size = new Size(71, 64);
            DrD.TabIndex = 9;
            DrD.Text = "Doktor Sil";
            DrD.Click += DrD_Click;
            // 
            // Drce
            // 
            Drce.ImageOptions.Image = (Image)resources.GetObject("Drce.ImageOptions.Image");
            Drce.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            Drce.ImageOptions.ImageUri.Uri = "Add";
            Drce.Location = new Point(70, 262);
            Drce.Name = "Drce";
            Drce.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            Drce.Size = new Size(71, 64);
            Drce.TabIndex = 8;
            Drce.Text = "Doktor Ekle";
            Drce.Click += Drce_Click;
            // 
            // hastalar
            // 
            hastalar.ImageOptions.Image = (Image)resources.GetObject("hastalar.ImageOptions.Image");
            hastalar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            hastalar.Location = new Point(1115, 257);
            hastalar.Name = "hastalar";
            hastalar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            hastalar.Size = new Size(71, 64);
            hastalar.TabIndex = 7;
            hastalar.Text = "hastalar";
            hastalar.Click += hastalar_Click;
            // 
            // DrRefresh
            // 
            DrRefresh.ImageOptions.Image = (Image)resources.GetObject("DrRefresh.ImageOptions.Image");
            DrRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            DrRefresh.Location = new Point(3, 262);
            DrRefresh.Name = "DrRefresh";
            DrRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            DrRefresh.Size = new Size(61, 64);
            DrRefresh.TabIndex = 6;
            DrRefresh.Text = "Doktorlar";
            DrRefresh.Click += DrRefresh_Click;
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 0);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(LeftGridControl);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(RightGridControl);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1199, 248);
            splitContainerControl1.SplitterPosition = 575;
            splitContainerControl1.TabIndex = 5;
            // 
            // LeftGridControl
            // 
            LeftGridControl.Dock = DockStyle.Fill;
            LeftGridControl.Location = new Point(0, 0);
            LeftGridControl.MainView = gridView1;
            LeftGridControl.Name = "LeftGridControl";
            LeftGridControl.Size = new Size(575, 248);
            LeftGridControl.TabIndex = 0;
            LeftGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = LeftGridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Cancel;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // RightGridControl
            // 
            RightGridControl.Dock = DockStyle.Fill;
            RightGridControl.Location = new Point(0, 0);
            RightGridControl.MainView = gridView2;
            RightGridControl.Name = "RightGridControl";
            RightGridControl.Size = new Size(612, 248);
            RightGridControl.TabIndex = 1;
            RightGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            RightGridControl.Click += RightGridControl_Click;
            // 
            // gridView2
            // 
            gridView2.GridControl = RightGridControl;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1199, 592);
            Controls.Add(splitContainerControl2);
            Name = "XtraForm1";
            Text = "XtraForm1";
            FormClosed += XtraForm1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel1).EndInit();
            splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel2).EndInit();
            splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2).EndInit();
            splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LeftGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl LeftGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl RightGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton hastalar;
        private DevExpress.XtraEditors.SimpleButton DrRefresh;
        private DevExpress.XtraEditors.SimpleButton Drce;
        private DevExpress.XtraEditors.SimpleButton DrD;
        private DevExpress.XtraEditors.SimpleButton PtD;
        private DevExpress.XtraEditors.SimpleButton Ptce;
    }
}