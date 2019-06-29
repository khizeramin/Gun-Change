using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunController : MonoBehaviour
{
    Animator shotGunAnimatior;
    public float gunSpeed;
    public float speed;
    Vector3 movement;
    Vector3 forwardMotion;

    public Camera FPSCamera;   
    public float Damage;
    public float Range = 500F;
    void Start() 
    {   
        
        shotGunAnimatior = GetComponent<Animator>();
        Debug.Log(shotGunAnimatior.name);    
        //shotGunAnimatior.enabled = false;    
        shotGunAnimatior.speed = 0.0f;
    }
    
    void Update()
    {
        GunAnimatorShotGun();    
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); 

        movement = new Vector3(horizontal, 0.0F, vertical);
        //forwardMotion = movement;
        GetComponent<Rigidbody>().velocity = movement * speed; 
    }
    public void RenderTheGun()
    {
        gameObject.SetActive(true);
    }
    
    public void GunAnimatorShotGun()
    {       
        RaycastHit hit;
        //gameObject.SetActive(false);
        if (Input.GetButtonDown("Fire1"))
        {
            

            if (null != shotGunAnimatior)
            {
                //shotGunAnimatior.enabled = true;
                shotGunAnimatior.speed = gunSpeed;
                //layer	The layer index, second argumant in Play method. If layer is -1, it plays the first state with the given state name or hash.
                shotGunAnimatior.Play("gunshot", -1, 0.05f);
                
            }
            // This entire Raycast function returns bool so we can use if statement here.
            if(Physics.Raycast(FPSCamera.transform.position, FPSCamera.transform.forward, out hit, Range))
            {
                BaronOfHellController BoHController = hit.transform.GetComponent<BaronOfHellController>();
                BoHController.BoHHealth(Damage);
                
            }
                      
            GetComponent<AudioSource>().Play();
        }
    }
  
}
 