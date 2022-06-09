using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Mining : MonoBehaviour
{
    public class BlockInfo
    {

        public static BlockInfo blockInfo = new BlockInfo();

        private int blockNum;
        private Color blockColor;


        public BlockInfo()
        {

        }

        public void setBlockInfo(int n)
        {




            Debug.Log(n + "block Info setting");

            blockNum = n;

            if (n == 1)
            {
                blockColor = Color.blue;
            }
            else if (n == 2)
            {
                blockColor = Color.red;
            }
            else if (n == 3)
            {
                blockColor = Color.black;
            }
            else if (n == 4)
            {
                blockColor = Color.grey;
            }
            else if (n == 5)
            {
                blockColor = Color.yellow;
            }
            else if (n == 6)
            {
                blockColor = Color.cyan;
            }
            else if (n == 7)
            {
                blockColor = Color.magenta;
            }
            else if (n == 8)
            {
                blockColor = Color.green;
            }
        }


        public Color getBlockColor()
        {
            return blockColor;
        }

        public int getBlockNum()
        {
            return this.blockNum - 1;
        }

        public void setBuildModeOn()
        {
            Mining.buildMode = true;
        }

        public void setMoveModeOn()
        {
            Mining.moveMode = true;
        }

    }




    public GameObject block;
    // public GameObject tempBlock;
    public LayerMask blockLayer;
    public Material[] materials;

    public static bool buildMode = false;
    public static bool moveMode = false;



    private RaycastHit hit;
    private Vector3 installPos;
    // private List<Vector3> beforePos = new List<Vector3>();




    private void Update()
    {


        if (moveMode == true && buildMode == false)
        {


            //print("moveMode ÀüÈ¯µÊ");

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction, out hit, 8, blockLayer))
            {

                Vector3 size = block.transform.lossyScale;
                installPos = Vector3.Scale(Vector3Int.RoundToInt((hit.point + hit.normal.MultiplyVector(size * 0.5f)).DivideVector(size)), size);


                if (Input.GetMouseButtonUp(0))
                {

                    print("µå·¡±×¿¡¼­ ¸¶¿ì½º¶« ÀüÈ¯µÊ");
                    moveMode = false;


                    Renderer rend = block.GetComponent<Renderer>();
                    rend.enabled = true;
                    rend.sharedMaterial = materials[BlockInfo.blockInfo.getBlockNum()];
                    Instantiate(block, installPos, block.transform.rotation);
                    buildMode = false;

                }

            }

        }




        if (buildMode == true)
        {


            if (Physics.Raycast(Camera.main.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction, out hit, 8, blockLayer))
            {

                Vector3 size = block.transform.lossyScale;
                installPos = Vector3.Scale(Vector3Int.RoundToInt((hit.point + hit.normal.MultiplyVector(size * 0.5f)).DivideVector(size)), size);




                if (Input.GetMouseButtonDown(0))
                {

                    Renderer rend = block.GetComponent<Renderer>();
                    rend.enabled = true;
                    rend.sharedMaterial = materials[BlockInfo.blockInfo.getBlockNum()];
                    Instantiate(block, installPos, block.transform.rotation);
                    buildMode = false;
                }

            }

        }





    }



    private void OnDrawGizmos()
    {
        if (hit.transform)
        {
            Gizmos.color = BlockInfo.blockInfo.getBlockColor();
            Gizmos.DrawWireCube(installPos, block.transform.lossyScale);
        }

    }


    //float distance = 10;

    /*    void OnMouseDrag()
        {

            if (buildMode == false)
            {
                print("Drag!!");


                if (Physics.Raycast(Camera.main.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction, out hit, 8, blockLayer))
                {

                    Vector3 size = block.transform.lossyScale;
                    installPos = Vector3.Scale(Vector3Int.RoundToInt((hit.point + hit.normal.MultiplyVector(size * 0.5f)).DivideVector(size)), size);

                    // Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

                    // Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);


                    // transform.position = objPosition;

                    transform.position = installPos;


                }

            }




        }*/


}

public static class Vector3Extensions
{
    public static Vector3 DivideVector(this Vector3 vector, Vector3 divideVector)
    {
        return new Vector3(vector.x / divideVector.x, vector.y / divideVector.y, vector.z / divideVector.z);

    }

    public static Vector3 MultiplyVector(this Vector3 vector, Vector3 multiplyVector)
    {
        return new Vector3(vector.x * multiplyVector.x, vector.y * multiplyVector.y, vector.z * multiplyVector.z);

    }
}