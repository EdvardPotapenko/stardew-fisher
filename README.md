# Stardew Fisher
Get max throw distance while fishing in stardew easily

# Prerequisites
* For versions greater than or equal to 3.0 - Windows 10 or later version are supported
* [For versions greater than or equal to 3.0 - [.NET Core 6]](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) 
* [For version lower than 3.0 - .NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) 

# Troubleshooting
If app won't start with version lower than 3.0 - try running compitability wizard by right clicking .exe file and opening properties.

If you get error message on app start which asks you to delete SavedHotkeys.json file - it may fix problem, but your saved hotkeys will be lost.
* *You shouldn't usually see this error message*

# How To Use

1. Open .exe file to start app
2. Now you have option to set your own time of throw in millis and hotkeys or use default values.
3. Default throw time is 1000 millis or 1 second and default hotkey to use app is ```Ctrl + Alt + F```
4. To set your own time use input box (available range is 100-2000 millis). Use arrow buttons to the right of input or input them via keyboard yourself.
5. To set your own hotkeys select empty input box next to how-to text and start pressing your key combination one by one; **first enter command keys (e.g. ctrl, alt, shift)**; Then press your desired key to save hotkey (A-Z or other keys)
6. Your hotkeys will be saved to SavedHotkeys.json file and loaded on next app start.
7. To use app - open up Stardew Valley, take fishing rod and press default (```Ctrl + Alt + F```) or one of your own key combinations.


Credit for global hotkey code for [aaronls](https://stackoverflow.com/users/84206/aaronls)

[Original StackOverflow thread](https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp)

