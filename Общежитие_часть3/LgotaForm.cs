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
    public partial class LgotaForm : Form
    {
        public LgotaForm()
        {
            InitializeComponent();
        }

        private void LgotaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитие1DataSet.Lgota". При необходимости она может быть перемещена или удалена.
            this.lgotaTableAdapter.Fill(this.общежитие1DataSet.Lgota);

        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            lgotaTableAdapter.Update(общежитие1DataSet);
        }
    }
}
