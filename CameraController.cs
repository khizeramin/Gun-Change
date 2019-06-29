using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    
    private Vector3 offset;
    Vector3 rotation;
    private float yaw = 0.0F;    // Mouse rotaiton along the Y Axis;
    private float pitch = 0.0F;  // Mouse rotation along the X Axis; 
    
    private float horizontalMouseMotion;
    private float verticalMouseMotion;

    
    void Start()
    {   
        // Take the offset distance number, which is the distance is tner  oood hhh between the Camera and the player.      
          offset = transform.position - Player.transform.position;
    }
      
    //// LateUpdate: LateUpdate is called once per frame, after Update has finished. Any calculations that are 
    //// performed in Update will have completed when LateUpdate begins. A common use for LateUpdate would be a 
    //// following third-person camera. If you make your character move and turn inside Update, you can perform all camera movement 
    //// and rotation calculations in LateUpdate. This will ensure that the character has moved completely before the camera tracks its position.
    
    void LateUpdate()
    {    
        transform.position = Player.transform.position + offset;
        //MouseHandler();
    }
    
    //void MouseHandler()
    //{ 
             
    //    pitch += mouseSpinSpeedX * Input.GetAxis("Mouse X");
    //    yaw -= mouseSpinSpeedY * Input.GetAxis("Mouse Y"); 
           
    //    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
         
    //}
}
    //public float turnSpeed = 50f;

    //void MouseAiming()
    //{
    //    var rot = new Vector3(0f, 0f, 0f);
    //    // rotates Camera Left
    //    if (Input.GetAxis("Mouse X") < 0)
    //    {
    //        rot.x -= 1;
    //    }

    //    // rotates Camera Left
    //    if (Input.GetAxis("Mouse X") > 0)
    //    {
    //        rot.x += 1;
    //    }

    //    // rotates Camera Up
    //    i iif (Input.GetAxis("Mouse Y") < 0)
    //    {
    //        rot.z -= 1;
    //    }
    //    // rotates Camera Down
    //    if (Input.GetAxis("Mouse Y") > 0)
    //    {
    //        rot.z += 1;
    //    }

    //    transform.Rotate(rot, turnSpeed * Time.deltaTime);
    //}
    
    //void KeyboardMovement()
    //{
    //    var sensitivity = 0.01f;
    //    var movementAmount = 0.5f;
    //    var movementVector = new Vector3(0f, 0f, 0f);
    //    var hMove = Input.GetAxis("Horizontal");
    //    var vMove = Input.GetAxis("Vertical");
    //    // left arrow
    //    if (hMove < -sensitivity) movementVector.x = -movementAmount;
    //    // right arrow
    //    if (hMove > sensitivity) movementVector.x = movementAmount;
    //    // up arrow
    //    if (vMove < -sensitivity) movementVector.z = -movementAmount;
    //    // down arrow
    //    if (vMove > sensitivity) movementVector.z = movementAmount;
    //    // Using Translate allows you to move while taking the current rotation into consideration
    //    transform.Translate(movementVector);
    //}

    //void Update()
    //{
    //    MouseAiming();
    //    KeyboardMovement();
    //}


