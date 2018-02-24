using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour {

    public GameObject playerObj;

    [Range(0f, 1f)]float m_time;
    Vector3 m_startMousePos;
    Vector3 m_endMousePos;
    Vector3 m_mouseDinstance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        MovingIsMousePos();

    }

    public void MovingIsMousePos() {

        Vector3 screenPos = Input.mousePosition;
        var DistancePer =  Mathf.Sqrt( Mathf.Pow(m_mouseDinstance.x, 2) + Mathf.Pow(m_mouseDinstance.y, 2))/ 0.1f;

        if (Input.GetMouseButtonDown(0))
        {
            m_startMousePos = Camera.main.ScreenToWorldPoint(screenPos);
            m_startMousePos.z = 0f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_endMousePos = Camera.main.ScreenToWorldPoint(screenPos);
            m_endMousePos.z = 0f;
            m_mouseDinstance = m_endMousePos - m_startMousePos;
        }

        

        Debug.Log("クリック時の座標：" + m_startMousePos);
        Debug.Log("クリック後の座標：" + m_endMousePos);
        Debug.Log("クリック時とクリック後の距離" + m_mouseDinstance);
    }
}
