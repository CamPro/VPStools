
namespace VpsSetup
{
    partial class VpsSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VpsSetup));
            this.buttonCredSSP = new System.Windows.Forms.Button();
            this.checkSetupFirefox = new System.Windows.Forms.CheckBox();
            this.checkSetupChrome = new System.Windows.Forms.CheckBox();
            this.checkSetupGeneral = new System.Windows.Forms.CheckBox();
            this.checkUpdateTime = new System.Windows.Forms.CheckBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonDnsJumper = new System.Windows.Forms.Button();
            this.buttonRestartVps = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.checkDnsJumper = new System.Windows.Forms.CheckBox();
            this.buttonSeftDelete = new System.Windows.Forms.Button();
            this.checkInfoIP = new System.Windows.Forms.CheckBox();
            this.textInfoIP = new System.Windows.Forms.TextBox();
            this.checkFixCopy = new System.Windows.Forms.CheckBox();
            this.buttonPass = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonPort = new System.Windows.Forms.Button();
            this.buttonRandomPort = new System.Windows.Forms.Button();
            this.buttonRandomUser = new System.Windows.Forms.Button();
            this.buttonRandomPass = new System.Windows.Forms.Button();
            this.checkBlockUpdate = new System.Windows.Forms.CheckBox();
            this.checkSetupWinrar = new System.Windows.Forms.CheckBox();
            this.checkSetupNet472 = new System.Windows.Forms.CheckBox();
            this.checkSetupDesktop = new System.Windows.Forms.CheckBox();
            this.pictureOpenStartup = new System.Windows.Forms.PictureBox();
            this.pictureOpenFirewall = new System.Windows.Forms.PictureBox();
            this.pictureOpenTaskSchd = new System.Windows.Forms.PictureBox();
            this.pictureOpenPrograms = new System.Windows.Forms.PictureBox();
            this.pictureOpenTaskMgr = new System.Windows.Forms.PictureBox();
            this.pictureOpenControlPanel = new System.Windows.Forms.PictureBox();
            this.pictureOpenCmd = new System.Windows.Forms.PictureBox();
            this.pictureOpenWindef = new System.Windows.Forms.PictureBox();
            this.checkSetup7Zip = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenStartup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenFirewall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenTaskSchd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenTaskMgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenControlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenWindef)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCredSSP
            // 
            this.buttonCredSSP.Location = new System.Drawing.Point(10, 330);
            this.buttonCredSSP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCredSSP.Name = "buttonCredSSP";
            this.buttonCredSSP.Size = new System.Drawing.Size(120, 28);
            this.buttonCredSSP.TabIndex = 21;
            this.buttonCredSSP.Text = "CredSSP";
            this.buttonCredSSP.UseVisualStyleBackColor = true;
            this.buttonCredSSP.Click += new System.EventHandler(this.buttonCredSSP_Click);
            // 
            // checkSetupFirefox
            // 
            this.checkSetupFirefox.AutoSize = true;
            this.checkSetupFirefox.Location = new System.Drawing.Point(191, 180);
            this.checkSetupFirefox.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupFirefox.Name = "checkSetupFirefox";
            this.checkSetupFirefox.Size = new System.Drawing.Size(76, 24);
            this.checkSetupFirefox.TabIndex = 7;
            this.checkSetupFirefox.Text = "Firefox";
            this.checkSetupFirefox.UseVisualStyleBackColor = true;
            this.checkSetupFirefox.Click += new System.EventHandler(this.checkSetupFirefox_Click);
            // 
            // checkSetupChrome
            // 
            this.checkSetupChrome.AutoSize = true;
            this.checkSetupChrome.Location = new System.Drawing.Point(330, 180);
            this.checkSetupChrome.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupChrome.Name = "checkSetupChrome";
            this.checkSetupChrome.Size = new System.Drawing.Size(84, 24);
            this.checkSetupChrome.TabIndex = 8;
            this.checkSetupChrome.Text = "Chrome";
            this.checkSetupChrome.UseVisualStyleBackColor = true;
            this.checkSetupChrome.Click += new System.EventHandler(this.checkSetupChrome_Click);
            // 
            // checkSetupGeneral
            // 
            this.checkSetupGeneral.AutoSize = true;
            this.checkSetupGeneral.Location = new System.Drawing.Point(12, 180);
            this.checkSetupGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupGeneral.Name = "checkSetupGeneral";
            this.checkSetupGeneral.Size = new System.Drawing.Size(126, 24);
            this.checkSetupGeneral.TabIndex = 2;
            this.checkSetupGeneral.Text = "Cài đặt chung";
            this.checkSetupGeneral.UseVisualStyleBackColor = true;
            this.checkSetupGeneral.Click += new System.EventHandler(this.checkSetupGeneral_Click);
            // 
            // checkUpdateTime
            // 
            this.checkUpdateTime.AutoSize = true;
            this.checkUpdateTime.Location = new System.Drawing.Point(12, 140);
            this.checkUpdateTime.Margin = new System.Windows.Forms.Padding(2);
            this.checkUpdateTime.Name = "checkUpdateTime";
            this.checkUpdateTime.Size = new System.Drawing.Size(157, 24);
            this.checkUpdateTime.TabIndex = 1;
            this.checkUpdateTime.Text = "Cập nhật thời gian";
            this.checkUpdateTime.UseVisualStyleBackColor = true;
            this.checkUpdateTime.Click += new System.EventHandler(this.checkUpdateTime_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(55, 12);
            this.textPass.Margin = new System.Windows.Forms.Padding(2);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(240, 26);
            this.textPass.TabIndex = 12;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // buttonDnsJumper
            // 
            this.buttonDnsJumper.Location = new System.Drawing.Point(155, 330);
            this.buttonDnsJumper.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDnsJumper.Name = "buttonDnsJumper";
            this.buttonDnsJumper.Size = new System.Drawing.Size(120, 28);
            this.buttonDnsJumper.TabIndex = 22;
            this.buttonDnsJumper.Text = "DNS Jumper";
            this.buttonDnsJumper.UseVisualStyleBackColor = true;
            this.buttonDnsJumper.Click += new System.EventHandler(this.buttonDnsJumper_Click);
            // 
            // buttonRestartVps
            // 
            this.buttonRestartVps.Location = new System.Drawing.Point(306, 330);
            this.buttonRestartVps.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestartVps.Name = "buttonRestartVps";
            this.buttonRestartVps.Size = new System.Drawing.Size(120, 28);
            this.buttonRestartVps.TabIndex = 23;
            this.buttonRestartVps.Text = "Restart";
            this.buttonRestartVps.UseVisualStyleBackColor = true;
            this.buttonRestartVps.Click += new System.EventHandler(this.buttonRestartVps_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(55, 52);
            this.textUser.Margin = new System.Windows.Forms.Padding(2);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(240, 26);
            this.textUser.TabIndex = 15;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(55, 92);
            this.textPort.Margin = new System.Windows.Forms.Padding(2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(240, 26);
            this.textPort.TabIndex = 18;
            this.textPort.TextChanged += new System.EventHandler(this.textPort_TextChanged);
            // 
            // checkDnsJumper
            // 
            this.checkDnsJumper.AutoSize = true;
            this.checkDnsJumper.Location = new System.Drawing.Point(12, 220);
            this.checkDnsJumper.Margin = new System.Windows.Forms.Padding(2);
            this.checkDnsJumper.Name = "checkDnsJumper";
            this.checkDnsJumper.Size = new System.Drawing.Size(130, 24);
            this.checkDnsJumper.TabIndex = 3;
            this.checkDnsJumper.Text = "Dns cloudflare";
            this.checkDnsJumper.UseVisualStyleBackColor = true;
            this.checkDnsJumper.Click += new System.EventHandler(this.checkDnsJumper_Click);
            // 
            // buttonSeftDelete
            // 
            this.buttonSeftDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeftDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonSeftDelete.Location = new System.Drawing.Point(398, 370);
            this.buttonSeftDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSeftDelete.Name = "buttonSeftDelete";
            this.buttonSeftDelete.Size = new System.Drawing.Size(28, 28);
            this.buttonSeftDelete.TabIndex = 24;
            this.buttonSeftDelete.Text = "x";
            this.buttonSeftDelete.UseVisualStyleBackColor = true;
            this.buttonSeftDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkInfoIP
            // 
            this.checkInfoIP.AutoSize = true;
            this.checkInfoIP.Location = new System.Drawing.Point(12, 260);
            this.checkInfoIP.Margin = new System.Windows.Forms.Padding(2);
            this.checkInfoIP.Name = "checkInfoIP";
            this.checkInfoIP.Size = new System.Drawing.Size(162, 24);
            this.checkInfoIP.TabIndex = 4;
            this.checkInfoIP.Text = "Cập nhật timezone";
            this.checkInfoIP.UseVisualStyleBackColor = true;
            this.checkInfoIP.Click += new System.EventHandler(this.checkInfoIP_Click);
            // 
            // textInfoIP
            // 
            this.textInfoIP.Location = new System.Drawing.Point(12, 286);
            this.textInfoIP.Margin = new System.Windows.Forms.Padding(2);
            this.textInfoIP.Name = "textInfoIP";
            this.textInfoIP.Size = new System.Drawing.Size(407, 26);
            this.textInfoIP.TabIndex = 0;
            // 
            // checkFixCopy
            // 
            this.checkFixCopy.AutoSize = true;
            this.checkFixCopy.Location = new System.Drawing.Point(330, 140);
            this.checkFixCopy.Margin = new System.Windows.Forms.Padding(2);
            this.checkFixCopy.Name = "checkFixCopy";
            this.checkFixCopy.Size = new System.Drawing.Size(85, 24);
            this.checkFixCopy.TabIndex = 6;
            this.checkFixCopy.Text = "Fix copy";
            this.checkFixCopy.UseVisualStyleBackColor = true;
            this.checkFixCopy.Click += new System.EventHandler(this.checkFixCopy_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(306, 10);
            this.buttonPass.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(120, 30);
            this.buttonPass.TabIndex = 13;
            this.buttonPass.Text = "Change Pass";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(306, 50);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(120, 30);
            this.buttonUser.TabIndex = 16;
            this.buttonUser.Text = "Change User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonPort
            // 
            this.buttonPort.Location = new System.Drawing.Point(306, 90);
            this.buttonPort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(120, 30);
            this.buttonPort.TabIndex = 19;
            this.buttonPort.Text = "Change Port";
            this.buttonPort.UseVisualStyleBackColor = true;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // buttonRandomPort
            // 
            this.buttonRandomPort.Location = new System.Drawing.Point(10, 90);
            this.buttonRandomPort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomPort.Name = "buttonRandomPort";
            this.buttonRandomPort.Size = new System.Drawing.Size(40, 30);
            this.buttonRandomPort.TabIndex = 17;
            this.buttonRandomPort.Text = "Rd";
            this.buttonRandomPort.UseVisualStyleBackColor = true;
            this.buttonRandomPort.Click += new System.EventHandler(this.buttonRandomPort_Click);
            // 
            // buttonRandomUser
            // 
            this.buttonRandomUser.Location = new System.Drawing.Point(10, 50);
            this.buttonRandomUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomUser.Name = "buttonRandomUser";
            this.buttonRandomUser.Size = new System.Drawing.Size(40, 30);
            this.buttonRandomUser.TabIndex = 14;
            this.buttonRandomUser.Text = "Rd";
            this.buttonRandomUser.UseVisualStyleBackColor = true;
            this.buttonRandomUser.Click += new System.EventHandler(this.buttonRandomUser_Click);
            // 
            // buttonRandomPass
            // 
            this.buttonRandomPass.Location = new System.Drawing.Point(10, 10);
            this.buttonRandomPass.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomPass.Name = "buttonRandomPass";
            this.buttonRandomPass.Size = new System.Drawing.Size(40, 30);
            this.buttonRandomPass.TabIndex = 11;
            this.buttonRandomPass.Text = "Rd";
            this.buttonRandomPass.UseVisualStyleBackColor = true;
            this.buttonRandomPass.Click += new System.EventHandler(this.buttonRandomPass_Click);
            // 
            // checkBlockUpdate
            // 
            this.checkBlockUpdate.AutoSize = true;
            this.checkBlockUpdate.Location = new System.Drawing.Point(191, 220);
            this.checkBlockUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.checkBlockUpdate.Name = "checkBlockUpdate";
            this.checkBlockUpdate.Size = new System.Drawing.Size(121, 24);
            this.checkBlockUpdate.TabIndex = 9;
            this.checkBlockUpdate.Text = "Block update";
            this.checkBlockUpdate.UseVisualStyleBackColor = true;
            this.checkBlockUpdate.Click += new System.EventHandler(this.checkBlockUpdate_Click);
            // 
            // checkSetupWinrar
            // 
            this.checkSetupWinrar.AutoSize = true;
            this.checkSetupWinrar.Location = new System.Drawing.Point(191, 140);
            this.checkSetupWinrar.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupWinrar.Name = "checkSetupWinrar";
            this.checkSetupWinrar.Size = new System.Drawing.Size(74, 24);
            this.checkSetupWinrar.TabIndex = 5;
            this.checkSetupWinrar.Text = "Winrar";
            this.checkSetupWinrar.UseVisualStyleBackColor = true;
            this.checkSetupWinrar.Click += new System.EventHandler(this.checkSetupWinrar_Click);
            // 
            // checkSetupNet472
            // 
            this.checkSetupNet472.AutoSize = true;
            this.checkSetupNet472.Location = new System.Drawing.Point(330, 220);
            this.checkSetupNet472.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupNet472.Name = "checkSetupNet472";
            this.checkSetupNet472.Size = new System.Drawing.Size(92, 24);
            this.checkSetupNet472.TabIndex = 40;
            this.checkSetupNet472.Text = "Net 4.7.2";
            this.checkSetupNet472.UseVisualStyleBackColor = true;
            this.checkSetupNet472.Click += new System.EventHandler(this.checkSetupNet472_Click);
            // 
            // checkSetupDesktop
            // 
            this.checkSetupDesktop.AutoSize = true;
            this.checkSetupDesktop.Location = new System.Drawing.Point(191, 260);
            this.checkSetupDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetupDesktop.Name = "checkSetupDesktop";
            this.checkSetupDesktop.Size = new System.Drawing.Size(88, 24);
            this.checkSetupDesktop.TabIndex = 41;
            this.checkSetupDesktop.Text = "Desktop";
            this.checkSetupDesktop.UseVisualStyleBackColor = true;
            this.checkSetupDesktop.Click += new System.EventHandler(this.checkSetupDesktop_Click);
            // 
            // pictureOpenStartup
            // 
            this.pictureOpenStartup.Image = global::VpsSetup.Properties.Resources.icon_Startup_32;
            this.pictureOpenStartup.Location = new System.Drawing.Point(290, 370);
            this.pictureOpenStartup.Name = "pictureOpenStartup";
            this.pictureOpenStartup.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenStartup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenStartup.TabIndex = 39;
            this.pictureOpenStartup.TabStop = false;
            this.pictureOpenStartup.Click += new System.EventHandler(this.pictureOpenStartup_Click);
            // 
            // pictureOpenFirewall
            // 
            this.pictureOpenFirewall.Image = global::VpsSetup.Properties.Resources.icon_Firewall_32;
            this.pictureOpenFirewall.Location = new System.Drawing.Point(210, 370);
            this.pictureOpenFirewall.Name = "pictureOpenFirewall";
            this.pictureOpenFirewall.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenFirewall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenFirewall.TabIndex = 38;
            this.pictureOpenFirewall.TabStop = false;
            this.pictureOpenFirewall.Click += new System.EventHandler(this.pictureOpenFirewall_Click);
            // 
            // pictureOpenTaskSchd
            // 
            this.pictureOpenTaskSchd.Image = global::VpsSetup.Properties.Resources.icon_Scheduled_Tasks_32;
            this.pictureOpenTaskSchd.Location = new System.Drawing.Point(90, 371);
            this.pictureOpenTaskSchd.Name = "pictureOpenTaskSchd";
            this.pictureOpenTaskSchd.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenTaskSchd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenTaskSchd.TabIndex = 37;
            this.pictureOpenTaskSchd.TabStop = false;
            this.pictureOpenTaskSchd.Click += new System.EventHandler(this.pictureOpenTaskSchd_Click);
            // 
            // pictureOpenPrograms
            // 
            this.pictureOpenPrograms.Image = global::VpsSetup.Properties.Resources.icon_Programs_32;
            this.pictureOpenPrograms.Location = new System.Drawing.Point(170, 370);
            this.pictureOpenPrograms.Name = "pictureOpenPrograms";
            this.pictureOpenPrograms.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenPrograms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenPrograms.TabIndex = 36;
            this.pictureOpenPrograms.TabStop = false;
            this.pictureOpenPrograms.Click += new System.EventHandler(this.pictureOpenPrograms_Click);
            // 
            // pictureOpenTaskMgr
            // 
            this.pictureOpenTaskMgr.Image = global::VpsSetup.Properties.Resources.icon_Task_Manager_32;
            this.pictureOpenTaskMgr.Location = new System.Drawing.Point(50, 371);
            this.pictureOpenTaskMgr.Name = "pictureOpenTaskMgr";
            this.pictureOpenTaskMgr.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenTaskMgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenTaskMgr.TabIndex = 35;
            this.pictureOpenTaskMgr.TabStop = false;
            this.pictureOpenTaskMgr.Click += new System.EventHandler(this.pictureOpenTaskMgr_Click);
            // 
            // pictureOpenControlPanel
            // 
            this.pictureOpenControlPanel.Image = global::VpsSetup.Properties.Resources.icon_Control_Panel_32;
            this.pictureOpenControlPanel.Location = new System.Drawing.Point(130, 370);
            this.pictureOpenControlPanel.Name = "pictureOpenControlPanel";
            this.pictureOpenControlPanel.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenControlPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenControlPanel.TabIndex = 34;
            this.pictureOpenControlPanel.TabStop = false;
            this.pictureOpenControlPanel.Click += new System.EventHandler(this.pictureOpenControlPanel_Click);
            // 
            // pictureOpenCmd
            // 
            this.pictureOpenCmd.Image = global::VpsSetup.Properties.Resources.icon_Command_Line_32;
            this.pictureOpenCmd.Location = new System.Drawing.Point(10, 370);
            this.pictureOpenCmd.Name = "pictureOpenCmd";
            this.pictureOpenCmd.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenCmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenCmd.TabIndex = 33;
            this.pictureOpenCmd.TabStop = false;
            this.pictureOpenCmd.Click += new System.EventHandler(this.pictureOpenCmd_Click);
            // 
            // pictureOpenWindef
            // 
            this.pictureOpenWindef.Image = global::VpsSetup.Properties.Resources.icon_windows_defender_50;
            this.pictureOpenWindef.Location = new System.Drawing.Point(250, 370);
            this.pictureOpenWindef.Name = "pictureOpenWindef";
            this.pictureOpenWindef.Size = new System.Drawing.Size(28, 28);
            this.pictureOpenWindef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpenWindef.TabIndex = 43;
            this.pictureOpenWindef.TabStop = false;
            this.pictureOpenWindef.Click += new System.EventHandler(this.pictureOpenWindef_Click);
            // 
            // checkSetup7Zip
            // 
            this.checkSetup7Zip.AutoSize = true;
            this.checkSetup7Zip.Location = new System.Drawing.Point(330, 260);
            this.checkSetup7Zip.Margin = new System.Windows.Forms.Padding(2);
            this.checkSetup7Zip.Name = "checkSetup7Zip";
            this.checkSetup7Zip.Size = new System.Drawing.Size(61, 24);
            this.checkSetup7Zip.TabIndex = 44;
            this.checkSetup7Zip.Text = "7 zip";
            this.checkSetup7Zip.UseVisualStyleBackColor = true;
            this.checkSetup7Zip.Click += new System.EventHandler(this.checkSetup7Zip_Click);
            // 
            // VpsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.checkSetup7Zip);
            this.Controls.Add(this.pictureOpenWindef);
            this.Controls.Add(this.checkSetupDesktop);
            this.Controls.Add(this.checkSetupNet472);
            this.Controls.Add(this.pictureOpenStartup);
            this.Controls.Add(this.pictureOpenFirewall);
            this.Controls.Add(this.pictureOpenTaskSchd);
            this.Controls.Add(this.pictureOpenPrograms);
            this.Controls.Add(this.pictureOpenTaskMgr);
            this.Controls.Add(this.pictureOpenControlPanel);
            this.Controls.Add(this.pictureOpenCmd);
            this.Controls.Add(this.checkSetupWinrar);
            this.Controls.Add(this.checkBlockUpdate);
            this.Controls.Add(this.buttonRandomPort);
            this.Controls.Add(this.buttonRandomUser);
            this.Controls.Add(this.buttonRandomPass);
            this.Controls.Add(this.buttonPort);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.checkFixCopy);
            this.Controls.Add(this.textInfoIP);
            this.Controls.Add(this.checkInfoIP);
            this.Controls.Add(this.buttonSeftDelete);
            this.Controls.Add(this.checkDnsJumper);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.buttonRestartVps);
            this.Controls.Add(this.buttonDnsJumper);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.checkUpdateTime);
            this.Controls.Add(this.checkSetupGeneral);
            this.Controls.Add(this.checkSetupChrome);
            this.Controls.Add(this.checkSetupFirefox);
            this.Controls.Add(this.buttonCredSSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "VpsSetup";
            this.Text = "Vps Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VpsSetup_FormClosing);
            this.Load += new System.EventHandler(this.VpsSetup_Load);
            this.Shown += new System.EventHandler(this.VpsSetup_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenStartup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenFirewall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenTaskSchd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenTaskMgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenControlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenWindef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCredSSP;
        private System.Windows.Forms.CheckBox checkSetupFirefox;
        private System.Windows.Forms.CheckBox checkSetupChrome;
        private System.Windows.Forms.CheckBox checkSetupGeneral;
        private System.Windows.Forms.CheckBox checkUpdateTime;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonDnsJumper;
        private System.Windows.Forms.Button buttonRestartVps;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.CheckBox checkDnsJumper;
        private System.Windows.Forms.Button buttonSeftDelete;
        private System.Windows.Forms.CheckBox checkInfoIP;
        private System.Windows.Forms.TextBox textInfoIP;
        private System.Windows.Forms.CheckBox checkFixCopy;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.Button buttonRandomPort;
        private System.Windows.Forms.Button buttonRandomUser;
        private System.Windows.Forms.Button buttonRandomPass;
        private System.Windows.Forms.CheckBox checkBlockUpdate;
        private System.Windows.Forms.CheckBox checkSetupWinrar;
        private System.Windows.Forms.PictureBox pictureOpenCmd;
        private System.Windows.Forms.PictureBox pictureOpenControlPanel;
        private System.Windows.Forms.PictureBox pictureOpenTaskMgr;
        private System.Windows.Forms.PictureBox pictureOpenPrograms;
        private System.Windows.Forms.PictureBox pictureOpenTaskSchd;
        private System.Windows.Forms.PictureBox pictureOpenFirewall;
        private System.Windows.Forms.PictureBox pictureOpenStartup;
        private System.Windows.Forms.CheckBox checkSetupNet472;
        private System.Windows.Forms.CheckBox checkSetupDesktop;
        private System.Windows.Forms.PictureBox pictureOpenWindef;
        private System.Windows.Forms.CheckBox checkSetup7Zip;
    }
}

