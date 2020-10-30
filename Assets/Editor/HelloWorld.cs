using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HelloWorld : EditorWindow
{
    [MenuItem("GameObject/Hello World")]
    private static void CreateHelloWorldGameObject()
    {
        if (EditorUtility.DisplayDialog(
            "Hello World",
            "Do you really want to do this?",
            "Create",
            "Cancel"))
        {
            GameObject helloWorld= new GameObject("HelloWorld");
            //set tag to the game object
            helloWorld.tag = "HelloWorld";
            //add any component to the GameObject
            helloWorld.AddComponent<Rigidbody>();
        }
    }
}
