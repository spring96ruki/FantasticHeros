using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {


    //主人公パーティーの位置
    public Transform friendPartyField;
    //敵パーティーの位置
    public Transform enemyPartyField;
    //主人公パーティーオブジェクト
    public GameObject[] friends;
    //敵パーティーオブジェクト
    public GameObject[] enemys;

    //名前表示テキストパネル
    public Transform namePanel;
    //HP表示テキストパネル
    public Transform hpPanel;
    //MP表示テキストパネル
    public Transform mpPanel;

    //Use this for initialization
    void Start()
    {
    }

}
