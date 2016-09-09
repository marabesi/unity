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
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) {
			result.text = string.Concat(result.text, "0");
		}

		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
			result.text = string.Concat(result.text, "1");
		}

		if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
			result.text = string.Concat(result.text, "2");
		}

		if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
			result.text = string.Concat(result.text, "3");
		}

		if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
			result.text = string.Concat(result.text, "4");
		}

		if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
			result.text = string.Concat(result.text, "5");
		}

		if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
			result.text = string.Concat(result.text, "6");
		}

		if( Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
			result.text = string.Concat(result.text, "7");
		}

		if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
			result.text = string.Concat(result.text, "8");
		}

		if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
			result.text = string.Concat(result.text, "9");
		}

		if (Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.Backspace)) {
			result.text = result.text.Remove(result.text.Length - 1);
		}
	}

	public void addNumber(Text number)
	{
		string total = result.text;

		if (total == "0") {
			total = "";
		}

		total = string.Concat(total, number.text);

		result.text = total;
	}
	
	public void cleanNumbers()
	{
		result.text = "0";
	}
}
