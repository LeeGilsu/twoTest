using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Mobster Data", menuName = "Scriptable Object/Monster Data", order = int.MaxValue)]
public class MonstData : ScriptableObject // 씬에있는 오브젝트를 붙일 수 없다.
    //사용법
{
    public string Name;
    public int HP;
    public float moveSpeed;
}
