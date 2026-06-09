using System;
using Il2CppDummyDll;

namespace GooglePlayInstant
{
	// Token: 0x02002BA3 RID: 11171
	[Token(Token = "0x2002BA3")]
	public static class Android
	{
		// Token: 0x04011AFD RID: 72445
		[Token(Token = "0x4011AFD")]
		public const string GooglePlayServicesPackageName = "com.google.android.gms";

		// Token: 0x04011AFE RID: 72446
		[Token(Token = "0x4011AFE")]
		public const string GooglePlayStorePackageName = "com.android.vending";

		// Token: 0x04011AFF RID: 72447
		[Token(Token = "0x4011AFF")]
		public const string ActivityMethodGetIntent = "getIntent";

		// Token: 0x04011B00 RID: 72448
		[Token(Token = "0x4011B00")]
		public const string ActivityMethodStartActivityForResult = "startActivityForResult";

		// Token: 0x04011B01 RID: 72449
		[Token(Token = "0x4011B01")]
		public const string BundleClass = "android.os.Bundle";

		// Token: 0x04011B02 RID: 72450
		[Token(Token = "0x4011B02")]
		public const string BundleMethodGetBoolean = "getBoolean";

		// Token: 0x04011B03 RID: 72451
		[Token(Token = "0x4011B03")]
		public const string BundleMethodGetByteArray = "getByteArray";

		// Token: 0x04011B04 RID: 72452
		[Token(Token = "0x4011B04")]
		public const string BundleMethodGetInt = "getInt";

		// Token: 0x04011B05 RID: 72453
		[Token(Token = "0x4011B05")]
		public const string BundleMethodPutByteArray = "putByteArray";

		// Token: 0x04011B06 RID: 72454
		[Token(Token = "0x4011B06")]
		public const string BundleMethodPutInt = "putInt";

		// Token: 0x04011B07 RID: 72455
		[Token(Token = "0x4011B07")]
		public const string ContentResolverMethodCall = "call";

		// Token: 0x04011B08 RID: 72456
		[Token(Token = "0x4011B08")]
		public const string ContextMethodGetContentResolver = "getContentResolver";

		// Token: 0x04011B09 RID: 72457
		[Token(Token = "0x4011B09")]
		public const string ContextMethodGetPackageManager = "getPackageManager";

		// Token: 0x04011B0A RID: 72458
		[Token(Token = "0x4011B0A")]
		public const string IntentActionMain = "android.intent.action.MAIN";

		// Token: 0x04011B0B RID: 72459
		[Token(Token = "0x4011B0B")]
		public const string IntentActionView = "android.intent.action.VIEW";

		// Token: 0x04011B0C RID: 72460
		[Token(Token = "0x4011B0C")]
		public const string IntentCategoryBrowsable = "android.intent.category.BROWSABLE";

		// Token: 0x04011B0D RID: 72461
		[Token(Token = "0x4011B0D")]
		public const string IntentCategoryDefault = "android.intent.category.DEFAULT";

		// Token: 0x04011B0E RID: 72462
		[Token(Token = "0x4011B0E")]
		public const string IntentCategoryLauncher = "android.intent.category.LAUNCHER";

		// Token: 0x04011B0F RID: 72463
		[Token(Token = "0x4011B0F")]
		public const string IntentClass = "android.content.Intent";

		// Token: 0x04011B10 RID: 72464
		[Token(Token = "0x4011B10")]
		public const string IntentMethodAddCategory = "addCategory";

		// Token: 0x04011B11 RID: 72465
		[Token(Token = "0x4011B11")]
		public const string IntentMethodGetStringExtra = "getStringExtra";

		// Token: 0x04011B12 RID: 72466
		[Token(Token = "0x4011B12")]
		public const string IntentMethodPutExtra = "putExtra";

		// Token: 0x04011B13 RID: 72467
		[Token(Token = "0x4011B13")]
		public const string IntentMethodSetData = "setData";

		// Token: 0x04011B14 RID: 72468
		[Token(Token = "0x4011B14")]
		public const string IntentMethodSetPackage = "setPackage";

		// Token: 0x04011B15 RID: 72469
		[Token(Token = "0x4011B15")]
		public const string ObjectMethodGetClass = "getClass";

		// Token: 0x04011B16 RID: 72470
		[Token(Token = "0x4011B16")]
		public const string PackageInfoFieldSignatures = "signatures";

		// Token: 0x04011B17 RID: 72471
		[Token(Token = "0x4011B17")]
		public const int PackageManagerFieldGetSignatures = 64;

		// Token: 0x04011B18 RID: 72472
		[Token(Token = "0x4011B18")]
		public const string PackageManagerMethodGetPackageInfo = "getPackageInfo";

		// Token: 0x04011B19 RID: 72473
		[Token(Token = "0x4011B19")]
		public const string PackageManagerMethodResolveActivity = "resolveActivity";

		// Token: 0x04011B1A RID: 72474
		[Token(Token = "0x4011B1A")]
		public const string PackageManagerMethodResolveContentProvider = "resolveContentProvider";

		// Token: 0x04011B1B RID: 72475
		[Token(Token = "0x4011B1B")]
		public const string ProcessClass = "android.os.Process";

		// Token: 0x04011B1C RID: 72476
		[Token(Token = "0x4011B1C")]
		public const string ProcessMethodMyUid = "myUid";

		// Token: 0x04011B1D RID: 72477
		[Token(Token = "0x4011B1D")]
		public const string ProviderInfoFieldPackageName = "packageName";

		// Token: 0x04011B1E RID: 72478
		[Token(Token = "0x4011B1E")]
		public const string SignatureMethodToByteArray = "toByteArray";

		// Token: 0x04011B1F RID: 72479
		[Token(Token = "0x4011B1F")]
		public const string UriClass = "android.net.Uri";

		// Token: 0x04011B20 RID: 72480
		[Token(Token = "0x4011B20")]
		public const string UriMethodParse = "parse";

		// Token: 0x04011B21 RID: 72481
		[Token(Token = "0x4011B21")]
		public const string UriBuilderClass = "android.net.Uri$Builder";

		// Token: 0x04011B22 RID: 72482
		[Token(Token = "0x4011B22")]
		public const string UriBuilderMethodAppendQueryParameter = "appendQueryParameter";

		// Token: 0x04011B23 RID: 72483
		[Token(Token = "0x4011B23")]
		public const string UriBuilderMethodAuthority = "authority";

		// Token: 0x04011B24 RID: 72484
		[Token(Token = "0x4011B24")]
		public const string UriBuilderMethodBuild = "build";

		// Token: 0x04011B25 RID: 72485
		[Token(Token = "0x4011B25")]
		public const string UriBuilderMethodScheme = "scheme";
	}
}
