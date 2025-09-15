using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Common
{
    public class DBService
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SqlDataAdapter adapter;
        SqlTransaction transaction;

        public DBService()
        {
            // 创建或打开数据库文件
            conn = new SQLiteConnection("Data Source=data.db;Version=3;");
            conn.Open();
            // 创建数据表（如果不存在）
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS 'values' (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    d_id INTEGER,
                    addr TEXT,
                    value TEXT,
                    time DATETIME DEFAULT CURRENT_TIMESTAMP
                )";
            cmd = new SQLiteCommand(createTableQuery, conn);
            cmd.ExecuteNonQuery();

            createTableQuery = @"
                CREATE TABLE IF NOT EXISTS 'alarms' (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    d_id INTEGER,
                    d_name TEXT,
                    addr TEXT,
                    v_name TEXT,
                    value TEXT,
                    message TEXT,
                    time DATETIME,
                    state TEXT
                )";
            cmd = new SQLiteCommand(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }

        // 写入监控数据
        public int AddMontiorValue(int slaveId, string addr, string value)
        {
            string insertQuery = "INSERT INTO 'values' (d_id, addr, value) VALUES (@d_id, @addr, @value)";
            cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@d_id", slaveId);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@value", value);
            return cmd.ExecuteNonQuery();
        }

        // 获取监控数据
        public DataTable GetMontiorValues(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT * FROM 'values' WHERE time BETWEEN @startTime AND @endTime ORDER BY time";
            cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@startTime", startTime);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            var adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // 写入告警数据
        public int AddAlarmValue(AlarmModel alarm)
        {
            string insertQuery = "INSERT INTO 'alarms' (d_id, d_name, addr, v_name, value, message, time, state) VALUES (@d_id, @d_name, @addr, @v_name, @value, @message, @time, @state); SELECT last_insert_rowid();";
            cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@d_id", alarm.SlaveId);
            cmd.Parameters.AddWithValue("@d_name", alarm.DeviceName);
            cmd.Parameters.AddWithValue("@addr", alarm.Address);
            cmd.Parameters.AddWithValue("@v_name", alarm.VariableName);
            cmd.Parameters.AddWithValue("@value", alarm.Value);
            cmd.Parameters.AddWithValue("@message", alarm.Message);
            cmd.Parameters.AddWithValue("@time", DateTime.Parse(alarm.Time));
            cmd.Parameters.AddWithValue("@state", alarm.State);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int UpdateAlarmState(int id, string state)
        {
            string updateQuery = "UPDATE 'alarms' SET state = @state WHERE id = @id";
            cmd = new SQLiteCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        public int UpdateAlarmState(int slaveId, string addr, string state)
        {
            string updateQuery = "UPDATE 'alarms' SET state = @state WHERE d_id = @d_id AND addr = @addr";
            cmd = new SQLiteCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@d_id", slaveId);
            cmd.Parameters.AddWithValue("@addr", addr);
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetAlarms()
        {
            string query = "SELECT * FROM 'alarms' WHERE state = '正在告警' ORDER BY time DESC";
            cmd = new SQLiteCommand(query, conn);
            var adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetAlarmsByTime(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT * FROM 'alarms' WHERE (time BETWEEN @startTime AND @endTime) AND state = '正在告警' ORDER BY time DESC";
            cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@startTime", startTime);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            var adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
