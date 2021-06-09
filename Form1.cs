using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonwerterCzasu
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <param name="x"></param>

        public double SekundyNaSekundy(double x)
        {
            return x;
        }

        /// <param name="x"></param>

        public double MinutyNaSekundy(double x)
        {
            return x * 60;
        }
 
        /// <param name="x"></param>

        public double GodzinyNaSekundy(double x)
        {
            return GodzinyNaMinuty(x) * 60;
        }

        /// <param name="x"></param>

        public double DniNaSekundy(double x)
        {
            return SekundyNaSekundy(GodzinyNaMinuty(DniNaGodziny(x))) * 60;
        }

        /// <param name="x"></param>

        public double TygodnieNaSekundy(double x)
        {
            return x * 604800.02;
        }

        /// <param name="x"></param>

        public double MiesiaceNaSekundy(double x)
        {
            return 2629800 * x;
        }

        /// <param name="x"></param>

        public double LataNaSekundy(double x)
        {
            return MiesiaceNaSekundy(x) * 12;
        }

        /// <param name="x"></param>

        public double SekundyNaMinuty(double x)
        {
            return x / 60;
        }

        /// <param name="x"></param>

        public double MinutyNaMinuty(double x)
        {
            return x;
        }

        /// <param name="x"></param>

        public double GodzinyNaMinuty(double x)
        {
            return x * 60;
        }

        /// <param name="x"></param>

        public double DniNaMinuty(double x)
        {
            return GodzinyNaMinuty(x) * 24;
        }

        /// <param name="x"></param>

        public double TygodnieNaMinuty(double x)
        {
            return DniNaMinuty(x) * 7;
        }

        /// <param name="x"></param>

        public double MiesiaceNaMinuty(double x)
        {
            return 730.5 * 60 * x;
        }

        /// <param name="x"></param>

        public double LataNaMinuty(double x)
        {
            return MiesiaceNaMinuty(x) * 12;
        }

        /// <param name="x"></param>

        public double SekundyNaGodziny(double x)
        {
            return x / 60 / 60;
        }


        /// <param name="x"></param>

        public double MinutyNaGodziny(double x)
        {
            return x / 60;
        }

        /// <param name="x"></param>

        public double GodzinyNaGodziny(double x)
        {
            return x;
        }

        /// <param name="x"></param>

        public double DniNaGodziny(double x)
        {
            return x * 24;
        }

        /// <param name="x"></param>

        public double TygodnieNaGodziny(double x)
        {
            return DniNaGodziny(x) * 7;
        }

        /// <param name="x"></param>

        public double MiesiaceNaGodziny(double x)
        {
            return 30.4375 * x * 24;
        }

        /// <param name="x"></param>

        public double LataNaGodziny(double x)
        {
            return x * 365 * 24 + 6 * x;
        }

        /// <param name="x"></param>

        public double SekundyNaDni(double x)
        {
            return x * 1.15740;
        }

        /// <param name="x"></param>

        public double MinutyNaDni(double x)
        {
            return GodzinyNaDni(x) / 60;
        }

        /// <param name="x"></param>

        public double GodzinyNaDni(double x)
        {
            return x / 24;
        }

        /// <param name="x"></param>

        public double DniNaDni(double x)
        {
            return x;
        }
        /// <param name="x"></param>

        public double TygodnieNaDni(double x)
        {
            return x * 7;
        }

        /// <param name="x"></param>

        public double MiesiaceNaDni(double x)
        {
            return 30.4375 * x;
        }

        /// <param name="x"></param>

        public double LataNaDni(double x)
        {
            return MiesiaceNaDni(x) * 12;
        }

        /// <param name="x"></param>

        public double SekundyNaTygodnie(double x)
        {
            return MinutyNaTygodnie(x) / 60;
        }

        /// <param name="x"></param>

        public double MinutyNaTygodnie(double x)
        {
            return GodzinyNaTygodnie(x) / 60;
        }

        /// <param name="x"></param>
 
        public double GodzinyNaTygodnie(double x)
        {
            return DniNaTygodnie(x) / 24;
        }

        /// <param name="x"></param>

        public double DniNaTygodnie(double x)
        {
            return x * 0.14;
        }

        /// <param name="x"></param>

        public double TygodnieNaTygodnie(double x)
        {
            return x;
        }

        /// <param name="x"></param>

        public double MiesiaceNaTygodnie(double x)
        {
            double y = 4.35;
            return Math.Floor(x * y);
        }

        /// <param name="x"></param>

        public double LataNaTygodnie(double x)
        {

            return 52.18 * x;
        }

        /// <param name="x"></param>

        public double SekundyNaMiesiace(double x)
        {
            return MinutyNaMiesiace(x) / 60;
        }


        /// <param name="x"></param>

        public double MinutyNaMiesiace(double x)
        {
            return GodzinyNaMiesiace(x) / 60;
        }

        /// <param name="x"></param>

        public double GodzinyNaMiesiace(double x)
        {
            return DniNaMiesiace(x) / 24;
        }

        /// <param name="x"></param>

        public double DniNaMiesiace(double x)
        {
            return x * 0.03;
        }


        /// <param name="x"></param>

        public double TygodnieNaMiesiace(double x)
        {
            return x * 0.23;
        }


        /// <param name="x"></param>

        public double MiesiaceNaMiesiace(double x)
        {
            return x;
        }


        /// <param name="x"></param>

        public double LataNaMiesiace(double x)
        {

            return x * 12;
        }

        /// <param name="x"></param>

        public double SekundyNaLata(double x)
        {
            return MinutyNaLata(x) / 60;
        }

        /// <param name="x"></param>

        public double MinutyNaLata(double x)
        {
            return GodzinyNaLata(x) / 60;
        }

        /// <param name="x"></param>

        public double GodzinyNaLata(double x)
        {
            return DniNaLata(x) / 24;
        }


        /// <param name="x"></param>
 
        public double DniNaLata(double x)
        {
            return x * 0.00274;
        }

        /// <param name="x"></param>

        public double TygodnieNaLata(double x)
        {
            return x * 0.02;
        }

        /// <param name="x"></param>

        public double MiesiaceNaLata(double x)
        {
            return x * 0.0833333333;
        }

        /// <param name="x"></param>

        public double LataNaLata(double x)
        {

            return x;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;               
            
                try
                { 
                
                double x = Convert.ToDouble(textBox1.Text);


                if (textBox1.Text == "" || Convert.ToDouble(textBox1.Text) < 0)
                {
                    MessageBox.Show("Należy wpisać liczbę, która będzie większa od zera");
                }

                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                {
                    result = SekundyNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {
                    result = SekundyNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
                {
                    result = SekundyNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
                {
                    result = SekundyNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
                {
                    result = SekundyNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
                {
                    result = SekundyNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6)
                {
                    result = SekundyNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                {
                    result = MinutyNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    result = MinutyNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    result = MinutyNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
                {
                    result = MinutyNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
                {
                    result = MinutyNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
                {
                    result = MinutyNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
                {
                    result = MinutyNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
                {
                    result = GodzinyNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
                {
                    result = GodzinyNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
                {
                    result = GodzinyNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
                {
                    result = GodzinyNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)
                {
                    result = GodzinyNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 5)
                {
                    result = GodzinyNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 6)
                {
                    result = GodzinyNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
                {
                    result = DniNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
                {
                    result = DniNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
                {
                    result = DniNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)
                {
                    result = DniNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)
                {
                    result = DniNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)
                {
                    result = DniNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 6)
                {
                    result = DniNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
                {
                    result = TygodnieNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
                {
                    result = TygodnieNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
                {
                    result = TygodnieNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)
                {
                    result = TygodnieNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)
                {
                    result = TygodnieNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 5)
                {
                    result = TygodnieNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
                {
                    result = TygodnieNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
                {
                    result = MiesiaceNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 1)
                {
                    result = MiesiaceNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 2)
                {
                    result = MiesiaceNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 3)
                {
                    result = MiesiaceNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 4)
                {
                    result = MiesiaceNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 5)
                {
                    result = MiesiaceNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 6)
                {
                    result = MiesiaceNaLata(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
                {
                    result = LataNaSekundy(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 1)
                {
                    result = LataNaMinuty(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 2)
                {
                    result = LataNaGodziny(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 3)
                {
                    result = LataNaDni(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 4)
                {
                    result = LataNaTygodnie(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 5)
                {
                    result = LataNaMiesiace(x);
                }
                else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 6)
                {
                    result = LataNaLata(x);
                }
                else
                {
                    MessageBox.Show("Wybierz jednostki czasu!");
                }
                }          

                catch (FormatException)
                {
                    MessageBox.Show("Wpisana wartość nie może być tekstem! ");
                }


            if (result != 0)
            {
                decimal d = Convert.ToDecimal(result);
                if (d < 1)
                    MessageBox.Show("0" + d.ToString("#.##"));
                else
                    MessageBox.Show(d.ToString("#.##"));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}


