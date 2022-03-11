using System.Drawing;
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
            this.notify_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctx_strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_hotkey = new System.Windows.Forms.TextBox();
            this.input_time_throw = new System.Windows.Forms.NumericUpDown();
            this.lbl_throw_time = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_custom_hotkey = new MaterialSkin.Controls.MaterialLabel();
            this.card_throw_time = new MaterialSkin.Controls.MaterialCard();
            this.card_hotkeys = new MaterialSkin.Controls.MaterialCard();
            this.ctx_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_time_throw)).BeginInit();
            this.card_throw_time.SuspendLayout();
            this.card_hotkeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify_icon
            // 
            this.notify_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify_icon.BalloonTipText = "Ima head out to tray";
            this.notify_icon.BalloonTipTitle = "Minimized to tray";
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
            // txt_hotkey
            // 
            this.txt_hotkey.Location = new System.Drawing.Point(20, 56);
            this.txt_hotkey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hotkey.Name = "txt_hotkey";
            this.txt_hotkey.ReadOnly = true;
            this.txt_hotkey.Size = new System.Drawing.Size(174, 27);
            this.txt_hotkey.TabIndex = 7;
            this.txt_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_hotkey_keydown);
            // 
            // input_time_throw
            // 
            this.input_time_throw.Location = new System.Drawing.Point(20, 45);
            this.input_time_throw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.input_time_throw.Size = new System.Drawing.Size(140, 27);
            this.input_time_throw.TabIndex = 9;
            this.input_time_throw.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.input_time_throw.ValueChanged += new System.EventHandler(this.input_time_throw_ValueChanged);
            // 
            // lbl_throw_time
            // 
            this.lbl_throw_time.AutoSize = true;
            this.lbl_throw_time.Depth = 0;
            this.lbl_throw_time.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_throw_time.Location = new System.Drawing.Point(17, 18);
            this.lbl_throw_time.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_throw_time.Name = "lbl_throw_time";
            this.lbl_throw_time.Size = new System.Drawing.Size(489, 19);
            this.lbl_throw_time.TabIndex = 10;
            this.lbl_throw_time.Text = "To choose custom throw time use input below (default is 1000 millis)";
            // 
            // lbl_custom_hotkey
            // 
            this.lbl_custom_hotkey.AutoSize = true;
            this.lbl_custom_hotkey.Depth = 0;
            this.lbl_custom_hotkey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_custom_hotkey.Location = new System.Drawing.Point(17, 18);
            this.lbl_custom_hotkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_custom_hotkey.Name = "lbl_custom_hotkey";
            this.lbl_custom_hotkey.Size = new System.Drawing.Size(651, 19);
            this.lbl_custom_hotkey.TabIndex = 11;
            this.lbl_custom_hotkey.Text = "To choose custom hotkey select input box and press keys one by one (first ctrl or" +
    " alt or shift)";
            // 
            // card_throw_time
            // 
            this.card_throw_time.AutoSize = true;
            this.card_throw_time.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.card_throw_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_throw_time.Controls.Add(this.lbl_throw_time);
            this.card_throw_time.Controls.Add(this.input_time_throw);
            this.card_throw_time.Depth = 0;
            this.card_throw_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_throw_time.Location = new System.Drawing.Point(17, 98);
            this.card_throw_time.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.card_throw_time.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_throw_time.Name = "card_throw_time";
            this.card_throw_time.Padding = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.card_throw_time.Size = new System.Drawing.Size(523, 94);
            this.card_throw_time.TabIndex = 12;
            // 
            // card_hotkeys
            // 
            this.card_hotkeys.AutoSize = true;
            this.card_hotkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.card_hotkeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_hotkeys.Controls.Add(this.lbl_custom_hotkey);
            this.card_hotkeys.Controls.Add(this.txt_hotkey);
            this.card_hotkeys.Depth = 0;
            this.card_hotkeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_hotkeys.Location = new System.Drawing.Point(17, 208);
            this.card_hotkeys.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.card_hotkeys.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_hotkeys.Name = "card_hotkeys";
            this.card_hotkeys.Padding = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.card_hotkeys.Size = new System.Drawing.Size(685, 105);
            this.card_hotkeys.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 329);
            this.Controls.Add(this.card_hotkeys);
            this.Controls.Add(this.card_throw_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 329);
            this.MinimumSize = new System.Drawing.Size(750, 329);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stardew Fisher by h0pele$0ul";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ctx_strip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input_time_throw)).EndInit();
            this.card_throw_time.ResumeLayout(false);
            this.card_throw_time.PerformLayout();
            this.card_hotkeys.ResumeLayout(false);
            this.card_hotkeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NotifyIcon notify_icon;
        private ContextMenuStrip ctx_strip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox txt_hotkey;
        private NumericUpDown input_time_throw;
        private MaterialSkin.Controls.MaterialLabel lbl_throw_time;
        private MaterialSkin.Controls.MaterialLabel lbl_custom_hotkey;
        private MaterialSkin.Controls.MaterialCard card_throw_time;
        private MaterialSkin.Controls.MaterialCard card_hotkeys;
    }
}