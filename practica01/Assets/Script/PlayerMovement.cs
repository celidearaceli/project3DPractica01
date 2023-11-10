using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private GameObject Bala;

    void Update()
    {
        // Movimiento del jugador
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        // Disparo de balas
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // Instancia una nueva bala en la posición y rotación actual del objeto.
        Instantiate(Bala, transform.position, transform.rotation);
    }
}