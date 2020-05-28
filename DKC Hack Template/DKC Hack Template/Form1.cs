using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKC_Hack_Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        ROM _rom = new ROM();


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _rom.Load();
            if (ROM.loadROMSuccess)
            {
                loadToolStripMenuItem.Enabled = false;
                Init();
            }
        }

        private void Init ()
        {
            panel_template.Visible = true;

            // Set cursor to end
            textBox_versionInput.Focus();
            textBox_versionInput.SelectionStart = textBox_versionInput.Text.Length;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void button_standardize_Click(object sender, EventArgs e)
        {
            Standardize();
        }

        private void textBox_versionInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Enable pressing enter does the same thing
            if (Keys.Return == e.KeyCode)
            {
                Standardize();
            }
        }

        private void Standardize ()
        {
            // Apply our patch
            ASM.ApplyPatch(ASM.ASMaddresses, ASM.ASMvalues, _rom.rom);

            // Are we skipping K Rool?
            _rom.rom[0x12fe91] = (byte)(checkBox_kkr.Checked ? 0x68 : 0);

            // Write string to ROM
            _rom.WriteString(0x23e211, "                                              ");
            _rom.WriteString(0x23e211, textBox_versionInput.Text);

            _rom.SaveROM("ROM hack");

            // Show so we dont have a silent program
            MessageBox.Show("Standardized!");

            // Exit after
            Application.Exit();

        }
    }
}
