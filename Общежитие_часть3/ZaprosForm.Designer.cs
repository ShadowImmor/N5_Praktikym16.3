namespace Общежитие_часть3
{
    partial class ZaprosForm
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
            this.Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Do_button = new System.Windows.Forms.Button();
            this.SelectZapr_groupBox = new System.Windows.Forms.GroupBox();
            this.InPO_radioButton = new System.Windows.Forms.RadioButton();
            this.In3Flour_radioButton = new System.Windows.Forms.RadioButton();
            this.InObch_radioButton = new System.Windows.Forms.RadioButton();
            this.ShortInf_radioButton = new System.Windows.Forms.RadioButton();
            this.FullInf_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Info_dataGridView)).BeginInit();
            this.SelectZapr_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info_dataGridView
            // 
            this.Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Info_dataGridView.Location = new System.Drawing.Point(30, 257);
            this.Info_dataGridView.Name = "Info_dataGridView";
            this.Info_dataGridView.RowTemplate.Height = 24;
            this.Info_dataGridView.Size = new System.Drawing.Size(1231, 251);
            this.Info_dataGridView.TabIndex = 7;
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(984, 31);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(179, 64);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Do_button
            // 
            this.Do_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Do_button.Location = new System.Drawing.Point(706, 31);
            this.Do_button.Name = "Do_button";
            this.Do_button.Size = new System.Drawing.Size(226, 64);
            this.Do_button.TabIndex = 5;
            this.Do_button.Text = "Выполнить запрос";
            this.Do_button.UseVisualStyleBackColor = true;
            this.Do_button.Click += new System.EventHandler(this.Do_button_Click);
            // 
            // SelectZapr_groupBox
            // 
            this.SelectZapr_groupBox.Controls.Add(this.InPO_radioButton);
            this.SelectZapr_groupBox.Controls.Add(this.In3Flour_radioButton);
            this.SelectZapr_groupBox.Controls.Add(this.InObch_radioButton);
            this.SelectZapr_groupBox.Controls.Add(this.ShortInf_radioButton);
            this.SelectZapr_groupBox.Controls.Add(this.FullInf_radioButton);
            this.SelectZapr_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectZapr_groupBox.Location = new System.Drawing.Point(30, 18);
            this.SelectZapr_groupBox.Name = "SelectZapr_groupBox";
            this.SelectZapr_groupBox.Size = new System.Drawing.Size(636, 232);
            this.SelectZapr_groupBox.TabIndex = 4;
            this.SelectZapr_groupBox.TabStop = false;
            this.SelectZapr_groupBox.Text = "Выберите запрос";
            // 
            // InPO_radioButton
            // 
            this.InPO_radioButton.AutoSize = true;
            this.InPO_radioButton.Location = new System.Drawing.Point(7, 170);
            this.InPO_radioButton.Name = "InPO_radioButton";
            this.InPO_radioButton.Size = new System.Drawing.Size(453, 29);
            this.InPO_radioButton.TabIndex = 4;
            this.InPO_radioButton.TabStop = true;
            this.InPO_radioButton.Text = "Список студентов, обучающихся в группе ПО";
            this.InPO_radioButton.UseVisualStyleBackColor = true;
            // 
            // In3Flour_radioButton
            // 
            this.In3Flour_radioButton.AutoSize = true;
            this.In3Flour_radioButton.Location = new System.Drawing.Point(7, 135);
            this.In3Flour_radioButton.Name = "In3Flour_radioButton";
            this.In3Flour_radioButton.Size = new System.Drawing.Size(396, 29);
            this.In3Flour_radioButton.TabIndex = 3;
            this.In3Flour_radioButton.TabStop = true;
            this.In3Flour_radioButton.Text = "№ комнат, расположенных на 3 этаже";
            this.In3Flour_radioButton.UseVisualStyleBackColor = true;
            // 
            // InObch_radioButton
            // 
            this.InObch_radioButton.AutoSize = true;
            this.InObch_radioButton.Location = new System.Drawing.Point(7, 100);
            this.InObch_radioButton.Name = "InObch_radioButton";
            this.InObch_radioButton.Size = new System.Drawing.Size(584, 29);
            this.InObch_radioButton.TabIndex = 2;
            this.InObch_radioButton.TabStop = true;
            this.InObch_radioButton.Text = "Список групп, студенты которых проживают в общежитии";
            this.InObch_radioButton.UseVisualStyleBackColor = true;
            // 
            // ShortInf_radioButton
            // 
            this.ShortInf_radioButton.AutoSize = true;
            this.ShortInf_radioButton.Location = new System.Drawing.Point(7, 65);
            this.ShortInf_radioButton.Name = "ShortInf_radioButton";
            this.ShortInf_radioButton.Size = new System.Drawing.Size(493, 29);
            this.ShortInf_radioButton.TabIndex = 1;
            this.ShortInf_radioButton.TabStop = true;
            this.ShortInf_radioButton.Text = "Краткая информация о студентах (ФИО, группа)";
            this.ShortInf_radioButton.UseVisualStyleBackColor = true;
            // 
            // FullInf_radioButton
            // 
            this.FullInf_radioButton.AutoSize = true;
            this.FullInf_radioButton.Checked = true;
            this.FullInf_radioButton.Location = new System.Drawing.Point(7, 30);
            this.FullInf_radioButton.Name = "FullInf_radioButton";
            this.FullInf_radioButton.Size = new System.Drawing.Size(349, 29);
            this.FullInf_radioButton.TabIndex = 0;
            this.FullInf_radioButton.TabStop = true;
            this.FullInf_radioButton.Text = "Полная информация о студентах";
            this.FullInf_radioButton.UseVisualStyleBackColor = true;
            // 
            // ZaprosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 523);
            this.Controls.Add(this.Info_dataGridView);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Do_button);
            this.Controls.Add(this.SelectZapr_groupBox);
            this.Name = "ZaprosForm";
            this.Text = "ZaprosForm";
            ((System.ComponentModel.ISupportInitialize)(this.Info_dataGridView)).EndInit();
            this.SelectZapr_groupBox.ResumeLayout(false);
            this.SelectZapr_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Info_dataGridView;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Do_button;
        private System.Windows.Forms.GroupBox SelectZapr_groupBox;
        private System.Windows.Forms.RadioButton InPO_radioButton;
        private System.Windows.Forms.RadioButton In3Flour_radioButton;
        private System.Windows.Forms.RadioButton InObch_radioButton;
        private System.Windows.Forms.RadioButton ShortInf_radioButton;
        private System.Windows.Forms.RadioButton FullInf_radioButton;
    }
}