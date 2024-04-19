using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnimator;
    public Rigidbody2D warriorRB;
    public int speed = 5;
    public int jumpForce = 15;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerAnimator.SetBool("r", true);
            playerAnimator.SetBool("i", false);
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnimator.SetBool("r", true);
            playerAnimator.SetBool("i", false);
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnimator.SetTrigger("j");
            warriorRB.AddForce(Vector2.up * jumpForce);

        }
        if (Input.anyKey == false)
        {
            playerAnimator.SetBool("i", true);
            playerAnimator.SetBool("r", false);
        }
    }
}
