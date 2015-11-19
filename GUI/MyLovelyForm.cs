using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurLib;

namespace GUI
{
    public partial class MyLovelyForm : Form
    {
        public MyLovelyForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        Point x1, x2, y1, y2;
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x1, y1);
            g.DrawLine(p, x2, y2);
            g.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = Convert.ToString(random.NextDouble() * 10);
            textBox2.Text = Convert.ToString(random.NextDouble() * 10);
            textBox3.Text = Convert.ToString(random.NextDouble() * 10);
            textBox4.Text = Convert.ToString(random.NextDouble() * 10);
            textBox5.Text = Convert.ToString(random.NextDouble() * 10);
            textBox6.Text = Convert.ToString(random.NextDouble() * 10);
            textBox7.Text = Convert.ToString(random.NextDouble() * 10);
            textBox8.Text = Convert.ToString(random.NextDouble() * 10);
           
            Tuple<double, double> a = new Tuple<double, double>
                            (Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));

            Tuple<double, double> b = new Tuple<double, double>
                            (Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            Tuple<double, double> c = new Tuple<double, double>
                            (Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text));

            Tuple<double, double> d = new Tuple<double, double>
                            (Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox7.Text));
            label1.Text = TwoLines.IsIntersect(a, b, c, d) ? "Intersect" : "Not intersect";
            x1 = new Point(Convert.ToInt32(a.Item1) * 30, Convert.ToInt32(a.Item2) * 30);
            y1 = new Point(Convert.ToInt32(b.Item1) * 30, Convert.ToInt32(b.Item2) * 30);
            x2 = new Point(Convert.ToInt32(c.Item1) * 30, Convert.ToInt32(c.Item2) * 30);
            y2 = new Point(Convert.ToInt32(d.Item1) * 30, Convert.ToInt32(d.Item2) * 30);
            panel1.Refresh();
        }
    }
}
