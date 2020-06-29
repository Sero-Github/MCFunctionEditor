using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCFunctionEditor.Core.Forms.Common
{
	public class TextEditPanel : TableLayoutPanel
	{
		public TextBox txtText = new TextBox();
		public ListBox lstText = new ListBox();
		public ComboBox[] cmbSetting = new ComboBox[6];
		
		public TextEditPanel() : base()
		{
			
			this.Size = new Size(250, 120);
			this.Dock = DockStyle.Fill;
			// this.ColumnStyles.Clear();
			this.ColumnCount = 5;
			this.RowCount = 4;
			
			for (int i = 0; i < 5; i++)
				   this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
			
			txtText.Dock = DockStyle.Fill;
			this.Controls.Add(txtText, 0, 0);
			this.SetColumnSpan(txtText, 4);
			
			String[] listName = { "Color", "Bold", "Italic", "Underlined", "Strikethrough", "Obfuscated" };
			
			for (int i = 0; i < listName.Length / 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Label nameLabel = new Label();
					nameLabel.AutoSize = false;
					nameLabel.Dock = DockStyle.Fill;
					nameLabel.Text = listName[i * 2 + j];
					this.Controls.Add(nameLabel, j * 2, i + 1);
					
					cmbSetting[i * 2 + j] = new ComboBox();
					cmbSetting[i * 2 + j] .AutoSize = false;
					cmbSetting[i * 2 + j].Dock = DockStyle.Fill;
					this.Controls.Add(cmbSetting[i * 2 + j], j * 2 + 1, i + 1);
					
					if (i + j * 2 > 0)
						cmbSetting[i * 2 + j].Items.AddRange(new String[] { "Unset", "True", "False" } );
				}
			}
			
			lstText.Dock = DockStyle.Fill;
			lstText.MultiColumn = true;
			this.Controls.Add(lstText, 4, 0);
			this.SetRowSpan(lstText, 4);
		}
	}
}