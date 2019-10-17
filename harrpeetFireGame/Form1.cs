using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harrpeetFireGame
{
    public partial class Form1 : Form
    {
        Setting obj = new Setting();
        Random rd = new Random();
        int sound = 0,bullet=0;
        int clk = 0;
        
        public Form1()
        {
            InitializeComponent();

            sound = obj.fire();

            pbGun.Image= Properties.Resources.bullet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wel Come to the Game \n You have only two bullet in first Chance \n if you want to play again then click on try again after that the game is over ");
            groupBox1.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pb_Gun.Image=Properties.Resources.load;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pb_Gun.Image = Properties.Resources.spin;
            button4.Enabled = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this code is uused when we click on the shoot away button to fire 

            pb_Gun.Image = Properties.Resources.gun;

            clk++;
            //if the clik and sound generation value is equal then the message will print and create the sound of fire other wise the empty sound will sound
            if (clk == sound)
            {
                pbGun.Visible = true;

                // enable the timer to work
                timer1.Start();
                // generate the sound of the  fire trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("fire.wav");
                player.Play();
                bullet++;
                findWinner();
                clk = 0;
                sound = obj.rd.Next(1, 6);
            }
            else {
                // generate the sound of the  empty trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Empty.wav");
                player.Play();

            }

        }
         //tooe code to find the winner of the game if the player win the game other wise it will generate an error 
        public void findWinner() {
            // count the chance to fire if this is first bullet then the message will be display otherwise the display the another message 
            if (bullet==1) {
                if (bullet == obj.rd.Next(1, 6))
                {
                    MessageBox.Show("Congrats you are the winner of this game ");
                    button4.Enabled = false;
                    button5.Visible = true;

                    groupBox1.Visible = false;

                    reset();

                }
                else {
                    MessageBox.Show("this is your last chance to fire ");
                }    
            }
            // when this is last chance then the game over messsage will display and reset the game will print 

            if (bullet==2) {
                MessageBox.Show("Now your bullets are finished try again to play");
                button5.Visible = true;
                button4.Enabled = false;
                groupBox1.Visible = false;
                reset();
            }

            pbGun.Visible = false;
            pbGun.Left = 195;
        }
        // this code is used to try again the game again to play 
        public void reset() {

            //reset all global variable 
            bullet = 0;
            clk = 0;
            //calling the method of the sound 
            sound = obj.rd.Next(1, 6);
            //reseet the gun image 
            pb_Gun.Image = Properties.Resources._1st;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // when the bullet will reach at destination then the timer will stop automatically 
            if (pbGun.Left>600) {
                timer1.Stop();

            }
            // move the image of the bullet 
            pbGun.Left = pbGun.Left + obj.rd.Next(1, 34);

            //button1.Text = "" + pbGun.Left;
        }
    }
}
