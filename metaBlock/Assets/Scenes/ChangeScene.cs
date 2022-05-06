using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        }
    }
}

