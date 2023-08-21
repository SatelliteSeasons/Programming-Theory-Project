using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] ReloadScript reload;

    private float maxRangeX = 10;
    private float inputHorizontal; //Encapsulation
    private float speed = 23;

    private Vector3 startingPosition = new Vector3(0, -3, 0);

    void Start()
    { 
        this.transform.position = startingPosition;
        reload = GameObject.Find("Reload Circle").GetComponent<ReloadScript>();
        projectilePrefab = reload.GetProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        
        inputHorizontal = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * inputHorizontal * speed * Time.deltaTime);
        MaxRangePosition();
        Fire(); //Abstraction
        if (Input.GetKeyDown(KeyCode.R))
        {
            reload.Reload();
            projectilePrefab = reload.GetProjectile();
        }
        
    }

    public void MaxRangePosition()
    {
        if (this.transform.position.x > maxRangeX)
        {
            this.transform.position = new Vector3(maxRangeX, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x < -maxRangeX)
        {
            this.transform.position = new Vector3(-maxRangeX, this.transform.position.y, this.transform.position.z);
        }
    }

    public void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space)  )  
        {
            Instantiate(this.projectilePrefab, this.transform.position, this.transform.rotation);
        }
    }



}
