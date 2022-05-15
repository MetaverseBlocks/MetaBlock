using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bExit : MonoBehaviour
{
   public void OnClickExit()
    {
        
        UnityEditor.EditorApplication.isPlaying=false;
        Application.Quit();
        Debug.Log("Button CLick");
       

    
    
     }
}
