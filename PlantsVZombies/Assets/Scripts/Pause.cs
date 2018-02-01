using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public Button pause;
    public GameObject ui;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
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
            pause.interactable = false;
            pause.enabled = false;
            pause.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            pause.GetComponentInChildren<Text>().color = Color.clear;
        }
        else
        {
            Time.timeScale = 1f;
            pause.interactable = true;
            pause.enabled = true;
            pause.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
            pause.GetComponentInChildren<Text>().color = Color.black;
        }
    }

    public void tryagain()
    {
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   

}
