using System;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
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


            p.RIP = RIP.SelectedIndex;
            p.MACSec = MACSec.SelectedIndex;
            p.BGP = BGP.SelectedIndex;
            p.VRRP = VRRP.SelectedIndex;
            p.SPAN_and_RSPAN = SPAN_and_RSPAN.SelectedIndex;
            p.ERSPAN = ERSPAN.SelectedIndex;
            p.DAI = DAI.SelectedIndex;
            p.IS_IS = IS_IS.SelectedIndex;
            p.MACSec_128_bit = MACSec_128_bit.SelectedIndex;
            p.Static_Routing = Static_Routing.SelectedIndex;
            p.EEM = EEM.SelectedIndex;
            p.uRPF = uRPF.SelectedIndex;
            p.VXLAN = VXLAN.SelectedIndex;
            p.MACSec_256_bit = MACSec_256_bit.SelectedIndex;
            p.OSPF_Routed_Access = OSPF_Routed_Access.SelectedIndex;
            p.Automation = Automation.SelectedIndex;
            p._802_1x = _802_1x.SelectedIndex;
            p.PBR = PBR.SelectedIndex;
            p.Private_VLAN = Private_VLAN.SelectedIndex;
            p.OSPF_Full = OSPF_Full.SelectedIndex;
            p.IsAdvantageLicense = IsAdvantageLicense.SelectedIndex;

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

        
        private void button1_Click(object sender, EventArgs e)
        {
            string _name= name.Text;
            string _Branch = Branch.Text;
            string _Price = Price.Text;
            string _IsAdvantageLicense = IsAdvantageLicense.SelectedIndex.ToString();
            string _ForwardingBandwidth = ForwardingBandwidth.Text;
            string _SwitchingBandwidth = SwitchingBandwidth.Text;
            string _ForwardingCapacity = ForwardingCapacity.Text;
            string _RAM = RAM.Text;
            string _Flash = Flash.Text;
            string _Stackable = Stackable.Text;
            string _Stack_Members = Stack_Members.Text;
            string _Maximumnumberofunitsinavirtualchassis = Maximumnumberofunitsinavirtualchassis.Text;
            string _PoE_15_4WPort = PoE_15_4WPort.Text;
            string _PoE_Plus_30W_Port = PoE_Plus_30W_Port.Text;
            string _UPOE_60W_Port = UPOE_60W_Port.Text;
            string _HPOE_75_W_Port = HPOE_75_W_Port.Text;
            string __95W_802_3bt_PoE = _95W_802_3bt_PoE.Text;
            string __1GE_BaseT_Ports = _1GE_BaseT_Ports.Text;
            string __1GE_BaseX_SFP_port = _1GE_BaseX_SFP_port.Text;
            string __1G_SFP_plus_port_ = _1G_SFP_plus_port_.Text;
            string _RJ45_SFP_combo_1G = RJ45_SFP_combo_1G.Text;
            string __1G_10G_RJ45_SFP_combo = _1G_10G_RJ45_SFP_combo.Text;
            string __mgig_port_100M_1G_2_5G_5G = _mgig_port_100M_1G_2_5G_5G.Text;
            string __mgig_port_100M_1G_2_5G_5G_10G = _mgig_port_100M_1G_2_5G_5G_10G.Text;
            string __mgig_port_1G_2_5G_BaseT = _mgig_port_1G_2_5G_BaseT.Text;
            string __mgig_port_100M_1G_2_5G_BaseT = _mgig_port_100M_1G_2_5G_BaseT.Text;
            string __20G_QSFP_plus_stacking_ports = _20G_QSFP_plus_stacking_ports.Text;
            string __1G_SPF_port = _1G_SPF_port.Text;
            string __1G_10G_SFP_plus_ = _1G_10G_SFP_plus_.Text;
            string __10_25G_SFP28 = _10_25G_SFP28.Text;
            string __10GE_SFP_plus_Ports = _10GE_SFP_plus_Ports.Text;
            string __40GE_QSFP_plus_Ports = _40GE_QSFP_plus_Ports.Text;
            string __100GE_QSFP28_Ports = _100GE_QSFP28_Ports.Text;
            string __MAC_Address_Table = _MAC_Address_Table.Text;
            string __VLANs_ID = _VLANs_ID.Text;
            string __VLAN_active = _VLAN_active.Text;
            string __VLAN_Interfaces_SVI_for_L3_Sw_ = _VLAN_Interfaces_SVI_for_L3_Sw_.Text;
            string __Jumbo_Frame_Bytes_ = _Jumbo_Frame_Bytes_.Text;
            string __Total_number_of_IPv4_routes_ARP_plus_learned_routes_ = _Total_number_of_IPv4_routes_ARP_plus_learned_routes_.Text;
            string __MAX_IPv4_routes = _MAX_IPv4_routes.Text;
            string __MAX_IPv6_routes = _MAX_IPv6_routes.Text;
            string __Multicast_groups = _Multicast_groups.Text;
            string __QoS_scale_entries = _QoS_scale_entries.Text;
            string __ACL_scale_entries = _ACL_scale_entries.Text;
            string __Flexible_NetFlow__FNF_entries = _Flexible_NetFlow__FNF_entries.Text;
            string __Power_Redundancy = _Power_Redundancy.Text;
            string _Static_Routing = Static_Routing.SelectedIndex.ToString();
            string _RIP = RIP.SelectedIndex.ToString();
            string _OSPF_Routed_Access = OSPF_Routed_Access.SelectedIndex.ToString();
            string _OSPF_Full = OSPF_Full.SelectedIndex.ToString();
            string _BGP = BGP.SelectedIndex.ToString();
            string _IS_IS = IS_IS.SelectedIndex.ToString();
            string _VXLAN = VXLAN.SelectedIndex.ToString();
            string _MACSec = MACSec.SelectedIndex.ToString();
            string _MACSec_128_bit = MACSec_128_bit.SelectedIndex.ToString();
            string _MACSec_256_bit = MACSec_256_bit.SelectedIndex.ToString();
            string _PBR = PBR.SelectedIndex.ToString();
            string _Private_VLAN = Private_VLAN.SelectedIndex.ToString();
            string _VRRP = VRRP.SelectedIndex.ToString();
            string _DAI = DAI.SelectedIndex.ToString();
            string _uRPF = uRPF.SelectedIndex.ToString();
            string __802_1x = _802_1x.SelectedIndex.ToString();
            string _SPAN_and_RSPAN = SPAN_and_RSPAN.SelectedIndex.ToString();
            string _ERSPAN = ERSPAN.SelectedIndex.ToString();
            string _EEM = EEM.SelectedIndex.ToString();
            string _Automation = Automation.SelectedIndex.ToString();

            Repo repo = new Repo();
            Product p = repo.Search(_name,
                                    _Branch,
                                    _Price, 
                                    _IsAdvantageLicense,
                                    _ForwardingBandwidth,
                                    _SwitchingBandwidth,
                                    _ForwardingCapacity,
                                    _RAM,
                                    _Flash,
                                    _Stackable,
                                    _Stack_Members,
                                    _Maximumnumberofunitsinavirtualchassis,
                                    _PoE_15_4WPort,
                                    _PoE_Plus_30W_Port,
                                    _UPOE_60W_Port,
                                    _HPOE_75_W_Port,
                                    __95W_802_3bt_PoE,
                                    __1GE_BaseT_Ports,
                                    __1GE_BaseX_SFP_port,
                                    __1G_SFP_plus_port_,
                                    _RJ45_SFP_combo_1G,
                                    __1G_10G_RJ45_SFP_combo,
                                    __mgig_port_100M_1G_2_5G_5G,
                                    __mgig_port_100M_1G_2_5G_5G_10G,
                                    __mgig_port_1G_2_5G_BaseT,
                                    __mgig_port_100M_1G_2_5G_BaseT,
                                    __20G_QSFP_plus_stacking_ports,
                                    __1G_SPF_port,
                                    __1G_10G_SFP_plus_,
                                    __10_25G_SFP28,
                                    __10GE_SFP_plus_Ports,
                                    __40GE_QSFP_plus_Ports,
                                    __100GE_QSFP28_Ports,
                                    __MAC_Address_Table,
                                    __VLANs_ID,
                                    __VLAN_active,
                                    __VLAN_Interfaces_SVI_for_L3_Sw_,
                                    __Jumbo_Frame_Bytes_,
                                    __Total_number_of_IPv4_routes_ARP_plus_learned_routes_,
                                    __MAX_IPv4_routes,
                                    __MAX_IPv6_routes,
                                    __Multicast_groups,
                                    __QoS_scale_entries,
                                    __ACL_scale_entries,
                                    __Flexible_NetFlow__FNF_entries,
                                    __Power_Redundancy,
                                    _Static_Routing,
                                    _RIP,
                                    _OSPF_Routed_Access,
                                    _OSPF_Full,
                                    _BGP,
                                    _IS_IS,
                                    _VXLAN,
                                    _MACSec,
                                    _MACSec_128_bit,
                                    _MACSec_256_bit,
                                    _PBR,
                                    _Private_VLAN,
                                    _VRRP,
                                    _DAI,
                                    _uRPF,
                                    __802_1x,
                                    _SPAN_and_RSPAN,
                                    _ERSPAN,
                                    _EEM,
                                    _Automation);
            if (p == null) MessageBox.Show("Không có sản phẩm thỏa mãn");
            else
                MessageBox.Show($"id:{p.id} \nname:{p.name}\nBranch:{p.Branch}");
        }

        private void RIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
