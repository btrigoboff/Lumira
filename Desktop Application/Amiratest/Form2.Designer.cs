
namespace Amiratest
{
    partial class Form2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "6"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "7"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "8"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "9"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            this.listView1 = new System.Windows.Forms.ListView();
            this.testSlotColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serNumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sense5VColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sense1P8VColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led0Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led3Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led4Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led5Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.led6Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtrAfwdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtrArevColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtrBfwdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtrBrevColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.testSlotColumn,
            this.serNumColumn,
            this.devIDColumn,
            this.sense5VColumn,
            this.sense1P8VColumn,
            this.led0Column,
            this.led1Column,
            this.led2Column,
            this.led3Column,
            this.led4Column,
            this.led5Column,
            this.led6Column,
            this.mtrAfwdColumn,
            this.mtrArevColumn,
            this.mtrBfwdColumn,
            this.mtrBrevColumn});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1684, 221);
            this.listView1.TabIndex = 11;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // testSlotColumn
            // 
            this.testSlotColumn.Text = "Test Slot";
            this.testSlotColumn.Width = 62;
            // 
            // serNumColumn
            // 
            this.serNumColumn.Tag = "";
            this.serNumColumn.Text = "Serial Number";
            this.serNumColumn.Width = 100;
            // 
            // devIDColumn
            // 
            this.devIDColumn.Text = "Test Hardware Device ID";
            this.devIDColumn.Width = 151;
            // 
            // sense5VColumn
            // 
            this.sense5VColumn.Text = "5.0V Power Rail (Volts)";
            this.sense5VColumn.Width = 138;
            // 
            // sense1P8VColumn
            // 
            this.sense1P8VColumn.Text = "1.8V Power Rail (Volts)";
            this.sense1P8VColumn.Width = 140;
            // 
            // led0Column
            // 
            this.led0Column.Text = "LED0";
            // 
            // led1Column
            // 
            this.led1Column.Text = "LED1";
            // 
            // led2Column
            // 
            this.led2Column.Text = "LED2";
            // 
            // led3Column
            // 
            this.led3Column.Text = "LED3";
            // 
            // led4Column
            // 
            this.led4Column.Text = "LED4";
            // 
            // led5Column
            // 
            this.led5Column.Text = "LED5";
            // 
            // led6Column
            // 
            this.led6Column.Text = "LED6";
            // 
            // mtrAfwdColumn
            // 
            this.mtrAfwdColumn.Text = "Motor A Forward Current (A)";
            this.mtrAfwdColumn.Width = 164;
            // 
            // mtrArevColumn
            // 
            this.mtrArevColumn.Text = "Motor A Reverse Current (A)";
            this.mtrArevColumn.Width = 164;
            // 
            // mtrBfwdColumn
            // 
            this.mtrBfwdColumn.Text = "Motor B Forward Current (A)";
            this.mtrBfwdColumn.Width = 164;
            // 
            // mtrBrevColumn
            // 
            this.mtrBrevColumn.Text = "Motor B Reverse Current (A)";
            this.mtrBrevColumn.Width = 164;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1684, 221);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader testSlotColumn;
        private System.Windows.Forms.ColumnHeader serNumColumn;
        private System.Windows.Forms.ColumnHeader devIDColumn;
        private System.Windows.Forms.ColumnHeader sense5VColumn;
        private System.Windows.Forms.ColumnHeader sense1P8VColumn;
        private System.Windows.Forms.ColumnHeader led0Column;
        private System.Windows.Forms.ColumnHeader led1Column;
        private System.Windows.Forms.ColumnHeader led2Column;
        private System.Windows.Forms.ColumnHeader led3Column;
        private System.Windows.Forms.ColumnHeader led4Column;
        private System.Windows.Forms.ColumnHeader led5Column;
        private System.Windows.Forms.ColumnHeader led6Column;
        private System.Windows.Forms.ColumnHeader mtrAfwdColumn;
        private System.Windows.Forms.ColumnHeader mtrArevColumn;
        private System.Windows.Forms.ColumnHeader mtrBfwdColumn;
        private System.Windows.Forms.ColumnHeader mtrBrevColumn;
    }
}