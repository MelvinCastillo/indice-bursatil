namespace BVRDConsole.Front.Rebalancing
{
    partial class FrmViewRebalancing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewRebalancing));
            this.qTabControl = new Qios.DevSuite.Components.QTabControl();
            this.qtpRebalancing = new Qios.DevSuite.Components.QTabPage();
            this.udvRebalancing = new BVRD.Windows.Controls.Controls.usDataView();
            this.qtpWeights = new Qios.DevSuite.Components.QTabPage();
            this.udvWeights = new BVRD.Windows.Controls.Controls.usDataView();
            this.lvRebalancing = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCurrentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsActiveRebalancing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.usViewRebalancing = new BVRDConsole.Front.Controls.usViewRebalancing();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl)).BeginInit();
            this.qTabControl.SuspendLayout();
            this.qtpRebalancing.SuspendLayout();
            this.qtpWeights.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // usDataView
            // 
            this.usDataView.Location = new System.Drawing.Point(410, 327);
            this.usDataView.Size = new System.Drawing.Size(158, 59);
            this.usDataView.Visible = false;
            // 
            // qTabControl
            // 
            this.qTabControl.ActiveTabPage = this.qtpRebalancing;
            this.qTabControl.Controls.Add(this.qtpRebalancing);
            this.qTabControl.Controls.Add(this.qtpWeights);
            this.qTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTabControl.Location = new System.Drawing.Point(3, 3);
            this.qTabControl.Name = "qTabControl";
            this.qTabControl.PersistGuid = new System.Guid("585c3edd-47fc-4e2b-b81f-9bd3e42329f7");
            this.qTabControl.Size = new System.Drawing.Size(432, 395);
            this.qTabControl.TabIndex = 4;
            // 
            // qtpRebalancing
            // 
            this.qtpRebalancing.ButtonOrder = 0;
            this.qtpRebalancing.Controls.Add(this.udvRebalancing);
            this.qtpRebalancing.Location = new System.Drawing.Point(0, 30);
            this.qtpRebalancing.Name = "qtpRebalancing";
            this.qtpRebalancing.PersistGuid = new System.Guid("39ac4f76-b7ee-4057-91a3-29c991889174");
            this.qtpRebalancing.Size = new System.Drawing.Size(430, 363);
            this.qtpRebalancing.Text = "Rebalanceo";
            // 
            // udvRebalancing
            // 
            this.udvRebalancing._RecordCount = 0;
            this.udvRebalancing._TableIndex = 0;
            this.udvRebalancing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udvRebalancing.Location = new System.Drawing.Point(0, 0);
            this.udvRebalancing.Name = "udvRebalancing";
            this.udvRebalancing.Size = new System.Drawing.Size(430, 363);
            this.udvRebalancing.TabIndex = 0;
            // 
            // qtpWeights
            // 
            this.qtpWeights.ButtonOrder = 1;
            this.qtpWeights.Controls.Add(this.udvWeights);
            this.qtpWeights.Location = new System.Drawing.Point(0, 30);
            this.qtpWeights.Name = "qtpWeights";
            this.qtpWeights.PersistGuid = new System.Guid("e881083c-24bf-46ad-b416-388c956dbfb3");
            this.qtpWeights.Size = new System.Drawing.Size(432, 365);
            this.qtpWeights.Text = "Ponderaciones";
            // 
            // udvWeights
            // 
            this.udvWeights._RecordCount = 0;
            this.udvWeights._TableIndex = 0;
            this.udvWeights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udvWeights.Location = new System.Drawing.Point(0, 0);
            this.udvWeights.Name = "udvWeights";
            this.udvWeights.Size = new System.Drawing.Size(432, 365);
            this.udvWeights.TabIndex = 0;
            // 
            // lvRebalancing
            // 
            this.lvRebalancing.BackColor = System.Drawing.Color.White;
            this.lvRebalancing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chCurrentDate});
            this.lvRebalancing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRebalancing.FullRowSelect = true;
            this.lvRebalancing.GridLines = true;
            this.lvRebalancing.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRebalancing.HideSelection = false;
            this.lvRebalancing.Location = new System.Drawing.Point(3, 32);
            this.lvRebalancing.MinimumSize = new System.Drawing.Size(220, 210);
            this.lvRebalancing.MultiSelect = false;
            this.lvRebalancing.Name = "lvRebalancing";
            this.lvRebalancing.Size = new System.Drawing.Size(220, 216);
            this.lvRebalancing.TabIndex = 1;
            this.lvRebalancing.UseCompatibleStateImageBehavior = false;
            this.lvRebalancing.View = System.Windows.Forms.View.Details;
            this.lvRebalancing.SelectedIndexChanged += new System.EventHandler(this.lvRebalancing_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 70;
            // 
            // chCurrentDate
            // 
            this.chCurrentDate.Text = "Fecha";
            this.chCurrentDate.Width = 130;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsActiveRebalancing,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.toolStrip1.Size = new System.Drawing.Size(216, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsActiveRebalancing
            // 
            this.tsActiveRebalancing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsActiveRebalancing.Enabled = false;
            this.tsActiveRebalancing.Image = global::BVRDConsole.Front.Properties.Resources.edit;
            this.tsActiveRebalancing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsActiveRebalancing.Name = "tsActiveRebalancing";
            this.tsActiveRebalancing.Size = new System.Drawing.Size(23, 20);
            this.tsActiveRebalancing.Tag = "Activar Rebalanceo.";
            this.tsActiveRebalancing.Text = "Activar Rebalanceo.";
            this.tsActiveRebalancing.Click += new System.EventHandler(this.tsActiveRebalancing_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvRebalancing);
            this.splitContainer.Panel1.Controls.Add(this.usViewRebalancing);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer.Panel1MinSize = 220;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.qTabControl);
            this.splitContainer.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer.Size = new System.Drawing.Size(664, 401);
            this.splitContainer.SplitterDistance = 222;
            this.splitContainer.TabIndex = 6;
            // 
            // usViewRebalancing
            // 
            this.usViewRebalancing._BeforeLastDate = new System.DateTime(((long)(0)));
            this.usViewRebalancing._Date = new System.DateTime(((long)(0)));
            this.usViewRebalancing._LastDate = new System.DateTime(((long)(0)));
            this.usViewRebalancing._TIPPP = 0D;
            this.usViewRebalancing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usViewRebalancing.Location = new System.Drawing.Point(3, 248);
            this.usViewRebalancing.MinimumSize = new System.Drawing.Size(320, 140);
            this.usViewRebalancing.Name = "usViewRebalancing";
            this.usViewRebalancing.Size = new System.Drawing.Size(320, 150);
            this.usViewRebalancing.TabIndex = 4;
            this.usViewRebalancing.Visible = false;
            // 
            // FrmViewRebalancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(670, 450);
            this.Name = "FrmViewRebalancing";
            this.Text = "Rebalanceo";
            this.Load += new System.EventHandler(this.FrmViewRebalancing_Load);
            this.Controls.SetChildIndex(this.usDataView, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl)).EndInit();
            this.qTabControl.ResumeLayout(false);
            this.qtpRebalancing.ResumeLayout(false);
            this.qtpWeights.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.QTabControl qTabControl;
        private Qios.DevSuite.Components.QTabPage qtpRebalancing;
        private BVRD.Windows.Controls.Controls.usDataView udvRebalancing;
        private Qios.DevSuite.Components.QTabPage qtpWeights;
        private BVRD.Windows.Controls.Controls.usDataView udvWeights;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lvRebalancing;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chCurrentDate;
        private System.Windows.Forms.ToolStripButton tsActiveRebalancing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Controls.usViewRebalancing usViewRebalancing;

    }
}