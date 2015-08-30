using UnityEngine;
using System.Collections;

namespace _2DCharacter
{

	public class Score : MonoBehaviour
	{
		public int score = 0;					// The player's score.


		private Platformer2DUserControl playerControl;	// Reference to the player control script.
		private int previousScore = 0;			// The score in the previous frame.


		void Awake ()
		{
			// Setting up the reference.
			playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<Platformer2DUserControl>();
		}


		void Update ()
		{
			// Set the score text.
			GetComponent<GUIText>().text = "Score: " + score;

			// If the score has changed...
			if(previousScore != score)
				// ... play a taunt.
				//playerControl.StartCoroutine(playerControl.Taunt());

			// Set the previous score to this frame's score.
			previousScore = score;
		}

	}

}