using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.All_User_Control
{
    public partial class Uc_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public Uc_AddRoom()
        {
            InitializeComponent();
        }

        private void Uc_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query); 
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomNo.Text !="" && txtType.Text !="" && txtBed.Text !="" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = " INSERT INTO rooms (roomNo,roomtype,bed,price) VALUES ('"+roomno+"', '"+type+"', '"+bed+"',"+price+")";
                fn.setData(query, "Room Added.");
                Uc_AddRoom_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
;            }
        }
        public void ClearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void Uc_AddRoom_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Uc_AddRoom_Enter(object sender, EventArgs e)
        {
            Uc_AddRoom_Load(this, null);
        }
    }
}
