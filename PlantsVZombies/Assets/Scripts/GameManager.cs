using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool end = false;
    public GameObject winUI;
    public GameObject lostUI;
    public Button pause;

    public void Lost()
    {
        if (end == false)
        {
            lostUI.SetActive(true);
            end = true;
            pause.interactable = false;
            pause.enabled = false;
            pause.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            pause.GetComponentInChildren<Text>().color = Color.clear;
        }
    }

    public void Win()
    {
        if (end == false)
        {
            winUI.SetActive(true);
            end = true;
            pause.interactable = false;
            pause.enabled = false;
            pause.enabled = false;
            pause.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            pause.GetComponentInChildren<Text>().color = Color.black ;
        }
    }

    public void EndGame () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

		
	}

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
