﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Builder;
using Microsoft.Framework.OptionsModel;
using System;

namespace Microsoft.AspNet.Security.Spotify
{
    public static class SpotifyAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Spotify.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> passed to the configure method.</param>
        /// <returns>The updated <see cref="IApplicationBuilder"/>.</returns>
        public static IApplicationBuilder UseSpotifyAuthentication(this IApplicationBuilder app, Action<SpotifyAuthenticationOptions> confiureOptions = null, string optionsName = "")
        {
            return app.UseMiddleware<SpotifyAuthenticationMiddleware>(
                new ConfigureOptions<SpotifyAuthenticationOptions>(confiureOptions ?? (o => { }))
                {
                    Name = optionsName
                });
        }
    }
}