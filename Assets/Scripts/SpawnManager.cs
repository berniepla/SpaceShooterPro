using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private float _waitTime = 5.0f;

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private GameObject _enemyContainer;

    private bool _stopSpawning = false;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator SpawnRoutine()
    {
        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(_waitTime);
        }
    }

    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}