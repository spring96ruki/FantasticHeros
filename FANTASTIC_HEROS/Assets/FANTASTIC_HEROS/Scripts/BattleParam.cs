using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//　シーン遷移時に戦闘で使うデータを保存しておくファイルの作成
[CreateAssetMenu(fileName = "BattleParameter", menuName = "CreateBattleParameter")]
public class BattleParam : ScriptableObject {

    //　主人公パーティーメンバー
    public KindOfFriendList.FriendList[] friendLists;
    //　戦う敵の種類
    public KindOfEnemyList.EnemyList[] enemyLists;
    //　主人公のワールド空間の位置
    public Vector2 pos;
    //　主人公のワールド空間の角度
    public Quaternion rot;

}
