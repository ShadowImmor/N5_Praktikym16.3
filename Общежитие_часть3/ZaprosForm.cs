using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие_часть3
{
    public partial class ZaprosForm : Form
    {
        public ZaprosForm()
        {
            InitializeComponent();
        }
        private void Do_button_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\..\\Общежитие1.accdb");
            sqlconn.Open();
            string s = "";
            if (FullInf_radioButton.Checked) { s = "SELECT * FROM Students"; }
            if (ShortInf_radioButton.Checked) { s = "SELECT SNP, GROUP FROM Students"; }
            if (InObch_radioButton.Checked) { s = "SELECT DISTINCT GROUP FROM Students"; }
            if (In3Flour_radioButton.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
            if (InPO_radioButton.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
            OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            Info_dataGridView.DataSource = dt;
            sqlconn.Close();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            int count = Info_dataGridView.Columns.Count;
            for (int i = 0; i < count; i++)
                Info_dataGridView.Columns.RemoveAt(0);
        }
    }
}
