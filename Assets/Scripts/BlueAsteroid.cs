using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAsteroid : Asteroid
{
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private MainManager mainManager;

    private float speedPas = 20f;
    void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        explosion = mainManager.explosion;
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    protected override void MoveForward()
    {
        this.transform.Translate(Vector3.down * base.speed * Time.deltaTime);
        StartCoroutine(PasChasser());
    }

    IEnumerator PasChasser() //REVOIR
    {
        if(this.transform.position.x < 6 && this.transform.position.x > -6)
        {
            int randomIndex = Random.Range(0, 2);
            if(randomIndex == 0)
            {
                this.transform.Translate(Vector3.left * speedPas * Time.deltaTime);
            }
            else
            {
                this.transform.Translate(Vector3.right * speedPas * Time.deltaTime);
            }
        }
        else if(this.transform.position.x > -6)
        {
            this.transform.Translate(Vector3.left * speedPas * Time.deltaTime);

        }
        else if(this.transform.position.x < 6)
        {
            this.transform.Translate(Vector3.right * speedPas * Time.deltaTime);
        }
        else
        {
            Debug.Log("ERREUR LORS DES PAS CHASSER");
        }
        yield return new WaitForSeconds(1f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueProjectile"))
        {
            Destroy(other.gameObject);
            Instantiate(this.explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
