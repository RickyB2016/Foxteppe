using UnityEngine;
using System.Collections;

public class Player_Combat : MonoBehaviour {

    public float HP = 100, MAXHP = 100;

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter (Collider col)
    {

        if (col.tag == "Damage")
        {

            HP -= col.GetComponent<Damager>().dmgVal;

        } else if (col.tag == "MaxHPUp")
        {

            //MAXHP += col.GetComponent<Bonus>().hpInc;

        }

    }

}
