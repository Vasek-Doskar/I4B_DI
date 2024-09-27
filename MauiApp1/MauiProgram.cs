using MauiApp1.Data;
using MauiApp1.Pages;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            // Registrace stránek
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<NovyClovek>();
            builder.Services.AddSingleton<NoveAuto>();


            // Registrace Databáze
            builder.Services.AddDbContext<DatabazeEF>();


            // Registrace Správce
            builder.Services.AddScoped<ILidiManager, LidiManager>();
            builder.Services.AddScoped<IAutoManager, AutoManager>();


            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

           

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
