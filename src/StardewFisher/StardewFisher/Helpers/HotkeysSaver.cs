using System.Text.Json;
using System.Text.Json.Serialization;
using StardewFisher.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StardewFisher.Helpers
{
    /// <summary>
    /// serializes and deserializes saved hotkeys into and from json files
    /// </summary>
    internal static class HotkeysSaver
    {
        private static readonly string _filename = "SavedHotkeys.json";


        /// <summary>
        /// Saves hotkey to file
        /// </summary>
        /// <param name="dataToSave">hotkey</param>
        /// <exception cref="ArgumentException">when hotkey is already present in file</exception>
        public static void SaveHotkeys(SaveDataDTO dataToSave)
        {
            string jsonToSave;

            if (File.Exists(_filename))
            {
                //write string to file
                var savedData = JsonSerializer.Deserialize<List<SaveDataDTO>>(File.ReadAllText(_filename));

                if (savedData.Any(h => h.Id == dataToSave.Id))
                    throw new ArgumentException("This hotkey has been already saved");

                savedData.Add(dataToSave);

                jsonToSave = JsonSerializer.Serialize(savedData);
                File.WriteAllText(_filename, jsonToSave);
                return;
            }

            jsonToSave = JsonSerializer.Serialize(new List<SaveDataDTO>(){ dataToSave});
            File.WriteAllText(_filename, jsonToSave);

        }

        /// <summary>
        /// reads saved hotkeys from file
        /// </summary>
        /// <returns>list of saved hotkeys or null if file is not present</returns>
        public static List<SaveDataDTO>? LoadSavedHotkeys()
        {
            if (File.Exists(_filename))
            {
                //write string to file
                var savedData = JsonSerializer.Deserialize<List<SaveDataDTO>>(File.ReadAllText(_filename));

                return savedData;
            }

            return null;
        }
    }
}
