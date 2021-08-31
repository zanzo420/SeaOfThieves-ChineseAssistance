
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfoSwordLunge = new System.Windows.Forms.Button();
            this.btnInfoJuggle = new System.Windows.Forms.Button();
            this.lblReference = new System.Windows.Forms.Label();
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
            this.lblLungeState.Location = new System.Drawing.Point(128, 31);
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
            this.lblKeyStroke.Location = new System.Drawing.Point(133, 124);
            this.lblKeyStroke.Name = "lblKeyStroke";
            this.lblKeyStroke.Size = new System.Drawing.Size(26, 15);
            this.lblKeyStroke.TabIndex = 9;
            this.lblKeyStroke.Text = "Key";
            // 
            // lblListenFrequency
            // 
            this.lblListenFrequency.AutoSize = true;
            this.lblListenFrequency.Location = new System.Drawing.Point(217, 216);
            this.lblListenFrequency.Name = "lblListenFrequency";
            this.lblListenFrequency.Size = new System.Drawing.Size(99, 15);
            this.lblListenFrequency.TabIndex = 8;
            this.lblListenFrequency.Text = "Listen frequency*";
            // 
            // txtKeyStroke
            // 
            this.txtKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtKeyStroke.Location = new System.Drawing.Point(27, 116);
            this.txtKeyStroke.Name = "txtKeyStroke";
            this.txtKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtKeyStroke.TabIndex = 7;
            this.txtKeyStroke.Text = "0x11";
            // 
            // txtListenFrequency
            // 
            this.txtListenFrequency.Location = new System.Drawing.Point(111, 212);
            this.txtListenFrequency.Name = "txtListenFrequency";
            this.txtListenFrequency.Size = new System.Drawing.Size(100, 23);
            this.txtListenFrequency.TabIndex = 6;
            this.txtListenFrequency.Text = "50";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Location = new System.Drawing.Point(318, 212);
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
            this.lblJuggleState.Location = new System.Drawing.Point(318, 31);
            this.lblJuggleState.Name = "lblJuggleState";
            this.lblJuggleState.Size = new System.Drawing.Size(22, 15);
            this.lblJuggleState.TabIndex = 12;
            this.lblJuggleState.Text = "off";
            // 
            // btnJuggleToggle
            // 
            this.btnJuggleToggle.BackColor = System.Drawing.Color.LightGray;
            this.btnJuggleToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuggleToggle.Location = new System.Drawing.Point(217, 14);
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
            this.txtMoveKeyStroke.Location = new System.Drawing.Point(217, 57);
            this.txtMoveKeyStroke.Name = "txtMoveKeyStroke";
            this.txtMoveKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtMoveKeyStroke.TabIndex = 13;
            this.txtMoveKeyStroke.Text = "0x11";
            // 
            // txtDropKeyStroke
            // 
            this.txtDropKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtDropKeyStroke.Location = new System.Drawing.Point(217, 87);
            this.txtDropKeyStroke.Name = "txtDropKeyStroke";
            this.txtDropKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtDropKeyStroke.TabIndex = 14;
            this.txtDropKeyStroke.Text = "0x11";
            // 
            // txtSprintKeyStroke
            // 
            this.txtSprintKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtSprintKeyStroke.Location = new System.Drawing.Point(217, 116);
            this.txtSprintKeyStroke.Name = "txtSprintKeyStroke";
            this.txtSprintKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtSprintKeyStroke.TabIndex = 15;
            this.txtSprintKeyStroke.Text = "0x11";
            // 
            // txtUseKeyStroke
            // 
            this.txtUseKeyStroke.BackColor = System.Drawing.Color.White;
            this.txtUseKeyStroke.Location = new System.Drawing.Point(217, 145);
            this.txtUseKeyStroke.Name = "txtUseKeyStroke";
            this.txtUseKeyStroke.Size = new System.Drawing.Size(100, 23);
            this.txtUseKeyStroke.TabIndex = 16;
            this.txtUseKeyStroke.Text = "0x11";
            // 
            // lblMoveKeyStroke
            // 
            this.lblMoveKeyStroke.AutoSize = true;
            this.lblMoveKeyStroke.Location = new System.Drawing.Point(323, 65);
            this.lblMoveKeyStroke.Name = "lblMoveKeyStroke";
            this.lblMoveKeyStroke.Size = new System.Drawing.Size(26, 15);
            this.lblMoveKeyStroke.TabIndex = 17;
            this.lblMoveKeyStroke.Text = "Key";
            // 
            // lblDropKeyStroke
            // 
            this.lblDropKeyStroke.AutoSize = true;
            this.lblDropKeyStroke.Location = new System.Drawing.Point(323, 95);
            this.lblDropKeyStroke.Name = "lblDropKeyStroke";
            this.lblDropKeyStroke.Size = new System.Drawing.Size(55, 15);
            this.lblDropKeyStroke.TabIndex = 18;
            this.lblDropKeyStroke.Text = "Drop Key";
            // 
            // lblSprintKeyStroke
            // 
            this.lblSprintKeyStroke.AutoSize = true;
            this.lblSprintKeyStroke.Location = new System.Drawing.Point(323, 124);
            this.lblSprintKeyStroke.Name = "lblSprintKeyStroke";
            this.lblSprintKeyStroke.Size = new System.Drawing.Size(60, 15);
            this.lblSprintKeyStroke.TabIndex = 19;
            this.lblSprintKeyStroke.Text = "Sprint Key";
            // 
            // lblUseKeyStroke
            // 
            this.lblUseKeyStroke.AutoSize = true;
            this.lblUseKeyStroke.Location = new System.Drawing.Point(323, 153);
            this.lblUseKeyStroke.Name = "lblUseKeyStroke";
            this.lblUseKeyStroke.Size = new System.Drawing.Size(48, 15);
            this.lblUseKeyStroke.TabIndex = 20;
            this.lblUseKeyStroke.Text = "Use Key";
            // 
            // lblDropDelay
            // 
            this.lblDropDelay.AutoSize = true;
            this.lblDropDelay.Location = new System.Drawing.Point(496, 65);
            this.lblDropDelay.Name = "lblDropDelay";
            this.lblDropDelay.Size = new System.Drawing.Size(65, 15);
            this.lblDropDelay.TabIndex = 21;
            this.lblDropDelay.Text = "Drop Delay";
            // 
            // lblMouseSpeed
            // 
            this.lblMouseSpeed.AutoSize = true;
            this.lblMouseSpeed.Location = new System.Drawing.Point(496, 95);
            this.lblMouseSpeed.Name = "lblMouseSpeed";
            this.lblMouseSpeed.Size = new System.Drawing.Size(78, 15);
            this.lblMouseSpeed.TabIndex = 22;
            this.lblMouseSpeed.Text = "Mouse Speed";
            // 
            // lblRunDelay
            // 
            this.lblRunDelay.AutoSize = true;
            this.lblRunDelay.Location = new System.Drawing.Point(496, 124);
            this.lblRunDelay.Name = "lblRunDelay";
            this.lblRunDelay.Size = new System.Drawing.Size(60, 15);
            this.lblRunDelay.TabIndex = 23;
            this.lblRunDelay.Text = "Run Delay";
            // 
            // lblUseDelay
            // 
            this.lblUseDelay.AutoSize = true;
            this.lblUseDelay.Location = new System.Drawing.Point(496, 153);
            this.lblUseDelay.Name = "lblUseDelay";
            this.lblUseDelay.Size = new System.Drawing.Size(58, 15);
            this.lblUseDelay.TabIndex = 24;
            this.lblUseDelay.Text = "Use Delay";
            // 
            // lblMouseDistance
            // 
            this.lblMouseDistance.AutoSize = true;
            this.lblMouseDistance.Location = new System.Drawing.Point(496, 182);
            this.lblMouseDistance.Name = "lblMouseDistance";
            this.lblMouseDistance.Size = new System.Drawing.Size(91, 15);
            this.lblMouseDistance.TabIndex = 25;
            this.lblMouseDistance.Text = "Mouse Distance";
            // 
            // txtDropDelay
            // 
            this.txtDropDelay.BackColor = System.Drawing.Color.White;
            this.txtDropDelay.Location = new System.Drawing.Point(390, 57);
            this.txtDropDelay.Name = "txtDropDelay";
            this.txtDropDelay.Size = new System.Drawing.Size(100, 23);
            this.txtDropDelay.TabIndex = 26;
            this.txtDropDelay.Text = "0x11";
            // 
            // txtMouseSpeed
            // 
            this.txtMouseSpeed.BackColor = System.Drawing.Color.White;
            this.txtMouseSpeed.Location = new System.Drawing.Point(390, 87);
            this.txtMouseSpeed.Name = "txtMouseSpeed";
            this.txtMouseSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtMouseSpeed.TabIndex = 27;
            this.txtMouseSpeed.Text = "0x11";
            // 
            // txtRunDelay
            // 
            this.txtRunDelay.BackColor = System.Drawing.Color.White;
            this.txtRunDelay.Location = new System.Drawing.Point(390, 116);
            this.txtRunDelay.Name = "txtRunDelay";
            this.txtRunDelay.Size = new System.Drawing.Size(100, 23);
            this.txtRunDelay.TabIndex = 28;
            this.txtRunDelay.Text = "0x11";
            // 
            // txtUseDelay
            // 
            this.txtUseDelay.BackColor = System.Drawing.Color.White;
            this.txtUseDelay.Location = new System.Drawing.Point(390, 145);
            this.txtUseDelay.Name = "txtUseDelay";
            this.txtUseDelay.Size = new System.Drawing.Size(100, 23);
            this.txtUseDelay.TabIndex = 29;
            this.txtUseDelay.Text = "0x11";
            // 
            // txtMouseDistance
            // 
            this.txtMouseDistance.BackColor = System.Drawing.Color.White;
            this.txtMouseDistance.Location = new System.Drawing.Point(390, 174);
            this.txtMouseDistance.Name = "txtMouseDistance";
            this.txtMouseDistance.Size = new System.Drawing.Size(100, 23);
            this.txtMouseDistance.TabIndex = 30;
            this.txtMouseDistance.Text = "0x11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Double Gun Macro //Todo";
            // 
            // btnInfoSwordLunge
            // 
            this.btnInfoSwordLunge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoSwordLunge.Location = new System.Drawing.Point(27, 153);
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
            this.btnInfoJuggle.Location = new System.Drawing.Point(217, 182);
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
            this.lblReference.Location = new System.Drawing.Point(481, 28);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(127, 15);
            this.lblReference.TabIndex = 34;
            this.lblReference.Text = "*Lower for better CPUs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(635, 244);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.btnInfoJuggle);
            this.Controls.Add(this.btnInfoSwordLunge);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoSwordLunge;
        private System.Windows.Forms.Button btnInfoJuggle;
        private System.Windows.Forms.Label lblReference;
    }
}

