using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resource : MonoBehaviour
{
    TextMeshProUGUI resourceText;
 

    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
    
    }

    // Update is called once per frame
    void Update()
    {
       // resourceText.text = "텍스트 테스트";
    }
}
