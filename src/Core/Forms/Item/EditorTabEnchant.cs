using System;
using System.Drawing;
using System.Windows.Forms;

using MCFunctionEditor.Resource;

namespace MCFunctionEditor.Core.Forms.Item
{
	public class EditorTabEnchant : TabPage
	{
		public TextBox[] txtEnchantLevel;
		
		String[] enchantList;
		
		public EditorTabEnchant() : base()
		{
			this.Text = "Enchantment";
			
			enchantList = Enum.GetNames(typeof(MinecraftEnchantList));
			txtEnchantLevel = new TextBox[enchantList.Length];
			
			TableLayoutPanel mainPanel = new TableLayoutPanel();
			mainPanel.AutoSize = true;
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.RowCount = enchantList.Length / 2;
			mainPanel.ColumnCount = 4;
			
			this.Controls.Add(mainPanel);
			
			for (int i = 0; i < enchantList.Length / 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Label nameLabel = new Label();
					nameLabel.Dock = DockStyle.Fill;
					nameLabel.Text = enchantList[i + j];
					mainPanel.Controls.Add(nameLabel, j * 2, i);
					
					txtEnchantLevel[i + j] = new TextBox();
					txtEnchantLevel[i + j].Dock = DockStyle.Fill;
					mainPanel.Controls.Add(txtEnchantLevel[i + j], j * 2 + 1, i);
				}
			}
		}
	}
}