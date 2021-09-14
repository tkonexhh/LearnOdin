using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[Searchable]
public class SearchableDemo : MonoBehaviour
{

    public List<ItemA> Perks = new List<ItemA>();


    [System.Serializable]
    public class ItemA
    {
        public string name;
        public int age;
        [TableList]
        public List<Skill> skills;
    }

    [System.Serializable]
    public class Skill
    {
        public SkillType type;
        public int damage;
    }

    public enum SkillType
    {
        A,
        B,
        C,
    }

}
