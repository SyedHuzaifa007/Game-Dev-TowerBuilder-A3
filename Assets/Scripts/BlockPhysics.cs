using UnityEngine;

public class BlockPhysics : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float sway = Mathf.PerlinNoise(Time.time, transform.position.y) - 0.5f;
        Vector3 swayVector = new Vector3(sway, 0, sway);
        rb.AddForce(swayVector * Time.deltaTime * 10f, ForceMode.Impulse);
    }
}
