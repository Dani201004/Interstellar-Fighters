using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public float rotationSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * rotationSpeed;
    }
}
