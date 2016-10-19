
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace CL.Spotify {
    class UnityAPI
    {
        #region Enums
        public enum AlbumType {
	        Single,
	        Album,
	        Compilation
        }
        private Dictionary<string, AlbumType> albumTypeMap = new Dictionary<string, AlbumType>
        {
            { "album", AlbumType.Album },
            { "compilation", AlbumType.Compilation },
            { "single", AlbumType.Single }
        };

        public enum DatePrecision {
	        Year,
	        Month,
	        Day
        }
        private Dictionary<string, DatePrecision> dateResMap = new Dictionary<string, DatePrecision>
        {
            { "day", DatePrecision.Day },
            { "month", DatePrecision.Month },
            { "year", DatePrecision.Year }
        };

        public enum ProductType {
            Free,
            Premium,
            Family,
            Student
        }
        private Dictionary<string, ProductType> productTypeMap = new Dictionary<string, ProductType>
        {
            { "free", ProductType.Free },
            { "premium", ProductType.Premium },
            { "family", ProductType.Family },
            { "student", ProductType.Student }
        };

        public enum PlaylistStatus {
            Public,
            Private,
            NA
        }

        public enum ExtIdType {
            Upc,
            Ean,
            Isrc
        }
        private Dictionary<string, ExtIdType> extIdMap = new Dictionary<string, ExtIdType>
        {
            { "upc", ExtIdType.Upc },
            { "ean", ExtIdType.Ean },
            { "isrc", ExtIdType.Isrc }
        };

        public enum ExtUrlType {
            Spotify,
            Other
        }
        #endregion

        #region Structs
        public struct Copyright {
	        public enum Type {
		        C,
		        P
	        } 
	        public Type    Rights;   
	        public string  value;
        }

        public struct ExternalID {
	        public ExtIdType IdType;
	        public string value;
        }

        public struct ExternalURL {
	        public ExtUrlType UrlType;
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
            public ExternalURL      ExternalUrls;
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
            private ProductType         Product;
    
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

        #endregion

        #region API
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
        #endregion

        #region Parsers
        private TrackLink parseTrackLink(string json)
        {
            return new TrackLink();
        }

        private ExternalID parseExternalID(Dictionary<string,string> json)
        {
            return new ExternalID();
        }

        private Copyright parseCopyright(Dictionary<string, string> json)
        {
            var retval = new Copyright();
            var cOrP = json["type"];
            if(cOrP=="C")
                retval.Rights = Copyright.Type.C;
            else
                retval.Rights = Copyright.Type.P;
            retval.value = json["text"];

            return retval;
        }

        private List<SPImage> parseImage(Dictionary<string,object> json)
        {
            var retval = new List<SPImage>();
            retval.Height = int.Parse(json["height"].ToString());
            retval.Width = int.Parse(json["width"].ToString());
            retval.Url = json["url"].ToString();

            return retval;
        }

        private ExternalURL parseExternalURL(Dictionary<string,string> json)
        {
            var retval = new ExternalURL();
            foreach(var k in json.Keys) {
                if(k=="spotify")
                    retval.UrlType=ExtUrlType.Spotify;
                else
                    retval.UrlType=ExtUrlType.Other;

                retval.value = json[k];
            }

            return retval;
        }

        private Followers parseFollowers(Dictionary<string,object> json)
        {
            var retval = new Followers();

            retval.Endpoint = json["href"].ToString();
            retval.Total = int.Parse(json["total"].ToString());
            return retval;
        }

        private Artist parseArtist(Dictionary<string,object> json)
        {
            var retval = new Artist();
            retval.Simplified = false;
            retval.ExternalUrls = parseExternalURL(JsonConvert.DeserializeObject<Dictionary<string,string>>(json["external_urls"].ToString()));
            retval.Endpoint = json["href"].ToString();
            retval.Id = json["id"].ToString();
            retval.Name = json["name"].ToString();
            retval.Uri = json["uri"].ToString();
            if(!json.ContainsKey("followers")) {
                retval.Simplified = true;
                return retval;
            }

            retval.Genres = JsonConvert.DeserializeObject<List<string>>(json["genres"].ToString());
            retval.Followers = parseFollowers(JsonConvert.DeserializeObject<Dictionary<string,object>>(json["followers"].ToString()));

            retval.Images = new List<SPImage>();
            var srcimages = JsonConvert.DeserializeObject<ArrayList>(json["images"].ToString());
            for(int i=0;i<srcimages.Count;++i) {
                var img = JsonConvert.DeserializeObject<Dictionary<string,object>>(srcimages[i].ToString());
                retval.Images.Add(parseImage(img));
            }

            retval.Popularity = int.Parse(json["popularity"].ToString());
            return retval;
        }

        private Album parseAlbum(string json)
        {
            var retval = new Album();
            var parsed = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            var albumType = parsed["album_type"].ToString();
            retval.AlbumType = albumTypeMap[albumType];

            var arr = JsonConvert.DeserializeObject<ArrayList>(parsed["artists"].ToString());
            for(int i=0;i<arr.Count;++i) {
                var artist = JsonConvert.DeserializeObject<Dictionary<string,object>>(arr[i].ToString());
                retval.Artists.Add(parseArtist(artist));
            }

            retval.AvailableMarkets = JsonConvert.DeserializeObject<List<string>>(parsed["available_markets"].ToString());
        
            arr = JsonConvert.DeserializeObject<ArrayList>(parsed["copyrights"].ToString());
            List<Dictionary<string,string>> copyrights = new List<Dictionary<string, string>>();
            for(int i=0;i<arr.Count;++i) {
                var cr = JsonConvert.DeserializeObject<Dictionary<string,string>>(arr[i].ToString());
                retval.Copyrights.Add(parseCopyright(cr));
            }

            var externalIds = JsonConvert.DeserializeObject<Dictionary<string,string>>(parsed["external_ids"].ToString());
            retval.ExternalIds = parseExternalID(externalIds);
            var externalUrls = JsonConvert.DeserializeObject<Dictionary<string,string>>(parsed["external_urls"].ToString());
            retval.Genres = JsonConvert.DeserializeObject<List<string>>(parsed["genres"].ToString());
            retval.Endpoint = parsed["href"].ToString();
            retval.Id = parsed["id"].ToString();
        
            //images

            retval.Label = parsed["label"].ToString();
            retval.Name = parsed["name"].ToString();
            retval.Popularity = int.Parse(parsed["popularity"].ToString());
            retval.ReleaseDate = parsed["release_date"].ToString();
            var rdPrecision = parsed["release_date_precision"].ToString();
            retval.ReleaseDatePrecision = dateResMap[rdPrecision];

            //tracks

            retval.Uri = parsed["uri"].ToString();

            return retval;
        }


        private Track parseTrack(string json)
        {
            return new Track();
        }

        private User parseUser(string json)
        {
            return new User();
        }

        private Playlist parsePlaylist(string json)
        {
            return new Playlist();
        }
        #endregion
    }
}