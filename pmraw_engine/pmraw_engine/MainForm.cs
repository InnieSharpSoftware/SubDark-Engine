using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pmraw_engine
{
	public partial class MainForm : Form
	{
		
		
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			
		}
		void MainFormShown(object sender, EventArgs e)
		{
			core.CreateLabel(350, 300, "Loading...", 16, Color.Black, "load");
			core.CreateWindow(800, 600, Color.White, "TEST GAME");
			core.resload();
			core.f.Controls.Clear();
			core.scenes("menu");
			core.f.BackgroundImage = core.res[0];
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
	
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			for (int i = 0; i > 8; i++)
			{
				core.res[i] = null;
			}
		}
	}
}
