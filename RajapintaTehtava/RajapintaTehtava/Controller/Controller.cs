using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;

namespace RajapintaTehtava.Controller
{
    internal class Controller
    {
        Model.Model model = new Model.Model();

        /// <summary>
        /// Gets result from API and returns a response object.
        /// </summary>
        /// <param name="searchObject"></param>
        /// <returns></returns>
        public Search.Response APISearch(Search.Search searchObject)
        {
            try
            {
                // Creating the URL

                if (searchObject.Key == "") searchObject.Key = "DEMO_KEY"; // If user doesn't have an auth key, use demo key instead.
                                                                           // !NOTE: DEMO_KEY can do only very limited amount of requests
                var url = "https://api.nasa.gov/planetary/apod?api_key=" + searchObject.Key;
                switch (searchObject.SearchType)
                {
                    case ("date"): // If searching by date, format the given date to the right format
                        if (searchObject.Date < DateTime.Parse("1995-06-16")) url = url + "&date=1995-06-16";
                        else if (searchObject.Date > DateTime.Now) { } // Without date parameter the result will be the latest pic
                        else url = url + "&date=" + searchObject.Date.ToString("yyyy-MM-dd");
                        break;
                    case ("random"): // If searching by random, add a count=1 parameter.
                        url = url + "&count=1";
                        break;
                }

                // Creating/sending GET request

                Console.WriteLine($"Sending request: {url}");
                var req = WebRequest.Create(url);
                req.Method = "GET";
                var webResponse = req.GetResponse();
                var webStream = webResponse.GetResponseStream();

                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                // Deserializing json string

                Search.Response responseObject = null;
                if (searchObject.SearchType == "random") // When GET query includes COUNT, result will be given in a list of objects.
                {
                    var responseObjects = JsonConvert.DeserializeObject<List<Search.Response>>(data);
                    responseObject = responseObjects[0];
                }
                else
                {
                    responseObject = JsonConvert.DeserializeObject<Search.Response>(data);
                }

                return responseObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// Saves bookmark to the database.
        /// </summary>
        /// <param name="bookmarkObj"></param>
        /// <returns></returns>
        public bool SaveBookmark(Bookmark bookmarkObj)
        {
            return model.SaveBookMark(bookmarkObj);
        }

        /// <summary>
        /// Removes bookmark from database by id.
        /// </summary>
        /// <param name="bookmarkID"></param>
        /// <returns></returns>
        public bool RemoveBookmark(int bookmarkID)
        {
            return model.DeleteBookmark(bookmarkID);
        }

        /// <summary>
        /// Gets a list of bookmarks from database.
        /// </summary>
        /// <returns></returns>
        public List<Bookmark> GetBookmarks()
        {
            return model.GetBookmarks();
        }

        /// <summary>
        /// Gets the entire datatable of bookmarks from database. 
        /// </summary>
        /// <returns></returns>
        public DataTable GetBookmarksDatatable()
        {
            return model.GetBookmarkDatatable();
        }

        /// <summary>
        /// Verifies database and datatable existance and creates new if not existing.
        /// </summary>
        /// <returns></returns>
        public bool VerifyDB()
        {
            return model.VerifyDBTable();
        }
    }


}
