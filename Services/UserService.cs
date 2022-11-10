﻿using Microsoft.AspNetCore.Components.Authorization;

namespace TheMovieWatchlist.Services
{
    public class UserService
    {
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public UserService(AuthenticationStateProvider authenticationStateProvider)
        {
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<string> GetUserId()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            return user.FindFirst("sub").Value;
        }

        public async Task<string> GetUserEmail()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            return user.FindFirst("emails").Value;

            foreach (var claim in user.Claims)
            {
                Console.WriteLine(claim.ToString());
            }
        }
    }
}
