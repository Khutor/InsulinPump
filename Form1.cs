using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tyler Clark
//Alexander Marquette

namespace InsulinPump
{
    public partial class Form1 : Form
    {
        //Global vars
        public String mode;
        public int reading;
        public int insulin = 100;
        public int battery = 100;

        //Form1 constructor
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            timer1.Start();
            timer2.Start();
            supplyMsg.Text = "";
        }


        //Handles on load
        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            this.chart1.Series["Reading"].Points.Add(0);
            battLvl.Maximum = 100;
            battLvl.Minimum = 0;
            battLvlTxt.Text = battLvl.Value.ToString() + "%";
        }

        //Handles time
        void timer1_Tick(object sender, EventArgs e)
        {
            timeTxt.Text = DateTime.Now.ToString();
        }

        //Handles battery
        private void timer2_Tick(object sender, EventArgs e)
        {
            battLvl.Value = battery;
            if (battery != 0)
            {
                battery--;
                battLvl.Value--;
                battLvlTxt.Text = battery + "%";
                //"System shutdown" commences (for purposes battery will go back to 100 and such)
                if(battery == 0)
                {
                    MessageBox.Show("BATTERY DEPLETED AND SYSTEM WILL SHUTDOWN; CHARGE/REPLACE NOW", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    battery = 100;
                    battLvl.Value = 100;
                    battLvlTxt.Text = battery + "%";
                } else if(battery == 5)
                {
                    MessageBox.Show("BATTERY LEVEL LOW; CONSIDER CHARGING/REPLACING BATTERY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Handles mode selection
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            msgLabel.Text = "";
            mode = comboBox1.SelectedItem.ToString();
            if (mode == "Automatic")
            {
                readingBtn.Enabled = true;
            } else if(mode == "Manual")
            {
                readingBtn.Enabled = true;
            } else
            {
                manInsulinBtn.Enabled = false;
                readingBtn.Enabled = false;
            }
        }

        //Handles getting user's reading
        private void readingBtn_Click(object sender, EventArgs e)
        {

            msgLabel.Text = "";
            msgLabel.BackColor = Color.Transparent;
            Random rand = new Random();
            reading = rand.Next(50, 280);
            readingTxt.Text = reading.ToString();
            this.chart1.Series["Reading"].Points.Add(reading);
            listView1.Items.Add("Date: " + DateTime.Now.ToString() + " | Reading: " + reading.ToString());

            if(insulin <= 100 && insulin >= 50)
            {
                msgLabel.BackColor = Color.Green;
            }
            else if (insulin < 50 && insulin >= 30)
            {
                circularProgressBar1.ProgressColor = Color.Yellow;
            }
            else if (insulin < 30)
            {
                circularProgressBar1.ProgressColor = Color.Red;
            }

            //Checks to see if reading is below or above 200
            if (reading < 100)
            {
                manInsulinBtn.Enabled = false;
                msgLabel.BackColor = Color.Red;
                msgLabel.Text = "CONSIDER EATING";
                System.Media.SystemSounds.Beep.Play();
            } else if(reading > 200 && mode == "Manual")
            {
                manInsulinBtn.Enabled = true;
                msgLabel.BackColor = Color.Red;
                msgLabel.Text = "INSULIN RECOMMENDED";
                System.Media.SystemSounds.Beep.Play();
            }



            //Checks to see if reading is over 200, requiring insulin administration
            if (mode == "Automatic" && reading > 200)
            {
                insulin -= 10;
                circularProgressBar1.Value = insulin;
                circularProgressBar1.Text = insulin + "%";
                msgLabel.Text = "INSULIN ADMINISTERED";

                if (insulin < 50 && insulin >= 30)
                {
                    circularProgressBar1.ProgressColor = Color.Yellow;
                }
                else if (insulin < 30)
                {
                    circularProgressBar1.ProgressColor = Color.Red;
                }


                if (insulin == 0)
                {
                    MessageBox.Show("Insulin reservoir is empty! Refill as soon as possible!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetInsulin();
                }

            } else if(mode == "Manual" && reading > 200) {
                readingBtn.Enabled = false;
                if (insulin < 50 && insulin >= 30)
                {
                    circularProgressBar1.ProgressColor = Color.Yellow;
                }
                else if (insulin < 30)
                {
                    circularProgressBar1.ProgressColor = Color.Red;
                }
            }

            if(insulin <= 30)
            {
                supplyMsg.Text = "INSULIN SUPPLY LOW";
            }
        }

        //Handles when the manual insulin delivery is clicked
        private void manInsulinBtn_Click(object sender, EventArgs e)
        {
            if (readingTxt.Text != "N/A")
            {
                if(reading >= 100)
                {
                    insulin -= 10;
                    circularProgressBar1.Value = insulin;
                    circularProgressBar1.Text = insulin + "%";
                    msgLabel.BackColor = Color.Green;
                    msgLabel.Text = "INSULIN ADMINISTERED";
                    readingBtn.Enabled = true;
                    manInsulinBtn.Enabled = false;
                } else if(reading < 100)
                {
                    MessageBox.Show("Insulin is not deliverabled when reading is less than 100; consider eating to raise blood sugar", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (insulin < 50 && insulin >= 30)
                {
                    circularProgressBar1.ProgressColor = Color.Yellow;
                }
                else if (insulin < 30)
                {
                    circularProgressBar1.ProgressColor = Color.Red;
                }
            }
        }

        //Quits application
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Opens the test window
        private void testWindBtn_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        //Resets everything but battery, insulin and logs
        public void reset()
        {
            msgLabel.Text = "";
            circularProgressBar1.Value = 100;
            circularProgressBar1.Text = 100 + "%";
            circularProgressBar1.ProgressColor = Color.Green;
            insulin = 100;
            readingTxt.Text = "N/A";
            comboBox1.SelectedIndex = 0;
            MessageBox.Show("Device has been restarted. System logs have been kept intact", "Restarted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Resets insulin
        public void resetInsulin()
        {
            insulin = 100;
            supplyMsg.Text = "";
            circularProgressBar1.Value = insulin;
            circularProgressBar1.Text = insulin + "%";
            circularProgressBar1.ProgressColor = Color.Green;
            MessageBox.Show("Thank you for fixing/replacing the insulin reservoir", "Insulin Replenished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Resets everything, including logs without saving them to file
        public void resetAll()
        {
            battLvl.Value = 100;
            battLvlTxt.Text = 100 + "%";
            battery = 100;
            msgLabel.Text = "";
            circularProgressBar1.Value = 100;
            circularProgressBar1.Text = 100 + "%";
            circularProgressBar1.ProgressColor = Color.Green;
            insulin = 100;
            readingTxt.Text = "N/A";
            comboBox1.SelectedIndex = 0;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            listView1.Items.Clear();
            MessageBox.Show("Device has been restarted and all information has been reset", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    public class Main
    {
    }
}
