using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetector : MonoBehaviour
{

    public int fingerNum=0;
    public string hand = "L";
    public bool check = true;

    private void Start()
    {
      
      
    }
    void OnCollisionEnter(Collision c)
    {

       // Debug.Log(hand + "손" + fingerNum + "손가락 터치");

        if (c.gameObject.CompareTag("block"))
        {
            //   Debug.Log("ThumbCollisionDetector OnCollidsionEnter");
            //Debug.Log(fingerNum);
            //Debug.Log(hand + "손" + fingerNum + "손가락 터치");

            if(hand=="L"&& fingerNum==1 && check)
            {
                check = false;

                Debug.Log("thumb finger touch");
                hapticBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());

            }
            else if (hand=="L" && fingerNum == 2 && check) //일단 왼손 검지일때 진동울리게함
            {
                check = false;
             
                Debug.Log("index finger touch");
                hapticBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());

            }
            else if(hand=="L" && fingerNum == 3 && check)
            {
                check = false;

                Debug.Log("middle finger touch");
                hapticBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }
            else if(hand=="L" && fingerNum == 4 && check)
            {
                check = false;

                Debug.Log("ring finger touch");
                hapticBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }
            else if (hand == "L" && fingerNum == 5 && check)
            {
                check = false;

                Debug.Log("pinky finger touch");
                hapticBluetoothManager.sendData(fingerNum.ToString());
                StartCoroutine(WaitForIt());
            }

        }

    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1.0f);
        check = true;
    }


}