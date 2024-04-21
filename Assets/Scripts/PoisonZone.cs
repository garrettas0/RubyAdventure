using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisionZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-2);
        }
    }
}