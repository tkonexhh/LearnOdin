using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ButtonDemo : MonoBehaviour
{
    [Button("FoldoutButton", ButtonStyle.FoldoutButton)]
    private void Default1(float a, string s, int[] c) { }
    [Button("CompactBox", ButtonStyle.CompactBox)]
    private void Default2(float a, string s, int[] c) { }
    [Button("Box", ButtonStyle.Box)]
    private void Default3(float a, string s, int[] c) { }

    [Button]
    private void Default(float a, string s, int[] c) { }

}
