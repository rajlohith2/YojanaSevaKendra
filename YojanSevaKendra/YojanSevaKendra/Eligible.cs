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
    public partial class Eligible : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        SqlCommand cmd, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11,cmd1,cmd2;
        SqlDataReader dr1,dr2,dr3;
        String UID;

        public Eligible(String UID)
        {
			this.AcceptButton = button12;
			InitializeComponent();
            this.UID = UID;
            try
            {

                con.Open();
                cmd = new SqlCommand("SELECT ServiceCode from Eligible_for where UID =@UID; ", con);
                cmd.Parameters.AddWithValue("@UID", UID);
                dr1 = cmd.ExecuteReader();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button1.Text = "Not Applicable";
                button2.Text = "Not Applicable";
                button3.Text = "Not Applicable";
                button4.Text = "Not Applicable";
                button5.Text = "Not Applicable";
                button6.Text = "Not Applicable";
                button7.Text = "Not Applicable";
                button8.Text = "Not Applicable";
                button9.Text = "Not Applicable";
                button10.Text = "Not Applicable";
                button11.Text = "Not Applicable";
              
                
               
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        String str = dr1[0].ToString();
                       
                         switch(str)
                         {
                             case "10521": button1.Enabled = true; button1.Text = "Apply"; continue;
                             case "10531": button2.Enabled = true; button2.Text = "Apply"; continue;
                             case "10541": button3.Enabled = true; button3.Text = "Apply"; continue;
                             case "10551": button4.Enabled = true; button4.Text = "Apply"; continue;
                             case "10561": button5.Enabled = true; button5.Text = "Apply"; continue;
                             case "10571": button6.Enabled = true; button6.Text = "Apply"; continue;
                             case "10581": button7.Enabled = true; button7.Text = "Apply"; continue;
                             case "10591": button8.Enabled = true; button8.Text = "Apply"; continue;
                             case "10611": button9.Enabled = true; button9.Text = "Apply"; continue;
                             case "10621": button10.Enabled = true; button10.Text = "Apply"; continue;
                             case "10631": button11.Enabled = true; button11.Text = "Apply";continue;
                         }
                        
                    }
                }
                dr1.Close();

                
                String str2 = "select count(*) from Applied_services where UID='" + UID + "';";
                cmd2 = new SqlCommand(str2, con);
                dr3 = cmd2.ExecuteReader();
                dr3.Read();
                String i = dr3[0].ToString();
                int j = Convert.ToInt32(i);
                dr3.Close();
                if (j > 0)
                {
                    cmd1 = new SqlCommand("SELECT ServiceCode from Applied_Services where UID =@UID; ", con);
                    cmd1.Parameters.AddWithValue("@UID", UID);
                    dr2 = cmd1.ExecuteReader();

                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            String str1 = dr2[0].ToString();                      

                            switch (str1)
                            {
                                
                                case "10521": button1.Enabled = false; button1.Text = "Applied"; continue;
                                case "10531": button2.Enabled = false; button2.Text = "Applied"; continue;
                                case "10541": button3.Enabled = false; button3.Text = "Applied"; continue;
                                case "10551": button4.Enabled = false; button4.Text = "Applied"; continue;
                                case "10561": button5.Enabled = false; button5.Text = "Applied"; continue;
                                case "10571": button6.Enabled = false; button6.Text = "Applied"; continue;
                                case "10581": button7.Enabled = false; button7.Text = "Applied"; continue;
                                case "10591": button8.Enabled = false; button8.Text = "Applied"; continue;
                                case "10611": button9.Enabled = false; button9.Text = "Applied"; continue;
                                case "10621": button10.Enabled = false; button10.Text = "Applied"; continue;
                                case "10631": button11.Enabled = false; button11.Text = "Applied"; continue;
                            }

                        }
                    }
                    dr2.Close();
                }
               
            }
            catch (System.Exception excp)
            {
                MessageBox.Show("Error is :" + excp);
                con.Close();
            }
        }
    
            

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String s = UID + "10561";
            c1 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10561');", con);
            c1.ExecuteNonQuery();
            button5.Text = "Applied";
            button5.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = UID + "10531";
            c2 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','" + UID + "','10531');", con);
            c2.ExecuteNonQuery();
            button2.Text = "Applied";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = UID + "10541";
            c3 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10541');", con);
            c3.ExecuteNonQuery();
            button3.Text = "Applied";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String s = UID + "10551";
            c4 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10551');", con);
            c4.ExecuteNonQuery();
            button4.Text = "Applied";
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = UID + "10521";
            c5 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10521');", con);
            c5.ExecuteNonQuery();
            button1.Text = "Applied";
            button1.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String s = UID + "10631";
            c10 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10631');", con);
            c10.ExecuteNonQuery();
            button11.Text = "Applied";
            button11.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String s = UID + "10571";
            c6 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10571');", con);
            c6.ExecuteNonQuery();
            button6.Text = "Applied";
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String s = UID + "10581";
            c7 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10581');", con);
            c7.ExecuteNonQuery();
            button7.Text = "Applied";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String s = UID + "10591";
            c8 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10591');", con);
            c8.ExecuteNonQuery();
            button8.Text = "Applied";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String s = UID + "10611";
            c9 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10611');", con);
            c9.ExecuteNonQuery();
            button9.Text = "Applied";
            button9.Enabled = false;
        }

        private void Eligible_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String s = UID + "10621";
            c11 = new SqlCommand("Insert into Applied_Services values('"+s+"','Processing','"+UID+"','10621');", con);
            c11.ExecuteNonQuery();
            button10.Text = "Applied";
            button10.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Appliedpage ap = new Appliedpage(UID);
            this.Hide();
            ap.Show();

        }
    }
}
