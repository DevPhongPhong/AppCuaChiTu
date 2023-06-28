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
                        "Price, " +
                        "IsAdvantageLicense, " +
                        "ForwardingBandwidth, " +
                        "SwitchingBandwidth, " +
                        "ForwardingCapacity, " +
                        "RAM, " +
                        "Flash, " +
                        "Stackable, " +
                        "Stack_Members, " +
                        "Maximumnumberofunitsinavirtualchassis, " +
                        "PoE_15_4WPort, " +
                        "PoE_Plus_30W_Port, " +
                        "UPOE_60W_Port, " +
                        "HPOE_75_W_Port, " +
                        "_95W_802_3bt_PoE, " +
                        "_1GE_BaseT_Ports, " +
                        "_1GE_BaseX_SFP_port, " +
                        "_1G_SFP_plus_port_, " +
                        "RJ45_SFP_combo_1G, " +
                        "_1G_10G_RJ45_SFP_combo, " +
                        "_mgig_port_100M_1G_2_5G_5G, " +
                        "_mgig_port_100M_1G_2_5G_5G_10G, " +
                        "_mgig_port_1G_2_5G_BaseT, " +
                        "_mgig_port_100M_1G_2_5G_BaseT, " +
                        "_20G_QSFP_plus_stacking_ports, " +
                        "_1G_SPF_port, " +
                        "_1G_10G_SFP_plus_, " +
                        "_10_25G_SFP28, " +
                        "_10GE_SFP_plus_Ports, " +
                        "_40GE_QSFP_plus_Ports, " +
                        "_100GE_QSFP28_Ports, " +
                        "_MAC_Address_Table, " +
                        "_VLANs_ID, " +
                        "_VLAN_active, " +
                        "_VLAN_Interfaces_SVI_for_L3_Sw_, " +
                        "_Jumbo_Frame_Bytes_, " +
                        "_Total_number_of_IPv4_routes_ARP_plus_learned_routes_, " +
                        "_MAX_IPv4_routes, " +
                        "_MAX_IPv6_routes, " +
                        "_Multicast_groups, " +
                        "_QoS_scale_entries, " +
                        "_ACL_scale_entries, " +
                        "_Flexible_NetFlow__FNF_entries, " +
                        "_Power_Redundancy, " +
                        "Static_Routing, " +
                        "RIP, " +
                        "OSPF_Routed_Access, " +
                        "OSPF_Full, " +
                        "BGP, " +
                        "IS_IS, " +
                        "VXLAN, " +
                        "MACSec, " +
                        "MACSec_128_bit, " +
                        "MACSec_256_bit, " +
                        "PBR, " +
                        "Private_VLAN, " +
                        "VRRP, " +
                        "DAI, " +
                        "uRPF, " +
                        "_802_1x, " +
                        "SPAN_and_RSPAN, " +
                        "ERSPAN, " +
                        "EEM, " +
                        "Automation) " +
                    "VALUES (" +
                        "@name, " +
                        "@Branch, " +
                        "@Price, " +
                        "@IsAdvantageLicense, " +
                        "@ForwardingBandwidth, " +
                        "@SwitchingBandwidth, " +
                        "@ForwardingCapacity, " +
                        "@RAM, " +
                        "@Flash, " +
                        "@Stackable, " +
                        "@Stack_Members, " +
                        "@Maximumnumberofunitsinavirtualchassis, " +
                        "@PoE_15_4WPort, " +
                        "@PoE_Plus_30W_Port, " +
                        "@UPOE_60W_Port, " +
                        "@HPOE_75_W_Port, " +
                        "@_95W_802_3bt_PoE, " +
                        "@_1GE_BaseT_Ports, " +
                        "@_1GE_BaseX_SFP_port, " +
                        "@_1G_SFP_plus_port_, " +
                        "@RJ45_SFP_combo_1G, " +
                        "@_1G_10G_RJ45_SFP_combo, " +
                        "@_mgig_port_100M_1G_2_5G_5G, " +
                        "@_mgig_port_100M_1G_2_5G_5G_10G, " +
                        "@_mgig_port_1G_2_5G_BaseT, " +
                        "@_mgig_port_100M_1G_2_5G_BaseT, " +
                        "@_20G_QSFP_plus_stacking_ports, " +
                        "@_1G_SPF_port, " +
                        "@_1G_10G_SFP_plus_, " +
                        "@_10_25G_SFP28, " +
                        "@_10GE_SFP_plus_Ports, " +
                        "@_40GE_QSFP_plus_Ports, " +
                        "@_100GE_QSFP28_Ports, " +
                        "@_MAC_Address_Table, " +
                        "@_VLANs_ID, " +
                        "@_VLAN_active, " +
                        "@_VLAN_Interfaces_SVI_for_L3_Sw_, " +
                        "@_Jumbo_Frame_Bytes_, " +
                        "@_Total_number_of_IPv4_routes_ARP_plus_learned_routes_, " +
                        "@_MAX_IPv4_routes, " +
                        "@_MAX_IPv6_routes, " +
                        "@_Multicast_groups, " +
                        "@_QoS_scale_entries, " +
                        "@_ACL_scale_entries, " +
                        "@_Flexible_NetFlow__FNF_entries, " +
                        "@_Power_Redundancy, " +
                        "@Static_Routing, " +
                        "@RIP, " +
                        "@OSPF_Routed_Access, " +
                        "@OSPF_Full, " +
                        "@BGP, " +
                        "@IS_IS, " +
                        "@VXLAN, " +
                        "@MACSec, " +
                        "@MACSec_128_bit, " +
                        "@MACSec_256_bit, " +
                        "@PBR, " +
                        "@Private_VLAN, " +
                        "@VRRP, " +
                        "@DAI, " +
                        "@uRPF, " +
                        "@_802_1x, " +
                        "@SPAN_and_RSPAN, " +
                        "@ERSPAN, " +
                        "@EEM, " +
                        "@Automation); ";
                using (command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", p.name);
                    command.Parameters.AddWithValue("@Branch", p.Branch);
                    command.Parameters.AddWithValue("@Price", p.Price);
                    command.Parameters.AddWithValue("@Maximumnumberofunitsinavirtualchassis", p.Maximumnumberofunitsinavirtualchassis);
                    command.Parameters.AddWithValue("@_mgig_port_100M_1G_2_5G_BaseT", p._mgig_port_100M_1G_2_5G_BaseT);
                    command.Parameters.AddWithValue("@_1G_SFP_plus_port_", p._1G_SFP_plus_port_);
                    command.Parameters.AddWithValue("@_MAX_IPv6_routes", p._MAX_IPv6_routes);
                    command.Parameters.AddWithValue("@_100GE_QSFP28_Ports", p._100GE_QSFP28_Ports);
                    command.Parameters.AddWithValue("@_Multicast_groups", p._Multicast_groups);
                    command.Parameters.AddWithValue("@_MAC_Address_Table", p._MAC_Address_Table);
                    command.Parameters.AddWithValue("@_20G_QSFP_plus_", p._20G_QSFP_plus_stacking_ports);
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
                    command.Parameters.AddWithValue("@_20G_QSFP_plus_stacking_ports", p._20G_QSFP_plus_stacking_ports);
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
                    command.Parameters.AddWithValue("@IsAdvantageLicense", p.IsAdvantageLicense);
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

        public List<Product> Gets()
        {
            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                sql = "SELECT * FROM Product ;";
                using (command = new SQLiteCommand(sql, connection))
                {
                    while (true)
                    {
                        try
                        {
                            reader = command.ExecuteReader();
                            break;
                        }
                        catch (SQLiteException e)
                        {
                            CreateSqliteDbExtension.Create();
                        }
                    }
                    if (reader == null) return null;
                    List<Product> products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(setObj(reader));
                    }

                    return products;
                }
            }
        }

        public Product Search(string name,
                                 string Branch,
                                 string Price,
                                 string IsAdvantageLicense,
                                 string ForwardingBandwidth,
                                 string SwitchingBandwidth,
                                 string ForwardingCapacity,
                                 string RAM,
                                 string Flash,
                                 string Stackable,
                                 string Stack_Members,
                                 string Maximumnumberofunitsinavirtualchassis,
                                 string PoE_15_4WPort,
                                 string PoE_Plus_30W_Port,
                                 string UPOE_60W_Port,
                                 string HPOE_75_W_Port,
                                 string _95W_802_3bt_PoE,
                                 string _1GE_BaseT_Ports,
                                 string _1GE_BaseX_SFP_port,
                                 string _1G_SFP_plus_port_,
                                 string RJ45_SFP_combo_1G,
                                 string _1G_10G_RJ45_SFP_combo,
                                 string _mgig_port_100M_1G_2_5G_5G,
                                 string _mgig_port_100M_1G_2_5G_5G_10G,
                                 string _mgig_port_1G_2_5G_BaseT,
                                 string _mgig_port_100M_1G_2_5G_BaseT,
                                 string _20G_QSFP_plus_stacking_ports,
                                 string _1G_SPF_port,
                                 string _1G_10G_SFP_plus_,
                                 string _10_25G_SFP28,
                                 string _10GE_SFP_plus_Ports,
                                 string _40GE_QSFP_plus_Ports,
                                 string _100GE_QSFP28_Ports,
                                 string _MAC_Address_Table,
                                 string _VLANs_ID,
                                 string _VLAN_active,
                                 string _VLAN_Interfaces_SVI_for_L3_Sw_,
                                 string _Jumbo_Frame_Bytes_,
                                 string _Total_number_of_IPv4_routes_ARP_plus_learned_routes_,
                                 string _MAX_IPv4_routes,
                                 string _MAX_IPv6_routes,
                                 string _Multicast_groups,
                                 string _QoS_scale_entries,
                                 string _ACL_scale_entries,
                                 string _Flexible_NetFlow__FNF_entries,
                                 string _Power_Redundancy,
                                 string Static_Routing,
                                 string RIP,
                                 string OSPF_Routed_Access,
                                 string OSPF_Full,
                                 string BGP,
                                 string IS_IS,
                                 string VXLAN,
                                 string MACSec,
                                 string MACSec_128_bit,
                                 string MACSec_256_bit,
                                 string PBR,
                                 string Private_VLAN,
                                 string VRRP,
                                 string DAI,
                                 string uRPF,
                                 string _802_1x,
                                 string SPAN_and_RSPAN,
                                 string ERSPAN,
                                 string EEM,
                                 string Automation)
        {
            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                sql = "SELECT * FROM Product WHERE TRUE " +
                                (!string.IsNullOrEmpty(name)  ? "AND name = '" + name + "'\n " : " AND TRUE ") +
                                (!string.IsNullOrEmpty(Branch)  ? "AND Branch = '" + Branch + "'\n " : " AND TRUE ") +
                                 genWhere("Price", Price) + "\n " +
                                 genWhere("IsAdvantageLicense", IsAdvantageLicense, true) + "\n " +
                                 genWhere("ForwardingBandwidth", ForwardingBandwidth) + "\n " +
                                 genWhere("SwitchingBandwidth", SwitchingBandwidth) + "\n " +
                                 genWhere("ForwardingCapacity", ForwardingCapacity) + "\n " +
                                 genWhere("RAM", RAM) + "\n " +
                                 genWhere("Flash", Flash) + "\n " +
                                 genWhere("Stackable", Stackable) + "\n " +
                                 genWhere("Stack_Members", Stack_Members) + "\n " +
                                 genWhere("Maximumnumberofunitsinavirtualchassis", Maximumnumberofunitsinavirtualchassis) + "\n " +
                                 genWhere("PoE_15_4WPort", PoE_15_4WPort) + "\n " +
                                 genWhere("PoE_Plus_30W_Port", PoE_Plus_30W_Port) + "\n " +
                                 genWhere("UPOE_60W_Port", UPOE_60W_Port) + "\n " +
                                 genWhere("HPOE_75_W_Port", HPOE_75_W_Port) + "\n " +
                                 genWhere("_95W_802_3bt_PoE", _95W_802_3bt_PoE) + "\n " +
                                 genWhere("_1GE_BaseT_Ports", _1GE_BaseT_Ports) + "\n " +
                                 genWhere("_1GE_BaseX_SFP_port", _1GE_BaseX_SFP_port) + "\n " +
                                 genWhere("_1G_SFP_plus_port_", _1G_SFP_plus_port_) + "\n " +
                                 genWhere("RJ45_SFP_combo_1G", RJ45_SFP_combo_1G) + "\n " +
                                 genWhere("_1G_10G_RJ45_SFP_combo", _1G_10G_RJ45_SFP_combo) + "\n " +
                                 genWhere("_mgig_port_100M_1G_2_5G_5G", _mgig_port_100M_1G_2_5G_5G) + "\n " +
                                 genWhere("_mgig_port_100M_1G_2_5G_5G_10G", _mgig_port_100M_1G_2_5G_5G_10G) + "\n " +
                                 genWhere("_mgig_port_1G_2_5G_BaseT", _mgig_port_1G_2_5G_BaseT) + "\n " +
                                 genWhere("_mgig_port_100M_1G_2_5G_BaseT", _mgig_port_100M_1G_2_5G_BaseT) + "\n " +
                                 genWhere("_20G_QSFP_plus_stacking_ports", _20G_QSFP_plus_stacking_ports) + "\n " +
                                 genWhere("_1G_SPF_port", _1G_SPF_port) + "\n " +
                                 genWhere("_1G_10G_SFP_plus_", _1G_10G_SFP_plus_) + "\n " +
                                 genWhere("_10_25G_SFP28", _10_25G_SFP28) + "\n " +
                                 genWhere("_10GE_SFP_plus_Ports", _10GE_SFP_plus_Ports) + "\n " +
                                 genWhere("_40GE_QSFP_plus_Ports", _40GE_QSFP_plus_Ports) + "\n " +
                                 genWhere("_100GE_QSFP28_Ports", _100GE_QSFP28_Ports) + "\n " +
                                 genWhere("_MAC_Address_Table", _MAC_Address_Table) + "\n " +
                                 genWhere("_VLANs_ID", _VLANs_ID) + "\n " +
                                 genWhere("_VLAN_active", _VLAN_active) + "\n " +
                                 genWhere("_VLAN_Interfaces_SVI_for_L3_Sw_", _VLAN_Interfaces_SVI_for_L3_Sw_) + "\n " +
                                 genWhere("_Jumbo_Frame_Bytes_", _Jumbo_Frame_Bytes_) + "\n " +
                                 genWhere("_Total_number_of_IPv4_routes_ARP_plus_learned_routes_", _Total_number_of_IPv4_routes_ARP_plus_learned_routes_) + "\n " +
                                 genWhere("_MAX_IPv4_routes", _MAX_IPv4_routes) + "\n " +
                                 genWhere("_MAX_IPv6_routes", _MAX_IPv6_routes) + "\n " +
                                 genWhere("_Multicast_groups", _Multicast_groups) + "\n " +
                                 genWhere("_QoS_scale_entries", _QoS_scale_entries) + "\n " +
                                 genWhere("_ACL_scale_entries", _ACL_scale_entries) + "\n " +
                                 genWhere("_Flexible_NetFlow__FNF_entries", _Flexible_NetFlow__FNF_entries) + "\n " +
                                 genWhere("_Power_Redundancy", _Power_Redundancy) + "\n " +
                                 genWhere("Static_Routing", Static_Routing, true) + "\n " +
                                 genWhere("RIP", RIP, true) + "\n " +
                                 genWhere("OSPF_Routed_Access", OSPF_Routed_Access, true) + "\n " +
                                 genWhere("OSPF_Full", OSPF_Full, true) + "\n " +
                                 genWhere("BGP", BGP, true) + "\n " +
                                 genWhere("IS_IS", IS_IS, true) + "\n " +
                                 genWhere("VXLAN", VXLAN, true) + "\n " +
                                 genWhere("MACSec", MACSec, true) + "\n " +
                                 genWhere("MACSec_128_bit", MACSec_128_bit, true) + "\n " +
                                 genWhere("MACSec_256_bit", MACSec_256_bit, true) + "\n " +
                                 genWhere("PBR", PBR, true) + "\n " +
                                 genWhere("Private_VLAN", Private_VLAN, true) + "\n " +
                                 genWhere("VRRP", VRRP, true) + "\n " +
                                 genWhere("DAI", DAI, true) + "\n " +
                                 genWhere("uRPF", uRPF, true) + "\n " +
                                 genWhere("_802_1x", _802_1x, true) + "\n " +
                                 genWhere("SPAN_and_RSPAN", SPAN_and_RSPAN, true) + "\n " +
                                 genWhere("ERSPAN", ERSPAN, true) + "\n " +
                                 genWhere("EEM", EEM, true) + "\n " +
                                 genWhere("Automation", Automation, true) + "\n " +
                                                          " ORDER BY price LIMIT 1;";
                using (command = new SQLiteCommand(sql, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return setObj(reader);
                    }
                    return null;
                }
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                using (connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    sql = "DELETE FROM Product WHERE id = " + id;
                    using(var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch
            {

            }
        }
        public Product setObj(SQLiteDataReader reader)
        {
            Product product = new Product();

            int id = Convert.ToInt32(reader["id"]);
            string name = Convert.ToString(reader["name"]);
            string Branch = Convert.ToString(reader["Branch"]);
            decimal Price = Convert.ToDecimal(reader["Price"]);
            int IsAdvantageLicense = Convert.ToInt32(reader["IsAdvantageLicense"]);
            double ForwardingBandwidth = Convert.ToDouble(reader["ForwardingBandwidth"]);
            double SwitchingBandwidth = Convert.ToDouble(reader["SwitchingBandwidth"]);
            double ForwardingCapacity = Convert.ToDouble(reader["ForwardingCapacity"]);
            int RAM = Convert.ToInt32(reader["RAM"]);
            int Flash = Convert.ToInt32(reader["Flash"]);
            int Stackable = Convert.ToInt32(reader["Stackable"]);
            int Stack_Members = Convert.ToInt32(reader["Stack_Members"]);
            int Maximumnumberofunitsinavirtualchassis = Convert.ToInt32(reader["Maximumnumberofunitsinavirtualchassis"]);
            int PoE_15_4WPort = Convert.ToInt32(reader["PoE_15_4WPort"]);
            int PoE_Plus_30W_Port = Convert.ToInt32(reader["PoE_Plus_30W_Port"]);
            int UPOE_60W_Port = Convert.ToInt32(reader["UPOE_60W_Port"]);
            int HPOE_75_W_Port = Convert.ToInt32(reader["HPOE_75_W_Port"]);
            int _95W_802_3bt_PoE = Convert.ToInt32(reader["_95W_802_3bt_PoE"]);
            int _1GE_BaseT_Ports = Convert.ToInt32(reader["_1GE_BaseT_Ports"]);
            int _1GE_BaseX_SFP_port = Convert.ToInt32(reader["_1GE_BaseX_SFP_port"]);
            int _1G_SFP_plus_port_ = Convert.ToInt32(reader["_1G_SFP_plus_port_"]);
            int RJ45_SFP_combo_1G = Convert.ToInt32(reader["RJ45_SFP_combo_1G"]);
            int _1G_10G_RJ45_SFP_combo = Convert.ToInt32(reader["_1G_10G_RJ45_SFP_combo"]);
            int _mgig_port_100M_1G_2_5G_5G = Convert.ToInt32(reader["_mgig_port_100M_1G_2_5G_5G"]);
            int _mgig_port_100M_1G_2_5G_5G_10G = Convert.ToInt32(reader["_mgig_port_100M_1G_2_5G_5G_10G"]);
            int _mgig_port_1G_2_5G_BaseT = Convert.ToInt32(reader["_mgig_port_1G_2_5G_BaseT"]);
            int _mgig_port_100M_1G_2_5G_BaseT = Convert.ToInt32(reader["_mgig_port_100M_1G_2_5G_BaseT"]);
            int _20G_QSFP_plus_stacking_ports = Convert.ToInt32(reader["_20G_QSFP_plus_stacking_ports"]);
            int _1G_SPF_port = Convert.ToInt32(reader["_1G_SPF_port"]);
            int _1G_10G_SFP_plus_ = Convert.ToInt32(reader["_1G_10G_SFP_plus_"]);
            int _10_25G_SFP28 = Convert.ToInt32(reader["_10_25G_SFP28"]);
            int _10GE_SFP_plus_Ports = Convert.ToInt32(reader["_10GE_SFP_plus_Ports"]);
            int _40GE_QSFP_plus_Ports = Convert.ToInt32(reader["_40GE_QSFP_plus_Ports"]);
            int _100GE_QSFP28_Ports = Convert.ToInt32(reader["_100GE_QSFP28_Ports"]);
            int _MAC_Address_Table = Convert.ToInt32(reader["_MAC_Address_Table"]);
            int _VLANs_ID = Convert.ToInt32(reader["_VLANs_ID"]);
            int _VLAN_active = Convert.ToInt32(reader["_VLAN_active"]);
            int _VLAN_Interfaces_SVI_for_L3_Sw_ = Convert.ToInt32(reader["_VLAN_Interfaces_SVI_for_L3_Sw_"]);
            double _Jumbo_Frame_Bytes_ = Convert.ToDouble(reader["_Jumbo_Frame_Bytes_"]);
            int _Total_number_of_IPv4_routes_ARP_plus_learned_routes_ = Convert.ToInt32(reader["_Total_number_of_IPv4_routes_ARP_plus_learned_routes_"]);
            int _MAX_IPv4_routes = Convert.ToInt32(reader["_MAX_IPv4_routes"]);
            int _MAX_IPv6_routes = Convert.ToInt32(reader["_MAX_IPv6_routes"]);
            int _Multicast_groups = Convert.ToInt32(reader["_Multicast_groups"]);
            int _QoS_scale_entries = Convert.ToInt32(reader["_QoS_scale_entries"]);
            int _ACL_scale_entries = Convert.ToInt32(reader["_ACL_scale_entries"]);
            int _Flexible_NetFlow__FNF_entries = Convert.ToInt32(reader["_Flexible_NetFlow__FNF_entries"]);
            int _Power_Redundancy = Convert.ToInt32(reader["_Power_Redundancy"]);
            int Static_Routing = Convert.ToInt32(reader["Static_Routing"]);
            int RIP = Convert.ToInt32(reader["RIP"]);
            int OSPF_Routed_Access = Convert.ToInt32(reader["OSPF_Routed_Access"]);
            int OSPF_Full = Convert.ToInt32(reader["OSPF_Full"]);
            int BGP = Convert.ToInt32(reader["BGP"]);
            int IS_IS = Convert.ToInt32(reader["IS_IS"]);
            int VXLAN = Convert.ToInt32(reader["VXLAN"]);
            int MACSec = Convert.ToInt32(reader["MACSec"]);
            int MACSec_128_bit = Convert.ToInt32(reader["MACSec_128_bit"]);
            int MACSec_256_bit = Convert.ToInt32(reader["MACSec_256_bit"]);
            int PBR = Convert.ToInt32(reader["PBR"]);
            int Private_VLAN = Convert.ToInt32(reader["Private_VLAN"]);
            int VRRP = Convert.ToInt32(reader["VRRP"]);
            int DAI = Convert.ToInt32(reader["DAI"]);
            int uRPF = Convert.ToInt32(reader["uRPF"]);
            int _802_1x = Convert.ToInt32(reader["_802_1x"]);
            int SPAN_and_RSPAN = Convert.ToInt32(reader["SPAN_and_RSPAN"]);
            int ERSPAN = Convert.ToInt32(reader["ERSPAN"]);
            int EEM = Convert.ToInt32(reader["EEM"]);
            int Automation = Convert.ToInt32(reader["Automation"]);

            product.id = id;
            product.name = name;
            product.Branch = Branch;
            product.Price = Price;
            product.IsAdvantageLicense = IsAdvantageLicense;
            product.ForwardingBandwidth = ForwardingBandwidth;
            product.SwitchingBandwidth = SwitchingBandwidth;
            product.ForwardingCapacity = ForwardingCapacity;
            product.RAM = RAM;
            product.Flash = Flash;
            product.Stackable = Stackable;
            product.Stack_Members = Stack_Members;
            product.Maximumnumberofunitsinavirtualchassis = Maximumnumberofunitsinavirtualchassis;
            product.PoE_15_4WPort = PoE_15_4WPort;
            product.PoE_Plus_30W_Port = PoE_Plus_30W_Port;
            product.UPOE_60W_Port = UPOE_60W_Port;
            product.HPOE_75_W_Port = HPOE_75_W_Port;
            product._95W_802_3bt_PoE = _95W_802_3bt_PoE;
            product._1GE_BaseT_Ports = _1GE_BaseT_Ports;
            product._1GE_BaseX_SFP_port = _1GE_BaseX_SFP_port;
            product._1G_SFP_plus_port_ = _1G_SFP_plus_port_;
            product.RJ45_SFP_combo_1G = RJ45_SFP_combo_1G;
            product._1G_10G_RJ45_SFP_combo = _1G_10G_RJ45_SFP_combo;
            product._mgig_port_100M_1G_2_5G_5G = _mgig_port_100M_1G_2_5G_5G;
            product._mgig_port_100M_1G_2_5G_5G_10G = _mgig_port_100M_1G_2_5G_5G_10G;
            product._mgig_port_1G_2_5G_BaseT = _mgig_port_1G_2_5G_BaseT;
            product._mgig_port_100M_1G_2_5G_BaseT = _mgig_port_100M_1G_2_5G_BaseT;
            product._20G_QSFP_plus_stacking_ports = _20G_QSFP_plus_stacking_ports;
            product._1G_SPF_port = _1G_SPF_port;
            product._1G_10G_SFP_plus_ = _1G_10G_SFP_plus_;
            product._10_25G_SFP28 = _10_25G_SFP28;
            product._10GE_SFP_plus_Ports = _10GE_SFP_plus_Ports;
            product._40GE_QSFP_plus_Ports = _40GE_QSFP_plus_Ports;
            product._100GE_QSFP28_Ports = _100GE_QSFP28_Ports;
            product._MAC_Address_Table = _MAC_Address_Table;
            product._VLANs_ID = _VLANs_ID;
            product._VLAN_active = _VLAN_active;
            product._VLAN_Interfaces_SVI_for_L3_Sw_ = _VLAN_Interfaces_SVI_for_L3_Sw_;
            product._Jumbo_Frame_Bytes_ = _Jumbo_Frame_Bytes_;
            product._Total_number_of_IPv4_routes_ARP_plus_learned_routes_ = _Total_number_of_IPv4_routes_ARP_plus_learned_routes_;
            product._MAX_IPv4_routes = _MAX_IPv4_routes;
            product._MAX_IPv6_routes = _MAX_IPv6_routes;
            product._Multicast_groups = _Multicast_groups;
            product._QoS_scale_entries = _QoS_scale_entries;
            product._ACL_scale_entries = _ACL_scale_entries;
            product._Flexible_NetFlow__FNF_entries = _Flexible_NetFlow__FNF_entries;
            product._Power_Redundancy = _Power_Redundancy;
            product.Static_Routing = Static_Routing;
            product.RIP = RIP;
            product.OSPF_Routed_Access = OSPF_Routed_Access;
            product.OSPF_Full = OSPF_Full;
            product.BGP = BGP;
            product.IS_IS = IS_IS;
            product.VXLAN = VXLAN;
            product.MACSec = MACSec;
            product.MACSec_128_bit = MACSec_128_bit;
            product.MACSec_256_bit = MACSec_256_bit;
            product.PBR = PBR;
            product.Private_VLAN = Private_VLAN;
            product.VRRP = VRRP;
            product.DAI = DAI;
            product.uRPF = uRPF;
            product._802_1x = _802_1x;
            product.SPAN_and_RSPAN = SPAN_and_RSPAN;
            product.ERSPAN = ERSPAN;
            product.EEM = EEM;
            product.Automation = Automation;
            return product;
        }

        private string genWhere(string name, string value, bool isCombobox = false)
        {
            string res = "AND ";
            if (value == null) return res + "TRUE ";
            if (value == "") return res + "TRUE ";
            if (isCombobox)
            {
                if (value == "-1" || value == "2") return res + "TRUE ";
                return res + name + " = " + value + " ";
            }
            return res + name + " >= " + value + " ";
        }
    }
}
