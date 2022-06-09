using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    Renderer rend;
    int n;
    float clickTime = 0;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        string blockColor = rend.sharedMaterial.name;


        if (blockColor.Equals("Block-Blue"))
            n = 1;
        else if (blockColor.Equals("Block-Red"))
            n = 2;
        else if (blockColor.Equals("Block-black"))
            n = 3;
        else if (blockColor.Equals("Block-grey"))
            n = 4;
        else if (blockColor.Equals("Block-yellow"))
            n = 5;
        else if (blockColor.Equals("Block-cyan"))
            n = 6;
        else if (blockColor.Equals("Block-magenta"))
            n = 7;



    }

    void OnMouseDrag()
    {

        print("Drag!!");
        clickTime += Time.deltaTime;

        if (clickTime > 2)
        {

            Mining.BlockInfo.blockInfo.setBlockInfo(n);

            if (Mining.moveMode != true)
            {
                Mining.BlockInfo.blockInfo.setMoveModeOn();

                //gameObject.SetActive(false);
                Destroy(gameObject);
                clickTime = 0;
            }

        }

        return;


    }

}
