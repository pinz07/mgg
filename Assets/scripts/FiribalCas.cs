using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiribalCas : MonoBehaviour
{
    public float damage = 10;

    public Firibal fireballPrefab;
    public Transform FireballSourceTransform;

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var fireball = Instantiate(fireballPrefab, FireballSourceTransform.position, FireballSourceTransform.rotation);
            fireball.damage = damage;
        }
    }
}
