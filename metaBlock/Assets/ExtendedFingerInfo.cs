using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendedFingerInfo : MonoBehaviour
{
    public static bool fistGesture = false;  //�ָ��� ������� �ƴ��� 
    public static bool clickGuesture = false;   //Ŭ���ϴ� ������ ��ģ ������� �ƴ���

    public void fistMotionLeft()
    {
        fistGesture = true;
        if (CollisionDetector.collsionStay)
            Debug.Log("left hand grabbing the block");//Debug.Log("�޼� ��� ����");
        //Debug.Log("�ָ���");
    }

    public void notFistMotionLeft()
    {
        fistGesture = false;
        if (CollisionDetector.collsionStay)  //��ݱ��� ��ϰ� �浹�Ǿ��µ� �ָ��� ��ģ�� -> ����� ����
            Debug.Log("left hand put down the block"); //Debug.Log("�޼� ��� ����");
       // Debug.Log("�ָԾ���");
    }

    public void fistMotionRight()
    {
        fistGesture = true;
        if (CollisionDetector.collsionStay)
            Debug.Log("right hand grabbing the block"); //Debug.Log("������ ��� ����");
        //Debug.Log("�ָ���");
    }

    public void notFistMotionRight()
    {
        fistGesture = false;
        if (CollisionDetector.collsionStay)  //��ݱ��� ��ϰ� �浹�Ǿ��µ� �ָ��� ��ģ�� -> ����� ����
            Debug.Log("right hand put down the block");//Debug.Log("������ ��� ����");
        // Debug.Log("�ָԾ���");
    }

    public void clickMotion()
    {
        clickGuesture = true;
    }

    public void notClickMotion()
    {
        clickGuesture = false;
    }
}
