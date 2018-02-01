using UnityEngine;

public class Shop : MonoBehaviour {

    Build build;

    public Vector3 offsett = new Vector3(0f, -0.167f, 0f);
    public Vector3 offsetn = new Vector3(-1f, -1f, -1f);

    public Plante tun;
    public Plante nuca;
    public Plante soare;
    public Plante dtun;

    void Start()
    {
        build = Build.instance;
    }

    public void SelectTun()
    {
        build.Selectobjtobuild(tun);
    }

    public void SelectSoare()
    {
        build.Selectobjtobuild(soare);
    }

    public void SelectNuca()
    {
        build.Selectobjtobuild(nuca);
    }

}
