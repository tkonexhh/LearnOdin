using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class RequiredDemo : MonoBehaviour
{
    [Required]
    public GameObject MyGameObject;


    [Required("自定义错误提示消息")]
    public GameObject MyGameObject2;

    [Required("显示类型", InfoMessageType.Info)]
    public GameObject MyGameObject3;
}
