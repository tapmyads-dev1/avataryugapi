using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName = "AvatarYugSettings", menuName = "Tapmyads/CreateAvatarYugSettings", order = 1)]
public class AvatarYugSettings : ScriptableObject
{
    public string ProjectId;
    public string SecretKey;//2b7e151628aed2a6abf7158809cf4f3c
    public string IVSecretKey; //000102030405060708090a0b0c0d0e0f
    public void Save()
    {
#if UNITY_EDITOR
        AssetDatabase.SaveAssets();
#endif
    }

}
