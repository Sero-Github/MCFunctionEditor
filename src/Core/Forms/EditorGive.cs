using System;
using System.Drawing;
using System.Windows.Forms;


namespace MCFunctionEditor.Core.Forms
{
	public class EditorGive : TabPage
	{
		public EditorGive(int tabWidth, int tabHeight) : base()
		{
			
			this.Text = "Give Editor";
			
			TableLayoutPanel mainPanel = new TableLayoutPanel();
			mainPanel.Location = new Point(0, 0);
			mainPanel.Size = new Size(tabWidth, tabHeight);
			mainPanel.RowCount = 21;
			mainPanel.ColumnCount = 2;
			this.Controls.Add(mainPanel);
			
			String[] labelName = { "Target", "Limit", "Sort", "x", "y", "z", "Selection Area", "Min Radius", "Max Radius", "Min Vert Rotation", "Max Vert Rotation", "Min Horiz Rotation", "Max Horiz Rotation", "Team", "Name", "NBT", "Game Mode", "Min XP Level", "Max XP Level", "Advancements", "Tags" };
			
			for (int i = 0; i < labelName.Length; i++)
			{
				Label nameLabel = new Label();
				nameLabel.Text = labelName[i];
				mainPanel.Controls.Add(nameLabel, 0, i);
			}
			
		}
	}
}