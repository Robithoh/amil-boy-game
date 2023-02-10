using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SackSpawner : MonoBehaviour
{
    [SerializeField] GameObject SackSpawn;
    [SerializeField] GameObject sack;
    public float fireRate;
    private float nextFire = 0.0F;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && Time.time > nextFire)
        {
            Instantiate(sack, SackSpawn.transform.position, SackSpawn.transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
}
