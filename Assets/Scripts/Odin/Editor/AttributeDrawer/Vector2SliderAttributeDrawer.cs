using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;

public class Vector2SliderAttributeDrawer : OdinAttributeDrawer<Vector2SliderAttribute, Vector2>
{

    protected override void DrawPropertyLayout(GUIContent label)
    {
        Rect rect = EditorGUILayout.GetControlRect();

        if (label != null)
        {
            rect = EditorGUI.PrefixLabel(rect, label);
        }

        Vector2 value = this.ValueEntry.SmartValue;
        GUIHelper.PushLabelWidth(20);

        GUIHelper.PopLabelWidth();
    }
}
