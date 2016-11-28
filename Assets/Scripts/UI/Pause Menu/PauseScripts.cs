using UnityEngine; 
using UnityEngine.SceneManagement;

public class PauseScripts : MonoBehaviour {

    public GameObject ui;
	
    void Awake ()
    {

        Toggle();

    }

    void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
                Toggle();
            
        }
	
	}

    public void Toggle()
    {

        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        } else

        {
            Time.timeScale = 1f;    
        }

    }

    public void Quit () 
    {
        SceneManager.LoadScene ("Scene Name");
    }

    public void ReturnToMenu(){

        GameObject.Find("PlayerCol").GetComponentInChildren<AudioListener>().enabled = false;
        SceneManager.LoadScene("Main Menu");
        Destroy(GameObject.Find("PlayerCol"));
    }

}
