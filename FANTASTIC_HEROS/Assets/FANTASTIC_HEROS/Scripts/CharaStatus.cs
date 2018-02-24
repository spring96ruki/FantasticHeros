using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//　キャラクター毎のステータス
[CreateAssetMenu(fileName = "CharacterStatus", menuName = "CreateCharacterStatus")]
public class CharaStatus : ScriptableObject {

    public string Name;
    public int Maxhp;
    public int Hp;
    public int Maxmp;
    public int Mp;
    public int Attack;
    public int Defense;
    public float movespeed;

}
