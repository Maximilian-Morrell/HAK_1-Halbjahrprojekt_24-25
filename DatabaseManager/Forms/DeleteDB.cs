﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager.Forms
{
    public partial class DeleteDB : Form
    {
        public DeleteDB()
        {
            InitializeComponent();
        }

        public DeleteDB(List<string> DataBases)
        {
            InitializeComponent();
            UpdateDBs(DataBases);
        }

        public void UpdateDBs(List<string> DataBases)
        {
            comboBoxDataBase.Items.Clear();
            foreach (string Database in DataBases)
            {
                comboBoxDataBase.Items.Add(Database);
            }
        }
    }
}
