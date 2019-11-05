﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class MovingWaypoint : MonoBehaviour
{
    string jsonString;
    JsonData itemData;
    Vector3 TempPos;

    // Start is called before the first frame update
    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/JSONFiles/HjsonData.json"); //Adds all text from json file to a string
        itemData = JsonMapper.ToObject(jsonString);

        TempPos = transform.position; // set vector variable as the x,y,z position of the object

        // set variables for the x,y,z data coming from the JSON file
        int json_x = (int) itemData["x"];
        int json_y = (int) itemData["y"];
        int json_z = (int) itemData["z"];

        // change the current x,y,z values to the new x,y,z values
        TempPos.x = json_x;
        TempPos.y = json_y;
        TempPos.z = json_z;

        // finally change the current position to the new position
        transform.position = TempPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
