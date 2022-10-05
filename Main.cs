using MelonLoader;
using UnityEngine;

namespace MillaTriCube.RisingSlash
{
    public static class BuildInfo
    {
        public const string Name = "MillaTriCube"; // Name of the Mod.  (MUST BE SET)

        public const string Description =
            "A simple Freedom Planet 2 Mod that makes milla spawn 3 cubes instead of 1 when pressing the Special button."; // Description for the Mod.  (Set as null if none)

        public const string Author = "Catssandra Ann"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://github.com/PoppingSpree"; // Download Link for the Mod.  (Set as null if none)
    }

    public class MillaTriCube : MelonMod
    {
        public static GameObject goMillaTriCube;
        
        public static MelonPreferences_Category PrefsMillaTriCube;
        public static MelonPreferences_Entry<int> CubeNum;
        
        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("MillaTriCube is active.");
            MelonPreferences.Load();
            PrefsMillaTriCube = MelonPreferences.CreateCategory("MillaTriCube");
            CubeNum = PrefsMillaTriCube.CreateEntry("CubeNum", 6);
            MelonPreferences.Save();
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            if (goMillaTriCube == null)
            {
                goMillaTriCube = new GameObject();
                GameObject.DontDestroyOnLoad(goMillaTriCube);
                var mtc = goMillaTriCube.AddComponent<MillaTriCubeBehaviour>();
            }
        }
    }
}