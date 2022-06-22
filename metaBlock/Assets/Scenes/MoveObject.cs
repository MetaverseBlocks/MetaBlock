using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{

    private static bool clickMode = false;
    public void clickModeOn()
    {
        clickMode = true;
    }

    public void clickModeOff()
    {
        clickMode = false;
    }

   
    //public Button btn1, btn2, btn3, btn4, upbtn, downbtn;

    //1=��, 2=�Ʒ�, 3=��, 4= ��
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

        /* 
            upbtn.onClick.AddListener(upBtn);
            downbtn.onClick.AddListener(downBtn);
            btn1.onClick.AddListener(Btn1);
            btn2.onClick.AddListener(Btn2);
            btn3.onClick.AddListener(Btn3);
            btn4.onClick.AddListener(Btn4);
        */
    }

    public void  upBtn()
    {
        // print("���1");
        Debug.Log("����ư Ŭ����,clickMode:" + clickMode);
        if (clickMode)
        {

            AudioSource sound= GetComponent<AudioSource>();
            sound.Play();
            //this.transform.Translate(0.0f, 0.0005f, 0.0f);
            this.transform.Translate(0.0f, 0.5f, 0.0f);
        }

        // print("���2");
    }
    public void downBtn()
    {
        // print("���1");
        Debug.Log("�ٿ��ư Ŭ����,clickMode:" + clickMode);
        if (clickMode)
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();
            //this.transform.Translate(0.0f, -0.0005f, 0.0f);
            this.transform.Translate(0.0f, -0.5f, 0.0f);
        }

    }
    public void frontBtn()
    {

        Debug.Log("���ư Ŭ����,clickMode:"+clickMode);

        if (clickMode)
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();
            // Debug.Log("�� ��ư Ŭ����");
            this.transform.Translate(0.0f, 0.0f, 0.5f);
        }

    }
    public void backBtn()
    {
        Debug.Log("�Ϲ�ư Ŭ����,clickMode:" + clickMode);
        if (clickMode)
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();
            // this.transform.Translate(0.0f, 0.0f, -0.0005f);
            this.transform.Translate(0.0f, 0.0f, -0.5f);
        }

    }
    public  void leftBtn()
    {
        Debug.Log("�¹�ư Ŭ����,clickMode:" + clickMode);
        if (clickMode)
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();
            //this.transform.Translate(-0.0005f, 0.0f, 0.0f);
            this.transform.Translate(-0.5f, 0.0f, 0.0f);
        }


    }
    public void rightBtn()
    {
        Debug.Log("���ư Ŭ����,clickMode:" + clickMode);
        if (clickMode)
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();
            //this.transform.Translate(0.0005f, 0.0f, 0.0f);
            this.transform.Translate(0.5f, 0.0f, 0.0f);
        }

    }





}