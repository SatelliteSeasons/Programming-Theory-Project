using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScript : MonoBehaviour //ENCAPSULATION
{
    [SerializeField] GameObject normalProjectilePrefab;
    [SerializeField] GameObject blueProjectilePrefab;
    [SerializeField] GameObject yellowProjectilePrefab;

    private int actualProjectile;
    private ArrayList projectile = new ArrayList(); //REVOIR

    void Start()
    {
        actualProjectile = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
