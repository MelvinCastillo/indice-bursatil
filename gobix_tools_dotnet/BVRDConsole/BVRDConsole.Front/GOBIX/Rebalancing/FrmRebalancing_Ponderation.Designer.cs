namespace BVRDConsole.Front.GOBIX.Rebalancing
{
    partial class FrmRebalancing_Ponderation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRebalancing_Ponderation));
            this.qTabControl = new Qios.DevSuite.Components.QTabControl();
            this.qtpRebalancing = new Qios.DevSuite.Components.QTabPage();
            this.splitContainerRebalanceo = new System.Windows.Forms.SplitContainer();
            this.lblRE = new System.Windows.Forms.Label();
            this.lblRD = new System.Windows.Forms.Label();
            this.btnCargardatos = new System.Windows.Forms.Button();
            this.btnLoadExcelRebalanceo = new System.Windows.Forms.Button();
            this.txtArchivoExcel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTIPPP = new System.Windows.Forms.TextBox();
            this.txtBeforeLastDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRebalanceo = new System.Windows.Forms.SplitContainer();
            this.udvRebalancing = new BVRD.Windows.Controls.Controls.usDataView();
            this.udvRebalancingExcluded = new BVRD.Windows.Controls.Controls.usDataView();
            this.qtpWeights = new Qios.DevSuite.Components.QTabPage();
            this.splitContainerPonderaciones = new System.Windows.Forms.SplitContainer();
            this.btnCargardatosPonderaciones = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoadExcelPonderaciones = new System.Windows.Forms.Button();
            this.txtPonderacionTotalDEC = new System.Windows.Forms.TextBox();
            this.txtArchivoExcelPonderaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPonderacionTotalPOR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorMercado = new System.Windows.Forms.TextBox();
            this.udvWeights = new BVRD.Windows.Controls.Controls.usDataView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BarraFormulario = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl)).BeginInit();
            this.qTabControl.SuspendLayout();
            this.qtpRebalancing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRebalanceo)).BeginInit();
            this.splitContainerRebalanceo.Panel1.SuspendLayout();
            this.splitContainerRebalanceo.Panel2.SuspendLayout();
            this.splitContainerRebalanceo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelRebalanceo)).BeginInit();
            this.PanelRebalanceo.Panel1.SuspendLayout();
            this.PanelRebalanceo.Panel2.SuspendLayout();
            this.PanelRebalanceo.SuspendLayout();
            this.qtpWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPonderaciones)).BeginInit();
            this.splitContainerPonderaciones.Panel1.SuspendLayout();
            this.splitContainerPonderaciones.Panel2.SuspendLayout();
            this.splitContainerPonderaciones.SuspendLayout();
            this.BarraFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(0, 514);
            this.groupBox.Size = new System.Drawing.Size(15, 17);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(849, 499);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(811, 499);
            // 
            // qTabControl
            // 
            this.qTabControl.ActiveTabPage = this.qtpRebalancing;
            this.qTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qTabControl.Controls.Add(this.qtpRebalancing);
            this.qTabControl.Controls.Add(this.qtpWeights);
            this.qTabControl.Location = new System.Drawing.Point(0, 70);
            this.qTabControl.Name = "qTabControl";
            this.qTabControl.PersistGuid = new System.Guid("585c3edd-47fc-4e2b-b81f-9bd3e42329f7");
            this.qTabControl.Size = new System.Drawing.Size(952, 467);
            this.qTabControl.TabIndex = 9;
            // 
            // qtpRebalancing
            // 
            this.qtpRebalancing.ButtonOrder = 0;
            this.qtpRebalancing.Controls.Add(this.splitContainerRebalanceo);
            this.qtpRebalancing.Location = new System.Drawing.Point(0, 30);
            this.qtpRebalancing.Name = "qtpRebalancing";
            this.qtpRebalancing.PersistGuid = new System.Guid("39ac4f76-b7ee-4057-91a3-29c991889174");
            this.qtpRebalancing.Size = new System.Drawing.Size(950, 435);
            this.qtpRebalancing.Text = "Rebalanceo";
            // 
            // splitContainerRebalanceo
            // 
            this.splitContainerRebalanceo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRebalanceo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRebalanceo.Name = "splitContainerRebalanceo";
            this.splitContainerRebalanceo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRebalanceo.Panel1
            // 
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.lblRE);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.lblRD);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.btnCargardatos);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.btnLoadExcelRebalanceo);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.txtArchivoExcel);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.label5);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.label4);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.txtTIPPP);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.txtBeforeLastDate);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.label3);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.txtLastDate);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.label2);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.txtCurrentDate);
            this.splitContainerRebalanceo.Panel1.Controls.Add(this.label1);
            // 
            // splitContainerRebalanceo.Panel2
            // 
            this.splitContainerRebalanceo.Panel2.Controls.Add(this.PanelRebalanceo);
            this.splitContainerRebalanceo.Size = new System.Drawing.Size(950, 435);
            this.splitContainerRebalanceo.SplitterDistance = 97;
            this.splitContainerRebalanceo.TabIndex = 3;
            // 
            // lblRE
            // 
            this.lblRE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.Location = new System.Drawing.Point(590, 81);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(357, 15);
            this.lblRE.TabIndex = 14;
            this.lblRE.Text = "Tbl_Rebalancing_Excluded";
            this.lblRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRD
            // 
            this.lblRD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRD.Location = new System.Drawing.Point(0, 81);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(589, 15);
            this.lblRD.TabIndex = 13;
            this.lblRD.Text = "Tbl_Rebalancing_Details";
            this.lblRD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCargardatos
            // 
            this.btnCargardatos.Image = global::BVRDConsole.Front.Properties.Resources.Upload_Information_icon;
            this.btnCargardatos.Location = new System.Drawing.Point(825, 9);
            this.btnCargardatos.Name = "btnCargardatos";
            this.btnCargardatos.Size = new System.Drawing.Size(72, 62);
            this.btnCargardatos.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnCargardatos, "Cargar datos de archivo a la Pantalla.");
            this.btnCargardatos.UseVisualStyleBackColor = true;
            this.btnCargardatos.Click += new System.EventHandler(this.btnCargardatos_Click);
            // 
            // btnLoadExcelRebalanceo
            // 
            this.btnLoadExcelRebalanceo.Location = new System.Drawing.Point(756, 48);
            this.btnLoadExcelRebalanceo.Name = "btnLoadExcelRebalanceo";
            this.btnLoadExcelRebalanceo.Size = new System.Drawing.Size(40, 23);
            this.btnLoadExcelRebalanceo.TabIndex = 11;
            this.btnLoadExcelRebalanceo.Text = "...";
            this.btnLoadExcelRebalanceo.UseVisualStyleBackColor = true;
            this.btnLoadExcelRebalanceo.Click += new System.EventHandler(this.btnLoadExcelRebalanceo_Click);
            // 
            // txtArchivoExcel
            // 
            this.txtArchivoExcel.Location = new System.Drawing.Point(106, 48);
            this.txtArchivoExcel.Name = "txtArchivoExcel";
            this.txtArchivoExcel.Size = new System.Drawing.Size(642, 23);
            this.txtArchivoExcel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Archivo Excel  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "TIPP :";
            // 
            // txtTIPPP
            // 
            this.txtTIPPP.Location = new System.Drawing.Point(287, 12);
            this.txtTIPPP.Name = "txtTIPPP";
            this.txtTIPPP.Size = new System.Drawing.Size(100, 23);
            this.txtTIPPP.TabIndex = 7;
            this.txtTIPPP.Text = "0";
            this.txtTIPPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTIPPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTIPPP_KeyPress);
            // 
            // txtBeforeLastDate
            // 
            this.txtBeforeLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBeforeLastDate.Location = new System.Drawing.Point(723, 12);
            this.txtBeforeLastDate.Name = "txtBeforeLastDate";
            this.txtBeforeLastDate.Size = new System.Drawing.Size(97, 23);
            this.txtBeforeLastDate.TabIndex = 6;
            this.txtBeforeLastDate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Ante Pasada :";
            this.label3.Visible = false;
            // 
            // txtLastDate
            // 
            this.txtLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtLastDate.Location = new System.Drawing.Point(481, 12);
            this.txtLastDate.Name = "txtLastDate";
            this.txtLastDate.Size = new System.Drawing.Size(97, 23);
            this.txtLastDate.TabIndex = 4;
            this.txtLastDate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Pasada :";
            this.label2.Visible = false;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCurrentDate.Location = new System.Drawing.Point(106, 12);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(97, 23);
            this.txtCurrentDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha :";
            // 
            // PanelRebalanceo
            // 
            this.PanelRebalanceo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRebalanceo.Location = new System.Drawing.Point(0, 0);
            this.PanelRebalanceo.Name = "PanelRebalanceo";
            // 
            // PanelRebalanceo.Panel1
            // 
            this.PanelRebalanceo.Panel1.Controls.Add(this.udvRebalancing);
            // 
            // PanelRebalanceo.Panel2
            // 
            this.PanelRebalanceo.Panel2.Controls.Add(this.udvRebalancingExcluded);
            this.PanelRebalanceo.Size = new System.Drawing.Size(950, 334);
            this.PanelRebalanceo.SplitterDistance = 589;
            this.PanelRebalanceo.TabIndex = 3;
            // 
            // udvRebalancing
            // 
            this.udvRebalancing._RecordCount = 0;
            this.udvRebalancing._TableIndex = 0;
            this.udvRebalancing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udvRebalancing.Location = new System.Drawing.Point(0, 0);
            this.udvRebalancing.Name = "udvRebalancing";
            this.udvRebalancing.Size = new System.Drawing.Size(589, 334);
            this.udvRebalancing.TabIndex = 1;
            // 
            // udvRebalancingExcluded
            // 
            this.udvRebalancingExcluded._RecordCount = 0;
            this.udvRebalancingExcluded._TableIndex = 0;
            this.udvRebalancingExcluded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udvRebalancingExcluded.Location = new System.Drawing.Point(0, 0);
            this.udvRebalancingExcluded.Name = "udvRebalancingExcluded";
            this.udvRebalancingExcluded.Size = new System.Drawing.Size(357, 334);
            this.udvRebalancingExcluded.TabIndex = 2;
            // 
            // qtpWeights
            // 
            this.qtpWeights.ButtonOrder = 1;
            this.qtpWeights.Controls.Add(this.splitContainerPonderaciones);
            this.qtpWeights.Location = new System.Drawing.Point(0, 30);
            this.qtpWeights.Name = "qtpWeights";
            this.qtpWeights.PersistGuid = new System.Guid("e881083c-24bf-46ad-b416-388c956dbfb3");
            this.qtpWeights.Size = new System.Drawing.Size(950, 435);
            this.qtpWeights.Text = "Ponderaciones";
            // 
            // splitContainerPonderaciones
            // 
            this.splitContainerPonderaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPonderaciones.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPonderaciones.Name = "splitContainerPonderaciones";
            this.splitContainerPonderaciones.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPonderaciones.Panel1
            // 
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.btnCargardatosPonderaciones);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.label8);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.btnLoadExcelPonderaciones);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.txtPonderacionTotalDEC);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.txtArchivoExcelPonderaciones);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.label9);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.label7);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.txtPonderacionTotalPOR);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.label6);
            this.splitContainerPonderaciones.Panel1.Controls.Add(this.txtValorMercado);
            // 
            // splitContainerPonderaciones.Panel2
            // 
            this.splitContainerPonderaciones.Panel2.Controls.Add(this.udvWeights);
            this.splitContainerPonderaciones.Size = new System.Drawing.Size(950, 435);
            this.splitContainerPonderaciones.SplitterDistance = 78;
            this.splitContainerPonderaciones.TabIndex = 1;
            // 
            // btnCargardatosPonderaciones
            // 
            this.btnCargardatosPonderaciones.Image = global::BVRDConsole.Front.Properties.Resources.Upload_Information_icon;
            this.btnCargardatosPonderaciones.Location = new System.Drawing.Point(852, 6);
            this.btnCargardatosPonderaciones.Name = "btnCargardatosPonderaciones";
            this.btnCargardatosPonderaciones.Size = new System.Drawing.Size(72, 62);
            this.btnCargardatosPonderaciones.TabIndex = 16;
            this.toolTip.SetToolTip(this.btnCargardatosPonderaciones, "Cargar datos de archivo a la Pantalla.");
            this.btnCargardatosPonderaciones.UseVisualStyleBackColor = true;
            this.btnCargardatosPonderaciones.Click += new System.EventHandler(this.btnCargardatosPonderaciones_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ponderación Total (DEC)  :";
            // 
            // btnLoadExcelPonderaciones
            // 
            this.btnLoadExcelPonderaciones.Location = new System.Drawing.Point(803, 41);
            this.btnLoadExcelPonderaciones.Name = "btnLoadExcelPonderaciones";
            this.btnLoadExcelPonderaciones.Size = new System.Drawing.Size(40, 23);
            this.btnLoadExcelPonderaciones.TabIndex = 15;
            this.btnLoadExcelPonderaciones.Text = "...";
            this.btnLoadExcelPonderaciones.UseVisualStyleBackColor = true;
            this.btnLoadExcelPonderaciones.Click += new System.EventHandler(this.btnLoadExcelPonderaciones_Click);
            // 
            // txtPonderacionTotalDEC
            // 
            this.txtPonderacionTotalDEC.Location = new System.Drawing.Point(741, 12);
            this.txtPonderacionTotalDEC.Name = "txtPonderacionTotalDEC";
            this.txtPonderacionTotalDEC.Size = new System.Drawing.Size(104, 23);
            this.txtPonderacionTotalDEC.TabIndex = 13;
            this.txtPonderacionTotalDEC.Text = "0";
            this.txtPonderacionTotalDEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPonderacionTotalDEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPonderacionTotalDEC_KeyPress);
            // 
            // txtArchivoExcelPonderaciones
            // 
            this.txtArchivoExcelPonderaciones.Location = new System.Drawing.Point(153, 41);
            this.txtArchivoExcelPonderaciones.Name = "txtArchivoExcelPonderaciones";
            this.txtArchivoExcelPonderaciones.Size = new System.Drawing.Size(642, 23);
            this.txtArchivoExcelPonderaciones.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Archivo Excel  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ponderación Total (POR)  :";
            // 
            // txtPonderacionTotalPOR
            // 
            this.txtPonderacionTotalPOR.Location = new System.Drawing.Point(452, 12);
            this.txtPonderacionTotalPOR.Name = "txtPonderacionTotalPOR";
            this.txtPonderacionTotalPOR.Size = new System.Drawing.Size(115, 23);
            this.txtPonderacionTotalPOR.TabIndex = 11;
            this.txtPonderacionTotalPOR.Text = "0";
            this.txtPonderacionTotalPOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPonderacionTotalPOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPonderacionTotalPOR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Total Mercado :";
            // 
            // txtValorMercado
            // 
            this.txtValorMercado.Location = new System.Drawing.Point(153, 12);
            this.txtValorMercado.Name = "txtValorMercado";
            this.txtValorMercado.Size = new System.Drawing.Size(123, 23);
            this.txtValorMercado.TabIndex = 9;
            this.txtValorMercado.Text = "0";
            this.txtValorMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorMercado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMercado_KeyPress);
            // 
            // udvWeights
            // 
            this.udvWeights._RecordCount = 0;
            this.udvWeights._TableIndex = 0;
            this.udvWeights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udvWeights.Location = new System.Drawing.Point(0, 0);
            this.udvWeights.Name = "udvWeights";
            this.udvWeights.Size = new System.Drawing.Size(950, 353);
            this.udvWeights.TabIndex = 1;
            // 
            // BarraFormulario
            // 
            this.BarraFormulario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BarraFormulario.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraFormulario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnCancelar});
            this.BarraFormulario.Location = new System.Drawing.Point(0, 28);
            this.BarraFormulario.Name = "BarraFormulario";
            this.BarraFormulario.Size = new System.Drawing.Size(952, 39);
            this.BarraFormulario.TabIndex = 2;
            this.BarraFormulario.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmRebalancing_Ponderation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 552);
            this.Controls.Add(this.BarraFormulario);
            this.Controls.Add(this.qTabControl);
            this.Name = "FrmRebalancing_Ponderation";
            this.Text = "Rebalanceo Manual";
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.qTabControl, 0);
            this.Controls.SetChildIndex(this.BarraFormulario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.qTabControl)).EndInit();
            this.qTabControl.ResumeLayout(false);
            this.qtpRebalancing.ResumeLayout(false);
            this.splitContainerRebalanceo.Panel1.ResumeLayout(false);
            this.splitContainerRebalanceo.Panel1.PerformLayout();
            this.splitContainerRebalanceo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRebalanceo)).EndInit();
            this.splitContainerRebalanceo.ResumeLayout(false);
            this.PanelRebalanceo.Panel1.ResumeLayout(false);
            this.PanelRebalanceo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelRebalanceo)).EndInit();
            this.PanelRebalanceo.ResumeLayout(false);
            this.qtpWeights.ResumeLayout(false);
            this.splitContainerPonderaciones.Panel1.ResumeLayout(false);
            this.splitContainerPonderaciones.Panel1.PerformLayout();
            this.splitContainerPonderaciones.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPonderaciones)).EndInit();
            this.splitContainerPonderaciones.ResumeLayout(false);
            this.BarraFormulario.ResumeLayout(false);
            this.BarraFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Qios.DevSuite.Components.QTabControl qTabControl;
        private Qios.DevSuite.Components.QTabPage qtpRebalancing;
        private System.Windows.Forms.SplitContainer splitContainerRebalanceo;
        private System.Windows.Forms.SplitContainer PanelRebalanceo;
        private BVRD.Windows.Controls.Controls.usDataView udvRebalancing;
        private BVRD.Windows.Controls.Controls.usDataView udvRebalancingExcluded;
        private Qios.DevSuite.Components.QTabPage qtpWeights;
        private System.Windows.Forms.SplitContainer splitContainerPonderaciones;
        private BVRD.Windows.Controls.Controls.usDataView udvWeights;
        private System.Windows.Forms.DateTimePicker txtCurrentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtBeforeLastDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtLastDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTIPPP;
        private System.Windows.Forms.Button btnLoadExcelRebalanceo;
        private System.Windows.Forms.TextBox txtArchivoExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargardatos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip BarraFormulario;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorMercado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPonderacionTotalDEC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPonderacionTotalPOR;
        private System.Windows.Forms.Button btnCargardatosPonderaciones;
        private System.Windows.Forms.Button btnLoadExcelPonderaciones;
        private System.Windows.Forms.TextBox txtArchivoExcelPonderaciones;
        private System.Windows.Forms.Label label9;
    }
}