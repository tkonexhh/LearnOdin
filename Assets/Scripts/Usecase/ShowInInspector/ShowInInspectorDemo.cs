using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ShowInInspectorDemo : MonoBehaviour
{
    [ShowInInspector]
    private int myPrivateInt;

    [ShowInInspector]
    public int MyPropertyInt { get; set; }

    [ShowInInspector]
    public int ReadOnlyProperty
    {
        get { return this.myPrivateInt; }
    }

    [ShowInInspector]
    public static bool StaticProperty { get; set; }
}
