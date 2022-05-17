using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "자유모드":
                SceneManager.LoadScene("SampleScene");
                break;
            case "게임설명":
                SceneManager.LoadScene("howtoplay");
                break;
            case "메뉴로":
                SceneManager.LoadScene("MainMenu");
                break;
           
        }
    }
  
}

