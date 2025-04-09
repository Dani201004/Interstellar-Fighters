using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }
}
