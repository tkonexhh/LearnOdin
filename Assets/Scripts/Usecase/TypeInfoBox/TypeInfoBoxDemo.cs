using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TypeInfoBoxDemo : MonoBehaviour
{
    public Student student = new Student();


    [System.Serializable]
    [TypeInfoBox("学生基本信息")]
    public class Student
    {
        public int age;
        public string name;
    }
}
