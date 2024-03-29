﻿namespace serialConnection
{
    partial class home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdExitApp = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmdReceive = new System.Windows.Forms.Button();
            this.gboValues = new System.Windows.Forms.GroupBox();
            this.txtSerialValue = new System.Windows.Forms.TextBox();
            this.gboValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(540, 72);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(155, 85);
            this.cmdOpen.TabIndex = 0;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(540, 198);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(155, 85);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdExitApp
            // 
            this.cmdExitApp.Location = new System.Drawing.Point(540, 318);
            this.cmdExitApp.Name = "cmdExitApp";
            this.cmdExitApp.Size = new System.Drawing.Size(155, 85);
            this.cmdExitApp.TabIndex = 2;
            this.cmdExitApp.Text = "Exit";
            this.cmdExitApp.UseVisualStyleBackColor = true;
            this.cmdExitApp.Click += new System.EventHandler(this.cmdExitApp_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(96, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "---";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(101, 225);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 33);
            this.cboPorts.TabIndex = 4;
            // 
            // cmdReceive
            // 
            this.cmdReceive.Location = new System.Drawing.Point(319, 20);
            this.cmdReceive.Name = "cmdReceive";
            this.cmdReceive.Size = new System.Drawing.Size(155, 85);
            this.cmdReceive.TabIndex = 5;
            this.cmdReceive.Text = "Request Data";
            this.cmdReceive.UseVisualStyleBackColor = true;
            this.cmdReceive.Click += new System.EventHandler(this.cmdReceive_Click);
            // 
            // gboValues
            // 
            this.gboValues.Controls.Add(this.txtSerialValue);
            this.gboValues.Controls.Add(this.cmdReceive);
            this.gboValues.Location = new System.Drawing.Point(56, 416);
            this.gboValues.Name = "gboValues";
            this.gboValues.Size = new System.Drawing.Size(480, 317);
            this.gboValues.TabIndex = 6;
            this.gboValues.TabStop = false;
            // 
            // txtSerialValue
            // 
            this.txtSerialValue.Location = new System.Drawing.Point(45, 168);
            this.txtSerialValue.Name = "txtSerialValue";
            this.txtSerialValue.Size = new System.Drawing.Size(100, 31);
            this.txtSerialValue.TabIndex = 6;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1306, 805);
            this.Controls.Add(this.gboValues);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdExitApp);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOpen);
            this.Name = "home";
            this.Text = "Serielle Schnittstelle";
            this.gboValues.ResumeLayout(false);
            this.gboValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdExitApp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button cmdReceive;
        private System.Windows.Forms.GroupBox gboValues;
        private System.Windows.Forms.TextBox txtSerialValue;
    }
}

