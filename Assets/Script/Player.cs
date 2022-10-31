using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;


public class Player : MonoBehaviour
{
    public string Name;
    public int Level;
    public float EXP;
    public float HP;
    public float SP;
    public float STR;
    public float SPD;
    public int INT;
    public int CON;


    void Save()
    {
        JSONObject playerJson = new JSONObject();
        playerJson.Add("Name", Name);
        playerJson.Add("Level", Name);

        playerJson.Add("EXP", EXP);
        playerJson.Add("HP", HP);
        playerJson.Add("SP", SP);

        playerJson.Add("STR", STR);
        playerJson.Add("SPD", SPD);
        playerJson.Add("INT", INT);
        playerJson.Add("CON", CON);

        JSONArray position=new JSONArray();
        position.Add(transform.position.x);
        position.Add(transform.position.y);
        position.Add(transform.position.z);
        playerJson.Add("Position",position);

        Debug.Log(playerJson.ToString());
        string path = Application.persistentDataPath + "/PlayerSave.json";
        File.WriteAllText(path, playerJson.ToString());


    }
    void Load()
    {
        string path = Application.persistentDataPath + "/PlayerSave.json";
        string jsonString=File.ReadAllText(path);
        JSONObject playerJson=(JSONObject)JSON.Parse(jsonString);
        Name = playerJson["Name"];
        Level= playerJson["Level"];
        
        EXP = playerJson["EXP"];
        HP = playerJson["HP"];
        SP = playerJson["SP"];

        STR = playerJson["STR"];
        SPD = playerJson["SPD"];
        INT = playerJson["INT"];
        CON = playerJson["CON"];

        transform.position = new Vector3(
            playerJson["Position"].AsArray[0],
            playerJson["Position"].AsArray[1],
            playerJson["Position"].AsArray[2]
            );

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) Save();
        if (Input.GetKeyDown(KeyCode.L)) Load();

    }
}
