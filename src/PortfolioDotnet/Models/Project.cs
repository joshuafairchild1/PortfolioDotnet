using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioDotnet.Models
{
    public class Project
    {
        public string name { get; set; }
        public string html_url { get; set; }
        public int forks { get; set; }
        public string language { get; set; }
        public int stargazers_count { get; set; }
        public string description { get; set; }
        public string homepage{ get; set; }

        private static RestClient Client = new RestClient("https://api.github.com");

        public static List<Project> GetTopStarredRepos()
        {
            RestRequest request = new RestRequest($"search/repositories?q=user:{EnvironmentVariables.GitHubUserAgent}&per_page=3&sort=stars", Method.GET);

            request.AddHeader("user-agent", EnvironmentVariables.GitHubUserAgent);
            request.AddHeader("Accept", "application/json");

            RestResponse response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(Client, request) as RestResponse;
            }).Wait();

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);

            List<Project> messageList = JsonConvert.DeserializeObject<List<Project>>(jsonResponse["items"].ToString());

            return messageList;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            TaskCompletionSource<IRestResponse> tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
