using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Je�li naci�ni�to spacj�
        {
            animator.SetTrigger("Open"); // Uruchom animacj� otwierania drzwi
            Debug.Log("Otwieram drzwi");
        }

    }
}
