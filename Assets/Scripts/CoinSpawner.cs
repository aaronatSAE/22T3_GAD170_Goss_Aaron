using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;

        // Start is called before the first frame update
        private void Start()
        {
            SpawnCoin();
            SpawnCoin();
        }

        private void SpawnCoin()
        {
            int xPosition = Random.Range(-50, 50);
            int yPosition = Random.Range(-50, 50);
            int zPosition = Random.Range(-50, 50);

            Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
        }
    }
}
