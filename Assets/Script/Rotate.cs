using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private Vector3 AngularV;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.angularVelocity = AngularV;
    }
}
