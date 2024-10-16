using NUnit.Framework;
using RestSharp;
using System;

namespace APITestProject
{
    public class Tests
    {
        private  IApiClient _apiClient;
        private RestResponse _response;
        [SetUp]
        public void Setup()
        {
            _apiClient = new RestApiClient();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("GET OBJECT");
            _response = _apiClient.GetObjects();           
        }
    }
}