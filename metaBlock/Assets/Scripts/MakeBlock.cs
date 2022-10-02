using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MakeBlock : MonoBehaviour
{

    private Vector3 installPos;
    public GameObject block;
    public GameObject player;


    //public Material[] materials;
    public Material material;

    public static bool clickMode = false;

    public void clickModeOn()
    {
        clickMode = true;
        Debug.Log("°ËÁö¸¸ ÆîÃÄÁü");
    }

    public void clickModeOff()
    {
        clickMode = false;
        Debug.Log("°ËÁö Á¢ÇöÁü");
    }

    public void makeBlockInSky()
    {
        if (clickMode == false)
            return;
        else
        {

            AudioSource sound= GetComponent<AudioSource>();
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



}