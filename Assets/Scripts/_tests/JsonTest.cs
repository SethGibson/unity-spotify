using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JsonTest : MonoBehaviour
{
	public void Start()
    {

	}

	public void Update()
    {
		
	}

    public void parseTest()
    {
        var parsed = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonStrings.Album);

        var albumType = parsed["album_type"].ToString();

        var arr = JsonConvert.DeserializeObject<ArrayList>(parsed["artists"].ToString());
        List<Dictionary<string,object>> artists = new List<Dictionary<string, object>>();
        for(int i=0;i<arr.Count;++i) {
            var artist = JsonConvert.DeserializeObject<Dictionary<string,object>>(arr[i].ToString());
            //parseArtist(artist) 
            artists.Add(artist);
        }

        var markets = JsonConvert.DeserializeObject<List<string>>(parsed["available_markets"].ToString());
        
        arr = JsonConvert.DeserializeObject<ArrayList>(parsed["copyrights"].ToString());
        List<Dictionary<string,string>> copyrights = new List<Dictionary<string, string>>();
        for(int i=0;i<arr.Count;++i) {
            var cr = JsonConvert.DeserializeObject<Dictionary<string,string>>(arr[i].ToString());
            //parseCopyright(cr) 
            copyrights.Add(cr);
        }

        var externalIds = JsonConvert.DeserializeObject<Dictionary<string,string>>(parsed["external_ids"].ToString());
        var externalUrls = JsonConvert.DeserializeObject<Dictionary<string,string>>(parsed["external_urls"].ToString());
        var genres = JsonConvert.DeserializeObject<List<string>>(parsed["genres"].ToString());
        var endpoint = parsed["href"].ToString();
        var id = parsed["id"].ToString();
        
        //images
        var imgs = JsonConvert.DeserializeObject<ArrayList>(parsed["images"].ToString());

        var label = parsed["label"].ToString();
        var name = parsed["name"].ToString();
        var popularity = int.Parse(parsed["popularity"].ToString());
        var releaseDate = parsed["release_date"].ToString();
        var rdPrecision = parsed["release_date_precision"].ToString();

        //tracks

        var uri = parsed["uri"].ToString();

        Debug.Log("stop");
    }
}
