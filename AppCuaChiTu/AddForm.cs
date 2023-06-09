﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCuaChiTu
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Repo repo = new Repo();
            Product p = new Product();
            int temp = -1;
            decimal tempDecimal = -1;
            bool tempStatus = false;
            p.Branch = Branch.Text.Trim();
            p.name = name.Text.Trim();

            tempStatus = decimal.TryParse(Price.Text.Trim(), out tempDecimal);
            p.Price = (tempStatus ? tempDecimal : -1);

            tempStatus = int.TryParse(Maximumnumberofunitsinavirtualchassis.Text.Trim(), out temp);
            p.Maximumnumberofunitsinavirtualchassis = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_mgig_port_100M_1G_2_5G_BaseT.Text.Trim(), out temp);
            p._mgig_port_100M_1G_2_5G_BaseT = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1G_SFP_plus_port_.Text.Trim(), out temp);
            p._1G_SFP_plus_port_ = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_MAX_IPv6_routes.Text.Trim(), out temp);
            p._MAX_IPv6_routes = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_100GE_QSFP28_Ports.Text.Trim(), out temp);
            p._100GE_QSFP28_Ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_Multicast_groups.Text.Trim(), out temp);
            p._Multicast_groups = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(RJ45_SFP_combo_1G.Text.Trim(), out temp);
            p.RJ45_SFP_combo_1G = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(PoE_15_4WPort.Text.Trim(), out temp);
            p.PoE_15_4WPort = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_MAC_Address_Table.Text.Trim(), out temp);
            p._MAC_Address_Table = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_20G_QSFP_plus_.Text.Trim(), out temp);
            p._20G_QSFP_plus_stacking_ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(ForwardingBandwidth.Text.Trim(), out temp);
            p.ForwardingBandwidth = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_ACL_scale_entries.Text.Trim(), out temp);
            p._ACL_scale_entries = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_VLAN_active.Text.Trim(), out temp);
            p._VLAN_active = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1G_SPF_port.Text.Trim(), out temp);
            p._1G_SPF_port = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_mgig_port_100M_1G_2_5G_5G.Text.Trim(), out temp);
            p._mgig_port_100M_1G_2_5G_5G = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(UPOE_60W_Port.Text.Trim(), out temp);
            p.UPOE_60W_Port = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(ForwardingCapacity.Text.Trim(), out temp);
            p.ForwardingCapacity = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_QoS_scale_entries.Text.Trim(), out temp);
            p._QoS_scale_entries = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_VLANs_ID.Text.Trim(), out temp);
            p._VLANs_ID = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_20G_QSFP_plus_stacking_ports.Text.Trim(), out temp);
            p._20G_QSFP_plus_stacking_ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1G_10G_RJ45_SFP_combo.Text.Trim(), out temp);
            p._1G_10G_RJ45_SFP_combo = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(PoE_Plus_30W_Port.Text.Trim(), out temp);
            p.PoE_Plus_30W_Port = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(SwitchingBandwidth.Text.Trim(), out temp);
            p.SwitchingBandwidth = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_MAX_IPv4_routes.Text.Trim(), out temp);
            p._MAX_IPv4_routes = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1GE_BaseX_SFP_port.Text.Trim(), out temp);
            p._1GE_BaseX_SFP_port = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(Stack_Members.Text.Trim(), out temp);
            p.Stack_Members = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_Total_number_of_IPv4_routes_ARP_plus_learned_routes_.Text.Trim(), out temp);
            p._Total_number_of_IPv4_routes_ARP_plus_learned_routes_ = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_40GE_QSFP_plus_Ports.Text.Trim(), out temp);
            p._40GE_QSFP_plus_Ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_10GE_SFP_plus_Ports.Text.Trim(), out temp);
            p._10GE_SFP_plus_Ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1GE_BaseT_Ports.Text.Trim(), out temp);
            p._1GE_BaseT_Ports = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(Stackable.Text.Trim(), out temp);
            p.Stackable = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_Power_Redundancy.Text.Trim(), out temp);
            p._Power_Redundancy = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_Jumbo_Frame_Bytes_.Text.Trim(), out temp);
            p._Jumbo_Frame_Bytes_ = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_10_25G_SFP28.Text.Trim(), out temp);
            p._10_25G_SFP28 = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_mgig_port_1G_2_5G_BaseT.Text.Trim(), out temp);
            p._mgig_port_1G_2_5G_BaseT = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_95W_802_3bt_PoE.Text.Trim(), out temp);
            p._95W_802_3bt_PoE = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(Flash.Text.Trim(), out temp);
            p.Flash = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_VLAN_Interfaces_SVI_for_L3_Sw_.Text.Trim(), out temp);
            p._VLAN_Interfaces_SVI_for_L3_Sw_ = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_1G_10G_SFP_plus_.Text.Trim(), out temp);
            p._1G_10G_SFP_plus_ = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_mgig_port_100M_1G_2_5G_5G_10G.Text.Trim(), out temp);
            p._mgig_port_100M_1G_2_5G_5G_10G = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(HPOE_75_W_Port.Text.Trim(), out temp);
            p.HPOE_75_W_Port = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(RAM.Text.Trim(), out temp);
            p.RAM = (tempStatus ? temp : -1);

            tempStatus = int.TryParse(_Flexible_NetFlow__FNF_entries.Text.Trim(), out temp);
            p._Flexible_NetFlow__FNF_entries = (tempStatus ? temp : -1);


            p.RIP = RIP.Checked ? 1 : 0;
            p.MACSec = MACSec.Checked ? 1 : 0;
            p.BGP = BGP.Checked ? 1 : 0;
            p.VRRP = VRRP.Checked ? 1 : 0;
            p.SPAN_and_RSPAN = SPAN_and_RSPAN.Checked ? 1 : 0;
            p.ERSPAN = ERSPAN.Checked ? 1 : 0;
            p.DAI = DAI.Checked ? 1 : 0;
            p.IS_IS = IS_IS.Checked ? 1 : 0;
            p.MACSec_128_bit = MACSec_128_bit.Checked ? 1 : 0;
            p.Static_Routing = Static_Routing.Checked ? 1 : 0;
            p.EEM = EEM.Checked ? 1 : 0;
            p.uRPF = uRPF.Checked ? 1 : 0;
            p.VXLAN = VXLAN.Checked ? 1 : 0;
            p.MACSec_256_bit = MACSec_256_bit.Checked ? 1 : 0;
            p.OSPF_Routed_Access = OSPF_Routed_Access.Checked ? 1 : 0;
            p.Automation = Automation.Checked ? 1 : 0;
            p._802_1x = _802_1x.Checked ? 1 : 0;
            p.PBR = PBR.Checked ? 1 : 0;
            p.Private_VLAN = Private_VLAN.Checked ? 1 : 0;
            p.OSPF_Full = OSPF_Full.Checked ? 1 : 0;
            p.IsAdvantageLicense = radbutAdv.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(p.name))
            {
                alert.Text = "Name không được để trống";
                return;
            }

            if (string.IsNullOrEmpty(p.Branch))
            {
                alert.Text = "Branch không được để trống";
                return;
            }

            if (p.Price == -1)
            {
                alert.Text = "Price nhập sai, nếu chưa có dữ liệu này hãy để -2";
                return;
            }
            alert.Text = "";

            try
            {
                repo.AddRecord(p);
                alert.Text = "Thêm dữ liệu thành công";


            }
            catch (Exception ex)
            {
                alert.Text = ex.Message;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            name.Text = "";
            Branch.Text = "";
            Maximumnumberofunitsinavirtualchassis.Text = "";
            _mgig_port_100M_1G_2_5G_BaseT.Text = "";
            _1G_SFP_plus_port_.Text = "";
            _MAX_IPv6_routes.Text = "";
            _100GE_QSFP28_Ports.Text = "";
            _Multicast_groups.Text = "";
            _MAC_Address_Table.Text = "";
            _20G_QSFP_plus_.Text = "";
            RJ45_SFP_combo_1G.Text = "";
            PoE_15_4WPort.Text = "";
            ForwardingBandwidth.Text = "";
            _ACL_scale_entries.Text = "";
            _VLAN_active.Text = "";
            _1G_SPF_port.Text = "";
            _mgig_port_100M_1G_2_5G_5G.Text = "";
            UPOE_60W_Port.Text = "";
            ForwardingCapacity.Text = "";
            _QoS_scale_entries.Text = "";
            _VLANs_ID.Text = "";
            _20G_QSFP_plus_stacking_ports.Text = "";
            _1G_10G_RJ45_SFP_combo.Text = "";
            PoE_Plus_30W_Port.Text = "";
            SwitchingBandwidth.Text = "";
            _MAX_IPv4_routes.Text = "";
            _40GE_QSFP_plus_Ports.Text = "";
            _1GE_BaseX_SFP_port.Text = "";
            Stack_Members.Text = "";
            _Total_number_of_IPv4_routes_ARP_plus_learned_routes_.Text = "";
            _10GE_SFP_plus_Ports.Text = "";
            _1GE_BaseT_Ports.Text = "";
            Stackable.Text = "";
            _Power_Redundancy.Text = "";
            _Jumbo_Frame_Bytes_.Text = "";
            _10_25G_SFP28.Text = "";
            _mgig_port_1G_2_5G_BaseT.Text = "";
            _95W_802_3bt_PoE.Text = "";
            Flash.Text = "";
            _VLAN_Interfaces_SVI_for_L3_Sw_.Text = "";
            _1G_10G_SFP_plus_.Text = "";
            _mgig_port_100M_1G_2_5G_5G_10G.Text = "";
            HPOE_75_W_Port.Text = "";
            RAM.Text = "";
            _Flexible_NetFlow__FNF_entries.Text = "";
            radbutAdv.Checked =false;
            radbutEssential.Checked =false;
            RIP.Checked =false;
            MACSec.Checked =false;
            BGP.Checked =false;
            VRRP.Checked =false;
            SPAN_and_RSPAN.Checked =false;
            ERSPAN.Checked =false;
            DAI.Checked =false;
            IS_IS.Checked =false;
            MACSec_128_bit.Checked =false;
            Static_Routing.Checked =false;
            EEM.Checked =false;
            uRPF.Checked =false;
            VXLAN.Checked =false;
            MACSec_256_bit.Checked =false;
            OSPF_Routed_Access.Checked =false;
            Automation.Checked =false;
            _802_1x.Checked =false;
            PBR.Checked =false;
            Private_VLAN.Checked =false;
            OSPF_Full.Checked =false;

            alert.Text = "";
        }
    }
}
