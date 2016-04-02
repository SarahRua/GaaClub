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

namespace GAAClubFront
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=PETER-PC;Initial Catalog=GAAClub;Integrated Security=False;User Id=sa;Password=Pa55w0rd1234;MultipleActiveResultSets=True");
            loadData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbName.Text != "") && (tbAge.Text != "") && (tbHeight.Text != "") && (tbDist.Text != "") && (tbSpeed.Text != ""))
            {
                conn.Open();
                cmd = new SqlCommand(@"Insert into Player 
                (PlayerName, PlayerAge, PlayerHeight, RunningDistance, PlayerSpeed)
                values ('"+ tbName.Text + " ',' " + tbAge.Text + "','" + tbHeight.Text + "','" + tbDist.Text + "','" + tbSpeed.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Player Added", "Standen GAA Technology");
                
                tbID.Text = "";
                tbName.Text = "";
                tbAge.Text = "";
                tbHeight.Text = "";
                tbDist.Text = "";
                tbSpeed.Text = "";
                loadData();
            }
        }
        
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if ((tbID.Text != "") && (tbName.Text != "") && (tbAge.Text != "") && (tbHeight.Text != "") && (tbDist.Text != "") && (tbSpeed.Text != ""))
            {
                conn.Open();
                cmd = new SqlCommand(@"Update Player 
                set PlayerName = '" + tbName.Text + "', PlayerAge = '" + tbAge.Text + "', PlayerHeight = '" + tbHeight.Text + "', RunningDistance='" + tbDist.Text + "', PlayerSpeed='" + tbSpeed.Text + "' where (PlayerID ='" + tbID.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Player Updated", "Standen GAA Technology");
                tbID.Text = "";
                tbName.Text = "";
                tbAge.Text = "";
                tbHeight.Text = "";
                tbDist.Text = "";
                tbSpeed.Text = "";
                loadData();
            }
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // create an instance of Stats
            Stats stat = new Stats(conn);
            listBox1.Items.Add("Mean Age: " + stat.getMeanAge());
            listBox1.Items.Add("Max Age: " + stat.getMaxAge());
            listBox1.Items.Add("Min Age: " + stat.getMinAge());
            listBox1.Items.Add("Mean Run: " + stat.getMeanDist());
            listBox1.Items.Add("Max Run: " + stat.getMaxDist());
            listBox1.Items.Add("Min Run: " + stat.getMinDist());
            listBox1.Items.Add("Mean Height: " + stat.getMeanHeight());
            listBox1.Items.Add("Max Height: " + stat.getMaxHeight());
            listBox1.Items.Add("Min Height: " + stat.getMinHeight());
            listBox1.Items.Add("Mean Speed: " + stat.getMeanSpeed());
            listBox1.Items.Add("Max Speed: " + stat.getMaxSpeed());
            listBox1.Items.Add("Min Speed: " + stat.getMinSpeed());

        }
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand(@"Delete from Player 
                where(PlayerID = '" +tbID.Text+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Player Deleted", "Standen GAA Technology");
            tbID.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            tbHeight.Text = "";
            tbDist.Text = "";
            tbSpeed.Text = "";
            loadData();
        }



        private void loadData()
        {
            dgvGaa.Rows.Clear();
            conn.Open();
            
            cmd = new SqlCommand("select * from Player",conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvGaa.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString());
                }
            }
            conn.Close();
            
        }
        private void dgvGaa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGaa_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int x = dgv.CurrentCell.RowIndex;
            if (x != -1)
            {
                //dgv.Rows(x).Selected = True;
                DataGridViewRow row = dgv.Rows[x];
                tbID.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbAge.Text = row.Cells[2].Value.ToString();
                tbHeight.Text = row.Cells[3].Value.ToString();
                tbDist.Text = row.Cells[4].Value.ToString();
                tbSpeed.Text = row.Cells[5].Value.ToString();

                // add exception around selecting a row which hasn't been filled
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            tbHeight.Text = "";
            tbDist.Text = "";
            tbSpeed.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
