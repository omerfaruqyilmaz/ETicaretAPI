using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services.Authentication
{
    public interface IExternalAuthentication
    {
        Task<DTOs.Token> FacebookLoginAsync(string authToken,int accessTokenLifteTime);
        Task<DTOs.Token> GoogleLoginAsync(string idToken, int accessTokenLifteTime);
    }
}
