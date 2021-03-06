﻿using EPose.Model;
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
        double total_price;
        dynamic invoice;
        public MemberShip_Frame(dynamic invoice = null)
        {
            InitializeComponent();
            this.ActiveControl = textBoxMobile;
            this.setTitle("Membership Window");
            this.invoice = invoice;
            if (this.invoice != null) {
                this.total_price = this.invoice.invoice_total;
            }
            
        }

        private void MemberShip_Frame_Load(object sender, EventArgs e)
        {
            DepartmentSettings.getData();  
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
                    memberList.Rows.Add(mem.id, mem.name, mem.email, mem.mobile, mem.address, Math.Round(mem.point,2), status);
                }
            }
            else
            {
                memberList.Rows.Clear();
            }
        }

        private void textBoxMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                memberList.Rows[0].Selected = true;
                memberList.Focus();
            }
        }
        private void memberList_SelectionChanged(object sender, EventArgs e)
        {
            int SelectedRow = memberList.CurrentCell.RowIndex;
            dynamic cellValue = memberList.Rows[SelectedRow].Cells["Point"].Value;
            String point = Convert.ToString(cellValue);
            pointLabel.Text = point;
        }

        private void memberList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.invoice != null)
            {
                int SelectedRow = memberList.SelectedRows[0].Index;
                dynamic cellValue = memberList.Rows[SelectedRow].Cells["Point"].Value;

                    if (memberList.SelectedRows[0].Index < memberList.Rows.Count - 1)
                    {
                        DialogResult result = MessageDialog.Show("Membership Selection!", " Do you want to select this member?", "member");
                        if (result == DialogResult.Yes)
                        {
                            double point = Convert.ToDouble(Convert.ToString(cellValue));
                            double sumOfPoint = point + (total_price / 100);

                            dynamic cellValueOfId = memberList.Rows[SelectedRow].Cells["Id"].Value;
                            String id = Convert.ToString(cellValueOfId);

                            MemberShipModel memberShipModel = new MemberShipModel();
                            memberShipModel.update_attributeForSingleRow(memberShipModel, "point", sumOfPoint, id);
                            memberShipModel.update_attributeForSingleRow(memberShipModel, "last_point", point, id);
                            this.invoice.point = sumOfPoint;
                            this.invoice.lastPoint = point;
                            
                            ActivityLogModel log = new ActivityLogModel();
                            log.model = "membership";
                            log.action = "update";
                            log.date = DateTime.Now.ToString("yyyy-MM-dd");
                            log.ref_id = id;
                            log.department_id = DepartmentSettings.DepartmentId;
                            log.create(log);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("please select a row");
                    }
            }
        }

        private void textBoxMobile_Enter(object sender, EventArgs e)
        {
            changeColor(textBoxMobile, "enter");
        }

        private void textBoxMobile_Leave(object sender, EventArgs e)
        {
            changeColor(textBoxMobile, "out");
        }
    }
}
