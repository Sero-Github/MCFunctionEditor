using System;
using System.Drawing;
using System.Windows.Forms;

using MCFunctionEditor.Core.Forms;

namespace MCFunctionEditor.Core
{
	public class MainForm : Form
	{
	
		TreeView treeView = new TreeView();
		TabControl tabControl = new TabControl();
		
		public MainForm() : base()	
		{
			this.Name = "MCFunctionEditor";
			this.Width = 800;
			this.Height = 600;
			
			MenuStrip menu = new MenuStrip();
			menu.Dock = DockStyle.Top;
			this.MainMenuStrip = menu;
			this.Controls.Add(menu);
			
			ToolStripMenuItem fileTap = new ToolStripMenuItem("파일(&F)");
			((ToolStripDropDownMenu)(fileTap.DropDown)).ShowImageMargin = false;
			((ToolStripDropDownMenu)(fileTap.DropDown)).ShowCheckMargin = false;
			menu.Items.Add(fileTap);
			
			ToolStripMenuItem fileNewMenu = new ToolStripMenuItem("새로 만들기");
			((ToolStripDropDownMenu)(fileNewMenu.DropDown)).ShowImageMargin = false;
			((ToolStripDropDownMenu)(fileNewMenu.DropDown)).ShowCheckMargin = false;
			fileTap.DropDownItems.Add(fileNewMenu);
			
			ToolStripMenuItem fileNewScriptEditorMenu = new ToolStripMenuItem("스크립트 에디터");
			ToolStripMenuItem fileNewGiveEditorMenu = new ToolStripMenuItem("Give 에디터", null, new EventHandler(fileNewGiveEditorMenu_Click));
			ToolStripMenuItem fileNewSummonEditorMenu = new ToolStripMenuItem("Summon 에디터");
			ToolStripMenuItem[] fileNewMenus = { fileNewScriptEditorMenu, fileNewGiveEditorMenu, fileNewSummonEditorMenu };
			for (int i = 0; i < fileNewMenus.Length; i++)
			{
				fileNewMenu.DropDownItems.Add(fileNewMenus[i]);
			}
			
			TableLayoutPanel mainPanel = new TableLayoutPanel();
			mainPanel.Location = new Point(0, 24);
			mainPanel.Size = new Size(this.Width - 8, this.Height - 52);
			mainPanel.RowCount = 1;
			mainPanel.ColumnCount = 4;
			this.Controls.Add(mainPanel);
			
			// https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.treeview?view=netcore-3.1
			// treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			// | System.Windows.Forms.AnchorStyles.Left)
			// | System.Windows.Forms.AnchorStyles.Right)));
			treeView.Dock = DockStyle.Fill;
			mainPanel.Controls.Add(treeView, 0, 0);
			
			// https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.tabcontrol?view=netcore-3.1
			// tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			// | System.Windows.Forms.AnchorStyles.Left)
			// | System.Windows.Forms.AnchorStyles.Right)));
			
			tabControl.Dock = DockStyle.Fill;
			mainPanel.Controls.Add(tabControl, 1, 0);
			mainPanel.SetColumnSpan(tabControl, 3);
		}
	
		void fileNewGiveEditorMenu_Click(object sender, EventArgs e)
		{
			tabControl.Controls.Add(new EditorItem());
		}
	}
}