using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    //  Intervalo: Public
    //  Colldown : privad
    // Lista de bolinhas: Public
    //  Ponto de origem: Public 
    public List<GameObject> prefabs; 
    public Vector3 origenPoint = new Vector3(0, 0, 0); 
    public float interval = 1;
    private float colldown = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Ensure ggame is active

        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        //  Spawn balls according to interval
        colldown -= Time.deltaTime;
        if (colldown <= 0f)
        {
            colldown = interval;
            SpawnBall();
        }

    }

    private void SpawnBall()
    {
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];
        // get position
        var gameWidth = GameManager.Instance.gameWidth;
        var xOffser = Random.Range(-gameWidth / 2f, gameWidth / 2f);

        Vector3 position = origenPoint + new Vector3(xOffser, 0, 0);
        



        // get rotacion
        Quaternion rotation = prefab.transform.rotation;


        // Spaw Ball
        Instantiate(prefab, position, rotation);
    }
}

