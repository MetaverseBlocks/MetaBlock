using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{



    // To setup object for this script:
    /* Create player object.
     * Child game camera to player.
     * Assign player to own layer. 
     * Remove player's layer from the camera's culling mask.
     * Add CharacterController component to player.
     * Add this script to player and set variables.
     */


    // Cam look variables.
    [SerializeField]
    private float rotSpeedX; // Mouse X sensitivity control, set in editor.
    [SerializeField]
    private float rotSpeedY; // Mouse Y sensitivity control, set in editor.

    [SerializeField]
    private float rotDamp; // Damping value for camera rotation.

    //private float mY = 0f; // Mouse X.
    //private float mX = 0f; // Mouse Y.


    // Player move variables.

    [SerializeField]
    private float walkSpeed; // Walk (normal movement) speed, set in editor.
  
    private float currentSpeed; // Stores current movement speed.

    private CharacterController cc; // Reference to attached CharacterController.

    [SerializeField]
    private GameObject playerCamera; // Player cam, set in editor.

    public GameObject LeapMotion;

    private void Start()
    {
     //   cc = GetComponent<CharacterController>();
        currentSpeed = walkSpeed;
    }

    private void LateUpdate()
    {
        /*


        // Get mouse axis.
        mX += Input.GetAxis("Mouse X") * rotSpeedX * (Time.deltaTime * rotDamp);
        mY += -Input.GetAxis("Mouse Y") * rotSpeedY * (Time.deltaTime * rotDamp);

        // Clamp Y so player can't 'flip'.
        mY = Mathf.Clamp(mY, -80, 80);

        // Adjust rotation of camera and player's body.
        // Rotate the camera on its X axis for up / down camera movement.
        playerCamera.transform.localEulerAngles = new Vector3(mY, 0f, 0f);
        // Rotate the player's body on its Y axis for left / right camera movement.
        transform.eulerAngles = new Vector3(0f, mX, 0f);

        // Get Hor and Ver input.
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        // Set speed to walk speed.
        currentSpeed = walkSpeed;

        // Get new move position based off input.
        Vector3 moveDir = (transform.right * hor) + (transform.forward * ver);

        // Move CharController. 
        // .Move will not apply gravity, use SimpleMove if you want gravity.
        //cc.Move(moveDir * currentSpeed * Time.deltaTime);
        */

        currentSpeed = walkSpeed;


        if (Input.GetKey(KeyCode.U))
            transform.Translate(Vector3.up * currentSpeed / 20);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.down * currentSpeed / 20);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * currentSpeed / 20);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * currentSpeed / 20);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * currentSpeed / 20);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * currentSpeed / 20);

        /*

        if (Input.GetKey(KeyCode.S))
        {
            if (CollisionDetector.data_stream.IsOpen)
            {
                CollisionDetector.data_stream.Close();
                Debug.Log("시리얼닫기");
            }
            else
            {
                Debug.Log("시리얼안열려있음");
            }
        }

        if (Input.GetKey(KeyCode.O))
        {
            if (CollisionDetector.data_stream.IsOpen)
            {
                Debug.Log("시리얼열려있음");
            }
            else
            {
                CollisionDetector.data_stream.Open();
                Debug.Log("시리얼열기");
            }

        }*/

    }





}