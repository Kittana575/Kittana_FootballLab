using Unity.VisualScripting;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] Vector3 velocity, spin;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            kick();
        }
        ApplyMagnusEffect();
    }

    void kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce,ForceMode.Force);
    }
}
