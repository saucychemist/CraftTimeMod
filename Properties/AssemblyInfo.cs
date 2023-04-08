using MelonLoader;
using System.Reflection;

//This is a C# comment. Comments have no impact on compilation.

[assembly: AssemblyTitle(CraftTimeMod.BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by {CraftTimeMod.BuildInfo.ModAuthor}")]

[assembly: AssemblyVersion(CraftTimeMod.BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(CraftTimeMod.BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(CraftTimeMod.CraftTimeMod), CraftTimeMod.BuildInfo.ModName, CraftTimeMod.BuildInfo.ModVersion, CraftTimeMod.BuildInfo.ModAuthor)]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]