using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float maxspeed;
    public float belok;
    private Vector3 direction;
    private CharacterController controller;
    Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*direction.z = speed;*/
        if (speed < maxspeed)
            speed += 0.1f * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * belok);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * belok);
        }
    }

    private void FixedUpdate()
    {
        /*controller.Move(direction * Time.fixedDeltaTime);*/
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
