using System;
using System.Threading;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;

namespace DSTCertFix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        readonly localization localization = new localization();
        String lang;

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            lang = Get_language();

            this.Text = localization.Get_string(lang, "formTitle");
            MaingroupBox.Text = localization.Get_string(lang, "groupBoxTitle");
            currentUserRadio.Text = localization.Get_string(lang, "currentUserRadio");
            localMachineRadio.Text = localization.Get_string(lang, "localMachineRadio");
            fixSubmit.Text = localization.Get_string(lang, "FixSumbit");
            helpStatusLabel.Text = localization.Get_string(lang, "helpStripLink");
            LanguagesDropDown.ToolTipText = localization.Get_string(lang, "languageSelectTooltip");
            englishToolStripMenuItem.Text = localization.Get_string(lang, "englishToolStrip");
            greekToolStripMenuItem.Text = localization.Get_string(lang, "greekToolStrip");

            MaingroupBox.Width = TextRenderer.MeasureText(MaingroupBox.Text, MaingroupBox.Font).Width + 25;
            this.Width = MaingroupBox.Width + 42;

            var args = Environment.GetCommandLineArgs();
            if (!IsAdministrator())
            {
                Size iconSize = SystemInformation.SmallIconSize;
                Bitmap uac_shield = new Bitmap(iconSize.Width, iconSize.Height);
                using (Graphics g = Graphics.FromImage(uac_shield))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(SystemIcons.Shield.ToBitmap(), new Rectangle(Point.Empty, iconSize));
                }
                UACpictureBox.Image = uac_shield;
                UACpictureBox.Visible = true;
            }
            else if (args.Length > 1 && args[1] == "execMachine")
            {
                Smb_lock(true);
                localMachineRadio.Checked = true;
                Thread lMc = new Thread(() => Certificate_manager(StoreLocation.LocalMachine));
                lMc.Start();
            }
        }

        private string Get_language()
        {
            if (Properties.Settings.Default.language != "")
            {
                if (Properties.Settings.Default.language == "el")
                {
                    return "el";
                } else
                {
                    return "en";
                }
            }
            else if (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName == "el")
            {
                return "el";
            }
            return "en";
        }

        private void FixSubmit_Click(object sender, EventArgs e)
        {
            var detector = new browser_detect();
            if (detector.BrowserIsOpen())
            {
                MessageBox.Show(localization.Get_string(lang, "browserOpenMessage"), localization.Get_string(lang, "browserOpenTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (currentUserRadio.Checked)
                {
                    Smb_lock(true);
                    Thread cUc_Thread = new Thread(() => Certificate_manager());
                    cUc_Thread.Start();

                }
                else if (localMachineRadio.Checked)
                {
                    Smb_lock(true);
                    Thread lMc_Thread = new Thread(() => LocalMachine_construct());
                    lMc_Thread.Start();
                }
                else
                {
                    MessageBox.Show(this, localization.Get_string(lang, "noSelectMessage"), localization.Get_string(lang, "noSelectDialogTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Certificate_manager(StoreLocation store_loc = StoreLocation.CurrentUser)
        {
            try
            {
                X509Store cert_store = new X509Store(StoreName.Root, store_loc);
                cert_store.Open(OpenFlags.ReadWrite | OpenFlags.IncludeArchived);
                X509Certificate2Collection cert_col = cert_store.Certificates;
                X509Certificate2Collection dst_col = cert_col.Find(X509FindType.FindBySubjectName, "DST Root CA X3", false);
                foreach (var dst_cert in dst_col)
                {
                    cert_store.Remove(dst_cert);
                }
                X509Certificate2Collection isgr_col = cert_col.Find(X509FindType.FindBySubjectName, "ISRG Root X1", false);
                if (isgr_col.Count == 0)
                {
                    X509Certificate2 isgr_cert = new X509Certificate2(Properties.Resources.isrgrootx1);
                    cert_store.Add(isgr_cert);
                }
                cert_store.Close();
                this.Invoke(new Action(() => {
                    String msgbox_msg = "";
                    if (store_loc == StoreLocation.CurrentUser)
                    {
                        msgbox_msg = localization.Get_string(lang, "successLocalMessage");
                    } else
                    {
                        msgbox_msg = localization.Get_string(lang, "successMachineMessage");
                    }
                    MessageBox.Show(this, msgbox_msg, localization.Get_string(lang, "successDialogTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));

            }
            catch (Exception e)
            {
                ShowError_msg(e.Message, e.GetType().Name);
            }
            Smb_lock(false);
        }

        private void LocalMachine_construct()
        {
            if (!IsAdministrator())
            {
                try
                {
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName, "execMachine");
                    startInfo.Verb = "runas";
                    Process.Start(startInfo);
                    Application.Exit();
                    return;
                }
                
                catch (Exception)
                {
                    this.Invoke(new Action(() => {
                        DialogResult adm_access = MessageBox.Show(this, localization.Get_string(lang, "uacMessage"), localization.Get_string(lang, "uacDialogTitle"), MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        if (adm_access == DialogResult.Retry)
                        {
                            Thread lmc_retry = new Thread(() => Certificate_manager(StoreLocation.LocalMachine));
                            lmc_retry.Start();
                        } else
                        {
                            Smb_lock(false);
                        }                        
                    }));
                }
            }
            else
            {
                Thread lMc_Thread = new Thread(() => Certificate_manager(StoreLocation.LocalMachine));
                lMc_Thread.Start();
            }
        }

        private void ShowError_msg(string message, string type)
        {
            String error_msg = localization.Get_string(lang, "errorMainMessage") + Environment.NewLine + localization.Get_string(lang, "errorType") + type + Environment.NewLine + localization.Get_string(lang, "errorMessageStr") + message;
            this.Invoke(new Action(() => {
                MessageBox.Show(error_msg, localization.Get_string(lang, "errorDialogTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }

        private void Smb_lock(Boolean enable)
        {
            if (enable)
            {
                this.Invoke(new Action(() => {
                    fixSubmit.Enabled = false;
                    toolStripProgressBar.Visible = true;
                }));
            } else
            {
                this.Invoke(new Action(() => {
                    fixSubmit.Enabled = true;
                    toolStripProgressBar.Visible = false;
                }));
            }
        }

        private void EnableFix_btn(object sender, EventArgs e)
        {
            fixSubmit.Enabled = true;
        }

        private void UACpictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(localization.Get_string(lang, "uacInfoDialog"), localization.Get_string(lang, "uacInfoDialogTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpStatusLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/giannisftaras/dstcertfix");
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "en";
            Properties.Settings.Default.Save();
            ApplicationRestart();
        }

        private void GreekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "el";
            Properties.Settings.Default.Save();
            ApplicationRestart();
        }

        private void ApplicationRestart()
        {
            var exeName = Process.GetCurrentProcess().MainModule.FileName;
            ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
            Process.Start(startInfo);
            Application.Exit();
            return;
        }
    }
}
