using UnityEngine;
using System.Collections;

public class DestroyIfer : MonoBehaviour {

    void Start()
    {

        if (this.name == "DJ_Upgrader" && GameObject.Find("PlayerCol").GetComponent<Player_Movement>().maxJumpCount == 2)
        {

            Destroy(gameObject);

        }
        else if (this.name == "boneA" && GameObject.Find("PlayerCol").GetComponent<Bones>().flagBoneA == true)
        {

            Destroy(gameObject);

        }
        else if (this.name == "AD_Upgrader" && GameObject.Find("PlayerCol").GetComponent<Player_Movement>().maxAirDashCount == 1)
        {

            Destroy(gameObject);

        } else if (this.name == "boneB" && GameObject.Find("PlayerCol").GetComponent<Bones>().flagBoneB == true)
        {

            Destroy(gameObject);

        }
        else if (this.name == "boneC" && GameObject.Find("PlayerCol").GetComponent<Bones>().flagBoneC == true)
        {

            Destroy(gameObject);

        }

    }

}
