using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public Transform target; //drag and stop player object in the inspector
    public float within_range;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        //get the distance between the player and enemy (this object)
        float dist = Vector3.Distance(target.position, transform.position);
        //check if it is within the range you set
        if (dist <= within_range)
        {
            //move to target(player) 
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
    }
}