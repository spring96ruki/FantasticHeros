using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStatus : MonoBehaviour
{
    public List<CharacterStatus> Chara;
    [System.Serializable]//これでinspectorに表示
    public struct CharacterStatus
    {
        public string Name;
        public int Maxhp;
        public int Hp;
        public int Maxmp;
        public int Mp;
        public int Attack;
        public int Defense;
        public float movespeed;
    }
}

