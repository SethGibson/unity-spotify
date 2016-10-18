
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace CL.Spotify {
    class UnityAPI
    {
        public enum AlbumType {
	        Single,
	        Album,
	        Compilation
        }

        public enum DatePrecision {
	        Year,
	        Month,
	        Day
        }

        public enum Product {
            Free,
            Premium,
            Famlily,
            Student
        }

        public enum PlaylistStatus {
            Public,
            Private,
            NA
        }

        public enum EIdType {
            Upc,
            Ean,
            Isrc
        }

        public enum EUrlType {
            Spotify,
            Other
        }

        public struct Copyright {
	        public enum Type {
		        C,
		        P
	        } 
	        public Type    Rights;   
	        public string  value;
        }

        public struct ExternalID {
	        public EIdType IdType;
	        public string value;
        }

        public struct ExternalURL {
	        public EUrlType UrlType;
	        public string value;
        }

        public struct SPImage {
            public int     Height;
            public int     Width;
            public string  Url;

            public Texture2D GetTexture()
            {
                return new Texture2D(Width,Height);
            }
        }

        public struct Followers {
            public string  Endpoint;   // "href"
            public int     Total;
        }

        public struct TrackLink {
            public List<ExternalURL>    ExternalUrls;
            public string               EndPoint; //"href"
            public string               Id;
            public string               Uri;
        }

        public struct Album {
	        public AlbumType	    AlbumType;
	        public List<Artist>	    Artists;
	        public List<string>	    AvailableMarkets;
	        public List<Copyright>  Copyrights;
	        public List<ExternalID> ExternalIds;
            public List<ExternalURL>    ExternalUrls;
	        public List<string>	    Genres;
	        public string		    Endpoint;   // "href"
	        public string		    Id;
	        public List<SPImage>    Images;
	        public string		    Label;
	        public string			Name;
	        public int				Popularity;
	        public string			ReleaseDate;
	        public DatePrecision	ReleaseDatePrecision;
	        public List<Track>		Tracks;
	        public string			Uri;
            public bool             Simplified;
        }

        public struct Artist {
            public List<ExternalURL>    ExternalUrls;
	        public Followers	    Followers;
	        public List<string>	    Genres;
	        public string		    Endpoint; // "href"
	        public string		    Id;
	        public List<SPImage>    Images;
	        public string		    Name;
	        public int              Popularity;
            public string           Uri;
            public bool             Simplified;
        }

        public struct Track {
	        public AlbumType        AlbumType;
	        public List<Artist>	    Artists;
	        public List<string>	    AvailableMarkets;
	        public int              DiskNumber;
            public int              DurationMS;
            public bool             Explicit;
	        public ExternalID	    ExternalIds;
	        public ExternalURL	    ExternalUrls;
	        public List<string>	    Genres;
	        public string		    Endpoint;   // "href"
	        public string		    Id;
	        public bool             IsPlayable;
            public TrackLink        LinkedFrom;
	        public string		    Name;
	        public int			    Popularity;
	        public string		    PreviewUrl;
            public int              TrackNumber;
	        public string		    Uri;
            public bool             Simplified;
        }

        public struct User {
            private string          BirthDate;
            private string          Country;
            private string          Email;
            private Followers       Followers;
            private Product         Product;
    
            public string           DisplayName;
            public ExternalURL      ExternalUrls;
            public string           Endpoint;    //"href"
            public string           Id;
	        public List<SPImage>    Images;
            public string           Uri;
        }

        public struct Playlist {
            public bool             Collaborative;
            public string           Description;
            Followers               Followers;
            string                  Endpoint; //"href"
            string                  Id;
	        public List<SPImage>    Images;
            string                  Name;
            User                    Owner;
            object                  Public;
            string                  SnapshotId;
	        public List<Track>		Tracks;
            string                  Uri;
        }

        public User GetUserProfile(string userId)
        {
            return new User();
        }

        public List<Playlist> SearchForPlaylist(string playlistName)
        {
            return new List<Playlist>();
        }

        public List<Album> SearchForAlbum(string album)
        {
            return new List<Album>();
        }

        public Album GetAlbum(string albumId)
        {
            return new Album();
        }

        public List<Album> GetAlbums(string[] albumIds)
        {
            return new List<Album>();
        }

        public List<Album> GetAlbumList(string artistId)
        {
            return new List<Album>();        
        }

        public List<Artist> SearchForArtist(string artist)
        {
            return new List<Artist>();
        }
        public Artist GetArtist(string artistId)
        {
            return new Artist();
        }

        public List<Artist> GetArtists(string[] artistIds)
        {
            return new List<Artist>();
        }

        public List<Artist> GetRelatedArtists(string artistId)
        {
            return new List<Artist>();
        }

        public List<Track> SearchForTrack(string trackName)
        {
            return new List<Track>();
        }

        public List<Track> GetTrack(string trackId)
        {
            return new List<Track>();
        }

        public List<Track> GetTracks(string[] trackIds)
        {
            return new List<Track>();
        }

        public List<Track> GetTrackList(string albumId)
        {
            return new List<Track>();
        }

        public List<Track> GetTopTracks(string id)
        {
            return new List<Track>();
        }

        #region object parsing
        private Copyright parseCopyright(string json)
        {
            var retval = new Copyright();
            var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);
            retval.value = dict["text"];
            var crt = dict["type"];
            if(crt=="C")
                retval.Rights = Copyright.Type.C;
            else
                retval.Rights = Copyright.Type.P;

            return retval;
        }

        private List<ExternalID> parseExternalID(string json)
        {
            // "external_ids" : { "upc" : "XXXXXXXXXXXX", "ean" : "YYYYYYYYYYYYY", "isrc" : "ZZZZZZZZZZZZZ"}
            var retval = new List<ExternalID>();
            var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);
            /*
            dict["upc"]="XXXXXXXXXXXXX";
            dict["ean"]="YYYYYYYYYYYYY"
            dict["isrc"]="ZZZZZZZZZZZZZ"
            */

            foreach(var k in dict.Keys) {
                var eid = new ExternalID();
                switch(k) {
                    case "upc":
                        eid.IdType = EIdType.Upc;
                        break;
                    case "ean":
                        eid.IdType = EIdType.Ean;
                        break;
                    case "isrc":
                        eid.IdType = EIdType.Isrc;
                        break;
                }
                
                eid.value = dict[k];
                retval.Add(eid);
            }

            return retval;
        }

        private List<ExternalURL> parseExternalURL(string json)
        {
            var retval = new List<ExternalURL>();
	        var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);
            foreach(var k in dict.Keys) {
                var eid = new ExternalURL();
                switch(k) {
                    case "spotify":
                        eid.UrlType = EUrlType.Spotify;
                        break;
                    default:
                        eid.UrlType = EUrlType.Other;
                        break;
                }
                
                eid.value = dict[k];
                retval.Add(eid);
            }

            return retval;
        }

        private List<SPImage> parseImage(string json)
        {
            var retval = new List<SPImage>();

            return retval;
        }

        private Followers parseFollowers(string json)
        {
            var retval = new Followers();
	        var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);

            retval.Endpoint = dict["href"];
            retval.Total = int.Parse(dict["total"]);

            return retval;
        }

        private TrackLink parseTrackLink(string json)
        {
            var retval = new TrackLink();
	        var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);

            retval.EndPoint = dict["href"];
            retval.ExternalUrls = parseExternalURL(dict["external_urls"]);
            retval.Id = dict["id"];
            retval.Uri = dict["uri"];

            return retval;
        }

        /*
"artists" : [ {"external_urls" : {"spotify" : "https://open.spotify.com/artist/2BTZIqw0ntH9MvilQ3ewNY"
    },
    "href" : "https://api.spotify.com/v1/artists/2BTZIqw0ntH9MvilQ3ewNY",
    "id" : "2BTZIqw0ntH9MvilQ3ewNY",
    "name" : "Cyndi Lauper",
    "type" : "artist",
    "uri" : "spotify:artist:2BTZIqw0ntH9MvilQ3ewNY"
  } ],
        */
        private List<Artist> parseArtist(string json)
        {
            var retval = new List<Artist>();


            return retval;
        }

        private Album parseAlbum(string json)
        {
            var retval = new Album();
            var dict = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);

            var atype = dict["album_type"];
            switch(atype) {
                case "album":
                    retval.AlbumType = AlbumType.Album;
                    break;
                case "single":
                    retval.AlbumType = AlbumType.Single;
                    break;
                case "compilation":
                    retval.AlbumType = AlbumType.Compilation;
                    break;
            }

            retval.Simplified = !dict.ContainsKey("copyrights");
            retval.AvailableMarkets = JsonConvert.DeserializeObject<List<string>>(dict["available_markets"]);
            retval.ExternalUrls = parseExternalURL(dict["external_urls"]);
            retval.Endpoint = dict["href"];
            retval.Id = dict["id"];
            retval.Images = parseImage(dict["images"]);
            retval.Name = dict["name"];
            retval.Uri = dict["uri"];
            if(retval.Simplified)
                return retval;

            retval.Artists = parseArtist(dict["artists"]);
            //retval.Copyrights = parseC
            return retval;
        }


        private Track parseTrack(string json)
        {
            var retval = new Track();

            return retval;
        }

        private User parseUser(string json)
        {
            var retval = new User();

            return retval;
        }

        private Playlist parsePlaylist(string json)
        {
            var retval = new Playlist();

            return retval;
        }
        #endregion
    }
}