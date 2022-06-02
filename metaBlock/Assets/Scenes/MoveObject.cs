using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    
    public Button btn1, btn2, btn3, btn4,upbtn, downbtn;

    //1=위, 2=아래, 3=왼, 4= 오
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
        
     
        upbtn.onClick.AddListener(upBtn);
        downbtn.onClick.AddListener(downBtn);
        btn1.onClick.AddListener(Btn1);
        btn2.onClick.AddListener(Btn2);
        btn3.onClick.AddListener(Btn3);
        btn4.onClick.AddListener(Btn4);

    }

    void upBtn()
    {
        print("출력1");
        this.transform.Translate(0.0f, 0.01f, 0.0f);
        print("출력2");
    }
    void downBtn()
    {
        this.transform.Translate(0.0f, -0.01f, 0.0f);
    }
    void Btn1()
    {
        this.transform.Translate(0.0f, 0.0f, 0.01f);
    }
    void Btn2()
    {
        this.transform.Translate(0.0f, 0.0f, -0.01f);
    }
    void Btn3()
    {
        this.transform.Translate(-0.01f, 0.0f, 0.0f);

    }
    void Btn4()
    {
        this.transform.Translate(0.01f, 0.0f, 0.0f);
    }





}