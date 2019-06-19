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
	public partial class Bankpage : Form
	{
        String UID,PAN;
         SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        public Bankpage(String UID,String PAN)
		{
			InitializeComponent();
			this.AcceptButton = button1;
			this.accNoTextBox.Text =String.Empty;
            this.nameTextBox.Text = String.Empty;
            this.iFSCTextBox.Text = String.Empty;
            this.UID = UID;
            this.PAN = PAN;
            uIDTextBox.Text = this.UID;
            pANTextBox.Text = this.PAN;
            uIDTextBox.ReadOnly = true;
            pANTextBox.ReadOnly = true;
        }
        /*
		private void bANK_ACCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bANK_ACCBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.govtdbsDataSet);

		}*/

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

        private void accTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void uIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {

                connection.Open();

                
                SqlCommand cmd = new SqlCommand("Insert into BANK_ACC (AccNo,Name,IFSC,AccType,UID,PAN) Values(@AccNo,@Name,@IFSC,@AccType,@UID,@PAN)", connection);

                cmd.Parameters.AddWithValue("@AccNo", accNoTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@IFSC", iFSCTextBox.Text);
                cmd.Parameters.AddWithValue("@AccType", accTypecomboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@UID",UID);
                cmd.Parameters.AddWithValue("@PAN", PAN);
                

                cmd.ExecuteNonQuery();


                Services obj4 = new Services(UID);
                this.Hide();
                obj4.Show();
            }
            catch (System.Exception excp)
            {
                MessageBox.Show("Error is :" + excp);
                connection.Close();
            }
           
        }
    }
}
