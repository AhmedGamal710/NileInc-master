using NileInc.Properties;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NileInc
{
	public class StylesClass
	{
		public static Image btnAddImage = Resources.Add32px;


		/// <summary>
		/// Styles the <see cref="MessageBoxAdv"/>
		/// </summary>
		public static void MsgBoxConfig(Font messageFont ,Font captionFont, Color foreColor,Color backColor)
		{
			MessageBoxAdv.RightToLeft = RightToLeft.Yes;
			MessageBoxAdv.MessageFont = messageFont;
			MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
			MessageBoxAdv.CaptionFont = captionFont;
			MessageBoxAdv.MetroColorTable = new MetroStyleColorTable
			{
				BackColor = Color.White,
				ForeColor = Color.Black,

				YesButtonBackColor = backColor,
				AbortButtonBackColor = backColor,
				CancelButtonBackColor = backColor,
				DetailsButtonBackColor = backColor,
				IgnoreButtonBackColor = backColor,
				NoButtonBackColor = backColor,
				OKButtonBackColor = backColor,
				RetryButtonBackColor = backColor,
				CaptionBarColor = Color.FromArgb(1, 60, 155),

				AbortButtonForeColor = foreColor,
				CancelButtonForeColor = foreColor,
				CaptionForeColor = foreColor,
				DetailsButtonForeColor = foreColor,
				IgnoreButtonForeColor = foreColor,
				NoButtonForeColor = foreColor,
				OKButtonForeColor = foreColor,
				RetryButtonForeColor = foreColor,
				YesButtonForeColor = foreColor
			};
		}
	}
}
