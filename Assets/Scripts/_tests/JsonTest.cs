using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JsonTest : MonoBehaviour
{
    private string json = "{\"arrkey\":[{\"akey\":\"avalue\"}]}";
	public void Start()
    {
        var parsed = JObject.Parse(json);
        Debug.Log(parsed);
	}
	
	public void Update()
    {
		
	}
}
