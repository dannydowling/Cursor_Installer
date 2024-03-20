using System.IO.Pipes;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Cursor_Installer
{
    public partial class Form1 : Form
    {

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        public Form1()
        {
            InitializeComponent();
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            // Create NotifyIcon
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application; //change to a better icon
            notifyIcon.Text = "Cursors";

            // Create ContextMenuStrip
            contextMenuStrip = new ContextMenuStrip();

            // Add menu items to ContextMenuStrip
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open");
            openMenuItem.Click += OpenMenuItem_Click;
            contextMenuStrip.Items.Add(openMenuItem);

            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += ExitMenuItem_Click;
            contextMenuStrip.Items.Add(exitMenuItem);

            // Assign ContextMenuStrip to NotifyIcon
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Handle MouseClick event to open the form on left-click
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Open the form on left-click
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            // Open the form when "Open" menu item is clicked
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application when "Exit" menu item is clicked
            notifyIcon.Visible = false;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hide the form instead of closing it when the close button is clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void InstallCursor(string cursorName)
        {
            try
            {
                // Send message to the service worker
                string message = cursorName;
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "cursorInstallPipeline", PipeDirection.Out))
                {
                    pipeClient.Connect();
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    pipeClient.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception)
            {
                string infResource = string.Format($@".\Resources\{cursorName}\{cursorName}.inf");
                System.Diagnostics.Process.Start("rundll32.exe", $"syssetup,SetupInfObjectInstallAction DefaultInstall 132 {infResource}");
            }
        }

        private void RemoveCursor(string cursorName)
        {
            string infResource = GetPath(cursorName);
            // Execute the INF file to uninstall the cursor
            System.Diagnostics.Process.Start("rundll32.exe", $"advpack.dll,LaunchINFSectionEx {infResource},,,256");
        }

        protected static string GetPath(string resourcePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());
            resourcePath = resourceNames.FirstOrDefault(r => r.Contains(resourcePath));

            if (resourcePath == null)
                throw new FileNotFoundException("Resource not found");

            return assembly.GetManifestResourceInfo(resourcePath).ResourceLocation.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-black");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-blue");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-bluecurve");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-brown");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-cherry");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-chrome");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-desert");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-emerald");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-green");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-grey");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-honeycomb");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-hot-orange");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-lilac");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-midnight-meadow");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-navy");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-norway");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-obsidian");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-obsidian-hc");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-olympus");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-olympus-inv");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-orchid");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-oxygen");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-peach");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-purple");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-red");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-red-argentina");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-sea-blue");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-steel");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-terra");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-terra-green");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-violet");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-viorange");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-white");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-whitewater");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-wonton");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-yellow");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-zion");
        }
    }
}
