using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator01Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemy01;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
    void Start()
    {
        
        InvokeRepeating("EnemyGenerator", initTime, repeatTime);
    }

    public void EnemyGenerator()
    {
        Instantiate(enemy01, transform.position, transform.rotation);
    }
}
