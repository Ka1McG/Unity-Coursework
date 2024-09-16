using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    public StatManager statManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            statManager.finishedLevel = true;
        }
    }
}
