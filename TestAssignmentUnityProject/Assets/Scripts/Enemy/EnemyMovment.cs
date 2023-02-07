using UnityEngine;



public class EnemyMovment : MonoBehaviour
{
    public float speed = 10;
    public float changeDirectionInterval = 1;

    private Rigidbody rb;
    private Vector2 direction;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = Random.insideUnitCircle.normalized;
        timer = changeDirectionInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            direction = Random.insideUnitCircle.normalized;
            timer = changeDirectionInterval;
        }

        rb.AddForce(direction * speed, ForceMode.Force);
        if (rb.velocity.magnitude >= speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        changeDirectionInterval = 5;
        Vector2 normal = collision.GetContact(0).normal;
        direction = -normal;
    }
}
