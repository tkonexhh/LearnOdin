using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PropertySpaceDemo : MonoBehaviour
{
    [Space]
    public int unitySpace;

    [Space(5)]
    public int unitySpace1;
    [PropertySpace]
    public int OdinSpace2;

    //自带的Space无法应用属性 PropertySpace可以
    // [ShowInInspector, Space(40)]
    [ShowInInspector, PropertySpace(40)]
    public int Property { get; set; }


    // 还可以控制PropertySpace属性前后的间距。
    [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
    public int BeforeAndAfter;
    [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
    public int BeforeAndAfter1;
}
