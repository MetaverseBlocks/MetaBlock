using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private static bool changeMode = false;
    public void chageModeOn()
    {
        changeMode = true;
    }

    public void chageModeOff()
    {
        changeMode = false;
    }

    public void ChangeSceneBtn()
    {


        if (changeMode == true)
        {

            switch (this.gameObject.name)
            {
                case "���ӽ���":
                    SceneManager.LoadScene("PlayRoom");
                    changeMode = false;
                    break;
                case "���Ӽ���":
                    SceneManager.LoadScene("howtoplay");
                    changeMode = false;
                    break;
                case "�޴���":
                    SceneManager.LoadScene("MainMenu");
                    changeMode = false;
                    break;
                case "�������":
                    SceneManager.LoadScene("MainMenu");
                    changeMode = false;
                    break;
            }

        }
        else
            return;

    }

}

