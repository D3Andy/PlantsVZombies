using UnityEngine;

public class TunViata : MonoBehaviour {

    private float tunv = 5f;
    private int coef = 5;
    public GameObject tun;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Zombi")
        {
            tunv -= coef * Time.deltaTime;
            if (tunv <= 0)
            {
                Destroy(tun);
            }
        }
    }
}
