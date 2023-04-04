using UnityEngine;

/// <summary>
/// Class <c> SaveGameManager</c> saves and loads data to the SaveData object
/// </summary>
public static class SaveGameManager {
    /// <summary>
    /// Method <c>Save</c> saves data in SaveData object.
    /// </summary>
    public static void Save(SaveData data) {
    
        PlayerPrefs.SetInt("Level", data.level);
        
        PlayerPrefs.SetString("Language", data.lang);
        
        PlayerPrefs.SetInt("Level1Score", data.lv1scr);
        PlayerPrefs.SetInt("Level2Score", data.lv2scr);
        PlayerPrefs.SetInt("Level3Score", data.lv3scr);
        PlayerPrefs.SetInt("Level4Score", data.lv4scr);
        
        PlayerPrefs.Save();
    }
    
    /// <summary>
    /// Method <c>Load</c> loads data in SaveData object. If there is no data saved before, it returns the default values of the object.
    /// </summary>
    public static SaveData Load() {
        SaveData data = new SaveData();
        
        data.level = PlayerPrefs.GetInt("Level", data.level);
        
        data.lang = PlayerPrefs.GetString("Language", data.lang);
        
        data.lv1scr = PlayerPrefs.GetInt("Level1Score", data.lv1scr);
        data.lv2scr = PlayerPrefs.GetInt("Level2Score", data.lv2scr);
        data.lv3scr = PlayerPrefs.GetInt("Level3Score", data.lv3scr);
        data.lv4scr = PlayerPrefs.GetInt("Level4Score", data.lv4scr);
        
        return data;
    }
}
