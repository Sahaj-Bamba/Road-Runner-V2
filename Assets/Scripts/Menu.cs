﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene(3);
	}
	
	public void LevelUp()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void StartMenu(){
		SceneManager.LoadScene(0);
	}

	public void Leaderboard(){
		SceneManager.LoadScene(1);
	}

	public void Instruction(){
		SceneManager.LoadScene(2);
	}

}
