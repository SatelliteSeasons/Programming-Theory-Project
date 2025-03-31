using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAsteroid : Asteroid // INHERITANCE
{
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private MainManager mainManager;

    void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        explosion = mainManager.explosion;
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
            ParticleSystem ps = Instantiate(this.explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
            MainManager.Instance.GameEnd();
            Destroy(ps, 2f);
        }
    }
}
