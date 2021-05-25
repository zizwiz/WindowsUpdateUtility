using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using help_about;
using Microsoft.Win32;

namespace WindowsUpdates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // write app version  number to GUI
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Process proc;


        /// <summary>
        /// Backup Registry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_backup_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Reg File|*.reg";
            saveFileDialog1.Title = "Backup Registry To ...";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string path = saveFileDialog1.FileName;
                    // ProcessStartInfo startInfo = new ProcessStartInfo("notepad.exe");
                    // startInfo.Verb = "runas";
                    //  startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //  proc = Process.Start(startInfo);


                    ProcessStartInfo startInfo = new ProcessStartInfo("regedit.exe", "/E " + saveFileDialog1.FileName);
                    startInfo.Verb = "runas";
                    proc = Process.Start(startInfo);
                    //MessageBox.Show("Registry has been exported");
                }
                catch (Exception)
                {
                    MessageBox.Show("Registry has not been exported");
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            proc.Kill();
        }

        /// <summary>
        /// Set Auto Update Options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_set_AUOptions_Click(object sender, EventArgs e)
        {

            /* Set the Auto Update Options. Num 2 is best to switch it all off.
         * o	2 — Notify for download and auto install.
           o	3 — Auto download and notify for install.
           o	4 — Auto download and schedule the install.
           o	5 — Allow local admin to choose settings.
           o	7 — Auto Download, Notify to install, Notify to Restart.
           
         */
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU");



            if (rdobtn_2.Checked)
            {
                key.SetValue("AUOptions", 2, RegistryValueKind.DWord);
            }
            else if (rdobtn_3.Checked)
            {
                key.SetValue("AUOptions", 3, RegistryValueKind.DWord);
            }
            else if (rdobtn_4.Checked)
            {
                key.SetValue("AUOptions", 4, RegistryValueKind.DWord);
            }
            else if (rdobtn_5.Checked)
            {
                key.SetValue("AUOptions", 5, RegistryValueKind.DWord);
            }
            else if (rdobtn_7.Checked)
            {
                key.SetValue("AUOptions", 7, RegistryValueKind.DWord);
            }
            else
            {
               DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the key from the Registry", "Question?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string Removekey = @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU";

                    DeleteRegistryFolder(RegistryHive.LocalMachine, Removekey);
                }

            }
            
            // Reboot 
            Process.Start("shutdown.exe", "-r -t 0");
        }

        private void btn_enable_disable_Click(object sender, EventArgs e)
        {
            //  Key is at HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU");

            if (rdobtn_enable.Checked) // Enable
            {
                key.SetValue("NoAutoUpdate", 1, RegistryValueKind.DWord);
            }
            else if (rdobtn_disable.Checked) // Disable
            {
                key.SetValue("NoAutoUpdate", 0, RegistryValueKind.DWord);
            }
            else // Remove
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the key from the Registry", "Question?",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string Removekey = @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU";

                    DeleteRegistryFolder(RegistryHive.LocalMachine, Removekey);
                }
            }

            key.Close();

            // Reboot 
            Process.Start("shutdown.exe", "-r -t 0");

        }

        public static void DeleteRegistryFolder(RegistryHive registryHive, string fullPathKeyToDelete)
        {
            using (var baseKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry64))
            {
                baseKey.DeleteSubKeyTree(fullPathKeyToDelete);
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
        }
    }
}