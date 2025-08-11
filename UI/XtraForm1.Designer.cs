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
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            LeftGridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            RightGridControl = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
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
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)LeftGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbonPage2
            // 
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // LeftGridControl
            // 
            LeftGridControl.Dock = DockStyle.Fill;
            LeftGridControl.Location = new Point(0, 0);
            LeftGridControl.MainView = gridView1;
            LeftGridControl.Name = "LeftGridControl";
            LeftGridControl.Size = new Size(667, 431);
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
            RightGridControl.Size = new Size(520, 431);
            RightGridControl.TabIndex = 1;
            RightGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = RightGridControl;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 161);
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
            splitContainerControl1.Size = new Size(1199, 431);
            splitContainerControl1.SplitterPosition = 667;
            splitContainerControl1.TabIndex = 7;
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10, barButtonItem11, barButtonItem12 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 13;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            ribbonControl1.Size = new Size(1199, 161);
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
            barButtonItem10.ItemClick += ta_ItemClick;
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "Doktor düzenleme";
            barButtonItem11.Id = 11;
            barButtonItem11.ImageOptions.Image = (Image)resources.GetObject("barButtonItem11.ImageOptions.Image");
            barButtonItem11.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem11.ImageOptions.LargeImage");
            barButtonItem11.Name = "barButtonItem11";
            barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            barButtonItem11.ItemClick += DRE_Click;
            // 
            // barButtonItem12
            // 
            barButtonItem12.Caption = "Hasta Düzenleme";
            barButtonItem12.Id = 12;
            barButtonItem12.ImageOptions.Image = (Image)resources.GetObject("barButtonItem12.ImageOptions.Image");
            barButtonItem12.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem12.ImageOptions.LargeImage");
            barButtonItem12.Name = "barButtonItem12";
            barButtonItem12.ItemClick += PtE_Click;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem11);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem7);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem8);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem12);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem9);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // XtraForm1
            // 
            Appearance.BackColor = Color.Fuchsia;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1199, 592);
            Controls.Add(splitContainerControl1);
            Controls.Add(ribbonControl1);
            Name = "XtraForm1";
            Text = "XtraForm1";
            FormClosed += XtraForm1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)LeftGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.GridControl LeftGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl RightGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}