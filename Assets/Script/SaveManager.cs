using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { set; get; }
    public SaveState state;


    private void Awake() {
        DontDestroyOnLoad(gameObject);
        Instance = this;
        Load();
        Debug.Log(SaveHelper.Serialize<SaveState>(state));
    }

    // Save the whole state of this saveState script to the player pref
    public void Save() {
        PlayerPrefs.SetString("save", SaveHelper.Serialize<SaveState>(state));
    }


    // load the previous saved state from the player pref
    public void Load() {
        if (PlayerPrefs.HasKey("save"))
        {
            state = SaveHelper.Deserialize<SaveState>(PlayerPrefs.GetString("save"));
        }
        else
        {
            state = new SaveState();
            Save();
            Debug.Log("No save file found, creating a new one.");
        }
    }
}