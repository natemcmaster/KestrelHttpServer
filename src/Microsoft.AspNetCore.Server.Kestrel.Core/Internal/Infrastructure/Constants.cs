// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
    internal static class Constants
    {
        public const int MaxExceptionDetailSize = 128;

        /// <summary>
        /// The IPEndPoint Kestrel will bind to if nothing else is specified.
        /// </summary>
        public static readonly string DefaultServerAddress = "http://localhost:5000";

        /// <summary>
        /// Prefix of host name used to specify Unix sockets in the configuration.
        /// </summary>
        public const string UnixPipeHostPrefix = "unix:/";

        /// <summary>
        /// Prefix of host name used to specify pipe file descriptor in the configuration.
        /// </summary>
        public const string PipeDescriptorPrefix = "pipefd:";

        /// <summary>
        /// Prefix of host name used to specify socket descriptor in the configuration.
        /// </summary>
        public const string SocketDescriptorPrefix = "sockfd:";

        public const string ServerName = "Kestrel";

        public const string ServiceUnavailableResponse =
                "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01//EN\"\"http://www.w3.org/TR/html4/strict.dtd\">" +
                "<HTML>" +
                "<HEAD><TITLE>Service Unavailable</TITLE><META HTTP-EQUIV=\"Content-Type\" Content=\"text/html; charset=us-ascii\"></HEAD>" +
                "<BODY><h2>Service Unavailable</h2><hr><p>HTTP Error 503. The service is unavailable.</p></BODY>" +
                "</HTML>";
    }
}
