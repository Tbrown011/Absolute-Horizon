﻿using UnityEngine;
using System.Collections;

public class EnemyMoves : MonoBehaviour
{

    private Player player;
    private GameObject enemy;

    private string moveName;

    private float brnRate;
    private float frzRate;
    private float stnRate;
    private float psnRate;
    private float hitRate;
    private float dmgX;
    private int dmgBoost;
    private int epUse;
    private int mpUse;
    private float spUse;
    private int option;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual IEnumerator enemyChoice()
    {
        yield return new WaitForSeconds(1);
        while (gameObject.GetComponent<Enemy>().Health > 0)
        {
            int choice = Random.Range(1, 4);
            switch (choice)
            {
                case 1:
                    choice1();
                    yield return new WaitForSeconds(5);
                    break;

                default:
                    yield return new WaitForSeconds(Random.Range(1f, 6f));
                    break;
            }

        }
    }
    public virtual float accuracy()
    {
        Debug.Log(BattleController.Player.Agility);
        float hit = (gameObject.GetComponent<Enemy>().Skill / BattleController.Player.Agility) * HitRate;
        return hit;
    }
    public virtual void move()
    {

    }
    protected  virtual void choice1()
    {

    }

    public string MoveName { get; set; }
    public Player Player { get; set; }
    public GameObject Enemy { get; set; }
    public float BrnRate { get; set; }
    public float FrzRate { get; set; }
    public float StnRate { get; set; }
    public float PsnRate { get; set; }
    public float HitRate { get; set; }
    public float DmgX { get; set; }
    public int DmgBoost { get; set; }
    public int EpUse { get; set; }
    public int MpUse { get; set; }
    public float SpUse { get; set; }
    public string Name { get; set; }
    public int Option { get; set; }
}
