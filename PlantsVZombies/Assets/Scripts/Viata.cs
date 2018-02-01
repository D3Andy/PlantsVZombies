using UnityEngine;

public class Viata : MonoBehaviour {

    public int viata = 100;
    public GameObject zombi;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Glont")
        {
            viata-=20;
            if( viata <= 0 )
            {
                Destroy(zombi);
            }
        }
    }
}
