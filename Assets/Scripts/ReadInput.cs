using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    public void ReadStringInput(string s) {
        MenuManager.Instance.userName = s;
        Debug.Log("s = "+s);
    }
}
