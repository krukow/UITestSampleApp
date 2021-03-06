﻿using Xamarin.UITest;

namespace UITestSampleApp.UITests
{
	public static class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					.PreferIdeSettings()
					.StartApp();
			}

			return ConfigureApp
				.iOS
				.PreferIdeSettings()
				.StartApp();
		}
	}
}

