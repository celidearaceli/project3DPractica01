using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaBehaviour : MonoBehaviour
{
    [SerializeField] private float speedZ = 2f;

    void Update()
    {
        transform.Translate(0, 0, speedZ * Time.deltaTime);
    }
}
