using UnityEngine;
using System.Collections;

public class gameSquare : MonoBehaviour {

	void OnMouseUp()
    {
        if (gameManager.gameOver) return;
        gameManager.EndTurn(this.transform);
        gameObject.SetActive(false);
    }
    
}
