using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YojanSevaKendra
{
	public partial class PANpage : Form
	{
        Aadhaarpage ap = new Aadhaarpage();
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        String st, str;
        public PANpage(String UID,String DoB)
		{
			InitializeComponent();
			this.AcceptButton = button1;
			st = UID;
            str = DoB;
            uIDTextBox.Text = st;
            uIDTextBox.ReadOnly = true;
            DObtextBox.Text = str;
            DObtextBox.ReadOnly = true;
        }

		/*private void pANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.pANBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.govtdbsDataSet);

		}*/

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DObtextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void uIDTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void occupationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                
                connection.Open();

                
                String tax = taxPaidTextBox.Text.ToString();
                String ann = annual_IncomeTextBox.Text.ToString();
                int a = Convert.ToInt32(ann);
                int t = Convert.ToInt32(tax);
                SqlCommand cmd = new SqlCommand("Insert into PAN (PAN,Name,DOB,Taxpaid,Annual_Income,Occupation,UID) Values(@PAN,@Name,@DOB,@Taxpaid,@Annual_Income,@Occupation,@UID)", connection);


                cmd.Parameters.AddWithValue("@PAN", pANTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@DOB", str);
                cmd.Parameters.AddWithValue("@Taxpaid", taxPaidTextBox.Text);
                cmd.Parameters.AddWithValue("@Annual_Income", annual_IncomeTextBox.Text);
                cmd.Parameters.AddWithValue("@Occupation", occupationComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@UID", st);

                cmd.ExecuteNonQuery();


                if (t==0&&a>250000)
                {

                    MessageBox.Show("As you have not Paid any Tax you are not Eligible to apply for any Government Services ");

                    SqlCommand cmd1 = new SqlCommand("DELETE FROM AADHAAR WHERE UID=@UID", connection);
                    cmd.ExecuteNonQuery();
                    LOGIN oblog = new LOGIN();
                    this.Hide();
                    oblog.Show();
                }
                else {
                    Bankpage obj3 = new Bankpage(st, pANTextBox.Text);
                    this.Hide();
                    obj3.Show();
                }                                                            

                
            }
            catch (System.Exception excp)
            {
                MessageBox.Show("Error is :" + excp);
                connection.Close();
            }
           
        }
    }
}
