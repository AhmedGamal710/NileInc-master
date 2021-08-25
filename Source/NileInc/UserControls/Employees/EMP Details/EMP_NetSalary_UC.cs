using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace NileInc
{
	public partial class EMP_NetSalary_UC : UserControl
	{
		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		public EMP_MainData OpenedEMP { get; set; }

		public EMP_MainData selectedEMP { get; set; }

		public decimal TotalSalaries { get; set; } = 0;

		public EMP_NetSalary_UC()
		{
			InitializeComponent();
			OpenedEMP = null;
			RefreshDeductionsDGV(null, null);
			RefreshAddsDGV(null, null);
			RefreshSalaryDGV(null, null);
			txtEMPName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtEMPName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtEMPName.AutoCompleteCustomSource = GetAllEmployeesNames();
		}

		public EMP_NetSalary_UC(EMP_MainData emp)
		{
			InitializeComponent();
			OpenedEMP = emp;
			RefreshDeductionsDGV(emp,null);
			RefreshAddsDGV(emp,null);
			RefreshSalaryDGV(emp, null);
			tlpSearch.Visible = false;
		}

		public AutoCompleteStringCollection GetAllEmployeesNames()
		{
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach (var emp in MainDB.EMP_MainDatas)
				collection.Add(emp.Name);
			return collection;
		}

		public void RefreshSalaryDGV(EMP_MainData emp, DateTime? monthDate)
		{
			var result = MainDB.EMP_NetSalaries.ToList();

			if (emp != null)
				result = result.Where(a => a.EMP_ID.Equals(emp.ID)).ToList();

			if (monthDate.HasValue)
				result = result.Where(a => a.MonthDate.ToString("MM/yyyy").Equals(monthDate.Value.ToString("MM/yyyy"))).ToList();

			dgvSalary.DataSource = result.Select(a => new
			{
				RecID = a.ID,
				EMPID = a.EMP_ID.Value,
				EMPName = a.EMP_MainData.Name,
				DATEMONTH = a.MonthDate.Month,
				DATEYEAR = a.MonthDate.Year,
				RecDate = a.MonthDate.ToString("MM/yyyy"),
				RecBaseSalaey = a.BaseSalary,
				RecIncentives = a.Incentives,
				RecStaticAdds = a.StaticAdds,
				RecAdds = a.AddOns,
				RecDis = a.Decuctions,
				RecNetSalary = a.NetSalary
			}).AC_AsDataTable();

			TotalSalaries = result.Sum(a => a.NetSalary);
			lblNetSalary.Text = TotalSalaries.ToString("0.00") + "ج.م";
		}

		public void RefreshAddsDGV(EMP_MainData emp, DateTime? monthDate)
		{
			var result = MainDB.EMP_AddAndDeductions.ToList();

			if(emp != null)
				result = result.Where(a => a.EMP_ID.Equals(emp.ID) && a.TypeAdd).ToList();

			if (monthDate.HasValue)
				result = result.Where(a => a.Date.ToString("MM/yyyy").Equals(monthDate.Value.ToString("MM/yyyy"))).ToList();

			dgvAdds.DataSource = result.Select(a => new
			{
				AddID = a.ID,
				AddValue = a.Value.ToString("0.00") + (a.StaticValue ? string.Empty : " %"),
				AddValueFrom = a.FromDay ? "مرتب اليوم" : a.FromMonth ? "مرتب الشهر" : a.FromIncentives ? "الحوافز" : "",
				AddRealValue = a.RealValue,
				AddNotes = a.Notes
			}).AC_AsDataTable();
		}

		public void RefreshDeductionsDGV(EMP_MainData emp, DateTime? monthDate)
		{
			var result = MainDB.EMP_AddAndDeductions.ToList();

			if (emp != null)
				result = result.Where(a => a.EMP_ID.Equals(emp.ID) && !a.TypeAdd).ToList();

			if (monthDate.HasValue)
				result = result.Where(a => a.Date.ToString("MM/yyyy").Equals(monthDate.Value.ToString("MM/yyyy"))).ToList();

			dgvDiscounts.DataSource = result.Select(a => new
			{
				DisID = a.ID,
				DisValue = a.Value.ToString("0.00") + (a.StaticValue ? string.Empty : " %"),
				DisValueFrom = a.FromDay ? "مرتب اليوم" : a.FromMonth ? "مرتب الشهر" : a.FromIncentives ? "الحوافز" : "",
				DisRealValue = a.RealValue,
				DisNotes = a.Notes
			}).AC_AsDataTable();
		}

		private void DtMonthDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
		{
			RefreshSalaryDGV(OpenedEMP,e.NewValue);
			RefreshAddsDGV(OpenedEMP, e.NewValue);
			RefreshDeductionsDGV(OpenedEMP, e.NewValue);
		}

		private void DgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				int month = (int)dgvSalary.Rows[e.RowIndex].Cells["DATEMONTH"].Value;
				int year = (int)dgvSalary.Rows[e.RowIndex].Cells["DATEYEAR"].Value;
				DateTime date = new DateTime(year, month, 1);
				selectedEMP = MainDB.EMP_MainDatas.FirstOrDefault(a => a.ID.Equals(dgvSalary.Rows[e.RowIndex].Cells["EMPID"].Value));
				RefreshAddsDGV(selectedEMP, date);
				RefreshDeductionsDGV(selectedEMP, date);
			}
		}

		private void BtnCalculateSalary_Click(object sender, EventArgs e)
		{
			if (dtMonthDate.Value.HasValue)
			{
				if (OpenedEMP != null)
				{
					CalculateEMPSalary(OpenedEMP, dtMonthDate.Value.Value);
					MessageBoxAdv.Show("تم حساب المرتب بنجاح");
				}
				else
				{
					foreach (var emp in MainDB.EMP_MainDatas)
					{
						CalculateEMPSalary(emp, dtMonthDate.Value.Value.Date);
					}
					MessageBoxAdv.Show("تم حساب المرتبات بنجاح");
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء تحديد شهر لحساب المرتب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void CalculateEMPSalary(EMP_MainData emp, DateTime monthdate)
		{
			int month = monthdate.Month;
			int year = monthdate.Year;
			EMP_NetSalary check = MainDB.EMP_NetSalaries.FirstOrDefault(a => a.EMP_ID.Equals(emp.ID) && a.MonthDate.Month.Equals(month) && a.MonthDate.Year.Equals(year));
			if (check == null)
			{
				EMP_NetSalary empSal = new EMP_NetSalary();
				empSal.EMP_ID = emp.ID;
				empSal.MonthDate = monthdate.Date;
				empSal.BaseSalary = emp.REF_Degree.BaseSalary;
				empSal.Incentives = emp.REF_Degree.Incentives;
				empSal.StaticAdds = emp.REF_Degree.StaticAdds;
				empSal.AddOns = GetEMPAdds(emp, month, year);
				empSal.Decuctions = GetEMPDeductions(emp, month, year);
				empSal.NetSalary = empSal.BaseSalary + empSal.Incentives + empSal.StaticAdds + empSal.AddOns - empSal.Decuctions;
				MainDB.EMP_NetSalaries.InsertOnSubmit(empSal);
				MainDB.SubmitChanges();
				RefreshSalaryDGV(emp, monthdate);
			}
			else
			{
				if (MessageBoxAdv.Show($"الموظف: {check.EMP_MainData.Name} قد تم حساب مرتبه بالفعل\nهل تريد الحساب مره اخري والتعديل؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					check.BaseSalary = emp.REF_Degree.BaseSalary;
					check.Incentives = emp.REF_Degree.Incentives;
					check.StaticAdds = emp.REF_Degree.StaticAdds;
					check.AddOns = GetEMPAdds(emp, month, year);
					check.Decuctions = GetEMPDeductions(emp, month, year);
					check.NetSalary = check.BaseSalary + check.Incentives + check.StaticAdds + check.AddOns - check.Decuctions;
					MainDB.SubmitChanges();
					RefreshSalaryDGV(emp, monthdate);
				}
			}
		}

		public decimal GetEMPAdds(EMP_MainData emp, int month, int year)
		{
			decimal add = 0;
			var Adds = MainDB.EMP_AddAndDeductions.Where(a => a.EMP_ID.Equals(emp.ID) && a.TypeAdd && a.Date.Month.Equals(month) && a.Date.Year.Equals(year));
			if (Adds.Count() > 0)
				add = Adds.Sum(a => a.RealValue);
			return add;
		}

		public decimal GetEMPDeductions(EMP_MainData emp,int month,int year)
		{
			decimal deds = 0;
			var Decuctions = MainDB.EMP_AddAndDeductions.Where(a => a.EMP_ID.Equals(emp.ID) && !a.TypeAdd && a.Date.Month.Equals(month) && a.Date.Year.Equals(year));
			if (Decuctions.Count() > 0)
				deds = Decuctions.Sum(a => a.RealValue);
			return deds;
		}

		private void TxtEMPName_Enter(object sender, EventArgs e)
		{
			txtEMPName.Text = "";
			txtEMPName.ForeColor = Color.Black;
		}

		private void TxtEMPName_Leave(object sender, EventArgs e)
		{
			if(txtEMPName.Text.Trim() == "")
			{
				txtEMPName.Text = "اسم الموظف";
				txtEMPName.ForeColor = Color.Silver;
			}
		}

		private void TxtEMPName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnSearch.PerformClick();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			if(txtEMPName.Text.Trim() != "")
			{
				selectedEMP = MainDB.EMP_MainDatas.FirstOrDefault(a => a.Name.Equals(txtEMPName.Text));
				if(selectedEMP != null)
				{
					RefreshAddsDGV(selectedEMP, dtMonthDate.Value);
					RefreshDeductionsDGV(selectedEMP, dtMonthDate.Value);
					RefreshSalaryDGV(selectedEMP, dtMonthDate.Value);
				}
			}
		}
	}
}
