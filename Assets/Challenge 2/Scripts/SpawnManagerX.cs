using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Programar la primera llamada
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // 1. Generar índice aleatorio para seleccionar pelota (1, 2 o 3)
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // 2. Generar posición aleatoria en X
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // 3. Instanciar la pelota elegida al azar
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // 4. Reprogramar la SIGUIENTE invocación con un intervalo aleatorio entre 3 y 5 segundos (Bonus)
        float spawnInterval = Random.Range(3.0f, 5.0f);
        Invoke("SpawnRandomBall", spawnInterval);
    }
}
