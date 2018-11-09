﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticScoreTrigger : MonoBehaviour {
	public ScoreBoard scoreBoard;
	void OnTriggerEnter(Collider col){	
		switch(col.tag){
			case "PlasticTrash":
				scoreBoard.handleScored();
				break;
			case "PaperTrash":
				scoreBoard.handleWrongScored();
				break;
			case "MetalTrash":
				scoreBoard.handleWrongScored();
				break;
			case "GlassTrash":
				scoreBoard.handleWrongScored();
				break;
			case "Waste":
				scoreBoard.handleWrongScored();
				break;
		}	
			Trash trash = col.gameObject.GetComponent<Trash>();
			trash.setSpeedToZero();
	}
}
