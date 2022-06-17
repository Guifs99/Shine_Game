using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiros : MonoBehaviour
{
      public ParticleSystem particula;
    void OnTriggerEnter2D(Collider2D col)
   { 
            if (col.GetComponent<Collider2D>().gameObject.CompareTag("Player"))
            particula.Play();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
