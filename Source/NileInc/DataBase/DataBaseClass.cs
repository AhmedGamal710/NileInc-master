using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileInc
{
	class DataBaseClass
	{
		public static string LocalDBPath = Directory.GetCurrentDirectory() + "\\DB\\NileInc.mdf";

		public static string LocalDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LocalDBPath + ";Integrated Security=True;";

		//public static string LocalDB = @"Data Source=.;AttachDbFilename=" + LocalDBPath + ";Integrated Security=True;";


		//public static string LocalDB = @"Data Source=DESKTOP-H9JPP40\SQLEXPRESS;Initial Catalog=NileInc;Integrated Security=True;";

		public static void SendExceptionToOfflineDB(Exception ex)
		{
			try
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Exceptions");
			}
			catch { }

			File.WriteAllText(Directory.GetCurrentDirectory() + "\\Exceptions\\" + DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss") + ".txt" , ex.Message);


			//using (SqlConnection Conn = new SqlConnection(LocalDB))
			//{
			//	SqlCommand cmd = new SqlCommand("AddExceptions", Conn);
			//	cmd.CommandType = CommandType.StoredProcedure;
			//	if (ex.Data.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@Data", ex.Data.ToString());
			//	else cmd.Parameters.AddWithValue("@Data", "null");

			//	if (ex.HelpLink != null)
			//		cmd.Parameters.AddWithValue("@HelpLink", ex.HelpLink.ToString());
			//	else cmd.Parameters.AddWithValue("@HelpLink", "null");

			//	if (ex.HResult.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@HResult", ex.HResult.ToString());
			//	else cmd.Parameters.AddWithValue("@HResult", "null");

			//	if (ex.InnerException != null)
			//		cmd.Parameters.AddWithValue("@InnerException", ex.InnerException.ToString());
			//	else cmd.Parameters.AddWithValue("@InnerException", "null");

			//	if (ex.Message.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@Message", ex.Message.ToString());
			//	else cmd.Parameters.AddWithValue("@Message", "null");

			//	if (ex.Source.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@Source", ex.Source.ToString());
			//	else cmd.Parameters.AddWithValue("@Source", "null");

			//	if (ex.StackTrace.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@StackTrace", ex.StackTrace.ToString());
			//	else cmd.Parameters.AddWithValue("@StackTrace", "null");

			//	if (ex.TargetSite.ToString() != "null")
			//		cmd.Parameters.AddWithValue("@TargetSite", ex.TargetSite.ToString());
			//	else cmd.Parameters.AddWithValue("@TargetSite", "null");

			//	Conn.Open();
			//	cmd.ExecuteNonQuery();
			//	Conn.Close();

			//}
		}

	}
}
