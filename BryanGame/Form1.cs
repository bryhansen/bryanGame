using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button anotherButton = new Button();
            anotherButton.Tag = new Point(1, 4);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fettPicture.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            fettPicture.Hide();
        
        }

        private void fettPicture_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            Console.WriteLine("This is a test");

        }
    }
}
