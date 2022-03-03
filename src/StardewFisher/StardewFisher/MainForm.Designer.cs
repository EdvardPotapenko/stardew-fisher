using System.Windows.Forms;

namespace StardewFisher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_help = new System.Windows.Forms.Label();
            this.txt_throw_time = new System.Windows.Forms.Label();
            this.notify_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctx_strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txt_hotkey = new System.Windows.Forms.TextBox();
            this.lbl_default = new System.Windows.Forms.Label();
            this.input_time_throw = new System.Windows.Forms.NumericUpDown();
            this.lbl_help_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_help_3 = new System.Windows.Forms.Label();
            this.ctx_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_time_throw)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_help.ForeColor = System.Drawing.Color.White;
            this.lbl_help.Location = new System.Drawing.Point(8, 41);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(221, 23);
            this.lbl_help.TabIndex = 1;
            this.lbl_help.Text = "To set your custom hotkeys:";
            // 
            // txt_throw_time
            // 
            this.txt_throw_time.AutoSize = true;
            this.txt_throw_time.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_throw_time.ForeColor = System.Drawing.Color.White;
            this.txt_throw_time.Location = new System.Drawing.Point(8, 13);
            this.txt_throw_time.Name = "txt_throw_time";
            this.txt_throw_time.Size = new System.Drawing.Size(395, 23);
            this.txt_throw_time.TabIndex = 3;
            this.txt_throw_time.Text = "Throw time in millis (default 1000, range 100-2000)";
            // 
            // notify_icon
            // 
            this.notify_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify_icon.BalloonTipText = "I\'m here bro";
            this.notify_icon.BalloonTipTitle = "Minimez to tray";
            this.notify_icon.ContextMenuStrip = this.ctx_strip;
            this.notify_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("notify_icon.Icon")));
            this.notify_icon.Text = "Stardew Clicker";
            this.notify_icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_icon_MouseDoubleClick);
            // 
            // ctx_strip
            // 
            this.ctx_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ctx_strip.Name = "ctx_strip";
            this.ctx_strip.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(460, 154);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(89, 17);
            this.lbl_author.TabIndex = 5;
            this.lbl_author.Text = "by h0pele$0ul";
            // 
            // txt_hotkey
            // 
            this.txt_hotkey.Location = new System.Drawing.Point(375, 66);
            this.txt_hotkey.Name = "txt_hotkey";
            this.txt_hotkey.ReadOnly = true;
            this.txt_hotkey.Size = new System.Drawing.Size(174, 22);
            this.txt_hotkey.TabIndex = 7;
            this.txt_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_hotkey_keydown);
            // 
            // lbl_default
            // 
            this.lbl_default.AutoSize = true;
            this.lbl_default.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_default.ForeColor = System.Drawing.Color.White;
            this.lbl_default.Location = new System.Drawing.Point(372, 92);
            this.lbl_default.Name = "lbl_default";
            this.lbl_default.Size = new System.Drawing.Size(183, 17);
            this.lbl_default.TabIndex = 8;
            this.lbl_default.Text = "Default hotkey is Ctrl + Alt + F";
            // 
            // input_time_throw
            // 
            this.input_time_throw.Location = new System.Drawing.Point(409, 16);
            this.input_time_throw.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.input_time_throw.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.input_time_throw.Name = "input_time_throw";
            this.input_time_throw.Size = new System.Drawing.Size(140, 22);
            this.input_time_throw.TabIndex = 9;
            this.input_time_throw.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.input_time_throw.ValueChanged += new System.EventHandler(this.input_time_throw_ValueChanged);
            // 
            // lbl_help_1
            // 
            this.lbl_help_1.AutoSize = true;
            this.lbl_help_1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_help_1.ForeColor = System.Drawing.Color.White;
            this.lbl_help_1.Location = new System.Drawing.Point(8, 64);
            this.lbl_help_1.Name = "lbl_help_1";
            this.lbl_help_1.Size = new System.Drawing.Size(185, 23);
            this.lbl_help_1.TabIndex = 10;
            this.lbl_help_1.Text = "1. Select input text box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "2. Press (ctrl or alt or shift) keys one by one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "3. Press non modifier key to set your hotkey";
            // 
            // lbl_help_3
            // 
            this.lbl_help_3.AutoSize = true;
            this.lbl_help_3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_help_3.ForeColor = System.Drawing.Color.White;
            this.lbl_help_3.Location = new System.Drawing.Point(8, 133);
            this.lbl_help_3.Name = "lbl_help_3";
            this.lbl_help_3.Size = new System.Drawing.Size(271, 23);
            this.lbl_help_3.TabIndex = 13;
            this.lbl_help_3.Text = "Example: Press Ctrl then Alt then t";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(582, 193);
            this.Controls.Add(this.lbl_help_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_help_1);
            this.Controls.Add(this.input_time_throw);
            this.Controls.Add(this.lbl_default);
            this.Controls.Add(this.txt_hotkey);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.txt_throw_time);
            this.Controls.Add(this.lbl_help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 240);
            this.MinimumSize = new System.Drawing.Size(600, 240);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stardew Fisher";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ctx_strip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input_time_throw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_help;
        private Label txt_throw_time;
        private NotifyIcon notify_icon;
        private ContextMenuStrip ctx_strip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lbl_author;
        private TextBox txt_hotkey;
        private Label lbl_default;
        private NumericUpDown input_time_throw;
        private Label lbl_help_1;
        private Label label1;
        private Label label2;
        private Label lbl_help_3;
    }
}