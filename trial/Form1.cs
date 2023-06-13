using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb();
            log();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            see();


        }
        string conn = (@"Data Source=REICHEL28\SQLEXPRESS01;Initial Catalog=TBLTRIAL;Integrated Security=True");

        public void see()
        {
            using (SqlConnection cn = new SqlConnection(conn))
            {


                try
                {

                    cn.Open();
                    string st = "select * from NET";
                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = table;



                    string st2 = "select * from arvhivetable";
                    SqlDataAdapter adapt2 = new SqlDataAdapter(st2, cn);
                    SqlCommand command2 = new SqlCommand();

                    command2.CommandText = st2;
                    command2.Parameters.Clear();
                    DataTable table2 = new DataTable();
                    adapt2.Fill(table2);

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.DataSource = table2;


                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }



        }


        public void add()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(conn))
                {

                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cnn.Open();
                        string day = DateTime.Now.ToString("M/d/yyyy");
                        string quer1 = " INSERT INTO NET (name , netdate) VALUES (@name , @day)";
                        SqlCommand command = new SqlCommand(quer1, cnn);

                        command.Parameters.AddWithValue("@name", textBox1.Text);
                        command.Parameters.AddWithValue("@day", day);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show(" fill up the ff.");
                    }


                    /*
                     * 
                     *   

                     *  string day = DateTime.Now.ToString("M/d/yyyy");

                    string quer1 = " INSERT INTO NET (name , netdate) VALUES ('" + textBox1.Text + "' ,'" + day + "')";
                    SqlCommand cmm = new SqlCommand(quer1, cnn);
                     cmm.ExecuteNonQuery();
                     */


                    cnn.Close();


                }






            }
            catch
            {
                MessageBox.Show("Error ");
            }




        }




        private void button2_Click(object sender, EventArgs e)
        {
            add();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            dataGridView1.Refresh();
        }


        public void delete()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    cnn.Open();


                    string inn = ("INSERT INTO arvhivetable(id, name, netdate)SELECT* FROM NET WHERE id = '" + Convert.ToInt32(textBox2.Text) + "'");
                    SqlCommand command = new SqlCommand(inn, cnn);

                    command.ExecuteNonQuery();

                    string del = (" DELETE FROM NET WHERE id = '" + Convert.ToInt32(textBox2.Text) + "'");
                    SqlCommand command1 = new SqlCommand(del, cnn);

                    command1.ExecuteNonQuery();

                    cnn.Close();





                    /*
                     
                    
                      INSERT INTO arvhivetable(id, name, netdate)SELECT* FROM NET
                     WHERE id = 6;

                     DELETE FROM arvhivetable
                    WHERE id = 6;


                string sql = @"DELETE*FROM          where id = 1";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                     */
                }






            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        public void edit()
        {

            try
            {



                using (SqlConnection cnn = new SqlConnection(conn))
                {

                    cnn.Open();
                    string del = (" ");
                    cnn.Close();





                }






            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.Show();
            search();
        }

        public void search()
        {
            using (SqlConnection cn = new SqlConnection(conn))
            {


                try
                {

                    cn.Open();

                    string st = "select * from NET WHERE id  = '" + textBox3.Text + "' ";


                    SqlDataAdapter adapt = new SqlDataAdapter(st, cn);
                    SqlCommand command = new SqlCommand();



                    command.CommandText = st;
                    command.Parameters.Clear();
                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView3.DataSource = table;



                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    cn.Close();

                } // to close the connection


            }

        }




        public void lb()
        {
            SqlConnection sqlc = new SqlConnection(conn);
            try
            {
                string str = "select netdate from NET";
                SqlCommand cmd = new SqlCommand(str, sqlc);
                cmd.CommandText = str;
                sqlc.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox1.Items.Add(drd["netdate"].ToString());

                    /*  comboBox1.ValueMember = drd["product_name"].ToString();
                      comboBox1.DisplayMember = drd["product_name"].ToString();
                     */
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }

            finally
            {
                sqlc.Close();
            }
        }




        private void button6_Click(object sender, EventArgs e)
        {
            login();
        }


        public void log()
        {
            SqlConnection sqlc = new SqlConnection(conn);
            try
            {
                string st = "SELECT type FROM logn";
                SqlCommand cmd1 = new SqlCommand(st, sqlc);
                cmd1.CommandText = st;
                sqlc.Open();
                SqlDataReader drd1 = cmd1.ExecuteReader();
                while (drd1.Read())
                {
                    comboBox2.Items.Add(drd1["type"].ToString());

                  
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }

            finally
            {
                sqlc.Close();
            }
        }
        public void login()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {


                try
                {


                    if (string.IsNullOrEmpty(textBox4.Text) ||
                                string.IsNullOrEmpty(textBox5.Text))
                    {
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show(" Enter your user name ");

                        }
                        else if (textBox5.Text == "")
                        {
                            MessageBox.Show(" Enter your password ");
                        }
                    }
                    else 
                    {

                        string un  = textBox4.Text;
                        string pass = textBox5.Text;

                        // Open the connection
                        connection.Open();


                        string quer = "  SELECT username ,password ,type FROM logn WHERE username = '" + un + "'  AND password =  '" + pass + "' ";

                        SqlCommand command;
                        command = new SqlCommand(quer, connection);
                        SqlDataReader reader = command.ExecuteReader();
                       

                      
           


                        if (reader.Read())
                        {
                            MessageBox.Show(" log in succesfully ");

                            if (reader[2].Equals("manager"))
                            {
                                MessageBox.Show("MANAGER");
                            }
                            else if (reader[2].Equals("cashier"))
                            {
                                MessageBox.Show("CASHIER");
                            }


                        }
                        else
                        {
                            MessageBox.Show(" user name or password incorect");
                        }      
                    }


                }
                catch (Exception)
                {

                    //MessageBox.Show(" user name or password incorect");
                    MessageBox.Show("error", "error", MessageBoxButtons.OK);




                }
                finally     // to close the connection
                {
                    connection.Close();

                } // to close the connection


            }// using connection

        }







    }

}