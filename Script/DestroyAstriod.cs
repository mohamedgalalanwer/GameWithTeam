using UnityEngine;
using System.Collections;

public class DestroyAstriod : MonoBehaviour {

	public GameObject explosion, playerExplosion;

	public int scoreValue;
	private GameController gameController;



	// Use this for initialization



	void Start(){
	
		GameObject gameObjectController = GameObject.FindWithTag ("GameController");

		if (gameObjectController != null) {
			gameController=	gameObjectController.GetComponent<GameController>();
		
		}

	
	
	}


	void OnTriggerEnter(Collider other){

		//no every thing occuer 
		if (other.tag == "Boundary") {
			return;

		}



		// if every thing collide  the stone   occure  particler system  and destroy  to both 


		Instantiate (explosion, transform.position, transform.rotation);





		// if  player==other  collide the stone   game over and particiler system
		if(other.tag=="Player"){


			Instantiate (playerExplosion,other. transform.position, other.transform.rotation);

			gameController.GameOver ();

		}

				gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy (gameObject);
	}

}
