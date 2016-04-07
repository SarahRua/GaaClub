﻿using System;
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
    // this is the code for the front end form
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
            // if all boxes have been filled in (except id, which will be autogenerated),
            // then the next step is allowed.
            if ((tbName.Text != "") && (tbAge.Text != "") && (tbHeight.Text != "") && (tbDist.Text != "") && (tbSpeed.Text != ""))
            {
                // an instance of inputvalidator is set up
                InputValidator v = new InputValidator();
                // default values are set at the beginning
                int age =-10;
                int height =-10;
                double speed =-10;
                int dist =-10;
                
                // this error message will appear beside any invalid data
                string error = "Invalid";

                // check a value is still entered in name
                if (tbName.Text == "")
                {
                    NameError.Text = error;
                }

                    // check input with validator before entering data into table
                    bool vA = v.validateAge(tbAge.Text);
                if (vA == false)
                {
                    // if the Age input is invalid, then a message is shown beside it
                    // so the user knows which field they need to amend
                    AgeError.Text = error;
                }
                else if (vA == true)
                {
                    // once the user enters a valid Age, the error message is removed
                    // and the age value is assigned
                    AgeError.Text = "";
                    age = v.a;
                }
                // the same process is carried out for height, distance and speed
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
                // once all the values are valid, the data can be added to the database
                if ((vA == true) &&( vH == true) && (vD == true) && (vS == true) && (tbName.Text != ""))
                {
                    // the error values on screen are removed
                    AgeError.Text = "";
                    HeightError.Text = "";
                    DistError.Text = "";
                    SpeedError.Text = "";
                    
                    // call modify database
                    ModifyDatabase modify = new ModifyDatabase();
                    // call addPlayer to connect to database and insert record
                    modify.addPlayer(tbName.Text, age, height, dist, speed);
                    // show a message box to tell the user their input has succeeded
                    MessageBox.Show("Player Added", "Standen GAA Technology");
                    // remove all the entries so the default view is seen
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
                    // if one or more of the values is invalid, this message box will show.
                    MessageBox.Show("Player Not Added. Enter valid data", "Standen GAA Technology");
                }
                }
            }

        // a similar process is carried out for update player and remove player
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

                // check a value is still entered in name
                if (tbName.Text == "")
                {
                    NameError.Text = error;
                }
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
                    modify.updatePlayer(int.Parse(tbID.Text), tbName.Text, age, height, dist, speed);

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
        // when the summary button is clicked, a refeshed view of stats is seen
        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            // the previous view is cleared
            listBox1.Items.Clear();
            // create an instance of Stats
            Stats stat = new Stats(conn);
            // retrieve all values and enter them into the listbox
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
            modify.removePlayer(int.Parse(tbID.Text));

            MessageBox.Show("Player Deleted", "Standen GAA Technology");
            tbID.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            tbHeight.Text = "";
            tbDist.Text = "";
            tbSpeed.Text = "";
            loadData();
        }


        // loadData is called when the form is opened
        private void loadData()
        {
            // the view of the database data in the grid view is removed
            dgvGaa.Rows.Clear();
            // connection is opened
            conn.Open();
            // all data is retrieved
            cmd = new SqlCommand("select * from Player", conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                // while there are more rows to read, the values are added to the data grid view
                while (dr.Read())
                {
                    dgvGaa.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString());
                }
            }
            // the connection is closed
            conn.Close();
            // all error messages are cleared
            NameError.Text = "";
            AgeError.Text = "";
            HeightError.Text = "";
            DistError.Text = "";
            SpeedError.Text = "";

        }

        private void dgvGaa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // when a different cell is selected on the datagridview, the view should update
        private void dgvGaa_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            // x is the row of the current cell selected
            int x = dgv.CurrentCell.RowIndex;

            // exception around selecting a row which hasn't been filled
            try
            {
                // as long as a row with data is selected,
                // the text values of the input boxes will reflect
                // the selected row values
                if (x != -1)
                {
                    DataGridViewRow row = dgv.Rows[x];
                    tbID.Text = row.Cells[0].Value.ToString();
                    tbName.Text = row.Cells[1].Value.ToString();
                    tbAge.Text = row.Cells[2].Value.ToString();
                    tbHeight.Text = row.Cells[3].Value.ToString();
                    tbDist.Text = row.Cells[4].Value.ToString();
                    tbSpeed.Text = row.Cells[5].Value.ToString();                  
                }
            }
            // if a row without values is selected, all the inputs
            // will be blanked out.
            catch
            {
                tbID.Text = "";
                tbName.Text = "";
                tbAge.Text = "";
                tbHeight.Text = "";
                tbDist.Text = "";
                tbSpeed.Text = "";
            }
        }
        // clear button
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
