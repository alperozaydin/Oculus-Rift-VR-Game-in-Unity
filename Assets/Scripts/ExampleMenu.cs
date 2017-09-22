using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleMenu : VRGUI
{
    public string stringToEdit = "Hello World\nI've got 2 lines...";
    public string stringToEdit2 = "selam.";

    public Texture aTexture;



    public override void OnVRGUI()
    {







        GUI.DrawTexture(new Rect(10, 10, 60, 60), aTexture, ScaleMode.ScaleToFit, true, 10.0F);


        GUILayout.BeginArea(new Rect(3, 3, Screen.width, Screen.height));

        stringToEdit2 = GUI.TextArea(new Rect(900, 70, 30, 450), stringToEdit, 200);








        GUILayout.EndArea();
    }

   
    
}