using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class DelayedDemo : MonoBehaviour
{
    [Delayed, OnValueChanged("OnXChanged")]
    public int delayedX;

    [OnValueChanged("OnXChanged")]
    public int x;

    private void OnXChanged()
    {
        Debug.LogError("OnDelayedXChanged");
    }
}
