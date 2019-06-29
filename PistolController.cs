using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolController : MonoBehaviour
{
    Animator shotGunAnimatior;
    public float gunSpeed;

    void Start()
    {
        shotGunAnimatior = GetComponent<Animator>();
        Debug.Log(shotGunAnimatior.name);
        //shotGunAnimatior.enabled = false;    
        shotGunAnimatior.speed = 0.0f;
        //gameObject.SetActive(false);
       
    }

    void Update()
    {
        GunAnimatorPistol();
    }

    public void RenderTheGun()
    {
        gameObject.SetActive(true);
    }


    public void GunAnimatorPistol()
    {
        gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != shotGunAnimatior)
            {
                //shotGunAnimatior.enabled = true;
                shotGunAnimatior.speed = gunSpeed;
                //layer	The layer index, second argumant in Play method. If layer is -1, it plays the first state with the given state name or hash.
                shotGunAnimatior.Play("pistol", -1, 0.05f);
                
            }

        }
    }

}
