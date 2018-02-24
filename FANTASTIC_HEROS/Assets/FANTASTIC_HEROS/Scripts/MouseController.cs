using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour {

    public GameObject playerObj;
    public float charaMove = 0.01f;

    Vector3 m_endMousePos;
    Vector3 m_mouseDinstance;

    // Update is called once per frame
    void Update () {

        MovingIsMousePos();

    }

    public void MovingIsMousePos() {

        Vector3 screenPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0))
        {
            m_endMousePos = Camera.main.ScreenToWorldPoint(screenPos);
            m_endMousePos.z = 0f;
        }

        playerObj.transform.position = Vector3.Lerp(playerObj.transform.position, m_endMousePos, charaMove);

        Debug.Log("クリック後の座標：" + m_endMousePos);
        Debug.Log("クリック時とクリック後の距離" + m_mouseDinstance);
    }
}
