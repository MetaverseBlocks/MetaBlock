using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetector : MonoBehaviour
{

    public int fingerNum = 0;
    public string hand = "L";
    private bool check = true;
    public static bool collsionStay = false; //손가락 충돌중인 상태인지 표시 (충돌하면서 주먹을 쥐기 시작한다 -> 블록을 잡음)

   // public static bool[] collisionFinger = { false, false, false, false, false };

    void OnCollisionEnter(Collision c)
    {

        // Debug.Log(hand + "손" + fingerNum + "손가락 터치");
        // 각 손가락이 무언가에 충돌할때 불러지는 함수

        if (c.gameObject.CompareTag("block") && check)
        {

            collsionStay = true;
            //주먹을 쥔 상태에서 블록과 충돌중 -> 이미 블록을 잡은 상태
            if (ExtendedFingerInfo.fistGesture == true)
            {
                Debug.Log("블록 잡고 움직이는 중");
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