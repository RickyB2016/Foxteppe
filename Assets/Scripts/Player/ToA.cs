using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToA : MonoBehaviour
{
    public AudioClip song;

    void OnTriggerEnter2D(Collider2D col)
    {

        SceneManager.LoadScene("Area_A");
        GameObject.Find("PlayerCol").GetComponent<Player_Movement>().onGround = false;

        if (GameObject.Find("Music").GetComponent<AudioSource>().name == "0A")
        {

        }
        else
        {

            GameObject.Find("Music").GetComponent<AudioSource>().Stop();
            GameObject.Find("Music").GetComponent<AudioSource>().PlayOneShot(song, 1.0f);

        }

    }
}
