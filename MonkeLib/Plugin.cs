using BepInEx;

namespace MonkeLib;

[BepInPlugin(PluginInfo.Guid, PluginInfo.Name, PluginInfo.Version)]
public class Plugin : BaseUnityPlugin
{
    
}

public static class PluginInfo
{
    public const string Guid = "xyz.pl2w.monkelib";
    public const string Name = "MonkeLib";
    public const string Version = "0.1.0";
}