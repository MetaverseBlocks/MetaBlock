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
                case "게임시작":
                    SceneManager.LoadScene("PlayRoom");
                    changeMode = false;
                    break;
                case "게임설명":
                    SceneManager.LoadScene("howtoplay");
                    changeMode = false;
                    break;
                case "메뉴로":
                    SceneManager.LoadScene("MainMenu");
                    changeMode = false;
                    break;
                case "검정블록":
                    SceneManager.LoadScene("MainMenu");
                    changeMode = false;
                    break;
            }

        }
        else
            return;

    }

}

