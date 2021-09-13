using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class DetailedInfoBox : MonoBehaviour
{
    [DetailedInfoBox("简介消息", "默认情况下VisibleIf为True，所以此消息框可见", InfoMessageType = InfoMessageType.None)]
    public string NoneMessage = "无";
    [DetailedInfoBox("简介消息", "默认情况下VisibleIf为True，所以此消息框可见", InfoMessageType = InfoMessageType.Info)]
    public string InfoMessage = "无";
    [DetailedInfoBox("简介消息", "默认情况下VisibleIf为True，所以此消息框可见", InfoMessageType = InfoMessageType.Warning)]
    public string WarningMessage = "无";
    [DetailedInfoBox("简介消息", "默认情况下VisibleIf为True，所以此消息框可见", InfoMessageType = InfoMessageType.Error)]
    public string ErrorMessage = "无";

    [Space(50)]
    [DetailedInfoBox("简介消息", "默认情况下VisibleIf为True，所以此消息框可见", InfoMessageType = InfoMessageType.Info, VisibleIf = "VisibleIf")]
    public string haveVisibleIfMessage = "";
    public bool visible;

    private bool VisibleIf()
    {
        return visible;
    }

}
