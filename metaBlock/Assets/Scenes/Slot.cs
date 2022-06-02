using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Button b1, b2, b3, b4, b5, b6, b7/*, b8*/;
    public GameObject tempBlock;
    public Material[] materials;
    public LayerMask UILayer;
    private RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {


        b1.onClick.AddListener(() => btnClick(1));
        b2.onClick.AddListener(() => btnClick(2));
        b3.onClick.AddListener(() => btnClick(3));
        b4.onClick.AddListener(() => btnClick(4));
        b5.onClick.AddListener(() => btnClick(5));
        b6.onClick.AddListener(() => btnClick(6));
        b7.onClick.AddListener(() => btnClick(7));
       // b8.onClick.AddListener(() => btnClick(8));

    }

    // Update is called once per frame
    void Update()
    {

        /*if (Physics.Raycast(Camera.main.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction, out hit, Mathf.Infinity, UILayer))
        {

            Debug.Log(hit);


            if (Input.GetMouseButtonDown(0))
            {


                Debug.Log(hit.transform.gameObject);
            }

        }*/


        //   GameObject obj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        //  Debug.Log(obj);


        RaycastHit hitInfo;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo, float.MaxValue, UILayer))
        {
            Debug.Log(hit);

        }

        if (Input.GetMouseButtonDown(0))
        {

            if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                Debug.Log("UIŬ����");
            }
            else
            {
                Debug.Log("UI���� Ŭ����");
            }
        }



    }

    public void OnMouseDown()
    {
        if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
        {
            Debug.Log("UIŬ����");
        }
        else
        {
            Debug.Log("UI���� Ŭ����");
        }
            return;
    }

    void btnClick(int n)
    {


        Mining.BlockInfo.blockInfo.setBlockInfo(n);

        Renderer rend = tempBlock.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[Mining.BlockInfo.blockInfo.getBlockNum()];

        //tempBlock.SetActive(true);  
        //����� ������������ . ������� ������ ������Ҹ� �д�. 
        // 

        Mining.BlockInfo.blockInfo.setBuildModeOn();





    }




}
