namespace Restaurant
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.subHeading = new System.Windows.Forms.Label();
            this.ordManagerButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.resManagerButton = new System.Windows.Forms.Button();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.resGroupBox = new System.Windows.Forms.GroupBox();
            this.removeResButton = new System.Windows.Forms.Button();
            this.reservationTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addResGroupBox = new System.Windows.Forms.GroupBox();
            this.resClearButton = new System.Windows.Forms.Button();
            this.newResTableNum = new System.Windows.Forms.NumericUpDown();
            this.newResParty = new System.Windows.Forms.NumericUpDown();
            this.resTableNumLabel = new System.Windows.Forms.Label();
            this.resSubmit = new System.Windows.Forms.Button();
            this.newResDate = new System.Windows.Forms.DateTimePicker();
            this.resDateLabel = new System.Windows.Forms.Label();
            this.newResPhone = new System.Windows.Forms.TextBox();
            this.newResLast = new System.Windows.Forms.TextBox();
            this.newResFirst = new System.Windows.Forms.TextBox();
            this.resPhoneLabel = new System.Windows.Forms.Label();
            this.resPartyLabel = new System.Windows.Forms.Label();
            this.resLNameLabel = new System.Windows.Forms.Label();
            this.resFNameLabel = new System.Windows.Forms.Label();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderClearButton = new System.Windows.Forms.Button();
            this.deleteFoodButton = new System.Windows.Forms.Button();
            this.newOrderFoodList = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.ComboBox();
            this.orderSelectLabel = new System.Windows.Forms.Label();
            this.onOrderLabel = new System.Windows.Forms.Label();
            this.orderSubmitButton = new System.Windows.Forms.Button();
            this.newOrderDate = new System.Windows.Forms.DateTimePicker();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.newOrderPhone = new System.Windows.Forms.TextBox();
            this.newOrderLast = new System.Windows.Forms.TextBox();
            this.newOrderFirst = new System.Windows.Forms.TextBox();
            this.orderPhoneLabel = new System.Windows.Forms.Label();
            this.orderLNameLabel = new System.Windows.Forms.Label();
            this.orderFNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.managerToggle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.reservationTab.SuspendLayout();
            this.resGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).BeginInit();
            this.addResGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newResTableNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newResParty)).BeginInit();
            this.orderTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.newOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.menuTab);
            this.tabControl1.Controls.Add(this.reservationTab);
            this.tabControl1.Controls.Add(this.orderTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 460);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // menuTab
            // 
            this.menuTab.BackColor = System.Drawing.SystemColors.Control;
            this.menuTab.Controls.Add(this.label2);
            this.menuTab.Controls.Add(this.settingsButton);
            this.menuTab.Controls.Add(this.subHeading);
            this.menuTab.Controls.Add(this.ordManagerButton);
            this.menuTab.Controls.Add(this.menuLabel);
            this.menuTab.Controls.Add(this.resManagerButton);
            this.menuTab.Location = new System.Drawing.Point(4, 5);
            this.menuTab.Name = "menuTab";
            this.menuTab.Padding = new System.Windows.Forms.Padding(3);
            this.menuTab.Size = new System.Drawing.Size(1087, 451);
            this.menuTab.TabIndex = 0;
            this.menuTab.Text = "Main Menu";
            // 
            // subHeading
            // 
            this.subHeading.AutoSize = true;
            this.subHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.subHeading.Location = new System.Drawing.Point(394, 140);
            this.subHeading.MaximumSize = new System.Drawing.Size(300, 0);
            this.subHeading.Name = "subHeading";
            this.subHeading.Size = new System.Drawing.Size(286, 111);
            this.subHeading.TabIndex = 1;
            this.subHeading.Text = "Please select an option below to get started:";
            this.subHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ordManagerButton
            // 
            this.ordManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ordManagerButton.Location = new System.Drawing.Point(546, 306);
            this.ordManagerButton.Name = "ordManagerButton";
            this.ordManagerButton.Size = new System.Drawing.Size(150, 60);
            this.ordManagerButton.TabIndex = 2;
            this.ordManagerButton.Text = "Order Manager";
            this.ordManagerButton.UseVisualStyleBackColor = true;
            this.ordManagerButton.Click += new System.EventHandler(this.ordManagerButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.menuLabel.Location = new System.Drawing.Point(384, 29);
            this.menuLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(312, 92);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Welcome to The Main Menu!";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resManagerButton
            // 
            this.resManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resManagerButton.Location = new System.Drawing.Point(390, 306);
            this.resManagerButton.Name = "resManagerButton";
            this.resManagerButton.Size = new System.Drawing.Size(150, 60);
            this.resManagerButton.TabIndex = 1;
            this.resManagerButton.Text = "Reservation Manager";
            this.resManagerButton.UseVisualStyleBackColor = true;
            this.resManagerButton.Click += new System.EventHandler(this.resManagerButton_Click);
            // 
            // reservationTab
            // 
            this.reservationTab.BackColor = System.Drawing.SystemColors.Control;
            this.reservationTab.Controls.Add(this.resGroupBox);
            this.reservationTab.Controls.Add(this.addResGroupBox);
            this.reservationTab.Location = new System.Drawing.Point(4, 5);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTab.Size = new System.Drawing.Size(1087, 451);
            this.reservationTab.TabIndex = 1;
            this.reservationTab.Text = "Reservations";
            // 
            // resGroupBox
            // 
            this.resGroupBox.Controls.Add(this.removeResButton);
            this.resGroupBox.Controls.Add(this.reservationTable);
            this.resGroupBox.Location = new System.Drawing.Point(368, 7);
            this.resGroupBox.Name = "resGroupBox";
            this.resGroupBox.Size = new System.Drawing.Size(702, 438);
            this.resGroupBox.TabIndex = 1;
            this.resGroupBox.TabStop = false;
            this.resGroupBox.Text = "Current Reservations";
            // 
            // removeResButton
            // 
            this.removeResButton.Location = new System.Drawing.Point(595, 387);
            this.removeResButton.Name = "removeResButton";
            this.removeResButton.Size = new System.Drawing.Size(101, 45);
            this.removeResButton.TabIndex = 0;
            this.removeResButton.Text = "Remove Selected Reservation";
            this.removeResButton.UseVisualStyleBackColor = true;
            this.removeResButton.Click += new System.EventHandler(this.removeResButton_Click);
            // 
            // reservationTable
            // 
            this.reservationTable.AllowUserToAddRows = false;
            this.reservationTable.AllowUserToDeleteRows = false;
            this.reservationTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Date,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Party,
            this.TableNum,
            this.dataGridViewTextBoxColumn7});
            this.reservationTable.Location = new System.Drawing.Point(7, 20);
            this.reservationTable.MultiSelect = false;
            this.reservationTable.Name = "reservationTable";
            this.reservationTable.ReadOnly = true;
            this.reservationTable.RowHeadersVisible = false;
            this.reservationTable.Size = new System.Drawing.Size(689, 361);
            this.reservationTable.TabIndex = 0;
            this.reservationTable.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "First";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Last";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Party
            // 
            this.Party.Frozen = true;
            this.Party.HeaderText = "# in Party";
            this.Party.Name = "Party";
            this.Party.ReadOnly = true;
            this.Party.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TableNum
            // 
            this.TableNum.Frozen = true;
            this.TableNum.HeaderText = "Table #";
            this.TableNum.Name = "TableNum";
            this.TableNum.ReadOnly = true;
            this.TableNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone #";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addResGroupBox
            // 
            this.addResGroupBox.Controls.Add(this.resClearButton);
            this.addResGroupBox.Controls.Add(this.newResTableNum);
            this.addResGroupBox.Controls.Add(this.newResParty);
            this.addResGroupBox.Controls.Add(this.resTableNumLabel);
            this.addResGroupBox.Controls.Add(this.resSubmit);
            this.addResGroupBox.Controls.Add(this.newResDate);
            this.addResGroupBox.Controls.Add(this.resDateLabel);
            this.addResGroupBox.Controls.Add(this.newResPhone);
            this.addResGroupBox.Controls.Add(this.newResLast);
            this.addResGroupBox.Controls.Add(this.newResFirst);
            this.addResGroupBox.Controls.Add(this.resPhoneLabel);
            this.addResGroupBox.Controls.Add(this.resPartyLabel);
            this.addResGroupBox.Controls.Add(this.resLNameLabel);
            this.addResGroupBox.Controls.Add(this.resFNameLabel);
            this.addResGroupBox.Location = new System.Drawing.Point(7, 7);
            this.addResGroupBox.Name = "addResGroupBox";
            this.addResGroupBox.Size = new System.Drawing.Size(341, 239);
            this.addResGroupBox.TabIndex = 0;
            this.addResGroupBox.TabStop = false;
            this.addResGroupBox.Text = "New Reservation";
            // 
            // resClearButton
            // 
            this.resClearButton.Location = new System.Drawing.Point(126, 200);
            this.resClearButton.Name = "resClearButton";
            this.resClearButton.Size = new System.Drawing.Size(75, 23);
            this.resClearButton.TabIndex = 7;
            this.resClearButton.Text = "Clear";
            this.resClearButton.UseVisualStyleBackColor = true;
            this.resClearButton.Click += new System.EventHandler(this.resClearButton_Click);
            // 
            // newResTableNum
            // 
            this.newResTableNum.Location = new System.Drawing.Point(126, 110);
            this.newResTableNum.Name = "newResTableNum";
            this.newResTableNum.Size = new System.Drawing.Size(62, 20);
            this.newResTableNum.TabIndex = 3;
            // 
            // newResParty
            // 
            this.newResParty.Location = new System.Drawing.Point(126, 80);
            this.newResParty.Name = "newResParty";
            this.newResParty.Size = new System.Drawing.Size(62, 20);
            this.newResParty.TabIndex = 2;
            // 
            // resTableNumLabel
            // 
            this.resTableNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resTableNumLabel.Location = new System.Drawing.Point(22, 110);
            this.resTableNumLabel.Name = "resTableNumLabel";
            this.resTableNumLabel.Size = new System.Drawing.Size(90, 20);
            this.resTableNumLabel.TabIndex = 11;
            this.resTableNumLabel.Text = "Table #:";
            this.resTableNumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resSubmit
            // 
            this.resSubmit.Location = new System.Drawing.Point(209, 200);
            this.resSubmit.Name = "resSubmit";
            this.resSubmit.Size = new System.Drawing.Size(109, 23);
            this.resSubmit.TabIndex = 6;
            this.resSubmit.Text = "Submit Reservation";
            this.resSubmit.UseVisualStyleBackColor = true;
            this.resSubmit.Click += new System.EventHandler(this.resSubmit_Click);
            // 
            // newResDate
            // 
            this.newResDate.CustomFormat = "ddd, MMM d, yyyy  - h:mm tt";
            this.newResDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newResDate.Location = new System.Drawing.Point(126, 170);
            this.newResDate.Name = "newResDate";
            this.newResDate.Size = new System.Drawing.Size(192, 20);
            this.newResDate.TabIndex = 5;
            // 
            // resDateLabel
            // 
            this.resDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resDateLabel.Location = new System.Drawing.Point(21, 170);
            this.resDateLabel.Name = "resDateLabel";
            this.resDateLabel.Size = new System.Drawing.Size(90, 20);
            this.resDateLabel.TabIndex = 8;
            this.resDateLabel.Text = "Date/Time:";
            this.resDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newResPhone
            // 
            this.newResPhone.Location = new System.Drawing.Point(126, 140);
            this.newResPhone.Name = "newResPhone";
            this.newResPhone.Size = new System.Drawing.Size(192, 20);
            this.newResPhone.TabIndex = 4;
            // 
            // newResLast
            // 
            this.newResLast.Location = new System.Drawing.Point(126, 50);
            this.newResLast.Name = "newResLast";
            this.newResLast.Size = new System.Drawing.Size(192, 20);
            this.newResLast.TabIndex = 1;
            // 
            // newResFirst
            // 
            this.newResFirst.Location = new System.Drawing.Point(126, 20);
            this.newResFirst.Name = "newResFirst";
            this.newResFirst.Size = new System.Drawing.Size(192, 20);
            this.newResFirst.TabIndex = 0;
            // 
            // resPhoneLabel
            // 
            this.resPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resPhoneLabel.Location = new System.Drawing.Point(21, 140);
            this.resPhoneLabel.Name = "resPhoneLabel";
            this.resPhoneLabel.Size = new System.Drawing.Size(90, 20);
            this.resPhoneLabel.TabIndex = 3;
            this.resPhoneLabel.Text = "Phone:";
            this.resPhoneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resPartyLabel
            // 
            this.resPartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resPartyLabel.Location = new System.Drawing.Point(21, 80);
            this.resPartyLabel.Name = "resPartyLabel";
            this.resPartyLabel.Size = new System.Drawing.Size(90, 20);
            this.resPartyLabel.TabIndex = 2;
            this.resPartyLabel.Text = "Party Size:";
            this.resPartyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resLNameLabel
            // 
            this.resLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resLNameLabel.Location = new System.Drawing.Point(21, 50);
            this.resLNameLabel.Name = "resLNameLabel";
            this.resLNameLabel.Size = new System.Drawing.Size(90, 20);
            this.resLNameLabel.TabIndex = 1;
            this.resLNameLabel.Text = "Last Name:";
            this.resLNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resFNameLabel
            // 
            this.resFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resFNameLabel.Location = new System.Drawing.Point(21, 20);
            this.resFNameLabel.Name = "resFNameLabel";
            this.resFNameLabel.Size = new System.Drawing.Size(90, 20);
            this.resFNameLabel.TabIndex = 0;
            this.resFNameLabel.Text = "First Name:";
            this.resFNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.groupBox1);
            this.orderTab.Controls.Add(this.newOrderGroupBox);
            this.orderTab.Location = new System.Drawing.Point(4, 5);
            this.orderTab.Name = "orderTab";
            this.orderTab.Size = new System.Drawing.Size(1087, 451);
            this.orderTab.TabIndex = 2;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeOrderButton);
            this.groupBox1.Controls.Add(this.orderTable);
            this.groupBox1.Location = new System.Drawing.Point(373, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Orders";
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Location = new System.Drawing.Point(601, 364);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(95, 45);
            this.removeOrderButton.TabIndex = 0;
            this.removeOrderButton.Text = "Remove Selected Order";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNum,
            this.Time,
            this.Items,
            this.Total,
            this.First,
            this.Last,
            this.Phone});
            this.orderTable.Location = new System.Drawing.Point(7, 20);
            this.orderTable.MultiSelect = false;
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.Size = new System.Drawing.Size(689, 338);
            this.orderTable.TabIndex = 0;
            this.orderTable.TabStop = false;
            // 
            // OrderNum
            // 
            this.OrderNum.Frozen = true;
            this.OrderNum.HeaderText = "#";
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.ReadOnly = true;
            this.OrderNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderNum.Width = 25;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 150;
            // 
            // Items
            // 
            this.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items.DefaultCellStyle = dataGridViewCellStyle6;
            this.Items.Frozen = true;
            this.Items.HeaderText = "Items";
            this.Items.MinimumWidth = 175;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Items.Width = 175;
            // 
            // Total
            // 
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 50;
            // 
            // First
            // 
            this.First.Frozen = true;
            this.First.HeaderText = "First";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            this.First.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Last
            // 
            this.Last.Frozen = true;
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.Frozen = true;
            this.Phone.HeaderText = "Phone #";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // newOrderGroupBox
            // 
            this.newOrderGroupBox.Controls.Add(this.orderClearButton);
            this.newOrderGroupBox.Controls.Add(this.deleteFoodButton);
            this.newOrderGroupBox.Controls.Add(this.newOrderFoodList);
            this.newOrderGroupBox.Controls.Add(this.addFoodButton);
            this.newOrderGroupBox.Controls.Add(this.menuList);
            this.newOrderGroupBox.Controls.Add(this.orderSelectLabel);
            this.newOrderGroupBox.Controls.Add(this.onOrderLabel);
            this.newOrderGroupBox.Controls.Add(this.orderSubmitButton);
            this.newOrderGroupBox.Controls.Add(this.newOrderDate);
            this.newOrderGroupBox.Controls.Add(this.orderDateLabel);
            this.newOrderGroupBox.Controls.Add(this.newOrderPhone);
            this.newOrderGroupBox.Controls.Add(this.newOrderLast);
            this.newOrderGroupBox.Controls.Add(this.newOrderFirst);
            this.newOrderGroupBox.Controls.Add(this.orderPhoneLabel);
            this.newOrderGroupBox.Controls.Add(this.orderLNameLabel);
            this.newOrderGroupBox.Controls.Add(this.orderFNameLabel);
            this.newOrderGroupBox.Location = new System.Drawing.Point(7, 7);
            this.newOrderGroupBox.Name = "newOrderGroupBox";
            this.newOrderGroupBox.Size = new System.Drawing.Size(341, 415);
            this.newOrderGroupBox.TabIndex = 0;
            this.newOrderGroupBox.TabStop = false;
            this.newOrderGroupBox.Text = "New Order";
            // 
            // orderClearButton
            // 
            this.orderClearButton.Location = new System.Drawing.Point(126, 369);
            this.orderClearButton.Name = "orderClearButton";
            this.orderClearButton.Size = new System.Drawing.Size(60, 23);
            this.orderClearButton.TabIndex = 7;
            this.orderClearButton.Text = "Clear";
            this.orderClearButton.UseVisualStyleBackColor = true;
            this.orderClearButton.Click += new System.EventHandler(this.orderClearButton_Click);
            // 
            // deleteFoodButton
            // 
            this.deleteFoodButton.Enabled = false;
            this.deleteFoodButton.Location = new System.Drawing.Point(192, 188);
            this.deleteFoodButton.Name = "deleteFoodButton";
            this.deleteFoodButton.Size = new System.Drawing.Size(125, 23);
            this.deleteFoodButton.TabIndex = 17;
            this.deleteFoodButton.TabStop = false;
            this.deleteFoodButton.Text = "Remove Selected Item";
            this.deleteFoodButton.UseVisualStyleBackColor = true;
            this.deleteFoodButton.Click += new System.EventHandler(this.deleteFoodButton_Click);
            // 
            // newOrderFoodList
            // 
            this.newOrderFoodList.AllowUserToAddRows = false;
            this.newOrderFoodList.AllowUserToDeleteRows = false;
            this.newOrderFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newOrderFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Price});
            this.newOrderFoodList.Location = new System.Drawing.Point(126, 69);
            this.newOrderFoodList.MultiSelect = false;
            this.newOrderFoodList.Name = "newOrderFoodList";
            this.newOrderFoodList.ReadOnly = true;
            this.newOrderFoodList.RowHeadersVisible = false;
            this.newOrderFoodList.Size = new System.Drawing.Size(192, 112);
            this.newOrderFoodList.TabIndex = 16;
            this.newOrderFoodList.TabStop = false;
            // 
            // Item
            // 
            this.Item.Frozen = true;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(258, 25);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(60, 23);
            this.addFoodButton.TabIndex = 1;
            this.addFoodButton.Text = "Add";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // menuList
            // 
            this.menuList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuList.FormattingEnabled = true;
            this.menuList.Location = new System.Drawing.Point(126, 26);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(125, 21);
            this.menuList.TabIndex = 0;
            // 
            // orderSelectLabel
            // 
            this.orderSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderSelectLabel.Location = new System.Drawing.Point(6, 26);
            this.orderSelectLabel.Name = "orderSelectLabel";
            this.orderSelectLabel.Size = new System.Drawing.Size(105, 20);
            this.orderSelectLabel.TabIndex = 13;
            this.orderSelectLabel.Text = "Select Food:";
            this.orderSelectLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // onOrderLabel
            // 
            this.onOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.onOrderLabel.Location = new System.Drawing.Point(21, 69);
            this.onOrderLabel.Name = "onOrderLabel";
            this.onOrderLabel.Size = new System.Drawing.Size(90, 20);
            this.onOrderLabel.TabIndex = 12;
            this.onOrderLabel.Text = "On Order:";
            this.onOrderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // orderSubmitButton
            // 
            this.orderSubmitButton.Location = new System.Drawing.Point(192, 369);
            this.orderSubmitButton.Name = "orderSubmitButton";
            this.orderSubmitButton.Size = new System.Drawing.Size(126, 23);
            this.orderSubmitButton.TabIndex = 6;
            this.orderSubmitButton.Text = "Submit Order";
            this.orderSubmitButton.UseVisualStyleBackColor = true;
            this.orderSubmitButton.Click += new System.EventHandler(this.orderSubmitButton_Click);
            // 
            // newOrderDate
            // 
            this.newOrderDate.CustomFormat = "ddd, MMM d, yyyy  - h:mm tt";
            this.newOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newOrderDate.Location = new System.Drawing.Point(126, 330);
            this.newOrderDate.Name = "newOrderDate";
            this.newOrderDate.Size = new System.Drawing.Size(192, 20);
            this.newOrderDate.TabIndex = 5;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderDateLabel.Location = new System.Drawing.Point(21, 330);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(90, 20);
            this.orderDateLabel.TabIndex = 8;
            this.orderDateLabel.Text = "Date/Time:";
            this.orderDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newOrderPhone
            // 
            this.newOrderPhone.Location = new System.Drawing.Point(126, 300);
            this.newOrderPhone.Name = "newOrderPhone";
            this.newOrderPhone.Size = new System.Drawing.Size(192, 20);
            this.newOrderPhone.TabIndex = 4;
            // 
            // newOrderLast
            // 
            this.newOrderLast.Location = new System.Drawing.Point(126, 270);
            this.newOrderLast.Name = "newOrderLast";
            this.newOrderLast.Size = new System.Drawing.Size(192, 20);
            this.newOrderLast.TabIndex = 3;
            // 
            // newOrderFirst
            // 
            this.newOrderFirst.Location = new System.Drawing.Point(126, 240);
            this.newOrderFirst.Name = "newOrderFirst";
            this.newOrderFirst.Size = new System.Drawing.Size(192, 20);
            this.newOrderFirst.TabIndex = 2;
            // 
            // orderPhoneLabel
            // 
            this.orderPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderPhoneLabel.Location = new System.Drawing.Point(21, 300);
            this.orderPhoneLabel.Name = "orderPhoneLabel";
            this.orderPhoneLabel.Size = new System.Drawing.Size(90, 20);
            this.orderPhoneLabel.TabIndex = 3;
            this.orderPhoneLabel.Text = "Phone:";
            this.orderPhoneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // orderLNameLabel
            // 
            this.orderLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderLNameLabel.Location = new System.Drawing.Point(21, 270);
            this.orderLNameLabel.Name = "orderLNameLabel";
            this.orderLNameLabel.Size = new System.Drawing.Size(90, 20);
            this.orderLNameLabel.TabIndex = 1;
            this.orderLNameLabel.Text = "Last Name:";
            this.orderLNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // orderFNameLabel
            // 
            this.orderFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderFNameLabel.Location = new System.Drawing.Point(21, 240);
            this.orderFNameLabel.Name = "orderFNameLabel";
            this.orderFNameLabel.Size = new System.Drawing.Size(90, 20);
            this.orderFNameLabel.TabIndex = 0;
            this.orderFNameLabel.Text = "First Name:";
            this.orderFNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "v1.2.0";
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuButton.Location = new System.Drawing.Point(23, 475);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(154, 30);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Back to Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Enabled = false;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsButton.Location = new System.Drawing.Point(467, 372);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 60);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Application Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "<-- not yet working";
            // 
            // managerToggle
            // 
            this.managerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.managerToggle.Location = new System.Drawing.Point(183, 475);
            this.managerToggle.Name = "managerToggle";
            this.managerToggle.Size = new System.Drawing.Size(173, 30);
            this.managerToggle.TabIndex = 4;
            this.managerToggle.UseVisualStyleBackColor = true;
            this.managerToggle.Visible = false;
            this.managerToggle.Click += new System.EventHandler(this.managerToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 512);
            this.Controls.Add(this.managerToggle);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TheCodeAwakens Restaurant App";
            this.tabControl1.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.reservationTab.ResumeLayout(false);
            this.resGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).EndInit();
            this.addResGroupBox.ResumeLayout(false);
            this.addResGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newResTableNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newResParty)).EndInit();
            this.orderTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.newOrderGroupBox.ResumeLayout(false);
            this.newOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.TabPage reservationTab;
        private System.Windows.Forms.Button resManagerButton;
        private System.Windows.Forms.Button ordManagerButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subHeading;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.GroupBox addResGroupBox;
        private System.Windows.Forms.Label resLNameLabel;
        private System.Windows.Forms.Label resFNameLabel;
        private System.Windows.Forms.DateTimePicker newResDate;
        private System.Windows.Forms.Label resDateLabel;
        private System.Windows.Forms.TextBox newResPhone;
        private System.Windows.Forms.TextBox newResLast;
        private System.Windows.Forms.TextBox newResFirst;
        private System.Windows.Forms.Label resPhoneLabel;
        private System.Windows.Forms.Label resPartyLabel;
        private System.Windows.Forms.Button resSubmit;
        private System.Windows.Forms.GroupBox newOrderGroupBox;
        private System.Windows.Forms.Button orderSubmitButton;
        private System.Windows.Forms.DateTimePicker newOrderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.TextBox newOrderPhone;
        private System.Windows.Forms.TextBox newOrderLast;
        private System.Windows.Forms.TextBox newOrderFirst;
        private System.Windows.Forms.Label orderPhoneLabel;
        private System.Windows.Forms.Label orderLNameLabel;
        private System.Windows.Forms.Label orderFNameLabel;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.ComboBox menuList;
        private System.Windows.Forms.Label orderSelectLabel;
        private System.Windows.Forms.Label onOrderLabel;
        private System.Windows.Forms.DataGridView newOrderFoodList;
        private System.Windows.Forms.Button deleteFoodButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.GroupBox resGroupBox;
        private System.Windows.Forms.DataGridView reservationTable;
        private System.Windows.Forms.Label resTableNumLabel;
        private System.Windows.Forms.Button orderClearButton;
        private System.Windows.Forms.NumericUpDown newResParty;
        private System.Windows.Forms.NumericUpDown newResTableNum;
        private System.Windows.Forms.Button resClearButton;
        private System.Windows.Forms.Button removeResButton;
        private System.Windows.Forms.Button removeOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button managerToggle;
    }
}

