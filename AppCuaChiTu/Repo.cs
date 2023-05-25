using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuaChiTu
{
    public class Repo
    {
        string connectionString = "Data Source=D:/mydb.sqlite;Version=3;";
        SQLiteConnection connection;
        string sql;
        SQLiteCommand command;
        SQLiteDataReader reader;
        public void AddRecord(Product p)
        {

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                sql = "INSERT INTO Product (" +
                        "name, " +
                        "Branch, " +
                        "Maximumnumberofunitsinavirtualchassis, " +
                        "_mgig_port_100M_1G_2_5G_BaseT, " +
                        "_1G_SFP_plus_port_, " +
                        "_MAX_IPv6_routes, " +
                        "_100GE_QSFP28_Ports, " +
                        "_Multicast_groups, " +
                        "_MAC_Address_Table, " +
                        "_20G_QSFP_plus_, " +
                        "RJ45_SFP_combo_1G, " +
                        "PoE_15_4WPort, " +
                        "ForwardingBandwidth, " +
                        "_ACL_scale_entries, " +
                        "_VLAN_active, " +
                        "_1G_SPF_port, " +
                        "_mgig_port_100M_1G_2_5G_5G, " +
                        "UPOE_60W_Port, " +
                        "ForwardingCapacity, " +
                        "_QoS_scale_entries, " +
                        "_VLANs_ID, " +
                        "_stacking_ports, " +
                        "_1G_10G_RJ45_SFP_combo, " +
                        "PoE_Plus_30W_Port, " +
                        "SwitchingBandwidth, " +
                        "_MAX_IPv4_routes, " +
                        "_40GE_QSFP_plus_Ports, " +
                        "_1GE_BaseX_SFP_port, " +
                        "Stack_Members, " +
                        "_Total_number_of_IPv4_routes_ARP_plus_learned_routes_, " +
                        "_10GE_SFP_plus_Ports, " +
                        "_1GE_BaseT_Ports, " +
                        "Stackable, " +
                        "_Power_Redundancy, " +
                        "_Jumbo_Frame_Bytes_, " +
                        "_10_25G_SFP28, " +
                        "_mgig_port_1G_2_5G_BaseT, " +
                        "_95W_802_3bt_PoE, " +
                        "Flash, " +
                        "_VLAN_Interfaces_SVI_for_L3_Sw_, " +
                        "_1G_10G_SFP_plus_, " +
                        "_mgig_port_100M_1G_2_5G_5G_10G, " +
                        "HPOE_75_W_Port, " +
                        "RAM, " +
                        "_Flexible_NetFlow__FNF_entries, " +
                        "IsAdventageLicense, " +
                        "RIP, " +
                        "MACSec, " +
                        "BGP, " +
                        "VRRP, " +
                        "SPAN_and_RSPAN, " +
                        "ERSPAN, " +
                        "DAI, " +
                        "IS_IS, " +
                        "MACSec_128_bit, " +
                        "Static_Routing, " +
                        "EEM, " +
                        "uRPF, " +
                        "VXLAN, " +
                        "MACSec_256_bit, " +
                        "OSPF_Routed_Access, " +
                        "Automation, " +
                        "_802_1x, " +
                        "PBR, " +
                        "Private_VLAN, " +
                        "OSPF_Full) " +
                    "VALUES (" +
                        "@name, " +
                        "@Branch, " +
                        "@Maximumnumberofunitsinavirtualchassis, " +
                        "@_mgig_port_100M_1G_2_5G_BaseT, " +
                        "@_1G_SFP_plus_port_, " +
                        "@_MAX_IPv6_routes, " +
                        "@_100GE_QSFP28_Ports, " +
                        "@_Multicast_groups, " +
                        "@_MAC_Address_Table, " +
                        "@_20G_QSFP_plus_, " +
                        "@RJ45_SFP_combo_1G, " +
                        "@PoE_15_4WPort, " +
                        "@ForwardingBandwidth, " +
                        "@_ACL_scale_entries, " +
                        "@_VLAN_active, " +
                        "@_1G_SPF_port, " +
                        "@_mgig_port_100M_1G_2_5G_5G, " +
                        "@UPOE_60W_Port, " +
                        "@ForwardingCapacity, " +
                        "@_QoS_scale_entries, " +
                        "@_VLANs_ID, " +
                        "@_stacking_ports, " +
                        "@_1G_10G_RJ45_SFP_combo, " +
                        "@PoE_Plus_30W_Port, " +
                        "@SwitchingBandwidth, " +
                        "@_MAX_IPv4_routes, " +
                        "@_40GE_QSFP_plus_Ports, " +
                        "@_1GE_BaseX_SFP_port, " +
                        "@Stack_Members, " +
                        "@_Total_number_of_IPv4_routes_ARP_plus_learned_routes_, " +
                        "@_10GE_SFP_plus_Ports, " +
                        "@_1GE_BaseT_Ports, " +
                        "@Stackable, " +
                        "@_Power_Redundancy, " +
                        "@_Jumbo_Frame_Bytes_, " +
                        "@_10_25G_SFP28, " +
                        "@_mgig_port_1G_2_5G_BaseT, " +
                        "@_95W_802_3bt_PoE, " +
                        "@Flash, " +
                        "@_VLAN_Interfaces_SVI_for_L3_Sw_, " +
                        "@_1G_10G_SFP_plus_, " +
                        "@_mgig_port_100M_1G_2_5G_5G_10G, " +
                        "@HPOE_75_W_Port, " +
                        "@RAM, " +
                        "@_Flexible_NetFlow__FNF_entries, " +
                        "@IsAdventageLicense, " +
                        "@RIP, " +
                        "@MACSec, " +
                        "@BGP, " +
                        "@VRRP, " +
                        "@SPAN_and_RSPAN, " +
                        "@ERSPAN, " +
                        "@DAI, " +
                        "@IS_IS, " +
                        "@MACSec_128_bit, " +
                        "@Static_Routing, " +
                        "@EEM, " +
                        "@uRPF, " +
                        "@VXLAN, " +
                        "@MACSec_256_bit, " +
                        "@OSPF_Routed_Access, " +
                        "@Automation, " +
                        "@_802_1x, " +
                        "@PBR, " +
                        "@Private_VLAN, " +
                        "@OSPF_Full " + ");";
                using (command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", p.name);
                    command.Parameters.AddWithValue("@Branch", p.Branch);
                    command.Parameters.AddWithValue("@Maximumnumberofunitsinavirtualchassis", p.Maximumnumberofunitsinavirtualchassis);
                    command.Parameters.AddWithValue("@_mgig_port_100M_1G_2_5G_BaseT", p._mgig_port_100M_1G_2_5G_BaseT);
                    command.Parameters.AddWithValue("@_1G_SFP_plus_port_", p._1G_SFP_plus_port_);
                    command.Parameters.AddWithValue("@_MAX_IPv6_routes", p._MAX_IPv6_routes);
                    command.Parameters.AddWithValue("@_100GE_QSFP28_Ports", p._100GE_QSFP28_Ports);
                    command.Parameters.AddWithValue("@_Multicast_groups", p._Multicast_groups);
                    command.Parameters.AddWithValue("@_MAC_Address_Table", p._MAC_Address_Table);
                    command.Parameters.AddWithValue("@_20G_QSFP_plus_", p._20G_QSFP_plus_);
                    command.Parameters.AddWithValue("@RJ45_SFP_combo_1G", p.RJ45_SFP_combo_1G);
                    command.Parameters.AddWithValue("@PoE_15_4WPort", p.PoE_15_4WPort);
                    command.Parameters.AddWithValue("@ForwardingBandwidth", p.ForwardingBandwidth);
                    command.Parameters.AddWithValue("@_ACL_scale_entries", p._ACL_scale_entries);
                    command.Parameters.AddWithValue("@_VLAN_active", p._VLAN_active);
                    command.Parameters.AddWithValue("@_1G_SPF_port", p._1G_SPF_port);
                    command.Parameters.AddWithValue("@_mgig_port_100M_1G_2_5G_5G", p._mgig_port_100M_1G_2_5G_5G);
                    command.Parameters.AddWithValue("@UPOE_60W_Port", p.UPOE_60W_Port);
                    command.Parameters.AddWithValue("@ForwardingCapacity", p.ForwardingCapacity);
                    command.Parameters.AddWithValue("@_QoS_scale_entries", p._QoS_scale_entries);
                    command.Parameters.AddWithValue("@_VLANs_ID", p._VLANs_ID);
                    command.Parameters.AddWithValue("@_stacking_ports", p._stacking_ports);
                    command.Parameters.AddWithValue("@_1G_10G_RJ45_SFP_combo", p._1G_10G_RJ45_SFP_combo);
                    command.Parameters.AddWithValue("@PoE_Plus_30W_Port", p.PoE_Plus_30W_Port);
                    command.Parameters.AddWithValue("@SwitchingBandwidth", p.SwitchingBandwidth);
                    command.Parameters.AddWithValue("@_MAX_IPv4_routes", p._MAX_IPv4_routes);
                    command.Parameters.AddWithValue("@_40GE_QSFP_plus_Ports", p._40GE_QSFP_plus_Ports);
                    command.Parameters.AddWithValue("@_1GE_BaseX_SFP_port", p._1GE_BaseX_SFP_port);
                    command.Parameters.AddWithValue("@Stack_Members", p.Stack_Members);
                    command.Parameters.AddWithValue("@_Total_number_of_IPv4_routes_ARP_plus_learned_routes_", p._Total_number_of_IPv4_routes_ARP_plus_learned_routes_);
                    command.Parameters.AddWithValue("@_10GE_SFP_plus_Ports", p._10GE_SFP_plus_Ports);
                    command.Parameters.AddWithValue("@_1GE_BaseT_Ports", p._1GE_BaseT_Ports);
                    command.Parameters.AddWithValue("@Stackable", p.Stackable);
                    command.Parameters.AddWithValue("@_Power_Redundancy", p._Power_Redundancy);
                    command.Parameters.AddWithValue("@_Jumbo_Frame_Bytes_", p._Jumbo_Frame_Bytes_);
                    command.Parameters.AddWithValue("@_10_25G_SFP28", p._10_25G_SFP28);
                    command.Parameters.AddWithValue("@_mgig_port_1G_2_5G_BaseT", p._mgig_port_1G_2_5G_BaseT);
                    command.Parameters.AddWithValue("@_95W_802_3bt_PoE", p._95W_802_3bt_PoE);
                    command.Parameters.AddWithValue("@Flash", p.Flash);
                    command.Parameters.AddWithValue("@_VLAN_Interfaces_SVI_for_L3_Sw_", p._VLAN_Interfaces_SVI_for_L3_Sw_);
                    command.Parameters.AddWithValue("@_1G_10G_SFP_plus_", p._1G_10G_SFP_plus_);
                    command.Parameters.AddWithValue("@_mgig_port_100M_1G_2_5G_5G_10G", p._mgig_port_100M_1G_2_5G_5G_10G);
                    command.Parameters.AddWithValue("@HPOE_75_W_Port", p.HPOE_75_W_Port);
                    command.Parameters.AddWithValue("@RAM", p.RAM);
                    command.Parameters.AddWithValue("@_Flexible_NetFlow__FNF_entries", p._Flexible_NetFlow__FNF_entries);
                    command.Parameters.AddWithValue("@IsAdventageLicense", p.IsAdventageLicense);
                    command.Parameters.AddWithValue("@RIP", p.RIP);
                    command.Parameters.AddWithValue("@MACSec", p.MACSec);
                    command.Parameters.AddWithValue("@BGP", p.BGP);
                    command.Parameters.AddWithValue("@VRRP", p.VRRP);
                    command.Parameters.AddWithValue("@SPAN_and_RSPAN", p.SPAN_and_RSPAN);
                    command.Parameters.AddWithValue("@ERSPAN", p.ERSPAN);
                    command.Parameters.AddWithValue("@DAI", p.DAI);
                    command.Parameters.AddWithValue("@IS_IS", p.IS_IS);
                    command.Parameters.AddWithValue("@MACSec_128_bit", p.MACSec_128_bit);
                    command.Parameters.AddWithValue("@Static_Routing", p.Static_Routing);
                    command.Parameters.AddWithValue("@EEM", p.EEM);
                    command.Parameters.AddWithValue("@uRPF", p.uRPF);
                    command.Parameters.AddWithValue("@VXLAN", p.VXLAN);
                    command.Parameters.AddWithValue("@MACSec_256_bit", p.MACSec_256_bit);
                    command.Parameters.AddWithValue("@OSPF_Routed_Access", p.OSPF_Routed_Access);
                    command.Parameters.AddWithValue("@Automation", p.Automation);
                    command.Parameters.AddWithValue("@_802_1x", p._802_1x);
                    command.Parameters.AddWithValue("@PBR", p.PBR);
                    command.Parameters.AddWithValue("@Private_VLAN", p.Private_VLAN);
                    command.Parameters.AddWithValue("@OSPF_Full", p.OSPF_Full);

                    command.ExecuteNonQuery();
                }
            }
        }
        public Repo()
        {

        }
    }
}
