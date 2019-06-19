using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace YojanSevaKendra
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
			this.AcceptButton = LOGINbutton;
			InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        SqlCommand cmd, cmd1,cmd2;
        SqlDataReader dr1, dr2,dr3;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String s = "select count(*) from aadhaar where UID='" + uidtextbox.Text + "';";
            cmd = new SqlCommand(s, con);
            dr1 = cmd.ExecuteReader();
            dr1.Read();
            if (dr1[0].Equals(1))
            {

                dr1.Close();
                String syn = "select password from aadhaar where UID='" + uidtextbox.Text + "';";
                cmd1 = new SqlCommand(syn, con);
                dr2 = cmd1.ExecuteReader();
                dr2.Read();
                String UIDpass = dr2[0].ToString();
                String pass = passwordtextbox.Text;
                dr2.Close();
                if (pass.Equals(UIDpass))
                {
                    String str = "select count(*) from Eligible_For where UID='" + uidtextbox.Text + "';";
                    cmd2 = new SqlCommand(str, con);
                    dr3 = cmd2.ExecuteReader();
                    dr3.Read();
                    String i = dr3[0].ToString();
                    int j = Convert.ToInt32(i);
                    dr3.Close();
                    if (j>0)
                    {
                        Eligible obe = new Eligible(uidtextbox.Text);
                        this.Hide();
                        obe.Show();
                    }
                    else
                    {

                        Services observ = new Services(uidtextbox.Text.ToString());
                        this.Hide();
                        observ.Show();
                    }
                   
                }

                else
                {
                    // don't login
                    MessageBox.Show("Log In Failed.Invalid Credentials!");
                }
            }
            else
            {
                // don't login
                MessageBox.Show("Log In Failed.Invalid Credentials!");
            }
            con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Aadhaarpage obj1 = new Aadhaarpage();
            this.Hide();
            obj1.Show();
        }
    }
}

