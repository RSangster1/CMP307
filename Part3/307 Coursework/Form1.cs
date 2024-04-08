using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Management;
using Microsoft.Win32;
using System.Collections;
using System.Net.Http;
using restClient;
using Newtonsoft.Json;

namespace _307_Coursework
{
    public partial class Form1 : Form
    {

        SqlConnection conn;

        string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

        public Form1()
        {

            conn = new SqlConnection(connString);
            conn.Open();

            InitializeComponent();
            try
            {


               

                string query = "SELECT * FROM [mssql2003115].[dbo].[Account]";

                SqlCommand command = new SqlCommand(query);

                command.Connection = conn;

                SqlDataReader data = command.ExecuteReader();


                while (data.Read())
                {

                    connectionBox.Checked = true;

                }
                data.Close();

                conn.Close();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            // TODO: This line of code loads data into the 'mssql2003115DataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2003115DataSet.Assets);


        }

        private void connectionBox_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void InsertBTN_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            conn.Open();


            string query = "";
            var Insert1 = "";
            var Insert2 = "";
            var Insert3 = "";
            var Insert4 = "";
            var Insert5 = "";
            var Insert6 = "";
            var Insert7 = "";
            var Insert8 = "";
            var Insert9 = "";

            Insert1 = assetIDTextBox.Text;
            Insert2 = systemNameTextBox.Text;
            Insert3 = modelTextBox.Text;
            Insert4 = manufacturerTextBox.Text;
            Insert5 = typeTextBox.Text;
            Insert6 = iPAddressTextBox.Text;
            Insert7 = purchaseDateDateTimePicker.Text;
            Insert8 = noteTextBox.Text;
            Insert9 = OSTextBox.Text;


            query = "INSERT INTO [mssql2003115].[dbo].[Assets] VALUES ('" + Insert1 + "' , '" + Insert2 + "' , '" + Insert3 + "' , '" + Insert4 + "' , '" + Insert5 + "' , '" + Insert6 + "' , '" + Insert7 + "' ,'" + Insert8 + "' ,'" + Insert9 + "')";

            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            SqlDataReader data = command.ExecuteReader();
            MessageBox.Show("Asset Created with ID: " + Insert1 + ".");
            conn.Close();
        }

        

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connString);
            conn.Open();

            string query = "";
            int ID = assetsDataGridView.CurrentCell.RowIndex + 1;

            query = "DELETE FROM [mssql2003115].[dbo].[Assets] WHERE AssetID = '"+ ID +  "'";
            
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            SqlDataReader data = command.ExecuteReader();
            conn.Close();
          
            MessageBox.Show("Asset Deleted with ID: " + ID + ".");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.assetsTableAdapter.Fill(this.mssql2003115DataSet.Assets);
            assetsDataGridView.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void purchaseDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void operatingSystemLabel_Click(object sender, EventArgs e)
        {

        }

        private void operatingSystemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            dgvWMI.DataSource = GetInformation(comboBox1.Text);

        }

        private ArrayList GetInformation(string qry)
        {
            ManagementObjectSearcher searcher;
            int i = 0;
            ArrayList arrayListInformationCollactor = new ArrayList();
            try
            {
                searcher = new ManagementObjectSearcher("SELECT * FROM " + qry);
                foreach (ManagementObject mo in searcher.Get())
                {
                    i++;
                    PropertyDataCollection searcherProperties = mo.Properties;
                    foreach (PropertyData sp in searcherProperties)
                    {
                        arrayListInformationCollactor.Add(sp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arrayListInformationCollactor;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string OS = this.OSTextBox.Text;
            versionTextBox.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            updatedDateTimePicker.Visible = true;
            this.softwareTableAdapter.FillBy(this.mssql2003115DataSet.Software, OS);
        }



        private void assetsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assetsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

      

        private void NVDButton_Click_1(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            txtResponse.Clear();

            string keyword = OSTextBox.Text;
            keywordTextBox.Text = keyword;

            rClient.endPoint = "https://services.nvd.nist.gov/rest/json/cves/2.0?resultsPerPage=20&keywordSearch=" + keyword + "";

            string strJSON = string.Empty;

            strJSON = rClient.makeRequest();

            dynamic JSONData = JsonConvert.DeserializeObject<dynamic>(strJSON);
            int i = 0;
            string newLine = Environment.NewLine;

            try
            {
                for (i = 0; i < 20; i++)
                {

                    string source = JSONData["vulnerabilities"][i]["cve"]["descriptions"][0]["value"];
                    string score = JSONData["vulnerabilities"][i]["cve"]["metrics"]["cvssMetricV2"][0]["exploitabilityScore"];

                    txtResponse.Text += "Vulnerabilty Source: " + source + newLine;
                    txtResponse.Text += "Expliotability score: " + score + newLine;
                    txtResponse.Text += newLine;
                }
            }
            catch
            {
                txtResponse.Text = "no data";
            }
            
        }



        private void versionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }

    //api key = 5134bd07-8df0-48ed-986f-9f4a4cc4897a  

}
