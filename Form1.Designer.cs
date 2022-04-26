
namespace Formapp_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ch_st1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.lb_out = new System.Windows.Forms.ListBox();
            this.cb_menu = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_saves = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.wBro_1 = new System.Windows.Forms.WebBrowser();
            this.pBar_pro = new System.Windows.Forms.ProgressBar();
            this.dtP_beDate = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bt_pre = new System.Windows.Forms.Button();
            this.bt_svPDF = new System.Windows.Forms.Button();
            this.bt_www = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ch_st1)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_st1
            // 
            chartArea5.Name = "ChartArea1";
            this.ch_st1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ch_st1.Legends.Add(legend5);
            this.ch_st1.Location = new System.Drawing.Point(488, 39);
            this.ch_st1.Name = "ch_st1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ch_st1.Series.Add(series5);
            this.ch_st1.Size = new System.Drawing.Size(300, 166);
            this.ch_st1.TabIndex = 0;
            this.ch_st1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ügyfél:";
            // 
            // la_name
            // 
            this.la_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.la_name.Location = new System.Drawing.Point(9, 63);
            this.la_name.Name = "la_name";
            this.la_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.la_name.Size = new System.Drawing.Size(194, 18);
            this.la_name.TabIndex = 3;
            // 
            // lb_out
            // 
            this.lb_out.FormattingEnabled = true;
            this.lb_out.Items.AddRange(new object[] {
            "<ures>"});
            this.lb_out.Location = new System.Drawing.Point(362, 39);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(120, 160);
            this.lb_out.TabIndex = 4;
            // 
            // cb_menu
            // 
            this.cb_menu.FormattingEnabled = true;
            this.cb_menu.Items.AddRange(new object[] {
            "internet",
            "televizio",
            "telefon"});
            this.cb_menu.Location = new System.Drawing.Point(12, 111);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(120, 49);
            this.cb_menu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szolgáltatások:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bt_sub
            // 
            this.bt_sub.Location = new System.Drawing.Point(12, 215);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(191, 23);
            this.bt_sub.TabIndex = 7;
            this.bt_sub.Text = "submit";
            this.bt_sub.UseVisualStyleBackColor = true;
            this.bt_sub.Click += new System.EventHandler(this.bt_sub_Click);
            // 
            // bt_saves
            // 
            this.bt_saves.Location = new System.Drawing.Point(12, 368);
            this.bt_saves.Name = "bt_saves";
            this.bt_saves.Size = new System.Drawing.Size(237, 20);
            this.bt_saves.TabIndex = 8;
            this.bt_saves.Text = "mentés";
            this.bt_saves.UseVisualStyleBackColor = true;
            this.bt_saves.Click += new System.EventHandler(this.bt_saves_Click);
            // 
            // bt_print
            // 
            this.bt_print.Location = new System.Drawing.Point(12, 397);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(237, 20);
            this.bt_print.TabIndex = 9;
            this.bt_print.Text = "nyomtatás";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // wBro_1
            // 
            this.wBro_1.Location = new System.Drawing.Point(362, 215);
            this.wBro_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBro_1.Name = "wBro_1";
            this.wBro_1.Size = new System.Drawing.Size(426, 250);
            this.wBro_1.TabIndex = 10;
            // 
            // pBar_pro
            // 
            this.pBar_pro.Location = new System.Drawing.Point(12, 7);
            this.pBar_pro.Name = "pBar_pro";
            this.pBar_pro.Size = new System.Drawing.Size(776, 23);
            this.pBar_pro.TabIndex = 11;
            this.pBar_pro.Click += new System.EventHandler(this.pBar_pro_Click);
            // 
            // dtP_beDate
            // 
            this.dtP_beDate.Location = new System.Drawing.Point(12, 166);
            this.dtP_beDate.Name = "dtP_beDate";
            this.dtP_beDate.Size = new System.Drawing.Size(191, 20);
            this.dtP_beDate.TabIndex = 12;
            // 
            // bt_pre
            // 
            this.bt_pre.Location = new System.Drawing.Point(12, 423);
            this.bt_pre.Name = "bt_pre";
            this.bt_pre.Size = new System.Drawing.Size(75, 23);
            this.bt_pre.TabIndex = 13;
            this.bt_pre.Text = "Preview";
            this.bt_pre.UseVisualStyleBackColor = true;
            this.bt_pre.Click += new System.EventHandler(this.bt_pre_Click);
            // 
            // bt_svPDF
            // 
            this.bt_svPDF.Location = new System.Drawing.Point(93, 423);
            this.bt_svPDF.Name = "bt_svPDF";
            this.bt_svPDF.Size = new System.Drawing.Size(75, 23);
            this.bt_svPDF.TabIndex = 14;
            this.bt_svPDF.Text = "PDF";
            this.bt_svPDF.UseVisualStyleBackColor = true;
            this.bt_svPDF.Click += new System.EventHandler(this.bt_svPDF_Click);
            // 
            // bt_www
            // 
            this.bt_www.Location = new System.Drawing.Point(174, 423);
            this.bt_www.Name = "bt_www";
            this.bt_www.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_www.Size = new System.Drawing.Size(75, 23);
            this.bt_www.TabIndex = 15;
            this.bt_www.Text = "WEB";
            this.bt_www.UseVisualStyleBackColor = true;
            this.bt_www.Click += new System.EventHandler(this.bt_www_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.bt_www);
            this.Controls.Add(this.bt_svPDF);
            this.Controls.Add(this.bt_pre);
            this.Controls.Add(this.dtP_beDate);
            this.Controls.Add(this.pBar_pro);
            this.Controls.Add(this.wBro_1);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_saves);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_menu);
            this.Controls.Add(this.lb_out);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ch_st1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_st1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_st1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.ListBox lb_out;
        private System.Windows.Forms.CheckedListBox cb_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_saves;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.WebBrowser wBro_1;
        private System.Windows.Forms.ProgressBar pBar_pro;
        private System.Windows.Forms.DateTimePicker dtP_beDate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button bt_pre;
        private System.Windows.Forms.Button bt_svPDF;
        private System.Windows.Forms.Button bt_www;
    }
}

