using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator02Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemy02;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
   
    private float speedZGenerator2 = 2f;
    private int enemyCount = 0; // Contador de cubos generados

    void Start()
    {
        InvokeRepeating("EnemyGenerator", initTime, repeatTime);
    }

    public void EnemyGenerator()
    {
        if (enemyCount < 5)  // Verificar si aún se pueden generar más cubos
        {
            Instantiate(enemy02, transform.position, transform.rotation);
            enemyCount++;
        }
    }
    void Update()
    {
        if(transform.position.z < -4.23f || transform.position.z > 4.32f)
        {
            speedZGenerator2 *= -1;
        }
        //normalizado en función del tiempo
        transform.Translate( 0, 0,speedZGenerator2 * Time.deltaTime);
    }
     
     
       
        
          
                
           
        
        
    
}
