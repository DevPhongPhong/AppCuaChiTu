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
            string filename = "C:\\mydb.sqlite";
            if (!File.Exists(filename))
            {
                string connectionString = "Data Source=C:\\mydb.sqlite;Version=3;";
                SQLiteConnection.CreateFile(filename);
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    // tạo bảng
                    string sql = @"CREATE TABLE Product(    
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        name TEXT,
                                        Branch TEXT,
                                        Maximumnumberofunitsinavirtualchassis INTEGER,
                                        _mgig_port_100M_1G_2_5G_BaseT INTEGER,
                                        _1G_SFP_plus_port_ INTEGER,
                                        _MAX_IPv6_routes INTEGER,
                                        _100GE_QSFP28_Ports INTEGER,
                                        _Multicast_groups INTEGER,
                                        _MAC_Address_Table INTEGER,
                                        _20G_QSFP_plus_ INTEGER,
                                        RJ45_SFP_combo_1G INTEGER,
                                        PoE_15_4WPort INTEGER,
                                        ForwardingBandwidth FLOAT,
                                        _ACL_scale_entries INTEGER,
                                        _VLAN_active INTEGER,
                                        _1G_SPF_port INTEGER,
                                        _mgig_port_100M_1G_2_5G_5G INTEGER,
                                        UPOE_60W_Port INTEGER,
                                        ForwardingCapacity FLOAT,
                                        _QoS_scale_entries INTEGER,
                                        _VLANs_ID INTEGER,
                                        _stacking_ports INTEGER,
                                        _1G_10G_RJ45_SFP_combo INTEGER,
                                        PoE_Plus_30W_Port INTEGER,
                                        SwitchingBandwidth FLOAT,
                                        _MAX_IPv4_routes INTEGER,
                                        _40GE_QSFP_plus_Ports INTEGER,
                                        _1GE_BaseX_SFP_port INTEGER,
                                        Stack_Members INTEGER,
                                        _Total_number_of_IPv4_routes_ARP_plus_learned_routes_ INTEGER,
                                        _10GE_SFP_plus_Ports INTEGER,
                                        _1GE_BaseT_Ports INTEGER,
                                        Stackable INTEGER,
                                        _Power_Redundancy INTEGER,
                                        _Jumbo_Frame_Bytes_ FLOAT,
                                        _10_25G_SFP28 INTEGER,
                                        _mgig_port_1G_2_5G_BaseT INTEGER,
                                        _95W_802_3bt_PoE INTEGER,
                                        Flash INTEGER,
                                        _VLAN_Interfaces_SVI_for_L3_Sw_ INTEGER,
                                        _1G_10G_SFP_plus_ INTEGER,
                                        _mgig_port_100M_1G_2_5G_5G_10G INTEGER,
                                        HPOE_75_W_Port INTEGER,
                                        RAM INTEGER,
                                        _Flexible_NetFlow__FNF_entries INTEGER,
                                        IsAdventageLicense BOOLEAN,
                                        RIP BOOLEAN,
                                        MACSec BOOLEAN,
                                        BGP BOOLEAN,
                                        VRRP BOOLEAN,
                                        SPAN_and_RSPAN BOOLEAN,
                                        ERSPAN BOOLEAN,
                                        DAI BOOLEAN, = temp;
                                        IS_IS BOOLEAN,
                                        MACSec_128_bit BOOLEAN,
                                        Static_Routing BOOLEAN,
                                        EEM BOOLEAN,
                                        uRPF BOOLEAN,
                                        VXLAN BOOLEAN,
                                        MACSec_256_bit BOOLEAN,
                                        OSPF_Routed_Access BOOLEAN,
                                        Automation BOOLEAN,
                                        _802_1x BOOLEAN,
                                        PBR BOOLEAN,
                                        Private_VLAN BOOLEAN,
                                        OSPF_Full BOOLEAN
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
