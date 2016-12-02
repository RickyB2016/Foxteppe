using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalScreen : MonoBehaviour {

    public AudioClip song;

    int countdown = 600;

	void Awake()
    {

        Destroy(GameObject.Find("PlayerCol"));
        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
        GameObject.Find("Music").GetComponent<AudioSource>().PlayOneShot(song, 1.0f);

    }

    void Update()
    {

        countdown--;

        if (countdown == 0)
        {

            SceneManager.LoadScene("Main Menu");

        }

    }

}
