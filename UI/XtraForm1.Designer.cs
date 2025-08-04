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
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
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
            splitContainerControl2.Panel1.Controls.Add(ribbonControl1);
            splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            splitContainerControl2.Panel2.Controls.Add(splitContainerControl1);
            splitContainerControl2.Panel2.Text = "Panel2";
            splitContainerControl2.Size = new Size(1199, 592);
            splitContainerControl2.SplitterPosition = 319;
            splitContainerControl2.TabIndex = 5;
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 11;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1199, 183);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "barButtonItem2";
            barButtonItem2.Id = 2;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Doktorlar";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += DrRefresh_Click;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Doktor Ekle";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.Image = (Image)resources.GetObject("barButtonItem4.ImageOptions.Image");
            barButtonItem4.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem4.ImageOptions.LargeImage");
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += Drce_Click;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Doktor sil";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.Image = (Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            barButtonItem5.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += DrD_Click;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Hastalar";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.Image = (Image)resources.GetObject("barButtonItem6.ImageOptions.Image");
            barButtonItem6.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem6.ImageOptions.LargeImage");
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += hastalar_Click;
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "Hasta ekle";
            barButtonItem7.Id = 7;
            barButtonItem7.ImageOptions.Image = (Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
            barButtonItem7.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
            barButtonItem7.Name = "barButtonItem7";
            barButtonItem7.ItemClick += Ptce_Click;
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "Hasta sil";
            barButtonItem8.Id = 8;
            barButtonItem8.ImageOptions.Image = (Image)resources.GetObject("barButtonItem8.ImageOptions.Image");
            barButtonItem8.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem8.ImageOptions.LargeImage");
            barButtonItem8.Name = "barButtonItem8";
            barButtonItem8.ItemClick += PtD_Click;
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "giriş";
            barButtonItem9.Id = 9;
            barButtonItem9.ImageOptions.Image = (Image)resources.GetObject("barButtonItem9.ImageOptions.Image");
            barButtonItem9.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem9.ImageOptions.LargeImage");
            barButtonItem9.Name = "barButtonItem9";
            barButtonItem9.ItemClick += barButtonItem9_ItemClick;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "Takip paneli";
            barButtonItem10.Id = 10;
            barButtonItem10.ImageOptions.Image = (Image)resources.GetObject("barButtonItem10.ImageOptions.Image");
            barButtonItem10.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem10.ImageOptions.LargeImage");
            barButtonItem10.Name = "barButtonItem10";
            barButtonItem10.ItemClick += barButtonItem10_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5, ribbonPageGroup6, ribbonPageGroup7, ribbonPageGroup8 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(barButtonItem7);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(barButtonItem8);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(barButtonItem9);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
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
            splitContainerControl1.Size = new Size(1199, 261);
            splitContainerControl1.SplitterPosition = 639;
            splitContainerControl1.TabIndex = 5;
            // 
            // LeftGridControl
            // 
            LeftGridControl.Dock = DockStyle.Fill;
            LeftGridControl.Location = new Point(0, 0);
            LeftGridControl.MainView = gridView1;
            LeftGridControl.Name = "LeftGridControl";
            LeftGridControl.Size = new Size(639, 261);
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
            RightGridControl.Size = new Size(548, 261);
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
            Appearance.BackColor = Color.Fuchsia;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1199, 592);
            Controls.Add(splitContainerControl2);
            Name = "XtraForm1";
            Text = "XtraForm1";
            FormClosed += XtraForm1_FormClosed;
            Load += XtraForm1_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel1).EndInit();
            splitContainerControl2.Panel1.ResumeLayout(false);
            splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel2).EndInit();
            splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2).EndInit();
            splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}