namespace TestSerialCom
{
    partial class InitSignalCalc
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
            this.FLSCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frameCreate = new System.Windows.Forms.TextBox();
            this.creatFrame = new System.Windows.Forms.Button();
            this.copyFrame = new System.Windows.Forms.Button();
            this.initOrReceive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FLSCode
            // 
            this.FLSCode.Location = new System.Drawing.Point(168, 19);
            this.FLSCode.Name = "FLSCode";
            this.FLSCode.Size = new System.Drawing.Size(102, 23);
            this.FLSCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code FLS du signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trame générée";
            // 
            // frameCreate
            // 
            this.frameCreate.Enabled = false;
            this.frameCreate.Location = new System.Drawing.Point(9, 202);
            this.frameCreate.Name = "frameCreate";
            this.frameCreate.Size = new System.Drawing.Size(180, 23);
            this.frameCreate.TabIndex = 3;
            // 
            // creatFrame
            // 
            this.creatFrame.Location = new System.Drawing.Point(95, 103);
            this.creatFrame.Name = "creatFrame";
            this.creatFrame.Size = new System.Drawing.Size(75, 23);
            this.creatFrame.TabIndex = 4;
            this.creatFrame.Text = "Génerer";
            this.creatFrame.UseVisualStyleBackColor = true;
            this.creatFrame.Click += new System.EventHandler(this.creatFrame_Click);
            // 
            // copyFrame
            // 
            this.copyFrame.Location = new System.Drawing.Point(195, 202);
            this.copyFrame.Name = "copyFrame";
            this.copyFrame.Size = new System.Drawing.Size(75, 23);
            this.copyFrame.TabIndex = 5;
            this.copyFrame.Text = "copy";
            this.copyFrame.UseVisualStyleBackColor = true;
            this.copyFrame.Click += new System.EventHandler(this.copyFrame_Click);
            // 
            // initOrReceive
            // 
            this.initOrReceive.AutoSize = true;
            this.initOrReceive.Location = new System.Drawing.Point(12, 66);
            this.initOrReceive.Name = "initOrReceive";
            this.initOrReceive.Size = new System.Drawing.Size(109, 19);
            this.initOrReceive.TabIndex = 6;
            this.initOrReceive.Text = "Trame de retour";
            this.initOrReceive.UseVisualStyleBackColor = true;
            // 
            // InitSignalCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.initOrReceive);
            this.Controls.Add(this.copyFrame);
            this.Controls.Add(this.creatFrame);
            this.Controls.Add(this.frameCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLSCode);
            this.Name = "InitSignalCalc";
            this.ShowIcon = false;
            this.Text = "Init Signal Led";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FLSCode;
        private Label label1;
        private Label label2;
        private TextBox frameCreate;
        private Button creatFrame;
        private Button copyFrame;
        private CheckBox initOrReceive;
    }
}