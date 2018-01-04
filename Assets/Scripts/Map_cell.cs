using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_cell : MonoBehaviour {

    public Map m_map;

    [SerializeField]
    int m_cost;

    int m_x;
    public int X {
        get {
            return m_x;
        }
    }

    int m_y;
    public int Y {
        get {
            return m_y;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPoint(int x, int y) {
        m_x = x;
        m_y = y;
        Vector2 cellPos = transform.position;
        cellPos.x = m_x;
        cellPos.y = m_y;
        transform.position = new Vector2(cellPos.x, cellPos.y);
    }
}
