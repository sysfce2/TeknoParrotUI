using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using TeknoParrotUi.Common;

namespace TeknoParrotUi.Helpers
{
    public static class GameErrorMessage
    {
        public static async Task ShowGameError(int errorCode)
        {
            switch (errorCode)
            {
                case 1337:
                    await MessageBoxHelper.ErrorOK("Unsupported CRC, please use a supported version of the game.");
                    break;
                case 76501:
                    await MessageBoxHelper.ErrorOK("This version of EXVS2 Xboost cannot be played. Please use Version 27 aka Final");
                    break;
                case 76502:
                    await MessageBoxHelper.ErrorOK("SFV 3.53 requires the games Patch folder to exist, either next to the \"game\" folder if you kept the original folder structure\n, or next to the Exe in WindowsNoEditor\\StreetFighterV\\Binaries\\Win64.\nIt should contain a bunch of patch pak files.");
                    break;
                case 76503:
                    await MessageBoxHelper.ErrorOK("Your ServerBoxD8_Nu_x64.exe is still encrypted. Please use a fully decrypted dump as the game won't work correctly without it.");
                    break;
                case 3820:
                    await MessageBoxHelper.ErrorOK("Score Submission - You are banned from making submissions!");
                    break;
                case 3821:
                    await MessageBoxHelper.ErrorOK("Score Submission - Detected old version, please update to latest version!");
                    break;
                case 3822:
                    await MessageBoxHelper.ErrorOK("Score Submission - Serial is invalid, please add a valid serial!");
                    break;
                case 3823:
                    await MessageBoxHelper.ErrorOK("Score Submission - Check ScoreSubmissionLog.txt in game folder for Audio Devices!");
                    break;
                case 2820:
                    await MessageBoxHelper.ErrorOK("You are using wrong exe on this game version! Please ensure you get correct executable file!");
                    break;
                case 2821:
                    await MessageBoxHelper.ErrorOK("openal32gsevo.dll not loaded from ElfLdr2\\libs folder!");
                    break;
                case 2822:
                    await MessageBoxHelper.ErrorOK("librnalindbergh_jr.so.1.46 not loaded from disk1\\vsg_l folder!");
                    break;
                case 2823:
                    await MessageBoxHelper.ErrorOK("libopenal.so.0.0.0 not loaded from disk1\\drv\\openal\\0.0.8-1.0.1\\lib folder!");
                    break;
                case 0xB0B0001:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\n./bin\n./bin/bms_GDK.exe\n......\n\nNow closing...");
                    break;
                case 0xB0B0002:
                    await MessageBoxHelper.ErrorOK("GAME REVISION not supported!!!\n\nNow closing.");
                    break;
                case 0xB0B0003:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\ndk2win32.dll\n......\n\nNow closing...");
                    break;
                case 0xB0B0004:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\ninpout32.dll\n......\n\nNow closing...");
                    break;
                case 0xB0B0005:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\n./bin\n./bin/bms_IG2.exe\n......\n\nNow closing...");
                    break;
                case 0xB0B0006:
                    await MessageBoxHelper.ErrorOK("The screen used is not compatible with this setting.\n\nPlease run the game in windowed mode.\n\nNow closing...");
                    break;
                case 0xB0B0007:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\nd3dx8.dll\nPlease copy the file or disable custom crosshairs.\n\nNow closing...");
                    break;
                case 0xB0B0008:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\n./bin\n./bin/bms_IMS.exe\n......\n\nNow closing...");
                    break;
                case 0xB0B0009:
                    await MessageBoxHelper.ErrorOK("Main game executable file need to be patched with 4GB PATCHER on x64 OS, check: \n\n- fixes-channel on TeknoParrot Discord\n or\n- https:////ntcore.com//?page_id=371 \n\n Now closing...");
                    break;
                case 0xB0B000A:
                    await MessageBoxHelper.ErrorOK("This game need to be run in XP compatibility mode to avoid freezes/crashes:\nPlease change \"game.exe\" Compatibility Mode setting to \"Windows XP\" and relaunch game.\n......\n\nNow closing...");
                    break;
                case 0xB0B000B:
                    await MessageBoxHelper.ErrorOK("This game need to be patched to remove all trash:\nPlease patch \"game.exe\" with TrashCleaner for BlockKing (download from fixes-channel on TeknoParrot Discord).\n Once done relaunch game.\n......\n\nNow closing...");
                    break;
                case 0xB0B000C:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\nd3dx11_43.dll (64-bit)\nPlease copy the file or disable custom bezel.\n\nNow closing...");
                    break;
                case 0xB0B000D:
                    await MessageBoxHelper.ErrorOK("This game need these files in game root:\nd3dx8.dll\nPlease copy the file or disable Landscape screen orientation.\n\nNow closing...");
                    break;
                case 0xB0B000E:
                    await MessageBoxHelper.ErrorOK("This game need this file in game root:\nglide3x.dll\nAvailable from #Fixes channel on TP-Discord or from nGlide v2.10\n......\n\nNow closing...");
                    break;
                case 0xB0B000F:
                    await MessageBoxHelper.ErrorOK("This game need this file in game root:\nglide2x.dll\nAvailable from #Fixes channel on TP-Discord or from nGlide v2.10\n......\n\nNow closing...");
                    break;
                case 0xB0B0010:
                    await MessageBoxHelper.ErrorOK("GAME PATH CHECK FAILED!...\nThis game need all his files to be in a \"pm\" directory.\n\nPlease move every files inside your game/dump folder to the newly created \"pm\" directory inside it.\nThen please re-set the path to the game elf in TeknoparrotUI settings before restarting the game.\n\nNow closing...");
                    break;
                case 0xB0B0011:
                    await MessageBoxHelper.ErrorOK("Missing Files detected. Please extract and place the \"programs_dec\" folder next to the game elf otherwise the game will not function properly. Now closing...");
                    break;
                case 0xB0B0012:
                    await MessageBoxHelper.ErrorOK("Missing Files detected. Please extract and place the \"hasp\" folder next to the game elf otherwise the game will not function properly. Now closing...");
                    break;
                case 0xB0B0013:
                    await MessageBoxHelper.ErrorOK("Missing Files detected. Please extract and place the \"TPVirtualCards.dll\" file next to the game exe to enable Virtual Cards interface.\nAvailable from #Fixes channel on TP-Discord.\n Now closing...");
                    break;
                case 0xB0B0020:
                    await MessageBoxHelper.ErrorOK("This game need these file in game root:\nSDL2.dll\n\nPlease come to #Fixes channel on TP-Discord.\n......\n\nNow closing...");
                    break;
                case 0xB0B0021:
                    await MessageBoxHelper.ErrorOK("This game need these file in game root:\nzlib1.dll (v1.2.3)\nlibeay32.dll (v1.0.0.e)\nssleay32.dll (v1.0.0.e)\n\nPlease come to #Fixes channel on TP-Discord.\n......\n\nNow closing...");
                    break;
                case 0xB0B0022:
                    await MessageBoxHelper.ErrorOK("This game need these file in game root:\nalleg40.dll (Allegro API v4.0.X)\n\nPlease come to #Fixes channel on TP-Discord.\n......\n\nNow closing...");
                    break;
                case 0xB0B0023:
                    await MessageBoxHelper.ErrorOK("Could not find the postgres dlls. Make sure you have set the right path to the postgres/bin folder, or alternatively copied the dlls into the Elfldr2/libs folder.\nIf you need help, feel free to ask in the #goldentee channel on discord.");
                    break;
                case 0xB0B0024:
                    await MessageBoxHelper.ErrorOK("Please delete the directx dlls (d3d8.dll, d3d8thk.dll, etc) from the game directory!");
                    break;
                case 0xB0B0025:
                    await MessageBoxHelper.ErrorOK("This game need files from \"Ripax' Tsunami launcher\" in a folder named \"Tsunami\" in game root......\n\nNow closing...");
                    break;
                case 0xB0B0026:
                    await MessageBoxHelper.ErrorOK("Game loading failed while loading classes.\nPlease ensure you are running the game as Admin.\n\nPlease report any issue to TP-Discord.\nNow closing...");
                    break;
                case 0xB0B0027:
                    await MessageBoxHelper.ErrorOK("This game need \"ddraw.dll\" file wrapper in \"Tsunami\" folder to force custom resolution on current OS...\n\nPlease come to #Fixes channel on TP-Discord.\nNow closing...");
                    break;
                case 0xB0B0028:
                    await MessageBoxHelper.ErrorOK("This game need this file in game root:\n-glide2x.dll\n\nGrab it from #Fixes channel on TP-Discord or from nGlide v2.10.\nYou also need to remove any dgVoodoo wrapper files too.\nNow closing...");
                    break;
                case 0xB0B0029:
                    await MessageBoxHelper.ErrorOK("This game has an encrypted Unity launcher.\nPlease copy the \"Game.exe\" file from a compatible Unity/Adrenaline game:\n-Hot Wheels\n-Drakons Realm Keepers\n\nNow closing...");
                    break;
                case 0xB0B0030:
                    await MessageBoxHelper.ErrorOK("This game need \"BepInEx v5 x64\" installed in a folder named \"BepInEx\" in game root, and TP plugin dll in its plugins folder......\n\nNow closing...");
                    break;
                case 0xB0B0031:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"NHAD2TPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0032:
                    await MessageBoxHelper.ErrorOK("The HostIP value you set is too long. It should be 16 or less characters long. Quitting.");
                    break;
                case 0xD00D000:
                    await MessageBoxHelper.ErrorOK("This game requires the game data to be in a \"pinball\" subfolder.\n Please move the following folders into a new pinball subdirectory.\nattract, attractreplays, configuration, enterinitials, lasvegas, newyorkshop, op_adjust, playfield, savedgames, scripts, select, show and sound");
                    break;
                case 0xB0B0033:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"NFSHTTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0034:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"CCJTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0035:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"BSACTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0036:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"WWSTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0037:
                    await MessageBoxHelper.ErrorOK("This game need \"BepInEx v5 x86\" installed in a folder named \"BepInEx\" in game root, and TP plugin dll in its plugins folder......\n\nNow closing...");
                    break;
                case 0xB0B0038:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"BBGTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0039:
                    MessageBox.Show("This game need \"\\BepInEx\\plugins\\\" folder with \"MSTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xB0B0040:
                    await MessageBoxHelper.ErrorOK("This game need \"\\BepInEx\\plugins\\\" folder with \"FGBTPPlugin.dll\" TP plugin dll file in it.\nYou also need to remove any other conflicting plugin dll file from this \"\\BepInEx\\plugins\\\" folder.\nPlease visit TeknoParrot Discord #fixes channel to get TP plugin...");
                    break;
                case 0xAAA0000:
                    await MessageBoxHelper.ErrorOK("Could not connect to TPO2 lobby server. Quitting game...");
                    break;
                case 0xAAA0001:
                    await MessageBoxHelper.ErrorOK("You're using a version of the game that hasn't been whitelisted for TPO.\nTo ensure people don't experience crashes or glitches because of mismatchd, only the latest public version will work.");
                    break;
            }
        }
    }
}
