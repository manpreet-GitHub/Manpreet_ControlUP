using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Infrastructure;

namespace Manpreet_Test.StepDefinitions
{
    [Binding]
    public class GetReqStepDefinition
    {
        HttpClient httpClient;
        HttpResponseMessage response;
        string responsebody;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        public GetReqStepDefinition(ISpecFlowOutputHelper _specFlowOutputHelper)
        {
            httpClient= new HttpClient();
            this._specFlowOutputHelper = _specFlowOutputHelper;
        }

        [Given(@"the user sends a get request with url as ""([^""]*)""")]
        public async Task GivenTheUserSendsAGetRequestWithUrlAs(string uri)
        {
            response =  await httpClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            responsebody = await response.Content.ReadAsStringAsync();
            _specFlowOutputHelper.WriteLine(responsebody);


        }

        [Then(@"request should be a success with (.*)s code")]
        public void ThenRequestShouldBeASuccessWithSCode(int p0)
        {
            Assert.True(response.IsSuccessStatusCode);
        }

    }
}
