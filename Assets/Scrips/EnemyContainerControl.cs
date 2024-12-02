using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameManagerControlGame gm;
    public float MinPositionX;
    public float MaxPositionX;
    public float PositionY;
    public int Timetocreat;
    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        float PositionX = Random.Range(MinPositionX, MaxPositionX);
        Vector2 PositionCreateEnemy = new Vector2(PositionX, PositionY); 
        GameObject enemy = Instantiate(EnemyPrefab, PositionCreateEnemy, transform.rotation);
        enemy.GetComponent<EnemyDestroy>().SetGameManagerControl(gm);
        Invoke("CreateEnemy", Timetocreat);
    }
}
