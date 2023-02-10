using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target"))
        {
            GameController.score++;
            Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}