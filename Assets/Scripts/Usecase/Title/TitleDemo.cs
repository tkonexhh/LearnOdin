using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TitleDemo : MonoBehaviour
{
    [Title("通用属性")]
    public int hp;
    public int mp;
    [Title("特殊属性")]
    public int atk;

    [Title("主标题", "副标题")]
    public int title;

    [Title("标题属性", "副标题", TitleAlignments.Centered, false, false)]
    public int title2;
}
