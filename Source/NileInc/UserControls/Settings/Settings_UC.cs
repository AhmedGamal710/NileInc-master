using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NileInc
{
	public partial class Settings_UC : UserControl
	{
		public Settings_UC()
		{
			InitializeComponent();
		}

		public void Load_UC(UserControl uc, string text, Button sender,bool sizable)
		{
			SingleUC_Form singUC = new SingleUC_Form(sizable);
			singUC.DataSource(uc, text, sender);
		}

		private void BtnDepartments_Click(object sender, EventArgs e)
		{
			Departments_UC dep = new Departments_UC();
			Load_UC(dep, "الاقسام", btnDepartments,false);
		}

		private void BtnDegrees_Click(object sender, EventArgs e)
		{
			Degrees_UC deg = new Degrees_UC();
			Load_UC(deg, "الدرجات", btnDegrees,false);
		}

		public void Settings_UC_Load(object sender, EventArgs e)
		{

		}

		private void BtnSalaries_Click(object sender, EventArgs e)
		{
			EMP_NetSalary_UC salaries = new EMP_NetSalary_UC();
			Load_UC(salaries, "كشف المرتبات", btnSalaries,true);
		}
	}
}
