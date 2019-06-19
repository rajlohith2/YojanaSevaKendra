using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YojanSevaKendra
{
	public partial class Aadhaarpage : Form
	{
        public String u;
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        public Aadhaarpage()
		{
			InitializeComponent();
			this.AcceptButton = button1;
		}

		/*private void aADHAARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.aADHAARBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.govtdbsDataSet);

		}*/

		private void Form2_Load(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aADHAARBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        { 
            try
            {
               
                connection.Open();
				SqlCommand cmd = new SqlCommand("insertAadhaar", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				/*SqlCommand cmd = new SqlCommand("Insert into AADHAAR (UID,Name,Phone,DOB,Address,Gender,Password) Values(@UID,@Name,@Phone,@DOB,@Address,@Gender,@Password)",connection); */

				cmd.Parameters.AddWithValue("@UID", uidTextBox.Text);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                   
                    cmd.ExecuteNonQuery();
                

                    PANpage obj2 = new PANpage(uidTextBox.Text,dobBox.Text);
               
                    this.Hide();
                    obj2.Show();
            }
            catch (System.Data.SqlClient.SqlException excp)
            {
                MessageBox.Show("UID Already Registered.Please Login!");
                LOGIN obl = new LOGIN();
                this.Hide();
                obl.Show();
                connection.Close();
            }

            catch (System.Exception excp)
            {
                MessageBox.Show("Details Not entered correctly!");             
                connection.Close();
            }
        }
    }
}
