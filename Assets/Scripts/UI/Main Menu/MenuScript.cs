using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Canvas optionsMenu;
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public Button optionsText;


	// Use this for initialization
	void Start () 
    {
	
        quitMenu = quitMenu.GetComponent<Canvas>();
        optionsMenu = optionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        optionsText = optionsText.GetComponent<Button>();
        optionsMenu.enabled = false;
        quitMenu.enabled = false;
    }
	
    public void OptionsPress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = true;
		optionsText.enabled = false;
    }

    public void ExitPress()
    {

        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionsMenu.enabled = false;
		optionsText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Shrine");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
