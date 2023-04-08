using MelonLoader;


namespace CraftTimeMod
{
    public static class BuildInfo
    {
        internal const string ModName = "CraftTimeMod";
        internal const string ModAuthor = "wannabehero";
        internal const string ModVersion = "1.0.2";
    }
    internal class CraftTimeMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
            LoggerInstance.Msg($"[{BuildInfo.ModName}] Version {BuildInfo.ModVersion} loaded!");
        }
        public static void Log(string msg)
        {
            MelonLogger.Msg(msg);
        }
    }
}