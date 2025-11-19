using System.Collections;
using UnityEngine;

public class ScriptSpawnerEnemigos : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    Vector3 spawner;
    float temporizador;
    float randomizadorX;
    float randomizadorY;
    float timer1;
    float timer2;

    //Intervalo de spawneo
    float intervalo;
    float distanciaEntreEnemigos = 2.5f;
    float speed = 30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SpawnRate");
    }

    // Update is called once per frame
    void Update()
    { 
       

       

    }

    IEnumerator SpawnRate()
    {
        while (true)
        {
            RandomPosition();
            spawnear1();
            //Calculo el intervalo
            intervalo = distanciaEntreEnemigos / speed;
            yield return new WaitForSeconds(intervalo);
        }
    }

    void RandomPosition()
    {
        randomizadorX = Random.Range(-10f, 10f);
        randomizadorY = Random.Range(-5, 5f);
        spawner = new Vector3(randomizadorX, randomizadorY, 45f);
    }
    

    void spawnear1()
    {
    Instantiate(enemigo,spawner,Quaternion.identity);
    }
}  

       
       
       
       



       
