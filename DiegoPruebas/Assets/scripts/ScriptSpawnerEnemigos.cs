using System.Threading;
using UnityEngine;

public class ScriptSpawnerEnemigos : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    Vector3 spawner;
    float temporizador;
    float randomizadorX;
    float randomizadorY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temporizador = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
