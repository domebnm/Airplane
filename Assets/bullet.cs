using UnityEngine;

public class bullet : MonoBehaviour
{
    float speed;
    float damage;

    private void Start()
    {
        Destroy(gameObject, 20f);
    }
    public void Set(float damage, float speed)
    {
        this.damage = damage;
        this.speed = speed;
    }
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Unit>() != null)
        {
            collision.GetComponent<Unit>().getDamage(damage);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
