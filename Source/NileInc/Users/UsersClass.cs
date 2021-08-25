using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileInc
{
	class UsersClass
	{
		public static DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		public static bool UserLogged(string Username, string Password)
		{
			USR_LoginData user = MainDB.USR_LoginDatas.ToList().FirstOrDefault(a => a.Username.ToLower() == Username.ToLower());
			if (user != null)
			{
				string hashedPassword = AC_Extensions.HashSHA1(Password + user.UserGuid.ToLower());
				if (hashedPassword == user.Password)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		public static bool CheckSecurityQuestions(string username, string ans1, string ans2, int rand1, int rand2)
		{
			string expectedAns1 = "", expectedAns2 = "";
			USR_LoginData logusr = MainDB.USR_LoginDatas.FirstOrDefault(a => a.Username.ToLower() == username.ToLower());
			if (logusr != null)
			{
				if (rand1 == 0)
					expectedAns1 = logusr.Answer1;
				else if (rand1 == 1)
					expectedAns1 = logusr.Answer2;
				else if (rand1 == 2)
					expectedAns1 = logusr.Answer3;
				else if (rand1 == 3)
					expectedAns1 = logusr.Answer4;

				if (rand2 == 0)
					expectedAns2 = logusr.Answer1;
				else if (rand2 == 1)
					expectedAns2 = logusr.Answer2;
				else if (rand2 == 2)
					expectedAns2 = logusr.Answer3;
				else if (rand2 == 3)
					expectedAns2 = logusr.Answer4;
			}
			else
			{
				return false;
			}

			if (ans1 == expectedAns1 && ans2 == expectedAns2)
				return true;
			else
				return false;

		}

		public static bool ChangeUserPassword(string username, string newpassword)
		{
			USR_LoginData logusr = MainDB.USR_LoginDatas.FirstOrDefault(a => a.Username.ToLower() == username.ToLower());
			try
			{
				string hashedpassword = AC_Extensions.HashSHA1(newpassword + logusr.UserGuid);
				logusr.Password = hashedpassword;
				MainDB.SubmitChanges();
				return true;

			}
			catch (Exception ex)
			{
				MessageBoxAdv.Show("خطأ");
				DataBaseClass.SendExceptionToOfflineDB(ex);
				return false;
			}

		}

	}
}
