namespace GuidConvert
{
    partial class GuidConverter
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNativePaste = new System.Windows.Forms.Button();
            this.btnNativeCopy = new System.Windows.Forms.Button();
            this.btnHexCopy = new System.Windows.Forms.Button();
            this.btnHexPaste = new System.Windows.Forms.Button();
            this.btnCCopy = new System.Windows.Forms.Button();
            this.btnCPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(12, 111);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(447, 20);
            this.txtC.TabIndex = 2;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(12, 68);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(447, 20);
            this.txtHex.TabIndex = 1;
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(12, 29);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.ReadOnly = true;
            this.txtGuid.Size = new System.Drawing.Size(447, 20);
            this.txtGuid.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(303, 141);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Native GUID Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Little Endian Hex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C Struct Initialiser:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(385, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNativePaste
            // 
            this.btnNativePaste.Location = new System.Drawing.Point(465, 29);
            this.btnNativePaste.Name = "btnNativePaste";
            this.btnNativePaste.Size = new System.Drawing.Size(53, 21);
            this.btnNativePaste.TabIndex = 7;
            this.btnNativePaste.Text = "Paste";
            this.btnNativePaste.UseVisualStyleBackColor = true;
            this.btnNativePaste.Click += new System.EventHandler(this.btnNativePaste_Click);
            // 
            // btnNativeCopy
            // 
            this.btnNativeCopy.Location = new System.Drawing.Point(524, 29);
            this.btnNativeCopy.Name = "btnNativeCopy";
            this.btnNativeCopy.Size = new System.Drawing.Size(53, 21);
            this.btnNativeCopy.TabIndex = 8;
            this.btnNativeCopy.Text = "Copy";
            this.btnNativeCopy.UseVisualStyleBackColor = true;
            this.btnNativeCopy.Click += new System.EventHandler(this.btnNativeCopy_Click);
            // 
            // btnHexCopy
            // 
            this.btnHexCopy.Location = new System.Drawing.Point(524, 68);
            this.btnHexCopy.Name = "btnHexCopy";
            this.btnHexCopy.Size = new System.Drawing.Size(53, 21);
            this.btnHexCopy.TabIndex = 10;
            this.btnHexCopy.Text = "Copy";
            this.btnHexCopy.UseVisualStyleBackColor = true;
            this.btnHexCopy.Click += new System.EventHandler(this.btnHexCopy_Click);
            // 
            // btnHexPaste
            // 
            this.btnHexPaste.Location = new System.Drawing.Point(465, 68);
            this.btnHexPaste.Name = "btnHexPaste";
            this.btnHexPaste.Size = new System.Drawing.Size(53, 21);
            this.btnHexPaste.TabIndex = 9;
            this.btnHexPaste.Text = "Paste";
            this.btnHexPaste.UseVisualStyleBackColor = true;
            this.btnHexPaste.Click += new System.EventHandler(this.btnHexPaste_Click);
            // 
            // btnCCopy
            // 
            this.btnCCopy.Location = new System.Drawing.Point(524, 111);
            this.btnCCopy.Name = "btnCCopy";
            this.btnCCopy.Size = new System.Drawing.Size(53, 21);
            this.btnCCopy.TabIndex = 12;
            this.btnCCopy.Text = "Copy";
            this.btnCCopy.UseVisualStyleBackColor = true;
            this.btnCCopy.Click += new System.EventHandler(this.btnCCopy_Click);
            // 
            // btnCPaste
            // 
            this.btnCPaste.Location = new System.Drawing.Point(465, 111);
            this.btnCPaste.Name = "btnCPaste";
            this.btnCPaste.Size = new System.Drawing.Size(53, 21);
            this.btnCPaste.TabIndex = 11;
            this.btnCPaste.Text = "Paste";
            this.btnCPaste.UseVisualStyleBackColor = true;
            this.btnCPaste.Click += new System.EventHandler(this.btnCPaste_Click);
            // 
            // GuidConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 179);
            this.Controls.Add(this.btnCCopy);
            this.Controls.Add(this.btnCPaste);
            this.Controls.Add(this.btnHexCopy);
            this.Controls.Add(this.btnHexPaste);
            this.Controls.Add(this.btnNativeCopy);
            this.Controls.Add(this.btnNativePaste);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GuidConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guid Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNativePaste;
        private System.Windows.Forms.Button btnNativeCopy;
        private System.Windows.Forms.Button btnHexCopy;
        private System.Windows.Forms.Button btnHexPaste;
        private System.Windows.Forms.Button btnCCopy;
        private System.Windows.Forms.Button btnCPaste;
    }
}

