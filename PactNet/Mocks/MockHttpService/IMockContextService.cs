﻿using System.Collections.Generic;
using PactNet.Mocks.MockHttpService.Models;

namespace PactNet.Mocks.MockHttpService
{
    public interface IMockContextService
    {
        IEnumerable<KeyValuePair<PactProviderServiceRequest, PactProviderServiceResponse>> GetExpectedRequestResponsePairs();
    }
}