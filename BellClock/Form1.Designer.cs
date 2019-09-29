using System;
using System.Windows.Forms;

namespace BellClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeNow = new System.Windows.Forms.Label();
            this.dateNow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hourSelect = new System.Windows.Forms.NumericUpDown();
            this.minSelect = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSelect)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeNow
            // 
            resources.ApplyResources(this.timeNow, "timeNow");
            this.timeNow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeNow.Name = "timeNow";
            // 
            // dateNow
            // 
            resources.ApplyResources(this.dateNow, "dateNow");
            this.dateNow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateNow.Name = "dateNow";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeNow);
            this.groupBox1.Controls.Add(this.dateNow);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testBTN
            // 
            resources.ApplyResources(this.testBTN, "testBTN");
            this.testBTN.Name = "testBTN";
            this.testBTN.UseVisualStyleBackColor = true;
            this.testBTN.Click += new System.EventHandler(this.testBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // hourSelect
            // 
            resources.ApplyResources(this.hourSelect, "hourSelect");
            this.hourSelect.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourSelect.Name = "hourSelect";
            // 
            // minSelect
            // 
            resources.ApplyResources(this.minSelect, "minSelect");
            this.minSelect.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minSelect.Name = "minSelect";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.testBTN);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.minSelect);
            this.groupBox3.Controls.Add(this.hourSelect);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2"),
            resources.GetString("checkedListBox1.Items3"),
            resources.GetString("checkedListBox1.Items4"),
            resources.GetString("checkedListBox1.Items5")});
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hourSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSelect)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Label dateNow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button testBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private ListBox listBox1;
        private NumericUpDown hourSelect;
        private NumericUpDown minSelect;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}

