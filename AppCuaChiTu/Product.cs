using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuaChiTu
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Branch { get; set; }
        public decimal Price { get; set; }
        public bool IsAdventageLicense { get; set; }
        public double ForwardingBandwidth { get; set; }
        public double SwitchingBandwidth { get; set; }
        public double ForwardingCapacity { get; set; }
        public int RAM { get; set; }
        public int Flash { get; set; }
        public int Stackable { get; set; }
        public int Stack_Members { get; set; }
        public int Maximumnumberofunitsinavirtualchassis { get; set; }
        public int PoE_15_4WPort { get; set; }
        public int PoE_Plus_30W_Port { get; set; }
        public int UPOE_60W_Port { get; set; }
        public int HPOE_75_W_Port { get; set; }
        public int _95W_802_3bt_PoE { get; set; }
        public int _1GE_BaseT_Ports { get; set; }
        public int _1GE_BaseX_SFP_port { get; set; }
        public int _1G_SFP_plus_port_ { get; set; }
        public int RJ45_SFP_combo_1G { get; set; }
        public int _1G_10G_RJ45_SFP_combo { get; set; }
        public int _mgig_port_100M_1G_2_5G_5G { get; set; }
        public int _mgig_port_100M_1G_2_5G_5G_10G { get; set; }
        public int _mgig_port_1G_2_5G_BaseT { get; set; }
        public int _mgig_port_100M_1G_2_5G_BaseT { get; set; }
        public int _20G_QSFP_plus_stacking_ports { get; set; }
        public int _1G_SPF_port { get; set; }
        public int _1G_10G_SFP_plus_ { get; set; }
        public int _10_25G_SFP28 { get; set; }
        public int _10GE_SFP_plus_Ports { get; set; }
        public int _40GE_QSFP_plus_Ports { get; set; }
        public int _100GE_QSFP28_Ports { get; set; }
        public int _MAC_Address_Table { get; set; }
        public int _VLANs_ID { get; set; }
        public int _VLAN_active { get; set; }
        public int _VLAN_Interfaces_SVI_for_L3_Sw_ { get; set; }
        public double _Jumbo_Frame_Bytes_ { get; set; }
        public int _Total_number_of_IPv4_routes_ARP_plus_learned_routes_ { get; set; }
        public int _MAX_IPv4_routes { get; set; }
        public int _MAX_IPv6_routes { get; set; }
        public int _Multicast_groups { get; set; }
        public int _QoS_scale_entries { get; set; }
        public int _ACL_scale_entries { get; set; }
        public int _Flexible_NetFlow__FNF_entries { get; set; }
        public int _Power_Redundancy { get; set; }
        public bool Static_Routing { get; set; }
        public bool RIP { get; set; }
        public bool OSPF_Routed_Access { get; set; }
        public bool OSPF_Full { get; set; }
        public bool BGP { get; set; }
        public bool IS_IS { get; set; }
        public bool VXLAN { get; set; }
        public bool MACSec { get; set; }
        public bool MACSec_128_bit { get; set; }
        public bool MACSec_256_bit { get; set; }
        public bool PBR { get; set; }
        public bool Private_VLAN { get; set; }
        public bool VRRP { get; set; }
        public bool DAI { get; set; }
        public bool uRPF { get; set; }
        public bool _802_1x { get; set; }
        public bool SPAN_and_RSPAN { get; set; }
        public bool ERSPAN { get; set; }
        public bool EEM { get; set; }
        public bool Automation { get; set; }
    }
}
