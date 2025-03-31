using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowAsteroid : Asteroid
{
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private MainManager mainManager;
    [SerializeField] private int life = 3;

    void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        explosion = mainManager.explosion;
        speed = 2;
    }
    private void Update()
    {
        MoveForward();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowProjectile"))
        {
            if(life <= 1)
            {
                Destroy(other.gameObject);
                ParticleSystem ps = Instantiate(this.explosion, this.transform.position, this.transform.rotation);
                Destroy(ps, 2.0f);
                Destroy(this.gameObject);
                MainManager.Instance.GameEnd();
            }
            else
            {
                life--;
                ParticleSystem ps = Instantiate(this.explosion, this.transform.position, this.transform.rotation);
                Destroy(ps, 2.0f);
            }
            
        }
    }
}
