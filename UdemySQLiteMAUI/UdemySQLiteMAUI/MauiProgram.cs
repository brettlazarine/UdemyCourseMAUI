﻿using Microsoft.Extensions.Logging;
using UdemySQLiteMAUI.MVVM.Models;
using UdemySQLiteMAUI.Repositories;

namespace UdemySQLiteMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<BaseRepository<Customer>>();
        builder.Services.AddSingleton<BaseRepository<Order>>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
