using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAsteroid : Asteroid // INHERITANCE
{
    
    void Start()
    {
        
    }

    private void Update()
    {
        MoveForward();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NormalProjectile"))
        {
            Destroy(other.gameObject);
            Instantiate(this.explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
