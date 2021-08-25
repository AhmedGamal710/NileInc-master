using NileInc.Properties;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace NileInc
{
	public static class AC_Extensions
	{


		#region Objects

		//objects
		public static void AC_ClearField(this object obj)
		{
			if (obj is TextBox)
			{
				(obj as TextBox).Clear();
			}
			else if (obj is ComboBox)
			{
				(obj as ComboBox).SelectedIndex = -1;
			}
			else if (obj is DateTimePicker)
			{
				(obj as DateTimePicker).Value = DateTime.Now;
			}
			else if (obj is NumericUpDown)
			{
				(obj as NumericUpDown).Value = 0;
			}
			else if (obj is DoubleTextBox)
			{
				(obj as DoubleTextBox).DoubleValue = 0;
			}
			else if (obj is CheckBox)
			{
				(obj as CheckBox).Checked = false;
			}
			else if(obj is RadioButton)
			{
				(obj as RadioButton).Checked = false;
			}
			//else
			//{
			//	throw new Exception("Control Unknown");
			//}
		}

		public static void OnlyNumbers(this object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}


		//End objects

		#endregion

		#region Controls
		//Controls
		#region Parent Controls

		public static bool AC_ValidValue(this Control con)
		{
			Type t = con.GetType();
			if (t == typeof(TextBox))
				return (con as TextBox).Text.Trim() == "" ? false : true;
			else if (t == typeof(DoubleTextBox))
				return (con as DoubleTextBox).DoubleValue == 0 ? false : true;
			else if (t == typeof(ComboBox))
				return (con as ComboBox).SelectedIndex == -1 ? false : true;
			else if (t == typeof(SfNumericTextBox))
				return (con as SfNumericTextBox).Value <= 0 ? false : true;
			else
				return true;
		}

		public static bool AC_CheckRequiredFields(params Control[] cons)
		{
			foreach (var item in cons)
			{
				if (!item.Enabled)
					return true;
				if (!item.AC_ValidValue())
					return false;
			}
			return true;
		}

		#endregion

		#region TableLayoutPanel

		//Tablelayoutpanel

		public static void AC_ConfigButtons(this TableLayoutPanel tlp, bool BigSize, DataGridView dgv)
		{
			foreach (Control con in tlp.Controls)
			{
				if (con is Button)
				{
					if (con.Name.Contains("btnAdd"))
					{
						if (con.Enabled)
						{
							con.Enabled = false;
							if (BigSize)
								(con as Button).Image = Resources.AddBlack32px;
							else
								(con as Button).Image = Resources.AddBlack25px;
							dgv.Enabled = true;
						}
						else
						{
							con.Enabled = true;
							if (BigSize)
								(con as Button).Image = Resources.Add32px;
							else
								(con as Button).Image = Resources.Add25px;
							dgv.Enabled = false;
						}
					}
					else if (con.Name.Contains("btnEdit"))
					{
						if (con.Enabled)
						{
							con.Enabled = false;
							if (BigSize)
								(con as Button).Image = Resources.EditBlack32px;
							else
								(con as Button).Image = Resources.EditBlack25px;
						}
						else
						{
							con.Enabled = true;
							if (BigSize)
								(con as Button).Image = Resources.Edit32px;
							else
								(con as Button).Image = Resources.Edit25px;
						}
					}
					else if (con.Name.Contains("btnDel"))
					{
						if (con.Enabled)
						{
							con.Enabled = false;
							if (BigSize)
								(con as Button).Image = Resources.DeleteBlack32px;
							else
								(con as Button).Image = Resources.DeleteBlack25px;
						}
						else
						{
							con.Enabled = true;
							if (BigSize)
								(con as Button).Image = Resources.Delete32px;
							else
								(con as Button).Image = Resources.Delete25px;
						}
					}
					else if (con.Name.Contains("btnCon"))
					{
						if (con.Text.Contains("تهيئة"))
						{
							con.Text = "الغاء";
							if (BigSize)
								(con as Button).Image = Resources.Cancel32px;
							else
								(con as Button).Image = Resources.Cancel25px;
						}
						else
						{
							con.Text = "تهيئة";
							if (BigSize)
								(con as Button).Image = Resources.Erase32px;
							else
								(con as Button).Image = Resources.Erase25px;
						}
					}
				}
			}
		}

		public static void AC_ClearFields(this TableLayoutPanel tlp)
		{
			foreach (Control con in tlp.Controls)
			{
				con.AC_ClearField();
			}
		}

		public static bool AC_CheckRequiredColumns(this TableLayoutPanel tlp, params int[] columns)
		{
			for (int i = 0; i < columns.Count(); i += 2)
			{

				if (!tlp.GetControlFromPosition(columns[i + 1], columns[i]).AC_ValidValue())
					return false;

			}
			return true;
		}

		public static bool AC_CheckRequiredFields(this TableLayoutPanel tlp, params Control[] cons)
		{
			return AC_CheckRequiredFields(cons);
		}


		public static void ConfigButtonDisplay(this TableLayoutPanel tlp,int permission)
		{
			if(permission == 2)
			{
				foreach(Control con in tlp.Controls)
				{
					if(con is Button)
					{
						if ((con as Button).Name.Contains("btnEdit"))
							con.Visible = false;
						else if ((con as Button).Name.Contains("btnDel"))
							con.Visible = false;
						else if ((con as Button).Name.Contains("btnCon"))
							tlp.SetCellPosition(con, new TableLayoutPanelCellPosition(0, 1));
					}
				}
			}
		}

		//End tablelayoutpanel

		#endregion

		public static string HashSHA1(this string value)
		{
			var sha1 = SHA1.Create();
			var inputBytes = Encoding.ASCII.GetBytes(value);
			var hash = sha1.ComputeHash(inputBytes);

			var sb = new StringBuilder();
			for (var i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}



		#region DataGridView

		//DataGridView
		public static DataTable AC_AsDataTable(this DataGridView dgv)
		{
			DataTable dt = new DataTable();
			foreach (DataGridViewColumn colm in dgv.Columns)
			{
				dt.Columns.Add(colm.Name, typeof(object));
			}

			foreach (DataGridViewRow row in dgv.Rows)
			{
				DataRow roww = dt.NewRow();

				foreach (DataGridViewCell cell in row.Cells)
				{
					roww[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(roww);
			}
			return dt;
		}

		public static T[] AC_GetColumnAsArray<T>(this DataGridView dgv, string columnName, int count)
		{
			T[] arr = new T[count];
			for (int i = 0; i < count; i++)
			{
				arr[i] = (T)dgv.Rows[i].Cells[columnName].Value;
			}
			return arr;
		}

		public static List<T> AC_GetColumnAsList<T>(this DataGridView dgv, string colName)
		{
			List<T> ls = new List<T>();
			Type type = typeof(T);
			foreach (DataGridViewRow row in dgv.Rows)
			{
				ls.Add((T)Convert.ChangeType(row.Cells[colName].Value, typeof(T)));
			}
			return ls;
		}


		public static DataTable GetDGVColumns(this DataGridView dgv)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Text");
			dt.Columns.Add("Name");
			dt.Columns.Add("DataPropertyName");

			foreach (DataGridViewColumn col in dgv.Columns)
			{
				DataRow row = dt.NewRow();
				row["Text"] = col.HeaderText;
				row["Name"] = col.Name;
				row["DataPropertyName"] = col.DataPropertyName;

				dt.Rows.Add(row);
			}

			return dt;
		}

		//End DataGridView

		#endregion

		#endregion

		//IEnumerable
		public static DataTable AC_AsDataTable<T>(this IEnumerable<T> data)
		{
			DataTable dt = new DataTable();

			PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			foreach (PropertyInfo p in properties)
			{
				dt.Columns.Add(p.Name, p.PropertyType);
			}


			foreach (T val in data)
			{
				var values = new object[properties.Length];
				for (int i = 0; i < properties.Length; i++)
				{
					values[i] = properties[i].GetValue(val, null);
				}
				dt.Rows.Add(values);
			}
			return dt;
		}

		public static void AC_ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (T element in source)
				action(element);
		}

		public static bool AC_Exists<T>(this IEnumerable<T> list, T value)
		{
			foreach (T element in list)
			{
				if (element.Equals(value))
					return true;
			}
			return false;
		}

		//End IEnumerable


		//DataTable
		public static List<T> AC_AsList<T>(this DataTable dataTable, string colName)
		{
			List<T> ls = new List<T>();
			Type type = typeof(T);
			dataTable.AsEnumerable().AC_ForEach(a => ls.Add((T)Convert.ChangeType(a[colName], typeof(T))));
			return ls;
		}

		// End DataTable

		//Int
		public static bool AC_ExistsIn(this int num, List<int> ls)
		{
			foreach (int i in ls)
			{
				if (i == num)
				{
					return true;
				}
			}
			return false;
		}

		//End Int

		//DataContext

		/// <summary>
		///     Discard all pending changes of current DataContext.
		///     All un-submitted changes, including insert/delete/modify will lost.
		/// </summary>
		/// <param name="context"></param>
		public static void AC_DiscardPendingChanges(this DataContext context)
		{
			context.AC_RefreshPendingChanges(RefreshMode.OverwriteCurrentValues);
			ChangeSet changeSet = context.GetChangeSet();
			if (changeSet != null)
			{
				//Undo inserts
				foreach (object objToInsert in changeSet.Inserts)
				{
					context.GetTable(objToInsert.GetType()).DeleteOnSubmit(objToInsert);
				}
				//Undo deletes
				foreach (object objToDelete in changeSet.Deletes)
				{
					context.GetTable(objToDelete.GetType()).InsertOnSubmit(objToDelete);
				}
			}
		}

		/// <summary>
		/// Refreshes all pending Delete/Update entity objects of current DataContext according to the specified mode.
		///	Nothing will do on Pending Insert entity objects.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="refreshMode">A value that specifies how optimistic concurrency conflicts are handled.</param>
		public static void AC_RefreshPendingChanges(this DataContext context, RefreshMode refreshMode)
		{
			ChangeSet changeSet = context.GetChangeSet();
			if (changeSet != null)
			{
				context.Refresh(refreshMode, changeSet.Deletes);
				context.Refresh(refreshMode, changeSet.Updates);
			}
		}

		//End DataContext


	}

}
