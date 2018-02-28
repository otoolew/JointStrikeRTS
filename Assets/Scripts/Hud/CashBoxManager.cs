using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CashBoxManager : MonoBehaviour {

	public Text CashField;
	
	void Update () {
		CashField.text = "$ " + (int)Player.Default.Credits;
	}
}
