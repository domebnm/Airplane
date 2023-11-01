using UnityEngine;

public class Enemy : MonoBehaviour, Unit
{
    [SerializeField] float health;
    [SerializeField] float speed;

    public void MyStart()
    {
        Gun[] gun = GetComponentsInChildren<Gun>();
        for (int i = 0; i < gun.Length; i++) { gun[i].enabled = true; }
    }
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
    public void getDamage(float damage)
    {
        health -= damage;
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
