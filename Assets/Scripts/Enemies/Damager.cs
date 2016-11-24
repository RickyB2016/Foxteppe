using UnityEngine;
using System.Collections;

public class Damager : MonoBehaviour
{

    public int dmgVal = 8;
    Vector2 knockback;

    void Start()
    {

        knockback = new Vector2(5, 2);

    }
}