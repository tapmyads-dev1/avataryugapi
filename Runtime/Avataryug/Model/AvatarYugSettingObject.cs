using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AvatarYugSettingObject
{
#if UNITY_EDITOR
    [MenuItem("AvatarYug/AvatarYugSettings")]
    public static void AvatarYugSettings()
    {
        var settingsList = Resources.LoadAll<AvatarYugSettings>("AvatarYugSettings");
        if (settingsList.Length <= 0)
        {
            AvatarYugSettings asset = ScriptableObject.CreateInstance<AvatarYugSettings>();
            AssetDatabase.CreateAsset(asset, "Assets/Plugins/Resources/AvatarYugSettings.asset"); // TODO: Path should not be hard coded
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }
        else if (settingsList.Length > 1)
        {
            Debug.LogWarning("Multiple of no Project Setting");
        }
        else
        {
            EditorUtility.FocusProjectWindow();
            AssetDatabase.SaveAssets();
            Selection.activeObject = settingsList[0];
        }

    }
#endif
}
