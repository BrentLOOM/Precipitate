using UnityEngine;

namespace Crosstales.TPS
{
    /// <summary>Configuration for the asset.</summary>
    public static class Config
    {

        #region Changable variables

        /// <summary>Path to the asset inside the Unity project.</summary>
        public static string ASSET_PATH = "/crosstales/TPS/";

        /// <summary>Enable or disable custom location for the cache.</summary>
        public static bool CUSTOM_PATH_CACHE = Constants.DEFAULT_CUSTOM_PATH_CACHE;

        /// <summary>TPS-cache path.</summary>
        private static string pathCache = Constants.DEFAULT_PATH_CACHE;
        public static string PATH_CACHE
        {
            get { return CUSTOM_PATH_CACHE && !string.IsNullOrEmpty(pathCache) ? Helper.ValidatePath(pathCache) : Constants.DEFAULT_PATH_CACHE; }
            set { pathCache = value; }
        }

        /// <summary>Selected VCS-system (default: 0, 0 = none, 1 = git, 2 = SVN, 3 Mercurial).</summary>
        public static int VCS = Constants.DEFAULT_VCS;

        /// <summary>Execute static method <ClassName.MethodName> in Unity after a switch.</summary>
        public static string EXECUTE_METHOD = string.Empty;

        /// <summary>Enable or disable copying the 'ProjectSettings'-folder.</summary>
        public static bool COPY_SETTINGS = Constants.DEFAULT_COPY_SETTINGS;

        /// <summary>Enable or disable the switch confirmation dialog.</summary>
        public static bool CONFIRM_SWITCH = Constants.DEFAULT_CONFIRM_SWITCH;

        /// <summary>Enable or disable debug logging for the asset.</summary>
        public static bool DEBUG = Constants.DEFAULT_DEBUG;

        /// <summary>Enable or disable update-checks for the asset.</summary>
        public static bool UPDATE_CHECK = Constants.DEFAULT_UPDATE_CHECK;

        /// <summary>Open the UAS-site when an update is found.</summary>
        public static bool UPDATE_OPEN_UAS = Constants.DEFAULT_UPDATE_OPEN_UAS;

        /// <summary>Enable or disable the Windows platform.</summary>
        public static bool PLATFORM_WINDOWS = Constants.DEFAULT_PLATFORM_WINDOWS;

        /// <summary>Enable or disable the macOS platform.</summary>
        public static bool PLATFORM_MAC = Constants.DEFAULT_PLATFORM_MAC;

        /// <summary>Enable or disable the Linux platform.</summary>
        public static bool PLATFORM_LINUX = Constants.DEFAULT_PLATFORM_LINUX;

        /// <summary>Enable or disable the Android platform.</summary>
        public static bool PLATFORM_ANDROID = Constants.DEFAULT_PLATFORM_ANDROID;

        /// <summary>Enable or disable the iOS platform.</summary>
        public static bool PLATFORM_IOS = Constants.DEFAULT_PLATFORM_IOS;

        /// <summary>Enable or disable the WSA platform.</summary>
        public static bool PLATFORM_WSA = Constants.DEFAULT_PLATFORM_WSA;

        /// <summary>Enable or disable the WebPlayer platform.</summary>
        public static bool PLATFORM_WEBPLAYER = Constants.DEFAULT_PLATFORM_WEBPLAYER;

        /// <summary>Enable or disable the WebGL platform.</summary>
        public static bool PLATFORM_WEBGL = Constants.DEFAULT_PLATFORM_WEBGL;

        /// <summary>Enable or disable the tvOS platform.</summary>
        public static bool PLATFORM_TVOS = Constants.DEFAULT_PLATFORM_TVOS;

        /// <summary>Enable or disable the Tizen platform.</summary>
        public static bool PLATFORM_TIZEN = Constants.DEFAULT_PLATFORM_TIZEN;

        /// <summary>Enable or disable the SamsungTV platform.</summary>
        public static bool PLATFORM_SAMSUNGTV = Constants.DEFAULT_PLATFORM_SAMSUNGTV;

        /// <summary>Enable or disable the PS3 platform.</summary>
        public static bool PLATFORM_PS3 = Constants.DEFAULT_PLATFORM_PS3;

        /// <summary>Enable or disable the PS4 platform.</summary>
        public static bool PLATFORM_PS4 = Constants.DEFAULT_PLATFORM_PS4;

        /// <summary>Enable or disable the PSP2 (Vita) platform.</summary>
        public static bool PLATFORM_PSP2 = Constants.DEFAULT_PLATFORM_PSP2;

        /// <summary>Enable or disable the XBox360 platform.</summary>
        public static bool PLATFORM_XBOX360 = Constants.DEFAULT_PLATFORM_XBOX360;

