using UnityEngine;

public class SpellProjectile : MonoBehaviour
{
    public Rigidbody rb;
    public float flyingSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + transform.forward * flyingSpeed * Time.deltaTime);
    }
}
