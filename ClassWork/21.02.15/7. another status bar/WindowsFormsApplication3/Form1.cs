﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        StatusStrip status = new StatusStrip();
        Image img = Image.FromFile(@"1.jpg");

        ToolStripTextBox txt = new ToolStripTextBox();
        ToolStripComboBox cmb = new ToolStripComboBox();
        ToolStripDropDownButton ddb = new ToolStripDropDownButton();
        public Form1()
        {
            InitializeComponent();
            status.Parent = this;

            status.Items.Add("Hello toolstrip");
            status.Items.Add(new ToolStripSeparator());
            status.Items.Add(img);
            status.Items.Add(new ToolStripSeparator());
            status.Items.Add("<-Image", img);
            status.Items.Add(new ToolStripSeparator());
            status.Items.Add("<-Image", img, new EventHandler(StatusBarEventHandler));
            status.Items.Add(new ToolStripSeparator());
            status.Items.Add(txt);
            ToolStripButton btn = new ToolStripButton("Show");
            btn.Click += new EventHandler(btn_Click);
            status.Items.Add(btn);
            status.Items.Add(new ToolStripSeparator());
            cmb.Items.AddRange(new object[] { "one", "two", "three" });
            status.Items.Add(cmb);
            status.Items.Add(new ToolStripSeparator());
            ToolStripDropDown dd = new ToolStripDropDown();
            dd.Items.Add(new ToolStripButton("Red") { ForeColor = Color.Red });
            dd.Items.Add(new ToolStripButton("Green") { ForeColor = Color.Green });
            dd.Items.Add(new ToolStripButton("Wtf") { ForeColor = Color.GhostWhite });
            ddb.DropDown = dd;
            status.Items.Add(ddb);
            status.Items.Add(new ToolStripSeparator());
            status.Items.Add(new ToolStripSplitButton("Split") { DropDown = dd });
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt.Text);
            txt.BackColor = Color.Red;
        }

        public void StatusBarEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Handled");
        }

    }
}
