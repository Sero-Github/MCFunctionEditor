using System;
using System.Drawing;
using System.Windows.Forms;

using MCFunctionEditor.Core.Forms.Common;

using MCFunctionEditor.Resource;


namespace MCFunctionEditor.Core.Forms.Item
{
	public class EditorTabItem : TabPage
	{
		// https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.combobox?view=netcore-3.1
		public ComboBox cmbItem = new ComboBox();
		
		// https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.textbox?view=netcore-3.1
		public TextBox txtCount = new TextBox();
		public TextBox txtCustomModelData = new TextBox();
		public TextBox txtCustomTags = new TextBox();
		
		public TextEditPanel txtName = new TextEditPanel();
		public TextEditPanel txtLore = new TextEditPanel();
		
		public EditorTabItem() : base()
		{
			this.Text = "Item";
			
			TableLayoutPanel mainPanel = new TableLayoutPanel();
			mainPanel.AutoSize = true;
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.RowCount = 20;
			mainPanel.ColumnCount = 4;
			this.Controls.Add(mainPanel);
			
			String[] labelName = { "Item", "Name", "Lore", "Count", "CustomModelData", "CustomTags", "CanPlaceOn", "CanDestroy" };
			
			for (int i = 0; i < labelName.Length; i++)
			{
				Label nameLabel = new Label();
				nameLabel.Dock = DockStyle.Fill;
				nameLabel.Text = labelName[i];
				nameLabel.TextAlign = ContentAlignment.MiddleLeft;
				mainPanel.Controls.Add(nameLabel, 0, i);
			}
			
			cmbItem.Items.AddRange(Enum.GetNames(typeof(MinecraftItemList)));
			cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
			mainPanel.Controls.Add(cmbItem, 1, 0);
			mainPanel.SetColumnSpan(cmbItem, 3);
			
			mainPanel.Controls.Add(txtName, 1, 1);
			mainPanel.SetColumnSpan(txtName, 3);
			
			mainPanel.Controls.Add(txtLore, 1, 2);
			mainPanel.SetColumnSpan(txtLore, 3);
			
			TextBox[] txtItemArr = { txtCount, txtCustomModelData, txtCustomTags };
			for (int i = 0; i < txtItemArr.Length; i++)
			{
				txtItemArr[i].Dock = DockStyle.Fill;
				mainPanel.Controls.Add(txtItemArr[i], 1, i + 2);
				mainPanel.SetColumnSpan(txtItemArr[i], 3);
			}
		}
	}
}