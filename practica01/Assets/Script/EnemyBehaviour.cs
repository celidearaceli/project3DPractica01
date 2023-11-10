using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemyBall; 
    [SerializeField] private float speedX = 2f;
    [SerializeField] private float speedZ = 2f;
    [SerializeField] private int enemyType;
    private float speedXEnemy2 = 2f;
    
    private float randomTime = 0;

    private void Start()
    {
        switch(enemyType)
        {
            case 1:
            {
                InvokeRepeating("ShootBall", 0, 2f);
                break;
            }
            case 2:
            {
                Invoke("ShootBall", randomTime);
                break;
            }
        }
        
       
    }
    void Update()
    {
        MoveEnemy();
    }

    public void ShootBall()
    {
        Instantiate(enemyBall, transform.position, transform.rotation);
        if (enemyType == 2)
        {
            randomTime = Random.Range(1,3);
            Invoke("ShootBall", randomTime);
        }
    }

    public void MoveEnemy()
    {
        switch(enemyType)
        {
            case 1:
            {
                transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
                //Los Enemigo01, al cruzar el plano son destruidos
                if (transform.position.z > 4.74f || transform.position.x < - 4.63f)
                {
                    Destroy(gameObject);
                }
                break;
            }
            case 2:
            {
                if(transform.position.x < -4.39f || transform.position.x > 4.45f)
                {
                    speedXEnemy2 *= -1;
                }
                transform.Translate(speedXEnemy2 * Time.deltaTime *-1, 0, 0);
                break;
            }
        }
        
    }
}
