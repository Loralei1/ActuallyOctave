using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class DestroyInstantly : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
