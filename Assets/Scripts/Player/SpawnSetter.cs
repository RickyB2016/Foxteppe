using UnityEngine;
using System.Collections;

public class SpawnSetter : MonoBehaviour {


    void Awake()
    {

        if (GameObject.Find("PlayerCol").GetComponent<Teleporter>().telValue == 1)
        {

            GameObject.Find("PlayerCol").transform.position = GameObject.Find("StartA").transform.localPosition;

        }
        else if (GameObject.Find("PlayerCol").GetComponent<Teleporter>().telValue == 2)
        {

            GameObject.Find("PlayerCol").transform.position = GameObject.Find("StartB").transform.localPosition;

        }
        else if (GameObject.Find("PlayerCol").GetComponent<Teleporter>().telValue == 3)
        {

            GameObject.Find("PlayerCol").transform.position = GameObject.Find("StartC").transform.localPosition;

        }
        else if (GameObject.Find("PlayerCol").GetComponent<Teleporter>().telValue == 4)
        {

            GameObject.Find("PlayerCol").transform.position = GameObject.Find("StartD").transform.localPosition;

        }

    }
}
