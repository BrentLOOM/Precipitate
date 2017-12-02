using UnityEngine;
using UnityEditor;

namespace Crosstales.TPS
{
    /// <summary>Loads the configuration of the asset.</summary>
    [InitializeOnLoad]
    public static class ConfigLoader
    {

        #region Constructor

        static ConfigLoader()
        {
            Config.Load();

            if (Config.DEBUG)
                Debug.Log("Config data loaded");

            Helper.DeleteAllScripts();
        }

        #endregion
    }
}
// © 2016-2017 crosstales LLC (https://www.crosstales.com)