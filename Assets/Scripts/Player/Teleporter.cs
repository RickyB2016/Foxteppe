using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

    public int telValue;

    void OnTriggerEnter2D(Collider2D col) {

        if (col.name == "ExitA"){

                telValue = 1;

        } else if (col.name == "ExitB")
        {
            
            telValue = 2;

        } else if (col.name == "ExitC")
        {

            telValue = 3;

        }else if (col.name == "ExitD")
        {

            telValue = 4;

        }

    }
}
