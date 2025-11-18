using System.Threading;
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer1 = 0;
        timer2 = 0;
    }

    // Update is called once per frame
    void Update()
    { 
       randomizadorX = UnityEngine.Random.Range(-10f,10f); 
       randomizadorY = UnityEngine.Random.Range(-5,5f);
       spawner = new Vector3(randomizadorX,randomizadorY,45f);

       timer1 += Time.deltaTime;
       timer2 += Time.deltaTime;
       
       if(timer1 >= 2f)
       {
        spawnear1();
        timer1 = 0f;
       }
       

       if(timer2 >= 3f)
       {
        spawnear1();
        timer2 = 0f;
       }
       

    }
       void spawnear1()
       {
        Instantiate(enemigo,spawner,Quaternion.identity);
       }
}  

       
       
       
       



       
