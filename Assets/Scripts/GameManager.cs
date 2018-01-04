using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Map m_map;
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator Start()
    {
        m_map.MapGenerate(10,10);
        yield return null;
    }
}
