using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class TouchDetector : MonoBehaviour
{

    //private Vector3 installPos;
    public GameObject block;
    public GameObject player;
    private bool check = true;

    public static bool touchMode = false;

    public void touchModeOn()
    {
        touchMode = true;
        Debug.Log("������ ������");
    }

    public void touchModeOff()
    {
        touchMode = false;
        Debug.Log("���� ����");
    }
 

    private void OnCollisionStay(Collision c)
    {

      

        if (c.gameObject.CompareTag("palette")&&check)  
            //�ȷ�Ʈ�� ��ġ�Ǿ��� ������ �������ִ� �����̸� 1.0f�� ��ٸ��� ���� ������ �׶� ��ġ��
        {
            Debug.Log("�ȷ�Ʈ" + check + touchMode);
            check = false;
            Debug.Log("�ȷ�Ʈ collision enter");
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
            //installPos = Vector3.Scale(Vector3Int.RoundToInt((hit.point + hit.normal.MultiplyVector(size * 0.5f)).DivideVector(size)), size);


            Vector3 installPos = player.gameObject.transform.position;

            Random rand = new Random();

            installPos.y += 2;
            installPos.z += (float)rand.NextDouble() * (4 - 2) + 2;
            installPos.x -= (float)rand.NextDouble() * (2 - 0.2f) + 0.2f;

            Renderer rend = block.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material;

            Instantiate(block, installPos, block.transform.rotation);

    

    }
}
