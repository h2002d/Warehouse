using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WarehouseWinForm
{
    public partial class Main_Form : Form
    {
        #region Members
        private WarehouseBack.Classes.Dept dept;
        private WarehouseBack.Classes.Category category;
        private WarehouseBack.Classes.Rate rate;
        private WarehouseBack.Classes.User user;
        private WarehouseBack.Classes.Country country;
        private WarehouseBack.Classes.ProductIn productin;
        // private WarehouseBack.Classes.ProductOut prodOutForSale;
        private WarehouseBack.Classes.ProductIn prodInForSell;
        #endregion
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 100F);
        public Main_Form()
        {
            InitializeComponent();
        }

        #region DataGridevents

        private void dataGridView_Categories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_Categories.Rows[e.RowIndex].Cells[0].Value);
            category = WarehouseBack.Classes.Category.GetCategory(id);
            textBoxCategoryName.Text = category.Name;
        }

        private void dataGridViewRates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewRates.Rows[e.RowIndex].Cells[0].Value);
            rate = WarehouseBack.Classes.Rate.GetRate(id);
            textBoxRateIn.Text = rate.RateIn.ToString();
            textBoxRateOut.Text = rate.RateOut.ToString();
            textBoxRateName.Text = rate.Name;
        }

        private void dataGridViewDept_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewDept.Rows[e.RowIndex].Cells[0].Value);
            dept = WarehouseBack.Classes.Dept.GetDept(id);
            textBoxPayedAmount.Text = dept.PayedAmount.ToString();
            textBox_Dept_ProducId.Text = dept.ProductOutID.ToString();
            comboBox_Users_Dept.SelectedValue = dept.UserID;
            checkBox_Dept_Isfinished.Checked = dept.IsFinishDept;
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value);
            user = WarehouseBack.Classes.User.GetUser(id);
            textBoxUserName.Text = user.Name;
            textBoxUserPercent.Text = user.Persent.ToString();
        }

        private void dataGridViewCountry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCountry.Rows[e.RowIndex].Cells[0].Value);
            country = WarehouseBack.Classes.Country.GetCountry(id);
            textBoxCountryName.Text = country.Name;

        }

        private void dataGridView_Categories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBoxOk())
                {
                    int id = Convert.ToInt32(dataGridView_Categories.Rows[e.RowIndex].Cells[0].Value);
                    category = WarehouseBack.Classes.Category.GetCategory(id);
                    category.Delete();
                }
            }
        }

        private void dataGridViewRates_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBoxOk())
                {
                    int id = Convert.ToInt32(dataGridViewRates.Rows[e.RowIndex].Cells[0].Value);
                    rate = WarehouseBack.Classes.Rate.GetRate(id);
                    rate.Delete();
                }
            }
        }

        private void dataGridViewDept_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBoxOk())
                {
                    int id = Convert.ToInt32(dataGridViewDept.Rows[e.RowIndex].Cells[0].Value);
                    dept = WarehouseBack.Classes.Dept.GetDept(id);
                    dept.Delete();
                }
            }
        }

        private void dataGridViewUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBoxOk())
                {
                    int id = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value);
                    user = WarehouseBack.Classes.User.GetUser(id);
                    user.Delete();
                }
            }
        }

        private void dataGridViewCountry_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBoxOk())
                {
                    int id = Convert.ToInt32(dataGridViewCountry.Rows[e.RowIndex].Cells[0].Value);
                    country = WarehouseBack.Classes.Country.GetCountry(id);
                    country.Delete();
                }
            }
        }

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPageCategories)
            {
                dataGridView_Categories.DataSource = WarehouseBack.Classes.Category.GetCategories();
                comboBox.DataSource = WarehouseBack.Classes.Category.GetCategories();
                comboBox.ValueMember = "CategoryID";
                comboBox.DisplayMember = "Name";
            }
            else
                if (tabControl1.SelectedTab == tabPage_Rates)
                {
                    dataGridViewRates.DataSource = WarehouseBack.Classes.Rate.GetCountries();
                }
                else
                    if (tabControl1.SelectedTab == tabPageDept)
                    {
                        dataGridViewDept.DataSource = WarehouseBack.Classes.Dept.GetDepts();
                        comboBox_Users_Dept.DataSource = WarehouseBack.Classes.User.GetUsers();
                        comboBox_Users_Dept.ValueMember = "UserID";
                        comboBox_Users_Dept.DisplayMember = "Name";
                    }
                    else
                        if (tabControl1.SelectedTab == tabPageUser)
                        {
                            dataGridViewUsers.DataSource = WarehouseBack.Classes.User.GetUsers();
                        }
                        else
                            if (tabControl1.SelectedTab == tabPageProdIn)
                            {
                                dataGridViewProductIn.DataSource = WarehouseBack.Classes.ProductIn.GetProductIns();

                                comboBoxProdInCategory.DataSource = WarehouseBack.Classes.Category.GetCategories();
                                comboBoxProdInCategory.ValueMember = "CategoryID";
                                comboBoxProdInCategory.DisplayMember = "Name";

                                comboBox_ProdInPlace.DataSource = WarehouseBack.Classes.Place.GetPlaces();
                                comboBox_ProdInPlace.ValueMember = "PlaceID";
                                comboBox_ProdInPlace.DisplayMember = "Name";

                                comboBox_ProdInCountry.DataSource = WarehouseBack.Classes.Country.GetCountries();
                                comboBox_ProdInCountry.ValueMember = "CountryID";
                                comboBox_ProdInCountry.DisplayMember = "Name";

                                comboBox_UnitID.DataSource = WarehouseBack.Classes.Rate.GetCountries();
                                comboBox_UnitID.ValueMember = "RateID";
                                comboBox_UnitID.DisplayMember = "Name";
                            }
                            else
                                if (tabControl1.SelectedTab == tabPageProdOut)
                                {
                                    dataGridViewProductOut.DataSource = WarehouseBack.Classes.ProductOut.GetProductOuts();
                                }
                                else
                                    if (tabControl1.SelectedTab == tabPageCountry)
                                    {
                                        dataGridViewCountry.DataSource = WarehouseBack.Classes.Country.GetCountries();
                                    }
                                    else
                                        if (tabControl1.SelectedTab == tabPageSell)
                                        {
                                            comboBox_SellUser.DataSource = WarehouseBack.Classes.User.GetUsers();
                                            comboBox_SellUser.ValueMember = "UserID";
                                            comboBox_SellUser.DisplayMember = "Name";
                                        }
                                        else
                                            if (tabControl1.SelectedTab == tabPageStatistics)
                                            {
                                                comboBox_StatisticUser.DataSource = WarehouseBack.Classes.User.GetUsers();
                                                comboBox_StatisticUser.ValueMember = "UserID";
                                                comboBox_StatisticUser.DisplayMember = "Name";
                                            }


        }

        public bool IsEmtyStr(string text)
        {
            return text == null || text == String.Empty;
        }
        #region Button Events

        private void button_SubmitCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmtyStr(textBoxCategoryName.Text))
                {
                    if (category == null)
                    {
                        WarehouseBack.Classes.Category newCategory = new WarehouseBack.Classes.Category();
                        newCategory.Name = textBoxCategoryName.Text;
                        newCategory.ParentID = Convert.ToInt32(comboBox.SelectedValue);
                        newCategory.Save();

                    }
                    else
                    {
                        category.Name = textBoxCategoryName.Text;
                        category.ParentID = Convert.ToInt32(comboBox.SelectedValue);
                        category.Save();
                    }
                    category = null;
                    textBoxCategoryName.Text = "";
                    comboBox.SelectedValue = 1;
                    MessageBoxOk1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_SubmitRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmtyStr(textBoxRateName.Text) && !IsEmtyStr(textBoxRateIn.Text) && !IsEmtyStr(textBoxRateOut.Text))
                {
                    if (rate == null)
                    {
                        WarehouseBack.Classes.Rate newRate = new WarehouseBack.Classes.Rate();
                        newRate.Name = textBoxRateName.Text;
                        newRate.RateIn = float.Parse(textBoxRateIn.Text, CultureInfo.InvariantCulture.NumberFormat);
                        newRate.RateOut = float.Parse(textBoxRateOut.Text, CultureInfo.InvariantCulture.NumberFormat);
                        newRate.Save();

                    }
                    else
                    {
                        rate.Name = textBoxRateName.Text;
                        rate.RateIn = float.Parse(textBoxRateIn.Text, CultureInfo.InvariantCulture.NumberFormat);
                        rate.RateOut = float.Parse(textBoxRateOut.Text, CultureInfo.InvariantCulture.NumberFormat);
                        rate.Save();
                    }

                    rate = null;
                    textBoxRateIn.Text = "";
                    textBoxRateOut.Text = "";
                    textBoxRateName.Text = "";
                    MessageBoxOk1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button_SubmitUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmtyStr(textBoxUserName.Text) && !IsEmtyStr(textBoxUserPercent.Text))
                {
                    if (user == null)
                    {
                        WarehouseBack.Classes.User newUser = new WarehouseBack.Classes.User();
                        newUser.Name = textBoxUserName.Text;
                        newUser.Persent = Convert.ToInt32(textBoxUserPercent.Text);
                        newUser.Save();

                    }
                    else
                    {
                        user.Name = textBoxUserName.Text;
                        user.Persent = Convert.ToInt32(textBoxUserPercent.Text);
                        user.Save();
                    }
                    textBoxUserPercent.Text = "";
                    textBoxUserName.Text = "";
                    user = null;
                    MessageBoxOk1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_SubmitDept_Click(object sender, EventArgs e)
        {
            //if (user == null)
            //{
            //    WarehouseBack.Classes.Dept newDept = new WarehouseBack.Classes.Dept();
            //    newDept.Name = textBoxUserName.Text;
            //    newDept.Persent = Convert.ToInt32(textBoxUserPercent.Text);
            //    newDept.Save();

            //}
            //else
            //{
            if (!IsEmtyStr(textBox_Dept_ProducId.Text) && !IsEmtyStr(textBoxPayedAmount.Text))
            {
                try
                {
                    dept.PayedAmount = Convert.ToInt32(textBoxPayedAmount.Text);
                    dept.UserID = Convert.ToInt32(comboBox_Users_Dept.SelectedValue);
                    dept.IsFinishDept = checkBox_Dept_Isfinished.Checked;
                    dept.ProductOutID = Convert.ToInt32(textBox_Dept_ProducId.Text);

                    dept.Save();
                    dept = null;
                    textBoxPayedAmount.Text = "";
                    textBox_Dept_ProducId.Text = "";
                    comboBox_Users_Dept.SelectedValue = 1;
                    MessageBoxOk1();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            // }
        }

        private void button_SubmitCountry_Click(object sender, EventArgs e)
        {
            if (!IsEmtyStr(textBoxCountryName.Text))
            {
                try
                {
                    if (country == null)
                    {
                        WarehouseBack.Classes.Country newCountry = new WarehouseBack.Classes.Country();
                        newCountry.Name = textBoxCountryName.Text;
                        newCountry.Save();
                    }
                    else
                    {
                        country.Name = textBoxCountryName.Text;
                        country.Save();
                    }
                    country = null;
                    textBoxCountryName.Text = "";
                    MessageBoxOk1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }


        private void button_GetProductSell_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_SellProductID.Text);
                prodInForSell = WarehouseBack.Classes.ProductIn.GetProductInForSell(id);
                label_SellProdName.Text = prodInForSell.Name;
                WarehouseBack.Classes.Rate rateofprod = WarehouseBack.Classes.Rate.GetRate(prodInForSell.UnitID);
                textBoxPriceForSell.Text = (rateofprod.RateOut*prodInForSell.OutAmount).ToString();
                MessageBoxOk1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSubmitSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmtyStr(textBoxPriceForSell.Text) && !IsEmtyStr(textBox_CountForSell.Text) && !IsEmtyStr(textBox_CountForSell.Text))
                {
                    int id = Convert.ToInt32(textBox_SellProductID.Text);
                    WarehouseBack.Classes.ProductOut prodOutForSale = new WarehouseBack.Classes.ProductOut();
                    prodOutForSale.ProductInID = prodInForSell.ProductInID.Value;
                    prodOutForSale.Amount = float.Parse(textBoxPriceForSell.Text, CultureInfo.InvariantCulture.NumberFormat);
                    prodOutForSale.Count = Convert.ToInt32(textBox_CountForSell.Text);
                    prodOutForSale.UserID = Convert.ToInt32(comboBox_SellUser.SelectedValue.ToString());
                    prodOutForSale.Save();
                    MessageBoxOk1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmtyStr(textBoxProdInName.Text) && !IsEmtyStr(textBox_InCount.Text)
                    && !IsEmtyStr(textBox_AmountProd.Text) && !IsEmtyStr(textBoxProductInId.Text))
                {
                    WarehouseBack.Classes.ProductIn newProdIn = new WarehouseBack.Classes.ProductIn();
                    newProdIn.Name = textBoxProdInName.Text;
                    newProdIn.Count = Convert.ToInt32(textBox_InCount.Text);
                    newProdIn.CurrCount = Convert.ToInt32(textBox_InCount.Text);
                    newProdIn.Amount = float.Parse(textBox_AmountProd.Text, CultureInfo.InvariantCulture.NumberFormat);
                    newProdIn.OutAmount = float.Parse(textBox_OutAmount.Text, CultureInfo.InvariantCulture.NumberFormat);
                    newProdIn.ProducKey = Convert.ToInt32(textBoxProductInId.Text);
                    newProdIn.CountryID = Convert.ToInt32(comboBox_ProdInCountry.SelectedValue);
                    newProdIn.PlaceID = Convert.ToInt32(comboBox_ProdInPlace.SelectedValue);
                    newProdIn.CategoryID = Convert.ToInt32(comboBoxProdInCategory.SelectedValue);
                    newProdIn.UnitID = Convert.ToInt32(comboBox_UnitID.SelectedValue);
                    newProdIn.Save();
                    MessageBoxOk1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_CountryCancel_Click(object sender, EventArgs e)
        {
            country = null;
            textBoxCountryName.Text = "";
        }


        #endregion

        public bool MessageBoxOk()
        {
            DialogResult result = MessageBox.Show("Удалить?", "Удалить!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public void MessageBoxOk1()
        {
            DialogResult result = MessageBox.Show("ОК", "Продолжить!", MessageBoxButtons.OK);

        }

        private void button_CancelUser_Click(object sender, EventArgs e)
        {
            user = null;
            textBoxUserName.Text = "";
            textBoxUserPercent.Text = "";
        }

        private void button_CancelDept_Click(object sender, EventArgs e)
        {
            dept = null;
            textBoxPayedAmount.Text = " ";
            textBox_Dept_ProducId.Text = " ";
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            rate = null;
            textBoxRateName.Text = "";
            textBoxRateIn.Text = "";
            textBoxRateOut.Text = "";
        }

        private void button_CancelCategory_Click(object sender, EventArgs e)
        {
            category = null;
            textBoxCategoryName.Text = "";
        }

        private void checkBox_StaticticsClient_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_StatisticUser.Enabled = checkBox_StaticticsClient.Checked;
        }

        #region Statistics

        private void button3_Click(object sender, EventArgs e)
        {
            GetStatistics();
        }

        private void GetStatistics()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = WarehouseBack.Classes.Dept.GetString();
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                if (!radioButton_MoneyCount.Checked)
                {
                    cmd.CommandText = GetProcedureText();                    
                    SqlDataReader rdr = cmd.ExecuteReader();
                    chart1.Series.Clear();
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 10;
                    while (rdr.Read())
                    {

                        if (chart1.ChartAreas[0].AxisY.Maximum < Convert.ToInt32(rdr[0]))
                            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(rdr[0]);

                        Series series = this.chart1.Series.Add(rdr[1].ToString() + "  Каличество :  " + rdr[0].ToString());
                        series.Points.Add(Convert.ToDouble(rdr[0]));
                    }
                }
                else
                {

                    cmd.CommandText = GetCashText();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    chart1.Series.Clear();
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 10;
                    while (rdr.Read())
                    {
                        try
                        {

                            if (chart1.ChartAreas[0].AxisY.Maximum < Convert.ToDouble(rdr[0]))
                                chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(rdr[0]);

                            Series series = this.chart1.Series.Add(rdr[1].ToString() + "  Каличество :  " + Convert.ToDouble(rdr[0]));
                            series.Points.Add(Convert.ToDouble(rdr[0]));
                        }
                        catch { }
                    }
                   
                }
               
                cnn.Close();

            }
            catch (Exception ex)
            {
                cnn.Close();
            }
        }

        private string GetCashText()
        {
            StringBuilder query = new StringBuilder("");
            query.Append("SELECT SUM(pout.Count*pout.Amount-ProductIn.Amount),ProductIn.Name ,ProductIn.ProductInID,ProductIn.Amount FROM ProductOut pout  INNER JOIN ProductIn ON ProductIn.ProductInID=pout.ProductInID AND pout.CreateDate BETWEEN '" + dateTimePicker1.Value + "' AND '" + dateTimePicker2.Value + "'");
            query.Append(" Group by pout.ProductInID ,ProductIn.Name ,ProductIn.ProductInID,ProductIn.Amount");
            return query.ToString();
        }


        private string GetProcedureText()
        {
            if (radioButton_CurrCount.Checked)
            {
                StringBuilder query = new StringBuilder("");

                query.Append("WITH Sales_CTE (Counts, prodIn )" +
                " AS (  SELECT SUM(pout.Count),pout.ProductInID FROM ProductOut pout Group by pout.ProductInID )" +

                " SELECT  SUM(pin.Count)-Counts, pin.Name, prodIn " +
                " FROM Sales_CTE" +
                " INNER JOIN ProductIn pin" +
                " ON Sales_CTE.prodIn=pin.ProductInID AND CreateDate BETWEEN '" + dateTimePicker1.Value + "' AND '" + dateTimePicker2.Value+"'");
                if (textBox_StatisticsProdId.Text != "")
                {
                    query.Append(" AND pin.ProducKey=" + textBox_StatisticsProdId.Text);
                }
                query.Append(" GROUP By  Sales_CTE.prodIn,pin.ProductInID,Sales_CTE.Counts,pin.Name ");
                return query.ToString();
            }
            else
            {
                StringBuilder query = new StringBuilder("");
                query.Append("SELECT SUM(pout.Count),ProductIn.Name FROM ProductOut pout INNER JOIN ProductIn ON ProductIn.ProductInID=pout.ProductInID AND pout.CreateDate BETWEEN '" + dateTimePicker1.Value + "' AND '" + dateTimePicker2.Value + "'");
                if (textBox_StatisticsProdId.Text != "")
                {
                    query.Append(" AND ProductIn.ProducKey=" + textBox_StatisticsProdId.Text);
                }
                query.Append(" Group by pout.ProductInID ,ProductIn.Name ");
                return query.ToString();
            }
        }

        #endregion

        private void dataGridViewProductIn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewProductIn.Rows[e.RowIndex].Cells[0].Value);
            productin = WarehouseBack.Classes.ProductIn.GetProductIn(id);
            textBoxProductInId.Text = productin.ProductInID.ToString();
            comboBoxProdInCategory.SelectedValue = productin.CategoryID;
            textBoxProdInName.Text = productin.Name;
            textBox_AmountProd.Text = productin.Amount.ToString();
            textBox_OutAmount.Text = productin.OutAmount.ToString();
            textBox_InCount.Text = productin.Count.ToString();
            comboBox_UnitID.SelectedValue = productin.UnitID;
            comboBox_ProdInPlace.SelectedValue=productin.PlaceID;
            comboBox_ProdInCountry.SelectedValue = productin.CreateDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productin = null;
            textBoxProductInId.Text = "";
            comboBoxProdInCategory.SelectedValue = 0;
            textBoxProdInName.Text = "";
            textBox_AmountProd.Text = "";
            textBox_OutAmount.Text = "";
            textBox_InCount.Text = "";
            comboBox_UnitID.SelectedValue = 0;
            comboBox_ProdInPlace.SelectedValue = 0;
            comboBox_ProdInCountry.SelectedValue = 0;
        }





    }
}
