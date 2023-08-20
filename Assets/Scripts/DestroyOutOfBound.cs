using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    void Update()
    {
        if(this.transform.position.y > 25 || this.transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}
