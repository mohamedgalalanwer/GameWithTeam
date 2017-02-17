using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    private RaycastHit hit;
    public LayerMask detectionLayer;
    private float checkRate = 0.5f;
    private float nextCheck;
    // private float ring = 5;
    private Transform myTransform;

    public GameObject killEfect;

    public GameObject enemy;
   /// public ParticleSystem hitEffect;
   /// 

   // DestroyEnemy de;
   
    void Start()
    {
       // hitEffect.enableEmission = false;
        IntialReferance();

       // de = new DestroyEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        DetectionItem();
    }

    void IntialReferance()
    {

        myTransform = transform;
        // detectionLayer = 1 << 9;

    }


    void RandomPostion()
    {

        float x = Random.Range(-5.0f, 50f);
        float z = Random.Range(-5.0f, 50f);
        enemy.transform.position=new Vector3(x, 0, z);
    }

    void DetectionItem()
    {
        if (Input.GetButtonDown("Fire1")) { 
        if (Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            if (Physics.Raycast(myTransform.position, -myTransform.forward, out hit, Mathf.Infinity, detectionLayer))
            {
                Debug.Log(hit.transform.name + "is Layer");
                Debug.DrawLine(transform.position, hit.point, Color.cyan);


               // hitEffect.transform.position = hit.point;
               // hitEffect.enableEmission = true;
                Instantiate(killEfect, hit.transform.position, hit.transform.rotation);
              
                RandomPostion();
               // de.Destroy_Enemy();
            }


        }
        }
    }
}