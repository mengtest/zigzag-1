using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	public static UiManager instance;
	public GameObject startPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScoreStart;
	public Text highScoreEnd;



	public void Awake(){
		if (instance == null) {
			instance = this;
		}
	}


	// Use this for initialization
	void Start () {
		highScoreStart.text = "High Score:" + PlayerPrefs.GetInt ("highScore").ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		tapText.SetActive (false);
		startPanel.GetComponent<Animator> ().Play ("panelUp");
	}

	public void GameEnd(){
		score.text = PlayerPrefs.GetInt ("score").ToString ();
		highScoreEnd.text = PlayerPrefs.GetInt ("highScore").ToString ();
		gameOverPanel.SetActive (true);

	}

	public void Reset(){
		SceneManager.LoadScene (0);
	}
}
