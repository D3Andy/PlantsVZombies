using System.Collections;
using System.Collections;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bullet;
    public GameObject glontcreat;
    public GameObject planta;
    
    public float timeleft = 0f;
    // Update is called once per frame
    void Update () {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Zombi");
        foreach( var obj in objs )
            if( planta.transform.position.z < obj.transform.position.z )
             if ( (planta.transform.position.x < obj.transform.position.x + 0.2f &&
                planta.transform.position.x > obj.transform.position.x - 0.2f ) ||
                (planta.transform.position.x < obj.transform.position.x - 0.2f &&
                planta.transform.position.x > obj.transform.position.x + 0.2f))
                {
                 if ( timeleft <= 0f )
                    {
                       GameObject temp=Instantiate(bullet, glontcreat.transform.position, glontcreat.transform.rotation);
                       timeleft = 2.5f;
                       Destroy(temp,5f);
                    }
             }

        timeleft -= Time.deltaTime;
    }


}
