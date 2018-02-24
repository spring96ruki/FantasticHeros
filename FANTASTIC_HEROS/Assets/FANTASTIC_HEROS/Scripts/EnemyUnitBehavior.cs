using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyUnitBehavior : MonoBehaviour {

    public GameObject unitstatus;

    float dt;
    float enemyMoveSpeed;
    UnitStatus uns;



    void Start()
    {
        dt = Time.deltaTime;
        enemyMoveSpeed = uns.chara[2].movespeed * dt;
        unitstatus = GameObject.Find("UnitStatus");
        uns = unitstatus.GetComponent<UnitStatus>();
    }

    private void Update()
    {
    }


}
