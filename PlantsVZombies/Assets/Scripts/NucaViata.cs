using UnityEngine;

public class NucaViata : MonoBehaviour {

    private float nucav = 100f;
    private int coef = 3;
    public GameObject nuca;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Zombi")
        {
            nucav -= coef * Time.deltaTime;
            if (nucav <= 0)
            {
                Destroy(nuca);
            }
        }
    }
}
