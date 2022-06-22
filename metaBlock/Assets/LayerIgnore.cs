using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerIgnore : MonoBehaviour
{
    public LayerMask Block;
    public LayerMask AttachUI;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(Block, AttachUI, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
