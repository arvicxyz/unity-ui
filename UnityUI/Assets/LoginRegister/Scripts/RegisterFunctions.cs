using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterFunctions : MonoBehaviour {

    private InputField emailInput;
    private InputField usernameInput;
    private InputField passwordInput;
    private InputField confirmPasswordInput;
    private InputField fullnameInput;
    private ToggleGroup genderToggleGroup;
    private Button submitButton;
    private Button cancelButton;

    // Use this for initialization
    void Start () {
        emailInput = GetComponent<InputField>();
        usernameInput = GetComponent<InputField>();
        passwordInput = GetComponent<InputField>();
        confirmPasswordInput = GetComponent<InputField>();
        fullnameInput = GetComponent<InputField>();
        genderToggleGroup = GetComponent<ToggleGroup>();
        submitButton = GetComponent<Button>();
        cancelButton = GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SubmitClicked()
    {
        Debug.Log("Submit");
    }

    public void CancelClicked()
    {
        Debug.Log("Cancel");
        SceneManager.LoadScene("LoginScene");
    }
}