        /// <summary>Enable or disable the XBoxOne platform.</summary>
        public static bool PLATFORM_XBOXONE = Constants.DEFAULT_PLATFORM_XBOXONE;

        /// <summary>Enable or disable the WiiU platform.</summary>
        public static bool PLATFORM_WIIU = Constants.DEFAULT_PLATFORM_WIIU;

        /// <summary>Enable or disable the 3DS platform.</summary>
        public static bool PLATFORM_3DS = Constants.DEFAULT_PLATFORM_3DS;

        /// <summary>Enable or disable the Nintendo Switch platform.</summary>
        public static bool PLATFORM_SWITCH = Constants.DEFAULT_PLATFORM_SWITCH;

        /// <summary>Architecture of the Windows platform.</summary>
        public static int ARCH_WINDOWS = Constants.DEFAULT_ARCH_WINDOWS;

        /// <summary>Architecture of the macOS platform.</summary>
        public static int ARCH_MAC = Constants.DEFAULT_ARCH_MAC;

        /// <summary>Architecture of the Linux platform.</summary>
        public static int ARCH_LINUX = Constants.DEFAULT_ARCH_LINUX;

        /// <summary>Texture format of the Android platform.</summary>
        public static int TEX_ANDROID = Constants.DEFAULT_TEX_ANDROID;

        /// <summary>Shows or hides the delete button for the cache.</summary>
        public static bool SHOW_DELETE = false;

        /// <summary>Shows or hides the column for the platform.</summary>
        public static bool SHOW_COLUMN_PLATFORM = Constants.DEFAULT_SHOW_COLUMN_PLATFORM;

        /// <summary>Shows or hides the column for the platform.</summary>
        public static bool SHOW_COLUMN_PLATFORM_LOGO = Constants.DEFAULT_SHOW_COLUMN_PLATFORM_LOGO;

        /// <summary>Shows or hides the column for the architecture.</summary>
        public static bool SHOW_COLUMN_ARCHITECTURE = Constants.DEFAULT_SHOW_COLUMN_ARCHITECTURE;

        /// <summary>Shows or hides the column for the texture format.</summary>
        public static bool SHOW_COLUMN_TEXTURE = Constants.DEFAULT_SHOW_COLUMN_TEXTURE;

        /// <summary>Shows or hides the column for the cache.</summary>
        public static bool SHOW_COLUMN_CACHE = Constants.DEFAULT_SHOW_COLUMN_CACHE;

        #endregion

        #region Public static methods

        /// <summary>Resets all changable variables to their default value.</summary>
        public static void Reset()
        {
            CUSTOM_PATH_CACHE = Constants.DEFAULT_CUSTOM_PATH_CACHE;
            pathCache = Constants.DEFAULT_PATH_CACHE;
            VCS = Constants.DEFAULT_VCS;
            EXECUTE_METHOD = string.Empty;
            COPY_SETTINGS = Constants.DEFAULT_COPY_SETTINGS;
            CONFIRM_SWITCH = Constants.DEFAULT_CONFIRM_SWITCH;
            DEBUG = Constants.DEFAULT_DEBUG;
            UPDATE_CHECK = Constants.DEFAULT_UPDATE_CHECK;
            UPDATE_OPEN_UAS = Constants.DEFAULT_UPDATE_OPEN_UAS;
            PLATFORM_WINDOWS = Constants.DEFAULT_PLATFORM_WINDOWS;
            PLATFORM_MAC = Constants.DEFAULT_PLATFORM_MAC;
            PLATFORM_LINUX = Constants.DEFAULT_PLATFORM_LINUX;
            PLATFORM_ANDROID = Constants.DEFAULT_PLATFORM_ANDROID;
            PLATFORM_IOS = Constants.DEFAULT_PLATFORM_IOS;
            PLATFORM_WSA = Constants.DEFAULT_PLATFORM_WSA;
            PLATFORM_WEBPLAYER = Constants.DEFAULT_PLATFORM_WEBPLAYER;
            PLATFORM_WEBGL = Constants.DEFAULT_PLATFORM_WEBGL;
            PLATFORM_TVOS = Constants.DEFAULT_PLATFORM_TVOS;
            PLATFORM_TIZEN = Constants.DEFAULT_PLATFORM_TIZEN;
            PLATFORM_SAMSUNGTV = Constants.DEFAULT_PLATFORM_SAMSUNGTV;
            PLATFORM_PS3 = Constants.DEFAULT_PLATFORM_PS3;
            PLATFORM_PS4 = Constants.DEFAULT_PLATFORM_PS4;
            PLATFORM_PSP2 = Constants.DEFAULT_PLATFORM_PSP2;
            PLATFORM_XBOX360 = Constants.DEFAULT_PLATFORM_XBOX360;
            PLATFORM_XBOXONE = Constants.DEFAULT_PLATFORM_XBOXONE;
            PLATFORM_WIIU = Constants.DEFAULT_PLATFORM_WIIU;
            PLATFORM_3DS = Constants.DEFAULT_PLATFORM_3DS;
            PLATFORM_SWITCH = Constants.DEFAULT_PLATFORM_SWITCH;
            ARCH_WINDOWS = Constants.DEFAULT_ARCH_WINDOWS;
            ARCH_MAC = Constants.DEFAULT_ARCH_MAC;
            ARCH_LINUX = Constants.DEFAULT_ARCH_LINUX;
            TEX_ANDROID = Constants.DEFAULT_TEX_ANDROID;
            SHOW_COLUMN_PLATFORM = Constants.DEFAULT_SHOW_COLUMN_PLATFORM;
            SHOW_COLUMN_PLATFORM_LOGO = Constants.DEFAULT_SHOW_COLUMN_PLATFORM_LOGO;
            SHOW_COLUMN_ARCHITECTURE = Constants.DEFAULT_SHOW_COLUMN_ARCHITECTURE;
            SHOW_COLUMN_TEXTURE = Constants.DEFAULT_SHOW_COLUMN_TEXTURE;
            SHOW_COLUMN_CACHE = Constants.DEFAULT_SHOW_COLUMN_CACHE;
        }

