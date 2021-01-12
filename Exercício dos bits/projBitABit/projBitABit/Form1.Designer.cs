namespace projBitABit
{
    partial class Form1
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSET = new System.Windows.Forms.Button();
            this.lblBase10 = new System.Windows.Forms.Label();
            this.lblBase2 = new System.Windows.Forms.Label();
            this.lblBase16 = new System.Windows.Forms.Label();
            this.btnGET = new System.Windows.Forms.Button();
            this.lblInformeUmNumero = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblHexadecimal = new System.Windows.Forms.Label();
            this.chkBit1 = new System.Windows.Forms.CheckBox();
            this.chkBit4 = new System.Windows.Forms.CheckBox();
            this.chkBit3 = new System.Windows.Forms.CheckBox();
            this.chkBit2 = new System.Windows.Forms.CheckBox();
            this.chkBit6 = new System.Windows.Forms.CheckBox();
            this.chkBit7 = new System.Windows.Forms.CheckBox();
            this.chkBit8 = new System.Windows.Forms.CheckBox();
            this.chkBit5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(240, 25);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(228, 26);
            this.txtNumero.TabIndex = 0;
            // 
            // btnSET
            // 
            this.btnSET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSET.Location = new System.Drawing.Point(240, 65);
            this.btnSET.Margin = new System.Windows.Forms.Padding(2);
            this.btnSET.Name = "btnSET";
            this.btnSET.Size = new System.Drawing.Size(98, 32);
            this.btnSET.TabIndex = 1;
            this.btnSET.Text = "SET";
            this.btnSET.UseVisualStyleBackColor = true;
            this.btnSET.Click += new System.EventHandler(this.clickou_em_SET);
            // 
            // lblBase10
            // 
            this.lblBase10.AutoSize = true;
            this.lblBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase10.Location = new System.Drawing.Point(348, 151);
            this.lblBase10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase10.Name = "lblBase10";
            this.lblBase10.Size = new System.Drawing.Size(18, 20);
            this.lblBase10.TabIndex = 2;
            this.lblBase10.Text = "0";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase2.Location = new System.Drawing.Point(348, 120);
            this.lblBase2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(18, 20);
            this.lblBase2.TabIndex = 3;
            this.lblBase2.Text = "0";
            // 
            // lblBase16
            // 
            this.lblBase16.AutoSize = true;
            this.lblBase16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase16.Location = new System.Drawing.Point(348, 183);
            this.lblBase16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase16.Name = "lblBase16";
            this.lblBase16.Size = new System.Drawing.Size(18, 20);
            this.lblBase16.TabIndex = 4;
            this.lblBase16.Text = "0";
            // 
            // btnGET
            // 
            this.btnGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGET.Location = new System.Drawing.Point(370, 65);
            this.btnGET.Margin = new System.Windows.Forms.Padding(2);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(98, 32);
            this.btnGET.TabIndex = 5;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.clickou_em_GET);
            // 
            // lblInformeUmNumero
            // 
            this.lblInformeUmNumero.AutoSize = true;
            this.lblInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeUmNumero.Location = new System.Drawing.Point(30, 28);
            this.lblInformeUmNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformeUmNumero.Name = "lblInformeUmNumero";
            this.lblInformeUmNumero.Size = new System.Drawing.Size(156, 20);
            this.lblInformeUmNumero.TabIndex = 19;
            this.lblInformeUmNumero.Text = "Informe um número: ";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.Location = new System.Drawing.Point(35, 120);
            this.lblBinario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(146, 20);
            this.lblBinario.TabIndex = 20;
            this.lblBinario.Text = "Número em binário:";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(35, 151);
            this.lblDecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(153, 20);
            this.lblDecimal.TabIndex = 21;
            this.lblDecimal.Text = "Número em decimal:";
            // 
            // lblHexadecimal
            // 
            this.lblHexadecimal.AutoSize = true;
            this.lblHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexadecimal.Location = new System.Drawing.Point(35, 183);
            this.lblHexadecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHexadecimal.Name = "lblHexadecimal";
            this.lblHexadecimal.Size = new System.Drawing.Size(187, 20);
            this.lblHexadecimal.TabIndex = 22;
            this.lblHexadecimal.Text = "Número em hexadecimal:";
            // 
            // chkBit1
            // 
            this.chkBit1.AutoSize = true;
            this.chkBit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit1.Location = new System.Drawing.Point(152, 270);
            this.chkBit1.Name = "chkBit1";
            this.chkBit1.Size = new System.Drawing.Size(60, 24);
            this.chkBit1.TabIndex = 23;
            this.chkBit1.Text = "Bit 1";
            this.chkBit1.UseVisualStyleBackColor = true;
            this.chkBit1.Click += new System.EventHandler(this.clickou_em_chkbit1);
            // 
            // chkBit4
            // 
            this.chkBit4.AutoSize = true;
            this.chkBit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit4.Location = new System.Drawing.Point(152, 360);
            this.chkBit4.Name = "chkBit4";
            this.chkBit4.Size = new System.Drawing.Size(60, 24);
            this.chkBit4.TabIndex = 24;
            this.chkBit4.Text = "Bit 4";
            this.chkBit4.UseVisualStyleBackColor = true;
            this.chkBit4.Click += new System.EventHandler(this.clickou_em_chkbit4);
            // 
            // chkBit3
            // 
            this.chkBit3.AutoSize = true;
            this.chkBit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit3.Location = new System.Drawing.Point(152, 330);
            this.chkBit3.Name = "chkBit3";
            this.chkBit3.Size = new System.Drawing.Size(60, 24);
            this.chkBit3.TabIndex = 25;
            this.chkBit3.Text = "Bit 3";
            this.chkBit3.UseVisualStyleBackColor = true;
            this.chkBit3.Click += new System.EventHandler(this.clickou_em_chkbit3);
            // 
            // chkBit2
            // 
            this.chkBit2.AutoSize = true;
            this.chkBit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit2.Location = new System.Drawing.Point(152, 300);
            this.chkBit2.Name = "chkBit2";
            this.chkBit2.Size = new System.Drawing.Size(60, 24);
            this.chkBit2.TabIndex = 26;
            this.chkBit2.Text = "Bit 2";
            this.chkBit2.UseVisualStyleBackColor = true;
            this.chkBit2.Click += new System.EventHandler(this.clickou_em_chkbit2);
            // 
            // chkBit6
            // 
            this.chkBit6.AutoSize = true;
            this.chkBit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit6.Location = new System.Drawing.Point(306, 300);
            this.chkBit6.Name = "chkBit6";
            this.chkBit6.Size = new System.Drawing.Size(60, 24);
            this.chkBit6.TabIndex = 30;
            this.chkBit6.Text = "Bit 6";
            this.chkBit6.UseVisualStyleBackColor = true;
            this.chkBit6.Click += new System.EventHandler(this.clickou_em_chkbit6);
            // 
            // chkBit7
            // 
            this.chkBit7.AutoSize = true;
            this.chkBit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit7.Location = new System.Drawing.Point(306, 330);
            this.chkBit7.Name = "chkBit7";
            this.chkBit7.Size = new System.Drawing.Size(60, 24);
            this.chkBit7.TabIndex = 29;
            this.chkBit7.Text = "Bit 7";
            this.chkBit7.UseVisualStyleBackColor = true;
            this.chkBit7.Click += new System.EventHandler(this.clickou_em_chkbit7);
            // 
            // chkBit8
            // 
            this.chkBit8.AutoSize = true;
            this.chkBit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit8.Location = new System.Drawing.Point(306, 360);
            this.chkBit8.Name = "chkBit8";
            this.chkBit8.Size = new System.Drawing.Size(60, 24);
            this.chkBit8.TabIndex = 28;
            this.chkBit8.Text = "Bit 8";
            this.chkBit8.UseVisualStyleBackColor = true;
            this.chkBit8.Click += new System.EventHandler(this.clickou_em_chkbit8);
            // 
            // chkBit5
            // 
            this.chkBit5.AutoSize = true;
            this.chkBit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit5.Location = new System.Drawing.Point(306, 270);
            this.chkBit5.Name = "chkBit5";
            this.chkBit5.Size = new System.Drawing.Size(60, 24);
            this.chkBit5.TabIndex = 27;
            this.chkBit5.Text = "Bit 5";
            this.chkBit5.UseVisualStyleBackColor = true;
            this.chkBit5.Click += new System.EventHandler(this.clickou_em_chkbit5);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 438);
            this.Controls.Add(this.chkBit6);
            this.Controls.Add(this.chkBit7);
            this.Controls.Add(this.chkBit8);
            this.Controls.Add(this.chkBit5);
            this.Controls.Add(this.chkBit2);
            this.Controls.Add(this.chkBit3);
            this.Controls.Add(this.chkBit4);
            this.Controls.Add(this.chkBit1);
            this.Controls.Add(this.lblHexadecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.lblInformeUmNumero);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.lblBase16);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase10);
            this.Controls.Add(this.btnSET);
            this.Controls.Add(this.txtNumero);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnSET;
        private System.Windows.Forms.Label lblBase10;
        private System.Windows.Forms.Label lblBase2;
        private System.Windows.Forms.Label lblBase16;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.Label lblInformeUmNumero;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblHexadecimal;
        private System.Windows.Forms.CheckBox chkBit1;
        private System.Windows.Forms.CheckBox chkBit4;
        private System.Windows.Forms.CheckBox chkBit3;
        private System.Windows.Forms.CheckBox chkBit2;
        private System.Windows.Forms.CheckBox chkBit6;
        private System.Windows.Forms.CheckBox chkBit7;
        private System.Windows.Forms.CheckBox chkBit8;
        private System.Windows.Forms.CheckBox chkBit5;
    }
}

