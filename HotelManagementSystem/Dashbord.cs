using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            uc_Employee1.Visible = false;
            uc_AddRoom1.Visible = false; // call visible uc room if false not show 
            uc_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //used for viewing cutomize code
            this.WindowState = FormWindowState.Minimized; 
        }
        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            MovingPanel3.Left = btnAddRoom.Left;
            uc_AddRoom1.Visible = true;
            uc_AddRoom1.BringToFront();
        }
        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel3.Left=btnCustomerRegistration.Left+30;
            uc_CustomerRegistration1.Visible = true;
            uc_CustomerRegistration1.BringToFront();
        }
        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            MovingPanel3.Left = btnCheckOut.Left + 20;
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }
        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            MovingPanel3.Left = btnCustomerDetail.Left + 25;
            uc_CustomerDetails1.Visible = true;
            uc_CustomerDetails1.BringToFront();
        }
        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            MovingPanel3.Left = btnEmployee.Left + 20;
            uc_Employee1.Visible = true;
            uc_Employee1.BringToFront();
        }
    }
}
