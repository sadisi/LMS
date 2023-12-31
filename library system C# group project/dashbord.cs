﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_system_C__group_project
{
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook abs = new AddBook();
            abs.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast =new AddStudent();
            ast.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vsi =new ViewStudentInformation();
            vsi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ib =new IssueBooks();
            ib.Show();

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook =new ReturnBook();
            returnBook.Show();
        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd =new CompleteBookDetails();
            cbd.Show();
        }
    }
}
