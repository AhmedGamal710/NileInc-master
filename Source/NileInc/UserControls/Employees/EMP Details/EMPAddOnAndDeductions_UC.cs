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
	public partial class EMPAddOnAndDeductions_UC : UserControl
	{
		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		public EMP_MainData OpenedEMP;

		EMP_AddAndDeduction selectedRec;

		public EMPAddOnAndDeductions_UC()
		{
			InitializeComponent();
			RefreshDGV();
			tlpButtons.ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);

		}

		public EMPAddOnAndDeductions_UC(EMP_MainData emp)
		{
			InitializeComponent();
			OpenedEMP = emp;
			RefreshDGV();
			tlpButtons.ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);
		}

		public void RefreshDGV()
		{
			var result = MainDB.EMP_AddAndDeductions.Where(a => a.EMP_ID.Equals(OpenedEMP.ID));

			if (rbViewAdds.Checked)
				result = result.Where(a => a.TypeAdd);
			if (rbViewDeductions.Checked)
				result = result.Where(a => !a.TypeAdd);

			if (sfDateTimeEdit1.Value.HasValue)
				result = result.Where(a => a.Date.Month.Equals(sfDateTimeEdit1.Value.Value.Month) && a.Date.Year.Equals(sfDateTimeEdit1.Value.Value.Year));

			dataGridView1.DataSource = result.ToList().Select(a => new
			{
				ID = a.ID,
				Date = a.Date.ToString("dd/MM/yyyy"),
				Type = a.TypeAdd ? "علاوة" : "خصم",
				Value = a.Value.ToString("0.00") + (a.StaticValue ? string.Empty : " %"),
				ValueFrom = a.FromDay ? "مرتب اليوم" : a.FromMonth ? "مرتب الشهر" : a.FromIncentives ? "الحوافز" : "",
				RealValue = a.RealValue.ToString("0.00"),
				Notes = a.Notes
			}).AC_AsDataTable();
		}

		public decimal GetRealValue(EMP_AddAndDeduction rec)
		{
			decimal realVal = 0;
			if (rec.StaticValue)
				realVal = rec.Value;
			else
			{
				if (rec.FromDay)
					realVal = ((rec.Value / 100) * (OpenedEMP.REF_Degree.BaseSalary / (DateTime.DaysInMonth(dtMonthDate.Value.Year, dtMonthDate.Value.Month))));
				else if (rec.FromIncentives)
					realVal = ((rec.Value / 100) * (OpenedEMP.REF_Degree.Incentives));
				else if (rec.FromMonth)
					realVal = ((rec.Value / 100) * (OpenedEMP.REF_Degree.BaseSalary));
			}
			return realVal;
		}


		private void BtnCon_Click(object sender, EventArgs e)
		{
			tlpFields.AC_ClearFields();
			tlpValueOptions.AC_ClearFields();
			tlpButtons.AC_ConfigButtons(false, dataGridView1);
		}

		private void RbAdd_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if ((rbAdd.Checked || rbDiscount.Checked) && (rbDaySalary.Checked || rbMonSalary.Checked || rbIncentives.Checked) && tlpFields.AC_CheckRequiredFields(numValue))
				{
					EMP_AddAndDeduction empAdd = new EMP_AddAndDeduction();
					empAdd.TypeAdd = rbAdd.Checked;
					empAdd.EMP_ID = OpenedEMP.ID;
					empAdd.Date = dtMonthDate.Value.Date;
					empAdd.Value = numValue.Value;
					empAdd.StaticValue = !chPercentage.Checked;
					empAdd.FromDay = rbDaySalary.Checked;
					empAdd.FromMonth = rbMonSalary.Checked;
					empAdd.FromIncentives = rbIncentives.Checked;
					empAdd.RealValue = GetRealValue(empAdd);
					empAdd.Notes = txtNotes.Text;
					MainDB.EMP_AddAndDeductions.InsertOnSubmit(empAdd);
					MainDB.SubmitChanges();
					RefreshDGV();
					btnCon.PerformClick();
					MessageBoxAdv.Show("تمت الاضافه بنجاح");
				}
				else
				{
					MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية الاضافه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void RbViewAdds_CheckedChanged(object sender, EventArgs e)
		{
			RefreshDGV();
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				selectedRec = MainDB.EMP_AddAndDeductions.FirstOrDefault(a => a.ID.Equals(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value));

				if(selectedRec!= null)
				{
					rbAdd.Checked = selectedRec.TypeAdd;
					rbDiscount.Checked = !selectedRec.TypeAdd;
					dtMonthDate.Value = selectedRec.Date;
					numValue.Value = selectedRec.Value;
					chPercentage.Checked = !selectedRec.StaticValue;
					rbDaySalary.Checked = selectedRec.FromDay;
					rbMonSalary.Checked = selectedRec.FromMonth;
					rbIncentives.Checked = selectedRec.FromIncentives;
					txtNotes.Text = selectedRec.Notes;
				}
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (selectedRec != null)
			{
				if ((rbAdd.Checked || rbDiscount.Checked) && (rbDaySalary.Checked || rbMonSalary.Checked || rbIncentives.Checked) && tlpFields.AC_CheckRequiredFields(numValue))
				{
					selectedRec.TypeAdd = rbAdd.Checked;
					selectedRec.Date = dtMonthDate.Value.Date;
					selectedRec.Value = numValue.Value;
					selectedRec.StaticValue = !chPercentage.Checked;
					selectedRec.FromDay = rbDaySalary.Checked;
					selectedRec.FromMonth = rbMonSalary.Checked;
					selectedRec.FromIncentives = rbIncentives.Checked;
					selectedRec.RealValue = GetRealValue(selectedRec);
					selectedRec.Notes = txtNotes.Text;
					MainDB.SubmitChanges();
					RefreshDGV();
					MessageBoxAdv.Show("تمت عملية التعديل بنجاح");
				}
				else
				{
					MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار عنصر للتعديل");
			}
		}

		private void BtnDel_Click(object sender, EventArgs e)
		{
			if (selectedRec != null)
			{
				if (MessageBoxAdv.Show("هل تريد الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MainDB.EMP_AddAndDeductions.DeleteOnSubmit(selectedRec);
					MainDB.SubmitChanges();
					RefreshDGV();
					selectedRec = null;
					MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار موظف لحذفه");
			}
		}

		private void ChPercentage_CheckedChanged(object sender, EventArgs e)
		{
			rbDaySalary.Enabled = chPercentage.Checked;
			rbDaySalary.Checked = false;
		}

		private void NumValue_Enter(object sender, EventArgs e)
		{
			
		}

		private void NumValue_Leave(object sender, EventArgs e)
		{

		}

		private void SfDateTimeEdit1_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
		{
			RefreshDGV();
		}
	}
}
