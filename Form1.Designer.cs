namespace iBatteryW
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelT = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblHardwareModel = new System.Windows.Forms.Label();
            this.lblHardwareModelT = new System.Windows.Forms.Label();
            this.lbliOS = new System.Windows.Forms.Label();
            this.lbliOST = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblDeviceNameT = new System.Windows.Forms.Label();
            this.lblDiskCapacity = new System.Windows.Forms.Label();
            this.lblDiskCapacityT = new System.Windows.Forms.Label();
            this.lblDiskUsed = new System.Windows.Forms.Label();
            this.lblDiskUsedT = new System.Windows.Forms.Label();
            this.lblCycleCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDesignCapacity = new System.Windows.Forms.Label();
            this.lblDesignCapacityT = new System.Windows.Forms.Label();
            this.lblActualCapacity = new System.Windows.Forms.Label();
            this.lblActualCapacityT = new System.Windows.Forms.Label();
            this.lblActualCharge = new System.Windows.Forms.Label();
            this.lblBatteryPercentageT = new System.Windows.Forms.Label();
            this.lblBatteryLife = new System.Windows.Forms.Label();
            this.lblBatteryLifeT = new System.Windows.Forms.Label();
            this.lblLifeStatus = new System.Windows.Forms.Label();
            this.lblLifeStatusT = new System.Windows.Forms.Label();
            this.gbSystem = new System.Windows.Forms.GroupBox();
            this.gbBattery = new System.Windows.Forms.GroupBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTemperatureT = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbFrancais = new System.Windows.Forms.RadioButton();
            this.rbAnglais = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetrieveCrash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbSystem.SuspendLayout();
            this.gbBattery.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "iBatteryW";
            // 
            // lblModelT
            // 
            this.lblModelT.AutoSize = true;
            this.lblModelT.Location = new System.Drawing.Point(15, 50);
            this.lblModelT.Name = "lblModelT";
            this.lblModelT.Size = new System.Drawing.Size(36, 13);
            this.lblModelT.TabIndex = 1;
            this.lblModelT.Text = "Model";
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(117, 50);
            this.lblModel.Name = "lblModel";
            this.lblModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModel.Size = new System.Drawing.Size(109, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHardwareModel
            // 
            this.lblHardwareModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardwareModel.Location = new System.Drawing.Point(120, 75);
            this.lblHardwareModel.Name = "lblHardwareModel";
            this.lblHardwareModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHardwareModel.Size = new System.Drawing.Size(106, 13);
            this.lblHardwareModel.TabIndex = 4;
            this.lblHardwareModel.Text = "HardwareModel";
            this.lblHardwareModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHardwareModelT
            // 
            this.lblHardwareModelT.AutoSize = true;
            this.lblHardwareModelT.Location = new System.Drawing.Point(15, 75);
            this.lblHardwareModelT.Name = "lblHardwareModelT";
            this.lblHardwareModelT.Size = new System.Drawing.Size(84, 13);
            this.lblHardwareModelT.TabIndex = 3;
            this.lblHardwareModelT.Text = "Hardware model";
            // 
            // lbliOS
            // 
            this.lbliOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliOS.Location = new System.Drawing.Point(120, 100);
            this.lbliOS.Name = "lbliOS";
            this.lbliOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbliOS.Size = new System.Drawing.Size(106, 13);
            this.lbliOS.TabIndex = 6;
            this.lbliOS.Text = "iOSVersion";
            this.lbliOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbliOST
            // 
            this.lbliOST.AutoSize = true;
            this.lbliOST.Location = new System.Drawing.Point(15, 100);
            this.lbliOST.Name = "lbliOST";
            this.lbliOST.Size = new System.Drawing.Size(61, 13);
            this.lbliOST.TabIndex = 5;
            this.lbliOST.Text = "iOS version";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(91, 25);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeviceName.Size = new System.Drawing.Size(135, 13);
            this.lblDeviceName.TabIndex = 8;
            this.lblDeviceName.Text = "DeviceName";
            this.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeviceNameT
            // 
            this.lblDeviceNameT.AutoSize = true;
            this.lblDeviceNameT.Location = new System.Drawing.Point(15, 25);
            this.lblDeviceNameT.Name = "lblDeviceNameT";
            this.lblDeviceNameT.Size = new System.Drawing.Size(70, 13);
            this.lblDeviceNameT.TabIndex = 7;
            this.lblDeviceNameT.Text = "Device name";
            // 
            // lblDiskCapacity
            // 
            this.lblDiskCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskCapacity.Location = new System.Drawing.Point(120, 125);
            this.lblDiskCapacity.Name = "lblDiskCapacity";
            this.lblDiskCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiskCapacity.Size = new System.Drawing.Size(106, 13);
            this.lblDiskCapacity.TabIndex = 10;
            this.lblDiskCapacity.Text = "DiskCapacity";
            this.lblDiskCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiskCapacityT
            // 
            this.lblDiskCapacityT.AutoSize = true;
            this.lblDiskCapacityT.Location = new System.Drawing.Point(15, 125);
            this.lblDiskCapacityT.Name = "lblDiskCapacityT";
            this.lblDiskCapacityT.Size = new System.Drawing.Size(71, 13);
            this.lblDiskCapacityT.TabIndex = 9;
            this.lblDiskCapacityT.Text = "Disk capacity";
            // 
            // lblDiskUsed
            // 
            this.lblDiskUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskUsed.Location = new System.Drawing.Point(123, 150);
            this.lblDiskUsed.Name = "lblDiskUsed";
            this.lblDiskUsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiskUsed.Size = new System.Drawing.Size(103, 13);
            this.lblDiskUsed.TabIndex = 12;
            this.lblDiskUsed.Text = "DiskUsed";
            this.lblDiskUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiskUsedT
            // 
            this.lblDiskUsedT.AutoSize = true;
            this.lblDiskUsedT.Location = new System.Drawing.Point(15, 150);
            this.lblDiskUsedT.Name = "lblDiskUsedT";
            this.lblDiskUsedT.Size = new System.Drawing.Size(54, 13);
            this.lblDiskUsedT.TabIndex = 11;
            this.lblDiskUsedT.Text = "Disk used";
            // 
            // lblCycleCount
            // 
            this.lblCycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycleCount.Location = new System.Drawing.Point(103, 217);
            this.lblCycleCount.Name = "lblCycleCount";
            this.lblCycleCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCycleCount.Size = new System.Drawing.Size(132, 13);
            this.lblCycleCount.TabIndex = 14;
            this.lblCycleCount.Text = "CycleCount";
            this.lblCycleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cycle count";
            // 
            // lblDesignCapacity
            // 
            this.lblDesignCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignCapacity.Location = new System.Drawing.Point(95, 26);
            this.lblDesignCapacity.Name = "lblDesignCapacity";
            this.lblDesignCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDesignCapacity.Size = new System.Drawing.Size(129, 13);
            this.lblDesignCapacity.TabIndex = 16;
            this.lblDesignCapacity.Text = "DesignCapacity";
            this.lblDesignCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesignCapacityT
            // 
            this.lblDesignCapacityT.AutoSize = true;
            this.lblDesignCapacityT.Location = new System.Drawing.Point(13, 26);
            this.lblDesignCapacityT.Name = "lblDesignCapacityT";
            this.lblDesignCapacityT.Size = new System.Drawing.Size(83, 13);
            this.lblDesignCapacityT.TabIndex = 15;
            this.lblDesignCapacityT.Text = "Design capacity";
            // 
            // lblActualCapacity
            // 
            this.lblActualCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualCapacity.Location = new System.Drawing.Point(99, 53);
            this.lblActualCapacity.Name = "lblActualCapacity";
            this.lblActualCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblActualCapacity.Size = new System.Drawing.Size(125, 13);
            this.lblActualCapacity.TabIndex = 18;
            this.lblActualCapacity.Text = "ActualCapacity";
            this.lblActualCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActualCapacityT
            // 
            this.lblActualCapacityT.AutoSize = true;
            this.lblActualCapacityT.Location = new System.Drawing.Point(13, 53);
            this.lblActualCapacityT.Name = "lblActualCapacityT";
            this.lblActualCapacityT.Size = new System.Drawing.Size(80, 13);
            this.lblActualCapacityT.TabIndex = 17;
            this.lblActualCapacityT.Text = "Actual capacity";
            // 
            // lblActualCharge
            // 
            this.lblActualCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualCharge.Location = new System.Drawing.Point(116, 80);
            this.lblActualCharge.Name = "lblActualCharge";
            this.lblActualCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblActualCharge.Size = new System.Drawing.Size(108, 13);
            this.lblActualCharge.TabIndex = 20;
            this.lblActualCharge.Text = "ActualCharge";
            this.lblActualCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBatteryPercentageT
            // 
            this.lblBatteryPercentageT.AutoSize = true;
            this.lblBatteryPercentageT.Location = new System.Drawing.Point(13, 80);
            this.lblBatteryPercentageT.Name = "lblBatteryPercentageT";
            this.lblBatteryPercentageT.Size = new System.Drawing.Size(97, 13);
            this.lblBatteryPercentageT.TabIndex = 19;
            this.lblBatteryPercentageT.Text = "Battery percentage";
            // 
            // lblBatteryLife
            // 
            this.lblBatteryLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLife.Location = new System.Drawing.Point(116, 107);
            this.lblBatteryLife.Name = "lblBatteryLife";
            this.lblBatteryLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBatteryLife.Size = new System.Drawing.Size(108, 13);
            this.lblBatteryLife.TabIndex = 22;
            this.lblBatteryLife.Text = "BatteryLife";
            this.lblBatteryLife.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBatteryLifeT
            // 
            this.lblBatteryLifeT.AutoSize = true;
            this.lblBatteryLifeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLifeT.Location = new System.Drawing.Point(13, 107);
            this.lblBatteryLifeT.Name = "lblBatteryLifeT";
            this.lblBatteryLifeT.Size = new System.Drawing.Size(56, 13);
            this.lblBatteryLifeT.TabIndex = 21;
            this.lblBatteryLifeT.Text = "Battery life";
            // 
            // lblLifeStatus
            // 
            this.lblLifeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeStatus.Location = new System.Drawing.Point(116, 134);
            this.lblLifeStatus.Name = "lblLifeStatus";
            this.lblLifeStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLifeStatus.Size = new System.Drawing.Size(108, 13);
            this.lblLifeStatus.TabIndex = 24;
            this.lblLifeStatus.Text = "LifeStatus";
            this.lblLifeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLifeStatusT
            // 
            this.lblLifeStatusT.AutoSize = true;
            this.lblLifeStatusT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeStatusT.Location = new System.Drawing.Point(13, 134);
            this.lblLifeStatusT.Name = "lblLifeStatusT";
            this.lblLifeStatusT.Size = new System.Drawing.Size(55, 13);
            this.lblLifeStatusT.TabIndex = 23;
            this.lblLifeStatusT.Text = "Life status";
            // 
            // gbSystem
            // 
            this.gbSystem.Controls.Add(this.lblDiskUsed);
            this.gbSystem.Controls.Add(this.lblModelT);
            this.gbSystem.Controls.Add(this.lblModel);
            this.gbSystem.Controls.Add(this.lblHardwareModelT);
            this.gbSystem.Controls.Add(this.lblHardwareModel);
            this.gbSystem.Controls.Add(this.lbliOST);
            this.gbSystem.Controls.Add(this.lbliOS);
            this.gbSystem.Controls.Add(this.lblDeviceNameT);
            this.gbSystem.Controls.Add(this.lblDeviceName);
            this.gbSystem.Controls.Add(this.lblDiskCapacityT);
            this.gbSystem.Controls.Add(this.lblDiskCapacity);
            this.gbSystem.Controls.Add(this.lblDiskUsedT);
            this.gbSystem.Location = new System.Drawing.Point(12, 60);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.Size = new System.Drawing.Size(242, 176);
            this.gbSystem.TabIndex = 25;
            this.gbSystem.TabStop = false;
            this.gbSystem.Text = "System";
            // 
            // gbBattery
            // 
            this.gbBattery.Controls.Add(this.lblTemperature);
            this.gbBattery.Controls.Add(this.lblTemperatureT);
            this.gbBattery.Controls.Add(this.lblActualCapacity);
            this.gbBattery.Controls.Add(this.lblDesignCapacityT);
            this.gbBattery.Controls.Add(this.lblLifeStatus);
            this.gbBattery.Controls.Add(this.lblDesignCapacity);
            this.gbBattery.Controls.Add(this.lblLifeStatusT);
            this.gbBattery.Controls.Add(this.lblActualCapacityT);
            this.gbBattery.Controls.Add(this.lblBatteryLife);
            this.gbBattery.Controls.Add(this.lblBatteryPercentageT);
            this.gbBattery.Controls.Add(this.lblBatteryLifeT);
            this.gbBattery.Controls.Add(this.lblActualCharge);
            this.gbBattery.Location = new System.Drawing.Point(12, 242);
            this.gbBattery.Name = "gbBattery";
            this.gbBattery.Size = new System.Drawing.Size(242, 189);
            this.gbBattery.TabIndex = 26;
            this.gbBattery.TabStop = false;
            this.gbBattery.Text = "Battery";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(94, 161);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemperature.Size = new System.Drawing.Size(130, 13);
            this.lblTemperature.TabIndex = 26;
            this.lblTemperature.Text = "Temperature";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTemperatureT
            // 
            this.lblTemperatureT.AutoSize = true;
            this.lblTemperatureT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureT.Location = new System.Drawing.Point(13, 161);
            this.lblTemperatureT.Name = "lblTemperatureT";
            this.lblTemperatureT.Size = new System.Drawing.Size(67, 13);
            this.lblTemperatureT.TabIndex = 25;
            this.lblTemperatureT.Text = "Temperature";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 502);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // rbFrancais
            // 
            this.rbFrancais.AutoSize = true;
            this.rbFrancais.Location = new System.Drawing.Point(12, 505);
            this.rbFrancais.Name = "rbFrancais";
            this.rbFrancais.Size = new System.Drawing.Size(58, 17);
            this.rbFrancais.TabIndex = 28;
            this.rbFrancais.TabStop = true;
            this.rbFrancais.Text = "French";
            this.rbFrancais.UseVisualStyleBackColor = true;
            this.rbFrancais.CheckedChanged += new System.EventHandler(this.RbFrancais_CheckedChanged);
            // 
            // rbAnglais
            // 
            this.rbAnglais.AutoSize = true;
            this.rbAnglais.Location = new System.Drawing.Point(76, 505);
            this.rbAnglais.Name = "rbAnglais";
            this.rbAnglais.Size = new System.Drawing.Size(59, 17);
            this.rbAnglais.TabIndex = 29;
            this.rbAnglais.TabStop = true;
            this.rbAnglais.Text = "English";
            this.rbAnglais.UseVisualStyleBackColor = true;
            this.rbAnglais.CheckedChanged += new System.EventHandler(this.RbAnglais_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "v0.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "© 2019 Bruno Paiva";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-3, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 10);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // btnRetrieveCrash
            // 
            this.btnRetrieveCrash.Location = new System.Drawing.Point(15, 24);
            this.btnRetrieveCrash.Name = "btnRetrieveCrash";
            this.btnRetrieveCrash.Size = new System.Drawing.Size(212, 23);
            this.btnRetrieveCrash.TabIndex = 33;
            this.btnRetrieveCrash.Text = "Delete crash files";
            this.btnRetrieveCrash.UseVisualStyleBackColor = true;
            this.btnRetrieveCrash.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetrieveCrash);
            this.groupBox2.Location = new System.Drawing.Point(12, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 59);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 568);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAnglais);
            this.Controls.Add(this.rbFrancais);
            this.Controls.Add(this.gbBattery);
            this.Controls.Add(this.gbSystem);
            this.Controls.Add(this.lblCycleCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iBatteryW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSystem.ResumeLayout(false);
            this.gbSystem.PerformLayout();
            this.gbBattery.ResumeLayout(false);
            this.gbBattery.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelT;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblHardwareModel;
        private System.Windows.Forms.Label lblHardwareModelT;
        private System.Windows.Forms.Label lbliOS;
        private System.Windows.Forms.Label lbliOST;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceNameT;
        private System.Windows.Forms.Label lblDiskCapacity;
        private System.Windows.Forms.Label lblDiskCapacityT;
        private System.Windows.Forms.Label lblDiskUsed;
        private System.Windows.Forms.Label lblDiskUsedT;
        private System.Windows.Forms.Label lblCycleCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDesignCapacity;
        private System.Windows.Forms.Label lblDesignCapacityT;
        private System.Windows.Forms.Label lblActualCapacity;
        private System.Windows.Forms.Label lblActualCapacityT;
        private System.Windows.Forms.Label lblActualCharge;
        private System.Windows.Forms.Label lblBatteryPercentageT;
        private System.Windows.Forms.Label lblBatteryLife;
        private System.Windows.Forms.Label lblBatteryLifeT;
        private System.Windows.Forms.Label lblLifeStatus;
        private System.Windows.Forms.Label lblLifeStatusT;
        private System.Windows.Forms.GroupBox gbSystem;
        private System.Windows.Forms.GroupBox gbBattery;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblTemperatureT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbFrancais;
        private System.Windows.Forms.RadioButton rbAnglais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetrieveCrash;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

