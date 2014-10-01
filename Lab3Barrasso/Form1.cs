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
        // Create new list to hold all objects instantiated from MarksClass
        public List <MarksClass>allPoints = new List<MarksClass>();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Set the dimensions of the dots
            const int height = 20;
            const int width = 20;

            // Instantiate graphics object
            Graphics g = e.Graphics;

            // Loop through allPoints array
            foreach (MarksClass markObj in this.allPoints)
            {
                // Check if point is black
                if (markObj.isRed == false)
                    // Create an black dot with coords and set height and width
                    g.FillEllipse(Brushes.Black, markObj.p.X - width / 2, markObj.p.Y - height / 2, width, height);
                                 
                else
                {
                    // Create an red dot with coords and set height and width
                    g.FillEllipse(Brushes.Red, markObj.p.X - width / 2, markObj.p.Y - height / 2, width, height);
                }
            }
        }

        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Create a new point at that clicked location
                Point p = new Point(e.X, e.Y);

                // Instantiate new class with point and flag set to false
                MarksClass markObj = new MarksClass(p, false);

                // Put the point in the coords array
                this.allPoints.Add(markObj);

                // Invalidate
                this.Invalidate();
            }

            // Check if right mouse buton was clicked
            if (e.Button == MouseButtons.Right)
            {
                // Loop through all the objects in allPoints
                for (int i = 0; i < this.allPoints.Count; i++)
                {
                    // Get current index's point
                    Point currentPoint = this.allPoints[i].p;

                    // Check if mouse click occured in boundingbox of currentpoint

                    // Check if point is black
                    if (this.allPoints[i].isRed == true)
                        // Remove it
                        this.allPoints.RemoveAt(i);
                    else
                        // Create new object
                        this.allPoints[i] = new MarksClass(currentPoint, true);
                }

                // Invalidate
                this.Invalidate();
            }
        }
    }
}
