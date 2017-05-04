using System;
using System.Data;
using System.Data.SqlClient;

namespace XNetUtilities
{
    /// <summary>
    /// 类说明：SqlServer命令执行类
    /// 日期：2017-04-24
    /// 作者：szwb
    /// 修改：
    /// </summary>
    public static class SqlHelper
    {

        // 设置连接、命令，然后执行非查询命令，返回受到影响的行数
        public static int ExecuteNonQuery(String connectionString, String commandText, CommandType commandType,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // 设置连接、命令，然后执行返回一个值的查询
        public static object ExecuteScalar(String connectionString, String commandText, CommandType commnadType,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commnadType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        // 设置连接、命令，然后执行返回reader的查询
        public static SqlDataReader ExecuteReader(String connectionString, String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
        }


    }
}
