using UnityEngine;
using System.Collections;

public class GenerarObstaculos : MonoBehaviour {

    public GameObject obstaculo;
    public float Rango;
    private Vector3 posRandom;
    public float tiempoRandom;
    float timer;
    // Use this for initialization
    void Start()
    {

    }
    void crearObstaculos()
    {
        posRandom = new Vector3(Random.Range(Rango, -Rango), 0, Random.Range(Rango, -Rango));
        Instantiate(obstaculo, posRandom, transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (tiempoRandom < timer)
        {
            crearObstaculos();
            timer = 0;
        }

    }
}
