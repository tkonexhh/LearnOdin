using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class AssetsOnlyDemo : MonoBehaviour
{
    [AssetsOnly] public GameObject go_Asset;
    [SceneObjectsOnly] public GameObject go_Scene;
}
