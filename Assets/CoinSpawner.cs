using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject coinPrefab;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(coinPrefab, new Vector3(this.transform.position.x+i, this.transform.position.y+i, this.transform.position.z+i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
