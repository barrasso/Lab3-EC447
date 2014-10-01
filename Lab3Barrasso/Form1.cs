using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Barrasso
{
    public partial class Form1 : Form
    {
        // Create new array list to hold coordinates
        private ArrayList coords = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Set the dimensions of the dots
            const int height = 20;
            const int width = 20;

            // Instantiate graphics object
            Graphics g = e.Graphics;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Create a new point at that clicked location
                Point p = new Point(e.X, e.Y);

                // Put the point in the coords array
                this.coords.Add(p);

                // Invalidate
                this.Invalidate();
            }

            // Check if right mouse buton was clicked
            if (e.Button == MouseButtons.Right)
            {
                // Clear the coords array
                this.coords.Clear();

                // Invalidate
                this.Invalidate();
            }
        }
    }
}
