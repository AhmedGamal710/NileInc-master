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
	public partial class EMPDetails_UC : UserControl
	{
		public EMP_MainData OpenedEMP;

		public EMPDetails_UC()
		{
			InitializeComponent();
		}

		public EMPDetails_UC(EMP_MainData emp)
		{
			InitializeComponent();
			OpenedEMP = emp;
		}

		private void BtnAddsAndDeductions_Click(object sender, EventArgs e)
		{
			if(OpenedEMP != null)
			{
				SingleUC_Form singUC = new SingleUC_Form(false);
				EMPAddOnAndDeductions_UC empadds = new EMPAddOnAndDeductions_UC(OpenedEMP);
				singUC.DataSource(empadds, "العلاوات و الخصومات", btnAddsAndDeductions);
			}
		}

		private void BtnNetSalary_Click(object sender, EventArgs e)
		{
			if (OpenedEMP != null)
			{
				SingleUC_Form singUC = new SingleUC_Form(false);
				EMP_NetSalary_UC empSalary = new EMP_NetSalary_UC(OpenedEMP);
				singUC.DataSource(empSalary, "كشف المرتب", btnNetSalary);
			}
		}
	}
}
