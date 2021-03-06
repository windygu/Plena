namespace M4.M4v2.Alerts
{
  partial class ctlAlert
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlAlert));
      this.pnlTrade = new System.Windows.Forms.Panel();
      this.grpTradeOptions = new System.Windows.Forms.GroupBox();
      this.cboExchanges = new System.Windows.Forms.ComboBox();
      this.txtSymbolOrder = new System.Windows.Forms.TextBox();
      this.lblExchange = new System.Windows.Forms.Label();
      this.lblSymbol = new System.Windows.Forms.Label();
      this.udQuantity = new System.Windows.Forms.NumericUpDown();
      this.lblQuantity = new System.Windows.Forms.Label();
      this.cmbPortfolio = new System.Windows.Forms.ComboBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.grpExpires = new System.Windows.Forms.GroupBox();
      this.rdoGTCHours = new System.Windows.Forms.RadioButton();
      this.rdoGTC = new System.Windows.Forms.RadioButton();
      this.rdoDayHours = new System.Windows.Forms.RadioButton();
      this.rdoDay = new System.Windows.Forms.RadioButton();
      this.grpOrderType = new System.Windows.Forms.GroupBox();
      this.txtStopLimit = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.rdoStopLimit = new System.Windows.Forms.RadioButton();
      this.rdoLimit = new System.Windows.Forms.RadioButton();
      this.rdoStopMarket = new System.Windows.Forms.RadioButton();
      this.rdoMarket = new System.Windows.Forms.RadioButton();
      this.txtExitLongScript = new System.Windows.Forms.TextBox();
      this.tpExitShort = new System.Windows.Forms.TabPage();
      this.txtExitShortScript = new System.Windows.Forms.TextBox();
      this.m_ImgList = new System.Windows.Forms.ImageList(this.components);
      this.tpExitLong = new System.Windows.Forms.TabPage();
      this.txtSellScript = new System.Windows.Forms.TextBox();
      this.tabScripts = new System.Windows.Forms.TabControl();
      this.tpBuy = new System.Windows.Forms.TabPage();
      this.txtBuyScript = new System.Windows.Forms.TextBox();
      this.tpSell = new System.Windows.Forms.TabPage();
      this.cboAlerts = new System.Windows.Forms.ComboBox();
      this.grpData = new System.Windows.Forms.GroupBox();
      this.cboPeriodicity = new System.Windows.Forms.ComboBox();
      this.Label6 = new System.Windows.Forms.Label();
      this.txtInterval = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.txtBars = new System.Windows.Forms.TextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.txtSymbol = new System.Windows.Forms.TextBox();
      this.grpAlerts = new System.Windows.Forms.GroupBox();
      this.m_ListAlerts = new System.Windows.Forms.ListView();
      this.Time = new System.Windows.Forms.ColumnHeader();
      this.Alert = new System.Windows.Forms.ColumnHeader();
      this.cmdDelete = new System.Windows.Forms.Button();
      this.grpSaveLoad = new System.Windows.Forms.GroupBox();
      this.lblAlert = new System.Windows.Forms.Label();
      this.cmdSave = new System.Windows.Forms.Button();
      this.txtAlertName = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.chkEnableOrder = new System.Windows.Forms.CheckBox();
      this.cmdEnable = new System.Windows.Forms.Button();
      this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
      this.cmdDocumentation = new System.Windows.Forms.Button();
      this.pnlTrade.SuspendLayout();
      this.grpTradeOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.udQuantity)).BeginInit();
      this.grpExpires.SuspendLayout();
      this.grpOrderType.SuspendLayout();
      this.tpExitShort.SuspendLayout();
      this.tpExitLong.SuspendLayout();
      this.tabScripts.SuspendLayout();
      this.tpBuy.SuspendLayout();
      this.tpSell.SuspendLayout();
      this.grpData.SuspendLayout();
      this.grpAlerts.SuspendLayout();
      this.grpSaveLoad.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTrade
      // 
      this.pnlTrade.Controls.Add(this.grpTradeOptions);
      this.pnlTrade.Controls.Add(this.cmbPortfolio);
      this.pnlTrade.Controls.Add(this.Label2);
      this.pnlTrade.Controls.Add(this.grpExpires);
      this.pnlTrade.Controls.Add(this.grpOrderType);
      this.pnlTrade.Enabled = false;
      this.pnlTrade.Location = new System.Drawing.Point(13, 391);
      this.pnlTrade.Name = "pnlTrade";
      this.pnlTrade.Size = new System.Drawing.Size(706, 192);
      this.pnlTrade.TabIndex = 153;
      // 
      // grpTradeOptions
      // 
      this.grpTradeOptions.Controls.Add(this.cboExchanges);
      this.grpTradeOptions.Controls.Add(this.txtSymbolOrder);
      this.grpTradeOptions.Controls.Add(this.lblExchange);
      this.grpTradeOptions.Controls.Add(this.lblSymbol);
      this.grpTradeOptions.Controls.Add(this.udQuantity);
      this.grpTradeOptions.Controls.Add(this.lblQuantity);
      this.grpTradeOptions.Location = new System.Drawing.Point(1, 66);
      this.grpTradeOptions.Name = "grpTradeOptions";
      this.grpTradeOptions.Size = new System.Drawing.Size(245, 122);
      this.grpTradeOptions.TabIndex = 13;
      this.grpTradeOptions.Text = "Trade Options";
      // 
      // cboExchanges
      // 
      this.cboExchanges.Location = new System.Drawing.Point(103, 59);
      this.cboExchanges.Name = "cboExchanges";
      this.cboExchanges.Size = new System.Drawing.Size(92, 22);
      this.cboExchanges.TabIndex = 17;
      this.cboExchanges.SelectedIndexChanged += new System.EventHandler(this.cboExchanges_SelectedIndexChanged);
      // 
      // txtSymbolOrder
      // 
      this.txtSymbolOrder.Location = new System.Drawing.Point(103, 34);
      this.txtSymbolOrder.Name = "txtSymbolOrder";
      this.txtSymbolOrder.Size = new System.Drawing.Size(92, 18);
      this.txtSymbolOrder.TabIndex = 16;
      this.txtSymbolOrder.TextChanged += new System.EventHandler(this.txtSymbolOrder_TextChanged);
      // 
      // lblExchange
      // 
      this.lblExchange.AutoSize = true;
      this.lblExchange.BackColor = System.Drawing.Color.Transparent;
      this.lblExchange.Location = new System.Drawing.Point(40, 63);
      this.lblExchange.Name = "lblExchange";
      this.lblExchange.Size = new System.Drawing.Size(55, 13);
      this.lblExchange.TabIndex = 54;
      this.lblExchange.Text = "Exchange";
      // 
      // lblSymbol
      // 
      this.lblSymbol.AutoSize = true;
      this.lblSymbol.BackColor = System.Drawing.Color.Transparent;
      this.lblSymbol.Location = new System.Drawing.Point(54, 37);
      this.lblSymbol.Name = "lblSymbol";
      this.lblSymbol.Size = new System.Drawing.Size(41, 13);
      this.lblSymbol.TabIndex = 52;
      this.lblSymbol.Text = "Symbol";
      // 
      // udQuantity
      // 
      this.udQuantity.Location = new System.Drawing.Point(103, 86);
      this.udQuantity.Name = "udQuantity";
      this.udQuantity.Size = new System.Drawing.Size(60, 18);
      this.udQuantity.TabIndex = 18;
      this.udQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.udQuantity.ValueChanged += new System.EventHandler(this.udQuantity_ValueChanged);
      // 
      // lblQuantity
      // 
      this.lblQuantity.AutoSize = true;
      this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
      this.lblQuantity.Location = new System.Drawing.Point(49, 90);
      this.lblQuantity.Name = "lblQuantity";
      this.lblQuantity.Size = new System.Drawing.Size(46, 13);
      this.lblQuantity.TabIndex = 49;
      this.lblQuantity.Text = "Quantity";
      // 
      // cmbPortfolio
      // 
      this.cmbPortfolio.Location = new System.Drawing.Point(52, 30);
      this.cmbPortfolio.Name = "cmbPortfolio";
      this.cmbPortfolio.Size = new System.Drawing.Size(170, 22);
      this.cmbPortfolio.TabIndex = 12;
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(2, 34);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(45, 13);
      this.Label2.TabIndex = 124;
      this.Label2.Text = "Portfolio";
      // 
      // grpExpires
      // 
      this.grpExpires.Controls.Add(this.rdoGTCHours);
      this.grpExpires.Controls.Add(this.rdoGTC);
      this.grpExpires.Controls.Add(this.rdoDayHours);
      this.grpExpires.Controls.Add(this.rdoDay);
      this.grpExpires.Location = new System.Drawing.Point(486, 66);
      this.grpExpires.Name = "grpExpires";
      this.grpExpires.Size = new System.Drawing.Size(211, 122);
      this.grpExpires.TabIndex = 25;
      this.grpExpires.Text = "Expires";
      // 
      // rdoGTCHours
      // 
      this.rdoGTCHours.AutoSize = true;
      this.rdoGTCHours.Location = new System.Drawing.Point(92, 58);
      this.rdoGTCHours.Name = "rdoGTCHours";
      this.rdoGTCHours.Size = new System.Drawing.Size(108, 17);
      this.rdoGTCHours.TabIndex = 29;
      this.rdoGTCHours.Text = "GTC + Ext. Hours";
      this.rdoGTCHours.UseVisualStyleBackColor = false;
      this.rdoGTCHours.CheckedChanged += new System.EventHandler(this.rdoGTCHours_CheckedChanged);
      // 
      // rdoGTC
      // 
      this.rdoGTC.AutoSize = true;
      this.rdoGTC.Location = new System.Drawing.Point(13, 59);
      this.rdoGTC.Name = "rdoGTC";
      this.rdoGTC.Size = new System.Drawing.Size(47, 17);
      this.rdoGTC.TabIndex = 28;
      this.rdoGTC.Text = "GTC";
      this.rdoGTC.UseVisualStyleBackColor = false;
      this.rdoGTC.CheckedChanged += new System.EventHandler(this.rdoGTC_CheckedChanged);
      // 
      // rdoDayHours
      // 
      this.rdoDayHours.AutoSize = true;
      this.rdoDayHours.Location = new System.Drawing.Point(92, 31);
      this.rdoDayHours.Name = "rdoDayHours";
      this.rdoDayHours.Size = new System.Drawing.Size(105, 17);
      this.rdoDayHours.TabIndex = 27;
      this.rdoDayHours.Text = "Day + Ext. Hours";
      this.rdoDayHours.UseVisualStyleBackColor = false;
      this.rdoDayHours.CheckedChanged += new System.EventHandler(this.rdoDayHours_CheckedChanged);
      // 
      // rdoDay
      // 
      this.rdoDay.AutoSize = true;
      this.rdoDay.Checked = true;
      this.rdoDay.Location = new System.Drawing.Point(13, 31);
      this.rdoDay.Name = "rdoDay";
      this.rdoDay.Size = new System.Drawing.Size(44, 17);
      this.rdoDay.TabIndex = 26;
      this.rdoDay.TabStop = true;
      this.rdoDay.Text = "Day";
      this.rdoDay.UseVisualStyleBackColor = false;
      this.rdoDay.CheckedChanged += new System.EventHandler(this.rdoDay_CheckedChanged);
      // 
      // grpOrderType
      // 
      this.grpOrderType.Controls.Add(this.txtStopLimit);
      this.grpOrderType.Controls.Add(this.Label10);
      this.grpOrderType.Controls.Add(this.rdoStopLimit);
      this.grpOrderType.Controls.Add(this.rdoLimit);
      this.grpOrderType.Controls.Add(this.rdoStopMarket);
      this.grpOrderType.Controls.Add(this.rdoMarket);
      this.grpOrderType.Location = new System.Drawing.Point(252, 66);
      this.grpOrderType.Name = "grpOrderType";
      this.grpOrderType.Size = new System.Drawing.Size(228, 122);
      this.grpOrderType.TabIndex = 19;
      this.grpOrderType.Text = "Order Type";
      // 
      // txtStopLimit
      // 
      this.txtStopLimit.Location = new System.Drawing.Point(118, 84);
      this.txtStopLimit.Name = "txtStopLimit";
      this.txtStopLimit.Size = new System.Drawing.Size(79, 18);
      this.txtStopLimit.TabIndex = 24;
      this.txtStopLimit.TextChanged += new System.EventHandler(this.txtStopLimit_TextChanged);
      // 
      // Label10
      // 
      this.Label10.AutoSize = true;
      this.Label10.BackColor = System.Drawing.Color.Transparent;
      this.Label10.Location = new System.Drawing.Point(25, 87);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(88, 13);
      this.Label10.TabIndex = 45;
      this.Label10.Text = "Stop / Limit Price";
      // 
      // rdoStopLimit
      // 
      this.rdoStopLimit.AutoSize = true;
      this.rdoStopLimit.Location = new System.Drawing.Point(118, 59);
      this.rdoStopLimit.Name = "rdoStopLimit";
      this.rdoStopLimit.Size = new System.Drawing.Size(71, 17);
      this.rdoStopLimit.TabIndex = 23;
      this.rdoStopLimit.Text = "Stop Limit";
      this.rdoStopLimit.UseVisualStyleBackColor = false;
      this.rdoStopLimit.CheckedChanged += new System.EventHandler(this.rdoStopLimit_CheckedChanged);
      // 
      // rdoLimit
      // 
      this.rdoLimit.AutoSize = true;
      this.rdoLimit.Location = new System.Drawing.Point(118, 32);
      this.rdoLimit.Name = "rdoLimit";
      this.rdoLimit.Size = new System.Drawing.Size(46, 17);
      this.rdoLimit.TabIndex = 21;
      this.rdoLimit.Text = "Limit";
      this.rdoLimit.UseVisualStyleBackColor = false;
      this.rdoLimit.CheckedChanged += new System.EventHandler(this.rdoLimit_CheckedChanged);
      // 
      // rdoStopMarket
      // 
      this.rdoStopMarket.AutoSize = true;
      this.rdoStopMarket.Location = new System.Drawing.Point(9, 58);
      this.rdoStopMarket.Name = "rdoStopMarket";
      this.rdoStopMarket.Size = new System.Drawing.Size(83, 17);
      this.rdoStopMarket.TabIndex = 22;
      this.rdoStopMarket.Text = "Stop Market";
      this.rdoStopMarket.UseVisualStyleBackColor = false;
      this.rdoStopMarket.CheckedChanged += new System.EventHandler(this.rdoStopMarket_CheckedChanged);
      // 
      // rdoMarket
      // 
      this.rdoMarket.AutoSize = true;
      this.rdoMarket.Checked = true;
      this.rdoMarket.Location = new System.Drawing.Point(9, 31);
      this.rdoMarket.Name = "rdoMarket";
      this.rdoMarket.Size = new System.Drawing.Size(58, 17);
      this.rdoMarket.TabIndex = 20;
      this.rdoMarket.TabStop = true;
      this.rdoMarket.Text = "Market";
      this.rdoMarket.UseVisualStyleBackColor = false;
      this.rdoMarket.CheckedChanged += new System.EventHandler(this.rdoMarket_CheckedChanged);
      // 
      // txtExitLongScript
      // 
      this.txtExitLongScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtExitLongScript.Location = new System.Drawing.Point(0, 0);
      this.txtExitLongScript.Multiline = true;
      this.txtExitLongScript.Name = "txtExitLongScript";
      this.txtExitLongScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtExitLongScript.Size = new System.Drawing.Size(200, 100);
      this.txtExitLongScript.TabIndex = 10;
      this.txtExitLongScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
      // 
      // tpExitShort
      // 
      this.tpExitShort.Controls.Add(this.txtExitShortScript);
      this.tpExitShort.ImageIndex = 3;
      this.tpExitShort.Name = "tpExitShort";
      this.tpExitShort.TabIndex = 4;
      this.tpExitShort.Text = "Exit Short Script";
      // 
      // txtExitShortScript
      // 
      this.txtExitShortScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtExitShortScript.Location = new System.Drawing.Point(0, 0);
      this.txtExitShortScript.Multiline = true;
      this.txtExitShortScript.Name = "txtExitShortScript";
      this.txtExitShortScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtExitShortScript.Size = new System.Drawing.Size(690, 183);
      this.txtExitShortScript.TabIndex = 11;
      this.txtExitShortScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
      // 
      // m_ImgList
      // 
      this.m_ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImgList.ImageStream")));
      this.m_ImgList.TransparentColor = System.Drawing.Color.Fuchsia;
      this.m_ImgList.Images.SetKeyName(0, "");
      this.m_ImgList.Images.SetKeyName(1, "");
      this.m_ImgList.Images.SetKeyName(2, "");
      this.m_ImgList.Images.SetKeyName(3, "");
      // 
      // tpExitLong
      // 
      this.tpExitLong.Controls.Add(this.txtExitLongScript);
      this.tpExitLong.ImageIndex = 2;
      this.tpExitLong.Name = "tpExitLong";
      this.tpExitLong.TabIndex = 3;
      this.tpExitLong.Text = "Exit Long Script";
      // 
      // txtSellScript
      // 
      this.txtSellScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtSellScript.Location = new System.Drawing.Point(0, 0);
      this.txtSellScript.Multiline = true;
      this.txtSellScript.Name = "txtSellScript";
      this.txtSellScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtSellScript.Size = new System.Drawing.Size(200, 100);
      this.txtSellScript.TabIndex = 9;
      this.txtSellScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
      // 
      // tabScripts
      // 
      this.tabScripts.Controls.Add(this.tpBuy);
      this.tabScripts.Controls.Add(this.tpSell);
      this.tabScripts.Controls.Add(this.tpExitLong);
      this.tabScripts.Controls.Add(this.tpExitShort);
      this.tabScripts.ImageList = this.m_ImgList;
      this.tabScripts.Location = new System.Drawing.Point(9, 142);
      this.tabScripts.Name = "tabScripts";
      this.tabScripts.SelectedIndex = 0;
      this.tabScripts.Size = new System.Drawing.Size(700, 218);
      this.tabScripts.TabIndex = 152;
      // 
      // tpBuy
      // 
      this.tpBuy.Controls.Add(this.txtBuyScript);
      this.tpBuy.ImageIndex = 0;
      this.tpBuy.Name = "tpBuy";
      this.tpBuy.TabIndex = 1;
      this.tpBuy.Text = "Buy Script";
      // 
      // txtBuyScript
      // 
      this.txtBuyScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtBuyScript.Location = new System.Drawing.Point(0, 0);
      this.txtBuyScript.Multiline = true;
      this.txtBuyScript.Name = "txtBuyScript";
      this.txtBuyScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtBuyScript.Size = new System.Drawing.Size(690, 183);
      this.txtBuyScript.TabIndex = 8;
      this.txtBuyScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
      // 
      // tpSell
      // 
      this.tpSell.Controls.Add(this.txtSellScript);
      this.tpSell.ImageIndex = 1;
      this.tpSell.Name = "tpSell";
      this.tpSell.TabIndex = 2;
      this.tpSell.Text = "Sell Script";
      // 
      // cboAlerts
      // 
      this.cboAlerts.Location = new System.Drawing.Point(81, 72);
      this.cboAlerts.Name = "cboAlerts";
      this.cboAlerts.Size = new System.Drawing.Size(179, 22);
      this.cboAlerts.TabIndex = 2;
      this.cboAlerts.SelectedIndexChanged += new System.EventHandler(this.cboAlerts_SelectedIndexChanged);
      // 
      // grpData
      // 
      this.grpData.Controls.Add(this.cboPeriodicity);
      this.grpData.Controls.Add(this.Label6);
      this.grpData.Controls.Add(this.txtInterval);
      this.grpData.Controls.Add(this.Label7);
      this.grpData.Controls.Add(this.Label8);
      this.grpData.Controls.Add(this.txtBars);
      this.grpData.Controls.Add(this.Label9);
      this.grpData.Controls.Add(this.txtSymbol);
      this.grpData.Location = new System.Drawing.Point(374, 9);
      this.grpData.Name = "grpData";
      this.grpData.Size = new System.Drawing.Size(338, 119);
      this.grpData.TabIndex = 147;
      this.grpData.Text = "Data Source";
      // 
      // cboPeriodicity
      // 
      this.cboPeriodicity.Items.AddRange(new object[] {"Minute","Hour", "Day", "Week"});
      this.cboPeriodicity.Location = new System.Drawing.Point(75, 72);
      this.cboPeriodicity.Name = "cboPeriodicity";
      this.cboPeriodicity.Size = new System.Drawing.Size(79, 20);
      this.cboPeriodicity.TabIndex = 110;
      this.cboPeriodicity.SelectedIndexChanged += new System.EventHandler(this.cboPeriodicity_SelectedIndexChanged);
      // 
      // Label6
      // 
      this.Label6.AutoSize = true;
      this.Label6.BackColor = System.Drawing.Color.Transparent;
      this.Label6.Location = new System.Drawing.Point(167, 42);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(61, 13);
      this.Label6.TabIndex = 109;
      this.Label6.Text = "Bar Interval";
      // 
      // txtInterval
      // 
      this.txtInterval.Location = new System.Drawing.Point(235, 40);
      this.txtInterval.Name = "txtInterval";
      this.txtInterval.Size = new System.Drawing.Size(76, 18);
      this.txtInterval.TabIndex = 5;
      this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
      // 
      // Label7
      // 
      this.Label7.AutoSize = true;
      this.Label7.BackColor = System.Drawing.Color.Transparent;
      this.Label7.Location = new System.Drawing.Point(13, 76);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(55, 13);
      this.Label7.TabIndex = 108;
      this.Label7.Text = "Periodicity";
      // 
      // Label8
      // 
      this.Label8.AutoSize = true;
      this.Label8.BackColor = System.Drawing.Color.Transparent;
      this.Label8.Location = new System.Drawing.Point(170, 75);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(58, 13);
      this.Label8.TabIndex = 107;
      this.Label8.Text = "Bar History";
      // 
      // txtBars
      // 
      this.txtBars.Location = new System.Drawing.Point(235, 72);
      this.txtBars.Name = "txtBars";
      this.txtBars.Size = new System.Drawing.Size(76, 18);
      this.txtBars.TabIndex = 7;
      this.txtBars.TextChanged += new System.EventHandler(this.txtBars_TextChanged);
      // 
      // Label9
      // 
      this.Label9.AutoSize = true;
      this.Label9.BackColor = System.Drawing.Color.Transparent;
      this.Label9.Location = new System.Drawing.Point(26, 42);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(41, 13);
      this.Label9.TabIndex = 106;
      this.Label9.Text = "Symbol";
      // 
      // txtSymbol
      // 
      this.txtSymbol.Location = new System.Drawing.Point(75, 40);
      this.txtSymbol.Name = "txtSymbol";
      this.txtSymbol.Size = new System.Drawing.Size(79, 18);
      this.txtSymbol.TabIndex = 4;
      this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
      // 
      // grpAlerts
      // 
      this.grpAlerts.Controls.Add(this.m_ListAlerts);
      this.grpAlerts.Location = new System.Drawing.Point(718, 9);
      this.grpAlerts.Name = "grpAlerts";
      this.grpAlerts.Size = new System.Drawing.Size(270, 585);
      this.grpAlerts.TabIndex = 151;
      this.grpAlerts.Text = "Data Source";
      // 
      // m_ListAlerts
      // 
      this.m_ListAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
      this.m_ListAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.m_ListAlerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Alert});
      this.m_ListAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_ListAlerts.ForeColor = System.Drawing.SystemColors.WindowText;
      this.m_ListAlerts.FullRowSelect = true;
      this.m_ListAlerts.GridLines = true;
      this.m_ListAlerts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.m_ListAlerts.Location = new System.Drawing.Point(1, 22);
      this.m_ListAlerts.MultiSelect = false;
      this.m_ListAlerts.Name = "m_ListAlerts";
      this.m_ListAlerts.Size = new System.Drawing.Size(263, 557);
      this.m_ListAlerts.TabIndex = 31;
      this.m_ListAlerts.UseCompatibleStateImageBehavior = false;
      this.m_ListAlerts.View = System.Windows.Forms.View.Details;
      // 
      // Time
      // 
      this.Time.Text = "";
      this.Time.Width = 135;
      // 
      // Alert
      // 
      this.Alert.Text = "";
      // 
      // cmdDelete
      // 
      this.cmdDelete.Enabled = false;
      this.cmdDelete.Location = new System.Drawing.Point(272, 72);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Size = new System.Drawing.Size(61, 23);
      this.cmdDelete.TabIndex = 3;
      this.cmdDelete.Text = "&Delete";
      this.cmdDelete.UseVisualStyleBackColor = false;
      this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
      // 
      // grpSaveLoad
      // 
      this.grpSaveLoad.Controls.Add(this.cmdDelete);
      this.grpSaveLoad.Controls.Add(this.cboAlerts);
      this.grpSaveLoad.Controls.Add(this.lblAlert);
      this.grpSaveLoad.Controls.Add(this.cmdSave);
      this.grpSaveLoad.Controls.Add(this.txtAlertName);
      this.grpSaveLoad.Controls.Add(this.Label1);
      this.grpSaveLoad.Location = new System.Drawing.Point(9, 9);
      this.grpSaveLoad.Name = "grpSaveLoad";
      this.grpSaveLoad.Size = new System.Drawing.Size(358, 119);
      this.grpSaveLoad.TabIndex = 146;
      this.grpSaveLoad.Text = "Data Source";
      // 
      // lblAlert
      // 
      this.lblAlert.AutoSize = true;
      this.lblAlert.BackColor = System.Drawing.Color.Transparent;
      this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAlert.ForeColor = System.Drawing.SystemColors.WindowText;
      this.lblAlert.Location = new System.Drawing.Point(20, 76);
      this.lblAlert.Name = "lblAlert";
      this.lblAlert.Size = new System.Drawing.Size(55, 13);
      this.lblAlert.TabIndex = 134;
      this.lblAlert.Text = "Load Alert";
      // 
      // cmdSave
      // 
      this.cmdSave.Location = new System.Drawing.Point(272, 38);
      this.cmdSave.Name = "cmdSave";
      this.cmdSave.Size = new System.Drawing.Size(61, 23);
      this.cmdSave.TabIndex = 1;
      this.cmdSave.Text = "&Save";
      this.cmdSave.UseVisualStyleBackColor = false;
      this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
      // 
      // txtAlertName
      // 
      this.txtAlertName.Location = new System.Drawing.Point(81, 40);
      this.txtAlertName.Name = "txtAlertName";
      this.txtAlertName.Size = new System.Drawing.Size(178, 18);
      this.txtAlertName.TabIndex = 0;
      this.txtAlertName.TextChanged += new System.EventHandler(this.txtAlertName_TextChanged);
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.Location = new System.Drawing.Point(16, 42);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(59, 13);
      this.Label1.TabIndex = 129;
      this.Label1.Text = "Alert Name";
      // 
      // chkEnableOrder
      // 
      this.chkEnableOrder.AutoSize = true;
      this.chkEnableOrder.Location = new System.Drawing.Point(15, 390);
      this.chkEnableOrder.Name = "chkEnableOrder";
      this.chkEnableOrder.Size = new System.Drawing.Size(152, 17);
      this.chkEnableOrder.TabIndex = 150;
      this.chkEnableOrder.Text = "Enable Automated Trading";
      this.chkEnableOrder.CheckedChanged += new System.EventHandler(this.chkEnableOrder_CheckedChanged);
      // 
      // cmdEnable
      // 
      this.cmdEnable.Location = new System.Drawing.Point(612, 373);
      this.cmdEnable.Name = "cmdEnable";
      this.cmdEnable.Size = new System.Drawing.Size(97, 23);
      this.cmdEnable.TabIndex = 148;
      this.cmdEnable.Text = "&Enable Alerts";
      this.cmdEnable.UseVisualStyleBackColor = false;
      this.cmdEnable.Click += new System.EventHandler(this.cmdEnable_Click);
      // 
      // tmrUpdate
      // 
      this.tmrUpdate.Interval = 500;
      this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
      // 
      // cmdDocumentation
      // 
      this.cmdDocumentation.Location = new System.Drawing.Point(505, 373);
      this.cmdDocumentation.Name = "cmdDocumentation";
      this.cmdDocumentation.Size = new System.Drawing.Size(97, 23);
      this.cmdDocumentation.TabIndex = 149;
      this.cmdDocumentation.Text = "&Script Guide";
      this.cmdDocumentation.UseVisualStyleBackColor = false;
      this.cmdDocumentation.Click += new System.EventHandler(this.cmdDocumentation_Click);
      // 
      // ctlAlert
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabScripts);
      this.Controls.Add(this.grpData);
      this.Controls.Add(this.grpAlerts);
      this.Controls.Add(this.grpSaveLoad);
      this.Controls.Add(this.chkEnableOrder);
      this.Controls.Add(this.cmdEnable);
      this.Controls.Add(this.cmdDocumentation);
      this.Controls.Add(this.pnlTrade);
      this.Name = "ctlAlert";
      this.Size = new System.Drawing.Size(997, 602);
      this.Load += new System.EventHandler(this.ctlAlert_Load);
      this.Resize += new System.EventHandler(this.ctlAlert_Resize);
      this.pnlTrade.ResumeLayout(false);
      this.pnlTrade.PerformLayout();
      this.grpTradeOptions.ResumeLayout(false);
      this.grpTradeOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.udQuantity)).EndInit();
      this.grpExpires.ResumeLayout(false);
      this.grpExpires.PerformLayout();
      this.grpOrderType.ResumeLayout(false);
      this.grpOrderType.PerformLayout();
      this.tpExitShort.ResumeLayout(false);
      this.tpExitLong.ResumeLayout(false);
      this.tabScripts.ResumeLayout(false);
      this.tpBuy.ResumeLayout(false);
      this.tpSell.ResumeLayout(false);
      this.grpData.ResumeLayout(false);
      this.grpData.PerformLayout();
      this.grpAlerts.ResumeLayout(false);
      this.grpSaveLoad.ResumeLayout(false);
      this.grpSaveLoad.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Panel pnlTrade;
    internal System.Windows.Forms.GroupBox grpTradeOptions;
    internal System.Windows.Forms.ComboBox cboExchanges;
    internal System.Windows.Forms.TextBox txtSymbolOrder;
    internal System.Windows.Forms.Label lblExchange;
    internal System.Windows.Forms.Label lblSymbol;
    internal System.Windows.Forms.NumericUpDown udQuantity;
    internal System.Windows.Forms.Label lblQuantity;
    internal System.Windows.Forms.ComboBox cmbPortfolio;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.GroupBox grpExpires;
    internal System.Windows.Forms.RadioButton rdoGTCHours;
    internal System.Windows.Forms.RadioButton rdoGTC;
    internal System.Windows.Forms.RadioButton rdoDayHours;
    internal System.Windows.Forms.RadioButton rdoDay;
    internal System.Windows.Forms.GroupBox grpOrderType;
    internal System.Windows.Forms.TextBox txtStopLimit;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.RadioButton rdoStopLimit;
    internal System.Windows.Forms.RadioButton rdoLimit;
    internal System.Windows.Forms.RadioButton rdoStopMarket;
    internal System.Windows.Forms.RadioButton rdoMarket;
    internal System.Windows.Forms.TextBox txtExitLongScript;
    internal System.Windows.Forms.TabPage tpExitShort;
    internal System.Windows.Forms.TextBox txtExitShortScript;
    internal System.Windows.Forms.ImageList m_ImgList;
    internal System.Windows.Forms.TabPage tpExitLong;
    internal System.Windows.Forms.TextBox txtSellScript;
    internal System.Windows.Forms.TabControl tabScripts;
    internal System.Windows.Forms.TabPage tpBuy;
    internal System.Windows.Forms.TextBox txtBuyScript;
    internal System.Windows.Forms.TabPage tpSell;
    internal System.Windows.Forms.ComboBox cboAlerts;
    internal System.Windows.Forms.GroupBox grpData;
    internal System.Windows.Forms.ComboBox cboPeriodicity;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.TextBox txtInterval;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.Label Label8;
    internal System.Windows.Forms.TextBox txtBars;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.TextBox txtSymbol;
    internal System.Windows.Forms.GroupBox grpAlerts;
    internal System.Windows.Forms.ListView m_ListAlerts;
    internal System.Windows.Forms.ColumnHeader Time;
    internal System.Windows.Forms.ColumnHeader Alert;
    internal System.Windows.Forms.Button cmdDelete;
    internal System.Windows.Forms.GroupBox grpSaveLoad;
    internal System.Windows.Forms.Label lblAlert;
    internal System.Windows.Forms.Button cmdSave;
    internal System.Windows.Forms.TextBox txtAlertName;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.CheckBox chkEnableOrder;
    internal System.Windows.Forms.Button cmdEnable;
    internal System.Windows.Forms.Timer tmrUpdate;
    internal System.Windows.Forms.Button cmdDocumentation;
  }
}
