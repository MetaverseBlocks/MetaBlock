using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    public Button btn1, btn2, btn3, btn4, upbtn, downbtn;
    //1=À§, 2=¾Æ·¡, 3=¿Þ, 4= ¿À
    /*
    public float speed = 30f;
    Vector3 fb = new Vector3(0, 0, 1);
    Vector3 lr = new Vector3(0, 1, 0);
    */
    void Update()
    {
        /*  float v = Input.GetAxis("Vertical") * Time.deltaTime;
          float h = Input.GetAxis("Horizontal") * Time.deltaTime;
          transform.Translate(fb * v * speed);
          transform.Rotate(lr * h * speed);
        */
        
        btn1.onClick.AddListener(btN1);
        btn2.onClick.AddListener(btN2);
        btn3.onClick.AddListener(btN3);
        btn4.onClick.AddListener(btN4);
        upbtn.onClick.AddListener(upBtn);
        downbtn.onClick.AddListener(downBtn);

    }
    void btN1()
    {
        this.transform.Translate(0.0f, 0.0f, 0.01f);
    }
    void btN2()
    {
        this.transform.Translate(0.0f, 0.0f, -0.01f);

    }
    void btN3()
    {
        this.transform.Translate(-0.01f, 0.0f, 0.0f);
    }
    void btN4()
    {
        this.transform.Translate(0.01f, 0.0f, 0.0f);

    }
    void upBtn()
    {
        this.transform.Translate(0.0f, 0.01f, 0.0f);
    }
    void downBtn()
    {
        this.transform.Translate(0.0f, -0.01f, 0.0f);
    }

}