using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type
    {
        Wheels,
        Spoiler,
        RoofScoop
    }

    public Type _Type;
    public int index;
}
