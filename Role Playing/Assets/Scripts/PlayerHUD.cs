using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public GameObject spellBookPanel;
    public bool spellBookOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleSpellBook();
        }
    }
    public void ToggleSpellBook()
    {
        spellBookOpen = !spellBookOpen;
        spellBookPanel.SetActive(spellBookOpen);
        Cursor.visible = spellBookOpen;
        if (spellBookOpen == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
    }
}
