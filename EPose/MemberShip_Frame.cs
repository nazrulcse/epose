using EPose.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public partial class MemberShip_Frame : Layout_Frame
    {
        public MemberShip_Frame()
        {
            InitializeComponent();
           
            this.setTitle("Membership Window");
            this.ActiveControl = textBoxMobile;
        }

        private void MemberShip_Frame_Load(object sender, EventArgs e)
        {
            this.memberList.CurrentCell.Selected = false;
           
           // this.textBoxMobile.Focus();
        }

       
        private void txtMembership_TextChanged(object sender, EventArgs e)
        {
            String mobile = textBoxMobile.Text;

            if (mobile == "")
            {
                memberList.Rows.Clear();
            }

            MemberShipModel member = new MemberShipModel();
            dynamic members = member.where(member, "mobile like '%" + mobile + "%'");
            if (members.Count > 0)
            {

                memberList.Rows.Clear();
                String status = "In Active";
                foreach (var mem in members)
                {
                    if( mem.is_active)
                    {
                      status = "Active";
                    }
                    memberList.Rows.Add(mem.id, mem.name, mem.email, mem.mobile, mem.adress, mem.point, status);
                }
            }
        }

       
    }
}
