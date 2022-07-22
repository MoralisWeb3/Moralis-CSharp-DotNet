﻿using System.Collections.Generic;

namespace Moralis.Platform.Abstractions
{
    /// <summary>
    /// Defines data values used to connect to Moralis / Parse standalone servers.
    /// </summary>
    public interface IServerConnectionData
    {
        /// <summary>
        /// The App ID of your app.
        /// </summary>
        string ApplicationID { get; set; }

        /// <summary>
        /// A URI pointing to the target Moralis Server instance hosting the app targeted by <see cref="ApplicationID"/>.
        /// </summary>
        string ServerURI { get; set; }

        /// <summary>
        /// A URI pointing to the target Moralis WS/WSS server.
        /// </summary>
        string LiveQueryServerURI { get; set; }

        /// <summary>
        /// The Web3Api key, must be supplied to initialize Web3Api to use 
        /// standard REST server.
        /// </summary>
        string ApiKey { get; set; }

        /// <summary>
        /// The .NET Key for the Moralis app targeted by <see cref="ServerURI"/>.
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// The Master Key for the Moralis app targeted by <see cref="Key"/>.
        /// </summary>
        string MasterKey { get; set; }

        /// <summary>
        /// Used to 
        /// </summary>
        string LocalStoragePath { get; set; }

        /// <summary>
        /// Auth 2.0 server endpoint URL
        /// </summary>
        string AuthenticationApiUrl { get; set; }

        /// <summary>
        /// Additional HTTP headers to be sent with network requests from the SDK.
        /// </summary>
        IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Base endpoint for a Parse server backend
        /// </summary>
        string ParseEndpointBase { get; set; }

        /// <summary>
        /// Cloud Functions endpoint for a Parse Backend
        /// </summary>
        string ParseEndpointCloudfunctions { get; set; }

        /// <summary>
        /// File Service endpoint for Parse backend
        /// </summary>
        string ParseEndpointFileService { get; set; }

        /// <summary>
        /// Classes endpoint for a Parse Backend
        /// </summary>
        string ParseEndpointClasses { get; set; }

        /// <summary>
        /// The Authentication module to use in the Parse Server, the 
        /// module must be defined in Parse 
        /// node_modules/parse-server/lib/Adapters/Auth
        /// </summary>
        string ParseAuthenticationHandler { get; set; }
    }
}
