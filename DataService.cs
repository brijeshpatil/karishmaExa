using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppForCloud
{
    public class DataService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        #region ManageUserInfo

        public void InsertNewUser(PropertyService P)
        {
            cmd = new SqlCommand("InsertNewUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fname", P.FirstName);
            cmd.Parameters.AddWithValue("@Lname", P.LastName);
            con.Open();
            cmd.ExecuteNonQuery();//To Save Changes into Table. & to findout Number of affected by Query
            con.Close();
        }

        public DataTable GetAllUsers()
        {
            da = new SqlDataAdapter("GetAllUsers", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateUser(PropertyService P)
        {
            cmd = new SqlCommand("UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", P.UserID);
            cmd.Parameters.AddWithValue("@Fname", P.FirstName);
            cmd.Parameters.AddWithValue("@Lname", P.LastName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteUser(int UserID)
        {
            cmd = new SqlCommand("DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", UserID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        public DataTable GetAllStates()
        {
            da = new SqlDataAdapter("GetAllStates", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetCityByState(int StateID)
        {
            da = new SqlDataAdapter("GetCityByState", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SID", StateID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}