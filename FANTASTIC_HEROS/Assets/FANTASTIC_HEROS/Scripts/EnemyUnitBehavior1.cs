using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitBehavior : MonoBehaviour {

    public Transform target;
    public GameObject unitstatus;
    private UnitStatus uns;



    void Start()
    {
        unitstatus = GameObject.Find("UnitStatus");
        uns = unitstatus.GetComponent<UnitStatus>();
        Debug.Log(uns.Chara[2].movespeed);

    }


    // Update is called once per frame
    void Update()
    {
        float step = uns.Chara[2].movespeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            
            Debug.Log("aaaa");
        }

    }
}
