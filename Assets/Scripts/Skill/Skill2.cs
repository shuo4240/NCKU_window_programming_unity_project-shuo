using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2 : MonoBehaviour
{
    public Collider myCollider;

    private void Start()
    {
        // 在開始時獲取碰撞器的引用
        myCollider = GetComponent<SphereCollider>();
    }
    SkillCD2 skill2;
    private void Update()
    {
        myCollider.enabled = false;
        skill2 = FindObjectOfType<SkillCD2>();
        if (skill2.isUsingSkill)
        {
            ToggleCollider();
        }
    }

    private void ToggleCollider()
    {
        // 切換碰撞器的啟用狀態
        myCollider.enabled = true;

        // 打印碰撞器的狀態
        if (myCollider.enabled)
        {
            Debug.Log("Collider is enabled.");
        }
        else
        {
            Debug.Log("Collider is disabled.");
        }
    }
}
