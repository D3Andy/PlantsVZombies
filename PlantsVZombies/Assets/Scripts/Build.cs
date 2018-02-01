using UnityEngine;

public class Build : MonoBehaviour {

    public static Build instance;

    public GameObject tun;
    public GameObject nuca;
    public GameObject soare;

    private Plante tobuild;
    Vector3 offsett = new Vector3(0f, -0.167f, 0f);
    Vector3 offsetn = new Vector3(-0.5f, 0.75f, -0.5f);

    private void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }

    public bool CanBuild {  get { return tobuild != null;  } }

    public void Selectobjtobuild(Plante planta)
    {
        tobuild = planta;
    }

    public void Buildon(Node node)
    {
        GameObject aux = null; ;
        if (PlayerStats.sun < tobuild.cost)
            return;
        PlayerStats.sun -= tobuild.cost;
        
        if (tobuild.planta == nuca)
            aux = (GameObject)Instantiate(tobuild.planta, node.transform.position + offsetn, node.transform.rotation);
        else
            aux = (GameObject)Instantiate(tobuild.planta, node.transform.position + offsett, node.transform.rotation);

        if (tobuild.planta == soare)
            PlayerStats.nrs++;
        node.planta = aux;
    }


}
