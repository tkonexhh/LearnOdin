using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ReadOnlyDemo : MonoBehaviour
{
    [ReadOnly]
    public string player1Name = "KDF";
    public string player2Name = "KKK";
}
