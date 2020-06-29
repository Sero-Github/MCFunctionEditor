using System;
using System.Drawing;
using System.Windows.Forms;

using MCFunctionEditor.Core.Forms.Item;
using MCFunctionEditor.Resource;

namespace MCFunctionEditor.Core.Forms
{
	public class EditorItem : TabPage
	{
		TabControl tabControl = new TabControl();
		
		EditorTabItem tabItem = new EditorTabItem();
		EditorTabEnchant tabEnchant = new EditorTabEnchant();
		
		public EditorItem() : base()
		{
			this.Text = "Item Editor";
			
			tabControl.Alignment = TabAlignment.Right;
			tabControl.Dock = DockStyle.Fill;
			tabControl.SizeMode = TabSizeMode.Fixed;
			tabControl.ItemSize = new Size(25, 80);
			tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
			
			tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
			
			tabControl.Controls.Add(tabItem);
			tabControl.Controls.Add(tabEnchant);
			this.Controls.Add(tabControl);
		}
		
		private void tabControl_DrawItem(Object sender, DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush _textBrush = new SolidBrush(e.ForeColor);;
			TabPage _tabPage = tabControl.TabPages[e.Index];
			Rectangle _tabBounds = tabControl.GetTabRect(e.Index);
			
			Font _tabFont = new Font("Arial", 10.0f, FontStyle.Regular, GraphicsUnit.Pixel);
			StringFormat _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}
	}
}