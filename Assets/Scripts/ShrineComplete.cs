using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShrineComplete : MonoBehaviour {

    Bones boneR;

	void Awake()
    {

        boneR = GameObject.Find("PlayerCol").GetComponent<Bones>();    

        if (boneR.flagBoneA && boneR.flagBoneB&& boneR.flagBoneC)
        {

            SceneManager.LoadScene("Complete");

        }

    }
}
