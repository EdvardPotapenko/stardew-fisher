using StardewFisher.DTO;
using StardewFisher.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewFisher
{
    public partial class MainForm : Form
    {

        private SaveDataDTO _saveData = new SaveDataDTO();

        private int _sleepTime = 1000;

        KeyboardHook hook = new KeyboardHook();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public MainForm()
        {
            InitializeComponent();

            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);

            // register default hotkey
            hook.RegisterHotKey(StardewFisher.Helpers.ModifierKeys.Control | StardewFisher.Helpers.ModifierKeys.Alt, Keys.F);

            try
            {
                this.RegisterSavedHotkeys();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Something went wrong, try deleting SavedHotkeys.json file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
        }

        /// <summary>
        /// reads all saved hotkeys from file and registers them into hook
        /// </summary>
        private void RegisterSavedHotkeys()
        {
            var hotkeys = HotkeysSaver.LoadSavedHotkeys();

            if (hotkeys == null) // means file is not present
                return;

            foreach (var hotkey in hotkeys)
            {
                this.RegisterHotkey(hotkey);
            }

        }

        
        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;

            // run fire and forget task to hold LMB for _sleepTime then release
            Task.Run(() =>
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);

                Thread.Sleep(_sleepTime);

                mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            }).ConfigureAwait(false); // so thread won't be blocked

        }

        // move app into tray on minimize
        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notify_icon.Visible = true;
                notify_icon.ShowBalloonTip(1000);
            }
        }

        // bring back app from tray
        private void notify_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notify_icon.Visible = false;
        }

        // exit for tray icon
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// registers and saves keys entered in hotkey textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_hotkey_keydown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.Alt)
            {
                if (_saveData.ModifierKeys.Count <= 3)
                {
                    if (!_saveData.ModifierKeys.Any(k => k == Helpers.ModifierKeys.Alt))
                    {
                        _saveData.ModifierKeys.Add(Helpers.ModifierKeys.Alt);
                        txt_hotkey.Text = txt_hotkey.Text.Trim() + " Alt ";
                    }
                    return;
                }
                _saveData.ModifierKeys = new List<ModifierKeys>();
                MessageBox.Show("Only 3 modifier keys allowed (shift, ctrl, alt)");
                txt_hotkey.Text = "";
                return;
            }

            if (e.Control)
            {
                if (_saveData.ModifierKeys.Count <= 3)
                {
                    if (!_saveData.ModifierKeys.Any(k => k == Helpers.ModifierKeys.Control))
                    {
                        _saveData.ModifierKeys.Add(Helpers.ModifierKeys.Control);
                        txt_hotkey.Text = txt_hotkey.Text.Trim() + " Ctrl ";
                    }
                    return;
                }
                _saveData.ModifierKeys = new List<ModifierKeys>();
                MessageBox.Show("Only 3 modifier keys allowed (shift, ctrl, alt)");
                txt_hotkey.Text = "";
                return;
            }

            if (e.Shift)
            {
                if (_saveData.ModifierKeys.Count <= 3)
                {
                    if (!_saveData.ModifierKeys.Any(k => k == Helpers.ModifierKeys.Shift))
                    {
                        _saveData.ModifierKeys.Add(Helpers.ModifierKeys.Shift);
                        txt_hotkey.Text = txt_hotkey.Text.Trim() + " Shift ";
                    }
                    return;
                }
                _saveData.ModifierKeys = new List<ModifierKeys>();
                MessageBox.Show("Only 3 modifier keys allowed (shift, ctrl, alt)");
                txt_hotkey.Text = "";
                return;
            }

            if (_saveData.Key == default && _saveData.ModifierKeys.Count != 0)
            {
                _saveData.Key = e.KeyCode;
                txt_hotkey.Text = txt_hotkey.Text.Trim() + $" {e.KeyCode.ToString()} ";

                try
                {
                    RegisterHotkey(_saveData);
                    _saveData.GenerateId();
                    HotkeysSaver.SaveHotkeys(_saveData);
                }
                catch (ArgumentException)
                {
                    txt_hotkey.Text = "";
                    _saveData.ModifierKeys = new List<ModifierKeys>();
                    _saveData.Key = default;
                    MessageBox.Show("Same hotkey already saved bro");
                    return;
                }
                catch (InvalidOperationException)
                {
                    txt_hotkey.Text = "";
                    _saveData.ModifierKeys = new List<ModifierKeys>();
                    _saveData.Key = default;
                    MessageBox.Show("Same hotkey already saved bro");
                    return;
                }

                txt_hotkey.Text = "";
                _saveData.ModifierKeys = new List<ModifierKeys>();
                _saveData.Key = default;
                MessageBox.Show("Your hotkey is saved");

                return;
            }

            MessageBox.Show("You must use at least one modifier key (ctrl, shift or alt)");
            txt_hotkey.Text = "";
            _saveData.ModifierKeys = new List<ModifierKeys>();
            _saveData.Key = default;
            txt_hotkey.Text = "";

        }

        /// <summary>
        /// registers hotkey in hook
        /// </summary>
        /// <param name="hotkeyToRegister">hotkey to register</param>
        private void RegisterHotkey(SaveDataDTO hotkeyToRegister)
        {
            switch (hotkeyToRegister.ModifierKeys.Count())
            {
                default:
                    {
                        break;
                    }
                case 1:
                    {
                        hook.RegisterHotKey(hotkeyToRegister.ModifierKeys[0], hotkeyToRegister.Key);
                        break;
                    }
                case 2:
                    {
                        hook.RegisterHotKey(hotkeyToRegister.ModifierKeys[0] | hotkeyToRegister.ModifierKeys[1], hotkeyToRegister.Key);
                        break;
                    }
                case 3:
                    {
                        hook.RegisterHotKey(hotkeyToRegister.ModifierKeys[0] | hotkeyToRegister.ModifierKeys[1] | hotkeyToRegister.ModifierKeys[2], hotkeyToRegister.Key);
                        break;
                    }
            }
        }

        // saves value from numeric updown to variable, so it can be accessed from different thread while
        // while executing fire and forget task (see mouse hook event handler)
        private void input_time_throw_ValueChanged(object sender, EventArgs e)
        {
            _sleepTime = (int)input_time_throw.Value;
        }
    }
}