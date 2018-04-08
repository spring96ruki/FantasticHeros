using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStatus : SingletonMono<UnitStatus> { 

    string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }

    }

    int _maxHp;
    public int MaxHp
    {
        get
        {
            return _maxHp;
        }
        set
        {
            _maxHp = value;
        }

    }

    int _currentHp;
    public int CurrentHP {
        get
        {
            return _currentHp;
        }
        set
        {
            _currentHp = value;
        }
    }

    int _maxMp;
    public int MaxMp
    {
        get
        {
            return _maxMp;
        }
        set
        {
            _maxMp = value;
        }
    }

    int _currentMp;
    public int CurrentMp
    {
        get
        {
            return _currentMp;
        }
        set
        {
            _currentMp = value;
        }
    }

    int _strength;
    public int Strange
    {
        get
        {
            return _strength;
        }
        set
        {
            _strength = value;
        }
    }

    int _vitality;
    public int Vitality
    {
        get
        {
            return _vitality;
        }
        set
        {
            _vitality = value;
        }
    }

    float _agility;
    public float Agility
    {
        get
        {
            return _agility;
        }
        set
        {
            _agility = value;
        }
    }
}

