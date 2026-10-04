using UnityEngine;
using UnityEditor;
using System.IO;
using NUnit.Framework;
using System;

public class ScreenshotUtility : EditorWindow {
    [MenuItem("Custom/Capture Screenshot")]
    public static void CaptureScreenshot()
    {
        string date = System.DateTime.Now.ToString();
        date = date.Replace("/", "-");
        date = date.Replace(" ", "_");
        date = date.Replace(":", "-");
        string filePath = string.Format("Assets/{0}.png", date);
        Application.CaptureScreenshot(filePath);
        Debug.Log(filePath);
    }
}
