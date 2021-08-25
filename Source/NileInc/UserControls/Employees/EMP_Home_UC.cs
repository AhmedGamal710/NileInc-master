using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NileInc
{
	public partial class EMP_Home_UC : UserControl
	{
		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);
		public EMP_Home_UC()
		{
			InitializeComponent();
		}

		public void EMP_Home_UC_Load(object sender, EventArgs e)
		{

		}

		private void GradientButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
