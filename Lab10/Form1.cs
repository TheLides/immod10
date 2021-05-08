using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFairDice_Click(object sender, EventArgs e)
        {
            Roll(false);
        }

        private void buttonUnfairDice_Click(object sender, EventArgs e)
        {
            Roll(true);
        }

        private void resultShow(int userRes, int rivalRes)
        {
            playerRoll.Text = userRes.ToString();
            rivalRoll.Text = rivalRes.ToString();
            if (userRes < rivalRes)
            {
                resultLabel.Text = "You died";
            }
            if (userRes > rivalRes)
            {
                resultLabel.Text = "Victory achieved. Humanity restored";
            }
            if (userRes == rivalRes)
            {
                resultLabel.Text = "Try again, warrior";
            }
        }

        private void Roll (bool cheat)
        {
            int userRes, rivalRes;
            if (cheat)
            {
                rivalRes = FairRoll(random.NextDouble());
                userRes = UnfairRoll(random.NextDouble(), rivalRes);
                resultShow(userRes, rivalRes);

            }
            else
            {
                userRes = FairRoll(random.NextDouble());
                rivalRes = FairRoll(random.NextDouble());
                resultShow(userRes, rivalRes);
            }

        }

        private int FairRoll(double rnd)
        {
            int ans = 0;
            while (rnd > 0)
            {
                rnd -= 0.05;
                ans++;
            }

            return ans;
        }

        private int UnfairRoll(double rnd, int rivalRoll)
        {
            int ans = 0;
            int tempRoll = FairRoll(random.NextDouble());
            if (tempRoll >= rivalRoll)
            {
                return tempRoll;
            }
            else
            {
                while (rnd > 0)
                {
                    if (ans < 15)
                    {
                        rnd -= 0.05;
                    }
                    else
                    {
                        rnd -= 0.5;
                    }
                    ans++;
                }
                return ans;
            }
        }
    }
}
