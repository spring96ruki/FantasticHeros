using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour {

    public bool isBool;

    private void Update()
    {
        Debug.Log("isBool : " + isBool);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isBool = true;
    }
}
