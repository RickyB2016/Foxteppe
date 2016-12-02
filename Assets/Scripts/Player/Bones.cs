using UnityEngine;
using System.Collections;

public class Bones : MonoBehaviour {

    public bool flagBoneA = false, flagBoneB = false, flagBoneC = false;


	void OnTriggerEnter2D (Collider2D col)
    {

        if (col.name == "boneA")
        {

            flagBoneA = true;
            Destroy(col.gameObject);

        } else if (col.name == "boneB")
        {

            flagBoneB = true;
            Destroy(col.gameObject);

        }
        else if (col.name == "boneC")
        {

            flagBoneC = true;
            Destroy(col.gameObject);

        }

    }
}
