using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float _lastSpawn = 0;

    private bool _spawned = false;
    // Update is called once per frame
    void Update()
    {
        CoolDown();
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !_spawned)
        {
            _lastSpawn = 1;
            _spawned = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    private void CoolDown()
    {
        if(_spawned && _lastSpawn > 0)
        {
            _lastSpawn -= Time.deltaTime;
        }

        if (_lastSpawn > 0) 
            return;
        _lastSpawn = 0;
        _spawned = false;
    }
}
