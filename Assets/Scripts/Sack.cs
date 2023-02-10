using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sack : MonoBehaviour
{
    [SerializeField] float Force = 50f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce((transform.right * -1) * Force, ForceMode.Impulse);
    }
}
