using ePostrojenje.WebAPI.Database;
using ePostrojenje.WebAPI.Exceptions;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ePostrojenje.WebAPI.Database;

namespace ePostrojenje.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IOsobljeService _userService;
        private readonly IKupciService _kupacService;
        private readonly _150217Context context = new _150217Context();

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IOsobljeService userService,
            IKupciService kupacService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _kupacService = kupacService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Osoblje user = null;
            Model.Kupci kupac = null;
            var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
            var username = credentials[0];
            var password = credentials[1];
            var status = context.VrstaAplikacije.First();
            //
            if (status.DesktopStatus == 1)
            {
                user = _userService.Authenticiraj(username, password);
                if (user != null)
                {

                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                        new Claim(ClaimTypes.Name, user.Ime),
                    };

                    foreach (var odjeliOsoblje in context.OdjeliOsoblje)
                        if (odjeliOsoblje.OsobljeId == user.OsobljeId)
                            claims.Add(new Claim(ClaimTypes.Role, odjeliOsoblje.OdjelId.ToString()));

                    /*foreach (var role in user.OdjeliOsoblje)
                    { 
                        claims.Add(new Claim(ClaimTypes.Role, role.Odjel.Naziv));
                    }*/

                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
            }
            else if (status.DesktopStatus == 0)
            {
                kupac = _kupacService.Authenticiraj(username, password);
                if (kupac != null)
                {

                    var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, kupac.KorisnickoIme),
                new Claim(ClaimTypes.Name, kupac.Ime),
            };

                    /*foreach (var role in user.OdjeliOsoblje)
                    { 
                        claims.Add(new Claim(ClaimTypes.Role, role.Odjel.Naziv));
                    }*/

                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);



                    return AuthenticateResult.Success(ticket);

                }
            }

            //kupac = _kupacService.Authenticiraj(username, password);




            ex(null);
            
            return AuthenticateResult.Fail("Invalid Auhtorization Header");

        }

        private void ex(string v)
        {
            throw new UserException("Invalid Username or Password");
        }
    }
}