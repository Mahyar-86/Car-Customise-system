using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{

    public Wheels[] _Wheels;
    public Spoiler[] _Spoiler;
    public RoofScoop[] _RoofScoops;
    
    [System.Serializable]
    public class Wheels
    {
        public int level;
        public int adhesion;
        public GameObject model;
        public int money;
        public bool equip;
    }
    [System.Serializable]
    public class Spoiler
    {
        public int level;
        public int acceleration;
        public GameObject model;
        public int money;
        public bool equip;
    }
    [System.Serializable]
    public class RoofScoop
    {
        public int level;
        public int enginePower;
        public GameObject model;
        public int money;
        public bool equip;
    }
}
