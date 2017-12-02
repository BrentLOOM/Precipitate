using UnityEngine;

namespace Crosstales.TPS
{
    /// <summary>Collected constants of very general utility for the asset.</summary>
    public static class Constants
    {

        #region Constant variables

        /// <summary>Name of the asset.</summary>
        public const string ASSET_NAME = "Turbo Platform Switch";

        /// <summary>Version of the asset.</summary>
        public const string ASSET_VERSION = "1.5.0";

        /// <summary>Build number of the asset.</summary>
        public const int ASSET_BUILD = 150;

        /// <summary>Create date of the asset (YYYY, MM, DD).</summary>
        public static readonly System.DateTime ASSET_CREATED = new System.DateTime(2016, 9, 22);

        /// <summary>Change date of the asset (YYYY, MM, DD).</summary>
        public static readonly System.DateTime ASSET_CHANGED = new System.DateTime(2017, 5, 5);

        /// <summary>Author of the asset.</summary>
        public const string ASSET_AUTHOR = "crosstales LLC";

        /// <summary>URL of the asset author.</summary>
        public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

        /// <summary>URL of the crosstales assets in UAS.</summary>
        public const string ASSET_CT_URL = "https://www.assetstore.unity3d.com/#!/list/42213-crosstales?aid=1011lNGT&pubref=" + ASSET_NAME; // crosstales list

        /// <summary>ID of the asset in the UAS.</summary>
        public const string ASSET_ID = "60040";

        /// <summary>URL of the asset in the UAS.</summary>
		public const string ASSET_URL = "https://www.assetstore.unity3d.com/#!/content/60040?aid=1011lNGT&pubref=" + ASSET_NAME;

        /// <summary>URL for update-checks of the asset</summary>
        public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/tps_versions.txt";

        /// <summary>Contact to the owner of the asset.</summary>
        public const string ASSET_CONTACT = "tps@crosstales.com";

        /// <summary>UID of the asset.</summary>
        public static readonly System.Guid ASSET_UID = new System.Guid("2d03d693-219a-4fa4-a9b0-83e5a59ebe01");

        /// <summary>URL of the asset manual.</summary>
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/tps/TPS-doc.pdf";

        /// <summary>URL of the asset API.</summary>
		public const string ASSET_API_URL = "https://goo.gl/NDTja0"; // checked: 08.03.2017
        //public const string ASSET_API_URL = "http://www.crosstales.com/en/assets/tps/api/";

        /// <summary>URL of the asset forum.</summary>
        public const string ASSET_FORUM_URL = "https://goo.gl/d7SjL2"; // checked: 08.03.2017
        //public const string ASSET_FORUM_URL = "https://forum.unity3d.com/threads/turbo-platform-switch.434860/";

        /// <summary>URL of the asset in crosstales.</summary>
        public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/tps/";

        // Keys for the configuration of the asset
        private const string KEY_PREFIX = "TPS_CFG_";
        public const string KEY_CUSTOM_PATH_CACHE = KEY_PREFIX + "CUSTOM_PATH_CACHE";
        public const string KEY_PATH_CACHE = KEY_PREFIX + "PATH_CACHE";
        public const string KEY_VCS = KEY_PREFIX + "VCS";
        public const string KEY_EXECUTE_METHOD = KEY_PREFIX + "EXECUTE_METHOD";
        public const string KEY_COPY_SETTINGS = KEY_PREFIX + "COPY_SETTINGS";
        public const string KEY_CONFIRM_SWITCH = KEY_PREFIX + "CONFIRM_SWITCH";
        public const string KEY_DEBUG = KEY_PREFIX + "DEBUG";
        public const string KEY_UPDATE_CHECK = KEY_PREFIX + "UPDATE_CHECK";
        public const string KEY_UPDATE_OPEN_UAS = KEY_PREFIX + "UPDATE_OPEN_UAS";
        public const string KEY_UPDATE_DATE = KEY_PREFIX + "UPDATE_DATE";

        public const string KEY_PLATFORM_WINDOWS = KEY_PREFIX + "PLATFORM_WINDOWS";
        public const string KEY_PLATFORM_MAC = KEY_PREFIX + "PLATFORM_MAC";
        public const string KEY_PLATFORM_LINUX = KEY_PREFIX + "PLATFORM_LINUX";
        public const string KEY_PLATFORM_ANDROID = KEY_PREFIX + "PLATFORM_ANDROID";
        public const string KEY_PLATFORM_IOS = KEY_PREFIX + "PLATFORM_IOS";
        public const string KEY_PLATFORM_WSA = KEY_PREFIX + "PLATFORM_WSA";
        public const string KEY_PLATFORM_WEBPLAYER = KEY_PREFIX + "PLATFORM_WEBPLAYER";
        public const string KEY_PLATFORM_WEBGL = KEY_PREFIX + "PLATFORM_WEBGL";
        public const string KEY_PLATFORM_TVOS = KEY_PREFIX + "PLATFORM_TVOS";
        public const string KEY_PLATFORM_TIZEN = KEY_PREFIX + "PLATFORM_TIZEN";
        public const string KEY_PLATFORM_SAMSUNGTV = KEY_PREFIX + "PLATFORM_SAMSUNGTV";
        public const string KEY_PLATFORM_PS3 = KEY_PREFIX + "PLATFORM_PS3";
        public const string KEY_PLATFORM_PS4 = KEY_PREFIX + "PLATFORM_PS4";
        public const string KEY_PLATFORM_PSP2 = KEY_PREFIX + "PLATFORM_PSP2";
        public const string KEY_PLATFORM_XBOX360 = KEY_PREFIX + "PLATFORM_XBOX360";
        public const string KEY_PLATFORM_XBOXONE = KEY_PREFIX + "PLATFORM_XBOXONE";
        public const string KEY_PLATFORM_WIIU = KEY_PREFIX + "PLATFORM_WIIU";
        public const string KEY_PLATFORM_3DS = KEY_PREFIX + "PLATFORM_3DS";
        public const string KEY_PLATFORM_SWITCH = KEY_PREFIX + "PLATFORM_SWITCH";

