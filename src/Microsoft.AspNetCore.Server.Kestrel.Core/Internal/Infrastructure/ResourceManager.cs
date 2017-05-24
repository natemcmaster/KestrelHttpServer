// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
    public class ResourceManager
    {
        public ResourceManager(ResourceCounter normalConnections, ResourceCounter upgradedConnections)
        {
            NormalConnections = normalConnections;
            UpgradedConnections = upgradedConnections;
        }

        /// <summary>
        /// TCP connections processed by Kestrel.
        /// </summary>
        public ResourceCounter NormalConnections { get; }

        /// <summary>
        /// Connections that have been switched to a different protocol.
        /// </summary>
        public ResourceCounter UpgradedConnections { get; }
    }
}
