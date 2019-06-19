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
    public partial class Appliedpage : Form
    {
        String UID,name;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr1;
        public Appliedpage(String UID)
        {
            InitializeComponent();
            this.UID = UID;
            con.Open();
            SqlDataAdapter obj = new SqlDataAdapter("SELECT AppNo, ServiceCode, Status FROM APPLIED_SERVICES where UID ='" + UID + "';", con);
            DataTable dtb = new DataTable();
            obj.Fill(dtb);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtb;
            dataGridView1.ReadOnly = true;
            cmd=new SqlCommand("Select name from aadhaar where UID='" + UID + "';", con);
            dr1 = cmd.ExecuteReader();
            dr1.Read();
            name = dr1[0].ToString();
            label1.Text = UID;
            label2.Text = name.ToUpper();
            
        }

       /* private void aPPLIED_SERVICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPLIED_SERVICESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.govtdbsDataSet);

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void aPPLIED_SERVICESDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN obl = new LOGIN();
            this.Hide();
            obl.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
