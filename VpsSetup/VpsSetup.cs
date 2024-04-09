using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VpsSetup
{
    public partial class VpsSetup : Form
    {
        private double appVersion = 1.3;

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);
        private const uint SPI_SETDESKWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x1;
        private const uint SPIF_SENDWININICHANGE = 0x2;

        private Random random = new Random();
        WebClient client = new WebClient();
        string toolboxs_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\tools";

        private List<string> chars = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private List<string> words = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public VpsSetup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VpsSetup_Load(object sender, EventArgs e)
        {
            this.Text += $" {appVersion.ToString("0.0")}";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        private void VpsSetup_Shown(object sender, EventArgs e)
        {
            textUser.Text = Environment.UserName;
            textPort.Text = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp").GetValue("PortNumber").ToString();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.0000.000 Safari/537.36");
            if (!Directory.Exists(toolboxs_folder))
            {
                Directory.CreateDirectory(toolboxs_folder);
                Thread.Sleep(1);
                new Task(() => {
                    // Chrome
                    downloadChrome();
                    // Firefox
                    downloadFirefox();
                    // DnsJumper
                    downloadDnsJumper();
                    // ndp472-kb4054531-web
                    downloadDotNet272();
                    // StartupManager
                    downloadStartupManager();
                    // UpdateTime
                    downloadUpdateTime();
                    // WindowsUpdateBlocker
                    downloadUpdateBlocker();
                    // WinRAR
                    downloadWinRAR();
                    // DONE
                }).Start();
            }
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full");
            if (key != null)
            {
                string netInstalled = key.GetValue("Version", "") as string;
                checkSetupNet472.Text += $" ({netInstalled} installed)";
            }
            buttonUser.Enabled = false;
            buttonPass.Enabled = false;
            buttonPort.Enabled = false;
        }

        private void VpsSetup_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void net(string arg)
        {
            var pp = new ProcessStartInfo("net.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void wmic(string arg)
        {
            var pp = new ProcessStartInfo("wmic.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void reg(string arg)
        {
            var pp = new ProcessStartInfo("reg.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void netsh(string arg)
        {
            var pp = new ProcessStartInfo("netsh.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void shutdown(string arg)
        {
            var pp = new ProcessStartInfo("shutdown.exe", "-a")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(1000);
            pp = new ProcessStartInfo("shutdown.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void taskkill(string exe)
        {
            var pp = new ProcessStartInfo("taskkill.exe", "/IM " + exe + " /F")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void tzutil(string zonename)
        {
            var pp = new ProcessStartInfo("tzutil.exe", "/s \"" + zonename + "\"")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void schtasks(string arg)
        {
            var pp = new ProcessStartInfo("schtasks.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void cacls(string arg)
        {
            var pp = new ProcessStartInfo("cacls.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void takeown(string arg)
        {
            var pp = new ProcessStartInfo("takeown.exe", arg)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(5000);
        }

        private void downloadChrome()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/Chrome.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\Chrome.zip";
            string execute_tools = toolboxs_folder + "\\ChromeSetup.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadFirefox()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/Firefox.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\Firefox.zip";
            string execute_tools = toolboxs_folder + "\\Firefox Installer.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadDnsJumper()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/DnsJumper.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\DnsJumper.zip";
            string execute_tools = toolboxs_folder + "\\DnsJumper.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadDotNet272()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/ndp472-kb4054531-web.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\ndp472-kb4054531-web.zip";
            string execute_tools = toolboxs_folder + "\\ndp472-kb4054531-web.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadStartupManager()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/StartupManager.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\StartupManager.zip";
            string execute_tools = toolboxs_folder + "\\StartupManager.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadUpdateTime()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/UpdateTime.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\UpdateTime.zip";
            string execute_tools = toolboxs_folder + "\\UpdateTime.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadUpdateBlocker()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/WindowsUpdateBlocker.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\WindowsUpdateBlocker.zip";
            string execute_tools = toolboxs_folder + "\\Wub.exe";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void downloadWinRAR()
        {
            string remote_tools = "https://github.com/CamPro/VPStools/raw/main/tools/WinRAR.zip?t=" + random.Next(1, 100);
            string local_tools = toolboxs_folder + "\\WinRAR.zip";
            string execute_tools = toolboxs_folder + "\\rarreg.key";
            if (!File.Exists(execute_tools))
            {
                client.DownloadFile(remote_tools, local_tools);
                Thread.Sleep(1);
                ZipFile.ExtractToDirectory(local_tools, toolboxs_folder);
                Thread.Sleep(1);
                File.Delete(local_tools);
            }
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            string pass = textPass.Text;
            if (string.IsNullOrEmpty(pass))
            {
                return;
            }
            string user = Environment.UserName;
            net("user \"" + user + "\" \"" + pass + "\"");
            buttonPass.ForeColor = Color.Blue;
            Clipboard.SetText(pass);
            shutdown("/r /t 1800");
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            string newUser = textUser.Text;
            if (string.IsNullOrEmpty(newUser))
            {
                return;
            }
            string curUser = Environment.UserName;
            wmic("useraccount where name='" + curUser + "' rename '" + newUser + "'");
            buttonUser.ForeColor = Color.Blue;
            buttonPass.Enabled = false;
            buttonRandomPass.Enabled = false;
            textPass.Enabled = false;
            shutdown("/r /t 1800");
        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(textPort.Text);
            reg("ADD \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp\" /v PortNumber /t REG_DWORD /d " + port + " /f");
            netsh("advfirewall firewall add rule name=\"Remote-Port\" dir=in action=allow protocol=TCP localport=" + port);
            buttonPort.ForeColor = Color.Blue;
            shutdown("/r /t 1800");
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            buttonPass.Enabled = !string.IsNullOrEmpty(textPass.Text);
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            buttonUser.Enabled = !string.IsNullOrEmpty(textUser.Text);
        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {
            buttonPort.Enabled = !string.IsNullOrEmpty(textPort.Text);
        }

        private void buttonRandomPass_Click(object sender, EventArgs e)
        {
            string text = this.chars[random.Next(0, 25)];
            for (int i = 0; i < 19; i++)
            {
                text += this.chars[random.Next(0, chars.Count - 1)];
            }
            textPass.Text = text;
        }

        private void buttonRandomUser_Click(object sender, EventArgs e)
        {
            string text = this.words[random.Next(0, 25)];
            for (int i = 0; i < 3; i++)
            {
                text += this.words[random.Next(0, words.Count - 1)];
            }
            textUser.Text = text;
        }

        private void buttonRandomPort_Click(object sender, EventArgs e)
        {
            textPort.Text = $"{random.Next(1025, 65535)}";
        }

        private void checkSetupFirefox_Click(object sender, EventArgs e)
        {
            // setup firefox
            string filename = toolboxs_folder + "\\Firefox Installer.exe";
            if (!File.Exists(filename))
            {
                downloadFirefox();
            }
            if (File.Exists(filename))
            {
                Process.Start(filename);
                // wait setup done
                string firefox = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
                for (int i = 0; i < 60; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (!Directory.Exists(firefox)) continue;
                    string[] folders = Directory.GetDirectories(firefox);
                    if (folders.Count() == 0) continue;
                    // get profile folder
                    foreach (var folder in folders)
                    {
                        if (folder.Contains("release"))
                        {
                            firefox = folder;
                            break;
                        }
                    }
                    taskkill("firefox.exe");
                    // copy bookmark
                    filename = toolboxs_folder + "\\places.sqlite";
                    if (File.Exists(filename))
                    {
                        File.Copy(filename, firefox + "\\places.sqlite", true);
                    }
                    // copy settings
                    filename = toolboxs_folder + "\\prefs.js";
                    if (File.Exists(filename))
                    {
                        File.Copy(filename, firefox + "\\prefs.js", true);
                    }
                    break;
                }
                checkSetupFirefox.Checked = true;
                checkSetupFirefox.ForeColor = Color.Blue;
            }
        }

        private void checkSetupChrome_Click(object sender, EventArgs e)
        {
            downloadChrome();
            // create default userdata
            string chrome = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default";
            if (!Directory.Exists(chrome)) Directory.CreateDirectory(chrome);
            // copy Bookmarks
            string filename = toolboxs_folder + "\\Bookmarks";
            if (File.Exists(filename))
            {
                File.Copy(filename, chrome + "\\Bookmarks", true);
            }
            // copy preferences
            filename = toolboxs_folder + "\\Preferences";
            if (File.Exists(filename))
            {
                File.Copy(filename, chrome + "\\Preferences", true);
            }
            // setup Chrome
            filename = toolboxs_folder + "\\ChromeSetup.exe";
            Process.Start(filename);
            checkSetupChrome.Checked = true;
            checkSetupChrome.ForeColor = Color.Blue;
        }

        private void checkDnsJumper_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\DnsJumper.exe";
            if (!File.Exists(filename))
            {
                downloadDnsJumper();
            }
            if (File.Exists(filename))
            {
                Process process = Process.Start(filename, "1.1.1.1,1.0.0.1");
                process.WaitForExit();
                checkDnsJumper.Checked = true;
                checkDnsJumper.ForeColor = Color.Blue;
            }
        }

        private void checkSetupGeneral_Click(object sender, EventArgs e)
        {
            // delete all schedule
            schtasks("/Delete /TN * /F");
            // setup taskbar & explorer
            reg("ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V TaskbarGlomLevel /t REG_DWORD /D 2 /F");
            reg("ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v Hidden /t REG_DWORD /d 1 /f");
            reg("ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v ShowSuperHidden /t REG_DWORD /d 1 /f");
            reg("ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\" /v EnableAutoTray /t REG_DWORD /d 0 /f");

            // delete Internet Explorer
            takeown(" /d y /r /a /f \"C:\\Program Files\\Internet Explorer\"");
            takeown(" /d y /r /a /f \"C:\\Program Files (x86)\\Internet Explorer\"");
            string filename = "C:\\Program Files\\Internet Explorer\\iexplore.exe";
            if (File.Exists(filename))
            {
                cacls($"\"{filename}\" /t /e /g Administrators:f");
                File.Delete(filename);
            }
            filename = "C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe";
            if (File.Exists(filename))
            {
                cacls($"\"{filename}\" /t /e /g Administrators:f");
                File.Delete(filename);
            }
            checkSetupGeneral.Checked = true;
            checkSetupGeneral.ForeColor = Color.Blue;
        }
        
        private static void DesktopPicture(string file_name)
        {
            uint flags = SPIF_UPDATEINIFILE; //update the registry
            if (!SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, file_name, flags))
            {
                Console.WriteLine("Error");
            }
        }

        private void checkUpdateTime_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\UpdateTime.exe";
            if (!File.Exists(filename))
            {
                downloadUpdateTime();
            }
            if (File.Exists(filename))
            {
                Process process = Process.Start(filename);
                process.WaitForExit();
                checkUpdateTime.Checked = true;
                checkUpdateTime.ForeColor = Color.Blue;
            }
        }

        private void checkInfoIP_Click(object sender, EventArgs e)
        {
            try
            {
                string country = "";
                string state = "";
                string city = "";
                string ip = "";
                string timezone = "";

                string dataJson = client.DownloadString("http://ip-api.com/json");

                SimpleJSON.JSONNode node = SimpleJSON.JSONNode.Parse(dataJson);

                timezone = node["timezone"].Value;
                foreach (var localize in timeZones)
                {
                    if (localize[2] == timezone)
                    {
                        tzutil(localize[0]); // change timezone
                        break;
                    }
                }
                country = node["country"].Value;
                state = node["regionName"].Value;
                ip = node["query"].Value;
                /*
                dataJson = client.DownloadString("http://api.ipstack.com/" + ip + "?access_key=d0af6fe00bd89197a34aa2a90d9f9650");
                node = SimpleJSON.JSONNode.Parse(dataJson);
                ip = node["ip"].Value;
                country2 = node["country_name"].Value;
                state2 = node["region_name"].Value;
                city = node["city"].Value;
                */
                checkInfoIP.Text = timezone;
                textInfoIP.Text = ip + " - " + state + ", " + country;

                checkInfoIP.Checked = true;
                checkInfoIP.ForeColor = Color.Blue;
            }
            catch { }
        }

        private void checkSetupWinrar_Click(object sender, EventArgs e)
        {
            string rar32 = "https://www.rarlab.com/rar/winrar-x32-624.exe";
            string rar64 = "https://www.rarlab.com/rar/winrar-x64-624.exe";
            string filename32 = toolboxs_folder + "\\winrar-x32-624.exe";
            string filename64 = toolboxs_folder + "\\winrar-x64-624.exe";
            string winrar64 = "C:\\Program Files\\WinRAR\\rarreg.key";
            string winrar32 = "C:\\Program Files (x86)\\WinRAR\\rarreg.key";
            if (File.Exists(winrar64) || File.Exists(winrar32))
            {
                checkSetupWinrar.Enabled = false;
                return;
            }
            if (Environment.Is64BitOperatingSystem)
            {
                if (!File.Exists(filename64))
                {
                    client.DownloadFile(rar64, filename64);
                }
                Process process = Process.Start(filename64, "/S");
                process.WaitForExit();
            }
            else
            {
                if (!File.Exists(filename32))
                {
                    client.DownloadFile(rar32, filename32);
                }
                Process process = Process.Start(filename32, "/S");
                process.WaitForExit();
            }
            Thread.Sleep(500);
            string rarreg = toolboxs_folder + "\\rarreg.key";
            if (!File.Exists(rarreg))
            {
                downloadWinRAR();
            }
            if (File.Exists(rarreg))
            {
                if (File.Exists(winrar64)) File.Copy(rarreg, winrar64, true);
                if (File.Exists(winrar32)) File.Copy(rarreg, winrar32, true);
            }
            checkSetupWinrar.Checked = true;
            checkSetupWinrar.ForeColor = Color.Blue;
        }

        private void checkSetup7Zip_Click(object sender, EventArgs e)
        {
            string zip32 = "https://www.7-zip.org/a/7z2301.exe";
            string zip64 = "https://www.7-zip.org/a/7z2301-x64.exe";
            string filename32 = toolboxs_folder + "\\7z2301.exe";
            string filename64 = toolboxs_folder + "\\7z2301-x64.exe";
            string sevenzip64 = "C:\\Program Files\\7-Zip\\7z.exe";
            string sevenzip32 = "C:\\Program Files (x86)\\7-Zip\\7z.exe";
            if (File.Exists(sevenzip64) || File.Exists(sevenzip32))
            {
                checkSetup7Zip.Enabled = false;
                return;
            }
            if (Environment.Is64BitOperatingSystem)
            {
                if (!File.Exists(filename64))
                {
                    client.DownloadFile(zip64, filename64);
                }
                Process process = Process.Start(filename64, "/S");
                process.WaitForExit();
            }
            else
            {
                if (!File.Exists(filename32))
                {
                    client.DownloadFile(zip32, filename32);
                }
                Process process = Process.Start(filename32, "/S");
                process.WaitForExit();
            }
            checkSetupWinrar.Checked = true;
            checkSetupWinrar.ForeColor = Color.Blue;
        }

        private void checkFixCopy_Click(object sender, EventArgs e)
        {
            string rdpclip = @"C:\Windows\Sysnative\rdpclip.exe";
            taskkill("rdpclip.exe");
            System.Threading.Thread.Sleep(500);
            if (File.Exists(rdpclip)) Process.Start(rdpclip);
            checkFixCopy.Checked = true;
            checkFixCopy.ForeColor = Color.Blue;
        }

        private void checkBlockUpdate_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\Wub.exe";
            if (!File.Exists(filename))
            {
                downloadUpdateBlocker();
            }
            if (File.Exists(filename))
            {
                Process process = Process.Start(filename, "/D /P");
                process.WaitForExit();
                checkBlockUpdate.Checked = true;
                checkBlockUpdate.ForeColor = Color.Blue;
            }
        }

        private void checkSetupNet472_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\ndp472-kb4054531-web.exe";
            if (!File.Exists(filename))
            {
                downloadDotNet272();
            }
            if (File.Exists(filename))
            {
                Process process = Process.Start(filename, "/q /norestart");
                process.WaitForExit();
                checkSetupNet472.Checked = true;
                checkSetupNet472.ForeColor = Color.Blue;
            }
        }

        private void checkSetupDesktop_Click(object sender, EventArgs e)
        {
            // setup desktop background
            string filedesktop = toolboxs_folder + "\\desktop.jpg";
            // down random image
            client.DownloadFile("https://source.unsplash.com/random/1366x768", filedesktop);
            Thread.Sleep(1);
            string filename = "C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg";
            if (File.Exists(filename) && File.Exists(filedesktop))
            {
                takeown(" /d y /r /a /f C:\\Windows\\Web\\Wallpaper\\Windows");
                cacls($"{filename} /t /e /g Administrators:f");
                File.Delete(filename);
                File.Copy(filedesktop, filename, true);
                DesktopPicture(filename);
            }
            filename = "C:\\Windows\\Web\\Screen\\img100.jpg";
            if (File.Exists(filename) && File.Exists(filedesktop))
            {
                takeown(" /d y /r /a /f C:\\Windows\\Web\\Screen");
                cacls($"{filename} /t /e /g Administrators:f");
                File.Delete(filename);
                File.Copy(filedesktop, filename, true);
                DesktopPicture(filename);
            }
            checkSetupDesktop.Checked = true;
            checkSetupDesktop.ForeColor = Color.Blue;
        }

        private void buttonCredSSP_Click(object sender, EventArgs e)
        {
            reg("ADD \"HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\CredSSP\\Parameters\" / f / v AllowEncryptionOracle / t REG_DWORD / d 2");
        }

        private void buttonRestartVps_Click(object sender, EventArgs e)
        {
            shutdown("/r /t 0");
            Application.Exit();
        }

        private void buttonDnsJumper_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\DnsJumper.exe";
            if (!File.Exists(filename))
            {
                downloadDnsJumper();
            }
            if (File.Exists(filename))
            {
                Process.Start(filename);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string delete = "echo off && timeout 3 && DEL /f /q /a /s \"" + Application.ExecutablePath + "\" && RD /s /q \"" + toolboxs_folder + "\"";
            string script = Path.GetTempPath() + "delete.bat";
            File.WriteAllText(script, delete);
            Process.Start(new ProcessStartInfo() {FileName = script, WindowStyle = ProcessWindowStyle.Hidden });
            Application.Exit();
        }

        private void pictureOpenCmd_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void pictureOpenControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }

        private void pictureOpenTaskMgr_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe", "/7");
        }

        private void pictureOpenPrograms_Click(object sender, EventArgs e)
        {
            Process.Start("appwiz.cpl");
        }

        private void pictureOpenTaskSchd_Click(object sender, EventArgs e)
        {
            Process.Start("taskschd.msc", "/s");
        }

        private void pictureOpenFirewall_Click(object sender, EventArgs e)
        {
            Process.Start("WF.msc");
        }

        private void pictureOpenStartup_Click(object sender, EventArgs e)
        {
            string filename = toolboxs_folder + "\\StartupManager.exe";
            if (!File.Exists(filename))
            {
                downloadStartupManager();
            }
            if (File.Exists(filename))
            {
                Process process = Process.Start(filename);
            }
        }

        private void pictureOpenWindef_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "windowsdefender:");
        }

        private List<string[]> timeZones = new List<string[]>()
        {
            new string[] {"Azores Standard Time", "(GMT-01:00) Azores", "Atlantic/Azores"},
            new string[] {"Cape Verde Standard Time", "(GMT-01:00) Cape Verde Islands", "Atlantic/Cape_Verde"},
            new string[] {"Mid-Atlantic Standard Time", "(GMT-02:00) Mid-Atlantic", "Atlantic/South_Georgia"},
            new string[] {"E. South America Standard Time", "(GMT-03:00) Brasilia", "America/Sao_Paulo"},
            new string[] {"SA Eastern Standard Time", "(GMT-03:00) Buenos Aires, Georgetown", "America/Argentina/Buenos_Aires"},
            new string[] {"Greenland Standard Time", "(GMT-03:00) Greenland", "America/Godthab"},
            new string[] {"Newfoundland Standard Time", "(GMT-03:30) Newfoundland and Labrador", "America/St_Johns"},
            new string[] {"Atlantic Standard Time", "(GMT-04:00) Atlantic Time (Canada)", "America/Halifax"},
            new string[] {"SA Western Standard Time", "(GMT-04:00) Caracas, La Paz", "America/La_Paz"},
            new string[] {"Central Brazilian Standard Time", "(GMT-04:00) Manaus", "America/Cuiaba"},
            new string[] {"Pacific SA Standard Time", "(GMT-04:00) Santiago", "America/Santiago"},
            new string[] {"SA Pacific Standard Time", "(GMT-05:00) Bogota, Lima, Quito", "America/Bogota"},
            new string[] {"Eastern Standard Time", "(GMT-05:00) Eastern Time (US and Canada)", "America/New_York"},
            new string[] {"US Eastern Standard Time", "(GMT-05:00) Indiana (East)", "America/Indiana/Indianapolis"},
            new string[] {"Central America Standard Time", "(GMT-06:00) Central America", "America/Costa_Rica"},
            new string[] {"Central Standard Time", "(GMT-06:00) Central Time (US and Canada)", "America/Chicago"},
            new string[] {"Central Standard Time (Mexico)", "(GMT-06:00) Guadalajara, Mexico City, Monterrey", "America/Monterrey"},
            new string[] {"Canada Central Standard Time", "(GMT-06:00) Saskatchewan", "America/Edmonton"},
            new string[] {"US Mountain Standard Time", "(GMT-07:00) Arizona", "America/Phoenix"},
            new string[] {"Mountain Standard Time (Mexico)", "(GMT-07:00) Chihuahua, La Paz, Mazatlan", "America/Chihuahua"},
            new string[] {"Mountain Standard Time", "(GMT-07:00) Mountain Time (US and Canada)", "America/Denver"},
            new string[] {"Pacific Standard Time", "(GMT-08:00) Pacific Time (US and Canada); Tijuana", "America/Tijuana"},
            new string[] {"Alaskan Standard Time", "(GMT-09:00) Alaska", "America/Anchorage"},
            new string[] {"Hawaiian Standard Time", "(GMT-10:00) Hawaii", "Pacific/Honolulu"},
            new string[] {"Samoa Standard Time", "(GMT-11:00) Midway Island, Samoa", "Pacific/Apia"},
            new string[] {"Greenwich Standard Time", "(GMT) Casablanca, Monrovia", "Africa/Monrovia"},
            new string[] {"GMT Standard Time", "(GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London", "Europe/London"},
            new string[] {"W. Europe Standard Time", "(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", "Europe/Berlin"},
            new string[] {"Central Europe Standard Time", "(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", "Europe/Belgrade"},
            new string[] {"Romance Standard Time", "(GMT+01:00) Brussels, Copenhagen, Madrid, Paris", "Europe/Paris"},
            new string[] {"Central European Standard Time", "(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb", "Europe/Belgrade"},
            new string[] {"W. Central Africa Standard Time", "(GMT+01:00) West Central Africa", "Africa/Lagos"},
            new string[] {"GTB Standard Time", "(GMT+02:00) Athens, Bucharest, Istanbul", "Europe/Istanbul"},
            new string[] {"Egypt Standard Time", "(GMT+02:00) Cairo", "Africa/Cairo"},
            new string[] {"South Africa Standard Time", "(GMT+02:00) Harare, Pretoria", "Africa/Harare"},
            new string[] {"FLE Standard Time", "(GMT+02:00) Helsinki, Kiev, Riga, Sofia, Tallinn, Vilnius", "Europe/Riga"},
            new string[] {"Israel Standard Time", "(GMT+02:00) Jerusalem", "Asia/Jerusalem"},
            new string[] {"E. Europe Standard Time", "(GMT+02:00) Minsk", "Europe/Minsk"},
            new string[] {"Namibia Standard Time", "(GMT+02:00) Windhoek", "Africa/Windhoek"},
            new string[] {"Arabic Standard Time", "(GMT+03:00) Baghdad", "Asia/Baghdad"},
            new string[] {"Arab Standard Time", "(GMT+03:00) Kuwait, Riyadh", "Asia/Kuwait"},
            new string[] {"Russian Standard Time", "(GMT+03:00) Moscow, St. Petersburg, Volgograd", "Europe/Moscow"},
            new string[] {"E. Africa Standard Time", "(GMT+03:00) Nairobi", "Africa/Nairobi"},
            new string[] {"Iran Standard Time", "(GMT+03:30) Tehran", "Asia/Tehran"},
            new string[] {"Arabian Standard Time", "(GMT+04:00) Abu Dhabi, Muscat", "Asia/Muscat"},
            new string[] {"Azerbaijan Standard Time", "(GMT+04:00) Baku", "Asia/Baku"},
            new string[] {"Georgian Standard Time", "(GMT+04:00) Tblisi", "Asia/Tbilisi"},
            new string[] {"Caucasus Standard Time", "(GMT+04:00) Yerevan", "Asia/Yerevan"},
            new string[] {"Afghanistan Standard Time", "(GMT+04:30) Kabul", "Asia/Kabul"},
            new string[] {"Ekaterinburg Standard Time", "(GMT+05:00) Ekaterinburg", "Asia/Yekaterinburg"},
            new string[] {"West Asia Standard Time", "(GMT+05:00) Islamabad, Karachi, Tashkent", "Asia/Tashkent"},
            new string[] {"India Standard Time", "(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi", "Asia/Calcutta"},
            new string[] {"Nepal Standard Time", "(GMT+05:45) Kathmandu", "Asia/Kathmandu"},
            new string[] {"N. Central Asia Standard Time", "(GMT+06:00) Almaty, Novosibirsk", "Asia/Novosibirsk"},
            new string[] {"Central Asia Standard Time", "(GMT+06:00) Astana, Dhaka", "Asia/Almaty"},
            new string[] {"Sri Lanka Standard Time", "(GMT+06:00) Sri Jayawardenepura", "Asia/Colombo"},
            new string[] {"Myanmar Standard Time", "(GMT+06:30) Yangon (Rangoon)", "Asia/Rangoon"},
            new string[] {"SE Asia Standard Time", "(GMT+07:00) Bangkok, Hanoi, Jakarta", "Asia/Bangkok"},
            new string[] {"North Asia Standard Time", "(GMT+07:00) Krasnoyarsk", "Asia/Krasnoyarsk"},
            new string[] {"China Standard Time", "(GMT+08:00) Beijing, Chongqing, Hong Kong SAR, Urumqi", "Asia/Shanghai"},
            new string[] {"North Asia East Standard Time", "(GMT+08:00) Irkutsk, Ulaanbaatar", "Asia/Irkutsk"},
            new string[] {"Singapore Standard Time", "(GMT+08:00) Kuala Lumpur, Singapore", "Asia/Singapore"},
            new string[] {"W. Australia Standard Time", "(GMT+08:00) Perth", "Australia/Perth"},
            new string[] {"Taipei Standard Time", "(GMT+08:00) Taipei", "Asia/Taipei"},
            new string[] {"Tokyo Standard Time", "(GMT+09:00) Osaka, Sapporo, Tokyo", "Asia/Tokyo"},
            new string[] {"Korea Standard Time", "(GMT+09:00) Seoul", "Asia/Seoul"},
            new string[] {"Yakutsk Standard Time", "(GMT+09:00) Yakutsk", "Asia/Yakutsk"},
            new string[] {"Cen. Australia Standard Time", "(GMT+09:30) Adelaide", "Australia/Adelaide"},
            new string[] {"AUS Central Standard Time", "(GMT+09:30) Darwin", "Australia/Darwin"},
            new string[] {"E. Australia Standard Time", "(GMT+10:00) Brisbane", "Australia/Brisbane"},
            new string[] {"AUS Eastern Standard Time", "(GMT+10:00) Canberra, Melbourne, Sydney", "Australia/Sydney"},
            new string[] {"West Pacific Standard Time", "(GMT+10:00) Guam, Port Moresby", "Pacific/Guam"},
            new string[] {"Tasmania Standard Time", "(GMT+10:00) Hobart", "Australia/Hobart"},
            new string[] {"Vladivostok Standard Time", "(GMT+10:00) Vladivostok", "Asia/Vladivostok"},
            new string[] {"Central Pacific Standard Time", "(GMT+11:00) Magadan, Solomon Islands, New Caledonia", "Pacific/Guadalcanal"},
            new string[] {"New Zealand Standard Time", "(GMT+12:00) Auckland, Wellington", "Pacific/Auckland"},
            new string[] {"Fiji Standard Time", "(GMT+12:00) Fiji Islands, Kamchatka, Marshall Islands", "Pacific/Fiji"},
            new string[] {"Tonga Standard Time", "(GMT+13:00) Nuku'alofa", "Pacific/Tongatapu"}
        };

    }
}
