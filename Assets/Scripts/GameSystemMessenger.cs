using UnityEngine;

public static class GameSystemMessenger
{
    public static void WriteSaveData(string filename, string data)
    {
        PlayerPrefs.SetString(filename, data);
    }

    public static bool TryReadSaveData(string filename, out string dataString)
    {
        dataString = PlayerPrefs.GetString(filename);
        return PlayerPrefs.HasKey(filename);
    }
}