using StardewFisher.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewFisher.DTO
{
    internal class SaveDataDTO
    {
        // used to comparing hotkeys when saving
        public string Id { get; set; } // "Ctrl Alt F"

        public List<ModifierKeys> ModifierKeys { get; set; } = new List<ModifierKeys>();
        public Keys Key { get; set; } = default;

        /// <summary>
        /// generates id string like "Ctrl Alt F" and fills Id property
        /// </summary>
        public void GenerateId()
        {
            string id = "";

            foreach(var modifier in this.ModifierKeys)
            {
                id = id.Trim() + $" {modifier.ToString()} ";
            }

            id = id.Trim() + $" {this.Key.ToString()}";

            this.Id = id;
        }
    }
}
