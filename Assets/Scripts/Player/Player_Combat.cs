using UnityEngine;
using System.Collections;

public class Player_Combat : MonoBehaviour {

    public float HP = 100, MAXHP = 100;

    Rigidbody2D rb;

	void Start () {

        rb = GetComponent<Rigidbody2D>();

    }
	
	void Update () {
	
        if (HP > MAXHP)
        {

            HP = MAXHP;

        }

	}

    void OnTriggerEnter2D (Collider2D col)
    {

        if (col.tag == "Damage")
        {

            HP -= col.GetComponent<Damager>().dmgVal;

            //rb.velocity = new Vector2 (col.GetComponent<Damager>().knockback.x, col.GetComponent<Damager>().knockback.y);

        } else if (col.name == "HP_Upper")
        {

            MAXHP += 25;
            HP = MAXHP;
            Destroy(col.gameObject);

        } else if (col.name == "HP_Recoverer")
        {

            HP += 10;

        }

    }

}
