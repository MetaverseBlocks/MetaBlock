using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowtoPlay : MonoBehaviour
{

  public void ChangeSceneBtn()
    {
       

        switch (this.gameObject.name)
        {
            case "beforebtn":
                SceneManager.LoadScene("MainMenu");
                break;
            case "startbtn":
                SceneManager.LoadScene("PlayRoom");
                break;
         
        }
    }
}
