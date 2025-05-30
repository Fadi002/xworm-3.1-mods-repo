using MetroFramework;
using MetroFramework.Components;

namespace downloader
{
    partial class Downloader
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
            this.components = new System.ComponentModel.Container();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.buildbtn = new MetroFramework.Controls.MetroButton();
            this.stubs = new MetroFramework.Controls.MetroComboBox();
            this.link = new MetroFramework.Controls.MetroTextBox();
            this.payloadlink = new MetroFramework.Controls.MetroLabel();
            this.Payloadstub = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Owner = this;
            this.styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            this.styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buildbtn
            // 
            this.buildbtn.Location = new System.Drawing.Point(312, 128);
            this.buildbtn.Name = "buildbtn";
            this.buildbtn.Size = new System.Drawing.Size(75, 23);
            this.buildbtn.TabIndex = 0;
            this.buildbtn.Text = "Build";
            this.buildbtn.Click += new System.EventHandler(this.buildbtn_Click);
            // 
            // stubs
            // 
            this.stubs.FormattingEnabled = true;
            this.stubs.ItemHeight = 23;
            this.stubs.Items.AddRange(new object[] {
            ".exe",
            ".vbs",
            ".ps1",
            ".bat",
            ".js"});
            this.stubs.Location = new System.Drawing.Point(110, 122);
            this.stubs.Name = "stubs";
            this.stubs.Size = new System.Drawing.Size(121, 29);
            this.stubs.TabIndex = 1;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(110, 93);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(277, 23);
            this.link.TabIndex = 2;
            // 
            // payloadlink
            // 
            this.payloadlink.AutoSize = true;
            this.payloadlink.Location = new System.Drawing.Point(23, 93);
            this.payloadlink.Name = "payloadlink";
            this.payloadlink.Size = new System.Drawing.Size(81, 19);
            this.payloadlink.TabIndex = 3;
            this.payloadlink.Text = "Payload link:";
            // 
            // Payloadstub
            // 
            this.Payloadstub.AutoSize = true;
            this.Payloadstub.Location = new System.Drawing.Point(66, 128);
            this.Payloadstub.Name = "Payloadstub";
            this.Payloadstub.Size = new System.Drawing.Size(38, 19);
            this.Payloadstub.TabIndex = 4;
            this.Payloadstub.Text = "Stub:";
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 184);
            this.Controls.Add(this.Payloadstub);
            this.Controls.Add(this.payloadlink);
            this.Controls.Add(this.link);
            this.Controls.Add(this.stubs);
            this.Controls.Add(this.buildbtn);
            this.Name = "Downloader";
            this.Resizable = false;
            this.Text = "Downloader";
            this.Load += new System.EventHandler(this.Downloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton buildbtn;
        private MetroFramework.Controls.MetroComboBox stubs;
        private MetroFramework.Controls.MetroTextBox link;
        private MetroFramework.Controls.MetroLabel payloadlink;
        private MetroFramework.Controls.MetroLabel Payloadstub;
        private MetroStyleManager styleManager;
    }
}