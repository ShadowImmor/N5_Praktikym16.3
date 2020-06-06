using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Text = "Комнаты";
            try
            {
                roomsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Lgots_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LgotaForm lgotaForm = new LgotaForm();
            lgotaForm.Text = "Льготы";
            try
            {
                lgotaForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Students_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Text = "Студенты";
            try
            {
                studentsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Rasselenie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm rasselenieForm = new RasselenieForm();
            rasselenieForm.Text = "Рассиление";
            try
            {
                rasselenieForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Zapr_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaprosForm zaprosForm = new ZaprosForm();
            zaprosForm.Text = "Запрос";
            try
            {
                zaprosForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Otch_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Text = "Отчёты";
            try
            {
                otchet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
