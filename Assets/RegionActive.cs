using System.Linq;
using UnityEngine;

public class RegionActive : MonoBehaviour
{
    private void Start()
    {
        Enemy[] enemy = GameObject.FindGameObjectsWithTag("Enemy").Select(x => x.GetComponent<Enemy>()).ToArray();  
        for (int i = 0; i < enemy.Length; i++) { enemy[i].enabled = false; }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().enabled = true;
            collision.GetComponent<Enemy>().MyStart();
        }
    }
}
