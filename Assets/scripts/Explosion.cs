using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float damege = 50;
    public float maxSize = 5;
    public float speed = 1;

    private void Start()
    {
        transform.localScale = Vector3.zero;
    }

    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;

        if(transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHp = other.GetComponent<PlayerHp>();
        if(PlayerHp != null)
        {
            PlayerHp.DealDamage(damege);
        }

        var EnemyHp = other.GetComponent<EnemyHp>();
        if(EnemyHp != null)
        {
            EnemyHp.DealDamage(damege);
        }
    }
}
