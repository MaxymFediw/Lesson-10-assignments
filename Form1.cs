using Lesson_10_assignments.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_10_assignments
{
    public partial class Form1 : Form
    {
        Random generator = new Random();

        SoundPlayer Player;

        int dog = 0, cat = 1, pig = 2, randomSound, score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            
            randomSound = generator.Next(3);

            if (randomSound == 0) 
            {
                Player = new SoundPlayer(Resources.woof);
            }

            else if (randomSound == 1) 
            {
                Player = new SoundPlayer(Resources.meow);
            }

            else if (randomSound == 2) 
            {
                Player = new SoundPlayer(Resources.oink);
            }

            Player.Play();
            
        }

        private void imgCat_Click(object sender, EventArgs e)
        {

            if (randomSound == 1)
            {
                score++;
            }

            else 
            {
                score--;
            }
            lblScore.Text = score.ToString();
        }

        private void imgDog_Click(object sender, EventArgs e)
        {
            if (randomSound == 0)
            {
                score++;
            }

            else 
            {
                score--;
            }
            lblScore.Text = score.ToString();
        }

        private void imgPig_Click(object sender, EventArgs e)
        {
            if (randomSound == 2)
            {
                score++;
            }

            else 
            {
                score--;
            }

            lblScore.Text = score.ToString();
        }





    }
}
