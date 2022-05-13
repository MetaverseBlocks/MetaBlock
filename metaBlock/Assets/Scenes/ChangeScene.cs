using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject menuset;
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
            
        }
    }
    private void Update()
    {
        if (Input.GetButton("exitbtn"))
        {
            menuset.SetActive(true);
        }
    }
}

