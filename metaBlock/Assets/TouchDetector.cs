using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using TMPro;

public class TouchDetector : MonoBehaviour
{

    //private Vector3 installPos;
    public GameObject block;
    public GameObject player;
    private bool check = true;

    public TextMeshProUGUI resourceText;

    private void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.CompareTag("palette")&&
            check&& ExtendedFingerInfo.clickGuesture)  
            //검지만 펼쳐진 클릭제스쳐이고 팔레트에 터치되었고
            //1.0f초 기다림이 끝난 상태일 때
        {
          
            check = false;
            Debug.Log("팔레트 collision enter");
            gloveBluetoothManager.sendData("2");
            StartCoroutine(WaitForIt());
            makeBlockInSky(c.gameObject.GetComponent<Renderer>().material);

        }
    }


    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1.0f);
        check = true;
    }


    void makeBlockInSky(Material material)
    {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();

            Vector3 size = block.transform.lossyScale;
          
            Vector3 installPos = player.gameObject.transform.position;

            Random rand = new Random();

            installPos.y += 2;
            installPos.z += (float)rand.NextDouble() * (4 - 2) + 2;
            installPos.x -= (float)rand.NextDouble() * (2 - 0.2f) + 0.2f;

            Renderer rend = block.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material;
            
            Instantiate(block, installPos, block.transform.rotation);
            string[] name = material.name.Split('(');
            Debug.Log("Make "+name[0]);
    

    }
}
