using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();


        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Size = new Size(800, 800);
            if (textBox1 == null) return;

            int x = Convert.ToInt32(textBox1.Text);
            int X1 = this.Size.Height;
            int Y1 = this.Size.Width;

            int X2 = 100;
            int Y2 = 100;

            int buttonX = 45;  
            int buttonY = 45;  

            for (int i = 1; i <= x; i++)
            {
                if ((X2 + buttonX) >= Y1)
                {
                    X2 = 100;
                    Y2 = Y2 + buttonY;

                    Button button = new Button();
                    button.Size = new Size(45,45);
                    button.Text=string.Format("{0}", i);
                    button.Location = new Point(X2,Y2);
                    button.BackColor = GetRandomColor();
                    Controls.Add(button);

                    X2 = X2 + buttonX;
                }
                else
                {
                    Button button = new Button();
                    button.Size = new Size(45,45);
                    button.Text = string.Format("{0}", i);
                   button.Location = new Point(X2, Y2);
                    button.BackColor = GetRandomColor();
                    Controls.Add(button);
                    X2 = X2 + buttonX;
                    button.Click += new EventHandler(button_Click);
                }
            }
           
            }
        private void button_Click(object sender, EventArgs e)


        {
            var button = (Button)sender;

            MessageBox.Show(string.Format(" {0}", button.Text));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        }
    

