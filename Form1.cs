using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BETTINGGAME4
{
   

    public partial class Form1 : Form
    {
        List<int> mike = new List<int>();
        List<int> robert = new List<int>();
        List<int> donald = new List<int>();
        public Form1()
        {
            InitializeComponent();
            mike.Add(45);// This code will add the first amount allowed to all players i.e,  45
            robert.Add(45);
            donald.Add(45);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            /*Accountmanitain h = new Accountmanitain();
            Random rd = new Random();
            int rd1 = rd.Next(1, 4);
            MessageBox.Show("Congrats! Horse " + rd1 + " Wins ");
            // array to hold Mike betting details
            string[] MIKE = new string[10];
            string labler = label1.Text;
            MIKE = labler.Split(' ');
            // array to hold Robert betting details
            string[] ROBERT = new string[10];
            string roblabel = label2.Text;
            ROBERT = roblabel.Split(' ');
            // array to hold donald betting details
            string[] DONALD = new string[10];
            string donaldlabel = label3.Text;
            DONALD = donaldlabel.Split(' ');

            if (rd1 == Convert.ToInt32(MIKE[9]))
            {
                MessageBox.Show("MIKE WINS THE BET");
                int amountmike = Convert.ToInt32(ROBERT[6] + DONALD[6]);

                MessageBox.Show(" Amount credited on Mike side" + amountmike);
                int mikescore = Convert.ToInt32(ROBERT[6]) + Convert.ToInt32(DONALD[6]);
                int mikescore1 = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]) + Convert.ToInt32(DONALD[6]);
                MessageBox.Show("You are awarded with" + mikescore);
                h.MikeupdateData(mikescore1);
                int mscore = Convert.ToInt32(h.Selectdata(2));
                int mscore1 = mscore - Convert.ToInt32(ROBERT[6]);
                h.robertupdateData(mscore1);
                int jascore = Convert.ToInt32(h.Selectdata(3));
                int jascore1 = jascore - Convert.ToInt32(DONALD[6]);
                h.donaldupdateData(jascore1);
                radioButton2.Enabled = false;
                label2.Text = "You are busted";
                radioButton3.Enabled = false;
                label3.Text = "You are busted";
            }
            /*else if(rd1 != Convert.ToInt32(MIKE[9])) {
                /* int max = 45;
                 List<int> mikelist = new List<int>();
                 int value = max - Convert.ToInt32(MIKE[6]);
                 bool isempty = !mikelist.Any();
                 if (isempty)
                 {
                     mikelist.Add(value);
                 }
                 else
                 {
                     int anothervalue = Convert.ToInt32(mikelist.Last()) - Convert.ToInt32(MIKE[6]);
                     mikelist.Add(anothervalue);
                     if (Convert.ToInt32(mikelist.Last()) <= 0)
                     {

                     }
                 }
                radioButton1.Enabled = false;
                label1.Text = "You are busted";


            } 
               
                //This code is For Robert to check wins or lose the bet
               else if (rd1 == Convert.ToInt32(ROBERT[9]))
                {

                    MessageBox.Show("ROBERT WINS THE BET");
                    int amountrobert = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(DONALD[6]);

        MessageBox.Show(" Amount credited on Robert side" + amountrobert);
                int robertscore = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(DONALD[6]);
                int robertscore1 = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]) + Convert.ToInt32(DONALD[6]);
                MessageBox.Show("You are awarded with" + robertscore);
                h.robertupdateData(robertscore1);
                int mscore = Convert.ToInt32(h.Selectdata(1));
                int mscore1 = mscore - Convert.ToInt32(MIKE[6]);
                h.MikeupdateData(mscore1);
                int jascore = Convert.ToInt32(h.Selectdata(3));
                int jascore1 = jascore - Convert.ToInt32(DONALD[6]);
                h.donaldupdateData(jascore1);
                radioButton3.Enabled = false;
                label3.Text = "You are busted";
                radioButton1.Enabled = false;
                label1.Text = "You are busted";

            }
            /*else if(rd1 != Convert.ToInt32(ROBERT[9]))
         { /*int maxval = 45;
             List<int> robertlist = new List<int>();
             int robvalue = maxval - Convert.ToInt32(ROBERT[6]);
             bool isempty1 = !robertlist.Any();
             if (isempty1)
             {
                 robertlist.Add(robvalue);
             }
             else
             {
                 int anotherrobvalue = Convert.ToInt32(robertlist.Last()) - Convert.ToInt32(ROBERT[6]);
                 robertlist.Add(anotherrobvalue);
                 if (Convert.ToInt32(robertlist.Last()) <= 0)
                 {

                 }
             }
             radioButton2.Enabled = false;
             label2.Text = "You are busted";

         }

            //this code will check whether donald wins or lose
            else if (rd1 == Convert.ToInt32(DONALD[9]))
{
    MessageBox.Show("DONALD  WINS THE BET");
    int amountdonald = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]);

    MessageBox.Show(" Amount credited on Donald side" + amountdonald);
                int donaldscore = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]);
                int donaldscore1 = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]) + Convert.ToInt32(DONALD[6]);
                MessageBox.Show("You are awarded with" + donaldscore);
                h.donaldupdateData(donaldscore1);
                int mscore = Convert.ToInt32(h.Selectdata(2));
                int mscore1 = mscore - Convert.ToInt32(ROBERT[6]);
                h.robertupdateData(mscore1);
                int jascore = Convert.ToInt32(h.Selectdata(1));
                int jascore1 = jascore - Convert.ToInt32(MIKE[6]);
                h.MikeupdateData(jascore1);
                radioButton1.Enabled = false;
                label1.Text = "You are busted";
                radioButton2.Enabled = false;
                label2.Text = "You are busted";
            }
/*else if(rd1 == Convert.ToInt32(DONALD[9])) { /*int maxvaldonald = 45;
    List<int> donaldlist = new List<int>();
    int donaldvalue = maxvaldonald - Convert.ToInt32(DONALD[6]);
    bool isempty2 = !donaldlist.Any();
    if (isempty2)
    {
        donaldlist.Add(donaldvalue);
    }
    else
    {
        int anotherdonaldvalue = Convert.ToInt32(donaldlist.Last()) - Convert.ToInt32(DONALD[6]);
        donaldlist.Add(anotherdonaldvalue);
        if (Convert.ToInt32(donaldlist.Last()) <= 0)
        {
           
        }
    }
                radioButton3.Enabled = false;
                label3.Text = "You are busted";
            }*/


            


        








        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { 
                //this label show the mike details
                label1.Text = "MIKE BET AN AMOUNT OF $ " + this.comboBox1.SelectedItem.ToString() + " on Horse " + this.comboBox2.SelectedItem.ToString();
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "ROBERT BET AN AMOUNT OF $ " + this.comboBox1.SelectedItem.ToString() + " on Horse " + this.comboBox2.SelectedItem.ToString();

            }
            else if (radioButton3.Checked)
            {
                label3.Text = "DONALD BET AN AMOUNT OF $ " + this.comboBox1.SelectedItem.ToString() + " on Horse " + this.comboBox2.SelectedItem.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            if (mike.Count > 1)
            {
                mike.RemoveRange(1, mike.Count - 1);
                MessageBox.Show("mikelist"+mike[0]);
            }
            if (robert.Count > 1)
            {
                robert.RemoveRange(1, robert.Count - 1);
                MessageBox.Show("robert" + mike[0]);
            }
            if (donald.Count > 1)
            {
                donald.RemoveRange(1, donald.Count - 1);
                MessageBox.Show("donaldlist" + donald[0]);
            }

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Accountmanitain myobj = new Accountmanitain();
            int b = myobj.Randomnumber();
            MessageBox.Show("Congratulations ! \n Horse " + b + " Wins The Race");
            // array to hold Mike betting details
            string[] MIKE = new string[10];
            string labler = label1.Text;
            MIKE = labler.Split(' ');
            // array to hold Robert betting details
            string[] ROBERT = new string[10];
            string roblabel = label2.Text;
            ROBERT = roblabel.Split(' ');
            // array to hold donald betting details
            string[] DONALD = new string[10];
            string donaldlabel = label3.Text;
            DONALD = donaldlabel.Split(' ');


            if (b == Convert.ToInt32(MIKE[9]))
            {
                MessageBox.Show("Congratulations Mike wins the race");

                if (mike.Count > 0)
                {
                    int result = Convert.ToInt32(ROBERT[6]) + Convert.ToInt32(DONALD[6]);
                    int mikeamount = Convert.ToInt32(mike[mike.Count - 1]);
                    int totalresult = mikeamount + result;
                    MessageBox.Show("Amount credited to Mike" + result);
                    MessageBox.Show("Total Amount" + totalresult);
                    mike.Add(totalresult);
                }
                int robreduction = Convert.ToInt32(robert.Last()) - Convert.ToInt32(ROBERT[6]);
                MessageBox.Show("Amount deducted from Tom account" + Convert.ToInt32(ROBERT[6]));
                MessageBox.Show("Amount remains in Rob account" + robreduction);
                robert.Add(robreduction);
                int donaldreduction = Convert.ToInt32(donald.Last()) - Convert.ToInt32(DONALD[6]);
                MessageBox.Show("Amount deducted from DONALD account" + Convert.ToInt32(DONALD[6]));
                MessageBox.Show("Amount remains in donald account" + donaldreduction);
                donald.Add(donaldreduction);
                // code to check player 2 is a winner
                if (Convert.ToInt32(robert.Last()) <= 0)
                {
                    radioButton2.Enabled = false;
                    label2.Text = "you are busted";


                }
                if (Convert.ToInt32(donald.Last()) <= 0)
                {
                    radioButton3.Enabled = false;
                    label3.Text = "You are busted";

                }
            }
            // code to find robert is a winner
            if (b == Convert.ToInt32(ROBERT[9]))
            {
                MessageBox.Show("Congratulations Robert wins the race");

                if (robert.Count > 0)
                {
                    int result = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(DONALD[6]);
                    int robertamount = Convert.ToInt32(robert[robert.Count - 1]);
                    int totalresult =robertamount + result;
                    MessageBox.Show("Amount credited to robert account" + result);
                    MessageBox.Show("Total Amount" + totalresult);
                    robert.Add(totalresult);
                }
                int mikereduction = Convert.ToInt32(mike.Last()) - Convert.ToInt32(MIKE[6]);
                MessageBox.Show("Amount deducted from Mike account" + Convert.ToInt32(MIKE[6]));
                MessageBox.Show("Amount remains in Mike account" + mikereduction);
                mike.Add(mikereduction);
                int donaldreduction = Convert.ToInt32(donald.Last()) - Convert.ToInt32(DONALD[6]);
                MessageBox.Show("Amount deducted from DONALD account" + Convert.ToInt32(DONALD[6]));
                MessageBox.Show("Amount remains in donald account" + donaldreduction);
                donald.Add(donaldreduction);
                int robreduction = Convert.ToInt32(robert.Last()) - Convert.ToInt32(ROBERT[6]);
                MessageBox.Show("Amount deducted from Tom account" + Convert.ToInt32(ROBERT[6]));
                MessageBox.Show("Amount remains in Rob account" + robreduction);
                robert.Add(robreduction);

                if (Convert.ToInt32(mike.Last()) <= 0)
                {
                    radioButton1.Enabled = false;
                    label1.Text = "you are busted";


                }
                if (Convert.ToInt32(donald.Last()) <= 0)
                {
                    radioButton3.Enabled = false;
                    label3.Text = "You are busted";

                }
            }





            // if statement to check tom is a winner or not

            if (b == Convert.ToInt32(DONALD[9]))
            {
                MessageBox.Show("Congratulations Donald wins the race");
                int donaldresult = Convert.ToInt32(MIKE[6]) + Convert.ToInt32(ROBERT[6]);//


                if (donald.Count > 0)
                {
                    int donaldamount = Convert.ToInt32(donald[donald.Count - 1]);
                    int result1 = donaldamount + donaldresult;
                    MessageBox.Show("Amount credited to Donald side" + donaldresult);
                    MessageBox.Show("Total Amount" + result1);
                    donald.Add(result1);
                }
                int mikereduction = Convert.ToInt32(mike.Last()) - Convert.ToInt32(MIKE[6]);
                MessageBox.Show("Amount deducted from Mike account" + Convert.ToInt32(MIKE[6]));
                MessageBox.Show("Amount remains in Mike account" + mikereduction);
                mike.Add(mikereduction);


                int robreduction = Convert.ToInt32(robert.Last()) - Convert.ToInt32(ROBERT[6]);
                MessageBox.Show("Amount deducted from Tom account" + Convert.ToInt32(ROBERT[6]));
                MessageBox.Show("Amount remains in Rob account" + robreduction);
                robert.Add(robreduction);
                if (Convert.ToInt32(mike.Last()) <= 0)
                {
                    radioButton1.Enabled = false;
                    label1.Text = "you are busted";


                }
                if (Convert.ToInt32(robert.Last()) <= 0)
                {
                    radioButton2.Enabled = false;
                    label2.Text = "you are busted";


                }
            }


            }

            private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pictureBox8.Left + 5) < (this.Width - pictureBox8.Width) & pictureBox9.Left + 5 < (this.Width - pictureBox9.Width) & (pictureBox10.Left + 5) < (this.Width - pictureBox10.Width) & (pictureBox11.Left + 5) < (this.Width - pictureBox11.Width))
            {
                pictureBox8.Left += 9;
                pictureBox9.Left += 6;
                pictureBox10.Left += 7;
                pictureBox11.Left += 8;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
public class Accountmanitain
{
    public int Randomnumber()
        {
            Random r = new Random();
            int x = r.Next(1, 5);
            return x;
        }

    public string Selectdata(int value)
    {
        string connection = "server=localhost;username=root;password=;database=betting4";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        //MessageBox.Show("database connected");
        string selectquery = "SELECT Amount FROM horsebettable WHERE id='" + value + "' ";
        MySqlCommand command = new MySqlCommand(selectquery, conn);
        MySqlDataReader reader = command.ExecuteReader();
        int amt = 0;
        string strresult = string.Empty;
        while (reader.Read())
        {
            strresult += reader.GetString(0);
        }
        string[] strArray = strresult.Split(' ');
        //MessageBox.Show("The value is" + strArray[0]);
        return strArray[0];

        /*string name = "Tom";
        string updatequery = "update bettinggametable set Amount = '" + Convert.ToInt32(amount) + "' where Name ='" + name + "' ";
        MySqlCommand command = new MySqlCommand(updatequery, conn);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        //MessageBox.Show("Data updated successfully");
        conn.Close();*/


    }
    public void MikeupdateData(int value)
    {
        string connection = "server=localhost;username=root;password=;database=betting4";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        //MessageBox.Show("database connected");
        string selectquery = "update horsebettable set Amount='" + value + "' WHERE id='" + 1 + "' ";
        MySqlCommand command = new MySqlCommand(selectquery, conn);
        MySqlDataReader reader = command.ExecuteReader();
        //MessageBox.Show("Database updated successfully");

    }
    public void robertupdateData(int value)
    {
        string connection = "server=localhost;username=root;password=;database=betting4";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        // MessageBox.Show("database connected");
        string selectquery = "update horsebettable set Amount='" + value + "' WHERE id='" + 2 + "' ";
        MySqlCommand command = new MySqlCommand(selectquery, conn);
        MySqlDataReader reader = command.ExecuteReader();
        //MessageBox.Show("Database updated successfully");

    }
    public void donaldupdateData(int value)
    {
        string connection = "server=localhost;username=root;password=;database=betting4";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        //MessageBox.Show("database connected");
        string selectquery = "update horsebettable set Amount='" + value + "' WHERE id='" + 3 + "' ";
        MySqlCommand command = new MySqlCommand(selectquery, conn);
        MySqlDataReader reader = command.ExecuteReader();
        //MessageBox.Show("Database updated successfully");

    }
    public void otherupdate()//THIS FUNCTION WILL RESET ALL THE AMOUNT TO PREVIOUS ONES
    {
        string connection = "server=localhost;username=root;password=;database=betting4";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        //MessageBox.Show("database connected");
        string selectquery = "UPDATE horsebettable SET Amount='" + 45 + "'  ";
        //string selectquery1 = "UPDATE bikebettinggame set Amount='" + 45 + "' WHERE id='" + 2 + "' ";
        //string selectquery2 = "update bikebettinggame set Amount='" + 45 + "'  WHERE id='" + 3 + "' ";

        MySqlCommand command = new MySqlCommand(selectquery, conn);
        //MySqlCommand command1 = new MySqlCommand(selectquery1, conn);
        //MySqlCommand command2 = new MySqlCommand(selectquery2, conn);

        MySqlDataReader reader1 = command.ExecuteReader();
        //MySqlDataReader reader2 = command1.ExecuteReader();
        // MySqlDataReader reader3 = command2.ExecuteReader();
        //MessageBox.Show("Database updated successfully");

    }




}
