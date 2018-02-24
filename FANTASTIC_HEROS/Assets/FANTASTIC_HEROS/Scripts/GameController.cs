using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour {

    //フェード＆シーン読み込み処理クラス
    public LoadSceneManager loadSceneManager;
    //戦闘時に使うパラメータファイル
    public BattleParam battleParam;
    //この敵と接触した時の敵の種類を入れるクラス
    private EnemyParty enemyParty;

    // Use this for initialization
    void Start()
    {
        loadSceneManager = FindObjectOfType<LoadSceneManager>();
        //自身に設定されているEnemyPartyスクリプトを取得
        enemyParty = GetComponent<EnemyParty>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //col.GetComponent<Player>().SetState(Player.State.freeze);
            //戦闘用のパラメータをScriptableObjectのデータに入れる
            battleParam.friendLists = col.GetComponent<FriendParty>().friendLists;
            battleParam.enemyLists = enemyParty.enemyLists;
            //主人公の位置を入れる
            battleParam.pos = col.transform.position;
            battleParam.rot = col.transform.rotation;
            //戦闘シーンの読み込み
            loadSceneManager.FadeAndLoadScene("Battle");
        }
    }
}
