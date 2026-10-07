using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    public GameObject prefabCoin;
    public float coinList = 0f;
    public GameObject prefabEnemy;
    public float enemyList = 0f;
    private float waktuSpawnSelanjutnya = 0f;
    private float waktuSpawnSelanjutnyaEnemy = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= waktuSpawnSelanjutnya && coinList <= 9)
        {
            float acakX = Random.Range(-10f, 10f);
            float acakZ = Random.Range(-10f, 10f);
            Vector3 posisiSpawn = new Vector3(acakX, 1f, acakZ);

            Instantiate(prefabCoin, posisiSpawn, Quaternion.identity);
            coinList += 1f;
            Debug.Log("Coin Spawned at: " + posisiSpawn);

            waktuSpawnSelanjutnya = Time.time + 1f;
    
        }

        if (Time.time >= waktuSpawnSelanjutnyaEnemy && enemyList <= 9)
        {
            float acakX = Random.Range(-10f, 10f);
            float acakZ = Random.Range(-10f, 10f);
            Vector3 posisiSpawn = new Vector3(acakX, 1f, acakZ);

            Instantiate(prefabEnemy, posisiSpawn, Quaternion.identity);
            enemyList += 1f;
            Debug.Log("Enemy Spawned at: " + posisiSpawn);

            waktuSpawnSelanjutnyaEnemy = Time.time + 2f;
        }
    }
}