        public const string KEY_ARCH_WINDOWS = KEY_PREFIX + "ARCH_WINDOWS";
        public const string KEY_ARCH_MAC = KEY_PREFIX + "ARCH_MAC";
        public const string KEY_ARCH_LINUX = KEY_PREFIX + "ARCH_LINUX";

        public const string KEY_TEX_ANDROID = KEY_PREFIX + "TEX_ANDROID";

        public const string KEY_SHOW_COLUMN_PLATFORM = KEY_PREFIX + "SHOW_COLUMN_PLATFORM";
        public const string KEY_SHOW_COLUMN_ARCHITECTURE = KEY_PREFIX + "SHOW_COLUMN_ARCHITECTURE";
        public const string KEY_SHOW_COLUMN_TEXTURE = KEY_PREFIX + "SHOW_COLUMN_TEXTURE";
        public const string KEY_SHOW_COLUMN_CACHE = KEY_PREFIX + "SHOW_COLUMN_CACHE";

        public const string CACHE_DIRNAME = "TPS_cache";

        /// <summary>Application path.</summary>
        public static readonly string PATH = Helper.ValidatePath(Application.dataPath.Substring(0, Application.dataPath.LastIndexOf('/') + 1));

        // Default values
        public static readonly string DEFAULT_PATH_CACHE = Helper.ValidatePath(PATH + CACHE_DIRNAME);
        public const bool DEFAULT_CUSTOM_PATH_CACHE = false;
        public const int DEFAULT_VCS = 1; //git
        public const bool DEFAULT_COPY_SETTINGS = true;
        public const bool DEFAULT_CONFIRM_SWITCH = true;
        public const bool DEFAULT_DEBUG = false;
        public const bool DEFAULT_UPDATE_CHECK = true;
        public const bool DEFAULT_UPDATE_OPEN_UAS = false;
        public const bool DEFAULT_PLATFORM_WINDOWS = true;
        public const bool DEFAULT_PLATFORM_MAC = true;
        public const bool DEFAULT_PLATFORM_LINUX = true;
        public const bool DEFAULT_PLATFORM_ANDROID = true;
        public const bool DEFAULT_PLATFORM_IOS = true;
        public const bool DEFAULT_PLATFORM_WSA = false;
        public const bool DEFAULT_PLATFORM_WEBPLAYER = false;
        public const bool DEFAULT_PLATFORM_WEBGL = true;
        public const bool DEFAULT_PLATFORM_TVOS = false;
        public const bool DEFAULT_PLATFORM_TIZEN = false;
        public const bool DEFAULT_PLATFORM_SAMSUNGTV = false;
        public const bool DEFAULT_PLATFORM_PS3 = false;
        public const bool DEFAULT_PLATFORM_PS4 = false;
        public const bool DEFAULT_PLATFORM_PSP2 = false;
        public const bool DEFAULT_PLATFORM_XBOX360 = false;
        public const bool DEFAULT_PLATFORM_XBOXONE = false;
        public const bool DEFAULT_PLATFORM_WIIU = false;
        public const bool DEFAULT_PLATFORM_3DS = false;
        public const bool DEFAULT_PLATFORM_SWITCH = false;
        public const int DEFAULT_ARCH_WINDOWS = 0;
        public const int DEFAULT_ARCH_MAC = 0;
        public const int DEFAULT_ARCH_LINUX = 0;
        public const int DEFAULT_TEX_ANDROID = 0;
        public const bool DEFAULT_SHOW_COLUMN_PLATFORM = true;
        public const bool DEFAULT_SHOW_COLUMN_PLATFORM_LOGO = false;
        public const bool DEFAULT_SHOW_COLUMN_ARCHITECTURE = true;
        public const bool DEFAULT_SHOW_COLUMN_TEXTURE = false;
        public const bool DEFAULT_SHOW_COLUMN_CACHE = true;

        #endregion


        #region Changable variables

        // Technical settings
        /// <summary>Kill processes after 3000 milliseconds.</summary>
        public static int KILL_TIME = 3000;

        #endregion

    }
}
// © 2016-2017 crosstales LLC (https://www.crosstales.com)