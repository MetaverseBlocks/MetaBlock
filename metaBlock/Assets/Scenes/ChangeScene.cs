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
            case "�������":
                SceneManager.LoadScene("SampleScene");
                break;
            case "���Ӽ���":
                SceneManager.LoadScene("howtoplay");
                break;
            case "�޴���":
                SceneManager.LoadScene("MainMenu");
                break;
           
        }
    }
  
}

