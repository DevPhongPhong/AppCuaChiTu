using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuaChiTu
{
    public class CreateSqliteDbExtension
    {
        public static void Create()
        {
            string filename = "D:\\mydb.sqlite";
            if (!File.Exists(filename))
            {
                string connectionString = "Data Source=D:\\mydb.sqlite;Version=3;";
                SQLiteConnection.CreateFile(filename);
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    // tạo bảng
                    string sql = @"CREATE TABLE Product(    
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        name TEXT,
                                        Branch TEXT,
                                        Price NUMERIC, 
                                        IsAdventageLicense BOOLEAN,
                                        ForwardingBandwidth NUMERIC,
                                        SwitchingBandwidth NUMERIC,
                                        ForwardingCapacity NUMERIC,
                                        RAM INTEGER,
                                        Flash INTEGER,
                                        Stackable INTEGER,
                                        Stack_Members INTEGER,
                                        Maximumnumberofunitsinavirtualchassis INTEGER,
                                        PoE_15_4WPort INTEGER,
                                        PoE_Plus_30W_Port INTEGER,
                                        UPOE_60W_Port INTEGER,
                                        HPOE_75_W_Port INTEGER,
                                        _95W_802_3bt_PoE INTEGER,
                                        _1GE_BaseT_Ports INTEGER,
                                        _1GE_BaseX_SFP_port INTEGER,
                                        _1G_SFP_plus_port_ INTEGER,
                                        RJ45_SFP_combo_1G INTEGER,
                                        _1G_10G_RJ45_SFP_combo INTEGER,
                                        _mgig_port_100M_1G_2_5G_5G INTEGER,
                                        _mgig_port_100M_1G_2_5G_5G_10G INTEGER,
                                        _mgig_port_1G_2_5G_BaseT INTEGER,
                                        _mgig_port_100M_1G_2_5G_BaseT INTEGER,
                                        _20G_QSFP_plus_stacking_ports INTEGER,
                                        _1G_SPF_port INTEGER,
                                        _1G_10G_SFP_plus_ INTEGER,
                                        _10_25G_SFP28 INTEGER,
                                        _10GE_SFP_plus_Ports INTEGER,
                                        _40GE_QSFP_plus_Ports INTEGER,
                                        _100GE_QSFP28_Ports INTEGER,
                                        _MAC_Address_Table INTEGER,
                                        _VLANs_ID INTEGER,
                                        _VLAN_active INTEGER,
                                        _VLAN_Interfaces_SVI_for_L3_Sw_ INTEGER,
                                        _Jumbo_Frame_Bytes_ NUMERIC,
                                        _Total_number_of_IPv4_routes_ARP_plus_learned_routes_ INTEGER,
                                        _MAX_IPv4_routes INTEGER,
                                        _MAX_IPv6_routes INTEGER,
                                        _Multicast_groups INTEGER,
                                        _QoS_scale_entries INTEGER,
                                        _ACL_scale_entries INTEGER,
                                        _Flexible_NetFlow__FNF_entries INTEGER,
                                        _Power_Redundancy INTEGER,
                                        Static_Routing BOOLEAN,
                                        RIP BOOLEAN,
                                        OSPF_Routed_Access BOOLEAN,
                                        OSPF_Full BOOLEAN,
                                        BGP BOOLEAN,
                                        IS_IS BOOLEAN,
                                        VXLAN BOOLEAN,
                                        MACSec BOOLEAN,
                                        MACSec_128_bit BOOLEAN,
                                        MACSec_256_bit BOOLEAN,
                                        PBR BOOLEAN,
                                        Private_VLAN BOOLEAN,
                                        VRRP BOOLEAN,
                                        DAI BOOLEAN,
                                        uRPF BOOLEAN,
                                        _802_1x BOOLEAN,
                                        SPAN_and_RSPAN BOOLEAN,
                                        ERSPAN BOOLEAN,
                                        EEM BOOLEAN,
                                        Automation BOOLEAN
                                    )";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
