// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    new public Rigidbody rigidbody;
    public Transform player;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;

    public float moveBorder = 7.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0,0,forwardforce * Time.deltaTime);

        if (player.position.x <= moveBorder && player.position.x >= -moveBorder)
        {
            if (Input.GetKey("d"))
            {
                rigidbody.AddForce(sidewaysforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
            }
            else if (Input.GetKey("a"))
            {
                rigidbody.AddForce(-sidewaysforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
            }
        }
    }
}
