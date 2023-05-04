using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Gun : MonoBehaviour
{


    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firingPoint;

   


    [Range(0.1f, 1f)]
    [SerializeField] private float fireRate = 0.5f;

    private float fireTimer;

    private Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;

        transform.localRotation = Quaternion.Euler(0,0, angle);

        if(Input.GetMouseButton(0) && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireRate;
        }
        else 
        {
            fireTimer -= Time.deltaTime;
        }
        
    }

    private void Shoot()
    {
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
          
    }

    
}
