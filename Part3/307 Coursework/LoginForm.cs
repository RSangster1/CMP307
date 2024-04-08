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

namespace _307_Coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn;

                string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

                conn = new SqlConnection(connString);

                conn.Open();


                string query = "SELECT Password FROM [mssql2003115].[dbo].[Account] WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@Username", textBox1.Text);

                command.Connection = conn;

                SqlDataReader data = command.ExecuteReader();


                while (data.Read())
                {
                    if (BCrypt.Net.BCrypt.Verify(textBox2.Text, data.GetString(0)))
                    {
                       DialogResult = DialogResult.OK;
                        
                    }
                    else
                    {
                        label4.Visible = true;
                    }
                   

                }
                data.Close();

                conn.Close();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
