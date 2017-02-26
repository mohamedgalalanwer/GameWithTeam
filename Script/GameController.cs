using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject hazared;
	public Vector3 spawnValue;
	public float count;
	public float statrWait;
	public float endWait;
	public float waveWate;


	private int scoreValue;
	public Text scoreText;
	public Text gameOverText;
	public Text restartText;

	private bool gameOver;
	private bool restart;

	// Use this for initialization
	void Start () {

		scoreValue = 0;
		UpdateScore ();

		gameOverText.text = "";
		restartText.text = "";
		gameOver = false;
		restart = false;



		StartCoroutine(	Spwan ());
	
	}

	void Update(){
	
		if (restart) {
		
			if (Input.GetKey (KeyCode.R)) {
				Application.LoadLevel (Application.loadedLevel);
			
			}
		
		
		
		}
	
	
	}


	IEnumerator Spwan(){
		while (true) {

			yield return new WaitForSeconds (statrWait);
			for (int i = 0; i <= count; i++) {
	
				Vector3 spawnPostion = new Vector3 (Random.Range (-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
				Quaternion spawnRotate = Quaternion.identity;

				Instantiate (hazared, spawnPostion, spawnRotate);
				yield return new WaitForSeconds (endWait);
		
			}
		
			yield return new WaitForSeconds (waveWate);

			if (gameOver) {
			
				restartText.text = "Press 'R' to Restart";
				restart = true;
			
				break;
			}

		}
	}





	public	void AddScore (int scoreUpdate){
	
		scoreValue += scoreUpdate;
		UpdateScore ();
	
	}


	public	void UpdateScore(){
	
		scoreText.text = "Count : " + scoreValue;
	
	
	}

	public	void GameOver(){
		gameOverText.text = "GameOver!";

		gameOver = true;
	
	
	}


	// Update is called once per frame

}
