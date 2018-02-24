using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour {


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision == null) {
            EnemyController.Instance.StateSet(EnemyState.normal);
        }
        if (collision.tag == "player") {
            EnemyController.Instance.StateSet(EnemyState.warning);
        }
    }
}
