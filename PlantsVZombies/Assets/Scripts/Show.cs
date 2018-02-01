using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{

    public float timp = 100f;

    public Text txt;
    void Update()
    {
        if (timp <= 0f)
        {
            FindObjectOfType<GameManager>().Win();
        }

        timp -= Time.deltaTime;
        timp = Mathf.Clamp(timp, 0f, Mathf.Infinity);
        txt.text = "Timp ramas: " + string.Format("{0:000.00}", timp);

    }
}
