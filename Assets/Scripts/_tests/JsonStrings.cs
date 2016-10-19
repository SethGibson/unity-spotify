using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JsonStrings
{
    public static string Artist = "{" +
        "\"external_urls\" : {" +
        "\"spotify\" : \"https://open.spotify.com/artist/0OdUWJ0sBjDrqHygGUXeCF\"" +
        "}," +
        "\"followers\" : {" +
        "\"href\" : null," +
        "\"total\" : 306565" +
        "}," +
        "\"genres\" : [ \"indie folk\", \"indie pop\" ]," +
        "\"href\" : \"https://api.spotify.com/v1/artists/0OdUWJ0sBjDrqHygGUXeCF\"," +
        "\"id\" : \"0OdUWJ0sBjDrqHygGUXeCF\"," +
        "\"images\" : [ {" +
        "\"height\" : 816," +
        "\"url\" : \"https://i.scdn.co/image/eb266625dab075341e8c4378a177a27370f91903\"," +
        "\"width\" : 1000" +
        "}, {" +
        "\"height\" : 522," +
        "\"url\" : \"https://i.scdn.co/image/2f91c3cace3c5a6a48f3d0e2fd21364d4911b332\"," +
        "\"width\" : 640" +
        "}, {" +
        "\"height\" : 163," +
        "\"url\" : \"https://i.scdn.co/image/2efc93d7ee88435116093274980f04ebceb7b527\"," +
        "\"width\" : 200" +
        "}, {" +
        "\"height\" : 52," +
        "\"url\" : \"https://i.scdn.co/image/4f25297750dfa4051195c36809a9049f6b841a23\"," +
        "\"width\" : 64" +
        "} ]," +
        "\"name\" : \"Band of Horses\"," +
        "\"popularity\" : 59," +
        "\"type\" : \"artist\"," +
        "\"uri\" : \"spotify:artist:0OdUWJ0sBjDrqHygGUXeCF\"" +
        "}";

    public static string Album = "{"+
        "\"album_type\" : \"album\","+
        "\"artists\" : [ {"+
        "\"external_urls\" : {"+
            "\"spotify\" : \"https://open.spotify.com/artist/2BTZIqw0ntH9MvilQ3ewNY\""+
        "},"+
        "\"href\" : \"https://api.spotify.com/v1/artists/2BTZIqw0ntH9MvilQ3ewNY\","+
        "\"id\" : \"2BTZIqw0ntH9MvilQ3ewNY\","+
        "\"name\" : \"Cyndi Lauper\","+
        "\"type\" : \"artist\","+
        "\"uri\" : \"spotify:artist:2BTZIqw0ntH9MvilQ3ewNY\""+
        "} ],"+
        "\"available_markets\" : [ \"AD\", \"AR\", \"AT\", \"AU\", \"BE\" ],"+
        "\"copyrights\" : [ {"+
        "\"text\" : \"(P) 2000 Sony Music Entertainment Inc.\","+
        "\"type\" : \"P\""+
        "} ],"+
        "\"external_ids\" : {"+
        "\"upc\" : \"5099749994324\""+
        "},"+
        "\"external_urls\" : {"+
        "\"spotify\" : \"https://open.spotify.com/album/0sNOF9WDwhWunNAHPD3Baj\""+
        "},"+
        "\"genres\" : [ ],"+
        "\"href\" : \"https://api.spotify.com/v1/albums/0sNOF9WDwhWunNAHPD3Baj\","+
        "\"id\" : \"0sNOF9WDwhWunNAHPD3Baj\","+
        "\"images\" : [ {"+
        "\"height\" : 640,"+
        "\"url\" : \"https://i.scdn.co/image/07c323340e03e25a8e5dd5b9a8ec72b69c50089d\","+
        "\"width\" : 640"+
        "}, {"+
        "\"height\" : 300,"+
        "\"url\" : \"https://i.scdn.co/image/8b662d81966a0ec40dc10563807696a8479cd48b\","+
        "\"width\" : 300"+
        "}, {"+
        "\"height\" : 64,"+
        "\"url\" : \"https://i.scdn.co/image/54b3222c8aaa77890d1ac37b3aaaa1fc9ba630ae\","+
        "\"width\" : 64"+
        "} ],"+
        "\"name\" : \"She's So Unusual\","+
        "\"popularity\" : 39,"+
        "\"release_date\" : \"1983\","+
        "\"release_date_precision\" : \"year\","+
        "\"tracks\" : {"+
        "\"href\" : \"https://api.spotify.com/v1/albums/0sNOF9WDwhWunNAHPD3Baj/tracks?offset=0&limit=50\","+
        "\"items\" : [ {"+
            "\"artists\" : [ {"+
            "\"external_urls\" : {"+
                "\"spotify\" : \"https://open.spotify.com/artist/2BTZIqw0ntH9MvilQ3ewNY\""+
            "},"+
            "\"href\" : \"https://api.spotify.com/v1/artists/2BTZIqw0ntH9MvilQ3ewNY\","+
            "\"id\" : \"2BTZIqw0ntH9MvilQ3ewNY\","+
            "\"name\" : \"Cyndi Lauper\","+
            "\"type\" : \"artist\","+
            "\"uri\" : \"spotify:artist:2BTZIqw0ntH9MvilQ3ewNY\""+
            "} ],"+
            "\"available_markets\" : [ \"AD\", \"AR\", \"AT\", \"AU\", \"BE\", \"BG\", \"BO\", \"BR\", \"CA\" ],"+
            "\"disc_number\" : 1,"+
            "\"duration_ms\" : 305560,"+
            "\"explicit\" : false,"+
            "\"external_urls\" : {"+
            "\"spotify\" : \"https://open.spotify.com/track/3f9zqUnrnIq0LANhmnaF0V\""+
            "},"+
            "\"href\" : \"https://api.spotify.com/v1/tracks/3f9zqUnrnIq0LANhmnaF0V\","+
            "\"id\" : \"3f9zqUnrnIq0LANhmnaF0V\","+
            "\"name\" : \"Money Changes Everything\","+
            "\"preview_url\" : \"https://p.scdn.co/mp3-preview/01bb2a6c9a89c05a4300aea427241b1719a26b06\","+
            "\"track_number\" : 1,"+
            "\"type\" : \"track\","+
            "\"uri\" : \"spotify:track:3f9zqUnrnIq0LANhmnaF0V\""+
        "} ],"+
        "\"limit\" : 50,"+
        "\"next\" : null,"+
        "\"offset\" : 0,"+
        "\"previous\" : null,"+
        "\"total\" : 13"+
        "},"+
        "\"type\" : \"album\","+
        "\"uri\" : \"spotify:album:0sNOF9WDwhWunNAHPD3Baj\""+
        "}";

    public static string Track = "{"+
        "\"album\": {"+
        "\"album_type\": \"album\","+
        "\"external_urls\": {"+
            "\"spotify\": \"https://open.spotify.com/album/6TJmQnO44YE5BtTxH8pop1\""+
        "},"+
        "\"href\": \"https://api.spotify.com/v1/albums/6TJmQnO44YE5BtTxH8pop1\","+
        "\"id\": \"6TJmQnO44YE5BtTxH8pop1\","+
        "\"images\": ["+
            "{"+
            "\"height\": 640,"+
            "\"url\": \"https://i.scdn.co/image/8e13218039f81b000553e25522a7f0d7a0600f2e\","+
            "\"width\": 629"+
            "},"+
            "{"+
            "\"height\": 300,"+
            "\"url\": \"https://i.scdn.co/image/8c1e066b5d1045038437d92815d49987f519e44f\","+
            "\"width\": 295"+
            "},"+
            "{"+
            "\"height\": 64,"+
            "\"url\": \"https://i.scdn.co/image/d49268a8fc0768084f4750cf1647709e89a27172\","+
            "\"width\": 63"+
            "}"+
        "],"+
        "\"name\": \"Hot Fuss\","+
        "\"type\": \"album\","+
        "\"uri\": \"spotify:album:6TJmQnO44YE5BtTxH8pop1\""+
        "},"+
        "\"artists\": ["+
        "{"+
            "\"external_urls\": {"+
            "\"spotify\": \"https://open.spotify.com/artist/0C0XlULifJtAgn6ZNCW2eu\""+
            "},"+
            "\"href\": \"https://api.spotify.com/v1/artists/0C0XlULifJtAgn6ZNCW2eu\","+
            "\"id\": \"0C0XlULifJtAgn6ZNCW2eu\","+
            "\"name\": \"The Killers\","+
            "\"type\": \"artist\","+
            "\"uri\": \"spotify:artist:0C0XlULifJtAgn6ZNCW2eu\""+
        "}"+
        "],"+
        "\"available_markets\": [ \"AD\", \"AR\", \"TW\", \"UY\" ],"+
        "\"disc_number\": 1,"+
        "\"duration_ms\": 222075,"+
        "\"explicit\": false,"+
        "\"external_ids\": {"+
        "\"isrc\": \"USIR20400274\""+
        "},"+
        "\"external_urls\": {"+
        "\"spotify\": \"https://open.spotify.com/track/0eGsygTp906u18L0Oimnem\""+
        "},"+
        "\"href\": \"https://api.spotify.com/v1/tracks/0eGsygTp906u18L0Oimnem\","+
        "\"id\": \"0eGsygTp906u18L0Oimnem\","+
        "\"name\": \"Mr. Brightside\","+
        "\"popularity\": 0,"+
        "\"preview_url\": \"http://d318706lgtcm8e.cloudfront.net/mp3-preview/f454c8224828e21fa146af84916fd22cb89cedc6\","+
        "\"track_number\": 2,"+
        "\"type\": \"track\","+
        "\"uri\": \"spotify:track:0eGsygTp906u18L0Oimnem\""+
       "}";
}
