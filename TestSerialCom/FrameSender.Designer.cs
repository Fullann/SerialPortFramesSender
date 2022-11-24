namespace TestSerialCom
{
    partial class SerialPortTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frameReceived = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frameInitGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPortList
            // 
            this.COMPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortList.FormattingEnabled = true;
            this.COMPortList.Location = new System.Drawing.Point(12, 40);
            this.COMPortList.Name = "COMPortList";
            this.COMPortList.Size = new System.Drawing.Size(182, 23);
            this.COMPortList.TabIndex = 0;
            // 
            // COMPortOpen
            // 
            this.COMPortOpen.Location = new System.Drawing.Point(217, 40);
            this.COMPortOpen.Name = "COMPortOpen";
            this.COMPortOpen.Size = new System.Drawing.Size(75, 23);
            this.COMPortOpen.TabIndex = 1;
            this.COMPortOpen.Text = "Open";
            this.COMPortOpen.UseVisualStyleBackColor = true;
            this.COMPortOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // COMPortClose
            // 
            this.COMPortClose.Location = new System.Drawing.Point(298, 40);
            this.COMPortClose.Name = "COMPortClose";
            this.COMPortClose.Size = new System.Drawing.Size(75, 23);
            this.COMPortClose.TabIndex = 2;
            this.COMPortClose.Text = "Close";
            this.COMPortClose.UseVisualStyleBackColor = true;
            this.COMPortClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FramesSendBtn
            // 
            this.FramesSendBtn.Location = new System.Drawing.Point(648, 124);
            this.FramesSendBtn.Name = "FramesSendBtn";
            this.FramesSendBtn.Size = new System.Drawing.Size(75, 23);
            this.FramesSendBtn.TabIndex = 3;
            this.FramesSendBtn.Text = "Send";
            this.FramesSendBtn.UseVisualStyleBackColor = true;
            this.FramesSendBtn.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FramesSend
            // 
            this.FramesSend.Location = new System.Drawing.Point(12, 124);
            this.FramesSend.Name = "FramesSend";
            this.FramesSend.Size = new System.Drawing.Size(630, 23);
            this.FramesSend.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frame to send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frame received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Communication port";
            // 
            // frameReceived
            // 
            this.frameReceived.FormattingEnabled = true;
            this.frameReceived.ItemHeight = 15;
            this.frameReceived.Location = new System.Drawing.Point(20, 197);
            this.frameReceived.Name = "frameReceived";
            this.frameReceived.Size = new System.Drawing.Size(703, 244);
            this.frameReceived.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frameInitGenerateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // frameInitGenerateToolStripMenuItem
            // 
            this.frameInitGenerateToolStripMenuItem.Name = "frameInitGenerateToolStripMenuItem";
            this.frameInitGenerateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frameInitGenerateToolStripMenuItem.Text = "Frame Init generate";
            this.frameInitGenerateToolStripMenuItem.Click += new System.EventHandler(this.frameInitGenerateToolStripMenuItem_Click);
            // 
            // SerialPortTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 456);
            this.Controls.Add(this.frameReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FramesSend);
            this.Controls.Add(this.FramesSendBtn);
            this.Controls.Add(this.COMPortClose);
            this.Controls.Add(this.COMPortOpen);
            this.Controls.Add(this.COMPortList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SerialPortTools";
            this.ShowIcon = false;
            this.Text = "Serial Port Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox COMPortList;
        private Button COMPortOpen;
        private Button COMPortClose;
        private Button FramesSendBtn;
        private TextBox FramesSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox frameReceived;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem frameInitGenerateToolStripMenuItem;
    }
}