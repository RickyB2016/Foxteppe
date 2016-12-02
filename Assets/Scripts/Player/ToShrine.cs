using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToShrine : MonoBehaviour {

    public AudioClip song;

    void OnTriggerEnter2D(Collider2D col)
    {

        SceneManager.LoadScene("Shrine");
        GameObject.Find("PlayerCol").GetComponent<Player_Movement>().onGround = false;
        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
        GameObject.Find("Music").GetComponent<AudioSource>().PlayOneShot(song, 1.0f);
    }
}
