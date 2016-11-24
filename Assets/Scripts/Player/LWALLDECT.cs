using UnityEngine;
using System.Collections;

public class LWALLDECT : MonoBehaviour
{

    public bool lTrigger = false;

    public GameObject player;


    void Start()
    {

        player = GameObject.Find("PlayerCol");

    }

    void Update()
    {

        transform.position = new Vector3(player.transform.position.x - 0.05f, player.transform.position.y, 0);

    }

    void OnTriggerStay2D(Collider2D lCol)
    {

        lTrigger = true;

    }

}
