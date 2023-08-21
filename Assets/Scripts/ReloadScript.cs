using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScript : MonoBehaviour //ENCAPSULATION
{
    [SerializeField] GameObject normalProjectilePrefab;
    [SerializeField] GameObject blueProjectilePrefab;
    [SerializeField] GameObject yellowProjectilePrefab;

    private int actualIndexProjectile;
    private GameObject[] projectileList = new GameObject[3];

    void Start()
    {
        actualIndexProjectile = 0;
        projectileList[0] = normalProjectilePrefab;
        projectileList[1] = blueProjectilePrefab;
        projectileList[2] = yellowProjectilePrefab; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reload()
    {
        switch(actualIndexProjectile)
        {
            case 0: actualIndexProjectile = 1;
                this.transform.Rotate(Vector3.forward, -120);
                break;

            case 1:
                actualIndexProjectile = 2;
                this.transform.Rotate(Vector3.forward, -120);
                break;

            case 2:
                actualIndexProjectile = 0;
                this.transform.Rotate(Vector3.forward, -120);
                break;
            default: Debug.Log("ERREUR LORS DU RELOAD SCRIPT RELOAD()");
                break;

        }
    }

    public GameObject GetProjectile()
    {
        return projectileList[actualIndexProjectile];
    }
}
