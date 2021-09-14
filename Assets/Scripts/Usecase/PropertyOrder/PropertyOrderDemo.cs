using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PropertyOrderDemo : MonoBehaviour
{
    [PropertyOrder(2)]
    public int first;

    [PropertyOrder(1)]
    public int second;
}
