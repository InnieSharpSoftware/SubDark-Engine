using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pmraw_engine
{
	public class core
	{
		public static Form f = Form.ActiveForm;
		public static Image[] res = new Image[8];
		public static int playerspeed;
		public static int arda;
		public static int abda;
		
		public core()
		{
		}
		
		public static void CreateWindow(int width, int height, Color color, string caption)
		{
			f.Size = new Size(width, height);
			f.Text = caption;
			f.FormBorderStyle = FormBorderStyle.FixedSingle;
			f.MaximizeBox = false;
			f.BackColor = color;
		}
		
		public static void CreateButton(int width, int height,int x, int y, string text, string name)
		{
			Button b = new Button();
			b.Name = name;
			b.Size = new Size(width, height);
			b.Location = new Point(x, y);
			b.Font = new Font("Consolas", 16f, FontStyle.Regular, GraphicsUnit.Point,((byte)(204)));
			b.Text = text;
			b.Click += btn_click;
			f.Controls.Add(b);
		}
		
		public static void resload()
		{
			res[0] = Image.FromFile(@"Images\finell_bg.png");
			res[1] = Image.FromFile(@"Images\coin.png");
		}
		
		public static void btn_click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			string name = btn.Name;
			switch (name) {
				case "play":
					scenes("play");
					break;
				case "options":
					scenes("options");
					break;
				case "menu":
					scenes("menu");
					break;
				case "exit":
					Application.Exit();
					break;
			}
		}
		
		public static void scenes(string name)
		{
			switch (name)
			{
				case "menu":
					f.Controls.Clear();
					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
					CreateButton(115, 70, 50, 60, "Start", "play");
					CreateButton(115, 70, 50, 135, "Options", "options");
					CreateButton(115, 70, 50, 220, "Exit", "exit");
					break;
				case "options":
					f.Controls.Clear();
					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
					CreateTextBox(320, 150, 300, 400, "TEXT", Color.Black, Color.Silver, "textbox1");
					CreateButton(115, 70, 50, 400, "Back", "menu");
					break;
				case "play":
					f.Controls.Clear();
					CreatePlayer(128, 128, 5, 5, 5, "player", res[1]);
					break;
			}
			if (name == "menu")
		    {
//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
				Console.WriteLine(f.Text);
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
				//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
				//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
		   		CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
		   		//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
		   		//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
		   		//				case "menu":
//					f.Controls.Clear();
//					CreateLabel(170, 65, "TEST GAME", 16, Color.DarkRed, "gamename");
//					CreateLabel(605, 0, "SubDark Engine", 16, Color.DarkRed, "gameeng");
//					CreateButton(115, 70, 50, 60, "Start", "play");
//					CreateButton(115, 70, 50, 135, "Options", "options");
//					CreateButton(115, 70, 50, 220, "Exit", "exit");
//					break;
//				case "options":
//					f.Controls.Clear();
//					CreateLabel(50, 50, "Unfinished!", 16, Color.Red, "options_unf");
//					CreateButton(115, 70, 50, 400, "Back", "menu");
//					break;
//				case "play":
//					f.Controls.Clear();
//					CreatePlayer(32, 32, 5, 5, "player", res[1]);
//					break;
		    }
		}
		
		public static void CreateLabel(int x, int y, string text, int tsize, Color color, string name)
		{
			Label l = new Label();
			l.Name = name;
			l.AutoSize = true;
			l.Location = new Point(x, y);
			l.Font = new Font("Consolas", tsize*1f, FontStyle.Regular, GraphicsUnit.Point,((byte)(204)));
			l.ForeColor = color;
			l.Text = text;
			l.BackColor = Color.Transparent;
			f.Controls.Add(l);
		}
		
		public static void CreateImage(int width, int height, int x, int y, string name, Image image)
		{
			PictureBox p = new PictureBox();
			p.Name = name;
			p.Size = new Size(width, height);
			p.Location = new Point(x, y);
			p.SizeMode = PictureBoxSizeMode.StretchImage;
			p.BackColor = Color.Transparent;
			p.Image = image;
			f.Controls.Add(p);
		}
		
		public static PictureBox p = new PictureBox();

		
		public static void CreatePlayer(int width, int height, int x, int y, int speed, string name, Image image)
		{
			p.Name = name;
			p.Size = new Size(width, height);
			p.Location = new Point(x, y);
			p.SizeMode = PictureBoxSizeMode.StretchImage;
			p.BackColor = Color.Transparent;
			p.Image = image;
			f.KeyDown += formKeyDown;
			//f.KeyUp += formKeyUp;
			f.Controls.Add(p);
			playerspeed = speed;
			Timer move = new Timer();
			move.Tick += movetick;
			move.Enabled = true;
		}
		
		public static void movetick(object sender, EventArgs e)
		{
			if(abda == 1)
			{
				if(arda == 1)
				{
					if (p.Left < 800)
			        {
			            p.Left -= playerspeed;
			        }
				}
				if(arda == 2)
				{
					if (p.Left > 0)
			        {
			            p.Left += playerspeed;
			        }
				}
				if(arda == 3)
				{
					if (p.Bottom > 600)
			        {
			            p.Top += playerspeed;
			        }
				}
				if(arda == 4)
				{
					if (p.Bottom < 0)
			        {
			            p.Top -= playerspeed;
			        }
				}
			}
		}
		
		public static void formKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.A)
			{
				arda = 1;
				abda = 1;
			}
			if(e.KeyCode == Keys.D)
			{
				arda = 2;
				abda = 1;
			}
			if(e.KeyCode == Keys.W)
			{
				arda = 3;
				abda = 1;
			}
			if(e.KeyCode == Keys.S)
			{
				arda = 4;
				abda = 1;
			}
		}
		
		/*
		public static void formKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.A)
			{
				arda = 1;
				abda = 2;
			}
			if(e.KeyCode == Keys.D)
			{
				arda = 2;
				abda = 2;
			}
			if(e.KeyCode == Keys.W)
			{
				arda = 3;
				abda = 2;
			}
			if(e.KeyCode == Keys.S)
			{
				arda = 4;
				abda = 2;
			}
		}
		*/
		
		public static void CreateTextBox(int width, int height, int x, int y, string text, Color fgcolor, Color bgcolor, string name)
		{
			TextBox tb = new TextBox();
			tb.Name = name;
			tb.Size = new Size(width, height);
			tb.Location = new Point(x, y);
			tb.Font = new Font("Consolas", 16f, FontStyle.Regular, GraphicsUnit.Point,((byte)(204)));
			tb.ForeColor = fgcolor;
			tb.BackColor = bgcolor;
			tb.Text = text;
			f.Controls.Add(tb);
		}
	}
}
