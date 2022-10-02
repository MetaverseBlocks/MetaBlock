using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetector : MonoBehaviour
{

    public int fingerNum=0;
    public string hand = "L";
    private bool check = true;


    void OnCollisionEnter(Collision c)
      {

         // Debug.Log(hand + "��" + fingerNum + "�հ��� ��ġ");
         // Debug.Log("ThumbCollisionDetector OnCollidsionEnter");

          if (c.gameObject.CompareTag("block") && check)
          {

            if (hand=="L"&& fingerNum==1 && check)
              {
                  check = false;

                  Debug.Log("thumb finger touch");
               
                  gloveBluetoothManager.sendData(fingerNum.ToString());
                  StartCoroutine(WaitForIt());

              }
              else if (hand=="L" && fingerNum == 2 && check) //�ϴ� �޼� �����϶� �����︮����
              {
                  check = false;

                  Debug.Log("index finger touch");
              
                  gloveBluetoothManager.sendData(fingerNum.ToString());
                  StartCoroutine(WaitForIt());

              }
              else if(hand=="L" && fingerNum == 3 && check)
              {
                  check = false;

                  Debug.Log("middle finger touch");
                  gloveBluetoothManager.sendData(fingerNum.ToString());
                  StartCoroutine(WaitForIt());
              }
              else if(hand=="L" && fingerNum == 4 && check)
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

      }

      IEnumerator WaitForIt()
      {
          yield return new WaitForSeconds(3.0f);
          check = true;
      }

         
}