﻿// ==========================================================================
//  AssetConfig.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace Squidex.Controllers.Api.Assets
{
    public sealed class AssetConfig
    {
        public long MaxSize { get; set; } = 5 * 1024 * 1024;
    }
}
