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
using System.Runtime.InteropServices;
using System.Globalization;
namespace YojanSevaKendra
{
    public partial class Services : Form
    {
        String UID;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lohith\\source\\repos\\YojanSevaKendra\\YojanSevaKendra\\govtdbs.mdf;Integrated Security=True;");
        SqlCommand comnd, cmd,c, cmd1, cmd2, c1, c2, c3, c4, c5, c6, c7,c8,c9,c10,c11;
        SqlDataReader dr1,dr2,dr3,dr4;
        public Services(String UID)
        {
            InitializeComponent();
			this.AcceptButton = button1;
			this.UID = UID;
        }
        public Services()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String s = "select count(*) from Eligible_for where UID='" + UID + "';";
                c = new SqlCommand(s, con);
                dr4 = c.ExecuteReader();
                dr4.Read();
                if (dr4[0].Equals(0))
                {
                    dr4.Close();                   
                    comnd = new SqlCommand("SELECT DOB,Annual_Income,Occupation from PAN where UID =@UID; ", con);
                    comnd.Parameters.AddWithValue("@UID", UID);
                    dr1 = comnd.ExecuteReader();
                    dr1.Read();
                    String AnnualIncome = dr1[1].ToString();
                    String Occupation = dr1[2].ToString();
                    int income = Int32.Parse(AnnualIncome);
                    String DOB = dr1[0].ToString();
                    DateTime newDate = Convert.ToDateTime(DOB);
                    int age = CalculateAge(newDate);
                    dr1.Close();

                    cmd2 = new SqlCommand("SELECT Gender from Aadhaar where UID =@UID; ", con);
                    cmd2.Parameters.AddWithValue("@UID", UID);
                    dr3 = cmd2.ExecuteReader();
                    dr3.Read();
                    String gender = dr3[0].ToString();
                    dr3.Close();
                    String code = "0000";
                    StringBuilder sb = new StringBuilder(code);
                    if (income < 500000)
                    {
                        sb[0] = '1';
                    }
                    else
                    {
                        sb[0] = '2';
                    }

                    if (age <= 18)
                    {
                        sb[1] = '1';
                    }
                    else
                    {
                        sb[1] = '2';
                    }
                    switch (Occupation)
                    {
                        case "Student": sb[2] = '1'; break;
                        case "Business": sb[2] = '2'; break;
                        case "Housewife": sb[2] = '3'; break;
                        case "Entrepreneur": sb[2] = '4'; break;
                        case "Agriculture": sb[2] = '5'; break;
                        case "Employed": sb[2] = '6'; break;
                        case "Unemployed": sb[2] = '7'; break;
                        case "Retired": sb[2] = '8'; break;
                    }
                    if (gender.Equals("Male"))
                    {
                        sb[3] = '1';
                    }
                    else
                    {
                        sb[3] = '2';
                    }


                    if (sb[1] == '2')
                    {
                        c1 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10521');", con);
                        c1.ExecuteNonQuery();
                        c2 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10591');", con);
                        c2.ExecuteNonQuery();
                    }
                    if (sb[0] == '1' && sb[1] == '2')
                    {
                        c3 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10531');", con);
                        c3.ExecuteNonQuery();
                        c4 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10551');", con);
                        c4.ExecuteNonQuery();
                    }
                    if (sb[1] == '1' && sb[3] == '2')
                    {
                        c5 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10541');", con);
                        c5.ExecuteNonQuery();
                        c6 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10611');", con);
                        c6.ExecuteNonQuery();
                    }
                    if (sb[2] == '5')
                    {
                        c7 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10561');", con);
                        c7.ExecuteNonQuery();
                        c8 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10581');", con);
                        c8.ExecuteNonQuery();
                    }
                    if (sb[2] == '4')
                    {
                        c9 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10571');", con);
                        c9.ExecuteNonQuery();

                    }
                    if (sb[0] == '1' && sb[2] == '1')
                    {
                        c10 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10621');", con);
                        c10.ExecuteNonQuery();
                    }
                    if (sb[1] == '1' && sb[2] == '1')
                    {
                        c11 = new SqlCommand("Insert into ELIGIBLE_FOR values('" + UID + "','10631');", con);
                        c11.ExecuteNonQuery();
                    }
                }


                Eligible obj5 = new Eligible(UID);
                this.Hide();
                obj5.Show();
            }
            catch (System.Exception excp)
            {
                MessageBox.Show("Error is :" + excp);
                con.Close();
            }
        }
    }
}
