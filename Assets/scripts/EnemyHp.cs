using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float value = 100;
    
    public void DealDamage(float damage)
    {
        value -= damage;
        if(value <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        
    }
}
