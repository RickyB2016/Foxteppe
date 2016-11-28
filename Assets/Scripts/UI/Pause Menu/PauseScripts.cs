using UnityEngine; 
using UnityEngine.SceneManagement;

public class PauseScripts : MonoBehaviour {

    public GameObject ui;

	// Update is called once per frame
	
  void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
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
        }
        else
        {
            Time.timeScale = 1f;    
        }
    }

    public void Quit () 
    {
        SceneManager.LoadScene ("Scene Name");
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene("Main Menu");
    }

}
