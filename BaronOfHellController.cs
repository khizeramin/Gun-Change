using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaronOfHellController : MonoBehaviour
{
    public float BaronSpeed;

    private Animator BaronAnim;
    // Gameobjects for the Enemy "Baron of Hell"
    public GameObject Baron;
    // A transform component for BOH Spawning.
    public Transform spawner;

    
    //public float currentPosition;
    public float transitPosition;
    private float elapsedTime;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
        //transform.position.y = transform.position;
        GetComponent<AudioSource>().Play();
        BaronAnim = GetComponent<Animator>();
            
    }

    // Update is called once per frame
    void Update()
    {
        
            elapsedTime += Time.deltaTime;
            if (elapsedTime < 3F)
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * BaronSpeed * Time.deltaTime;
                //elapsedTime = 0;
            } 
                    
            if (elapsedTime > 4F)
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * -BaronSpeed * Time.deltaTime;
                if (elapsedTime > 8F)
                {
                    elapsedTime = 0;                     
                }
            }    
    }

    public void BoHHealth(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Disapear();
            BaronAnim.SetBool("isRunning", true);
            StartCoroutine(BaronWaitController());
            BaronAnim.SetBool("isRunning", false);
        }
    }
     
    void Disapear()
    {
        //upper anam eis ther 
        Destroy(gameObject);
        //Debug.Log(health);
        //for (int spawn = 0; spawn < spawner.Length; spawn++)
        //{
            
            Instantiate(Baron, spawner.position, spawner.rotation);
        //}

    }

    IEnumerator BaronWaitController()
    {
        yield return new WaitForSeconds(5);
    }
}
