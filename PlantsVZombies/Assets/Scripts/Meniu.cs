﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Meniu : MonoBehaviour {

	public void StartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
		
	}
}
