using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    private Renderer rend;
    public GameObject planta;

    
    public Color hovercolor;
    public Color startcolor;
    

    Build build;

	void Start () {

        rend = GetComponent<Renderer>();
        startcolor = rend.material.color;
        build = Build.instance;
	}

    void OnMouseEnter()
    {
        if ( !build.CanBuild)
            return;
        rend.material.color = hovercolor;
    }
    void OnMouseExit()
    {
        rend.material.color = startcolor;
    }

    private void OnMouseDown()
    {
        if ( !build.CanBuild )
            return;

        if( planta != null)
        {
            return;
        }

        build.Buildon(this);
        
    }
}
