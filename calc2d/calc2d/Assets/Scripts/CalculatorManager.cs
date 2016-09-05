using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CalculatorManager : MonoBehaviour {

	public Text result;
	public Button btn1;
	public Button btn2;
	public Button btn3;
	public Button btn4;
	public Button btn5;
	public Button btn6;
	public Button btn7;
	public Button btn8;
	public Button btn9;
	public Button btn0;

	void Start()
	{
		result = GameObject.Find("result").GetComponent<Text>();
	}

	void addNumber(Text number)
	{
		string total = result.text;

		if (total == "0") {
			total = "";
		}

		total += number.text;

		result.text = total;
	}
	
	void cleanNumbers()
	{
		result.text = "0";
	}
}
