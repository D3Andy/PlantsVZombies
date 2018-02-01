using UnityEngine;

public class glontMove : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 100f;

    void Update()
    {
        Vector3 dir = new Vector3(0, 0, 1);
        rb.velocity = dir * speed * Time.deltaTime;
    }
}
