using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    //戦闘用データ
    public BattleParam battleParam;
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
        //前のシーンがアクティブと判断されてしまう為、再度Battleシーンをアクティブにする
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Battle"));

        friends = new GameObject[battleParam.friendLists.Length];
        enemys = new GameObject[battleParam.enemyLists.Length];

        //パーティーメンバーをインスタンス化して配置
        for (int i = 0; i < battleParam.friendLists.Length; i++)
        {
            friends[i] = Instantiate(Resources.Load(battleParam.friendLists[i].ToString(), typeof(GameObject)), friendPartyField.GetChild(i).position, friendPartyField.GetChild(i).rotation) as GameObject;
            namePanel.GetChild(i).GetComponent<Text>().text = friends[i].GetComponent<BattleChara>().charaStatus.name.ToString();
            hpPanel.GetChild(i).GetComponent<Text>().text = friends[i].GetComponent<BattleChara>().charaStatus.Hp.ToString();
            mpPanel.GetChild(i).GetComponent<Text>().text = friends[i].GetComponent<BattleChara>().charaStatus.Mp.ToString();
        }

        for (int i = 0; i < battleParam.enemyLists.Length; i++)
        {
            enemys[i] = Instantiate(Resources.Load(battleParam.enemyLists[i].ToString(), typeof(GameObject)), enemyPartyField.GetChild(i).position, enemyPartyField.GetChild(i).rotation) as GameObject;
        }
    }

}
