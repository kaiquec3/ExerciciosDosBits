using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projBitABit
{
    public partial class Form1 : Form
    {
        private Bits bits;

        public Form1()
        {
            InitializeComponent();
            bits = this.bits = new Bits();
        }

        private void clickou_em_SET(object sender, EventArgs e)
        {
            bits.setBits(byte.Parse(txtNumero.Text));
        }

        private void clickou_em_GET(object sender, EventArgs e)
        {
            lblBase10.Text = Convert.ToString(bits.getBits());
            lblBase2.Text = Convert.ToString(bits.getBits(), 2);
            lblBase16.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            chkBit1.Checked = (bits.getBits(1)) ? true : false;
            chkBit2.Checked = (bits.getBits(2)) ? true : false;
            chkBit3.Checked = (bits.getBits(3)) ? true : false;
            chkBit4.Checked = (bits.getBits(4)) ? true : false;
            chkBit5.Checked = (bits.getBits(5)) ? true : false;
            chkBit6.Checked = (bits.getBits(6)) ? true : false;
            chkBit7.Checked = (bits.getBits(7)) ? true : false;
            chkBit8.Checked = (bits.getBits(8)) ? true : false;
        }

        private void clickou_em_chkbit1(object sender, EventArgs e)
        {
            if (chkBit1.Checked) bits.setBit1(1);
            else bits.setBit0(1);
        }

        private void clickou_em_chkbit2(object sender, EventArgs e)
        {
            if (chkBit2.Checked) bits.setBit1(2);
            else bits.setBit0(2);
        }

        private void clickou_em_chkbit3(object sender, EventArgs e)
        {
            if (chkBit3.Checked) bits.setBit1(3);
            else bits.setBit0(3);
        }

        private void clickou_em_chkbit4(object sender, EventArgs e)
        {
            if (chkBit4.Checked) bits.setBit1(4);
            else bits.setBit0(4);
        }

        private void clickou_em_chkbit5(object sender, EventArgs e)
        {
            if (chkBit5.Checked) bits.setBit1(5);
            else bits.setBit0(5);
        }

        private void clickou_em_chkbit6(object sender, EventArgs e)
        {
            if (chkBit6.Checked) bits.setBit1(6);
            else bits.setBit0(6);
        }

        private void clickou_em_chkbit7(object sender, EventArgs e)
        {
            if (chkBit7.Checked) bits.setBit1(7);
            else bits.setBit0(7);
        }

        private void clickou_em_chkbit8(object sender, EventArgs e)
        {
            if (chkBit8.Checked) bits.setBit1(8);
            else bits.setBit0(8);
        }
    }
}
