using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEditor;


[InitializeOnLoad]
public class Entry : MonoBehaviour {

    static Entry()
    {
        EditorApplication.update += Initialize;
    }
    
    private static void Initialize()
    {
        EditorApplication.update -= Initialize;
        var cl = new ExternalLibrary.CalledClass();
        Debug.Log("created");
    }
}
