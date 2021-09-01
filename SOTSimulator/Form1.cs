using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOTSimulator
{
    public partial class Form1 : Form
    {
        #region Initialize
        public Form1()
        {
            InitializeComponent();
            Script.setAccess(this);
            setValues(FileHandler.ReadFromFile());
        }
        #endregion

        #region Interface
        private void setValues(Model aModel)
        {
            this.txtBlockDelay.Text = aModel.blockDelay.ToString();
            this.txtJumpDelay.Text = aModel.jumpDelay.ToString();
            this.txtKeyStroke.Text = aModel.keyStroke.ToString();
            this.txtListenFrequency.Text = aModel.listenFrequency.ToString();
            this.txtMoveKeyStroke.Text = aModel.moveKeyStroke.ToString();
            this.txtDropKeyStroke.Text = aModel.dropKeyStroke.ToString();
            this.txtSprintKeyStroke.Text = aModel.sprintKeyStroke.ToString();
            this.txtUseKeyStroke.Text = aModel.useKeyStroke.ToString();
            this.txtDropDelay.Text = aModel.dropDelay.ToString();
            this.txtMouseSpeed.Text = aModel.mouseSpeed.ToString();
            this.txtRunDelay.Text = aModel.runDelay.ToString();
            this.txtUseDelay.Text = aModel.useDelay.ToString();
            this.txtMouseDistance.Text = aModel.mouseDistance.ToString();
            this.txtDgKeyStroke.Text = aModel.dgKeyStroke.ToString();
            this.txtSwitchKeyStroke.Text = aModel.switchKeyStroke.ToString();
            this.txtSwitchDelay.Text = aModel.switchDelay.ToString();
            this.txtFireKeyStroke.Text = aModel.fireKeyStroke.ToString();
            this.txtAimKeyStroke.Text = aModel.aimKeyStroke.ToString();
            this.txtAdsDelay.Text = aModel.adsDelay.ToString();
            this.txtBhopStateKeyStroke.Text = aModel.bhopStateKeyStroke.ToString();
            this.txtCannonToggleKeyStroke.Text = aModel.CannonStateKeyStroke.ToString();
            this.txtReloadDelay.Text = aModel.reloadDelay.ToString();
            this.txtReloadKeyStroke.Text = aModel.reloadKeyStroke.ToString();
            this.txtAutoLootToggleKeyStroke.Text = aModel.autoLootKeyStroke.ToString();
        }

        public void readValues(Model aModel)
        {
            aModel.blockDelay = Convert.ToInt32(this.txtBlockDelay.Text);
            aModel.jumpDelay = Convert.ToInt32(this.txtJumpDelay.Text);
            aModel.listenFrequency = Convert.ToInt32(this.txtListenFrequency.Text);
            try
            {
                aModel.keyStroke = Convert.ToInt32(this.txtKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.keyStroke = Convert.ToInt32(this.txtKeyStroke.Text, 16);
            }
            try
            {
                aModel.moveKeyStroke = Convert.ToInt32(this.txtMoveKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.moveKeyStroke = Convert.ToInt32(this.txtMoveKeyStroke.Text, 16);
            }
            try
            {
                aModel.dropKeyStroke = Convert.ToInt32(this.txtDropKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.dropKeyStroke = Convert.ToInt32(this.txtDropKeyStroke.Text, 16);
            }
            try
            {
                aModel.sprintKeyStroke = Convert.ToInt32(this.txtSprintKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.sprintKeyStroke = Convert.ToInt32(this.txtSprintKeyStroke.Text, 16);
            }
            try
            {
                aModel.useKeyStroke = Convert.ToInt32(this.txtUseKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.useKeyStroke = Convert.ToInt32(this.txtUseKeyStroke.Text, 16);
            }
            aModel.dropDelay = Convert.ToInt32(this.txtDropDelay.Text);
            aModel.mouseSpeed = Convert.ToInt32(this.txtMouseSpeed.Text);
            aModel.runDelay = Convert.ToInt32(this.txtRunDelay.Text);
            aModel.useDelay = Convert.ToInt32(this.txtUseDelay.Text);
            aModel.mouseDistance = Convert.ToInt32(this.txtMouseDistance.Text);
            try
            {
                aModel.dgKeyStroke = Convert.ToInt32(this.txtDgKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.dgKeyStroke = Convert.ToInt32(this.txtDgKeyStroke.Text, 16);
            }
            try
            {
                aModel.switchKeyStroke = Convert.ToInt32(this.txtSwitchKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.switchKeyStroke = Convert.ToInt32(this.txtSwitchKeyStroke.Text, 16);
            }
            aModel.switchDelay = Convert.ToInt32(this.txtSwitchDelay.Text);
            try
            {
                aModel.fireKeyStroke = Convert.ToInt32(this.txtFireKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.fireKeyStroke = Convert.ToInt32(this.txtFireKeyStroke.Text, 16);
            }
            try
            {
                aModel.aimKeyStroke = Convert.ToInt32(this.txtAimKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.aimKeyStroke = Convert.ToInt32(this.txtAimKeyStroke.Text, 16);
            }
            aModel.adsDelay = Convert.ToInt32(this.txtAdsDelay.Text);
            try
            {
                aModel.bhopStateKeyStroke = Convert.ToInt32(this.txtBhopStateKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.bhopStateKeyStroke = Convert.ToInt32(this.txtBhopStateKeyStroke.Text, 16);
            }
            try
            {
                aModel.reloadKeyStroke = Convert.ToInt32(this.txtReloadKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.reloadKeyStroke = Convert.ToInt32(this.txtReloadKeyStroke.Text, 16);
            }
            try
            {
                aModel.CannonStateKeyStroke = Convert.ToInt32(this.txtCannonToggleKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.CannonStateKeyStroke = Convert.ToInt32(this.txtCannonToggleKeyStroke.Text, 16);
            }
            aModel.reloadDelay = Convert.ToInt32(this.txtReloadDelay.Text);
            try
            {
                aModel.autoLootKeyStroke = Convert.ToInt32(this.txtAutoLootToggleKeyStroke.Text);
            }
            catch (Exception useless)
            {
                aModel.autoLootKeyStroke = Convert.ToInt32(this.txtAutoLootToggleKeyStroke.Text, 16);
            }
        }
        #endregion

        #region ClickEvents
        private void btnLungeToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("Lunge"))
            {
                lblLungeState.Text = "on";
                lblLungeState.ForeColor = Color.Green;
            }
            else
            {
                lblLungeState.Text = "off";
                lblLungeState.ForeColor = Color.Red;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Model currentSettings = new Model();
            readValues(currentSettings);
            FileHandler.WriteToFile(currentSettings);
        }

        private void btnJuggleToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("Move"))
            {
                lblJuggleState.Text = "on";
                lblJuggleState.ForeColor = Color.Green;
            }
            else
            {
                lblJuggleState.Text = "off";
                lblJuggleState.ForeColor = Color.Red;
            }
        }

        private void btnInfoSwordLunge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Block\n->Block delay\n->Attack\n->Jump delay\n->Jump\n->Sleep for 100ms");
        }

        private void btnInfoJuggle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Sleep for 50ms\n->Drop item\n->Look down\n->Drop delay(should be shorter)\n->Start sprinting\n->Run delay\n->Press use\n->Look up\n->Use delay(should be longer)\n->Stop holding use & sprint\n\nMouse distance determines how far down/up to look\n\nMouse speed determines lenght of mouse event.");

        }

        private void btnDoubleGunToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("DoubleGun"))
            {
                lblDgState.Text = "on";
                lblDgState.ForeColor = Color.Green;
            }
            else
            {
                lblDgState.Text = "off";
                lblDgState.ForeColor = Color.Red;
            }
        }

        private void btnBhopToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("Bhop"))
            {
                lblBhopToggle.Text = "on";
                lblBhopToggle.ForeColor = Color.Green;
            }
            else
            {
                lblBhopToggle.Text = "off";
                lblBhopToggle.ForeColor = Color.Red;
            }
        }

        private void btnInfoDoubleGun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Switch weapon\n->Sprint\n->Switch delay\n->ADS\n->Aim delay\n->Fire");
        }

        private void btnAntiAFKStateToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("AFK"))
            {
                lblAntiAFKStateToggle.Text = "on";
                lblAntiAFKStateToggle.ForeColor = Color.Green;
            }
            else
            {
                lblAntiAFKStateToggle.Text = "off";
                lblAntiAFKStateToggle.ForeColor = Color.Red;
            }
        }

        private void btnAutoCannonStateToggle_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("Cannon"))
            {
                lblAutoCannonStateToggle.Text = "on";
                lblAutoCannonStateToggle.ForeColor = Color.Green;
            }
            else
            {
                lblAutoCannonStateToggle.Text = "off";
                lblAutoCannonStateToggle.ForeColor = Color.Red;
            }
        }

        private void btnAutoLootToggleState_Click(object sender, EventArgs e)
        {
            if (Script.toggleState("Loot"))
            {
                lblAutoLootToggleState.Text = "on";
                lblAutoLootToggleState.ForeColor = Color.Green;
            }
            else
            {
                lblAutoLootToggleState.Text = "off";
                lblAutoLootToggleState.ForeColor = Color.Red;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            setValues(new Model());
        }
        #endregion
    }
}
