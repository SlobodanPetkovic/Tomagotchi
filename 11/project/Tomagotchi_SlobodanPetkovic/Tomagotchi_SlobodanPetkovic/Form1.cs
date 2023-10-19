using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomagotchi_SlobodanPetkovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _score;
        private bool _statusscore = false;
        private bool _message = true;
        private void btnDrinken_Click(object sender, EventArgs e)
        {
            try
            {
                barDrinken.Value = barDrinken.Value + 5;
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            try
            {
                barEten.Value = barEten.Value + 5;
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barEten.Increment(-1);
            barDrinken.Increment(-1);

            if (barEten.Value < 1 || barDrinken.Value < 1)
            {
                barWelzijn.Increment(-1);
            }

            if (barWelzijn.Value > 75)
            {
                pbAfbeelding.Image = Properties.Resources.max;
                pbAfbeelding.Refresh();
            }
            else if (barWelzijn.Value < 75 && barWelzijn.Value > 50)
            {
                pbAfbeelding.Image = Properties.Resources.high;
                pbAfbeelding.Refresh();
            }
            else if (barWelzijn.Value < 50 && barWelzijn.Value > 25)
            {
                pbAfbeelding.Image = Properties.Resources.mid;
                pbAfbeelding.Refresh();
            }
            else if (barWelzijn.Value < 25 && barWelzijn.Value > 1)
            {
                pbAfbeelding.Image = Properties.Resources.low;
                pbAfbeelding.Refresh();
            }
            else if (barWelzijn.Value == 0)
            {
                pbAfbeelding.Image = Properties.Resources.dead;
                _statusscore = true;
                if (_message)
                {
                    _message = false;
                    MessageBox.Show("Jouw score is:" + _score);
                    // Application.Exit();

                }
                pbAfbeelding.Refresh();
            }

            if (_statusscore != true)
            {
                lblScore.Text = _score++.ToString();
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
