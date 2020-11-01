using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 1;
        int time = 0, startTime = 0;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 0;
            time = 15;
            startTime = 15;
            foreach (Button rb in panel1.Controls.OfType<Button>())
            {
                rb.BackColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            Random rnd = new Random();
            int rand = 0;
            int[] arr = new int[25];
            for (int i = 0; i < arr.Length; i++)
            {
                rand = rnd.Next(1, 26);
                arr[i] = rand;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        i--;
                        break;
                    }
                }
            }

            foreach (Button rb in panel1.Controls.OfType<Button>())
            {
                rb.Text = arr[q].ToString();
                q++;
            }
            if (trackBar1.Value == 0)
            {
                time = 15;
                startTime = 15;
            }
            else if (trackBar1.Value == 1)
            {
                time = 30;
                startTime = 30;
            }
            else if (trackBar1.Value == 2)
            {
                time = 45;
                startTime = 45;
            }
            else if (trackBar1.Value == 3)
            {
                time = 60;
                startTime = 60;
            }
            toolStripStatusLabel2.Text = time.ToString();
            timer1.Start();
            trackBar1.Enabled = false;
            button1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                time = 15;
                startTime = 15;
            }
            else if (trackBar1.Value == 1)
            {
                time = 30;
                startTime = 30;
            }
            else if (trackBar1.Value == 2)
            {
                time = 45;
                startTime = 45;
            }
            else if (trackBar1.Value == 3)
            {
                time = 60;
                startTime = 60;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                toolStripStatusLabel2.Text = "0";
                timer1.Stop();
                MessageBox.Show("You lose!");
                trackBar1.Enabled = true;
                button1.Enabled = true;
                count = 1;
                foreach (Button rb in panel1.Controls.OfType<Button>())
                {
                    rb.BackColor = Color.Gray;
                }
                toolStripProgressBar1.Value = 0;

            }
            toolStripStatusLabel2.Text = (time--).ToString();
        }

        private void Win()
        {
            timer1.Stop();
            MessageBox.Show("xarow; Time: " + ((startTime - time) - 1) + ";");
            trackBar1.Enabled = true;
            button1.Enabled = true;
            count = 1;
            foreach (Button rb in panel1.Controls.OfType<Button>())
            {
                rb.BackColor = Color.Gray;
            }
            toolStripProgressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == count.ToString())
            {
                button2.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if(count == 26)
                {
                    Win();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == count.ToString())
            {
                button3.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == count.ToString())
            {
                button4.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == count.ToString())
            {
                button5.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == count.ToString())
            {
                button6.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == count.ToString())
            {
                button7.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == count.ToString())
            {
                button8.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == count.ToString())
            {
                button9.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == count.ToString())
            {
                button10.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == count.ToString())
            {
                button11.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == count.ToString())
            {
                button12.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == count.ToString())
            {
                button13.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == count.ToString())
            {
                button14.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == count.ToString())
            {
                button15.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == count.ToString())
            {
                button16.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == count.ToString())
            {
                button17.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Text == count.ToString())
            {
                button18.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.Text == count.ToString())
            {
                button19.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Text == count.ToString())
            {
                button20.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.Text == count.ToString())
            {
                button21.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.Text == count.ToString())
            {
                button22.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.Text == count.ToString())
            {
                button23.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Text == count.ToString())
            {
                button24.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Text == count.ToString())
            {
                button25.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Text == count.ToString())
            {
                button26.BackColor = Color.Green;
                count++;
                toolStripProgressBar1.Value += 4;
                if (count == 26)
                {
                    Win();
                }
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
