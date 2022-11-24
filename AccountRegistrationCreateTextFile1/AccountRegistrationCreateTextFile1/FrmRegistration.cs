using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountRegistrationCreateTextFile1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StreamWriter writer1;
            writer1 = File.CreateText(txtFile.Text);
            string data1 = txtStudentNo.Text;
            string data2 = txtLastName.Text;
            string data3 = txtAge.Text;
            string data4 = txtBirthday.Text;
            string data5 = txtProgram.Text;
            string data6 = txtFirstName.Text;
            string data7 = txtGender.Text;
            string data8 = txtContactNo.Text;
            string data9 = txtMiddleName.Text;
            writer1.WriteLine(data1);
            writer1.WriteLine(data2);
            writer1.WriteLine(data3);
            writer1.WriteLine(data4);
            writer1.WriteLine(data5);
            writer1.WriteLine(data6);
            writer1.WriteLine(data7);
            writer1.WriteLine(data8);
            writer1.WriteLine(data9);
            writer1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.ShowDialog();
        }
    }
}
