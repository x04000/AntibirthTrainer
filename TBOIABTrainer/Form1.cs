using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TBOIABTrainer
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();

        // "zhlRemix2.dll"+0027CF60 + B54
        string healthAddress = "zhlRemix2.dll+0027CF60,B54";
        // "zhlRemix2.dll"+0027CF60 + B70
        string bombsAddress = "zhlRemix2.dll+0027CF60,B70";
        // "zhlRemix2.dll"+0027CF60 + B68
        string keysAddress = "zhlRemix2.dll+0027CF60,B68";
        // "zhlRemix2.dll"+0027CF60 + 5D0 + 38 + 7F8 + B74
        string coinsAddress = "zhlRemix2.dll+0027CF60,5D0,38,7F8,B74";
        // "zhlRemix2.dll"+0027CF60 + BF0
        string damageAddress = "zhlRemix2.dll+0027CF60,BF0";
        // "zhlRemix2.dll"+0027CF60 + 5D0 + 38 + 7F8 + B5C
        string blueHeartsAddress = "zhlRemix2.dll+0027CF60,5D0,38,7F8,B5C";
        // "zhlRemix2.dll"+0027CF60 + BE0
        string tearsAddress = "zhlRemix2.dll+0027CF60,BE0";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("isaac-ng.exe");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                timer1.Start();
            }
            else
            {
                MessageBox.Show("TBOI Antibirth is not started!", "Antibirth Trainer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                m.WriteMemory(healthAddress, "int", "100");
            }
            if (checkBox2.Checked)
            {
                m.WriteMemory(bombsAddress, "int", "99");
            }
            if (checkBox3.Checked)
            {
                m.WriteMemory(keysAddress, "int", "99");
            }
            if (checkBox4.Checked)
            {
                m.WriteMemory(coinsAddress, "int", "99");
            }
            if (checkBox5.Checked)
            {
                string damageSelected = comboBox1.Text;
                if (damageSelected == "1")
                {
                    m.WriteMemory(damageAddress, "int", "1065353216");
                }
                if (damageSelected == "2")
                {
                    m.WriteMemory(damageAddress, "int", "1073741824");
                }
                if (damageSelected == "3")
                {
                    m.WriteMemory(damageAddress, "int", "1077936128");
                }
                if (damageSelected == "4")
                {
                    m.WriteMemory(damageAddress, "int", "1082130432");
                }
                if (damageSelected == "5")
                {
                    m.WriteMemory(damageAddress, "int", "1084227584");
                }
                if (damageSelected == "6")
                {
                    m.WriteMemory(damageAddress, "int", "1086324736");
                }
                if (damageSelected == "7")
                {
                    m.WriteMemory(damageAddress, "int", "1088421888");
                }
                if (damageSelected == "8")
                {
                    m.WriteMemory(damageAddress, "int", "1090519040");
                }
                if (damageSelected == "9")
                {
                    m.WriteMemory(damageAddress, "int", "1091567616");
                }
                if (damageSelected == "10")
                {
                    m.WriteMemory(damageAddress, "int", "1092616192");
                }
                if (damageSelected == "13")
                {
                    m.WriteMemory(damageAddress, "int", "1095761920");
                }
                if (damageSelected == "15")
                {
                    m.WriteMemory(damageAddress, "int", "1097859072");
                }
                if (damageSelected == "17")
                {
                    m.WriteMemory(damageAddress, "int", "1099431936");
                }
                if (damageSelected == "20")
                {
                    m.WriteMemory(damageAddress, "int", "1101004800");
                }
                if (damageSelected == "30")
                {
                    m.WriteMemory(damageAddress, "int", "1106247680");
                }
                if (damageSelected == "40")
                {
                    m.WriteMemory(damageAddress, "int", "1109393408");
                }
                if (damageSelected == "50")
                {
                    m.WriteMemory(damageAddress, "int", "1112014848");
                }
                if (damageSelected == "100")
                {
                    m.WriteMemory(damageAddress, "int", "1120403456");
                }
                if (damageSelected == "500")
                {
                    m.WriteMemory(damageAddress, "int", "1140457472");
                }
                if (damageSelected == "999")
                {
                    m.WriteMemory(damageAddress, "int", "1148829696");
                }
                if (damageSelected == "999999")
                {
                    m.WriteMemory(damageAddress, "int", "1232348144");
                }
            }
            if (checkBox6.Checked)
            {
                m.WriteMemory(blueHeartsAddress, "int", "22");
            }
            if (checkBox7.Checked)
            {
                if (comboBox2.Text != "")
                {
                    string tearsSelected = comboBox2.Text;
                    m.WriteMemory(tearsAddress, "int", tearsSelected);
                }
                else
                {
                    checkBox7.Checked = false;
                    MessageBox.Show("Select a value for tears", "Antibirth Trainer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }
}
