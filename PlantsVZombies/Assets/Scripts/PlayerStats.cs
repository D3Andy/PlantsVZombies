using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int sun;
    private int startsun = 300;
    private float count = 0;
    public static int nrs;
	void Start () {
        sun = startsun;	
	}

    void Update()
    {
        count += Time.deltaTime;
        
        if (count > 15f)
        { 
            sun =sun + 25 + nrs*50 ;
            count = 0f ;
        }
    }
}
