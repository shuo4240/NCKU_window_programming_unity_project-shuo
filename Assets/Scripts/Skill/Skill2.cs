using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2 : MonoBehaviour
{
    public Collider myCollider;

    private void Start()
    {
        // �b�}�l������I�������ޥ�
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
        // �����I�������ҥΪ��A
        myCollider.enabled = true;

        // ���L�I���������A
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
