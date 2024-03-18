using System.Reflection;
using System.Resources;

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
           // string infResource = GetPath(cursorName);
            // object? infResource = Properties.Resources.ResourceManager.GetObject(cursorName);
            string infResource = string.Format($@".\Resources\{cursorName}\{cursorName}.inf");

            // Execute the INF file to install the cursor
            System.Diagnostics.Process.Start("rundll32.exe", $"advpack.dll,LaunchINFSectionEx {infResource},,,4");
        }

        private void RemoveCursor(string cursorName)
        {
            string infResource = GetPath(cursorName);

            // Execute the INF file to install the cursor
            System.Diagnostics.Process.Start("rundll32.exe", $"advpack.dll,LaunchINFSectionEx {infResource},,,256");
        }

        protected static string GetPath(string resourcePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());

            //resourcePath = resourcePath.Replace('/', '.');
            //resourcePath = resourcePath.Replace('\\', '.');
            resourcePath = resourceNames.FirstOrDefault(r => r.Contains(resourcePath));

            if (resourcePath == null)
                throw new FileNotFoundException("Resource not found");

            return assembly.GetManifestResourceInfo(resourcePath).ResourceLocation.ToString();
        }

        //internal static string GetPath(string resourceFileName)
        //{
        //   string cursorPathInfo = Assembly.GetExecutingAssembly().GetManifestResourceInfo(resourceFileName).ResourceLocation.ToString();
           
        //    return cursorPathInfo;           
        //}

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
            InstallCursor("oxy-hotorange");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-lilac");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InstallCursor("oxy-midnight_meadow");
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
            InstallCursor("oxy-sea_blue");
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
            InstallCursor("oxy-terra_green");
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
