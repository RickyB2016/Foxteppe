using UnityEngine;
using System.Collections;

public class Fox_Animation : MonoBehaviour {

	Animator animator;

	public bool Grounded = false;
	public bool RightMov = false;
	public bool LeftMov = false;
	public bool NoHorizontalSpeed = false;
	public bool facingLeft = false, facingRight = true;

	public float horizontalSpeed;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Grounded = GameObject.Find ("PlayerCol").GetComponent<Player_Movement> ().onGround;
		horizontalSpeed = GameObject.Find ("PlayerCol").GetComponent<Player_Movement> ().hSpeed;

		animator.SetBool ("onGround", Grounded);
		animator.SetFloat ("hSpeed", horizontalSpeed);

		if ( horizontalSpeed != 0) {

			if (horizontalSpeed < 0) {

				RightMov = true;

			} else if (horizontalSpeed > 0) {

				LeftMov = true;

			}

		}


		animator.SetBool("LMoving", RightMov);
		animator.SetBool("RMoving", LeftMov);


		if (Input.GetKey (KeyCode.RightArrow)){

			facingLeft = true;
			facingRight = false;

		} if (Input.GetKey (KeyCode.LeftArrow)){

			facingRight = true;
			facingLeft = false;

		}
			
		if (horizontalSpeed == 0) {

			LeftMov = false;
			RightMov = false;

			NoHorizontalSpeed = true;

			animator.SetBool("NoHSpeed",NoHorizontalSpeed);

		}

		if (facingRight) {

			transform.localScale = new Vector3 (-0.25f, 0.25f, 0.25f);

		} else {

			transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);

		}
	}
}
