using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] float damage;
    [SerializeField] float speed;
    [SerializeField] GameObject obj;
    
    [SerializeField] float time;
    float Const_time;

    private void Start()
    {
        Const_time = time;
    }
    private void Update()
    {
        if(time < 0f)
        {
            Attack();
            time = Const_time;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
    public void Attack()
    {
        GameObject bullet = Instantiate(obj, transform.position, transform.rotation);
        bullet.GetComponent<bullet>().Set(damage, speed);
    }
}
