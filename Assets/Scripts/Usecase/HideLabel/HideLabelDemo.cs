using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class HideLabelDemo : MonoBehaviour
{
    public string showLabel = "显示标题";

    [HideLabel]
    public string hideLabel = "隐藏标题";

    [ShowInInspector]
    public string ShowPropertyLabel { get; set; }

    [ShowInInspector]
    [HideLabel]
    public string HidePropertyLabel { get; set; }
}
