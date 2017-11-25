using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rigidbody;
    Animator animator;
    public float speed;

	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	void FixedUpdate () {

            float vAxis = Input.GetAxis("Vertical") * speed;
            vAxis *= Time.deltaTime;
            Vector3 movement = new Vector3(0, vAxis, 0);
            rigidbody.MovePosition(transform.position + movement);

            if(vAxis != 0)
            {
                animator.SetInteger("State", 1);
            }
            else
            {
                animator.SetInteger("State", 0);
            }
      
	}
}
