using UnityEngine;

public class Gcollision : MonoBehaviour {

    public GameObject hit;

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.collider.tag == "Zombi")
        {
            Destroy(hit);
        }
    }

}
