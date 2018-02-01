using UnityEngine;

public class EndTrig : MonoBehaviour {

    public GameManager game;

    void OnTriggerEnter()
    {
        game.Lost();
    }
	
}
