using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private Rigidbody2D _rigid;
    public GameObject Explosion;
    public GameManagerControlGame gamemanagercontrolgame;
    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _rigid.velocity = new Vector2(0, 2);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            gamemanagercontrolgame.UpdateScore(100);
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            
        }
    }
    public void SetGameManagerControl(GameManagerControlGame gamemanager)
    {
        gamemanagercontrolgame = gamemanager;
    }
    
}
