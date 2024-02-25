using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiribalCas : MonoBehaviour
{
    public Firibal fireballPrefab;
    public Transform FireballSourceTransform;

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, FireballSourceTransform.position, FireballSourceTransform.rotation);
        }
    }
}
