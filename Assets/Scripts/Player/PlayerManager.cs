using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public static GameObject PlayerCol;

    public static bool foxExists = false;

    void Awake()
    {

        if (foxExists)
        {

            Destroy(gameObject);

        } else
        {

            foxExists = true;

        }

       /* if(PlayerCol == null)
        {

            DontDestroyOnLoad(gameObject);
            PlayerCol = this.gameObject;

        } else if (PlayerCol != this.gameObject)
        {

            Destroy(gameObject);

        }*/

    }

}
