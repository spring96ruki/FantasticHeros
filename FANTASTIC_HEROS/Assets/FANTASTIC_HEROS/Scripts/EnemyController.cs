using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    unknown,
    normal,
    warning
}

public class EnemyController : SingletonMono<EnemyController> {

    public Transform baseUnit;
    public Transform playerUnit;
    public List<GameObject> EnemyObjList = new List<GameObject>();

    float dt;
    float enemySpeed;
    UnitStatus unitStatus;

    // Use this for initialization
    void Start () {
        dt = Time.deltaTime;
        unitStatus = GetComponent<UnitStatus>();
        enemySpeed = unitStatus.chara[2].movespeed;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void StateSet(EnemyState state)
    {
        switch (state)
        {
            case EnemyState.normal:
                EnemyObjList[0].transform.position = Vector3.MoveTowards(transform.position, baseUnit.position, enemySpeed * dt);
                break;
            case EnemyState.warning:
                EnemyObjList[0].transform.position = Vector3.MoveTowards(transform.position, playerUnit.position, enemySpeed * dt);
                break;
        }
    }
}
