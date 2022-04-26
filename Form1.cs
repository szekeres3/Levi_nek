using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Formapp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class ugyfel
        {
            public string nev;
            public string[] szoln;
            public DateTime beszerel;
        }

        List<ugyfel> rendelesek = new List<ugyfel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //toltes-haladas
            pBar_pro.Maximum = cb_menu.Items.Count;
            pBar_pro.Step = 1;

            //statisztika
            ch_st1.Visible = false;
            ch_st1.Titles.Add("Rendelések");
            ch_st1.Series.Clear();
            ch_st1.ChartAreas[0].AxisY.Interval = 1;
            ch_st1.ChartAreas[0].AxisY.Maximum = cb_menu.Items.Count;
            ch_st1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            ch_st1.ChartAreas[0].AxisX.Interval = 1;

            //textbox
            textBox1.Text = "nevtelen";

            //mentes-gombok
            bt_print.Enabled = false;
            bt_www.Enabled = false;
            bt_pre.Enabled = false;
            bt_svPDF.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            la_name.Text = textBox1.Text;
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            //progress
            pBar_pro.Value = cb_menu.CheckedItems.Count;
            
            //lista
            lb_out.Items.Clear();
            foreach (var item in cb_menu.CheckedItems)
            {
                lb_out.Items.Add(item);
            }

            //ugyfel
            ugyfel u = new ugyfel();
            u.nev = nevve();
            u.beszerel = dtP_beDate.Value;
            u.szoln = lb_out.Items.Cast<string>().ToArray();
            rendelesek.Add(u);

            //stat feltolt
            ch_st1.Visible = true;
            ch_st1.Series.Clear();
            int hely = 0;
            while (hely < rendelesek.Count)
            {
                string azon = rendelesek[hely].nev + hely.ToString();
                ch_st1.Series.Add(azon);
                ch_st1.Series[azon].Points.AddXY(rendelesek[hely].beszerel, rendelesek[hely].szoln.Length);
                hely++;
            }

            string nevve()
            {
                if (textBox1.Text != "")
                {
                    string mod1 = "";
                    string[] mod2 = textBox1.Text.Split(' ');
                    foreach (var item in mod2)
                    {
                        mod1 += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
                    }
                    return mod1;
                }
                else
                {
                    return "nevtelen";
                }
            }
        }

        private void pBar_pro_Click(object sender, EventArgs e)
        {
            int c = pBar_pro.Maximum - pBar_pro.Value; 
            MessageBox.Show(pBar_pro.Value.ToString() + " csomag kijelölve megrendelésre\n" + c + " lehetséges csomag maradt\n", "Vásárlás menete" ,MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void bt_saves_Click(object sender, EventArgs e)
        {
            var r = folderBrowserDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                string spath = folderBrowserDialog1.SelectedPath;
                if (File.Exists(spath+"/vazlat.png")||File.Exists(spath+"/munka.html"))
                {
                    MessageBox.Show("A fájl már létezik!\n Helyezze át vagy használja a további megoldások egyikét!", "Egyezéses hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var s = MessageBox.Show("A régi fájl elveszik, de egy új lép a helyére!\nFelülírja?", "Overwrite?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (s == DialogResult.Yes)
                    {
                        ch_st1.SaveImage(spath + "/vazlat.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        weblap();
                        MessageBox.Show("Sikeres mentés!", "Új fájl", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (s == DialogResult.No)
                    {
                        MessageBox.Show("Nem történt mentés", "Visszavonás!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ch_st1.SaveImage(spath + "/vazlat.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    weblap();
                    MessageBox.Show("Sikeres mentes", "Hurrá!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                void weblap()
                {
                    //html mentes
                    string stilus = "style =\"border: 1px solid; padding: 10px;\"";
                    string center = "style =\"float:center; text-align: center; justify-content: center;\"";
                    //"+stilus+"
                    string html = "<head><meta charset=\"UTF-8\"></head><body " + center + "><table  style=\"margin-left: auto; margin-right: auto; border: 1px solid; padding: 10px;\">";

                    //table-header
                    html += "<tr>" +
                        "<th " + stilus + ">Név</th>" +
                        "<th " + stilus + ">Szolgáltatás(ok)</th>" +
                        "<th " + stilus + ">Beszerelés dátuma</th>" +
                        "<th " + stilus + ">Teljesítés</th>" +
                        "</tr>";

                    //table-data
                    foreach (var item in rendelesek)
                    {
                        html += "<tr style=\"border: 1px solid; padding: 10px;\">" +
                            "<td " + stilus + ">" + item.nev + "</td><td " + stilus + ">";


                        for (int i = 0; i < item.szoln.Length; i++)
                        {
                            html += item.szoln[i];
                            if (i < item.szoln.Length - 1)
                            {
                                html += "; ";
                            }
                        }
                        html += "</ td ><td " + stilus + ">" + item.beszerel + "</td>" +
                                "<td " + stilus + "><input type=\"checkbox\"></td>";
                    }
                    html += "</table><br><br>";
                    html += "<img src=\"vazlat.png\" alt=\"grafikon\"></body>";
                    File.WriteAllText(spath+"/munka.html", html);

                    string page = Path.Combine(spath, "munka.html");
                    wBro_1.Url = new Uri(String.Format("file:///" + page));
                    bt_print.Enabled = true;
                    bt_www.Enabled = true;
                    bt_pre.Enabled = true;
                    bt_svPDF.Enabled = true;
                }
            }

            
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            wBro_1.ShowPrintDialog();
        }

        private void bt_www_Click(object sender, EventArgs e)
        {
            string whtm = folderBrowserDialog1.SelectedPath + "/munka.html";
            if (File.Exists(whtm))
            {
                System.Diagnostics.Process.Start(whtm);
            }
        }

        private void bt_svPDF_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument1.PrinterSettings.PrintToFile = true;;
            printDocument1.Print();
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {
            wBro_1.ShowPrintPreviewDialog();
        }
    }
}
