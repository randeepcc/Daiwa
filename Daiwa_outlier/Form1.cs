using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daiwa_outlier
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                loadData(openFileDialog1.FileName);
            }
        }

        public void loadData(string filename)
        {
            try
            {
                string CSVFilePathName = filename;
                string[] Lines = File.ReadAllLines(CSVFilePathName);
                string[] Fields;
                Fields = Lines[0].Split(new char[] { ',' });
                int Cols = Fields.GetLength(0);
                dt = new DataTable();

                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Price", typeof(double));

                DataRow Row;
                for (int i = 1; i < Lines.GetLength(0); i++)
                {
                    Fields = Lines[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
                dGrid.DataSource = dt;

                //calculating average, sum and Standard deviation
                double avg = (double)dt.Compute("AVG([Price])", "");
                double sum = (double)dt.Compute("SUM([Price])", "");
                double STD = (double)dt.Compute("STDEV([Price])", "");

                Double Outlier_ = 0;
                //finding out outlier and setting to form text box : using formula
                foreach (DataRow row in dt.Rows)
                {
                    string type = ((Math.Abs((double)row["Price"]) - avg) > (2 * STD)) ? "OUTLIER" : "NORMAL";
                    if (type == "OUTLIER" && Outlier_ < (double)row["Price"])
                    {
                        txt_formula.Text = row["Price"].ToString();
                        Outlier_ = (double)row["Price"];
                    }
                }

                //finding out outlier and setting to form text box : using last day record in chronological order
                double outlier = 0;
                double outlier_limit = 0;

                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        var row = dt.Rows[i];
                        var prev_row = dt.Rows[i - 1];
                        if (Math.Abs((double)row["Price"] - (double)prev_row["Price"]) > outlier_limit)
                        {
                            double row_price = Math.Abs((double)row["Price"]) - avg;
                            double prev_row_price = Math.Abs((double)prev_row["Price"] - avg);

                            outlier = (double)row["Price"];
                            outlier_limit = Math.Abs((double)row["Price"] - (double)prev_row["Price"]);
                        }
                    }
                }
                txt_history.Text = outlier.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Removing formula calculated outlier value from grid
            if (txt_formula.Text != "")
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr["Price"].ToString() == txt_formula.Text)
                        dr.Delete();
                }
                dt.AcceptChanges();
                dGrid.DataSource = dt;
                txt_formula.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Removing  calculated outlier value from grid
            if (txt_history.Text != "")
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr["Price"].ToString() == txt_history.Text)
                        dr.Delete();
                }
                dt.AcceptChanges();
                dGrid.DataSource = dt;
                txt_history.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}
