using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms;
using System.Diagnostics;

namespace NileInc
{
	public partial class EMPWallet_UC : UserControl
	{
		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		EMP_MainData OpenedEMP;

		EMP_Document selectedDoc;

		string FilePath { get; set; }

		string FileEXT { get; set; }

		public EMPWallet_UC()
		{
			InitializeComponent();
		}

		public EMPWallet_UC(EMP_MainData emp)
		{
			InitializeComponent();
			OpenedEMP = emp;
			RefreshDGV();
		}

		public void RefreshDGV()
		{
			dataGridView1.DataSource = MainDB.EMP_Documents.Where(b => b.EMP_ID.Equals(OpenedEMP.ID)).Select(a => new
			{
				ID = a.ID,
				DocName = a.DocName,
				DocPath = a.DocPath
			}).AC_AsDataTable();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Image Files (JPG & PNG) | *.jpeg; *.jpg; *.png;"/* + "|Text Files|*.rtf;*.txt;" + "|Office Files and PDF|*.doc;*.xls;*.ppt;*.pdf;"*/;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FilePath = ofd.FileName;
					FileEXT = Path.GetExtension(FilePath);
					lblDocPath.Text = FilePath;
					txtDocName.Text = "";
					txtDocName.Focus();
				}
				catch (Exception ex)
				{
					MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);                 //MessageBox.Show(ex.Message);
					DataBaseClass.SendExceptionToOfflineDB(ex);
				}
			}
		}

		public string GetID()
		{
			var lastDoc = MainDB.EMP_Documents.ToList().LastOrDefault();
			return lastDoc == null ? "1" : (lastDoc.ID + 1).ToString();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if(txtDocName.Text.Trim() != "" && FilePath.Trim() != "")
			{
				string newFilePath = "\\Docs\\" + txtDocName.Text + " - " + OpenedEMP.ID + "-" + GetID() + FileEXT;
				EMP_Document empDoc = new EMP_Document();
				empDoc.EMP_ID = OpenedEMP.ID;
				empDoc.DocName = txtDocName.Text;
				empDoc.DocPath = newFilePath;
				File.Copy(FilePath, Directory.GetCurrentDirectory() + newFilePath, true);
				MainDB.EMP_Documents.InsertOnSubmit(empDoc);
				MainDB.SubmitChanges();
				RefreshDGV();
				txtDocName.Text = "";
				lblDocPath.Text = "Path";
				MessageBoxAdv.Show("تمت الاضافه بنجاح");

			}
			else
			{
				MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية الاضافه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				selectedDoc = MainDB.EMP_Documents.FirstOrDefault(a => a.ID.Equals(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value));
				if(selectedDoc != null)
				{
					txtDocName.Text = selectedDoc.DocName;
					lblDocPath.Text = Directory.GetCurrentDirectory() + selectedDoc.DocPath;
				}
			}
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				if(selectedDoc != null)
				{
					if(selectedDoc.DocPath.Trim() != "")
					{
						Process.Start(Directory.GetCurrentDirectory() + selectedDoc.DocPath);
					}
				}
			}
		}

		private void TxtDocName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnAdd.PerformClick();
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if (selectedDoc != null)
			{
				if (MessageBoxAdv.Show("هل انت متاكد من حذف الملف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					try
					{
						File.Delete(Directory.GetCurrentDirectory() + selectedDoc.DocPath);
					}
					catch { }
					MainDB.EMP_Documents.DeleteOnSubmit(selectedDoc);
					MainDB.SubmitChanges();
					RefreshDGV();
					selectedDoc = null;
					MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار ملف لحذفه");
			}
		}
	}
}
