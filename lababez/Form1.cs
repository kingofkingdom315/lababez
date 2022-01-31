using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lababez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v, t, s2;
            double p, s, a, l;
            a = 26;
            l = 2;
            p = Convert.ToDouble(Pbox.Text);
            v = Convert.ToInt32(Vbox.Text);
            t = Convert.ToInt32(Tbox.Text);
            s = v * t / p;
            s2 = Convert.ToInt32(s);
            for (l = 2; s2 > Math.Pow(a, l); l++)
            {
                for (a = 26; s2 > Math.Pow(a, l) && a < 36; a++)
                {
                    if (s2 < Math.Pow(a, l))
                    {
                        Console.WriteLine(Math.Pow(a, l));
                        break;
                    }
                }
                if (s2 < Math.Pow(a, l))
                {
                    Console.WriteLine(Math.Pow(a, l));
                    break;
                }
                a = 26;
            }
            Abox.Text = a.ToString();
            Lbox.Text = l.ToString();
        }
    }
}
