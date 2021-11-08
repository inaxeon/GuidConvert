using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidConvert
{
    public partial class GuidConverter : Form
    {
        enum FromType
        {
            Invalid,
            Guid,
            Hex,
            C
        }

        public GuidConverter()
        {
            InitializeComponent();
        }

        public static byte[] StringToByteArray(string hex)
        {
            hex = hex.Replace(" ", "");

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void ConvertGuid()
        {
            try
            {
                var fromType = GetFromType();
                Guid guid = Guid.Empty;

                if (fromType == FromType.Invalid)
                {
                    MessageBox.Show("No input, or too many inputs, Enter only one input", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (fromType)
                {
                    case FromType.Guid:
                        guid = Guid.Parse(txtGuid.Text);
                        break;
                    case FromType.Hex:
                        var bytes = StringToByteArray(txtHex.Text);
                        guid = new Guid(bytes);
                        break;
                    case FromType.C:
                        guid = Guid.ParseExact(txtC.Text, "X");
                        break;
                }

                switch (fromType)
                {
                    case FromType.Guid:
                        SetHexGuid(guid);
                        SetCGuid(guid);
                        break;
                    case FromType.Hex:
                        SetTextGuid(guid);
                        SetCGuid(guid);
                        break;
                    case FromType.C:
                        SetTextGuid(guid);
                        SetHexGuid(guid);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertGuid();
        }

        void SetTextGuid(Guid guid)
        {
            txtGuid.Text = guid.ToString().ToUpperInvariant();
        }

        void SetHexGuid(Guid guid)
        {
            txtHex.Text = string.Join(" ", guid.ToByteArray().Select(b => b.ToString("X2")));
        }

        void SetCGuid(Guid guid)
        {
            int a = guid.GetFieldValue<int>("_a");
            short b = guid.GetFieldValue<short>("_b");
            short c = guid.GetFieldValue<short>("_c");
            byte d = guid.GetFieldValue<byte>("_d");
            byte e = guid.GetFieldValue<byte>("_e");
            byte f = guid.GetFieldValue<byte>("_f");
            byte g = guid.GetFieldValue<byte>("_g");
            byte h = guid.GetFieldValue<byte>("_h");
            byte i = guid.GetFieldValue<byte>("_i");
            byte j = guid.GetFieldValue<byte>("_j");
            byte k = guid.GetFieldValue<byte>("_k");

            txtC.Text = string.Format("{{ 0x{0:X8}, 0x{1:X4}, 0x{2:X4}, {{ 0x{3:X2}, 0x{4:X2}, 0x{5:X2}, 0x{6:X2}, 0x{7:X2}, 0x{8:X2}, 0x{9:X2}, 0x{10:X2} }} }}",
                a, b, c, d, e, f, g, h, i, j, k);
        }

        private FromType GetFromType()
        {
            FromType ret = FromType.Invalid;
            int numSet = 0;

            if (!string.IsNullOrEmpty(txtGuid.Text))
            {
                ret = FromType.Guid;
                numSet++;
            }

            if (!string.IsNullOrEmpty(txtHex.Text))
            {
                ret = FromType.Hex;
                numSet++;
            }

            if (!string.IsNullOrEmpty(txtC.Text))
            {
                ret = FromType.C;
                numSet++;
            }

            if (numSet == 1)
                return ret;

            return FromType.Invalid;
        }

        private void Clear()
        {
            txtGuid.Text = "";
            txtHex.Text = "";
            txtC.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNativePaste_Click(object sender, EventArgs e)
        {
            Clear();
            txtGuid.Text = Clipboard.GetText();
            ConvertGuid();
        }

        private void btnNativeCopy_Click(object sender, EventArgs e)
        {
            txtGuid.SelectAll();
            txtGuid.Copy();
        }

        private void btnHexPaste_Click(object sender, EventArgs e)
        {
            Clear();
            txtHex.Text = Clipboard.GetText();
            ConvertGuid();
        }

        private void btnHexCopy_Click(object sender, EventArgs e)
        {
            txtHex.SelectAll();
            txtHex.Copy();
        }

        private void btnCPaste_Click(object sender, EventArgs e)
        {
            Clear();
            txtC.Text = Clipboard.GetText();
            ConvertGuid();
        }

        private void btnCCopy_Click(object sender, EventArgs e)
        {
            txtC.SelectAll();
            txtC.Copy();
        }
    }
}
