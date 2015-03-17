using System;

using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace csharp
{
	class Divvy
	{
		public void ShowStations()
		{
			string webServiceUrl = "http://www.divvybikes.com/stations/json";
			webServiceUrl.
			HttpWebRequest request = WebRequest.Create(webServiceUrl) as HttpWebRequest;
			request.ContentType = "application/json; charset=utf-8";

			HttpWebResponse response = (HttpWebResponse) request.GetResponse();
			Stream receiveStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(receiveStream);
			string json = reader.ReadToEnd();

			JavaScriptSerializer serializer = new JavaScriptSerializer(); //using System.Web.Script.Serialization;
			Dictionary<string, object> result = serializer.Deserialize<Dictionary<string, object>>(json);

			ArrayList stations = (ArrayList) result["stationBeanList"];
			foreach (Dictionary<string, object> station in stations) {
				Console.WriteLine (station["stationName"]);
			}

		}

	}
}

//	import json
//	from urllib.request import urlopen
//	import math
//
//	webservice_url = "http://www.divvybikes.com/stations/json"
//	data = urlopen(webservice_url).read().decode("utf8")
//	result = json.loads(data)
//	stations = result['stationBeanList']
//
//	young_latitude = 41.793414
//	young_longitude = -87.600915
//
//	nearest_distance = 100000  # Assume something very far out
//
//	for station in stations:
//		print(station["stationName"])
//