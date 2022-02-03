using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Point initialPosition;
        public Form1()
        {
            InitializeComponent();

            redLight1.Visible = true;
            yellowLight1.Visible = false;
            greenLight1.Visible = false;
            red2.Visible = true;
            yellow2.Visible = false;
            green2.Visible = false;
            red3.Visible = true;
            yellow3.Visible = false;
            green3.Visible = false;
            red4.Visible = true;
            yellow4.Visible = false;
            green4.Visible = false;



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (redLight1.Visible == true)
            {
                redLight1.Visible = false;
                yellowLight1.Visible = false;
                greenLight1.Visible = true;
            }
            else if (greenLight1.Visible == true)
            {
                redLight1.Visible = false;
                yellowLight1.Visible = true;
                greenLight1.Visible = false;
            }
            else if (yellowLight1.Visible == true)
            {
                redLight1.Visible = true;
                yellowLight1.Visible = false;
                greenLight1.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (yellowLight1.Visible == true)
            {
                if (car2.Location.X > 9)
                    car2.Location =
                        new Point(car2.Location.X + 10, car2.Location.Y);
                else car2.Location = initialPosition(90,10);
            }

            if (greenLight1.Visible == true)
            {
                if (car2.Location.X > 9)
                    car2.Location =
                        new Point(car2.Location.X + 10, car2.Location.Y);
                else car2.Location = initialPosition(90,10);
            }


        }

        private Point initialPosition(90,10)(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            timer7.Enabled = true;
            timer8.Enabled = true;
            timer9.Enabled = true;
            timer10.Enabled = true;
            timer11.Enabled = true;
            timer12.Enabled = true;
            timer13.Enabled = true;
            timer14.Enabled = true;
            timer15.Enabled = true;
            timer16.Enabled = true;
            initialPosition = car1.Location;
            initialPosition = car2.Location;
            initialPosition = car5.Location;
            initialPosition = car10.Location;
            initialPosition = car11.Location;
            initialPosition = car6.Location;
            initialPosition = redcar.Location;
            initialPosition = yellowcar.Location;
            initialPosition = bluecar.Location;
            initialPosition = carwhite.Location;
            initialPosition = openblue.Location;
            initialPosition = carwhite2.Location;

        }

        private void redLight1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (red2.Visible == true)
            {
                red2.Visible = false;
                yellow2.Visible = false;
                green2.Visible = true;
            }
            else if (green2.Visible == true)
            {
                red2.Visible = false;
                yellow2.Visible = true;
                green2.Visible = false;
            }
            else if (yellow2.Visible == true)
            {
                red2.Visible = true;
                yellow2.Visible = false;
                green2.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (yellow2.Visible == true)
            {
                if (car1.Location.X > 9)
                    car1.Location =
                        new Point(car1.Location.X - 10, car1.Location.Y);
                else car1.Location = initialPosition;
            }
            if (green2.Visible == true)
            {
                if (car1.Location.X > 9)
                    car1.Location =
                        new Point(car1.Location.X - 10, car1.Location.Y);
                else car1.Location = initialPosition;
            }
        }

        private void car1_Click(object sender, EventArgs e)
        {

        }

        private void car5_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (yellow3.Visible == true)
            {

                if (car5.Location.Y > 10)
                    car5.Location =
                        new Point(car5.Location.X, car5.Location.Y - 20);
                else car5.Location = initialPosition;
            }
            if (green3.Visible == true)
            {
                if (car5.Location.Y > 10)
                    car5.Location =
                        new Point(car5.Location.X, car5.Location.Y - 20);
                else car5.Location = initialPosition;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            timer9.Enabled = false;
            timer10.Enabled = false;
            timer11.Enabled = false;
            timer12.Enabled = false;
            timer13.Enabled = false;
            timer14.Enabled = false;
            timer15.Enabled = false;
            timer16.Enabled = false;


        }

        private void yellow3_Click(object sender, EventArgs e)
        {

        }

        private void car10_Click(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (yellowLight1.Visible == true)
            {
                if (car10.Location.X > 9)
                    car10.Location =
                        new Point(car10.Location.X + 10, car10.Location.Y);
                else car10.Location = initialPosition;
            }

            if (greenLight1.Visible == true)
            {
                if (car10.Location.X > 9)
                    car10.Location =
                        new Point(car10.Location.X + 10, car10.Location.Y);
                else car10.Location = initialPosition;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (yellowLight1.Visible == true)
            {
                if (car11.Location.X > 9)
                    car11.Location =
                        new Point(car11.Location.X + 10, car11.Location.Y);
                else car11.Location = initialPosition;
            }

            if (greenLight1.Visible == true)
            {
                if (car11.Location.X > 9)
                    car11.Location =
                        new Point(car11.Location.X + 10, car11.Location.Y);
                else car11.Location = initialPosition;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (red3.Visible == true)
            {
                red3.Visible = false;
                yellow3.Visible = false;
                green3.Visible = true;
            }
            else if (green3.Visible == true)
            {
                red3.Visible = false;
                yellow3.Visible = true;
                green3.Visible = false;
            }
            else if (yellow3.Visible == true)
            {
                red3.Visible = true;
                yellow3.Visible = false;
                green3.Visible = false;
            }
        }

        private void car6_Click(object sender, EventArgs e)
        {

        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (yellow3.Visible == true)
            {

                if (car6.Location.Y > 10)
                    car6.Location =
                        new Point(car6.Location.X, car6.Location.Y - 20);
                else car6.Location = initialPosition;
            }
            if (green3.Visible == true)
            {
                if (car6.Location.Y > 10)
                    car6.Location =
                        new Point(car6.Location.X, car6.Location.Y - 20);
                else car6.Location = initialPosition;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (yellow3.Visible == true)
            {

                if (redcar.Location.Y > 10)
                    redcar.Location =
                        new Point(redcar.Location.X, redcar.Location.Y - 20);
                else redcar.Location = initialPosition;
            }
            if (green3.Visible == true)
            {
                if (redcar.Location.Y > 10)
                    redcar.Location =
                        new Point(redcar.Location.X, redcar.Location.Y - 20);
                else redcar.Location = initialPosition;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            {
                if (red4.Visible == true)
                {
                    red4.Visible = false;
                    yellow4.Visible = false;
                    green4.Visible = true;
                }
                else if (green4.Visible == true)
                {
                    red4.Visible = false;
                    yellow4.Visible = true;
                    green4.Visible = false;
                }
                else if (yellow4.Visible == true)
                {
                    red4.Visible = true;
                    yellow4.Visible = false;
                    green4.Visible = false;
                }
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (yellow2.Visible == true)
            {
                if (yellowcar.Location.X > 9)
                    yellowcar.Location =
                        new Point(yellowcar.Location.X - 10, yellowcar.Location.Y);
                else yellowcar.Location = initialPosition;
            }
            if (green2.Visible == true)
            {
                if (yellowcar.Location.X > 9)
                    yellowcar.Location =
                        new Point(yellowcar.Location.X - 10, yellowcar.Location.Y);
                else yellowcar.Location = initialPosition;
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (yellow2.Visible == true)
            {
                if (bluecar.Location.X > 9)
                    bluecar.Location =
                        new Point(bluecar.Location.X - 10, bluecar.Location.Y);
                else bluecar.Location = initialPosition;
            }
            if (green2.Visible == true)
            {
                if (bluecar.Location.X > 9)
                    bluecar.Location =
                        new Point(bluecar.Location.X - 10, bluecar.Location.Y);
                else bluecar.Location = initialPosition;
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (yellow4.Visible == true)
            {

                if (carwhite.Location.Y > 10)
                    carwhite.Location =
                        new Point(carwhite.Location.X, carwhite.Location.Y + 20);
                else carwhite.Location = initialPosition;
            }
            if (green4.Visible == true)
            {
                if (carwhite.Location.Y > 10)
                    carwhite.Location =
                        new Point(carwhite.Location.X, carwhite.Location.Y + 20);
                else carwhite.Location = initialPosition;
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if (yellow4.Visible == true)
            {

                if (carwhite2.Location.Y > 10)
                    carwhite2.Location =
                        new Point(carwhite2.Location.X, carwhite2.Location.Y + 20);
                else carwhite2.Location = initialPosition;
            }
            if (green4.Visible == true)
            {
                if (carwhite2.Location.Y > 10)
                    carwhite2.Location =
                        new Point(carwhite2.Location.X, carwhite2.Location.Y + 20);
                else carwhite2.Location = initialPosition;
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            if (yellow4.Visible == true)
            {

                if (openblue.Location.Y > 10)
                    openblue.Location =
                        new Point(openblue.Location.X, openblue.Location.Y + 20);
                else openblue.Location = initialPosition;
            }
            if (green4.Visible == true)
            {
                if (openblue.Location.Y > 10)
                    openblue.Location =
                        new Point(openblue.Location.X, openblue.Location.Y + 20);
                else openblue.Location = initialPosition;
            }
        }
    }
}
    

