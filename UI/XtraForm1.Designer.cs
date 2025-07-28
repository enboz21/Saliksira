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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            DrRefresh = new DevExpress.XtraEditors.SimpleButton();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            hastalar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(15, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(494, 262);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // DrRefresh
            // 
            DrRefresh.ImageOptions.Image = (Image)resources.GetObject("DrRefresh.ImageOptions.Image");
            DrRefresh.Location = new Point(15, 284);
            DrRefresh.Name = "DrRefresh";
            DrRefresh.Size = new Size(118, 36);
            DrRefresh.TabIndex = 0;
            DrRefresh.Text = "Doktorlar";
            DrRefresh.Click += DrRefresh_Click;
            // 
            // stackPanel1
            // 
            stackPanel1.AutoScroll = true;
            stackPanel1.AutoSize = true;
            stackPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackPanel1.Controls.Add(gridControl1);
            stackPanel1.Controls.Add(gridControl2);
            stackPanel1.Dock = DockStyle.Bottom;
            stackPanel1.Location = new Point(0, 326);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(985, 266);
            stackPanel1.TabIndex = 2;
            stackPanel1.UseSkinIndents = true;
            // 
            // gridControl2
            // 
            gridControl2.Location = new Point(513, 2);
            gridControl2.MainView = gridView2;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new Size(460, 262);
            gridControl2.TabIndex = 2;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // hastalar
            // 
            hastalar.ImageOptions.Image = (Image)resources.GetObject("hastalar.ImageOptions.Image");
            hastalar.Location = new Point(855, 284);
            hastalar.Name = "hastalar";
            hastalar.Size = new Size(118, 36);
            hastalar.TabIndex = 3;
            hastalar.Text = "hastalar";
            hastalar.Click += hastalar_Click;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(985, 592);
            Controls.Add(hastalar);
            Controls.Add(stackPanel1);
            Controls.Add(DrRefresh);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton DrRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton hastalar;
    }
}