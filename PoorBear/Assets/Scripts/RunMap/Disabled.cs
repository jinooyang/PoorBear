using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabled : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.98f)
        {
            Debug.Log("끝");
            this.gameObject.SetActive(false);
        }
    }
}
