using UnityEngine;

public class SpellProjectile : MonoBehaviour
{
    public Rigidbody rb;
    public float flyingSpeed;
    public GameObject explosionParticle;
    public float PushingForce;
    // Start is called once before theng first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        rb.MovePosition(transform.position + transform.forward * flyingSpeed * Time.deltaTime);



    }
    void OnTriggerEnter(Collider other)
    {
        Vector3 direction = other.transform.position - transform.position;
        other.GetComponent<Rigidbody>().AddForce(direction*PushingForce, ForceMode.Impulse);
        Instantiate(explosionParticle,transform.position,Quaternion.identity); 
        Destroy(gameObject);
    }



}
