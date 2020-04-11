using System;
using Stylet;
using StyletIoC;
using TIDALDL_UI.Pages;

namespace TIDALDL_UI
{
    public class Bootstrapper : Bootstrapper<LoginViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }
    }
}



/********************************
 * 
 * DEBUG Url:
 *  专辑：https://listen.tidal.com/album/27633968
 *  歌手：https://listen.tidal.com/artist/3529466
 *  单曲：https://tidal.com/browse/track/70973230
 * 
 * ******************************/
