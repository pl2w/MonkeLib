using System.IO;
using System.Reflection;
using UnityEngine;

namespace MonkeLib.Assets;

public static class AssetLoading
{
    public static Texture2D LoadTextureFromEmbed(string resourcePath)
    {
        var assembly = Assembly.GetCallingAssembly();

        using var stream = assembly.GetManifestResourceStream(resourcePath);
        
        if (stream == null)
        {
            Debug.LogError($"[MonkeLib] Resource not found: {resourcePath}");
            foreach (var name in assembly.GetManifestResourceNames())
                Debug.Log($"Available resource: {name}");
            return null;
        }

        byte[] buffer = new byte[stream.Length];
        stream.Read(buffer, 0, buffer.Length);

        var texture = new Texture2D(2, 2);
        return texture.LoadImage(buffer) ? texture : null;
    }
}