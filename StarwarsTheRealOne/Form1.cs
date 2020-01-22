using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarwarsTheRealOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int team = 0, unitATKID, unitDFSID, HP1 = 200, HP2 = 90, HP3 = 50, HP4 = 20, HP5 = 60, HP6 = 200, HP7 = 90, HP8 = 50, HP9 = 20, HP10 = 60, ATK1 = 30, ATK2 = 45, ATK3 = 50, ATK4 = 60, ATK5 = 25, ATK6 = 30, ATK7 = 45, ATK8 = 50, ATK9 = 60, ATK10 = 25;

        private void button13_Click(object sender, EventArgs e)
        {
            unitATK();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (team == 1)
            {
                unitATKID = 10;
            }
            if (team == 0)
            {
                unitDFSID = 10;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (team == 1)
            {
                unitATKID = 9;
            }
            if (team == 0)
            {
                unitDFSID = 9;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (team == 1)
            {
                unitATKID = 8;
            }
            if (team == 0)
            {
                unitDFSID = 8;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (team == 1)
            {
                unitATKID = 7;
            }
            if (team == 0)
            {
                unitDFSID = 7;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (team == 1)
            {
                unitATKID = 6;
            }
            if (team == 0)
            {
                unitDFSID = 6;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (team == 0)
            {
                unitATKID = 5;
            }
            if (team == 1)
            {
                unitDFSID = 5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (team == 0)
            {
                unitATKID = 4;
            }
            if (team == 1)
            {
                unitDFSID = 4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (team == 0)
            {
                unitATKID = 3;
            }
            if (team == 1)
            {
                unitDFSID = 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (team == 0)
            {
                unitATKID = 2;
            }
            if (team == 1)
            {
                unitDFSID = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (team == 0)
            {
                unitATKID = 1;
            }
            if (team == 1)
            {
                unitDFSID = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Blue;
            button11.BackColor = Color.Red;
            team = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button11.BackColor = Color.Blue;
            team = 0;
        }

        public void unitATK()
        {
            if (unitATKID == 1 && unitDFSID == 6 && HP1 > 0 && HP6 > 0)
            {
                HP6 = HP6 - ATK1;
            }
            if (unitATKID == 1 && unitDFSID == 7 && HP1 > 0 && HP7 > 0)
            {
                HP7 = HP7 - ATK1;
            }
            if (unitATKID == 1 && unitDFSID == 8 && HP1 > 0 && HP8 > 0)
            {
                HP8 = HP8 - ATK1;
            }
            if (unitATKID == 1 && unitDFSID == 9 && HP1 > 0 && HP9 > 0)
            {
                HP9 = HP9 - ATK1;
            }
            if (unitATKID == 1 && unitDFSID == 10 && HP1 > 0 && HP10 > 0)
            {
                HP10 = HP10 - ATK1;
            }
            //Unit 2 atk
            if (unitATKID == 2 && unitDFSID == 6 && HP2 > 0 && HP6 > 0)
            {
                HP6 = HP6 - ATK2;
            }
            if (unitATKID == 2 && unitDFSID == 7 && HP2 > 0 && HP7 > 0)
            {
                HP7 = HP7 - ATK2;
            }
            if (unitATKID == 2 && unitDFSID == 8 && HP2 > 0 && HP8 > 0)
            {
                HP8 = HP8 - ATK2;
            }
            if (unitATKID == 2 && unitDFSID == 9 && HP2 > 0 && HP9 > 0)
            {
                HP9 = HP9 - ATK2;
            }
            if (unitATKID == 2 && unitDFSID == 10 && HP2 > 0 && HP10 > 0)
            {
                HP10 = HP10 - ATK2;
            }
            //unit 3
            if (unitATKID == 3  && unitDFSID == 6 && HP3 > 0 && HP6 > 0)
            {
                HP6 = HP6 - ATK3;
            }
            if (unitATKID == 3 && unitDFSID == 7 && HP3 > 0 && HP7 > 0)
            {
                HP7 = HP7 - ATK3;
            }
            if (unitATKID == 3 && unitDFSID == 8 && HP3 > 0 && HP8 > 0)
            {
                HP8 = HP8 - ATK3;
            }
            if (unitATKID == 3 && unitDFSID == 9 && HP3 > 0 && HP9 > 0)
            {
                HP9 = HP9 - ATK3;
            }
            if (unitATKID == 3 && unitDFSID == 10 && HP3 > 0 && HP10 > 0)
            {
                HP10 = HP10 - ATK3;
            }
            //unit4
            if (unitATKID == 4 && unitDFSID == 6 && HP4 > 0 && HP6 > 0)
            {
                HP6 = HP6 - ATK4;
            }
            if (unitATKID == 4 && unitDFSID == 7 && HP4 > 0 && HP7 > 0)
            {
                HP7 = HP7 - ATK4;
            }
            if (unitATKID == 4 && unitDFSID == 8 && HP4 > 0 && HP8 > 0)
            {
                HP8 = HP8 - ATK4;
            }
            if (unitATKID == 4 && unitDFSID == 9 && HP4 > 0 && HP9 > 0)
            {
                HP9 = HP9 - ATK4;
            }
            if (unitATKID == 4 && unitDFSID == 10 && HP4 > 0 && HP10 > 0)
            {
                HP10 = HP10 - ATK4;
            }
            //unit5
            if (unitATKID == 5 && unitDFSID == 6 && HP5 > 0 && HP6 > 0)
            {
                HP6 = HP6 - ATK5;
            }
            if (unitATKID == 5 && unitDFSID == 7 && HP5 > 0 && HP7 > 0)
            {
                HP7 = HP7 - ATK5;
            }
            if (unitATKID == 5 && unitDFSID == 8 && HP5 > 0 && HP8 > 0)
            {
                HP8 = HP8 - ATK5;
            }
            if (unitATKID == 5 && unitDFSID == 9 && HP5 > 0 && HP9 > 0)
            {
                HP9 = HP9 - ATK5;
            }
            if (unitATKID == 5 && unitDFSID == 10 && HP5 > 0 && HP10 > 0)
            {
                HP10 = HP10 - ATK5;
            }
            //unit6
            if (unitATKID == 6 && unitDFSID == 1 && HP6 > 0 && HP1> 0)
            {
                HP1 = HP1 - ATK6;
            }
            if (unitATKID == 6 && unitDFSID == 2 && HP6 > 0 && HP2 > 0)
            {
                HP2 = HP2 - ATK6;
            }
            if (unitATKID == 6 && unitDFSID == 3 && HP6 > 0 && HP3 > 0)
            {
                HP3 = HP3 - ATK6;
            }
            if (unitATKID == 6 && unitDFSID == 4 && HP6 > 0 && HP4 > 0)
            {
                HP4 = HP4 - ATK6;
            }
            if (unitATKID == 6 && unitDFSID == 5 && HP6 > 0 && HP5 > 0)
            {
                HP5 = HP5 - ATK6;
            }
            //unit7
            if (unitATKID == 7 && unitDFSID == 1 && HP7 > 0 && HP1 > 0)
            {
                HP1 = HP1 - ATK7;
            }
            if (unitATKID == 7 && unitDFSID == 2 && HP7 > 0 && HP2 > 0)
            {
                HP2 = HP2 - ATK7;
            }
            if (unitATKID == 7 && unitDFSID == 3 && HP7 > 0 && HP3 > 0)
            {
                HP3 = HP3 - ATK7;
            }
            if (unitATKID == 7 && unitDFSID == 4 && HP7 > 0 && HP4 > 0)
            {
                HP4 = HP4 - ATK7;
            }
            if (unitATKID == 7 && unitDFSID == 5 && HP7 > 0 && HP5 > 0)
            {
                HP5 = HP5 - ATK7;
            }
            //unit8
            if (unitATKID == 8 && unitDFSID == 1 && HP8 > 0 && HP1 > 0)
            {
                HP1 = HP1 - ATK8;
            }
            if (unitATKID == 8 && unitDFSID == 2 && HP8 > 0 && HP2 > 0)
            {
                HP2 = HP2 - ATK8;
            }
            if (unitATKID == 8 && unitDFSID == 3 && HP8 > 0 && HP3 > 0)
            {
                HP3 = HP3 - ATK8;
            }
            if (unitATKID == 8 && unitDFSID == 4 && HP8 > 0 && HP4 > 0)
            {
                HP4 = HP4 - ATK8;
            }
            if (unitATKID == 8 && unitDFSID == 5 && HP8 > 0 && HP5 > 0)
            {
                HP5 = HP5 - ATK8;
            }
            //unit9
            if (unitATKID == 9 && unitDFSID == 1 && HP9 > 0 && HP1 > 0)
            {
                HP1 = HP1 - ATK9;
            }
            if (unitATKID == 9 && unitDFSID == 2 && HP9 > 0 && HP2 > 0)
            {
                HP2 = HP2 - ATK9;
            }
            if (unitATKID == 9 && unitDFSID == 3 && HP9 > 0 && HP3 > 0)
            {
                HP3 = HP3 - ATK9;
            }
            if (unitATKID == 9 && unitDFSID == 4 && HP9 > 0 && HP4 > 0)
            {
                HP4 = HP4 - ATK9;
            }
            if (unitATKID == 9 && unitDFSID == 5 && HP9 > 0 && HP5 > 0)
            {
                HP5 = HP5 - ATK9;
            }
            //unit10
            if (unitATKID == 10 && unitDFSID == 1 && HP10 > 0 && HP1 > 0)
            {
                HP1 = HP1 - ATK10;
            }
            if (unitATKID == 10 && unitDFSID == 2 && HP10 > 0 && HP2 > 0)
            {
                HP2 = HP2 - ATK10;
            }
            if (unitATKID == 10 && unitDFSID == 3 && HP10 > 0 && HP3 > 0)
            {
                HP3 = HP3 - ATK10;
            }
            if (unitATKID == 10 && unitDFSID == 4 && HP10 > 0 && HP4 > 0)
            {
                HP4 = HP4 - ATK10;
            }
            if (unitATKID == 10 && unitDFSID == 5 && HP10 > 0 && HP5 > 0)
            {
                HP5 = HP5 - ATK10;
            }
            if (HP1 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP2 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP3 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP4 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP5 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP6 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP7 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP8 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP9 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
            if (HP10 <= 0)
            {
                button1.BackgroundImage = Properties.Resources.X;
            }
        }
    }
}
