﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие_часть3
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Общежитие1DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.StudentsTableAdapter.Fill(this.Общежитие1DataSet.Students);

            this.reportViewer1.RefreshReport();
        }
    }
}
