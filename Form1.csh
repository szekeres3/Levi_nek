using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace formapp
{
    public partial class Form1 : Form
    {
        struct ugyfel
        {
            public string nev;
            public int szolsz;
        }
        List<string> l = new List<string>();
        List<ugyfel> rendelsek = new List<ugyfel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            la_name.Visible = true;
            la_name.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progress bar
            progressBar1.Value = cb_menu.CheckedItems.Count;

            lb_out.Items.Clear();
            //for (int i = 0; i < cb_menu.CheckedItems.Count; i++)
            //{
            //    lb_out.Items.Add(cb_menu.Items.IndexOf(i));
            //}

            foreach (var cb in cb_menu.CheckedItems)
            {
                lb_out.Items.Add(cb);
            }

            chart1.Visible = true;

            //ugyfel letrehozasa
            ugyfel u = new ugyfel();
            u.nev = la_name.Text;
            u.szolsz = cb_menu.CheckedItems.Count;
            rendelsek.Add(u);

            int hely = 0;
            for (hely; hely < rendelsek.Count; hely++)
            {
                if (chart1.Series.Equals(rendelsek[hely].nev))
                {
                    MessageBox.Show("Visszatérő vásárló");
                }
                else {
                    chart1.Series.Add(rendelsek[hely].nev);
                }
                
                chart1.Series[rendelsek[hely].nev].Points.AddXY(hely, rendelsek[hely].szolsz);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int c = progressBar1.Maximum - progressBar1.Value;
            MessageBox.Show(progressBar1.Value.ToString()+" csomag kijelölve megrendelésre\n"+  c + " lehetséges csomag maradt\n");


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //csik-toltes
            progressBar1.Maximum = 3;
            progressBar1.Step = 1;

            //statisztika
            chart1.Visible = false;
            chart1.Titles.Add("Rendlesések");
            chart1.Series.Clear();

            //textbox
            textBox1.Text = "<nevtelen>";
            la_name.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("vazlat.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }
    }
}