        /// <summary>Loads the all changable variables.</summary>
        public static void Load()
        {
            if (CTPlayerPrefs.HasKey(Constants.KEY_CUSTOM_PATH_CACHE))
            {
                CUSTOM_PATH_CACHE = CTPlayerPrefs.GetBool(Constants.KEY_CUSTOM_PATH_CACHE);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PATH_CACHE))
            {
                PATH_CACHE = CTPlayerPrefs.GetString(Constants.KEY_PATH_CACHE);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_VCS))
            {
                VCS = CTPlayerPrefs.GetInt(Constants.KEY_VCS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_EXECUTE_METHOD))
            {
                EXECUTE_METHOD = CTPlayerPrefs.GetString(Constants.KEY_EXECUTE_METHOD);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_COPY_SETTINGS))
            {
                COPY_SETTINGS = CTPlayerPrefs.GetBool(Constants.KEY_COPY_SETTINGS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_CONFIRM_SWITCH))
            {
                CONFIRM_SWITCH = CTPlayerPrefs.GetBool(Constants.KEY_CONFIRM_SWITCH);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_DEBUG))
            {
                DEBUG = CTPlayerPrefs.GetBool(Constants.KEY_DEBUG);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_UPDATE_CHECK))
            {
                UPDATE_CHECK = CTPlayerPrefs.GetBool(Constants.KEY_UPDATE_CHECK);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_UPDATE_OPEN_UAS))
            {
                UPDATE_OPEN_UAS = CTPlayerPrefs.GetBool(Constants.KEY_UPDATE_OPEN_UAS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_WINDOWS))
            {
                PLATFORM_WINDOWS = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_WINDOWS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_MAC))
            {
                PLATFORM_MAC = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_MAC);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_LINUX))
            {
                PLATFORM_LINUX = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_LINUX);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_ANDROID))
            {
                PLATFORM_ANDROID = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_ANDROID);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_IOS))
            {
                PLATFORM_IOS = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_IOS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_WSA))
            {
                PLATFORM_WSA = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_WSA);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_WEBPLAYER))
            {
                PLATFORM_WEBPLAYER = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_WEBPLAYER);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_WEBGL))
            {
                PLATFORM_WEBGL = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_WEBGL);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_TVOS))
            {
                PLATFORM_TVOS = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_TVOS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_TIZEN))
            {
                PLATFORM_TIZEN = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_TIZEN);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_SAMSUNGTV))
            {
                PLATFORM_SAMSUNGTV = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_SAMSUNGTV);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_PS3))
            {
                PLATFORM_PS3 = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_PS3);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_PS4))
            {
                PLATFORM_PS4 = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_PS4);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_PSP2))
            {
                PLATFORM_PSP2 = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_PSP2);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_XBOX360))
            {
                PLATFORM_XBOX360 = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_XBOX360);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_XBOXONE))
            {
                PLATFORM_XBOXONE = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_XBOXONE);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_WIIU))
            {
                PLATFORM_WIIU = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_WIIU);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_3DS))
            {
                PLATFORM_3DS = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_3DS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_PLATFORM_SWITCH))
            {
                PLATFORM_SWITCH = CTPlayerPrefs.GetBool(Constants.KEY_PLATFORM_SWITCH);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_ARCH_WINDOWS))
            {
                ARCH_WINDOWS = CTPlayerPrefs.GetInt(Constants.KEY_ARCH_WINDOWS);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_ARCH_MAC))
            {
                ARCH_MAC = CTPlayerPrefs.GetInt(Constants.KEY_ARCH_MAC);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_ARCH_LINUX))
            {
                ARCH_LINUX = CTPlayerPrefs.GetInt(Constants.KEY_ARCH_LINUX);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_TEX_ANDROID))
            {
                TEX_ANDROID = CTPlayerPrefs.GetInt(Constants.KEY_TEX_ANDROID);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_SHOW_COLUMN_PLATFORM))
            {
                SHOW_COLUMN_PLATFORM = CTPlayerPrefs.GetBool(Constants.KEY_SHOW_COLUMN_PLATFORM);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_SHOW_COLUMN_ARCHITECTURE))
            {
                SHOW_COLUMN_ARCHITECTURE = CTPlayerPrefs.GetBool(Constants.KEY_SHOW_COLUMN_ARCHITECTURE);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_SHOW_COLUMN_TEXTURE))
            {
                SHOW_COLUMN_TEXTURE = CTPlayerPrefs.GetBool(Constants.KEY_SHOW_COLUMN_TEXTURE);
            }

            if (CTPlayerPrefs.HasKey(Constants.KEY_SHOW_COLUMN_CACHE))
            {
                SHOW_COLUMN_CACHE = CTPlayerPrefs.GetBool(Constants.KEY_SHOW_COLUMN_CACHE);
            }
        }

        /// <summary>Saves the all changable variables.</summary>
        public static void Save()
        {
            CTPlayerPrefs.SetBool(Constants.KEY_CUSTOM_PATH_CACHE, CUSTOM_PATH_CACHE);
            CTPlayerPrefs.SetString(Constants.KEY_PATH_CACHE, PATH_CACHE);
            CTPlayerPrefs.SetInt(Constants.KEY_VCS, VCS);
            CTPlayerPrefs.SetString(Constants.KEY_EXECUTE_METHOD, EXECUTE_METHOD);
            CTPlayerPrefs.SetBool(Constants.KEY_COPY_SETTINGS, COPY_SETTINGS);
            CTPlayerPrefs.SetBool(Constants.KEY_CONFIRM_SWITCH, CONFIRM_SWITCH);
            CTPlayerPrefs.SetBool(Constants.KEY_DEBUG, DEBUG);
            CTPlayerPrefs.SetBool(Constants.KEY_UPDATE_CHECK, UPDATE_CHECK);
            CTPlayerPrefs.SetBool(Constants.KEY_UPDATE_OPEN_UAS, UPDATE_OPEN_UAS);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_WINDOWS, PLATFORM_WINDOWS);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_MAC, PLATFORM_MAC);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_LINUX, PLATFORM_LINUX);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_ANDROID, PLATFORM_ANDROID);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_IOS, PLATFORM_IOS);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_WSA, PLATFORM_WSA);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_WEBPLAYER, PLATFORM_WEBPLAYER);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_WEBGL, PLATFORM_WEBGL);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_TVOS, PLATFORM_TVOS);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_TIZEN, PLATFORM_TIZEN);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_SAMSUNGTV, PLATFORM_SAMSUNGTV);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_PS3, PLATFORM_PS3);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_PS4, PLATFORM_PS4);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_PSP2, PLATFORM_PSP2);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_XBOX360, PLATFORM_XBOX360);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_XBOXONE, PLATFORM_XBOXONE);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_WIIU, PLATFORM_WIIU);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_3DS, PLATFORM_3DS);
            CTPlayerPrefs.SetBool(Constants.KEY_PLATFORM_SWITCH, PLATFORM_SWITCH);
            CTPlayerPrefs.SetInt(Constants.KEY_ARCH_WINDOWS, ARCH_WINDOWS);
            CTPlayerPrefs.SetInt(Constants.KEY_ARCH_MAC, ARCH_MAC);
            CTPlayerPrefs.SetInt(Constants.KEY_ARCH_LINUX, ARCH_LINUX);
            CTPlayerPrefs.SetInt(Constants.KEY_TEX_ANDROID, TEX_ANDROID);
            CTPlayerPrefs.SetBool(Constants.KEY_SHOW_COLUMN_PLATFORM, SHOW_COLUMN_PLATFORM);
            CTPlayerPrefs.SetBool(Constants.KEY_SHOW_COLUMN_ARCHITECTURE, SHOW_COLUMN_ARCHITECTURE);
            CTPlayerPrefs.SetBool(Constants.KEY_SHOW_COLUMN_TEXTURE, SHOW_COLUMN_TEXTURE);
            CTPlayerPrefs.SetBool(Constants.KEY_SHOW_COLUMN_CACHE, SHOW_COLUMN_CACHE);

            CTPlayerPrefs.Save();
        }

        #endregion

    }
}
// © 2017 crosstales LLC (https://www.crosstales.com)