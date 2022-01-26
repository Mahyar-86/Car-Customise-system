using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Customizer : MonoBehaviour
{
    public Components components;
    public Position position;
    
[System.Serializable]
    public class Position
    {
        public Transform[] wheelsPosition;
        public Transform spoiler, roofScoop;
    }
}
