using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firibal : MonoBehaviour
{
    public float Speed;
    public float Iitetime;
    public float damage = 10;

    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void Start()
    {
        Invoke("DestroyFireball", Iitetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireball();
    }

    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHp>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }

    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
