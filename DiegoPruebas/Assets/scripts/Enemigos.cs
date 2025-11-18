using UnityEngine;

public class Enemigos : MonoBehaviour
{
    float velocidadenemigo = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * velocidadenemigo);
    }
}
