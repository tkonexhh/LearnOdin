using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ValidateInputDemo : MonoBehaviour
{
    [Delayed]
    [ValidateInput("CheckPlayerAge", "", InfoMessageType.Error)]
    public int playerAge;

    private bool CheckPlayerAge(int age, ref string errorMessage, ref InfoMessageType? messageType)
    {
        errorMessage = "角色未成年";
        return age >= 18;
    }
}
