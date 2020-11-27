﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class TeacherMainScreenForm : Form
    {
        AddMaterialForm addQuestionForm = new AddMaterialForm();
        ChangeMaterialForm changeMaterialForm = new ChangeMaterialForm();
        DeleteMaterialForm deleteMaterialForm = new DeleteMaterialForm();
        

        internal static TeacherMainScreenForm teacherMainScreenForm = new TeacherMainScreenForm();
        public TeacherMainScreenForm()
        {
            InitializeComponent();

        }

        private void TeacherMainScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void TeacherMainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createQuestionButton_Click(object sender, EventArgs e)
        {
            addQuestionForm.ShowDialog();
        }

        private void changeQuestionButton_Click(object sender, EventArgs e)
        {
            changeMaterialForm.ShowDialog();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            deleteMaterialForm.ShowDialog();
        }
    }
}
