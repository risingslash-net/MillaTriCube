using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(MillaTriCube.RisingSlash.BuildInfo.Description)]
[assembly: AssemblyDescription(MillaTriCube.RisingSlash.BuildInfo.Description)]
[assembly: AssemblyCompany(MillaTriCube.RisingSlash.BuildInfo.Company)]
[assembly: AssemblyProduct(MillaTriCube.RisingSlash.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + MillaTriCube.RisingSlash.BuildInfo.Author)]
[assembly: AssemblyTrademark(MillaTriCube.RisingSlash.BuildInfo.Company)]
[assembly: AssemblyVersion(MillaTriCube.RisingSlash.BuildInfo.Version)]
[assembly: AssemblyFileVersion(MillaTriCube.RisingSlash.BuildInfo.Version)]
[assembly: MelonInfo(typeof(MillaTriCube.RisingSlash.MillaTriCube), MillaTriCube.RisingSlash.BuildInfo.Name, MillaTriCube.RisingSlash.BuildInfo.Version, MillaTriCube.RisingSlash.BuildInfo.Author, MillaTriCube.RisingSlash.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]