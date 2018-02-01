using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Sun : MonoBehaviour {

    public Text sun;
	
	// Update is called once per frame
	void Update () {
        sun.text = "Sun: " + PlayerStats.sun;

	}
}
