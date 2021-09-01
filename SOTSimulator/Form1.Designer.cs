
namespace SOTSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLungeToggle = new System.Windows.Forms.Button();
            this.lblLungeState = new System.Windows.Forms.Label();
            this.txtBlockDelay = new System.Windows.Forms.TextBox();
            this.txtJumpDelay = new System.Windows.Forms.TextBox();
            this.lblBlockDelay = new System.Windows.Forms.Label();
            this.lblJumpDelay = new System.Windows.Forms.Label();
            this.lblKeyStroke = new System.Windows.Forms.Label();
            this.lblListenFrequency = new System.Windows.Forms.Label();
            this.txtKeyStroke = new System.Windows.Forms.TextBox();
            this.txtListenFrequency = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblJuggleState = new System.Windows.Forms.Label();
            this.btnJuggleToggle = new System.Windows.Forms.Button();
            this.txtMoveKeyStroke = new System.Windows.Forms.TextBox();
            this.txtDropKeyStroke = new System.Windows.Forms.TextBox();
            this.txtSprintKeyStroke = new System.Windows.Forms.TextBox();
            this.txtUseKeyStroke = new System.Windows.Forms.TextBox();
            this.lblMoveKeyStroke = new System.Windows.Forms.Label();
            this.lblDropKeyStroke = new System.Windows.Forms.Label();
            this.lblSprintKeyStroke = new System.Windows.Forms.Label();
            this.lblUseKeyStroke = new System.Windows.Forms.Label();
            this.lblDropDelay = new System.Windows.Forms.Label();
            this.lblMouseSpeed = new System.Windows.Forms.Label();
            this.lblRunDelay = new System.Windows.Forms.Label();
            this.lblUseDelay = new System.Windows.Forms.Label();
            this.lblMouseDistance = new System.Windows.Forms.Label();
            this.txtDropDelay = new System.Windows.Forms.TextBox();
            this.txtMouseSpeed = new System.Windows.Forms.TextBox();
            this.txtRunDelay = new System.Windows.Forms.TextBox();
            this.txtUseDelay = new System.Windows.Forms.TextBox();
            this.txtMouseDistance = new System.Windows.Forms.TextBox();
            this.btnInfoSwordLunge = new System.Windows.Forms.Button();
            this.btnInfoJuggle = new System.Windows.Forms.Button();
            this.lblReference = new System.Windows.Forms.Label();
            this.btnDoubleGunToggle = new System.Windows.Forms.Button();
            this.lblDgState = new System.Windows.Forms.Label();
            this.txtDgKeyStroke = new System.Windows.Forms.TextBox();
            this.lblDgKeyStroke = new System.Windows.Forms.Label();
            this.lblSwitchKeyStroke = new System.Windows.Forms.Label();
            this.txtSwitchKeyStroke = new System.Windows.Forms.TextBox();
            this.txtSwitchDelay = new System.Windows.Forms.TextBox();
            this.lblSwitchDelay = new System.Windows.Forms.Label();
            this.lblFireKeyStroke = new System.Windows.Forms.Label();
            this.txtFireKeyStroke = new System.Windows.Forms.TextBox();
            this.lblAimKeyStroke = new System.Windows.Forms.Label();
            this.txtAimKeyStroke = new System.Windows.Forms.TextBox();
            this.txtAdsDelay = new System.Windows.Forms.TextBox();
            this.lblAdsDelay = new System.Windows.Forms.Label();
            this.btnInfoDoubleGun = new System.Windows.Forms.Button();
            this.lblBhopToggle = new System.Windows.Forms.Label();
            this.btnBhopToggle = new System.Windows.Forms.Button();
            this.lblBhopStateKeyStroke = new System.Windows.Forms.Label();
            this.txtBhopStateKeyStroke = new System.Windows.Forms.TextBox();
            this.lblAntiAFKStateToggle = new System.Windows.Forms.Label();
            this.btnAntiAFKStateToggle = new System.Windows.Forms.Button();
            this.lblAutoCannonStateToggle = new System.Windows.Forms.Label();
            this.btnAutoCannonStateToggle = new System.Windows.Forms.Button();
            this.txtReloadDelay = new System.Windows.Forms.TextBox();
            this.lblReloadDelay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReloadKeyStroke = new System.Windows.Forms.Label();
            this.txtReloadKeyStroke = new System.Windows.Forms.TextBox();
            this.lblCannonToggleKeyStroke = new System.Windows.Forms.Label();
            this.txtCannonToggleKeyStroke = new System.Windows.Forms.TextBox();
            this.lblAutoLootToggleState = new System.Windows.Forms.Label();
            this.btnAutoLootToggleState = new System.Windows.Forms.Button();
            this.lblLootToggle = new System.Windows.Forms.Label();
            this.txtAutoLootToggleKeyStroke = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLungeToggle
            // 
            this.btnLungeToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnLungeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLungeToggle.Location = new System.Drawing.Point(27, 14);
            this.btnLungeToggle.Name = "btnLungeToggle";
            this.btnLungeToggle.Size = new System.Drawing.Size(75, 37);
            this.btnLungeToggle.TabIndex = 0;
            this.btnLungeToggle.Text = "SL";
            this.btnLungeToggle.UseVisualStyleBackColor = false;
            this.btnLungeToggle.Click += new System.EventHandler(this.btnLungeToggle_Click);
            // 
            // lblLungeState
            // 
            this.lblLungeState.AutoSize = true;
            this.lblLungeState.ForeColor = System.Drawing.Color.Red;
            this.lblLungeState.Location = new System.Drawing.Point(108, 28);
            this.lblLungeState.Name = "lblLungeState";
            this.lblLungeState.Size = new System.Drawing.Size(22, 15);
            this.lblLungeState.TabIndex = 1;
            this.lblLungeState.Text = "off";
            // 
            // txtBlockDelay
            // 
            this.txtBlockDelay.BackColor = System.Drawing.Color.White;
            this.txtBlockDelay.Location = new System.Drawing.Point(27, 57);
            this.txtBlockDelay.Name = "txtBlockDelay";
            this.txtBlockDelay.Size = new System.Drawing.Size(100, 23);
            this.txtBlockDelay.TabIndex = 2;
            this.txtBlockDelay.Text = "100";
            // 
            // txtJumpDelay
            // 
            this.txtJumpDelay.BackColor = System.Drawing.Color.White;
            this.txtJumpDelay.Location = new System.Drawing.Point(27, 87);
            this.txtJumpDelay.Name = "txtJumpDelay";
            this.txtJumpDelay.Size = new System.Drawing.Size(100, 23);
            this.txtJumpDelay.TabIndex = 3;
            this.txtJumpDelay.Text = "100";
            // 
            // lblBlockDelay
            // 
            this.lblBlockDelay.AutoSize = true;
            this.lblBlockDelay.Location = new System.Drawing.Point(133, 65);
            this.lblBlockDelay.Name = "lblBlockDelay";
            this.lblBlockDelay.Size = new System.Drawing.Size(67, 15);
            this.lblBlockDelay.TabIndex = 4;
            this.lblBlockDelay.Text = "Block delay";
            // 
            // lblJumpDelay
            // 
            this.lblJumpDelay.AutoSize = true;
            this.lblJumpDelay.Location = new System.Drawing.Point(133, 95);
            this.lblJumpDelay.Name = "lblJumpDelay";
            this.lblJumpDelay.Size = new System.Drawing.Size(67, 15);
            this.lblJumpDelay.TabIndex = 5;
            this.lblJumpDelay.Text = "Jump delay";
            // 
            // lblKeyStroke
            // 
            this.lblKeyStroke.AutoSize = true;
            this.lblKeyStroke.Location = new System.Drawing.Point(587, 56);
            this.lblKeyStroke.Name = "lblKeyStroke";
            this.lblKeyStroke.Size = new System.Drawing.Size(77, 15);
            this.lblKeyStroke.TabIndex = 9;
            this.lblKeyStroke.Text = "Lunge toggle";
            // 
            // lblListenFrequency
            // 
            this.lblListenFrequency.AutoSize = true;
            this.lblListenFrequency.Location = new System.Drawing.Point(133, 394);
            this.lblListenFrequency.Name = "lblListenFrequency";
            this.lblListenFrequency.Size = new System.Drawing.Size(99, 15);
            this.lblListenFrequency.TabIndex = 8;
            this.lblListenFrequency.Text = "Listen frequency*";
            // 
            // txtKeyStroke
            // 
            this.txtKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtKeyStroke.Location = new System.Drawing.Point(481, 48);
            this.txtKeyStroke.Name = "txtKeyStroke";
            this.txtKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtKeyStroke.TabIndex = 7;
            this.txtKeyStroke.Text = "0x11";
            // 
            // txtListenFrequency
            // 
            this.txtListenFrequency.Location = new System.Drawing.Point(27, 390);
            this.txtListenFrequency.Name = "txtListenFrequency";
            this.txtListenFrequency.Size = new System.Drawing.Size(100, 23);
            this.txtListenFrequency.TabIndex = 6;
            this.txtListenFrequency.Text = "50";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Location = new System.Drawing.Point(250, 373);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(133, 23);
            this.btnSaveSettings.TabIndex = 10;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblJuggleState
            // 
            this.lblJuggleState.AutoSize = true;
            this.lblJuggleState.ForeColor = System.Drawing.Color.Red;
            this.lblJuggleState.Location = new System.Drawing.Point(331, 28);
            this.lblJuggleState.Name = "lblJuggleState";
            this.lblJuggleState.Size = new System.Drawing.Size(22, 15);
            this.lblJuggleState.TabIndex = 12;
            this.lblJuggleState.Text = "off";
            // 
            // btnJuggleToggle
            // 
            this.btnJuggleToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnJuggleToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuggleToggle.Location = new System.Drawing.Point(250, 14);
            this.btnJuggleToggle.Name = "btnJuggleToggle";
            this.btnJuggleToggle.Size = new System.Drawing.Size(75, 37);
            this.btnJuggleToggle.TabIndex = 11;
            this.btnJuggleToggle.Text = "Juggle";
            this.btnJuggleToggle.UseVisualStyleBackColor = false;
            this.btnJuggleToggle.Click += new System.EventHandler(this.btnJuggleToggle_Click);
            // 
            // txtMoveKeyStroke
            // 
            this.txtMoveKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtMoveKeyStroke.Location = new System.Drawing.Point(481, 106);
            this.txtMoveKeyStroke.Name = "txtMoveKeyStroke";
            this.txtMoveKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtMoveKeyStroke.TabIndex = 13;
            this.txtMoveKeyStroke.Text = "0x11";
            // 
            // txtDropKeyStroke
            // 
            this.txtDropKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtDropKeyStroke.Location = new System.Drawing.Point(481, 251);
            this.txtDropKeyStroke.Name = "txtDropKeyStroke";
            this.txtDropKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtDropKeyStroke.TabIndex = 14;
            this.txtDropKeyStroke.Text = "0x11";
            // 
            // txtSprintKeyStroke
            // 
            this.txtSprintKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtSprintKeyStroke.Location = new System.Drawing.Point(481, 280);
            this.txtSprintKeyStroke.Name = "txtSprintKeyStroke";
            this.txtSprintKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtSprintKeyStroke.TabIndex = 15;
            this.txtSprintKeyStroke.Text = "0x11";
            // 
            // txtUseKeyStroke
            // 
            this.txtUseKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtUseKeyStroke.Location = new System.Drawing.Point(481, 309);
            this.txtUseKeyStroke.Name = "txtUseKeyStroke";
            this.txtUseKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtUseKeyStroke.TabIndex = 16;
            this.txtUseKeyStroke.Text = "0x11";
            // 
            // lblMoveKeyStroke
            // 
            this.lblMoveKeyStroke.AutoSize = true;
            this.lblMoveKeyStroke.Location = new System.Drawing.Point(587, 114);
            this.lblMoveKeyStroke.Name = "lblMoveKeyStroke";
            this.lblMoveKeyStroke.Size = new System.Drawing.Size(78, 15);
            this.lblMoveKeyStroke.TabIndex = 17;
            this.lblMoveKeyStroke.Text = "Juggle toggle";
            // 
            // lblDropKeyStroke
            // 
            this.lblDropKeyStroke.AutoSize = true;
            this.lblDropKeyStroke.Location = new System.Drawing.Point(587, 259);
            this.lblDropKeyStroke.Name = "lblDropKeyStroke";
            this.lblDropKeyStroke.Size = new System.Drawing.Size(55, 15);
            this.lblDropKeyStroke.TabIndex = 18;
            this.lblDropKeyStroke.Text = "Drop Key";
            // 
            // lblSprintKeyStroke
            // 
            this.lblSprintKeyStroke.AutoSize = true;
            this.lblSprintKeyStroke.Location = new System.Drawing.Point(587, 288);
            this.lblSprintKeyStroke.Name = "lblSprintKeyStroke";
            this.lblSprintKeyStroke.Size = new System.Drawing.Size(60, 15);
            this.lblSprintKeyStroke.TabIndex = 19;
            this.lblSprintKeyStroke.Text = "Sprint Key";
            // 
            // lblUseKeyStroke
            // 
            this.lblUseKeyStroke.AutoSize = true;
            this.lblUseKeyStroke.Location = new System.Drawing.Point(587, 317);
            this.lblUseKeyStroke.Name = "lblUseKeyStroke";
            this.lblUseKeyStroke.Size = new System.Drawing.Size(48, 15);
            this.lblUseKeyStroke.TabIndex = 20;
            this.lblUseKeyStroke.Text = "Use Key";
            // 
            // lblDropDelay
            // 
            this.lblDropDelay.AutoSize = true;
            this.lblDropDelay.Location = new System.Drawing.Point(356, 65);
            this.lblDropDelay.Name = "lblDropDelay";
            this.lblDropDelay.Size = new System.Drawing.Size(65, 15);
            this.lblDropDelay.TabIndex = 21;
            this.lblDropDelay.Text = "Drop Delay";
            // 
            // lblMouseSpeed
            // 
            this.lblMouseSpeed.AutoSize = true;
            this.lblMouseSpeed.Location = new System.Drawing.Point(356, 95);
            this.lblMouseSpeed.Name = "lblMouseSpeed";
            this.lblMouseSpeed.Size = new System.Drawing.Size(78, 15);
            this.lblMouseSpeed.TabIndex = 22;
            this.lblMouseSpeed.Text = "Mouse Speed";
            // 
            // lblRunDelay
            // 
            this.lblRunDelay.AutoSize = true;
            this.lblRunDelay.Location = new System.Drawing.Point(356, 124);
            this.lblRunDelay.Name = "lblRunDelay";
            this.lblRunDelay.Size = new System.Drawing.Size(60, 15);
            this.lblRunDelay.TabIndex = 23;
            this.lblRunDelay.Text = "Run Delay";
            // 
            // lblUseDelay
            // 
            this.lblUseDelay.AutoSize = true;
            this.lblUseDelay.Location = new System.Drawing.Point(356, 153);
            this.lblUseDelay.Name = "lblUseDelay";
            this.lblUseDelay.Size = new System.Drawing.Size(58, 15);
            this.lblUseDelay.TabIndex = 24;
            this.lblUseDelay.Text = "Use Delay";
            // 
            // lblMouseDistance
            // 
            this.lblMouseDistance.AutoSize = true;
            this.lblMouseDistance.Location = new System.Drawing.Point(356, 182);
            this.lblMouseDistance.Name = "lblMouseDistance";
            this.lblMouseDistance.Size = new System.Drawing.Size(91, 15);
            this.lblMouseDistance.TabIndex = 25;
            this.lblMouseDistance.Text = "Mouse Distance";
            // 
            // txtDropDelay
            // 
            this.txtDropDelay.BackColor = System.Drawing.Color.White;
            this.txtDropDelay.Location = new System.Drawing.Point(250, 57);
            this.txtDropDelay.Name = "txtDropDelay";
            this.txtDropDelay.Size = new System.Drawing.Size(100, 23);
            this.txtDropDelay.TabIndex = 26;
            this.txtDropDelay.Text = "0x11";
            // 
            // txtMouseSpeed
            // 
            this.txtMouseSpeed.BackColor = System.Drawing.Color.White;
            this.txtMouseSpeed.Location = new System.Drawing.Point(250, 87);
            this.txtMouseSpeed.Name = "txtMouseSpeed";
            this.txtMouseSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtMouseSpeed.TabIndex = 27;
            this.txtMouseSpeed.Text = "0x11";
            // 
            // txtRunDelay
            // 
            this.txtRunDelay.BackColor = System.Drawing.Color.White;
            this.txtRunDelay.Location = new System.Drawing.Point(250, 116);
            this.txtRunDelay.Name = "txtRunDelay";
            this.txtRunDelay.Size = new System.Drawing.Size(100, 23);
            this.txtRunDelay.TabIndex = 28;
            this.txtRunDelay.Text = "0x11";
            // 
            // txtUseDelay
            // 
            this.txtUseDelay.BackColor = System.Drawing.Color.White;
            this.txtUseDelay.Location = new System.Drawing.Point(250, 145);
            this.txtUseDelay.Name = "txtUseDelay";
            this.txtUseDelay.Size = new System.Drawing.Size(100, 23);
            this.txtUseDelay.TabIndex = 29;
            this.txtUseDelay.Text = "0x11";
            // 
            // txtMouseDistance
            // 
            this.txtMouseDistance.BackColor = System.Drawing.Color.White;
            this.txtMouseDistance.Location = new System.Drawing.Point(250, 174);
            this.txtMouseDistance.Name = "txtMouseDistance";
            this.txtMouseDistance.Size = new System.Drawing.Size(100, 23);
            this.txtMouseDistance.TabIndex = 30;
            this.txtMouseDistance.Text = "0x11";
            // 
            // btnInfoSwordLunge
            // 
            this.btnInfoSwordLunge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoSwordLunge.Location = new System.Drawing.Point(148, 24);
            this.btnInfoSwordLunge.Name = "btnInfoSwordLunge";
            this.btnInfoSwordLunge.Size = new System.Drawing.Size(75, 23);
            this.btnInfoSwordLunge.TabIndex = 32;
            this.btnInfoSwordLunge.Text = "Info";
            this.btnInfoSwordLunge.UseVisualStyleBackColor = true;
            this.btnInfoSwordLunge.Click += new System.EventHandler(this.btnInfoSwordLunge_Click);
            // 
            // btnInfoJuggle
            // 
            this.btnInfoJuggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoJuggle.Location = new System.Drawing.Point(379, 24);
            this.btnInfoJuggle.Name = "btnInfoJuggle";
            this.btnInfoJuggle.Size = new System.Drawing.Size(75, 23);
            this.btnInfoJuggle.TabIndex = 33;
            this.btnInfoJuggle.Text = "Info";
            this.btnInfoJuggle.UseVisualStyleBackColor = true;
            this.btnInfoJuggle.Click += new System.EventHandler(this.btnInfoJuggle_Click);
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(508, 14);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(127, 15);
            this.lblReference.TabIndex = 34;
            this.lblReference.Text = "*Lower for better CPUs";
            // 
            // btnDoubleGunToggle
            // 
            this.btnDoubleGunToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnDoubleGunToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleGunToggle.Location = new System.Drawing.Point(27, 116);
            this.btnDoubleGunToggle.Name = "btnDoubleGunToggle";
            this.btnDoubleGunToggle.Size = new System.Drawing.Size(75, 37);
            this.btnDoubleGunToggle.TabIndex = 35;
            this.btnDoubleGunToggle.Text = "DG";
            this.btnDoubleGunToggle.UseVisualStyleBackColor = false;
            this.btnDoubleGunToggle.Click += new System.EventHandler(this.btnDoubleGunToggle_Click);
            // 
            // lblDgState
            // 
            this.lblDgState.AutoSize = true;
            this.lblDgState.ForeColor = System.Drawing.Color.Red;
            this.lblDgState.Location = new System.Drawing.Point(108, 127);
            this.lblDgState.Name = "lblDgState";
            this.lblDgState.Size = new System.Drawing.Size(22, 15);
            this.lblDgState.TabIndex = 36;
            this.lblDgState.Text = "off";
            // 
            // txtDgKeyStroke
            // 
            this.txtDgKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtDgKeyStroke.Location = new System.Drawing.Point(481, 77);
            this.txtDgKeyStroke.Name = "txtDgKeyStroke";
            this.txtDgKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtDgKeyStroke.TabIndex = 37;
            this.txtDgKeyStroke.Text = "0x11";
            // 
            // lblDgKeyStroke
            // 
            this.lblDgKeyStroke.AutoSize = true;
            this.lblDgKeyStroke.Location = new System.Drawing.Point(587, 85);
            this.lblDgKeyStroke.Name = "lblDgKeyStroke";
            this.lblDgKeyStroke.Size = new System.Drawing.Size(104, 15);
            this.lblDgKeyStroke.TabIndex = 38;
            this.lblDgKeyStroke.Text = "DoubleGun toggle";
            // 
            // lblSwitchKeyStroke
            // 
            this.lblSwitchKeyStroke.AutoSize = true;
            this.lblSwitchKeyStroke.Location = new System.Drawing.Point(587, 344);
            this.lblSwitchKeyStroke.Name = "lblSwitchKeyStroke";
            this.lblSwitchKeyStroke.Size = new System.Drawing.Size(113, 15);
            this.lblSwitchKeyStroke.TabIndex = 40;
            this.lblSwitchKeyStroke.Text = "Switch weapons key";
            // 
            // txtSwitchKeyStroke
            // 
            this.txtSwitchKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtSwitchKeyStroke.Location = new System.Drawing.Point(481, 336);
            this.txtSwitchKeyStroke.Name = "txtSwitchKeyStroke";
            this.txtSwitchKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtSwitchKeyStroke.TabIndex = 39;
            this.txtSwitchKeyStroke.Text = "0x11";
            // 
            // txtSwitchDelay
            // 
            this.txtSwitchDelay.BackColor = System.Drawing.Color.White;
            this.txtSwitchDelay.Location = new System.Drawing.Point(27, 159);
            this.txtSwitchDelay.Name = "txtSwitchDelay";
            this.txtSwitchDelay.Size = new System.Drawing.Size(100, 23);
            this.txtSwitchDelay.TabIndex = 42;
            this.txtSwitchDelay.Text = "0x11";
            // 
            // lblSwitchDelay
            // 
            this.lblSwitchDelay.AutoSize = true;
            this.lblSwitchDelay.Location = new System.Drawing.Point(133, 167);
            this.lblSwitchDelay.Name = "lblSwitchDelay";
            this.lblSwitchDelay.Size = new System.Drawing.Size(73, 15);
            this.lblSwitchDelay.TabIndex = 41;
            this.lblSwitchDelay.Text = "Switch delay";
            // 
            // lblFireKeyStroke
            // 
            this.lblFireKeyStroke.AutoSize = true;
            this.lblFireKeyStroke.Location = new System.Drawing.Point(587, 373);
            this.lblFireKeyStroke.Name = "lblFireKeyStroke";
            this.lblFireKeyStroke.Size = new System.Drawing.Size(59, 15);
            this.lblFireKeyStroke.TabIndex = 44;
            this.lblFireKeyStroke.Text = "Shoot key";
            // 
            // txtFireKeyStroke
            // 
            this.txtFireKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtFireKeyStroke.Location = new System.Drawing.Point(481, 365);
            this.txtFireKeyStroke.Name = "txtFireKeyStroke";
            this.txtFireKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtFireKeyStroke.TabIndex = 43;
            this.txtFireKeyStroke.Text = "0x11";
            // 
            // lblAimKeyStroke
            // 
            this.lblAimKeyStroke.AutoSize = true;
            this.lblAimKeyStroke.Location = new System.Drawing.Point(587, 402);
            this.lblAimKeyStroke.Name = "lblAimKeyStroke";
            this.lblAimKeyStroke.Size = new System.Drawing.Size(50, 15);
            this.lblAimKeyStroke.TabIndex = 46;
            this.lblAimKeyStroke.Text = "Aim key";
            // 
            // txtAimKeyStroke
            // 
            this.txtAimKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtAimKeyStroke.Location = new System.Drawing.Point(481, 394);
            this.txtAimKeyStroke.Name = "txtAimKeyStroke";
            this.txtAimKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtAimKeyStroke.TabIndex = 45;
            this.txtAimKeyStroke.Text = "0x11";
            // 
            // txtAdsDelay
            // 
            this.txtAdsDelay.BackColor = System.Drawing.Color.White;
            this.txtAdsDelay.Location = new System.Drawing.Point(27, 188);
            this.txtAdsDelay.Name = "txtAdsDelay";
            this.txtAdsDelay.Size = new System.Drawing.Size(100, 23);
            this.txtAdsDelay.TabIndex = 48;
            this.txtAdsDelay.Text = "0x11";
            // 
            // lblAdsDelay
            // 
            this.lblAdsDelay.AutoSize = true;
            this.lblAdsDelay.Location = new System.Drawing.Point(133, 196);
            this.lblAdsDelay.Name = "lblAdsDelay";
            this.lblAdsDelay.Size = new System.Drawing.Size(60, 15);
            this.lblAdsDelay.TabIndex = 47;
            this.lblAdsDelay.Text = "ADS delay";
            // 
            // btnInfoDoubleGun
            // 
            this.btnInfoDoubleGun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoDoubleGun.Location = new System.Drawing.Point(148, 123);
            this.btnInfoDoubleGun.Name = "btnInfoDoubleGun";
            this.btnInfoDoubleGun.Size = new System.Drawing.Size(75, 23);
            this.btnInfoDoubleGun.TabIndex = 49;
            this.btnInfoDoubleGun.Text = "Info";
            this.btnInfoDoubleGun.UseVisualStyleBackColor = true;
            this.btnInfoDoubleGun.Click += new System.EventHandler(this.btnInfoDoubleGun_Click);
            // 
            // lblBhopToggle
            // 
            this.lblBhopToggle.AutoSize = true;
            this.lblBhopToggle.ForeColor = System.Drawing.Color.Red;
            this.lblBhopToggle.Location = new System.Drawing.Point(331, 214);
            this.lblBhopToggle.Name = "lblBhopToggle";
            this.lblBhopToggle.Size = new System.Drawing.Size(22, 15);
            this.lblBhopToggle.TabIndex = 51;
            this.lblBhopToggle.Text = "off";
            // 
            // btnBhopToggle
            // 
            this.btnBhopToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnBhopToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBhopToggle.Location = new System.Drawing.Point(250, 203);
            this.btnBhopToggle.Name = "btnBhopToggle";
            this.btnBhopToggle.Size = new System.Drawing.Size(75, 37);
            this.btnBhopToggle.TabIndex = 50;
            this.btnBhopToggle.Text = "Bhop";
            this.btnBhopToggle.UseVisualStyleBackColor = false;
            this.btnBhopToggle.Click += new System.EventHandler(this.btnBhopToggle_Click);
            // 
            // lblBhopStateKeyStroke
            // 
            this.lblBhopStateKeyStroke.AutoSize = true;
            this.lblBhopStateKeyStroke.Location = new System.Drawing.Point(587, 143);
            this.lblBhopStateKeyStroke.Name = "lblBhopStateKeyStroke";
            this.lblBhopStateKeyStroke.Size = new System.Drawing.Size(72, 15);
            this.lblBhopStateKeyStroke.TabIndex = 53;
            this.lblBhopStateKeyStroke.Text = "Bhop toggle";
            // 
            // txtBhopStateKeyStroke
            // 
            this.txtBhopStateKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtBhopStateKeyStroke.Location = new System.Drawing.Point(481, 135);
            this.txtBhopStateKeyStroke.Name = "txtBhopStateKeyStroke";
            this.txtBhopStateKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtBhopStateKeyStroke.TabIndex = 52;
            this.txtBhopStateKeyStroke.Text = "0x11";
            // 
            // lblAntiAFKStateToggle
            // 
            this.lblAntiAFKStateToggle.AutoSize = true;
            this.lblAntiAFKStateToggle.ForeColor = System.Drawing.Color.Red;
            this.lblAntiAFKStateToggle.Location = new System.Drawing.Point(331, 257);
            this.lblAntiAFKStateToggle.Name = "lblAntiAFKStateToggle";
            this.lblAntiAFKStateToggle.Size = new System.Drawing.Size(22, 15);
            this.lblAntiAFKStateToggle.TabIndex = 55;
            this.lblAntiAFKStateToggle.Text = "off";
            // 
            // btnAntiAFKStateToggle
            // 
            this.btnAntiAFKStateToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnAntiAFKStateToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiAFKStateToggle.Location = new System.Drawing.Point(250, 246);
            this.btnAntiAFKStateToggle.Name = "btnAntiAFKStateToggle";
            this.btnAntiAFKStateToggle.Size = new System.Drawing.Size(75, 37);
            this.btnAntiAFKStateToggle.TabIndex = 54;
            this.btnAntiAFKStateToggle.Text = "Anti-AFK";
            this.btnAntiAFKStateToggle.UseVisualStyleBackColor = false;
            this.btnAntiAFKStateToggle.Click += new System.EventHandler(this.btnAntiAFKStateToggle_Click);
            // 
            // lblAutoCannonStateToggle
            // 
            this.lblAutoCannonStateToggle.AutoSize = true;
            this.lblAutoCannonStateToggle.ForeColor = System.Drawing.Color.Red;
            this.lblAutoCannonStateToggle.Location = new System.Drawing.Point(133, 229);
            this.lblAutoCannonStateToggle.Name = "lblAutoCannonStateToggle";
            this.lblAutoCannonStateToggle.Size = new System.Drawing.Size(22, 15);
            this.lblAutoCannonStateToggle.TabIndex = 57;
            this.lblAutoCannonStateToggle.Text = "off";
            // 
            // btnAutoCannonStateToggle
            // 
            this.btnAutoCannonStateToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnAutoCannonStateToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoCannonStateToggle.Location = new System.Drawing.Point(27, 218);
            this.btnAutoCannonStateToggle.Name = "btnAutoCannonStateToggle";
            this.btnAutoCannonStateToggle.Size = new System.Drawing.Size(100, 37);
            this.btnAutoCannonStateToggle.TabIndex = 56;
            this.btnAutoCannonStateToggle.Text = "AutoCannon";
            this.btnAutoCannonStateToggle.UseVisualStyleBackColor = false;
            this.btnAutoCannonStateToggle.Click += new System.EventHandler(this.btnAutoCannonStateToggle_Click);
            // 
            // txtReloadDelay
            // 
            this.txtReloadDelay.BackColor = System.Drawing.Color.White;
            this.txtReloadDelay.Location = new System.Drawing.Point(27, 261);
            this.txtReloadDelay.Name = "txtReloadDelay";
            this.txtReloadDelay.Size = new System.Drawing.Size(100, 23);
            this.txtReloadDelay.TabIndex = 59;
            this.txtReloadDelay.Text = "0x11";
            // 
            // lblReloadDelay
            // 
            this.lblReloadDelay.AutoSize = true;
            this.lblReloadDelay.Location = new System.Drawing.Point(133, 269);
            this.lblReloadDelay.Name = "lblReloadDelay";
            this.lblReloadDelay.Size = new System.Drawing.Size(74, 15);
            this.lblReloadDelay.TabIndex = 58;
            this.lblReloadDelay.Text = "Reload delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "*Also bhop delay";
            // 
            // lblReloadKeyStroke
            // 
            this.lblReloadKeyStroke.AutoSize = true;
            this.lblReloadKeyStroke.Location = new System.Drawing.Point(587, 230);
            this.lblReloadKeyStroke.Name = "lblReloadKeyStroke";
            this.lblReloadKeyStroke.Size = new System.Drawing.Size(64, 15);
            this.lblReloadKeyStroke.TabIndex = 62;
            this.lblReloadKeyStroke.Text = "Reload key";
            // 
            // txtReloadKeyStroke
            // 
            this.txtReloadKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtReloadKeyStroke.Location = new System.Drawing.Point(481, 222);
            this.txtReloadKeyStroke.Name = "txtReloadKeyStroke";
            this.txtReloadKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtReloadKeyStroke.TabIndex = 61;
            this.txtReloadKeyStroke.Text = "0x11";
            // 
            // lblCannonToggleKeyStroke
            // 
            this.lblCannonToggleKeyStroke.AutoSize = true;
            this.lblCannonToggleKeyStroke.Location = new System.Drawing.Point(587, 172);
            this.lblCannonToggleKeyStroke.Name = "lblCannonToggleKeyStroke";
            this.lblCannonToggleKeyStroke.Size = new System.Drawing.Size(87, 15);
            this.lblCannonToggleKeyStroke.TabIndex = 64;
            this.lblCannonToggleKeyStroke.Text = "Cannon Toggle";
            // 
            // txtCannonToggleKeyStroke
            // 
            this.txtCannonToggleKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtCannonToggleKeyStroke.Location = new System.Drawing.Point(481, 164);
            this.txtCannonToggleKeyStroke.Name = "txtCannonToggleKeyStroke";
            this.txtCannonToggleKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtCannonToggleKeyStroke.TabIndex = 63;
            this.txtCannonToggleKeyStroke.Text = "0x11";
            // 
            // lblAutoLootToggleState
            // 
            this.lblAutoLootToggleState.AutoSize = true;
            this.lblAutoLootToggleState.ForeColor = System.Drawing.Color.Red;
            this.lblAutoLootToggleState.Location = new System.Drawing.Point(331, 300);
            this.lblAutoLootToggleState.Name = "lblAutoLootToggleState";
            this.lblAutoLootToggleState.Size = new System.Drawing.Size(22, 15);
            this.lblAutoLootToggleState.TabIndex = 66;
            this.lblAutoLootToggleState.Text = "off";
            // 
            // btnAutoLootToggleState
            // 
            this.btnAutoLootToggleState.BackColor = System.Drawing.Color.LightGray;
            this.btnAutoLootToggleState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoLootToggleState.Location = new System.Drawing.Point(250, 289);
            this.btnAutoLootToggleState.Name = "btnAutoLootToggleState";
            this.btnAutoLootToggleState.Size = new System.Drawing.Size(75, 37);
            this.btnAutoLootToggleState.TabIndex = 65;
            this.btnAutoLootToggleState.Text = "Auto Loot";
            this.btnAutoLootToggleState.UseVisualStyleBackColor = false;
            this.btnAutoLootToggleState.Click += new System.EventHandler(this.btnAutoLootToggleState_Click);
            // 
            // lblLootToggle
            // 
            this.lblLootToggle.AutoSize = true;
            this.lblLootToggle.Location = new System.Drawing.Point(587, 201);
            this.lblLootToggle.Name = "lblLootToggle";
            this.lblLootToggle.Size = new System.Drawing.Size(68, 15);
            this.lblLootToggle.TabIndex = 68;
            this.lblLootToggle.Text = "Loot toggle";
            // 
            // txtAutoLootToggleKeyStroke
            // 
            this.txtAutoLootToggleKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtAutoLootToggleKeyStroke.Location = new System.Drawing.Point(481, 193);
            this.txtAutoLootToggleKeyStroke.Name = "txtAutoLootToggleKeyStroke";
            this.txtAutoLootToggleKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtAutoLootToggleKeyStroke.TabIndex = 67;
            this.txtAutoLootToggleKeyStroke.Text = "0x11";
            // 
            // btnDefault
            // 
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDefault.Location = new System.Drawing.Point(250, 402);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(133, 23);
            this.btnDefault.TabIndex = 69;
            this.btnDefault.Text = "Default values";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.lblLootToggle);
            this.Controls.Add(this.txtAutoLootToggleKeyStroke);
            this.Controls.Add(this.lblAutoLootToggleState);
            this.Controls.Add(this.btnAutoLootToggleState);
            this.Controls.Add(this.lblCannonToggleKeyStroke);
            this.Controls.Add(this.txtCannonToggleKeyStroke);
            this.Controls.Add(this.lblReloadKeyStroke);
            this.Controls.Add(this.txtReloadKeyStroke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReloadDelay);
            this.Controls.Add(this.lblReloadDelay);
            this.Controls.Add(this.lblAutoCannonStateToggle);
            this.Controls.Add(this.btnAutoCannonStateToggle);
            this.Controls.Add(this.lblAntiAFKStateToggle);
            this.Controls.Add(this.btnAntiAFKStateToggle);
            this.Controls.Add(this.lblBhopStateKeyStroke);
            this.Controls.Add(this.txtBhopStateKeyStroke);
            this.Controls.Add(this.lblBhopToggle);
            this.Controls.Add(this.btnBhopToggle);
            this.Controls.Add(this.btnInfoDoubleGun);
            this.Controls.Add(this.txtAdsDelay);
            this.Controls.Add(this.lblAdsDelay);
            this.Controls.Add(this.lblAimKeyStroke);
            this.Controls.Add(this.txtAimKeyStroke);
            this.Controls.Add(this.lblFireKeyStroke);
            this.Controls.Add(this.txtFireKeyStroke);
            this.Controls.Add(this.txtSwitchDelay);
            this.Controls.Add(this.lblSwitchDelay);
            this.Controls.Add(this.lblSwitchKeyStroke);
            this.Controls.Add(this.txtSwitchKeyStroke);
            this.Controls.Add(this.lblDgKeyStroke);
            this.Controls.Add(this.txtDgKeyStroke);
            this.Controls.Add(this.lblDgState);
            this.Controls.Add(this.btnDoubleGunToggle);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.btnInfoJuggle);
            this.Controls.Add(this.btnInfoSwordLunge);
            this.Controls.Add(this.txtMouseDistance);
            this.Controls.Add(this.txtUseDelay);
            this.Controls.Add(this.txtRunDelay);
            this.Controls.Add(this.txtMouseSpeed);
            this.Controls.Add(this.txtDropDelay);
            this.Controls.Add(this.lblMouseDistance);
            this.Controls.Add(this.lblUseDelay);
            this.Controls.Add(this.lblRunDelay);
            this.Controls.Add(this.lblMouseSpeed);
            this.Controls.Add(this.lblDropDelay);
            this.Controls.Add(this.lblUseKeyStroke);
            this.Controls.Add(this.lblSprintKeyStroke);
            this.Controls.Add(this.lblDropKeyStroke);
            this.Controls.Add(this.lblMoveKeyStroke);
            this.Controls.Add(this.txtUseKeyStroke);
            this.Controls.Add(this.txtSprintKeyStroke);
            this.Controls.Add(this.txtDropKeyStroke);
            this.Controls.Add(this.txtMoveKeyStroke);
            this.Controls.Add(this.lblJuggleState);
            this.Controls.Add(this.btnJuggleToggle);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblKeyStroke);
            this.Controls.Add(this.lblListenFrequency);
            this.Controls.Add(this.txtKeyStroke);
            this.Controls.Add(this.txtListenFrequency);
            this.Controls.Add(this.lblJumpDelay);
            this.Controls.Add(this.lblBlockDelay);
            this.Controls.Add(this.txtJumpDelay);
            this.Controls.Add(this.txtBlockDelay);
            this.Controls.Add(this.lblLungeState);
            this.Controls.Add(this.btnLungeToggle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLungeToggle;
        private System.Windows.Forms.Label lblLungeState;
        private System.Windows.Forms.TextBox txtBlockDelay;
        private System.Windows.Forms.TextBox txtJumpDelay;
        private System.Windows.Forms.Label lblBlockDelay;
        private System.Windows.Forms.Label lblJumpDelay;
        private System.Windows.Forms.Label lblKeyStroke;
        private System.Windows.Forms.Label lblListenFrequency;
        private System.Windows.Forms.TextBox txtKeyStroke;
        private System.Windows.Forms.TextBox txtListenFrequency;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblJuggleState;
        private System.Windows.Forms.Button btnJuggleToggle;
        private System.Windows.Forms.TextBox txtMoveKeyStroke;
        private System.Windows.Forms.TextBox txtDropKeyStroke;
        private System.Windows.Forms.TextBox txtSprintKeyStroke;
        private System.Windows.Forms.TextBox txtUseKeyStroke;
        private System.Windows.Forms.Label lblMoveKeyStroke;
        private System.Windows.Forms.Label lblDropKeyStroke;
        private System.Windows.Forms.Label lblSprintKeyStroke;
        private System.Windows.Forms.Label lblUseKeyStroke;
        private System.Windows.Forms.Label lblDropDelay;
        private System.Windows.Forms.Label lblMouseSpeed;
        private System.Windows.Forms.Label lblRunDelay;
        private System.Windows.Forms.Label lblUseDelay;
        private System.Windows.Forms.Label lblMouseDistance;
        private System.Windows.Forms.TextBox txtDropDelay;
        private System.Windows.Forms.TextBox txtMouseSpeed;
        private System.Windows.Forms.TextBox txtRunDelay;
        private System.Windows.Forms.TextBox txtUseDelay;
        private System.Windows.Forms.TextBox txtMouseDistance;
        private System.Windows.Forms.Button btnInfoSwordLunge;
        private System.Windows.Forms.Button btnInfoJuggle;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Button btnDoubleGunToggle;
        private System.Windows.Forms.Label lblDgState;
        private System.Windows.Forms.TextBox txtDgKeyStroke;
        private System.Windows.Forms.Label lblDgKeyStroke;
        private System.Windows.Forms.Label lblSwitchKeyStroke;
        private System.Windows.Forms.TextBox txtSwitchKeyStroke;
        private System.Windows.Forms.TextBox txtSwitchDelay;
        private System.Windows.Forms.Label lblSwitchDelay;
        private System.Windows.Forms.Label lblFireKeyStroke;
        private System.Windows.Forms.TextBox txtFireKeyStroke;
        private System.Windows.Forms.Label lblAimKeyStroke;
        private System.Windows.Forms.TextBox txtAimKeyStroke;
        private System.Windows.Forms.TextBox txtAdsDelay;
        private System.Windows.Forms.Label lblAdsDelay;
        private System.Windows.Forms.Button btnInfoDoubleGun;
        private System.Windows.Forms.Label lblBhopToggle;
        private System.Windows.Forms.Button btnBhopToggle;
        private System.Windows.Forms.Label lblBhopStateKeyStroke;
        private System.Windows.Forms.TextBox txtBhopStateKeyStroke;
        private System.Windows.Forms.Label lblAntiAFKStateToggle;
        private System.Windows.Forms.Button btnAntiAFKStateToggle;
        private System.Windows.Forms.Label lblAutoCannonStateToggle;
        private System.Windows.Forms.Button btnAutoCannonStateToggle;
        private System.Windows.Forms.TextBox txtReloadDelay;
        private System.Windows.Forms.Label lblReloadDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReloadKeyStroke;
        private System.Windows.Forms.TextBox txtReloadKeyStroke;
        private System.Windows.Forms.Label lblCannonToggleKeyStroke;
        private System.Windows.Forms.TextBox txtCannonToggleKeyStroke;
        private System.Windows.Forms.Label lblAutoLootToggleState;
        private System.Windows.Forms.Button btnAutoLootToggleState;
        private System.Windows.Forms.Label lblLootToggle;
        private System.Windows.Forms.TextBox txtAutoLootToggleKeyStroke;
        private System.Windows.Forms.Button btnDefault;
    }
}

