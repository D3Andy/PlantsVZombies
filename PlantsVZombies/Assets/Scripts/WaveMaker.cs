using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveMaker : MonoBehaviour {

    public Transform zombi;
    public Transform[] spawnPoints;
    private float time=15f;
    private int wave = 1;
    private float count = 2f;

    private void Update()
    {
        if( count <= 2f)
        {
            StartCoroutine(SpawnWave());
            count = time;
        }
        count -= Time.deltaTime;

    }

    IEnumerator SpawnWave()
    {
        for(int i = 0; i < wave; i++)
        {
            Spawn();
            yield return new WaitForSeconds(0.1f);
        }
        wave++;
    }

    void Spawn()
    {
        int x = Random.Range(0, 5);
        Instantiate(zombi, spawnPoints[x].position+new Vector3(0.4f,0.125f,0f), spawnPoints[x].rotation);
    }

}
