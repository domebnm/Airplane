using System;
using UnityEngine;

public class Player : MonoBehaviour, Unit
{
    [Serializable] struct Offset
    {
        public float minX, maxX;
    }
    [SerializeField] Offset offset;
    float posX, posY;

    [SerializeField] float healthMax;
    float health;
    [SerializeField] UnityEngine.UI.Image healthBar;

    [SerializeField] float speedX;
    [SerializeField] float speedY;

    void Start()
    {
        Cursor.visible = false;
        health = healthMax;

        posX = transform.position.x;
        posY = transform.position.y;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        float mouseX = Input.GetAxis("Mouse X");

        posX += mouseX * speedX;
        posX = Mathf.Clamp(posX, offset.minX, offset.maxX);

        posY += speedY * Time.deltaTime;

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
    public void addHealth(float health)
    {
        this.health = this.health + health > this.healthMax ? this.health + health : this.healthMax;
    }
    public void getDamage(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / healthMax;

        if (health <= 0) {
            Debug.Log("end game");
        }
    }
}
