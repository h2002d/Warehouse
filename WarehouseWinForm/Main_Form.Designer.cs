namespace WarehouseWinForm
{
    partial class Main_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProdIn = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox_UnitID = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox_ProdInCountry = new System.Windows.Forms.ComboBox();
            this.comboBox_ProdInPlace = new System.Windows.Forms.ComboBox();
            this.textBox_InCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_OutAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_AmountProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxProdInName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxProdInCategory = new System.Windows.Forms.ComboBox();
            this.textBoxProductInId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProductIn = new System.Windows.Forms.DataGridView();
            this.tabPageProdOut = new System.Windows.Forms.TabPage();
            this.dataGridViewProductOut = new System.Windows.Forms.DataGridView();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.button_CancelCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_SubmitCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Rates = new System.Windows.Forms.TabPage();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBoxRateOut = new System.Windows.Forms.TextBox();
            this.textBoxRateIn = new System.Windows.Forms.TextBox();
            this.textBoxRateName = new System.Windows.Forms.TextBox();
            this.button_SubmitRate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRates = new System.Windows.Forms.DataGridView();
            this.Column_RateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDept = new System.Windows.Forms.TabPage();
            this.button_CancelDept = new System.Windows.Forms.Button();
            this.comboBox_Users_Dept = new System.Windows.Forms.ComboBox();
            this.checkBox_Dept_Isfinished = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Dept_ProducId = new System.Windows.Forms.TextBox();
            this.button_Submit_Dept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPayedAmount = new System.Windows.Forms.TextBox();
            this.dataGridViewDept = new System.Windows.Forms.DataGridView();
            this.Column_Dept_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dept_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dept_PayedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Isfinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dept_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dept_UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.button_CancelUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUsersSubmit = new System.Windows.Forms.Button();
            this.textBoxUserPercent = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Column_User_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnՒ_User_Persent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCountry = new System.Windows.Forms.TabPage();
            this.button_CountryCancel = new System.Windows.Forms.Button();
            this.button_Submit_Country = new System.Windows.Forms.Button();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSell = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox_SellUser = new System.Windows.Forms.ComboBox();
            this.textBoxPriceForSell = new System.Windows.Forms.TextBox();
            this.textBox_CountForSell = new System.Windows.Forms.TextBox();
            this.label_SellProdName = new System.Windows.Forms.Label();
            this.buttonSubmitSell = new System.Windows.Forms.Button();
            this.button_GetProductSell = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_SellProductID = new System.Windows.Forms.TextBox();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.radioButton_MoneyCount = new System.Windows.Forms.RadioButton();
            this.radioButton_SellCount = new System.Windows.Forms.RadioButton();
            this.radioButton_CurrCount = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_StaticticsClient = new System.Windows.Forms.CheckBox();
            this.comboBox_StatisticUser = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_StatisticsProdId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageProdIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIn)).BeginInit();
            this.tabPageProdOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductOut)).BeginInit();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).BeginInit();
            this.tabPage_Rates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).BeginInit();
            this.tabPageDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).BeginInit();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            this.tabPageSell.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageProdIn);
            this.tabControl1.Controls.Add(this.tabPageProdOut);
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Controls.Add(this.tabPage_Rates);
            this.tabControl1.Controls.Add(this.tabPageDept);
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageCountry);
            this.tabControl1.Controls.Add(this.tabPageSell);
            this.tabControl1.Controls.Add(this.tabPageStatistics);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 585);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageProdIn
            // 
            this.tabPageProdIn.Controls.Add(this.button1);
            this.tabPageProdIn.Controls.Add(this.label28);
            this.tabPageProdIn.Controls.Add(this.comboBox_UnitID);
            this.tabPageProdIn.Controls.Add(this.label24);
            this.tabPageProdIn.Controls.Add(this.label23);
            this.tabPageProdIn.Controls.Add(this.comboBox_ProdInCountry);
            this.tabPageProdIn.Controls.Add(this.comboBox_ProdInPlace);
            this.tabPageProdIn.Controls.Add(this.textBox_InCount);
            this.tabPageProdIn.Controls.Add(this.label17);
            this.tabPageProdIn.Controls.Add(this.textBox_OutAmount);
            this.tabPageProdIn.Controls.Add(this.label16);
            this.tabPageProdIn.Controls.Add(this.textBox_AmountProd);
            this.tabPageProdIn.Controls.Add(this.label15);
            this.tabPageProdIn.Controls.Add(this.textBoxProdInName);
            this.tabPageProdIn.Controls.Add(this.label14);
            this.tabPageProdIn.Controls.Add(this.label13);
            this.tabPageProdIn.Controls.Add(this.comboBoxProdInCategory);
            this.tabPageProdIn.Controls.Add(this.textBoxProductInId);
            this.tabPageProdIn.Controls.Add(this.label11);
            this.tabPageProdIn.Controls.Add(this.button2);
            this.tabPageProdIn.Controls.Add(this.dataGridViewProductIn);
            this.tabPageProdIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageProdIn.Name = "tabPageProdIn";
            this.tabPageProdIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProdIn.Size = new System.Drawing.Size(838, 559);
            this.tabPageProdIn.TabIndex = 0;
            this.tabPageProdIn.Text = "Продукты";
            this.tabPageProdIn.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(605, 335);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "Валюта";
            // 
            // comboBox_UnitID
            // 
            this.comboBox_UnitID.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_UnitID.FormattingEnabled = true;
            this.comboBox_UnitID.Location = new System.Drawing.Point(605, 351);
            this.comboBox_UnitID.Name = "comboBox_UnitID";
            this.comboBox_UnitID.Size = new System.Drawing.Size(198, 26);
            this.comboBox_UnitID.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(605, 444);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Страна";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(605, 399);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Место";
            // 
            // comboBox_ProdInCountry
            // 
            this.comboBox_ProdInCountry.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_ProdInCountry.FormattingEnabled = true;
            this.comboBox_ProdInCountry.Location = new System.Drawing.Point(608, 460);
            this.comboBox_ProdInCountry.Name = "comboBox_ProdInCountry";
            this.comboBox_ProdInCountry.Size = new System.Drawing.Size(198, 26);
            this.comboBox_ProdInCountry.TabIndex = 23;
            // 
            // comboBox_ProdInPlace
            // 
            this.comboBox_ProdInPlace.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_ProdInPlace.FormattingEnabled = true;
            this.comboBox_ProdInPlace.Location = new System.Drawing.Point(605, 415);
            this.comboBox_ProdInPlace.Name = "comboBox_ProdInPlace";
            this.comboBox_ProdInPlace.Size = new System.Drawing.Size(198, 26);
            this.comboBox_ProdInPlace.TabIndex = 22;
            // 
            // textBox_InCount
            // 
            this.textBox_InCount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_InCount.Location = new System.Drawing.Point(605, 297);
            this.textBox_InCount.Name = "textBox_InCount";
            this.textBox_InCount.Size = new System.Drawing.Size(198, 26);
            this.textBox_InCount.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(602, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Каличество";
            // 
            // textBox_OutAmount
            // 
            this.textBox_OutAmount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_OutAmount.Location = new System.Drawing.Point(605, 247);
            this.textBox_OutAmount.Name = "textBox_OutAmount";
            this.textBox_OutAmount.Size = new System.Drawing.Size(198, 26);
            this.textBox_OutAmount.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(602, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Цена Продажи";
            // 
            // textBox_AmountProd
            // 
            this.textBox_AmountProd.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_AmountProd.Location = new System.Drawing.Point(605, 196);
            this.textBox_AmountProd.Name = "textBox_AmountProd";
            this.textBox_AmountProd.Size = new System.Drawing.Size(198, 26);
            this.textBox_AmountProd.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(602, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Цена";
            // 
            // textBoxProdInName
            // 
            this.textBoxProdInName.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxProdInName.Location = new System.Drawing.Point(605, 144);
            this.textBoxProdInName.Name = "textBoxProdInName";
            this.textBoxProdInName.Size = new System.Drawing.Size(198, 26);
            this.textBoxProdInName.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(602, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Категория";
            // 
            // comboBoxProdInCategory
            // 
            this.comboBoxProdInCategory.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBoxProdInCategory.FormattingEnabled = true;
            this.comboBoxProdInCategory.Location = new System.Drawing.Point(605, 96);
            this.comboBoxProdInCategory.Name = "comboBoxProdInCategory";
            this.comboBoxProdInCategory.Size = new System.Drawing.Size(198, 26);
            this.comboBoxProdInCategory.TabIndex = 12;
            // 
            // textBoxProductInId
            // 
            this.textBoxProductInId.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxProductInId.Location = new System.Drawing.Point(605, 36);
            this.textBoxProductInId.Name = "textBoxProductInId";
            this.textBoxProductInId.Size = new System.Drawing.Size(198, 26);
            this.textBoxProductInId.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(602, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Номер Продукта";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewProductIn
            // 
            this.dataGridViewProductIn.AllowUserToAddRows = false;
            this.dataGridViewProductIn.AllowUserToDeleteRows = false;
            this.dataGridViewProductIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIn.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewProductIn.Name = "dataGridViewProductIn";
            this.dataGridViewProductIn.ReadOnly = true;
            this.dataGridViewProductIn.Size = new System.Drawing.Size(593, 545);
            this.dataGridViewProductIn.TabIndex = 0;
            this.dataGridViewProductIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductIn_CellDoubleClick);
            // 
            // tabPageProdOut
            // 
            this.tabPageProdOut.Controls.Add(this.dataGridViewProductOut);
            this.tabPageProdOut.Location = new System.Drawing.Point(4, 22);
            this.tabPageProdOut.Name = "tabPageProdOut";
            this.tabPageProdOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProdOut.Size = new System.Drawing.Size(838, 559);
            this.tabPageProdOut.TabIndex = 1;
            this.tabPageProdOut.Text = "Продажы";
            this.tabPageProdOut.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductOut
            // 
            this.dataGridViewProductOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductOut.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewProductOut.Name = "dataGridViewProductOut";
            this.dataGridViewProductOut.Size = new System.Drawing.Size(813, 545);
            this.dataGridViewProductOut.TabIndex = 1;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.button_CancelCategory);
            this.tabPageCategories.Controls.Add(this.label8);
            this.tabPageCategories.Controls.Add(this.comboBox);
            this.tabPageCategories.Controls.Add(this.button_SubmitCategory);
            this.tabPageCategories.Controls.Add(this.textBoxCategoryName);
            this.tabPageCategories.Controls.Add(this.label1);
            this.tabPageCategories.Controls.Add(this.dataGridView_Categories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Size = new System.Drawing.Size(838, 559);
            this.tabPageCategories.TabIndex = 2;
            this.tabPageCategories.Text = "Категории";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // button_CancelCategory
            // 
            this.button_CancelCategory.Location = new System.Drawing.Point(479, 139);
            this.button_CancelCategory.Name = "button_CancelCategory";
            this.button_CancelCategory.Size = new System.Drawing.Size(100, 35);
            this.button_CancelCategory.TabIndex = 20;
            this.button_CancelCategory.Text = "Отмена";
            this.button_CancelCategory.UseVisualStyleBackColor = true;
            this.button_CancelCategory.Click += new System.EventHandler(this.button_CancelCategory_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Parent";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(487, 86);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(198, 26);
            this.comboBox.TabIndex = 4;
            // 
            // button_SubmitCategory
            // 
            this.button_SubmitCategory.Location = new System.Drawing.Point(585, 139);
            this.button_SubmitCategory.Name = "button_SubmitCategory";
            this.button_SubmitCategory.Size = new System.Drawing.Size(100, 35);
            this.button_SubmitCategory.TabIndex = 3;
            this.button_SubmitCategory.Text = "Сохранить";
            this.button_SubmitCategory.UseVisualStyleBackColor = true;
            this.button_SubmitCategory.Click += new System.EventHandler(this.button_SubmitCategory_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxCategoryName.Location = new System.Drawing.Point(487, 23);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(198, 26);
            this.textBoxCategoryName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // dataGridView_Categories
            // 
            this.dataGridView_Categories.AllowUserToAddRows = false;
            this.dataGridView_Categories.AllowUserToDeleteRows = false;
            this.dataGridView_Categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Categories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_ParentId,
            this.Column_EditDate,
            this.Column_CreateDate});
            this.dataGridView_Categories.Location = new System.Drawing.Point(7, 4);
            this.dataGridView_Categories.Name = "dataGridView_Categories";
            this.dataGridView_Categories.ReadOnly = true;
            this.dataGridView_Categories.Size = new System.Drawing.Size(447, 547);
            this.dataGridView_Categories.TabIndex = 0;
            this.dataGridView_Categories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Categories_CellDoubleClick);
            this.dataGridView_Categories.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Categories_CellMouseDown);
            // 
            // Column_Id
            // 
            this.Column_Id.DataPropertyName = "CategoryID";
            this.Column_Id.HeaderText = "Column1";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.ReadOnly = true;
            this.Column_Id.Visible = false;
            // 
            // Column_Name
            // 
            this.Column_Name.DataPropertyName = "Name";
            this.Column_Name.HeaderText = "Название";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_ParentId
            // 
            this.Column_ParentId.DataPropertyName = "ParentID";
            this.Column_ParentId.HeaderText = "Column";
            this.Column_ParentId.Name = "Column_ParentId";
            this.Column_ParentId.ReadOnly = true;
            this.Column_ParentId.Visible = false;
            // 
            // Column_EditDate
            // 
            this.Column_EditDate.DataPropertyName = "UpdateDate";
            this.Column_EditDate.HeaderText = "Дата Изменения";
            this.Column_EditDate.Name = "Column_EditDate";
            this.Column_EditDate.ReadOnly = true;
            // 
            // Column_CreateDate
            // 
            this.Column_CreateDate.DataPropertyName = "CreateDate";
            this.Column_CreateDate.HeaderText = "Дата Создания";
            this.Column_CreateDate.Name = "Column_CreateDate";
            this.Column_CreateDate.ReadOnly = true;
            // 
            // tabPage_Rates
            // 
            this.tabPage_Rates.Controls.Add(this.button_Cancel);
            this.tabPage_Rates.Controls.Add(this.textBoxRateOut);
            this.tabPage_Rates.Controls.Add(this.textBoxRateIn);
            this.tabPage_Rates.Controls.Add(this.textBoxRateName);
            this.tabPage_Rates.Controls.Add(this.button_SubmitRate);
            this.tabPage_Rates.Controls.Add(this.label4);
            this.tabPage_Rates.Controls.Add(this.label3);
            this.tabPage_Rates.Controls.Add(this.label2);
            this.tabPage_Rates.Controls.Add(this.dataGridViewRates);
            this.tabPage_Rates.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rates.Name = "tabPage_Rates";
            this.tabPage_Rates.Size = new System.Drawing.Size(838, 559);
            this.tabPage_Rates.TabIndex = 3;
            this.tabPage_Rates.Text = "Валюта";
            this.tabPage_Rates.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(441, 198);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 35);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBoxRateOut
            // 
            this.textBoxRateOut.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxRateOut.Location = new System.Drawing.Point(449, 141);
            this.textBoxRateOut.Name = "textBoxRateOut";
            this.textBoxRateOut.Size = new System.Drawing.Size(198, 26);
            this.textBoxRateOut.TabIndex = 10;
            // 
            // textBoxRateIn
            // 
            this.textBoxRateIn.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxRateIn.Location = new System.Drawing.Point(449, 83);
            this.textBoxRateIn.Name = "textBoxRateIn";
            this.textBoxRateIn.Size = new System.Drawing.Size(198, 26);
            this.textBoxRateIn.TabIndex = 9;
            // 
            // textBoxRateName
            // 
            this.textBoxRateName.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxRateName.Location = new System.Drawing.Point(449, 27);
            this.textBoxRateName.Name = "textBoxRateName";
            this.textBoxRateName.Size = new System.Drawing.Size(198, 26);
            this.textBoxRateName.TabIndex = 8;
            // 
            // button_SubmitRate
            // 
            this.button_SubmitRate.Location = new System.Drawing.Point(547, 198);
            this.button_SubmitRate.Name = "button_SubmitRate";
            this.button_SubmitRate.Size = new System.Drawing.Size(100, 35);
            this.button_SubmitRate.TabIndex = 7;
            this.button_SubmitRate.Text = "Сохранить";
            this.button_SubmitRate.UseVisualStyleBackColor = true;
            this.button_SubmitRate.Click += new System.EventHandler(this.button_SubmitRate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // dataGridViewRates
            // 
            this.dataGridViewRates.AllowUserToAddRows = false;
            this.dataGridViewRates.AllowUserToDeleteRows = false;
            this.dataGridViewRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_RateId,
            this.Column_RateName,
            this.Column_RateIn,
            this.Column_RateOut});
            this.dataGridViewRates.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewRates.Name = "dataGridViewRates";
            this.dataGridViewRates.ReadOnly = true;
            this.dataGridViewRates.Size = new System.Drawing.Size(418, 548);
            this.dataGridViewRates.TabIndex = 0;
            this.dataGridViewRates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRates_CellDoubleClick);
            this.dataGridViewRates.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRates_CellMouseDown);
            // 
            // Column_RateId
            // 
            this.Column_RateId.DataPropertyName = "RateID";
            this.Column_RateId.HeaderText = "Column1";
            this.Column_RateId.Name = "Column_RateId";
            this.Column_RateId.ReadOnly = true;
            this.Column_RateId.Visible = false;
            // 
            // Column_RateName
            // 
            this.Column_RateName.DataPropertyName = "Name";
            this.Column_RateName.HeaderText = "Название";
            this.Column_RateName.Name = "Column_RateName";
            this.Column_RateName.ReadOnly = true;
            // 
            // Column_RateIn
            // 
            this.Column_RateIn.DataPropertyName = "RateIn";
            this.Column_RateIn.HeaderText = "Вход";
            this.Column_RateIn.Name = "Column_RateIn";
            this.Column_RateIn.ReadOnly = true;
            // 
            // Column_RateOut
            // 
            this.Column_RateOut.DataPropertyName = "RateOut";
            this.Column_RateOut.HeaderText = "Выход";
            this.Column_RateOut.Name = "Column_RateOut";
            this.Column_RateOut.ReadOnly = true;
            // 
            // tabPageDept
            // 
            this.tabPageDept.Controls.Add(this.button_CancelDept);
            this.tabPageDept.Controls.Add(this.comboBox_Users_Dept);
            this.tabPageDept.Controls.Add(this.checkBox_Dept_Isfinished);
            this.tabPageDept.Controls.Add(this.label10);
            this.tabPageDept.Controls.Add(this.label9);
            this.tabPageDept.Controls.Add(this.textBox_Dept_ProducId);
            this.tabPageDept.Controls.Add(this.button_Submit_Dept);
            this.tabPageDept.Controls.Add(this.label5);
            this.tabPageDept.Controls.Add(this.textBoxPayedAmount);
            this.tabPageDept.Controls.Add(this.dataGridViewDept);
            this.tabPageDept.Location = new System.Drawing.Point(4, 22);
            this.tabPageDept.Name = "tabPageDept";
            this.tabPageDept.Size = new System.Drawing.Size(838, 559);
            this.tabPageDept.TabIndex = 4;
            this.tabPageDept.Text = "Долг";
            this.tabPageDept.UseVisualStyleBackColor = true;
            // 
            // button_CancelDept
            // 
            this.button_CancelDept.Location = new System.Drawing.Point(585, 204);
            this.button_CancelDept.Name = "button_CancelDept";
            this.button_CancelDept.Size = new System.Drawing.Size(100, 35);
            this.button_CancelDept.TabIndex = 18;
            this.button_CancelDept.Text = "Отмена";
            this.button_CancelDept.UseVisualStyleBackColor = true;
            this.button_CancelDept.Click += new System.EventHandler(this.button_CancelDept_Click);
            // 
            // comboBox_Users_Dept
            // 
            this.comboBox_Users_Dept.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_Users_Dept.FormattingEnabled = true;
            this.comboBox_Users_Dept.Location = new System.Drawing.Point(603, 153);
            this.comboBox_Users_Dept.Name = "comboBox_Users_Dept";
            this.comboBox_Users_Dept.Size = new System.Drawing.Size(198, 26);
            this.comboBox_Users_Dept.TabIndex = 17;
            // 
            // checkBox_Dept_Isfinished
            // 
            this.checkBox_Dept_Isfinished.AutoSize = true;
            this.checkBox_Dept_Isfinished.Location = new System.Drawing.Point(603, 104);
            this.checkBox_Dept_Isfinished.Name = "checkBox_Dept_Isfinished";
            this.checkBox_Dept_Isfinished.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Dept_Isfinished.TabIndex = 16;
            this.checkBox_Dept_Isfinished.Text = "Закрыто";
            this.checkBox_Dept_Isfinished.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Клиент";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Номер Продукта";
            // 
            // textBox_Dept_ProducId
            // 
            this.textBox_Dept_ProducId.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_Dept_ProducId.Location = new System.Drawing.Point(603, 72);
            this.textBox_Dept_ProducId.Name = "textBox_Dept_ProducId";
            this.textBox_Dept_ProducId.Size = new System.Drawing.Size(198, 26);
            this.textBox_Dept_ProducId.TabIndex = 12;
            // 
            // button_Submit_Dept
            // 
            this.button_Submit_Dept.Location = new System.Drawing.Point(701, 204);
            this.button_Submit_Dept.Name = "button_Submit_Dept";
            this.button_Submit_Dept.Size = new System.Drawing.Size(100, 35);
            this.button_Submit_Dept.TabIndex = 11;
            this.button_Submit_Dept.Text = "Сохранить";
            this.button_Submit_Dept.UseVisualStyleBackColor = true;
            this.button_Submit_Dept.Click += new System.EventHandler(this.button_SubmitDept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Оплаченная Сумма";
            // 
            // textBoxPayedAmount
            // 
            this.textBoxPayedAmount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxPayedAmount.Location = new System.Drawing.Point(603, 29);
            this.textBoxPayedAmount.Name = "textBoxPayedAmount";
            this.textBoxPayedAmount.Size = new System.Drawing.Size(198, 26);
            this.textBoxPayedAmount.TabIndex = 9;
            // 
            // dataGridViewDept
            // 
            this.dataGridViewDept.AllowUserToAddRows = false;
            this.dataGridViewDept.AllowUserToDeleteRows = false;
            this.dataGridViewDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Dept_ID,
            this.Column_Dept_ProductID,
            this.Column_Dept_PayedAmount,
            this.Column_Isfinished,
            this.Column_Dept_CreateDate,
            this.Column_Dept_UpdateDate,
            this.Column_UserID});
            this.dataGridViewDept.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDept.Name = "dataGridViewDept";
            this.dataGridViewDept.ReadOnly = true;
            this.dataGridViewDept.Size = new System.Drawing.Size(557, 553);
            this.dataGridViewDept.TabIndex = 0;
            this.dataGridViewDept.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDept_CellDoubleClick);
            this.dataGridViewDept.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDept_CellMouseDown);
            // 
            // Column_Dept_ID
            // 
            this.Column_Dept_ID.DataPropertyName = "DeptID";
            this.Column_Dept_ID.HeaderText = "Column1";
            this.Column_Dept_ID.Name = "Column_Dept_ID";
            this.Column_Dept_ID.ReadOnly = true;
            this.Column_Dept_ID.Visible = false;
            // 
            // Column_Dept_ProductID
            // 
            this.Column_Dept_ProductID.DataPropertyName = "ProductOutID";
            this.Column_Dept_ProductID.HeaderText = "Номер Продукта";
            this.Column_Dept_ProductID.Name = "Column_Dept_ProductID";
            this.Column_Dept_ProductID.ReadOnly = true;
            // 
            // Column_Dept_PayedAmount
            // 
            this.Column_Dept_PayedAmount.DataPropertyName = "PayedAmount";
            this.Column_Dept_PayedAmount.HeaderText = "Оплаченная Сумма";
            this.Column_Dept_PayedAmount.Name = "Column_Dept_PayedAmount";
            this.Column_Dept_PayedAmount.ReadOnly = true;
            // 
            // Column_Isfinished
            // 
            this.Column_Isfinished.DataPropertyName = "IsFinishDept";
            this.Column_Isfinished.HeaderText = "Закрыто";
            this.Column_Isfinished.Name = "Column_Isfinished";
            this.Column_Isfinished.ReadOnly = true;
            // 
            // Column_Dept_CreateDate
            // 
            this.Column_Dept_CreateDate.DataPropertyName = "CreateDate";
            this.Column_Dept_CreateDate.HeaderText = "Дата Создания";
            this.Column_Dept_CreateDate.Name = "Column_Dept_CreateDate";
            this.Column_Dept_CreateDate.ReadOnly = true;
            // 
            // Column_Dept_UpdateDate
            // 
            this.Column_Dept_UpdateDate.DataPropertyName = "UpdateDate";
            this.Column_Dept_UpdateDate.HeaderText = "Последние изменения";
            this.Column_Dept_UpdateDate.Name = "Column_Dept_UpdateDate";
            this.Column_Dept_UpdateDate.ReadOnly = true;
            // 
            // Column_UserID
            // 
            this.Column_UserID.DataPropertyName = "UserID";
            this.Column_UserID.HeaderText = "Клиент";
            this.Column_UserID.Name = "Column_UserID";
            this.Column_UserID.ReadOnly = true;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.button_CancelUser);
            this.tabPageUser.Controls.Add(this.label7);
            this.tabPageUser.Controls.Add(this.label6);
            this.tabPageUser.Controls.Add(this.buttonUsersSubmit);
            this.tabPageUser.Controls.Add(this.textBoxUserPercent);
            this.tabPageUser.Controls.Add(this.textBoxUserName);
            this.tabPageUser.Controls.Add(this.dataGridViewUsers);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Size = new System.Drawing.Size(838, 559);
            this.tabPageUser.TabIndex = 5;
            this.tabPageUser.Text = "Клиенты";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // button_CancelUser
            // 
            this.button_CancelUser.Location = new System.Drawing.Point(471, 157);
            this.button_CancelUser.Name = "button_CancelUser";
            this.button_CancelUser.Size = new System.Drawing.Size(100, 35);
            this.button_CancelUser.TabIndex = 19;
            this.button_CancelUser.Text = "Отмена";
            this.button_CancelUser.UseVisualStyleBackColor = true;
            this.button_CancelUser.Click += new System.EventHandler(this.button_CancelUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Процент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Имя ";
            // 
            // buttonUsersSubmit
            // 
            this.buttonUsersSubmit.Location = new System.Drawing.Point(577, 157);
            this.buttonUsersSubmit.Name = "buttonUsersSubmit";
            this.buttonUsersSubmit.Size = new System.Drawing.Size(100, 35);
            this.buttonUsersSubmit.TabIndex = 5;
            this.buttonUsersSubmit.Text = "Сохранить";
            this.buttonUsersSubmit.UseVisualStyleBackColor = true;
            this.buttonUsersSubmit.Click += new System.EventHandler(this.button_SubmitUsers_Click);
            // 
            // textBoxUserPercent
            // 
            this.textBoxUserPercent.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxUserPercent.Location = new System.Drawing.Point(479, 108);
            this.textBoxUserPercent.Name = "textBoxUserPercent";
            this.textBoxUserPercent.Size = new System.Drawing.Size(198, 26);
            this.textBoxUserPercent.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxUserName.Location = new System.Drawing.Point(479, 53);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(198, 26);
            this.textBoxUserName.TabIndex = 3;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_User_Id,
            this.ColumnUser_Name,
            this.ColumnՒ_User_Persent});
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(446, 548);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            this.dataGridViewUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUsers_CellMouseDown);
            // 
            // Column_User_Id
            // 
            this.Column_User_Id.DataPropertyName = "UserID";
            this.Column_User_Id.HeaderText = "Column1";
            this.Column_User_Id.Name = "Column_User_Id";
            this.Column_User_Id.ReadOnly = true;
            this.Column_User_Id.Visible = false;
            // 
            // ColumnUser_Name
            // 
            this.ColumnUser_Name.DataPropertyName = "Name";
            this.ColumnUser_Name.FillWeight = 49.62779F;
            this.ColumnUser_Name.HeaderText = "Имя";
            this.ColumnUser_Name.Name = "ColumnUser_Name";
            this.ColumnUser_Name.ReadOnly = true;
            // 
            // ColumnՒ_User_Persent
            // 
            this.ColumnՒ_User_Persent.DataPropertyName = "Persent";
            this.ColumnՒ_User_Persent.FillWeight = 150.3722F;
            this.ColumnՒ_User_Persent.HeaderText = "Процент %";
            this.ColumnՒ_User_Persent.Name = "ColumnՒ_User_Persent";
            this.ColumnՒ_User_Persent.ReadOnly = true;
            this.ColumnՒ_User_Persent.Width = 303;
            // 
            // tabPageCountry
            // 
            this.tabPageCountry.Controls.Add(this.button_CountryCancel);
            this.tabPageCountry.Controls.Add(this.button_Submit_Country);
            this.tabPageCountry.Controls.Add(this.textBoxCountryName);
            this.tabPageCountry.Controls.Add(this.label12);
            this.tabPageCountry.Controls.Add(this.dataGridViewCountry);
            this.tabPageCountry.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountry.Name = "tabPageCountry";
            this.tabPageCountry.Size = new System.Drawing.Size(838, 559);
            this.tabPageCountry.TabIndex = 6;
            this.tabPageCountry.Text = "Страна";
            this.tabPageCountry.UseVisualStyleBackColor = true;
            // 
            // button_CountryCancel
            // 
            this.button_CountryCancel.Location = new System.Drawing.Point(546, 113);
            this.button_CountryCancel.Name = "button_CountryCancel";
            this.button_CountryCancel.Size = new System.Drawing.Size(100, 35);
            this.button_CountryCancel.TabIndex = 19;
            this.button_CountryCancel.Text = "Отмена";
            this.button_CountryCancel.UseVisualStyleBackColor = true;
            this.button_CountryCancel.Click += new System.EventHandler(this.button_CountryCancel_Click);
            // 
            // button_Submit_Country
            // 
            this.button_Submit_Country.Location = new System.Drawing.Point(652, 113);
            this.button_Submit_Country.Name = "button_Submit_Country";
            this.button_Submit_Country.Size = new System.Drawing.Size(100, 35);
            this.button_Submit_Country.TabIndex = 13;
            this.button_Submit_Country.Text = "Сохранить";
            this.button_Submit_Country.UseVisualStyleBackColor = true;
            this.button_Submit_Country.Click += new System.EventHandler(this.button_SubmitCountry_Click);
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxCountryName.Location = new System.Drawing.Point(554, 35);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(198, 26);
            this.textBoxCountryName.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Название";
            // 
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.AllowUserToAddRows = false;
            this.dataGridViewCountry.AllowUserToDeleteRows = false;
            this.dataGridViewCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewCountry.Location = new System.Drawing.Point(0, 8);
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.ReadOnly = true;
            this.dataGridViewCountry.Size = new System.Drawing.Size(521, 548);
            this.dataGridViewCountry.TabIndex = 0;
            this.dataGridViewCountry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountry_CellDoubleClick);
            this.dataGridViewCountry.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCountry_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CountryId";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tabPageSell
            // 
            this.tabPageSell.Controls.Add(this.label29);
            this.tabPageSell.Controls.Add(this.button7);
            this.tabPageSell.Controls.Add(this.label22);
            this.tabPageSell.Controls.Add(this.comboBox_SellUser);
            this.tabPageSell.Controls.Add(this.textBoxPriceForSell);
            this.tabPageSell.Controls.Add(this.textBox_CountForSell);
            this.tabPageSell.Controls.Add(this.label_SellProdName);
            this.tabPageSell.Controls.Add(this.buttonSubmitSell);
            this.tabPageSell.Controls.Add(this.button_GetProductSell);
            this.tabPageSell.Controls.Add(this.label21);
            this.tabPageSell.Controls.Add(this.label20);
            this.tabPageSell.Controls.Add(this.label19);
            this.tabPageSell.Controls.Add(this.label18);
            this.tabPageSell.Controls.Add(this.textBox_SellProductID);
            this.tabPageSell.Location = new System.Drawing.Point(4, 22);
            this.tabPageSell.Name = "tabPageSell";
            this.tabPageSell.Size = new System.Drawing.Size(838, 559);
            this.tabPageSell.TabIndex = 7;
            this.tabPageSell.Text = "Продажа";
            this.tabPageSell.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.label29.Location = new System.Drawing.Point(282, 270);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 18);
            this.label29.TabIndex = 26;
            this.label29.Text = "AMD";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(316, 355);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.TabIndex = 25;
            this.button7.Text = "Отмена";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Клиент";
            // 
            // comboBox_SellUser
            // 
            this.comboBox_SellUser.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_SellUser.FormattingEnabled = true;
            this.comboBox_SellUser.Location = new System.Drawing.Point(78, 306);
            this.comboBox_SellUser.Name = "comboBox_SellUser";
            this.comboBox_SellUser.Size = new System.Drawing.Size(198, 26);
            this.comboBox_SellUser.TabIndex = 23;
            // 
            // textBoxPriceForSell
            // 
            this.textBoxPriceForSell.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBoxPriceForSell.Location = new System.Drawing.Point(78, 267);
            this.textBoxPriceForSell.Name = "textBoxPriceForSell";
            this.textBoxPriceForSell.Size = new System.Drawing.Size(198, 26);
            this.textBoxPriceForSell.TabIndex = 22;
            // 
            // textBox_CountForSell
            // 
            this.textBox_CountForSell.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_CountForSell.Location = new System.Drawing.Point(78, 225);
            this.textBox_CountForSell.Name = "textBox_CountForSell";
            this.textBox_CountForSell.Size = new System.Drawing.Size(198, 26);
            this.textBox_CountForSell.TabIndex = 21;
            // 
            // label_SellProdName
            // 
            this.label_SellProdName.AutoSize = true;
            this.label_SellProdName.Location = new System.Drawing.Point(101, 199);
            this.label_SellProdName.Name = "label_SellProdName";
            this.label_SellProdName.Size = new System.Drawing.Size(0, 13);
            this.label_SellProdName.TabIndex = 20;
            // 
            // buttonSubmitSell
            // 
            this.buttonSubmitSell.Location = new System.Drawing.Point(422, 355);
            this.buttonSubmitSell.Name = "buttonSubmitSell";
            this.buttonSubmitSell.Size = new System.Drawing.Size(100, 35);
            this.buttonSubmitSell.TabIndex = 19;
            this.buttonSubmitSell.Text = "Продать";
            this.buttonSubmitSell.UseVisualStyleBackColor = true;
            this.buttonSubmitSell.Click += new System.EventHandler(this.buttonSubmitSell_Click);
            // 
            // button_GetProductSell
            // 
            this.button_GetProductSell.Location = new System.Drawing.Point(104, 114);
            this.button_GetProductSell.Name = "button_GetProductSell";
            this.button_GetProductSell.Size = new System.Drawing.Size(100, 35);
            this.button_GetProductSell.TabIndex = 18;
            this.button_GetProductSell.Text = "Продукт";
            this.button_GetProductSell.UseVisualStyleBackColor = true;
            this.button_GetProductSell.Click += new System.EventHandler(this.button_GetProductSell_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Цена";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Каличество";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Имя Продукта";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Код Продукта";
            // 
            // textBox_SellProductID
            // 
            this.textBox_SellProductID.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_SellProductID.Location = new System.Drawing.Point(6, 65);
            this.textBox_SellProductID.Name = "textBox_SellProductID";
            this.textBox_SellProductID.Size = new System.Drawing.Size(198, 26);
            this.textBox_SellProductID.TabIndex = 13;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Controls.Add(this.radioButton_MoneyCount);
            this.tabPageStatistics.Controls.Add(this.radioButton_SellCount);
            this.tabPageStatistics.Controls.Add(this.radioButton_CurrCount);
            this.tabPageStatistics.Controls.Add(this.chart1);
            this.tabPageStatistics.Controls.Add(this.button3);
            this.tabPageStatistics.Controls.Add(this.checkBox_StaticticsClient);
            this.tabPageStatistics.Controls.Add(this.comboBox_StatisticUser);
            this.tabPageStatistics.Controls.Add(this.label27);
            this.tabPageStatistics.Controls.Add(this.label26);
            this.tabPageStatistics.Controls.Add(this.dateTimePicker2);
            this.tabPageStatistics.Controls.Add(this.dateTimePicker1);
            this.tabPageStatistics.Controls.Add(this.label25);
            this.tabPageStatistics.Controls.Add(this.textBox_StatisticsProdId);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Size = new System.Drawing.Size(838, 559);
            this.tabPageStatistics.TabIndex = 8;
            this.tabPageStatistics.Text = "Статистика";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // radioButton_MoneyCount
            // 
            this.radioButton_MoneyCount.AutoSize = true;
            this.radioButton_MoneyCount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.radioButton_MoneyCount.Location = new System.Drawing.Point(283, 105);
            this.radioButton_MoneyCount.Name = "radioButton_MoneyCount";
            this.radioButton_MoneyCount.Size = new System.Drawing.Size(64, 22);
            this.radioButton_MoneyCount.TabIndex = 33;
            this.radioButton_MoneyCount.Text = "Доход";
            this.radioButton_MoneyCount.UseVisualStyleBackColor = true;
            // 
            // radioButton_SellCount
            // 
            this.radioButton_SellCount.AutoSize = true;
            this.radioButton_SellCount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.radioButton_SellCount.Location = new System.Drawing.Point(197, 105);
            this.radioButton_SellCount.Name = "radioButton_SellCount";
            this.radioButton_SellCount.Size = new System.Drawing.Size(80, 22);
            this.radioButton_SellCount.TabIndex = 32;
            this.radioButton_SellCount.Text = "Продажа";
            this.radioButton_SellCount.UseVisualStyleBackColor = true;
            // 
            // radioButton_CurrCount
            // 
            this.radioButton_CurrCount.AutoSize = true;
            this.radioButton_CurrCount.Checked = true;
            this.radioButton_CurrCount.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.radioButton_CurrCount.Location = new System.Drawing.Point(116, 105);
            this.radioButton_CurrCount.Name = "radioButton_CurrCount";
            this.radioButton_CurrCount.Size = new System.Drawing.Size(75, 22);
            this.radioButton_CurrCount.TabIndex = 31;
            this.radioButton_CurrCount.TabStop = true;
            this.radioButton_CurrCount.Text = "Остаток";
            this.radioButton_CurrCount.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(9, 133);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(699, 418);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(711, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 28;
            this.button3.Text = "Статистика";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_StaticticsClient
            // 
            this.checkBox_StaticticsClient.AutoSize = true;
            this.checkBox_StaticticsClient.Location = new System.Drawing.Point(496, 18);
            this.checkBox_StaticticsClient.Name = "checkBox_StaticticsClient";
            this.checkBox_StaticticsClient.Size = new System.Drawing.Size(62, 17);
            this.checkBox_StaticticsClient.TabIndex = 27;
            this.checkBox_StaticticsClient.Text = "Клиент";
            this.checkBox_StaticticsClient.UseVisualStyleBackColor = true;
            this.checkBox_StaticticsClient.CheckedChanged += new System.EventHandler(this.checkBox_StaticticsClient_CheckedChanged);
            // 
            // comboBox_StatisticUser
            // 
            this.comboBox_StatisticUser.Enabled = false;
            this.comboBox_StatisticUser.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.comboBox_StatisticUser.FormattingEnabled = true;
            this.comboBox_StatisticUser.Location = new System.Drawing.Point(496, 38);
            this.comboBox_StatisticUser.Name = "comboBox_StatisticUser";
            this.comboBox_StatisticUser.Size = new System.Drawing.Size(198, 26);
            this.comboBox_StatisticUser.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(350, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 20;
            this.label27.Text = "До";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(210, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "От";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.dateTimePicker2.Location = new System.Drawing.Point(353, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 26);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Код Продукта";
            // 
            // textBox_StatisticsProdId
            // 
            this.textBox_StatisticsProdId.Font = new System.Drawing.Font("Sylfaen", 10.5F);
            this.textBox_StatisticsProdId.Location = new System.Drawing.Point(9, 38);
            this.textBox_StatisticsProdId.Name = "textBox_StatisticsProdId";
            this.textBox_StatisticsProdId.Size = new System.Drawing.Size(198, 26);
            this.textBox_StatisticsProdId.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProdIn.ResumeLayout(false);
            this.tabPageProdIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIn)).EndInit();
            this.tabPageProdOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductOut)).EndInit();
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).EndInit();
            this.tabPage_Rates.ResumeLayout(false);
            this.tabPage_Rates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).EndInit();
            this.tabPageDept.ResumeLayout(false);
            this.tabPageDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).EndInit();
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageCountry.ResumeLayout(false);
            this.tabPageCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            this.tabPageSell.ResumeLayout(false);
            this.tabPageSell.PerformLayout();
            this.tabPageStatistics.ResumeLayout(false);
            this.tabPageStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProdIn;
        private System.Windows.Forms.TabPage tabPageProdOut;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.DataGridView dataGridView_Categories;
        private System.Windows.Forms.Button button_SubmitCategory;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Rates;
        private System.Windows.Forms.DataGridView dataGridViewRates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SubmitRate;
        private System.Windows.Forms.TabPage tabPageDept;
        private System.Windows.Forms.DataGridView dataGridViewDept;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox textBoxRateOut;
        private System.Windows.Forms.TextBox textBoxRateIn;
        private System.Windows.Forms.TextBox textBoxRateName;
        private System.Windows.Forms.TextBox textBoxUserPercent;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPayedAmount;
        private System.Windows.Forms.Button button_Submit_Dept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUsersSubmit;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Dept_ProducId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Users_Dept;
        private System.Windows.Forms.CheckBox checkBox_Dept_Isfinished;
        private System.Windows.Forms.TabPage tabPageCountry;
        private System.Windows.Forms.DataGridView dataGridViewCountry;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Submit_Country;
        private System.Windows.Forms.DataGridView dataGridViewProductIn;
        private System.Windows.Forms.DataGridView dataGridViewProductOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxProductInId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxProdInCategory;
        private System.Windows.Forms.TextBox textBoxProdInName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_OutAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_AmountProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_InCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPageSell;
        private System.Windows.Forms.TextBox textBox_SellProductID;
        private System.Windows.Forms.Button buttonSubmitSell;
        private System.Windows.Forms.Button button_GetProductSell;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_SellProdName;
        private System.Windows.Forms.TextBox textBoxPriceForSell;
        private System.Windows.Forms.TextBox textBox_CountForSell;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox_SellUser;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBox_ProdInCountry;
        private System.Windows.Forms.Button button_CancelDept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_CancelUser;
        private System.Windows.Forms.Button button_CountryCancel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_CancelCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dept_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dept_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dept_PayedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Isfinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dept_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dept_UpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_User_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnՒ_User_Persent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CreateDate;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_StatisticsProdId;
        private System.Windows.Forms.ComboBox comboBox_StatisticUser;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox_StaticticsClient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton_MoneyCount;
        private System.Windows.Forms.RadioButton radioButton_SellCount;
        private System.Windows.Forms.RadioButton radioButton_CurrCount;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox_UnitID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox_ProdInPlace;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button1;
    }
}

