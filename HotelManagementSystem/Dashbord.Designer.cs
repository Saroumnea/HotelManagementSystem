namespace HotelManagementSystem
{
    partial class Dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.MovingPanel3 = new System.Windows.Forms.Panel();
            this.btnCustomerRegistration = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCustomerDetail = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.uc_CustomerDetails1 = new HotelManagementSystem.All_User_Control.Uc_CustomerDetails();
            this.uC_CustomerCheckOut1 = new HotelManagementSystem.All_User_Control.UC_CustomerCheckOut();
            this.uc_CustomerRegistration1 = new HotelManagementSystem.All_User_Control.Uc_CustomerRegistration();
            this.uc_AddRoom1 = new HotelManagementSystem.All_User_Control.Uc_AddRoom();
            this.uc_Employee1 = new HotelManagementSystem.All_User_Control.Uc_Employee();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(57, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Teal;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Teal;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.Location = new System.Drawing.Point(1, 60);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(57, 41);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_Employee1);
            this.panel2.Controls.Add(this.uc_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uc_CustomerRegistration1);
            this.panel2.Controls.Add(this.uc_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 505);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.MovingPanel3);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(57, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 4;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.Location = new System.Drawing.Point(12, 22);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(209, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click_1);
            // 
            // MovingPanel3
            // 
            this.MovingPanel3.BackColor = System.Drawing.Color.Fuchsia;
            this.MovingPanel3.Location = new System.Drawing.Point(12, 113);
            this.MovingPanel3.Name = "MovingPanel3";
            this.MovingPanel3.Size = new System.Drawing.Size(195, 5);
            this.MovingPanel3.TabIndex = 3;
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCustomerRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
            this.btnCustomerRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerRegistration.Location = new System.Drawing.Point(227, 22);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(287, 85);
            this.btnCustomerRegistration.TabIndex = 4;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.UseVisualStyleBackColor = false;
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(520, 22);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(244, 85);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCustomerDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
            this.btnCustomerDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerDetail.Location = new System.Drawing.Point(770, 23);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(252, 85);
            this.btnCustomerDetail.TabIndex = 5;
            this.btnCustomerDetail.Text = "Customer Details";
            this.btnCustomerDetail.UseVisualStyleBackColor = false;
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(1028, 22);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(209, 85);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
            // 
            // uc_CustomerDetails1
            // 
            this.uc_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uc_CustomerDetails1.Name = "uc_CustomerDetails1";
            this.uc_CustomerDetails1.Size = new System.Drawing.Size(1298, 502);
            this.uc_CustomerDetails1.TabIndex = 3;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(-1, 0);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1295, 502);
            this.uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uc_CustomerRegistration1
            // 
            this.uc_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerRegistration1.Location = new System.Drawing.Point(0, 0);
            this.uc_CustomerRegistration1.Name = "uc_CustomerRegistration1";
            this.uc_CustomerRegistration1.Size = new System.Drawing.Size(1297, 516);
            this.uc_CustomerRegistration1.TabIndex = 1;
            // 
            // uc_AddRoom1
            // 
            this.uc_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uc_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uc_AddRoom1.Name = "uc_AddRoom1";
            this.uc_AddRoom1.Size = new System.Drawing.Size(1297, 583);
            this.uc_AddRoom1.TabIndex = 0;
            // 
            // uc_Employee1
            // 
            this.uc_Employee1.BackColor = System.Drawing.Color.White;
            this.uc_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uc_Employee1.Name = "uc_Employee1";
            this.uc_Employee1.Size = new System.Drawing.Size(1298, 502);
            this.uc_Employee1.TabIndex = 4;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private All_User_Control.Uc_AddRoom uc_AddRoom1;
        private All_User_Control.Uc_CustomerDetails uc_CustomerDetails1;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private All_User_Control.Uc_CustomerRegistration uc_CustomerRegistration1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCustomerRegistration;
        private System.Windows.Forms.Panel MovingPanel3;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomerDetail;
        private All_User_Control.Uc_Employee uc_Employee1;
    }
}