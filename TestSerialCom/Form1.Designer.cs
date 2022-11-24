namespace TestSerialCom
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
            this.COMPortList = new System.Windows.Forms.ComboBox();
            this.COMPortOpen = new System.Windows.Forms.Button();
            this.COMPortClose = new System.Windows.Forms.Button();
            this.FramesSendBtn = new System.Windows.Forms.Button();
            this.FramesSend = new System.Windows.Forms.TextBox();
            this.FramesReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // COMPortList
            // 
            this.COMPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortList.FormattingEnabled = true;
            this.COMPortList.Location = new System.Drawing.Point(61, 26);
            this.COMPortList.Name = "COMPortList";
            this.COMPortList.Size = new System.Drawing.Size(182, 23);
            this.COMPortList.TabIndex = 0;
            // 
            // COMPortOpen
            // 
            this.COMPortOpen.Location = new System.Drawing.Point(261, 26);
            this.COMPortOpen.Name = "COMPortOpen";
            this.COMPortOpen.Size = new System.Drawing.Size(75, 23);
            this.COMPortOpen.TabIndex = 1;
            this.COMPortOpen.Text = "Open";
            this.COMPortOpen.UseVisualStyleBackColor = true;
            this.COMPortOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // COMPortClose
            // 
            this.COMPortClose.Location = new System.Drawing.Point(353, 26);
            this.COMPortClose.Name = "COMPortClose";
            this.COMPortClose.Size = new System.Drawing.Size(75, 23);
            this.COMPortClose.TabIndex = 2;
            this.COMPortClose.Text = "Close";
            this.COMPortClose.UseVisualStyleBackColor = true;
            this.COMPortClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FramesSendBtn
            // 
            this.FramesSendBtn.Location = new System.Drawing.Point(622, 208);
            this.FramesSendBtn.Name = "FramesSendBtn";
            this.FramesSendBtn.Size = new System.Drawing.Size(75, 23);
            this.FramesSendBtn.TabIndex = 3;
            this.FramesSendBtn.Text = "Send";
            this.FramesSendBtn.UseVisualStyleBackColor = true;
            this.FramesSendBtn.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FramesSend
            // 
            this.FramesSend.Location = new System.Drawing.Point(61, 72);
            this.FramesSend.Multiline = true;
            this.FramesSend.Name = "FramesSend";
            this.FramesSend.Size = new System.Drawing.Size(636, 130);
            this.FramesSend.TabIndex = 5;
            // 
            // FramesReceive
            // 
            this.FramesReceive.Location = new System.Drawing.Point(61, 237);
            this.FramesReceive.Multiline = true;
            this.FramesReceive.Name = "FramesReceive";
            this.FramesReceive.Size = new System.Drawing.Size(636, 130);
            this.FramesReceive.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FramesReceive);
            this.Controls.Add(this.FramesSend);
            this.Controls.Add(this.FramesSendBtn);
            this.Controls.Add(this.COMPortClose);
            this.Controls.Add(this.COMPortOpen);
            this.Controls.Add(this.COMPortList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox COMPortList;
        private Button COMPortOpen;
        private Button COMPortClose;
        private Button FramesSendBtn;
        private TextBox FramesSend;
        private TextBox FramesReceive;
    }
}