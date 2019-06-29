using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BOHWalkScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    private GameObject[] RandomMotionPoints;
    private NavMeshAgent MotionAgent;
    public Transform[] target;
    //public Transform BaronPosition;
    private float speed;
    Vector3 Distance;
    public float newPosition;
    
    
    void Start()
    {
        //There is no need for speed as the speed is automatically is provided by the engine itself. 
        MotionAgent = this.GetComponent<NavMeshAgent>();
        //RandomMotionPoints = GameObject.FindGameObjectsWithTag("RandomCubeTag");  
        

    }    
    // Update is called once per frame
    void Update()
    {   
        
        BOHWalkMotion();  
    }
    public void BOHWalkMotion()
    {
        
       
        
        //if (MotionAgent.hasPath == false)
        //{
        //int randomPoints = Random.Range(0, RandomMotionPoints.Length + 1);
        //MotionAgent.Warp(RandomMotionPoints[randomPoints].transform.position);
        //MotionAgent.SetDestination(RandomMotionPoints[randomPoints].transform.position);

        //} 
       
       // MotionAgent.SetDestination(target.position);
//      name is ReadOnlyCollectionBase is zuler nam is per ss
        //  inüut.s  iis rer  iiriostrm earteh´ 
            // BOH would would towards the player
        // if (BOH < 50)
            // Stop BOH and turn on BOH Plasma attack sprite
        // if (BOH < 10)
            // Turn ON BOH physical assault sprite   
            
    } 
    
    
} 
    