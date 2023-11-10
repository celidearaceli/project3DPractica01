using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator02Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemy02;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
   

// Declaración de variables para la velocidad y cantidad de generación de enemigos
private float speedZGenerator2 = 2f;
private int enemyCount = 0;


void Start()
{
    // Configuración de la invocación repetida del método EnemyGenerator
    InvokeRepeating("EnemyGenerator", initTime, repeatTime);
}

// Método para generar enemigos
public void EnemyGenerator()
{
    // Verificar si la cantidad de enemigos es menor que 5
    if (enemyCount < 5)
    {
        // Instanciar un objeto enemigo e incrementar la cuenta
        Instantiate(enemy02, transform.position, transform.rotation);
        enemyCount++;
    }
}


void Update()
{
    // Verificar si la posición en el eje Z está más allá de los límites especificados
    if (transform.position.z < -4.23f || transform.position.z > 4.32f)
    {
        // Si está fuera de límites, invertir la dirección del movimiento
        speedZGenerator2 *= -1;
    }

    // Mover el objeto en función de la velocidad de movimiento en el eje Z
    transform.Translate(0, 0, speedZGenerator2 * Time.deltaTime);
}

    
    
}
