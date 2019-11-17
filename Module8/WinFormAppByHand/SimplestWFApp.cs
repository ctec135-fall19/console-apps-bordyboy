using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
    class Program
    {
        static void Main() 
        {
            Application.Run(new MainWindow("MyWindow", 200, 300));
        }
    }
	
    class MainWindow : Form 
    {
        private MenuStrip simpleMainMenu = new MenuStrip();
        private ToolStripMenuItem simpleMenuFile = new ToolStripMenuItem();
        private ToolStripMenuItem simpleMenuFileExit = new ToolStripMenuItem();


        public MainWindow(string title,int width,int height) {
            Text = title;
            Width = width;
            Height = height;

            CenterToScreen();

            CreateMenu();
        }

        public void CreateMenu()
        {
            simpleMenuFile.Text = "&File";
            simpleMainMenu.Items.Add(simpleMenuFile);

            simpleMenuFileExit.Text = "E&xit";
            simpleMenuFile.DropDownItems.Add(simpleMenuFileExit);
            simpleMenuFileExit.Click += new System.EventHandler(this.simpleMenuFileExit_Click);

            Controls.Add(this.simpleMainMenu);
            MainMenuStrip = this.simpleMainMenu;

        }

        private void simpleMenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}