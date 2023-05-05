﻿using ChatAI.Services;
using ChatAI.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ChatAI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<IChatService, ChatService>();
        builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
