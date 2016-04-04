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


        // add user
        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbName.Text != "") && (tbAge.Text != "") && (tbHeight.Text != "") && (tbDist.Text != "") && (tbSpeed.Text != ""))
            {
                InputValidator v = new InputValidator();
                int age =-10;
                int height =-10;
                double speed =-10;
                int dist =-10;
                // check input with validator before entering data into table

                string error = "Invalid";


                bool vA = v.validateAge(tbAge.Text);
                if (vA == false)
                {

                    AgeError.Text = error;
                }
                else if (vA == true)
                {
                    AgeError.Text = "";
                    age = v.a;
                }
                bool vH = v.validateHeight(tbHeight.Text);
                if (vH == false)
                {
                    HeightError.Text = error;
                }
                else  if (vH ==true)
                {
                    HeightError.Text = "";
                    height = v.h;
                }
                bool vD = v.validateDist(tbDist.Text);
                if (vD == false)
                {
                    DistError.Text = error;
                }
                else if (vD ==true)
                {
                    DistError.Text = "";
                    dist = v.d;
                }
                bool vS = v.validateSpeed(tbSpeed.Text);
                if (vS == false)
                {
                    SpeedError.Text = error;
                }
                else if (vS == true)
                {
                    SpeedError.Text = "";
                    speed = v.s;
                }
                if ((vA == true) &&( vH == true) && (vD == true) && (vS == true) && (tbName.Text != ""))
                {
                    AgeError.Text = "";
                    HeightError.Text = "";
                    DistError.Text = "";
                    SpeedError.Text = "";

                    // call modify database
                    ModifyDatabase modify = new ModifyDatabase();
                    modify.addPlayer(tbName.Text, age, height, dist, speed);

                    MessageBox.Show("Player Added", "Standen GAA Technology");

                    tbID.Text = "";
                    tbName.Text = "";
                    tbAge.Text = "";
                    tbHeight.Text = "";
                    tbDist.Text = "";
                    tbSpeed.Text = "";
                    loadData();
                }
                else
                {
                    MessageBox.Show("Player Not Added. Enter valid data", "Standen GAA Technology");
                }
                }
            }
        // update player
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if ((tbName.Text != "") && (tbAge.Text != "") && (tbHeight.Text != "") && (tbDist.Text != "") && (tbSpeed.Text != ""))
            {
                InputValidator v = new InputValidator();
                int age = -10;
                int height = -10;
                double speed = -10;
                int dist = -10;
                // check input with validator before entering data into table

                string error = "Invalid";


                bool vA = v.validateAge(tbAge.Text);
                if (vA == false)
                {

                    AgeError.Text = error;
                }
                else if (vA == true)
                {
                    AgeError.Text = "";
                    age = v.a;
                }
                bool vH = v.validateHeight(tbHeight.Text);
                if (vH == false)
                {
                    HeightError.Text = error;
                }
                else if (vH == true)
                {
                    HeightError.Text = "";
                    height = v.h;
                }
                bool vD = v.validateDist(tbDist.Text);
                if (vD == false)
                {
                    DistError.Text = error;
                }
                else if (vD == true)
                {
                    DistError.Text = "";
                    dist = v.d;
                }
                bool vS = v.validateSpeed(tbSpeed.Text);
                if (vS == false)
                {
                    SpeedError.Text = error;
                }
                else if (vS == true)
                {
                    SpeedError.Text = "";
                    speed = v.s;
                }
                if ((vA == true) && (vH == true) && (vD == true) && (vS == true) && (tbName.Text != ""))
                {
                    //call update method in modify database
                    ModifyDatabase modify = new ModifyDatabase();
                    modify.updatePlayer(tbID.Text, tbName.Text, age, height, dist, speed);

                    MessageBox.Show("Player Updated", "Standen GAA Technology");
                tbID.Text = "";
                tbName.Text = "";
                tbAge.Text = "";
                tbHeight.Text = "";
                tbDist.Text = "";
                tbSpeed.Text = "";
                loadData();
                }
                else
                {
                    MessageBox.Show("Player Not Updated. Enter valid data", "Standen GAA Technology");
                }
            }
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // create an instance of Stats
            Stats stat = new Stats(conn);
            listBox1.Items.Add("Mean Age:   \t" + stat.getMeanAge());
            listBox1.Items.Add("Max Age:    \t" + stat.getMaxAge());
            listBox1.Items.Add("Min Age:    \t" + stat.getMinAge());
            listBox1.Items.Add("Mean Run:   \t" + stat.getMeanDist());
            listBox1.Items.Add("Max Run:    \t" + stat.getMaxDist());
            listBox1.Items.Add("Min Run:    \t" + stat.getMinDist());
            listBox1.Items.Add("Mean Height:\t" + stat.getMeanHeight());
            listBox1.Items.Add("Max Height: \t" + stat.getMaxHeight());
            listBox1.Items.Add("Min Height: \t" + stat.getMinHeight());
            listBox1.Items.Add("Mean Speed: \t" + stat.getMeanSpeed());
            listBox1.Items.Add("Max Speed:  \t" + stat.getMaxSpeed());
            listBox1.Items.Add("Min Speed:  \t" + stat.getMinSpeed());

        }
        //remove player
        private void button3_Click(object sender, EventArgs e)
        {
            //call remove method in modify database
            ModifyDatabase modify = new ModifyDatabase();
            modify.removePlayer(tbID.Text);

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

            cmd = new SqlCommand("select * from Player", conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvGaa.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString());
                }
            }
            conn.Close();
            NameError.Text = "";
            AgeError.Text = "";
            HeightError.Text = "";
            DistError.Text = "";
            SpeedError.Text = "";
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
