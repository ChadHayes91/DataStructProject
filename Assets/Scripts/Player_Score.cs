﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

    private float timeLeft = 200;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f)
        {
            gameObject.GetComponent<Player_Death>().hasDied = true;
        }
	}

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "EndLevel")
        {
            CountScore();
            gameObject.GetComponent<Player_Death>().hasDied = true;
        }
        if (trig.gameObject.tag == "Asset")
        {
            playerScore += 30;
            Destroy(trig.gameObject);   
        }
        if (trig.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<Player_Death>().hasDied = true;
        }
    }

    void CountScore()
    {
        playerScore += (int)(timeLeft * 10);
    }
}