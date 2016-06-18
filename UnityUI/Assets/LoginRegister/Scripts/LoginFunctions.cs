using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginFunctions : MonoBehaviour {

    private InputField usernameInput;
    private InputField passwordInput;
    private Button loginButton;
    private Button registerButton;

	// Use this for initialization
	void Start () {
        usernameInput = GetComponent<InputField>();
        passwordInput = GetComponent<InputField>();
        loginButton = GetComponent<Button>();
        registerButton = GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoginClicked()
    {
        Debug.Log("Login");
    }

    public void RegisterClicked()
    {
        Debug.Log("Register");
        SceneManager.LoadScene("RegisterScene");
    }
}
