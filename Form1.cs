using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBatteryW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string formatSizeUnits(double bytes)
        {
            string strBytes;

            if (bytes >= 1000000000)
            {
                strBytes = Convert.ToString(Math.Round(Convert.ToDouble(bytes / 1000000000), 2) + " GB");
            }
            else if (bytes >= 1000000)
            {
                strBytes = Convert.ToString(Math.Round(Convert.ToDouble(bytes / 1000000), 2) + " MB");
            }
            else if (bytes >= 1000)
            {
                strBytes = Convert.ToString(Math.Round(Convert.ToDouble(bytes / 1000), 2) + " KB");
            }
            else if (bytes > 1)
            {
                strBytes = Convert.ToString(bytes + " bytes");
            }
            else if (bytes == 1)
            {
                strBytes = Convert.ToString(bytes + " byte");
            }
            else
            {
                strBytes = "0 byte";
            }
            return strBytes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("iTunes");
                foreach (System.Diagnostics.Process p in process)
                {
                    if (!string.IsNullOrEmpty(p.ProcessName))
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch { }
                    }
                }

                rbAnglais.Checked = true;
                tradEN();

                Process pair = new Process();
                pair.StartInfo.FileName = "cmd";
                pair.StartInfo.Verb = "runas";
                pair.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                pair.StartInfo.Arguments = "/k idevicepair.exe pair & exit";
                pair.StartInfo.ErrorDialog = true;
                pair.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pair.StartInfo.UseShellExecute = false;
                pair.StartInfo.CreateNoWindow = true;
                pair.StartInfo.RedirectStandardOutput = true;
                pair.Start();
                while (!pair.StandardOutput.EndOfStream)
                {
                    string line = pair.StandardOutput.ReadLine();

                    if (line.Contains("ERROR"))
                    {
                        MessageBox.Show("Please accept the trust dialog on the screen of your device and try again.\n\nVeuillez accepter la boîte de dialogue de confiance sur l'écran de votre appareil et réessayez.", "Error/Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RefreshAll();
                    }
                }
                pair.WaitForExit();

                if (lblDeviceName.Text == "" || lblDeviceName.Text == "DeviceName")
                {
                    btnRetrieveCrash.Enabled = false;
                }
                else
                {
                    btnRetrieveCrash.Enabled = true;
                }

                System.Diagnostics.Process[] process1 = System.Diagnostics.Process.GetProcessesByName("iTunes");
                foreach (System.Diagnostics.Process p in process1)
                {
                    if (!string.IsNullOrEmpty(p.ProcessName))
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch { }
                    }
                }
            }
            catch
            {
                MessageBox.Show("A error as occured. Please restart the tool and retry.\n\nUne erreur est survenue. Redémarrez l'utilitaire et réessayez.", "Error/Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void RefreshAll()
        {
            try
            {
                int iEstLa1 = 0;
                bool bEstDejaFait1 = false;

                int iEstLa2 = 0;
                bool bEstDejaFait2 = false;

                int iEstLa3 = 0;
                bool bEstDejaFait3 = false;

                int iEstLa4 = 0;
                bool bEstDejaFait4 = false;

                int iEstLa5 = 0;
                bool bEstDejaFait5 = false;

                int iEstLa6 = 0;
                bool bEstDejaFait6 = false;

                Process deviceName = new Process();
                deviceName.StartInfo.FileName = "cmd";
                deviceName.StartInfo.Verb = "runas";
                deviceName.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                deviceName.StartInfo.Arguments = "/k ideviceinfo.exe -k DeviceName & exit";
                deviceName.StartInfo.ErrorDialog = true;
                deviceName.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                deviceName.StartInfo.UseShellExecute = false;
                deviceName.StartInfo.CreateNoWindow = true;
                deviceName.StartInfo.RedirectStandardOutput = true;
                deviceName.Start();
                while (!deviceName.StandardOutput.EndOfStream)
                {
                    string line = deviceName.StandardOutput.ReadLine();
                    lblDeviceName.Text = line;
                }
                deviceName.WaitForExit();

                Process model = new Process();
                model.StartInfo.FileName = "cmd";
                model.StartInfo.Verb = "runas";
                model.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                model.StartInfo.Arguments = "/k ideviceinfo.exe -k ProductType & exit";
                model.StartInfo.ErrorDialog = true;
                model.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                model.StartInfo.UseShellExecute = false;
                model.StartInfo.CreateNoWindow = true;
                model.StartInfo.RedirectStandardOutput = true;
                model.Start();
                while (!model.StandardOutput.EndOfStream)
                {
                    string line = model.StandardOutput.ReadLine();
                    lblModel.Text = line;
                }
                model.WaitForExit();

                Process hardwareModel = new Process();
                hardwareModel.StartInfo.FileName = "cmd";
                hardwareModel.StartInfo.Verb = "runas";
                hardwareModel.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                hardwareModel.StartInfo.Arguments = "/k ideviceinfo.exe -k HardwareModel & exit";
                hardwareModel.StartInfo.ErrorDialog = true;
                hardwareModel.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                hardwareModel.StartInfo.UseShellExecute = false;
                hardwareModel.StartInfo.CreateNoWindow = true;
                hardwareModel.StartInfo.RedirectStandardOutput = true;
                hardwareModel.Start();
                while (!hardwareModel.StandardOutput.EndOfStream)
                {
                    string line = hardwareModel.StandardOutput.ReadLine();
                    lblHardwareModel.Text = line;
                }
                hardwareModel.WaitForExit();

                Process ios = new Process();
                ios.StartInfo.FileName = "cmd";
                ios.StartInfo.Verb = "runas";
                ios.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                ios.StartInfo.Arguments = "/k ideviceinfo.exe -k ProductVersion & exit";
                ios.StartInfo.ErrorDialog = true;
                ios.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ios.StartInfo.UseShellExecute = false;
                ios.StartInfo.CreateNoWindow = true;
                ios.StartInfo.RedirectStandardOutput = true;
                ios.Start();
                while (!ios.StandardOutput.EndOfStream)
                {
                    string line = ios.StandardOutput.ReadLine();
                    lbliOS.Text = line;
                }
                ios.WaitForExit();

                Process diskCapacity = new Process();
                diskCapacity.StartInfo.FileName = "cmd";
                diskCapacity.StartInfo.Verb = "runas";
                diskCapacity.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                diskCapacity.StartInfo.Arguments = "/k ideviceinfo.exe -q com.apple.disk_usage -k TotalDiskCapacity & exit";
                diskCapacity.StartInfo.ErrorDialog = true;
                diskCapacity.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                diskCapacity.StartInfo.UseShellExecute = false;
                diskCapacity.StartInfo.CreateNoWindow = true;
                diskCapacity.StartInfo.RedirectStandardOutput = true;
                diskCapacity.Start();
                while (!diskCapacity.StandardOutput.EndOfStream)
                {
                    string line = diskCapacity.StandardOutput.ReadLine();
                    lblDiskCapacity.Text = formatSizeUnits(Convert.ToDouble(line));
                }
                diskCapacity.WaitForExit();

                Process diskAvailable = new Process();
                diskAvailable.StartInfo.FileName = "cmd";
                diskAvailable.StartInfo.Verb = "runas";
                diskAvailable.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                diskAvailable.StartInfo.Arguments = "/k ideviceinfo.exe -q com.apple.disk_usage -k TotalDataCapacity & exit";
                diskAvailable.StartInfo.ErrorDialog = true;
                diskAvailable.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                diskAvailable.StartInfo.UseShellExecute = false;
                diskAvailable.StartInfo.CreateNoWindow = true;
                diskAvailable.StartInfo.RedirectStandardOutput = true;
                diskAvailable.Start();
                while (!diskAvailable.StandardOutput.EndOfStream)
                {
                    string line = diskAvailable.StandardOutput.ReadLine();
                    lblDiskUsed.Text = formatSizeUnits(Convert.ToDouble(line));
                }
                diskAvailable.WaitForExit();

                Process cycleCount = new Process();
                cycleCount.StartInfo.FileName = "cmd";
                cycleCount.StartInfo.Verb = "runas";
                cycleCount.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                cycleCount.StartInfo.Arguments = "/k idevicediagnostics.exe diagnostics GasGauge & exit";
                cycleCount.StartInfo.ErrorDialog = true;
                cycleCount.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cycleCount.StartInfo.UseShellExecute = false;
                cycleCount.StartInfo.CreateNoWindow = true;
                cycleCount.StartInfo.RedirectStandardOutput = true;
                cycleCount.Start();
                while (!cycleCount.StandardOutput.EndOfStream)
                {
                    if (bEstDejaFait1 == true)
                    {
                        iEstLa1++;
                    }
                    string line = cycleCount.StandardOutput.ReadLine();
                    if (iEstLa1 == 2)
                    {
                        line = line.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                        lblCycleCount.Text = line;
                        lblCycleCount.Text = lblCycleCount.Text.Replace(" ", "");
                    }
                    if (bEstDejaFait1 == false)
                    {
                        if (line.Contains("<key>CycleCount</key>"))
                        {
                            iEstLa1++;
                            bEstDejaFait1 = true;
                        }
                    }
                }
                cycleCount.WaitForExit();

                Process designCapacity = new Process();
                designCapacity.StartInfo.FileName = "cmd";
                designCapacity.StartInfo.Verb = "runas";
                designCapacity.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                designCapacity.StartInfo.Arguments = "/k idevicediagnostics.exe diagnostics GasGauge & exit";
                designCapacity.StartInfo.ErrorDialog = true;
                designCapacity.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                designCapacity.StartInfo.UseShellExecute = false;
                designCapacity.StartInfo.CreateNoWindow = true;
                designCapacity.StartInfo.RedirectStandardOutput = true;
                designCapacity.Start();
                while (!designCapacity.StandardOutput.EndOfStream)
                {
                    if (bEstDejaFait2 == true)
                    {
                        iEstLa2++;
                    }
                    string line = designCapacity.StandardOutput.ReadLine();
                    if (iEstLa2 == 2)
                    {
                        line = line.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                        lblDesignCapacity.Text = line;
                        lblDesignCapacity.Text = lblDesignCapacity.Text.Replace(" ", "") + " mAh";
                    }
                    if (bEstDejaFait2 == false)
                    {
                        if (line.Contains("<key>DesignCapacity</key>"))
                        {
                            iEstLa2++;
                            bEstDejaFait2 = true;
                        }
                    }
                }
                designCapacity.WaitForExit();

                Process actualCapacity = new Process();
                actualCapacity.StartInfo.FileName = "cmd";
                actualCapacity.StartInfo.Verb = "runas";
                actualCapacity.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                actualCapacity.StartInfo.Arguments = "/k idevicediagnostics.exe ioregentry AppleSmartBattery & exit";
                actualCapacity.StartInfo.ErrorDialog = true;
                actualCapacity.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                actualCapacity.StartInfo.UseShellExecute = false;
                actualCapacity.StartInfo.CreateNoWindow = true;
                actualCapacity.StartInfo.RedirectStandardOutput = true;
                actualCapacity.Start();
                while (!actualCapacity.StandardOutput.EndOfStream)
                {
                    if (bEstDejaFait3 == true)
                    {
                        iEstLa3++;
                    }
                    string line = actualCapacity.StandardOutput.ReadLine();
                    if (iEstLa3 == 2)
                    {
                        line = line.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                        lblActualCapacity.Text = line;
                        lblActualCapacity.Text = lblActualCapacity.Text.Replace(" ", "") + " mAh";

                    }
                    if (bEstDejaFait3 == false)
                    {
                        if (line.Contains("<key>NominalChargeCapacity</key>"))
                        {
                            iEstLa3++;
                            bEstDejaFait3 = true;
                        }
                    }
                }
                actualCapacity.WaitForExit();
                if (lblActualCapacity.Text == "ActualCapacity")
                {
                    Process actualCapacityOld = new Process();
                    actualCapacityOld.StartInfo.FileName = "cmd";
                    actualCapacityOld.StartInfo.Verb = "runas";
                    actualCapacityOld.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                    actualCapacityOld.StartInfo.Arguments = "/k idevicediagnostics.exe ioregentry AppleARMPMUCharger & exit";
                    actualCapacityOld.StartInfo.ErrorDialog = true;
                    actualCapacityOld.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    actualCapacityOld.StartInfo.UseShellExecute = false;
                    actualCapacityOld.StartInfo.CreateNoWindow = true;
                    actualCapacityOld.StartInfo.RedirectStandardOutput = true;
                    actualCapacityOld.Start();
                    while (!actualCapacityOld.StandardOutput.EndOfStream)
                    {
                        if (bEstDejaFait4 == true)
                        {
                            iEstLa4++;
                        }
                        string line1 = actualCapacityOld.StandardOutput.ReadLine();
                        if (iEstLa4 == 2)
                        {
                            line1 = line1.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                            lblActualCapacity.Text = line1;
                            lblActualCapacity.Text = lblActualCapacity.Text.Replace(" ", "") + " mAh";

                        }
                        if (bEstDejaFait4 == false)
                        {
                            if (line1.Contains("<key>MaxCapacity</key>"))
                            {
                                iEstLa4++;
                                bEstDejaFait4 = true;
                            }
                        }
                    }
                    actualCapacityOld.WaitForExit();
                }

                if (lblActualCapacity.Text.Contains("keyUpdate"))
                {
                    lblActualCapacity.Text = "???";
                }

                Process actualBattery = new Process();
                actualBattery.StartInfo.FileName = "cmd";
                actualBattery.StartInfo.Verb = "runas";
                actualBattery.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                actualBattery.StartInfo.Arguments = "/k ideviceinfo.exe -q com.apple.mobile.battery -k BatteryCurrentCapacity & exit";
                actualBattery.StartInfo.ErrorDialog = true;
                actualBattery.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                actualBattery.StartInfo.UseShellExecute = false;
                actualBattery.StartInfo.CreateNoWindow = true;
                actualBattery.StartInfo.RedirectStandardOutput = true;
                actualBattery.Start();
                while (!actualBattery.StandardOutput.EndOfStream)
                {
                    string line = actualBattery.StandardOutput.ReadLine();
                    lblActualCharge.Text = line + "%";
                }
                actualBattery.WaitForExit();

                if (Convert.ToInt32(lblActualCapacity.Text.Replace(" ", "").Replace("mAh", "")) > Convert.ToInt32(lblDesignCapacity.Text.Replace(" ", "").Replace("mAh", "")))
                {
                    string strActualCapacity = lblActualCapacity.Text;
                    string strDesignCapacity = lblDesignCapacity.Text;
                    lblDesignCapacity.Text = strActualCapacity;
                    lblActualCapacity.Text = strDesignCapacity;
                    lblBatteryLife.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblActualCapacity.Text.Replace("mAh", "").Replace(" ", "")) * 100 / Convert.ToDouble(lblDesignCapacity.Text.Replace("mAh", "").Replace(" ", "")))) + "%";
                }
                else
                {
                    lblBatteryLife.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblActualCapacity.Text.Replace("mAh", "").Replace(" ", "")) * 100 / Convert.ToDouble(lblDesignCapacity.Text.Replace("mAh", "").Replace(" ", "")))) + "%";
                }

                if (Convert.ToInt32(lblBatteryLife.Text.Replace("%", "")) >= 90)
                {
                    lblBatteryLife.ForeColor = Color.DarkGreen;

                    if (rbFrancais.Checked == true)
                    {
                        lblLifeStatus.Text = "Très bien";
                    }
                    else
                    {
                        lblLifeStatus.Text = "Very good";
                    }
                }
                else if (Convert.ToInt32(lblBatteryLife.Text.Replace("%", "")) >= 83 && Convert.ToInt32(lblBatteryLife.Text.Replace("%", "")) < 90)
                {
                    lblBatteryLife.ForeColor = Color.Green;

                    if (rbFrancais.Checked == true)
                    {
                        lblLifeStatus.Text = "Bien";
                    }
                    else
                    {
                        lblLifeStatus.Text = "Good";
                    }
                }
                else if (Convert.ToInt32(lblBatteryLife.Text.Replace("%", "")) < 83)
                {
                    lblBatteryLife.ForeColor = Color.Orange;

                    if (rbFrancais.Checked == true)
                    {
                        lblLifeStatus.Text = "Médiocre";
                    }
                    else
                    {
                        lblLifeStatus.Text = "Poor";
                    }
                }
                else if (Convert.ToInt32(lblBatteryLife.Text.Replace("%", "")) < 80)
                {
                    lblBatteryLife.ForeColor = Color.Red;

                    if (rbFrancais.Checked == true)
                    {
                        lblLifeStatus.Text = "Très mauvais";

                    }
                    else
                    {
                        lblLifeStatus.Text = "Very bad";
                    }
                }

                Process temperature = new Process();
                temperature.StartInfo.FileName = "cmd";
                temperature.StartInfo.Verb = "runas";
                temperature.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                temperature.StartInfo.Arguments = "/k idevicediagnostics.exe ioregentry AppleSmartBattery & exit";
                temperature.StartInfo.ErrorDialog = true;
                temperature.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                temperature.StartInfo.UseShellExecute = false;
                temperature.StartInfo.CreateNoWindow = true;
                temperature.StartInfo.RedirectStandardOutput = true;
                temperature.Start();
                while (!temperature.StandardOutput.EndOfStream)
                {
                    if (bEstDejaFait5 == true)
                    {
                        iEstLa5++;
                    }
                    string line = temperature.StandardOutput.ReadLine();
                    if (iEstLa5 == 2)
                    {
                        line = line.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                        lblTemperature.Text = line;
                        lblTemperature.Text = lblTemperature.Text.Insert(4, ".");
                        lblTemperature.Text = lblTemperature.Text.Replace(" ", "") + "°C";

                    }
                    if (bEstDejaFait5 == false)
                    {
                        if (line.Contains("<key>Temperature</key>"))
                        {
                            iEstLa5++;
                            bEstDejaFait5 = true;
                        }
                    }
                }
                temperature.WaitForExit();

                if (lblTemperature.Text == "Temperature")
                {
                    Process temperatureOld = new Process();
                    temperatureOld.StartInfo.FileName = "cmd";
                    temperatureOld.StartInfo.Verb = "runas";
                    temperatureOld.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                    temperatureOld.StartInfo.Arguments = "/k idevicediagnostics.exe ioregentry AppleARMPMUCharger & exit";
                    temperatureOld.StartInfo.ErrorDialog = true;
                    temperatureOld.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    temperatureOld.StartInfo.UseShellExecute = false;
                    temperatureOld.StartInfo.CreateNoWindow = true;
                    temperatureOld.StartInfo.RedirectStandardOutput = true;
                    temperatureOld.Start();
                    while (!temperatureOld.StandardOutput.EndOfStream)
                    {
                        if (bEstDejaFait6 == true)
                        {
                            iEstLa6++;
                        }
                        string line1 = temperatureOld.StandardOutput.ReadLine();
                        if (iEstLa6 == 2)
                        {
                            line1 = line1.Replace(" ", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("integer", "");
                            lblTemperature.Text = line1;
                            lblTemperature.Text = lblTemperature.Text.Insert(4, ".");
                            lblTemperature.Text = lblTemperature.Text.Replace(" ", "") + "°C";

                        }
                        if (bEstDejaFait6 == false)
                        {
                            if (line1.Contains("<key>Temperature</key>"))
                            {
                                iEstLa6++;
                                bEstDejaFait6 = true;
                            }
                        }
                    }
                    temperatureOld.WaitForExit();
                }

                if (lblTemperature.Text.Contains("keyUpdate"))
                {
                    lblTemperature.Text = "???";
                }
            }
            catch
            {
                if (lblDeviceName.Text.Contains("No device found"))
                {
                    MessageBox.Show("Your iDevice is not connected. Please connect it and refresh.\n\nVotre appareil n'est pas connecté. Connectez-le et rafraîchissez.", "Error/Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDeviceName.Text = "";
                    lblModel.Text = "";
                    lblHardwareModel.Text = "";
                    lbliOS.Text = "";
                    lblDiskUsed.Text = "";
                    lblDiskCapacity.Text = "";
                    lblDesignCapacity.Text = "";
                    lblActualCapacity.Text = "";
                    lblActualCharge.Text = "";
                    lblBatteryLife.Text = "";
                    lblTemperature.Text = "";
                    lblLifeStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("A error as occured. Please restart the tool and retry.\n\nUne erreur est survenue. Redémarrez l'utilitaire et réessayez.", "Error/Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tradFR()
        {
            gbSystem.Text = "Système";
            gbBattery.Text = "Batterie";

            lblDeviceNameT.Text = "Nom";
            lblModelT.Text = "Nom de modèle";
            lblHardwareModelT.Text = "Modèle physique";
            lbliOST.Text = "Version d'iOS";
            lblDiskCapacityT.Text = "Stockage total";
            lblDiskUsedT.Text = "Stockage utilisé";

            lblDesignCapacityT.Text = "Capacité nominale";
            lblActualCapacityT.Text = "Capacité actuelle";
            lblBatteryPercentageT.Text = "Pourcentage";
            lblBatteryLifeT.Text = "Capacité maximum";
            lblLifeStatusT.Text = "État";
            lblTemperatureT.Text = "Température";

            rbAnglais.Text = "Anglais";
            rbFrancais.Text = "Français";

            btnRefresh.Text = "Rafraîchir";
            btnRetrieveCrash.Text = "Supprimer les fichiers crash";

            switch (lblLifeStatus.Text)
            {
                case "Very good":
                    lblLifeStatus.Text = "Très bien";
                    break;
                case "Good":
                    lblLifeStatus.Text = "Bien";
                    break;
                case "Poor":
                    lblLifeStatus.Text = "Médiocre";
                    break;
                case "Very bad":
                    lblLifeStatus.Text = "Très mauvais";
                    break;
            }
        }

        private void tradEN()
        {
            gbSystem.Text = "System";
            gbBattery.Text = "Battery";

            lblDeviceNameT.Text = "Device name";
            lblModelT.Text = "Model name";
            lblHardwareModelT.Text = "Hardware model";
            lbliOST.Text = "iOS version";
            lblDiskCapacityT.Text = "Disk capacity";
            lblDiskUsedT.Text = "Disk used";

            lblDesignCapacityT.Text = "Design capacity";
            lblActualCapacityT.Text = "Actual capacity";
            lblBatteryPercentageT.Text = "Battery percentage";
            lblBatteryLifeT.Text = "Battery life";
            lblLifeStatusT.Text = "Life status";
            lblTemperatureT.Text = "Temperature";

            rbAnglais.Text = "English";
            rbFrancais.Text = "French";

            btnRefresh.Text = "Refresh";
            btnRetrieveCrash.Text = "Delete crash files";

            switch (lblLifeStatus.Text)
            {
                case "Très bien":
                    lblLifeStatus.Text = "Very good";
                    break;
                case "Bien":
                    lblLifeStatus.Text = "Good";
                    break;
                case "Médiocre":
                    lblLifeStatus.Text = "Poor";
                    break;
                case "Très mauvais":
                    lblLifeStatus.Text = "Very bad";
                    break;
            }
        }

        private void RbAnglais_CheckedChanged(object sender, EventArgs e)
        {
            tradEN();
        }

        private void RbFrancais_CheckedChanged(object sender, EventArgs e)
        {
            tradFR();
        }

        static long GetDirectorySize(string p)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("iBatteryW will delete all crash files from your device. Continue ?\n\niBatteryW va supprimer tous les fichiers de crash de votre appareil. Continuer ?", "Delete crash files/Supprimer les fichiers de crash", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnRetrieveCrash.Enabled = false;

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp"))
                {
                    System.IO.DirectoryInfo di1 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");

                    foreach (FileInfo file in di1.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di1.GetDirectories())
                    {
                        dir.Delete(true);
                    }

                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");
                }
                else
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");
                }

                Process crash = new Process();
                crash.StartInfo.FileName = "cmd";
                crash.StartInfo.Verb = "runas";
                crash.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                crash.StartInfo.Arguments = "/k idevicecrashreport.exe -e " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp" + " & exit";
                crash.StartInfo.ErrorDialog = true;
                crash.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                crash.Start();
                crash.WaitForExit();

                Cursor.Current = Cursors.WaitCursor;

                long lTaille = GetDirectorySize(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");

                System.IO.DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Temp");

                Cursor.Current = Cursors.Default;

                btnRetrieveCrash.Enabled = true;

                MessageBox.Show("Success. Released size : " + formatSizeUnits(Convert.ToDouble(lTaille)) + "\n\nSuccès. Taille libérée : " + formatSizeUnits(Convert.ToDouble(lTaille)), "Success/Succès", MessageBoxButtons.OK);
            }
        }
    }
}
