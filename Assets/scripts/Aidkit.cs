using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aidkit : MonoBehaviour
{
    public float healAmout = 50;
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHp = other.gameObject.GetComponent<PlayerHp>();
        if (PlayerHp != null && PlayerHp.value<100)
        {
            PlayerHp.AddHealth(healAmout);
            Destroy(gameObject);
        }
    }
}
