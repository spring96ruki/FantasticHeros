using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour {

    public GameObject playerObj;

    [Range(0f, 10f)]float m_time;
    float m_startTime;
    Vector3 m_startMousePos;
    Vector3 m_endMousePos;
    Vector3 m_mouseDinstance;

	// Use this for initialization
	void Start () {
        m_startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        MovingIsMousePos();

    }

    public void MovingIsMousePos() {

        Vector3 screenPos = Input.mousePosition;
        float timeStep = m_time > 0f ? (Time.time - m_startTime) / m_time : 1.0f;
        timeStep = Mathf.Clamp01(timeStep);

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

        playerObj.transform.position = Vector3.Lerp(m_startMousePos, m_endMousePos, timeStep);

        Debug.Log("クリック時の座標：" + m_startMousePos);
        Debug.Log("クリック後の座標：" + m_endMousePos);
        Debug.Log("クリック時とクリック後の距離" + m_mouseDinstance);
    }
}
