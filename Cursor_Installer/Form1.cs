using System.Reflection;

namespace Cursor_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void InstallCursor(string cursorName)
        {
            string infResource = GERString(cursorName);

            // Execute the INF file to install the cursor
            System.Diagnostics.Process.Start("rundll32.exe", $"shell32.dll,Control_RunDLL {infResource}");
        }

        internal static string GERString(string resourceFileName)
        {
            var stream = GetEmbeddedResourceStream(Assembly.GetCallingAssembly(), resourceFileName);
            using (var streamReader = new StreamReader(stream))
            {
                return streamReader.ReadToEnd();
            }
        }

        internal static Stream GetEmbeddedResourceStream(Assembly assembly, string resourceFileName)

        {
            var resourceNames = assembly.GetManifestResourceNames();
            var resourcePaths = resourceNames
                .Where(x => x.EndsWith(resourceFileName, StringComparison.CurrentCultureIgnoreCase))
                .ToArray();
            return assembly.GetManifestResourceStream(resourcePaths.Single());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-black.inf");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-blue.inf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-bluecurve.inf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-brown.inf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-cherry.inf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-chrome.inf");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-desert.inf");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-emerald.inf");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-green.inf");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-grey.inf");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-honeycomb.inf");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-hotorange.inf");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-lilac.inf");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-midnight_meadow.inf");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-navy.inf");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-norway.inf");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-obsidian.inf");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-obsidian-hc.inf");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-olympus.inf");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-olympus-inv.inf");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-orchid.inf");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-oxygen.inf");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-peach.inf");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-purple.inf");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-red.inf");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-red-argentina.inf");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-sea_blue.inf");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-steel.inf");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-terra.inf");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-terra_green.inf");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-violet.inf");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-viorange.inf");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-white.inf");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-whitewater.inf");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-wonton.inf");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-yellow.inf");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-zion.inf");
        }
    }
}
