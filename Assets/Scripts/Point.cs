using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnDroawGizmos()
    {
#if UNITY_EDITOR
        UnityEditor.Handles.Label(transform.position, name);
#endif

    }
}
