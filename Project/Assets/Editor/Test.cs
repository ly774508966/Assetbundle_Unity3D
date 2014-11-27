using UnityEngine;
using System.Collections;
using UnityEditor;

public class Test : Editor
{
	[MenuItem("Custom Editor/Create Scene")]
	static void CreateSceneALL ()
	{
		string  []levels = {"C:/Assetbundle_Unity3D/Project/Assets/Level1.unity"};
        BuildPipeline.BuildStreamedSceneAssetBundle( levels, "Streamed-Level1.unity3d", BuildTarget.StandaloneWindows); 
	}
	
}
