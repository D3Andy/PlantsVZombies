using UnityEngine;

public class ZMove : MonoBehaviour {

    public float speed = 3.5f;
    public Rigidbody rb;
	void Update () {
        Vector3 dir = new Vector3(0, 0, -1);
        rb.velocity = dir * speed * Time.deltaTime;
    }

}
