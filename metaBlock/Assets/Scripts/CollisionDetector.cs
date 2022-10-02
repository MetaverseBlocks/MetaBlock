using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetector : MonoBehaviour
{

    public int fingerNum = 0;
    public string hand = "L";
    private bool check = true;
    public static bool collsionStay = false; //�հ��� �浹���� �������� ǥ�� (�浹�ϸ鼭 �ָ��� ��� �����Ѵ� -> ����� ����)

   // public static bool[] collisionFinger = { false, false, false, false, false };

    void OnCollisionEnter(Collision c)
    {

        // Debug.Log(hand + "��" + fingerNum + "�հ��� ��ġ");
        // �� �հ����� ���𰡿� �浹�Ҷ� �ҷ����� �Լ�

        if (c.gameObject.CompareTag("block") && check)
        {

            collsionStay = true;
            //�ָ��� �� ���¿��� ��ϰ� �浹�� -> �̹� ����� ���� ����
            if (ExtendedFingerInfo.fistGesture == true)
            {
                Debug.Log("��� ��� �����̴� ��");
            }

            if (hand == "L" && fingerNum == 1 && check)
            {
                check = false;

                Debug.Log("thumb finger touch");

                gloveBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());

            }
            else if (hand == "L" && fingerNum == 2 && check)
            {
                check = false;

                Debug.Log("index finger touch");

                gloveBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());

            }
            else if (hand == "L" && fingerNum == 3 && check)
            {
                check = false;

                Debug.Log("middle finger touch");

                gloveBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }
            else if (hand == "L" && fingerNum == 4 && check)
            {
                check = false;


                Debug.Log("ring finger touch");
                gloveBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }
            else if (hand == "L" && fingerNum == 5 && check)
            {
                check = false;


                Debug.Log("pinky finger touch");
                gloveBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }

        }
        else if (c.gameObject.CompareTag("block"))
        {
            collsionStay = true;
        }
        else
            collsionStay = false;

    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(3.0f);
        check = true;
    }


}