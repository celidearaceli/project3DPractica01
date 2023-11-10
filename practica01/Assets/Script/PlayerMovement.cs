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
        Instantiate(Bala, transform.position, transform.rotation);
    }
}