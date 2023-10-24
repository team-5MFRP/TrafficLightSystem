using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTest
{
    public partial class Form1 : Form
    {
        private int southNorthGreenDuration = 20;
        private int westEastGreenDuration = 20;
        private int yellowDuration = 5;
        private int redDuration = 4;
        private int rightTurnDuration = 10;
        //private bool isPeakTime = false;

        public Form1()
        {
            InitializeComponent();
            StartTrafficLights();
        }
        private async void StartTrafficLights()
        {
            while(true)
            {
                if (IsPeakHour())
                {
                    southNorthGreenDuration = 40;
                    westEastGreenDuration = 10;
                }
                else
                {
                    southNorthGreenDuration = 20;
                    westEastGreenDuration = 20;
                }

                DisplaySouthNorthGreenLight();
                await Task.Delay(southNorthGreenDuration * 1000);

                DisplayNorthRightTurnLight();
                await Task.Delay(rightTurnDuration * 1000);

                DisplaySouthNorthYellowLight();
                await Task.Delay(yellowDuration * 1000);

                DisplayRedLight();
                await Task.Delay(redDuration * 1000);

                DisplayWestEastGreenLight();
                await Task.Delay(westEastGreenDuration * 1000);

                DisplayWestEastYellowLight();
                await Task.Delay(yellowDuration * 1000);

                DisplayRedLight();
                await Task.Delay(redDuration * 1000);
            }
        }


        private bool IsPeakHour()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan current = currentTime.TimeOfDay;

            // Peak hours are 0800-1000 and 1700-1900
            return (current >= new TimeSpan(8, 0, 0) && current <= new TimeSpan(10, 0, 0)) ||
                   (current >= new TimeSpan(17, 0, 0) && current <= new TimeSpan(19, 0, 0));
        }

        private void DisplaySouthNorthGreenLight()
        {
            southLightPictureBox.BackColor = Color.Green;
            northLightPictureBox.BackColor = Color.Green;
            westLightPictureBox.BackColor = Color.Red;    
            eastLightPictureBox.BackColor = Color.Red;
            rightTurnPictureBox.BackColor = Color.Red;
        }

        private void DisplayNorthRightTurnLight()
        {
            southLightPictureBox.BackColor = Color.Green;
            northLightPictureBox.BackColor = Color.Red;//stops south bound traffic
            westLightPictureBox.BackColor = Color.Red;
            eastLightPictureBox.BackColor = Color.Red;
            rightTurnPictureBox.BackColor = Color.Green;
        }
        private void DisplayWestEastGreenLight()
        {
            southLightPictureBox.BackColor = Color.Red;
            northLightPictureBox.BackColor = Color.Red;
            westLightPictureBox.BackColor = Color.Green;
            eastLightPictureBox.BackColor = Color.Green;
            rightTurnPictureBox.BackColor = Color.Red;
        }

        private void DisplaySouthNorthYellowLight()
        {
            southLightPictureBox.BackColor = Color.Yellow;
            northLightPictureBox.BackColor= Color.Yellow;
            westLightPictureBox.BackColor = Color.Red;
            eastLightPictureBox.BackColor = Color.Red;
            rightTurnPictureBox.BackColor = Color.Yellow;
        }

        private void DisplayWestEastYellowLight()
        {
            southLightPictureBox.BackColor = Color.Red;
            northLightPictureBox.BackColor = Color.Red;
            westLightPictureBox.BackColor = Color.Yellow;
            eastLightPictureBox.BackColor = Color.Yellow;
            rightTurnPictureBox.BackColor = Color.Red;
        }

        private void DisplayRedLight()
        {
            southLightPictureBox.BackColor = Color.Red;
            northLightPictureBox.BackColor = Color.Red;
            westLightPictureBox.BackColor = Color.Red;
            eastLightPictureBox.BackColor = Color.Red;
            rightTurnPictureBox.BackColor = Color.Red;
        }       

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void westLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void southLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
