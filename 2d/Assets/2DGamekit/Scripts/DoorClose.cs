using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public Animator animator = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log( " Player entered " );

        animator.GetComponent<Gamekit2D.HubDoor>().enabled = false;

        animator.Play ("DoorClosing");
    }
}
