﻿namespace Общежитие_часть3
{
    partial class RoomsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.Update_button = new System.Windows.Forms.Button();
            this.Rooms_bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Rooms_dataGridView = new System.Windows.Forms.DataGridView();
            this.общежитие1DataSet = new Общежитие_часть3.Общежитие1DataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Общежитие_часть3.Общежитие1DataSetTableAdapters.RoomsTableAdapter();
            this.roomnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_bindingNavigator)).BeginInit();
            this.Rooms_bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитие1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_button.Location = new System.Drawing.Point(474, 172);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(150, 41);
            this.Update_button.TabIndex = 8;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Rooms_bindingNavigator
            // 
            this.Rooms_bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.Rooms_bindingNavigator.BindingSource = this.roomsBindingSource;
            this.Rooms_bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.Rooms_bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.Rooms_bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.Rooms_bindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rooms_bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Rooms_bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.Rooms_bindingNavigator.Location = new System.Drawing.Point(12, 169);
            this.Rooms_bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Rooms_bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Rooms_bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Rooms_bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Rooms_bindingNavigator.Name = "Rooms_bindingNavigator";
            this.Rooms_bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.Rooms_bindingNavigator.Size = new System.Drawing.Size(298, 31);
            this.Rooms_bindingNavigator.TabIndex = 7;
            this.Rooms_bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(72, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // Rooms_dataGridView
            // 
            this.Rooms_dataGridView.AutoGenerateColumns = false;
            this.Rooms_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rooms_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnDataGridViewTextBoxColumn,
            this.valuerDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.toolsDataGridViewTextBoxColumn,
            this.flourDataGridViewTextBoxColumn});
            this.Rooms_dataGridView.DataSource = this.roomsBindingSource;
            this.Rooms_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Rooms_dataGridView.Name = "Rooms_dataGridView";
            this.Rooms_dataGridView.RowTemplate.Height = 24;
            this.Rooms_dataGridView.Size = new System.Drawing.Size(751, 154);
            this.Rooms_dataGridView.TabIndex = 6;
            // 
            // общежитие1DataSet
            // 
            this.общежитие1DataSet.DataSetName = "Общежитие1DataSet";
            this.общежитие1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.общежитие1DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomnDataGridViewTextBoxColumn
            // 
            this.roomnDataGridViewTextBoxColumn.DataPropertyName = "Room_n";
            this.roomnDataGridViewTextBoxColumn.HeaderText = "Room_n";
            this.roomnDataGridViewTextBoxColumn.Name = "roomnDataGridViewTextBoxColumn";
            // 
            // valuerDataGridViewTextBoxColumn
            // 
            this.valuerDataGridViewTextBoxColumn.DataPropertyName = "Value_r";
            this.valuerDataGridViewTextBoxColumn.HeaderText = "Value_r";
            this.valuerDataGridViewTextBoxColumn.Name = "valuerDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // toolsDataGridViewTextBoxColumn
            // 
            this.toolsDataGridViewTextBoxColumn.DataPropertyName = "Tools";
            this.toolsDataGridViewTextBoxColumn.HeaderText = "Tools";
            this.toolsDataGridViewTextBoxColumn.Name = "toolsDataGridViewTextBoxColumn";
            // 
            // flourDataGridViewTextBoxColumn
            // 
            this.flourDataGridViewTextBoxColumn.DataPropertyName = "Flour";
            this.flourDataGridViewTextBoxColumn.HeaderText = "Flour";
            this.flourDataGridViewTextBoxColumn.Name = "flourDataGridViewTextBoxColumn";
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 225);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Rooms_bindingNavigator);
            this.Controls.Add(this.Rooms_dataGridView);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_bindingNavigator)).EndInit();
            this.Rooms_bindingNavigator.ResumeLayout(false);
            this.Rooms_bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитие1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.BindingNavigator Rooms_bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView Rooms_dataGridView;
        private Общежитие1DataSet общежитие1DataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Общежитие1DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flourDataGridViewTextBoxColumn;
    }
}