using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    protected float speed = 5;

    private void Start()
    {
        
    }

    protected virtual void MoveForward()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
