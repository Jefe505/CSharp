using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WoWRun
{
    public partial class Form1 : Form
    {
        string[] realmList = new string [2];
        public Form1()
        {
            InitializeComponent();
        }

        private void radioScriptCraft_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioVanilla_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (radioScriptCraft.Checked)
            {
                realmList[0] = "set realmlist scriptcraft.servegame.com";
            }
            else if (radioVanilla.Checked)
            {
                realmList[0] = "set realmlist vanillafeenix.servegame.org";
                realmList[1] = "set realmname \"Warsong [12x] Blizzlike\"";
            }
            System.IO.File.WriteAllLines(@"D:\spel\World of Warcraft\realmlist.wtf", realmList);
            simpleRun_Click();
        }
        private void simpleRun_Click()
        {
            System.Diagnostics.Process.Start(@"D:\spel\World of Warcraft\WoW.exe");
            Application.Exit();
        }
    }
}
