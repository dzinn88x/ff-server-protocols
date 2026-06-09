using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025E2 RID: 9698
	[Token(Token = "0x20025E2")]
	public static class GameConfig
	{
		// Token: 0x0600C782 RID: 51074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C782")]
		[Address(RVA = "0x186BA58", Offset = "0x186BA58", VA = "0x7BBC06BA58")]
		public static void OverrideServerAddr(string addr)
		{
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600C783 RID: 51075 RVA: 0x00035700 File Offset: 0x00033900
		// (set) Token: 0x0600C784 RID: 51076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE3")]
		public static bool IsIOSReview
		{
			[Token(Token = "0x600C783")]
			[Address(RVA = "0x186BAC4", Offset = "0x186BAC4", VA = "0x7BBC06BAC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C784")]
			[Address(RVA = "0x186BBC0", Offset = "0x186BBC0", VA = "0x7BBC06BBC0")]
			set
			{
			}
		}

		// Token: 0x0600C785 RID: 51077 RVA: 0x00035718 File Offset: 0x00033918
		[Token(Token = "0x600C785")]
		[Address(RVA = "0x186BC30", Offset = "0x186BC30", VA = "0x7BBC06BC30")]
		public static bool NeedRefreshFile()
		{
			return default(bool);
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600C786 RID: 51078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C787 RID: 51079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE4")]
		public static string BillboardServerAddr
		{
			[Token(Token = "0x600C786")]
			[Address(RVA = "0x186BCD8", Offset = "0x186BCD8", VA = "0x7BBC06BCD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C787")]
			[Address(RVA = "0x186BE10", Offset = "0x186BE10", VA = "0x7BBC06BE10")]
			set
			{
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600C789 RID: 51081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C788 RID: 51080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE5")]
		public static string Country
		{
			[Token(Token = "0x600C789")]
			[Address(RVA = "0x186BEE8", Offset = "0x186BEE8", VA = "0x7BBC06BEE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C788")]
			[Address(RVA = "0x186BE7C", Offset = "0x186BE7C", VA = "0x7BBC06BE7C")]
			set
			{
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600C78B RID: 51083 RVA: 0x00035730 File Offset: 0x00033930
		// (set) Token: 0x0600C78A RID: 51082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE6")]
		public static bool ShowDebugInfo
		{
			[Token(Token = "0x600C78B")]
			[Address(RVA = "0x186BFC0", Offset = "0x186BFC0", VA = "0x7BBC06BFC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C78A")]
			[Address(RVA = "0x186BF50", Offset = "0x186BF50", VA = "0x7BBC06BF50")]
			set
			{
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600C78C RID: 51084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE7")]
		public static string GarenaAppKey
		{
			[Token(Token = "0x600C78C")]
			[Address(RVA = "0x186C1A4", Offset = "0x186C1A4", VA = "0x7BBC06C1A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600C78D RID: 51085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE8")]
		public static string GoogleClientID
		{
			[Token(Token = "0x600C78D")]
			[Address(RVA = "0x186C254", Offset = "0x186C254", VA = "0x7BBC06C254")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600C78E RID: 51086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE9")]
		public static string GarenaPushAppKey
		{
			[Token(Token = "0x600C78E")]
			[Address(RVA = "0x186C340", Offset = "0x186C340", VA = "0x7BBC06C340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600C78F RID: 51087 RVA: 0x00035748 File Offset: 0x00033948
		[Token(Token = "0x17000CEA")]
		public static int VeteranReminderDays
		{
			[Token(Token = "0x600C78F")]
			[Address(RVA = "0x186C3F0", Offset = "0x186C3F0", VA = "0x7BBC06C3F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600C790 RID: 51088 RVA: 0x00035760 File Offset: 0x00033960
		[Token(Token = "0x17000CEB")]
		public static bool? DisplayDebugInfo
		{
			[Token(Token = "0x600C790")]
			[Address(RVA = "0x186C0A8", Offset = "0x186C0A8", VA = "0x7BBC06C0A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600C791 RID: 51089 RVA: 0x00035778 File Offset: 0x00033978
		[Token(Token = "0x17000CEC")]
		public static bool DebugSkipRoomCheck
		{
			[Token(Token = "0x600C791")]
			[Address(RVA = "0x186C494", Offset = "0x186C494", VA = "0x7BBC06C494")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600C792 RID: 51090 RVA: 0x00035790 File Offset: 0x00033990
		[Token(Token = "0x17000CED")]
		public static bool DebugShowAccountDel
		{
			[Token(Token = "0x600C792")]
			[Address(RVA = "0x186C540", Offset = "0x186C540", VA = "0x7BBC06C540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		public static string VersionOfIAPProducts
		{
			[Token(Token = "0x600C793")]
			[Address(RVA = "0x186C5EC", Offset = "0x186C5EC", VA = "0x7BBC06C5EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x000357A8 File Offset: 0x000339A8
		[Token(Token = "0x17000CEF")]
		public static float DurationForEatingChicken
		{
			[Token(Token = "0x600C794")]
			[Address(RVA = "0x186C6A4", Offset = "0x186C6A4", VA = "0x7BBC06C6A4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600C795 RID: 51093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF0")]
		public static string VersionOfPaymentBundles
		{
			[Token(Token = "0x600C795")]
			[Address(RVA = "0x186C748", Offset = "0x186C748", VA = "0x7BBC06C748")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600C796 RID: 51094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		public static string VersionOfRebateCardss
		{
			[Token(Token = "0x600C796")]
			[Address(RVA = "0x186C800", Offset = "0x186C800", VA = "0x7BBC06C800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600C797 RID: 51095 RVA: 0x000357C0 File Offset: 0x000339C0
		[Token(Token = "0x17000CF2")]
		public static ulong PaymentBundleNextResetTime
		{
			[Token(Token = "0x600C797")]
			[Address(RVA = "0x186C8B8", Offset = "0x186C8B8", VA = "0x7BBC06C8B8")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF3")]
		public static string TestPayMainUrl_Paid
		{
			[Token(Token = "0x600C798")]
			[Address(RVA = "0x186C95C", Offset = "0x186C95C", VA = "0x7BBC06C95C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x0600C799 RID: 51097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF4")]
		public static string TestPayMainUrl_Unpaid
		{
			[Token(Token = "0x600C799")]
			[Address(RVA = "0x186CA14", Offset = "0x186CA14", VA = "0x7BBC06CA14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF5")]
		public static string TestPaymentActivityImageUrl
		{
			[Token(Token = "0x600C79A")]
			[Address(RVA = "0x186CACC", Offset = "0x186CACC", VA = "0x7BBC06CACC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600C79B RID: 51099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF6")]
		public static string TestPayItemUrl_iOS
		{
			[Token(Token = "0x600C79B")]
			[Address(RVA = "0x186CB84", Offset = "0x186CB84", VA = "0x7BBC06CB84")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600C79C RID: 51100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF7")]
		public static string TestPayIAPButtonUrl_Android
		{
			[Token(Token = "0x600C79C")]
			[Address(RVA = "0x186CC3C", Offset = "0x186CC3C", VA = "0x7BBC06CC3C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600C79D RID: 51101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF8")]
		public static string TestPayAdImageUrl_Android
		{
			[Token(Token = "0x600C79D")]
			[Address(RVA = "0x186CCF4", Offset = "0x186CCF4", VA = "0x7BBC06CCF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600C79E RID: 51102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF9")]
		public static string TestPayAdClickUrl_Android
		{
			[Token(Token = "0x600C79E")]
			[Address(RVA = "0x186CDAC", Offset = "0x186CDAC", VA = "0x7BBC06CDAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x0600C79F RID: 51103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFA")]
		public static string TestShareUrl
		{
			[Token(Token = "0x600C79F")]
			[Address(RVA = "0x186CE64", Offset = "0x186CE64", VA = "0x7BBC06CE64")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x0600C7A0 RID: 51104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFB")]
		public static string TestInviteUrl
		{
			[Token(Token = "0x600C7A0")]
			[Address(RVA = "0x186CF1C", Offset = "0x186CF1C", VA = "0x7BBC06CF1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x0600C7A1 RID: 51105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFC")]
		public static string TestOpenedByUrl
		{
			[Token(Token = "0x600C7A1")]
			[Address(RVA = "0x186CFD4", Offset = "0x186CFD4", VA = "0x7BBC06CFD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFD")]
		public static string TestOpenedWithDeepLinkUrl
		{
			[Token(Token = "0x600C7A2")]
			[Address(RVA = "0x186D08C", Offset = "0x186D08C", VA = "0x7BBC06D08C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600C7A3 RID: 51107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFE")]
		public static string TestOpenedWithWebViewUrl
		{
			[Token(Token = "0x600C7A3")]
			[Address(RVA = "0x186D144", Offset = "0x186D144", VA = "0x7BBC06D144")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFF")]
		public static string TestOpenedWithWebViewStyle
		{
			[Token(Token = "0x600C7A4")]
			[Address(RVA = "0x186D1FC", Offset = "0x186D1FC", VA = "0x7BBC06D1FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600C7A5 RID: 51109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D00")]
		public static string TestOpenedWithBrowserUrl
		{
			[Token(Token = "0x600C7A5")]
			[Address(RVA = "0x186D2B4", Offset = "0x186D2B4", VA = "0x7BBC06D2B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x000357D8 File Offset: 0x000339D8
		[Token(Token = "0x17000D01")]
		public static uint PrepareForNavigatePos
		{
			[Token(Token = "0x600C7A6")]
			[Address(RVA = "0x186D36C", Offset = "0x186D36C", VA = "0x7BBC06D36C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600C7A7 RID: 51111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D02")]
		public static string PrepareForNavigateParam
		{
			[Token(Token = "0x600C7A7")]
			[Address(RVA = "0x186D410", Offset = "0x186D410", VA = "0x7BBC06D410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600C7A8 RID: 51112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D03")]
		public static string BillboardTestDesc
		{
			[Token(Token = "0x600C7A8")]
			[Address(RVA = "0x186D4C8", Offset = "0x186D4C8", VA = "0x7BBC06D4C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600C7A9 RID: 51113 RVA: 0x000357F0 File Offset: 0x000339F0
		[Token(Token = "0x17000D04")]
		public static bool GMSDKEnableDebugLog
		{
			[Token(Token = "0x600C7A9")]
			[Address(RVA = "0x186D580", Offset = "0x186D580", VA = "0x7BBC06D580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x0600C7AA RID: 51114 RVA: 0x00035808 File Offset: 0x00033A08
		[Token(Token = "0x17000D05")]
		public static bool ResetGuest
		{
			[Token(Token = "0x600C7AA")]
			[Address(RVA = "0x186D62C", Offset = "0x186D62C", VA = "0x7BBC06D62C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600C7AB RID: 51115 RVA: 0x00035820 File Offset: 0x00033A20
		[Token(Token = "0x17000D06")]
		public static bool RebateCardOverride
		{
			[Token(Token = "0x600C7AB")]
			[Address(RVA = "0x186D6D8", Offset = "0x186D6D8", VA = "0x7BBC06D6D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00035838 File Offset: 0x00033A38
		[Token(Token = "0x17000D07")]
		public static bool RebateCardEnabled
		{
			[Token(Token = "0x600C7AC")]
			[Address(RVA = "0x186D784", Offset = "0x186D784", VA = "0x7BBC06D784")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600C7AD RID: 51117 RVA: 0x00035850 File Offset: 0x00033A50
		[Token(Token = "0x17000D08")]
		public static bool PaymentBundleOverride
		{
			[Token(Token = "0x600C7AD")]
			[Address(RVA = "0x186D830", Offset = "0x186D830", VA = "0x7BBC06D830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x00035868 File Offset: 0x00033A68
		[Token(Token = "0x17000D09")]
		public static bool PaymentBundleEnabled
		{
			[Token(Token = "0x600C7AE")]
			[Address(RVA = "0x186D8DC", Offset = "0x186D8DC", VA = "0x7BBC06D8DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600C7AF RID: 51119 RVA: 0x00035880 File Offset: 0x00033A80
		[Token(Token = "0x17000D0A")]
		public static bool PaymentShopOverride
		{
			[Token(Token = "0x600C7AF")]
			[Address(RVA = "0x186D988", Offset = "0x186D988", VA = "0x7BBC06D988")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x00035898 File Offset: 0x00033A98
		[Token(Token = "0x17000D0B")]
		public static bool PaymentShopEnabled
		{
			[Token(Token = "0x600C7B0")]
			[Address(RVA = "0x186DA34", Offset = "0x186DA34", VA = "0x7BBC06DA34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600C7B1 RID: 51121 RVA: 0x000358B0 File Offset: 0x00033AB0
		[Token(Token = "0x17000D0C")]
		public static bool PaymentShopFirstOverride
		{
			[Token(Token = "0x600C7B1")]
			[Address(RVA = "0x186DAE0", Offset = "0x186DAE0", VA = "0x7BBC06DAE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x000358C8 File Offset: 0x00033AC8
		[Token(Token = "0x17000D0D")]
		public static bool PaymentShopFirst
		{
			[Token(Token = "0x600C7B2")]
			[Address(RVA = "0x186DB8C", Offset = "0x186DB8C", VA = "0x7BBC06DB8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600C7B3 RID: 51123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0E")]
		public static string PaymentShopCdnUrl
		{
			[Token(Token = "0x600C7B3")]
			[Address(RVA = "0x186DC38", Offset = "0x186DC38", VA = "0x7BBC06DC38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600C7B4 RID: 51124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0F")]
		public static string PaymentShopFallbackStrategy
		{
			[Token(Token = "0x600C7B4")]
			[Address(RVA = "0x186DCF0", Offset = "0x186DCF0", VA = "0x7BBC06DCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600C7B5 RID: 51125 RVA: 0x000358E0 File Offset: 0x00033AE0
		[Token(Token = "0x17000D10")]
		public static bool PaymentShopFalseFaulty
		{
			[Token(Token = "0x600C7B5")]
			[Address(RVA = "0x186DDA8", Offset = "0x186DDA8", VA = "0x7BBC06DDA8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600C7B6 RID: 51126 RVA: 0x000358F8 File Offset: 0x00033AF8
		[Token(Token = "0x17000D11")]
		public static bool ForceDisplayAllPaymentTabs
		{
			[Token(Token = "0x600C7B6")]
			[Address(RVA = "0x186DE54", Offset = "0x186DE54", VA = "0x7BBC06DE54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600C7B7 RID: 51127 RVA: 0x00035910 File Offset: 0x00033B10
		[Token(Token = "0x17000D12")]
		public static bool ScreenshotForIAPBundles
		{
			[Token(Token = "0x600C7B7")]
			[Address(RVA = "0x186DF00", Offset = "0x186DF00", VA = "0x7BBC06DF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600C7B8 RID: 51128 RVA: 0x00035928 File Offset: 0x00033B28
		[Token(Token = "0x17000D13")]
		public static bool LogoutStopTPNS
		{
			[Token(Token = "0x600C7B8")]
			[Address(RVA = "0x186DFAC", Offset = "0x186DFAC", VA = "0x7BBC06DFAC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600C7B9 RID: 51129 RVA: 0x00035940 File Offset: 0x00033B40
		[Token(Token = "0x17000D14")]
		public static bool ForceWebView
		{
			[Token(Token = "0x600C7B9")]
			[Address(RVA = "0x186E058", Offset = "0x186E058", VA = "0x7BBC06E058")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600C7BA RID: 51130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D15")]
		public static string TestWebViewUrl
		{
			[Token(Token = "0x600C7BA")]
			[Address(RVA = "0x186E104", Offset = "0x186E104", VA = "0x7BBC06E104")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600C7BB RID: 51131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D16")]
		public static string TestLiveTVUrl
		{
			[Token(Token = "0x600C7BB")]
			[Address(RVA = "0x186E1BC", Offset = "0x186E1BC", VA = "0x7BBC06E1BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600C7BC RID: 51132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D17")]
		public static string TestBooyahTVUrl
		{
			[Token(Token = "0x600C7BC")]
			[Address(RVA = "0x186E274", Offset = "0x186E274", VA = "0x7BBC06E274")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600C7BD RID: 51133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D18")]
		public static string TestProductIdentifier
		{
			[Token(Token = "0x600C7BD")]
			[Address(RVA = "0x186E32C", Offset = "0x186E32C", VA = "0x7BBC06E32C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600C7BE RID: 51134 RVA: 0x00035958 File Offset: 0x00033B58
		[Token(Token = "0x17000D19")]
		public static long TestRebateCardNotifyTimeOfDay_Local_MS
		{
			[Token(Token = "0x600C7BE")]
			[Address(RVA = "0x186E3E4", Offset = "0x186E3E4", VA = "0x7BBC06E3E4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600C7BF RID: 51135 RVA: 0x00035970 File Offset: 0x00033B70
		[Token(Token = "0x17000D1A")]
		public static long TestPlayTestNotifyTimeOfDay_Local_MS
		{
			[Token(Token = "0x600C7BF")]
			[Address(RVA = "0x186E600", Offset = "0x186E600", VA = "0x7BBC06E600")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600C7C0 RID: 51136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1B")]
		public static string TestHook
		{
			[Token(Token = "0x600C7C0")]
			[Address(RVA = "0x186E6AC", Offset = "0x186E6AC", VA = "0x7BBC06E6AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x00035988 File Offset: 0x00033B88
		[Token(Token = "0x600C7C1")]
		[Address(RVA = "0x186E764", Offset = "0x186E764", VA = "0x7BBC06E764")]
		private static long _DateTimeToTimeStamp(string timeString)
		{
			return 0L;
		}

		// Token: 0x0600C7C2 RID: 51138 RVA: 0x000359A0 File Offset: 0x00033BA0
		[Token(Token = "0x600C7C2")]
		[Address(RVA = "0x186E490", Offset = "0x186E490", VA = "0x7BBC06E490")]
		private static long _TimeOfDayToMS(string timeString)
		{
			return 0L;
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x000359B8 File Offset: 0x00033BB8
		[Token(Token = "0x17000D1C")]
		public static int TestIAPBundleStoreID
		{
			[Token(Token = "0x600C7C3")]
			[Address(RVA = "0x186E904", Offset = "0x186E904", VA = "0x7BBC06E904")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600C7C4 RID: 51140 RVA: 0x000359D0 File Offset: 0x00033BD0
		[Token(Token = "0x17000D1D")]
		public static int TestIAPBundleDuration
		{
			[Token(Token = "0x600C7C4")]
			[Address(RVA = "0x186E9A8", Offset = "0x186E9A8", VA = "0x7BBC06E9A8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x000359E8 File Offset: 0x00033BE8
		[Token(Token = "0x17000D1E")]
		public static int TestMinutesOfNotifyBeforeIAPBundleEnds
		{
			[Token(Token = "0x600C7C5")]
			[Address(RVA = "0x186EA4C", Offset = "0x186EA4C", VA = "0x7BBC06EA4C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600C7C6 RID: 51142 RVA: 0x00035A00 File Offset: 0x00033C00
		[Token(Token = "0x17000D1F")]
		public static bool TestIAPBundleFirstTime
		{
			[Token(Token = "0x600C7C6")]
			[Address(RVA = "0x186EAF0", Offset = "0x186EAF0", VA = "0x7BBC06EAF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600C7C7 RID: 51143 RVA: 0x00035A18 File Offset: 0x00033C18
		[Token(Token = "0x17000D20")]
		public static bool TestIAPBundleAllPurchasable
		{
			[Token(Token = "0x600C7C7")]
			[Address(RVA = "0x186EB9C", Offset = "0x186EB9C", VA = "0x7BBC06EB9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600C7C8 RID: 51144 RVA: 0x00035A30 File Offset: 0x00033C30
		[Token(Token = "0x17000D21")]
		public static bool ForceIAPBundleFullyDisplay
		{
			[Token(Token = "0x600C7C8")]
			[Address(RVA = "0x186EC48", Offset = "0x186EC48", VA = "0x7BBC06EC48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600C7C9 RID: 51145 RVA: 0x00035A48 File Offset: 0x00033C48
		[Token(Token = "0x17000D22")]
		public static bool ForcePlatformFriendReunion
		{
			[Token(Token = "0x600C7C9")]
			[Address(RVA = "0x186ECF4", Offset = "0x186ECF4", VA = "0x7BBC06ECF4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600C7CA RID: 51146 RVA: 0x00035A60 File Offset: 0x00033C60
		[Token(Token = "0x17000D23")]
		public static bool? TestSparkEventEnabled
		{
			[Token(Token = "0x600C7CA")]
			[Address(RVA = "0x186EDA0", Offset = "0x186EDA0", VA = "0x7BBC06EDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600C7CB RID: 51147 RVA: 0x00035A78 File Offset: 0x00033C78
		[Token(Token = "0x17000D24")]
		public static bool? TestSparkEventOnEnterLobby
		{
			[Token(Token = "0x600C7CB")]
			[Address(RVA = "0x186EE9C", Offset = "0x186EE9C", VA = "0x7BBC06EE9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600C7CC RID: 51148 RVA: 0x00035A90 File Offset: 0x00033C90
		[Token(Token = "0x17000D25")]
		public static bool? TestSparkEventDebugMode
		{
			[Token(Token = "0x600C7CC")]
			[Address(RVA = "0x186EF98", Offset = "0x186EF98", VA = "0x7BBC06EF98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600C7CD RID: 51149 RVA: 0x00035AA8 File Offset: 0x00033CA8
		[Token(Token = "0x17000D26")]
		public static long TestFreeGachaNotifyTimeOfDay_Local_MS
		{
			[Token(Token = "0x600C7CD")]
			[Address(RVA = "0x186F094", Offset = "0x186F094", VA = "0x7BBC06F094")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x00035AC0 File Offset: 0x00033CC0
		[Token(Token = "0x17000D27")]
		public static bool DisableRandomDelayForNotifies
		{
			[Token(Token = "0x600C7CE")]
			[Address(RVA = "0x186F180", Offset = "0x186F180", VA = "0x7BBC06F180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600C7CF RID: 51151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D28")]
		public static string DetectAndroidApplicationBundleIdentifier
		{
			[Token(Token = "0x600C7CF")]
			[Address(RVA = "0x186F22C", Offset = "0x186F22C", VA = "0x7BBC06F22C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600C7D0 RID: 51152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D29")]
		public static string TestDeviceIdForGoogleAdMob
		{
			[Token(Token = "0x600C7D0")]
			[Address(RVA = "0x186F2E4", Offset = "0x186F2E4", VA = "0x7BBC06F2E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600C7D1 RID: 51153 RVA: 0x00035AD8 File Offset: 0x00033CD8
		[Token(Token = "0x17000D2A")]
		public static bool TestAdMobOverride
		{
			[Token(Token = "0x600C7D1")]
			[Address(RVA = "0x186F39C", Offset = "0x186F39C", VA = "0x7BBC06F39C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600C7D2 RID: 51154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2B")]
		public static string TestRewardedVideoAdUnitId
		{
			[Token(Token = "0x600C7D2")]
			[Address(RVA = "0x186F448", Offset = "0x186F448", VA = "0x7BBC06F448")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600C7D3 RID: 51155 RVA: 0x00035AF0 File Offset: 0x00033CF0
		[Token(Token = "0x17000D2C")]
		public static bool TestAdMob
		{
			[Token(Token = "0x600C7D3")]
			[Address(RVA = "0x186F500", Offset = "0x186F500", VA = "0x7BBC06F500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x00035B08 File Offset: 0x00033D08
		[Token(Token = "0x17000D2D")]
		public static bool ForceEnableRewardedVideo
		{
			[Token(Token = "0x600C7D4")]
			[Address(RVA = "0x186F5AC", Offset = "0x186F5AC", VA = "0x7BBC06F5AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600C7D5 RID: 51157 RVA: 0x00035B20 File Offset: 0x00033D20
		[Token(Token = "0x17000D2E")]
		public static bool ForceEnableRewardVideoAfterMatch
		{
			[Token(Token = "0x600C7D5")]
			[Address(RVA = "0x186F658", Offset = "0x186F658", VA = "0x7BBC06F658")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x0600C7D6 RID: 51158 RVA: 0x00035B38 File Offset: 0x00033D38
		[Token(Token = "0x17000D2F")]
		public static int PaymentBundlesReloadInterval
		{
			[Token(Token = "0x600C7D6")]
			[Address(RVA = "0x186F704", Offset = "0x186F704", VA = "0x7BBC06F704")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x0600C7D7 RID: 51159 RVA: 0x00035B50 File Offset: 0x00033D50
		[Token(Token = "0x17000D30")]
		public static bool IAPLogVerbose
		{
			[Token(Token = "0x600C7D7")]
			[Address(RVA = "0x186F7A8", Offset = "0x186F7A8", VA = "0x7BBC06F7A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x00035B68 File Offset: 0x00033D68
		[Token(Token = "0x17000D31")]
		public static bool RebateCardLogVerbose
		{
			[Token(Token = "0x600C7D8")]
			[Address(RVA = "0x186F854", Offset = "0x186F854", VA = "0x7BBC06F854")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600C7D9 RID: 51161 RVA: 0x00035B80 File Offset: 0x00033D80
		[Token(Token = "0x17000D32")]
		public static bool LocalNotifyLogVerbose
		{
			[Token(Token = "0x600C7D9")]
			[Address(RVA = "0x186F900", Offset = "0x186F900", VA = "0x7BBC06F900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600C7DA RID: 51162 RVA: 0x00035B98 File Offset: 0x00033D98
		[Token(Token = "0x17000D33")]
		public static bool UIWaitingLogVerbose
		{
			[Token(Token = "0x600C7DA")]
			[Address(RVA = "0x186F9AC", Offset = "0x186F9AC", VA = "0x7BBC06F9AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600C7DB RID: 51163 RVA: 0x00035BB0 File Offset: 0x00033DB0
		[Token(Token = "0x17000D34")]
		public static bool LoginLogVerbose
		{
			[Token(Token = "0x600C7DB")]
			[Address(RVA = "0x186FA58", Offset = "0x186FA58", VA = "0x7BBC06FA58")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600C7DC RID: 51164 RVA: 0x00035BC8 File Offset: 0x00033DC8
		[Token(Token = "0x17000D35")]
		public static bool AutoUIIntentsLogVerbose
		{
			[Token(Token = "0x600C7DC")]
			[Address(RVA = "0x186FB04", Offset = "0x186FB04", VA = "0x7BBC06FB04")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600C7DD RID: 51165 RVA: 0x00035BE0 File Offset: 0x00033DE0
		[Token(Token = "0x17000D36")]
		public static bool ForceCrash
		{
			[Token(Token = "0x600C7DD")]
			[Address(RVA = "0x186FBB0", Offset = "0x186FBB0", VA = "0x7BBC06FBB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600C7DE RID: 51166 RVA: 0x00035BF8 File Offset: 0x00033DF8
		[Token(Token = "0x17000D37")]
		public static bool FirebaseLogVerbose
		{
			[Token(Token = "0x600C7DE")]
			[Address(RVA = "0x186FC5C", Offset = "0x186FC5C", VA = "0x7BBC06FC5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600C7DF RID: 51167 RVA: 0x00035C10 File Offset: 0x00033E10
		[Token(Token = "0x17000D38")]
		public static bool GERLogVerbose
		{
			[Token(Token = "0x600C7DF")]
			[Address(RVA = "0x186FD08", Offset = "0x186FD08", VA = "0x7BBC06FD08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600C7E0 RID: 51168 RVA: 0x00035C28 File Offset: 0x00033E28
		[Token(Token = "0x17000D39")]
		public static bool InterAppLogVerbose
		{
			[Token(Token = "0x600C7E0")]
			[Address(RVA = "0x186FDB4", Offset = "0x186FDB4", VA = "0x7BBC06FDB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x00035C40 File Offset: 0x00033E40
		[Token(Token = "0x17000D3A")]
		public static bool TPNSLogVerbose
		{
			[Token(Token = "0x600C7E1")]
			[Address(RVA = "0x186FE60", Offset = "0x186FE60", VA = "0x7BBC06FE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600C7E2 RID: 51170 RVA: 0x00035C58 File Offset: 0x00033E58
		[Token(Token = "0x17000D3B")]
		public static bool DisableCacheForFirebaseAnalytics
		{
			[Token(Token = "0x600C7E2")]
			[Address(RVA = "0x186FF0C", Offset = "0x186FF0C", VA = "0x7BBC06FF0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600C7E3 RID: 51171 RVA: 0x00035C70 File Offset: 0x00033E70
		[Token(Token = "0x17000D3C")]
		public static bool DisableCacheForFirebaseMessaging
		{
			[Token(Token = "0x600C7E3")]
			[Address(RVA = "0x186FFB8", Offset = "0x186FFB8", VA = "0x7BBC06FFB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600C7E4 RID: 51172 RVA: 0x00035C88 File Offset: 0x00033E88
		[Token(Token = "0x17000D3D")]
		public static bool FirebaseSettingsOverride
		{
			[Token(Token = "0x600C7E4")]
			[Address(RVA = "0x1870064", Offset = "0x1870064", VA = "0x7BBC070064")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600C7E5 RID: 51173 RVA: 0x00035CA0 File Offset: 0x00033EA0
		[Token(Token = "0x17000D3E")]
		public static bool FirebaseEnabled
		{
			[Token(Token = "0x600C7E5")]
			[Address(RVA = "0x1870110", Offset = "0x1870110", VA = "0x7BBC070110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x00035CB8 File Offset: 0x00033EB8
		[Token(Token = "0x17000D3F")]
		public static bool FirebaseMessagingEnabled
		{
			[Token(Token = "0x600C7E6")]
			[Address(RVA = "0x18701BC", Offset = "0x18701BC", VA = "0x7BBC0701BC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x0600C7E7 RID: 51175 RVA: 0x00035CD0 File Offset: 0x00033ED0
		[Token(Token = "0x17000D40")]
		public static bool FirebaseAnalyticsEnabled
		{
			[Token(Token = "0x600C7E7")]
			[Address(RVA = "0x1870268", Offset = "0x1870268", VA = "0x7BBC070268")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600C7E8 RID: 51176 RVA: 0x00035CE8 File Offset: 0x00033EE8
		[Token(Token = "0x17000D41")]
		public static bool FirebaseCrashlyticsEnabled
		{
			[Token(Token = "0x600C7E8")]
			[Address(RVA = "0x1870314", Offset = "0x1870314", VA = "0x7BBC070314")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600C7E9 RID: 51177 RVA: 0x00035D00 File Offset: 0x00033F00
		[Token(Token = "0x17000D42")]
		public static bool FirebaseMessagingSettingsOverride
		{
			[Token(Token = "0x600C7E9")]
			[Address(RVA = "0x18703C0", Offset = "0x18703C0", VA = "0x7BBC0703C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600C7EA RID: 51178 RVA: 0x00035D18 File Offset: 0x00033F18
		[Token(Token = "0x17000D43")]
		public static bool FirebaseMessagingUseUserProperties
		{
			[Token(Token = "0x600C7EA")]
			[Address(RVA = "0x187046C", Offset = "0x187046C", VA = "0x7BBC07046C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600C7EB RID: 51179 RVA: 0x00035D30 File Offset: 0x00033F30
		[Token(Token = "0x17000D44")]
		public static bool FirebaseMessagingUseTopics
		{
			[Token(Token = "0x600C7EB")]
			[Address(RVA = "0x1870518", Offset = "0x1870518", VA = "0x7BBC070518")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x00035D48 File Offset: 0x00033F48
		[Token(Token = "0x17000D45")]
		public static bool GER_Override
		{
			[Token(Token = "0x600C7EC")]
			[Address(RVA = "0x18705C4", Offset = "0x18705C4", VA = "0x7BBC0705C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600C7ED RID: 51181 RVA: 0x00035D60 File Offset: 0x00033F60
		[Token(Token = "0x17000D46")]
		public static bool GER_Enabled
		{
			[Token(Token = "0x600C7ED")]
			[Address(RVA = "0x1870670", Offset = "0x1870670", VA = "0x7BBC070670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x00035D78 File Offset: 0x00033F78
		[Token(Token = "0x17000D47")]
		public static int GER_Env
		{
			[Token(Token = "0x600C7EE")]
			[Address(RVA = "0x187071C", Offset = "0x187071C", VA = "0x7BBC07071C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600C7EF RID: 51183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D48")]
		public static string GER_SponsorId
		{
			[Token(Token = "0x600C7EF")]
			[Address(RVA = "0x18707C0", Offset = "0x18707C0", VA = "0x7BBC0707C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600C7F0 RID: 51184 RVA: 0x00035D90 File Offset: 0x00033F90
		[Token(Token = "0x17000D49")]
		public static bool GER_BypassAllFilters
		{
			[Token(Token = "0x600C7F0")]
			[Address(RVA = "0x1870878", Offset = "0x1870878", VA = "0x7BBC070878")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x0600C7F1 RID: 51185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4A")]
		public static string GER_ApiKey
		{
			[Token(Token = "0x600C7F1")]
			[Address(RVA = "0x1870924", Offset = "0x1870924", VA = "0x7BBC070924")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600C7F2 RID: 51186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4B")]
		public static string GER_EP
		{
			[Token(Token = "0x600C7F2")]
			[Address(RVA = "0x18709DC", Offset = "0x18709DC", VA = "0x7BBC0709DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600C7F3 RID: 51187 RVA: 0x00035DA8 File Offset: 0x00033FA8
		[Token(Token = "0x17000D4C")]
		public static bool Subscription_Override
		{
			[Token(Token = "0x600C7F3")]
			[Address(RVA = "0x1870A94", Offset = "0x1870A94", VA = "0x7BBC070A94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x00035DC0 File Offset: 0x00033FC0
		[Token(Token = "0x17000D4D")]
		public static bool Subscription_RebateCard_Enabled
		{
			[Token(Token = "0x600C7F4")]
			[Address(RVA = "0x1870B40", Offset = "0x1870B40", VA = "0x7BBC070B40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600C7F5 RID: 51189 RVA: 0x00035DD8 File Offset: 0x00033FD8
		[Token(Token = "0x17000D4E")]
		public static bool Subscription_ElitePass_Enabled
		{
			[Token(Token = "0x600C7F5")]
			[Address(RVA = "0x1870BEC", Offset = "0x1870BEC", VA = "0x7BBC070BEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600C7F6 RID: 51190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4F")]
		public static string Subscription_ProductIdentifier_ElitePass
		{
			[Token(Token = "0x600C7F6")]
			[Address(RVA = "0x1870C98", Offset = "0x1870C98", VA = "0x7BBC070C98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x0600C7F7 RID: 51191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D50")]
		public static string Subscription_ProductIdentifier_MonthCard
		{
			[Token(Token = "0x600C7F7")]
			[Address(RVA = "0x1870D50", Offset = "0x1870D50", VA = "0x7BBC070D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x0600C7F8 RID: 51192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D51")]
		public static string Subscription_ProductIdentifier_WeekCard
		{
			[Token(Token = "0x600C7F8")]
			[Address(RVA = "0x1870E08", Offset = "0x1870E08", VA = "0x7BBC070E08")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600C7F9 RID: 51193 RVA: 0x00035DF0 File Offset: 0x00033FF0
		[Token(Token = "0x17000D52")]
		public static int Subscription_GracePeriod_ProductId
		{
			[Token(Token = "0x600C7F9")]
			[Address(RVA = "0x1870EC0", Offset = "0x1870EC0", VA = "0x7BBC070EC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x00035E08 File Offset: 0x00034008
		[Token(Token = "0x17000D53")]
		public static ulong Subscription_GracePeriod_ExpiryTime
		{
			[Token(Token = "0x600C7FA")]
			[Address(RVA = "0x1870F64", Offset = "0x1870F64", VA = "0x7BBC070F64")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x0600C7FB RID: 51195 RVA: 0x00035E20 File Offset: 0x00034020
		[Token(Token = "0x17000D54")]
		public static bool ShowPaymentFailureSignatureOverride
		{
			[Token(Token = "0x600C7FB")]
			[Address(RVA = "0x1871008", Offset = "0x1871008", VA = "0x7BBC071008")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x00035E38 File Offset: 0x00034038
		[Token(Token = "0x17000D55")]
		public static bool ShowPaymentFailureSignature
		{
			[Token(Token = "0x600C7FC")]
			[Address(RVA = "0x18710B4", Offset = "0x18710B4", VA = "0x7BBC0710B4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600C7FD RID: 51197 RVA: 0x00035E50 File Offset: 0x00034050
		[Token(Token = "0x17000D56")]
		public static long ElitePassSubscribeStart_Seconds
		{
			[Token(Token = "0x600C7FD")]
			[Address(RVA = "0x1871160", Offset = "0x1871160", VA = "0x7BBC071160")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00035E68 File Offset: 0x00034068
		[Token(Token = "0x17000D57")]
		public static long ElitePassSubscribeEnd_Seconds
		{
			[Token(Token = "0x600C7FE")]
			[Address(RVA = "0x187120C", Offset = "0x187120C", VA = "0x7BBC07120C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600C7FF RID: 51199 RVA: 0x00035E80 File Offset: 0x00034080
		[Token(Token = "0x17000D58")]
		public static bool ElitePassSubscribedOverride
		{
			[Token(Token = "0x600C7FF")]
			[Address(RVA = "0x18712B8", Offset = "0x18712B8", VA = "0x7BBC0712B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x00035E98 File Offset: 0x00034098
		[Token(Token = "0x17000D59")]
		public static bool ElitePassSubscribed
		{
			[Token(Token = "0x600C800")]
			[Address(RVA = "0x1871364", Offset = "0x1871364", VA = "0x7BBC071364")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600C801 RID: 51201 RVA: 0x00035EB0 File Offset: 0x000340B0
		[Token(Token = "0x17000D5A")]
		public static bool CopyOpenID
		{
			[Token(Token = "0x600C801")]
			[Address(RVA = "0x1871410", Offset = "0x1871410", VA = "0x7BBC071410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600C802 RID: 51202 RVA: 0x00035EC8 File Offset: 0x000340C8
		[Token(Token = "0x17000D5B")]
		public static bool TPNS_Override
		{
			[Token(Token = "0x600C802")]
			[Address(RVA = "0x18714BC", Offset = "0x18714BC", VA = "0x7BBC0714BC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600C803 RID: 51203 RVA: 0x00035EE0 File Offset: 0x000340E0
		[Token(Token = "0x17000D5C")]
		public static bool TPNS
		{
			[Token(Token = "0x600C803")]
			[Address(RVA = "0x1871568", Offset = "0x1871568", VA = "0x7BBC071568")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x00035EF8 File Offset: 0x000340F8
		[Token(Token = "0x17000D5D")]
		public static bool TPNS_FCM
		{
			[Token(Token = "0x600C804")]
			[Address(RVA = "0x1871614", Offset = "0x1871614", VA = "0x7BBC071614")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600C805 RID: 51205 RVA: 0x00035F10 File Offset: 0x00034110
		[Token(Token = "0x17000D5E")]
		public static bool TPNS_NoCache
		{
			[Token(Token = "0x600C805")]
			[Address(RVA = "0x18716C0", Offset = "0x18716C0", VA = "0x7BBC0716C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x00035F28 File Offset: 0x00034128
		[Token(Token = "0x17000D5F")]
		public static bool TPNS_Preview
		{
			[Token(Token = "0x600C806")]
			[Address(RVA = "0x187176C", Offset = "0x187176C", VA = "0x7BBC07176C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600C807 RID: 51207 RVA: 0x00035F40 File Offset: 0x00034140
		[Token(Token = "0x17000D60")]
		public static bool WebViewOverride
		{
			[Token(Token = "0x600C807")]
			[Address(RVA = "0x1871818", Offset = "0x1871818", VA = "0x7BBC071818")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x00035F58 File Offset: 0x00034158
		[Token(Token = "0x17000D61")]
		public static bool WebViewDisableJavaScriptInjection
		{
			[Token(Token = "0x600C808")]
			[Address(RVA = "0x18718C4", Offset = "0x18718C4", VA = "0x7BBC0718C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600C809 RID: 51209 RVA: 0x00035F70 File Offset: 0x00034170
		[Token(Token = "0x17000D62")]
		public static bool WebViewDisableMediaManipulationOnHideAndShowByJavaScript
		{
			[Token(Token = "0x600C809")]
			[Address(RVA = "0x1871970", Offset = "0x1871970", VA = "0x7BBC071970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x00035F88 File Offset: 0x00034188
		[Token(Token = "0x17000D63")]
		public static bool WebViewProtect
		{
			[Token(Token = "0x600C80A")]
			[Address(RVA = "0x1871A1C", Offset = "0x1871A1C", VA = "0x7BBC071A1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600C80B RID: 51211 RVA: 0x00035FA0 File Offset: 0x000341A0
		[Token(Token = "0x17000D64")]
		public static bool WebViewPromptFaulty
		{
			[Token(Token = "0x600C80B")]
			[Address(RVA = "0x1871AC8", Offset = "0x1871AC8", VA = "0x7BBC071AC8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600C80C RID: 51212 RVA: 0x00035FB8 File Offset: 0x000341B8
		[Token(Token = "0x17000D65")]
		public static bool WebViewFallbackToBrowser
		{
			[Token(Token = "0x600C80C")]
			[Address(RVA = "0x1871B74", Offset = "0x1871B74", VA = "0x7BBC071B74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600C80D RID: 51213 RVA: 0x00035FD0 File Offset: 0x000341D0
		[Token(Token = "0x17000D66")]
		public static bool WebViewFalseFaulty
		{
			[Token(Token = "0x600C80D")]
			[Address(RVA = "0x1871C20", Offset = "0x1871C20", VA = "0x7BBC071C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600C80E RID: 51214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D67")]
		public static string WebViewJavaScriptName
		{
			[Token(Token = "0x600C80E")]
			[Address(RVA = "0x1871CCC", Offset = "0x1871CCC", VA = "0x7BBC071CCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x00035FE8 File Offset: 0x000341E8
		[Token(Token = "0x17000D68")]
		public static bool WebViewRunJavaScript
		{
			[Token(Token = "0x600C80F")]
			[Address(RVA = "0x1871D84", Offset = "0x1871D84", VA = "0x7BBC071D84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600C810 RID: 51216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D69")]
		public static string WebViewJavaScriptEcho
		{
			[Token(Token = "0x600C810")]
			[Address(RVA = "0x1871E30", Offset = "0x1871E30", VA = "0x7BBC071E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600C811 RID: 51217 RVA: 0x00036000 File Offset: 0x00034200
		[Token(Token = "0x17000D6A")]
		public static bool WebViewLogConsoleMessages
		{
			[Token(Token = "0x600C811")]
			[Address(RVA = "0x1871EE8", Offset = "0x1871EE8", VA = "0x7BBC071EE8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x00036018 File Offset: 0x00034218
		[Token(Token = "0x17000D6B")]
		public static bool WebViewLog
		{
			[Token(Token = "0x600C812")]
			[Address(RVA = "0x1871F94", Offset = "0x1871F94", VA = "0x7BBC071F94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600C813 RID: 51219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6C")]
		public static string[] WebViewLogUrls
		{
			[Token(Token = "0x600C813")]
			[Address(RVA = "0x1872040", Offset = "0x1872040", VA = "0x7BBC072040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x0600C814 RID: 51220 RVA: 0x00036030 File Offset: 0x00034230
		[Token(Token = "0x17000D6D")]
		public static bool WebViewDeferredDisplay
		{
			[Token(Token = "0x600C814")]
			[Address(RVA = "0x1872238", Offset = "0x1872238", VA = "0x7BBC072238")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600C815 RID: 51221 RVA: 0x00036048 File Offset: 0x00034248
		[Token(Token = "0x17000D6E")]
		public static float WebViewLoadingProgressAnimationDuration
		{
			[Token(Token = "0x600C815")]
			[Address(RVA = "0x187230C", Offset = "0x187230C", VA = "0x7BBC07230C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600C816 RID: 51222 RVA: 0x00036060 File Offset: 0x00034260
		[Token(Token = "0x17000D6F")]
		public static float WebViewPromptReloadDuration
		{
			[Token(Token = "0x600C816")]
			[Address(RVA = "0x18723E0", Offset = "0x18723E0", VA = "0x7BBC0723E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600C817 RID: 51223 RVA: 0x00036078 File Offset: 0x00034278
		[Token(Token = "0x17000D70")]
		public static bool MambetLogVerbose
		{
			[Token(Token = "0x600C817")]
			[Address(RVA = "0x18724B4", Offset = "0x18724B4", VA = "0x7BBC0724B4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600C818 RID: 51224 RVA: 0x00036090 File Offset: 0x00034290
		[Token(Token = "0x17000D71")]
		public static bool MambetDebugVoiceOverride
		{
			[Token(Token = "0x600C818")]
			[Address(RVA = "0x1872560", Offset = "0x1872560", VA = "0x7BBC072560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600C819 RID: 51225 RVA: 0x000360A8 File Offset: 0x000342A8
		[Token(Token = "0x17000D72")]
		public static bool MambetDebugVoice
		{
			[Token(Token = "0x600C819")]
			[Address(RVA = "0x187260C", Offset = "0x187260C", VA = "0x7BBC07260C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x0600C81A RID: 51226 RVA: 0x000360C0 File Offset: 0x000342C0
		[Token(Token = "0x17000D73")]
		public static bool AccountOverride
		{
			[Token(Token = "0x600C81A")]
			[Address(RVA = "0x18726B8", Offset = "0x18726B8", VA = "0x7BBC0726B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600C81B RID: 51227 RVA: 0x000360D8 File Offset: 0x000342D8
		[Token(Token = "0x17000D74")]
		public static bool AccountGuestAllowed
		{
			[Token(Token = "0x600C81B")]
			[Address(RVA = "0x1872764", Offset = "0x1872764", VA = "0x7BBC072764")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x0600C81C RID: 51228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D75")]
		public static string LanguageCheckFlag
		{
			[Token(Token = "0x600C81C")]
			[Address(RVA = "0x1872810", Offset = "0x1872810", VA = "0x7BBC072810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600C81D RID: 51229 RVA: 0x000360F0 File Offset: 0x000342F0
		// (set) Token: 0x0600C81E RID: 51230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D76")]
		public static bool TestChangeClothIngame
		{
			[Token(Token = "0x600C81D")]
			[Address(RVA = "0x18728C8", Offset = "0x18728C8", VA = "0x7BBC0728C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F4C", Offset = "0x1147F4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C81E")]
			[Address(RVA = "0x1872930", Offset = "0x1872930", VA = "0x7BBC072930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F5C", Offset = "0x1147F5C")]
			set
			{
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600C81F RID: 51231 RVA: 0x00036108 File Offset: 0x00034308
		// (set) Token: 0x0600C820 RID: 51232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D77")]
		public static bool TestAutoChangeClothInGame
		{
			[Token(Token = "0x600C81F")]
			[Address(RVA = "0x18729A0", Offset = "0x18729A0", VA = "0x7BBC0729A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F6C", Offset = "0x1147F6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C820")]
			[Address(RVA = "0x1872A08", Offset = "0x1872A08", VA = "0x7BBC072A08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147F7C", Offset = "0x1147F7C")]
			set
			{
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600C821 RID: 51233 RVA: 0x00036120 File Offset: 0x00034320
		// (set) Token: 0x0600C822 RID: 51234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D78")]
		public static bool IsAnnouncementDebugMode
		{
			[Token(Token = "0x600C821")]
			[Address(RVA = "0x1872A78", Offset = "0x1872A78", VA = "0x7BBC072A78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C822")]
			[Address(RVA = "0x1872B24", Offset = "0x1872B24", VA = "0x7BBC072B24")]
			set
			{
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x0600C823 RID: 51235 RVA: 0x00036138 File Offset: 0x00034338
		[Token(Token = "0x17000D79")]
		public static bool UMALogErrors
		{
			[Token(Token = "0x600C823")]
			[Address(RVA = "0x1872BC8", Offset = "0x1872BC8", VA = "0x7BBC072BC8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x00036150 File Offset: 0x00034350
		[Token(Token = "0x17000D7A")]
		public static bool UMALogDetails
		{
			[Token(Token = "0x600C824")]
			[Address(RVA = "0x1872C74", Offset = "0x1872C74", VA = "0x7BBC072C74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x0600C825 RID: 51237 RVA: 0x00036168 File Offset: 0x00034368
		[Token(Token = "0x17000D7B")]
		public static bool UMALogDetails3P
		{
			[Token(Token = "0x600C825")]
			[Address(RVA = "0x1872D20", Offset = "0x1872D20", VA = "0x7BBC072D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x00036180 File Offset: 0x00034380
		[Token(Token = "0x17000D7C")]
		public static bool UMALogTimes
		{
			[Token(Token = "0x600C826")]
			[Address(RVA = "0x1872DCC", Offset = "0x1872DCC", VA = "0x7BBC072DCC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600C827 RID: 51239 RVA: 0x00036198 File Offset: 0x00034398
		[Token(Token = "0x17000D7D")]
		public static bool InAppReviewOverride
		{
			[Token(Token = "0x600C827")]
			[Address(RVA = "0x1872E78", Offset = "0x1872E78", VA = "0x7BBC072E78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x000361B0 File Offset: 0x000343B0
		[Token(Token = "0x17000D7E")]
		public static bool InAppReviewEnabled
		{
			[Token(Token = "0x600C828")]
			[Address(RVA = "0x1872F24", Offset = "0x1872F24", VA = "0x7BBC072F24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C829 RID: 51241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D7F")]
		public static string IPRegion
		{
			[Token(Token = "0x600C82A")]
			[Address(RVA = "0x1873070", Offset = "0x1873070", VA = "0x7BBC073070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C829")]
			[Address(RVA = "0x1872FD0", Offset = "0x1872FD0", VA = "0x7BBC072FD0")]
			set
			{
			}
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C82B")]
		[Address(RVA = "0x1873120", Offset = "0x1873120", VA = "0x7BBC073120")]
		public static string GetClientIP()
		{
			return null;
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C82C")]
		[Address(RVA = "0x18731DC", Offset = "0x18731DC", VA = "0x7BBC0731DC")]
		private static string GetLocalIPAddress()
		{
			return null;
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82D")]
		[Address(RVA = "0x187332C", Offset = "0x187332C", VA = "0x7BBC07332C")]
		public static void SelectServer(ServerSettingsData region)
		{
		}

		// Token: 0x0600C82E RID: 51246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82E")]
		[Address(RVA = "0x1873444", Offset = "0x1873444", VA = "0x7BBC073444")]
		public static void UpdateServerConfigFromHTTPVerGet(string serverAddr, string cdnAddr, bool isIOSReview)
		{
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C82F")]
		[Address(RVA = "0x18735E0", Offset = "0x18735E0", VA = "0x7BBC0735E0")]
		public static string GetRegion()
		{
			return null;
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C830")]
		[Address(RVA = "0x18736F0", Offset = "0x18736F0", VA = "0x7BBC0736F0")]
		private static GameConfig.LocalConfig ReadUrlFromLocalConfig()
		{
			return null;
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C831")]
		[Address(RVA = "0x18739D0", Offset = "0x18739D0", VA = "0x7BBC0739D0")]
		public static List<AnnoucementInfo> ReadAnnouncementInfoFromLocalCSV()
		{
			return null;
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C832")]
		[Address(RVA = "0x1873E38", Offset = "0x1873E38", VA = "0x7BBC073E38")]
		private static void SetAppSrc()
		{
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C833")]
		[Address(RVA = "0x1873EB4", Offset = "0x1873EB4", VA = "0x7BBC073EB4")]
		public static void GotoAppSrc()
		{
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C834")]
		[Address(RVA = "0x1873F20", Offset = "0x1873F20", VA = "0x7BBC073F20")]
		public static void Reset()
		{
		}

		// Token: 0x0400F9B2 RID: 63922
		[Token(Token = "0x400F9B2")]
		[FieldOffset(Offset = "0x0")]
		public static string VerAddr;

		// Token: 0x0400F9B3 RID: 63923
		[Token(Token = "0x400F9B3")]
		[FieldOffset(Offset = "0x8")]
		public static string CDNAddr;

		// Token: 0x0400F9B4 RID: 63924
		[Token(Token = "0x400F9B4")]
		[FieldOffset(Offset = "0x10")]
		public static string ServerAddr;

		// Token: 0x0400F9B5 RID: 63925
		[Token(Token = "0x400F9B5")]
		[FieldOffset(Offset = "0x18")]
		public static string MajorServerAddr;

		// Token: 0x0400F9B6 RID: 63926
		[Token(Token = "0x400F9B6")]
		[FieldOffset(Offset = "0x20")]
		public static string LogServerAddr;

		// Token: 0x0400F9B7 RID: 63927
		[Token(Token = "0x400F9B7")]
		[FieldOffset(Offset = "0x28")]
		public static string NetworkLogServerAddr;

		// Token: 0x0400F9B8 RID: 63928
		[Token(Token = "0x400F9B8")]
		[FieldOffset(Offset = "0x30")]
		private static bool _IsIOSReview;

		// Token: 0x0400F9B9 RID: 63929
		[Token(Token = "0x400F9B9")]
		[FieldOffset(Offset = "0x31")]
		public static bool SkipVersionCheck;

		// Token: 0x0400F9BA RID: 63930
		[Token(Token = "0x400F9BA")]
		[FieldOffset(Offset = "0x32")]
		public static bool SkipResourceDownload;

		// Token: 0x0400F9BB RID: 63931
		[Token(Token = "0x400F9BB")]
		[FieldOffset(Offset = "0x33")]
		public static bool LegacyGuest;

		// Token: 0x0400F9BC RID: 63932
		[Token(Token = "0x400F9BC")]
		[FieldOffset(Offset = "0x38")]
		private static string m_BillboardServerAddr;

		// Token: 0x0400F9BD RID: 63933
		[Token(Token = "0x400F9BD")]
		[FieldOffset(Offset = "0x40")]
		public static GameConfig.EAppStore AppStore;

		// Token: 0x0400F9BE RID: 63934
		[Token(Token = "0x400F9BE")]
		[FieldOffset(Offset = "0x48")]
		public static string AppStoreAddr;

		// Token: 0x0400F9BF RID: 63935
		[Token(Token = "0x400F9BF")]
		[FieldOffset(Offset = "0x50")]
		public static bool UseAssetBundle;

		// Token: 0x0400F9C0 RID: 63936
		[Token(Token = "0x400F9C0")]
		[FieldOffset(Offset = "0x54")]
		public static LocLang CurrentLang;

		// Token: 0x0400F9C1 RID: 63937
		[Token(Token = "0x400F9C1")]
		[FieldOffset(Offset = "0x58")]
		public static float CAM_OFFSET_FOR_SNIPER;

		// Token: 0x0400F9C2 RID: 63938
		[Token(Token = "0x400F9C2")]
		[FieldOffset(Offset = "0x60")]
		public static string ClientIP;

		// Token: 0x0400F9C3 RID: 63939
		[Token(Token = "0x400F9C3")]
		[FieldOffset(Offset = "0x68")]
		public static int EuroPolicyVersion;

		// Token: 0x0400F9C4 RID: 63940
		[Token(Token = "0x400F9C4")]
		[FieldOffset(Offset = "0x70")]
		private static string _Country;

		// Token: 0x0400F9C5 RID: 63941
		[Token(Token = "0x400F9C5")]
		[FieldOffset(Offset = "0x78")]
		public static bool IsFirewallOpen;

		// Token: 0x0400F9C6 RID: 63942
		[Token(Token = "0x400F9C6")]
		[FieldOffset(Offset = "0x79")]
		public static bool MuteSound;

		// Token: 0x0400F9C7 RID: 63943
		[Token(Token = "0x400F9C7")]
		[FieldOffset(Offset = "0x80")]
		public static string DevId;

		// Token: 0x0400F9C8 RID: 63944
		[Token(Token = "0x400F9C8")]
		[FieldOffset(Offset = "0x88")]
		public static bool DebugMode;

		// Token: 0x0400F9C9 RID: 63945
		[Token(Token = "0x400F9C9")]
		[FieldOffset(Offset = "0x89")]
		private static bool _ShowDebugInfo;

		// Token: 0x0400F9CA RID: 63946
		[Token(Token = "0x400F9CA")]
		[FieldOffset(Offset = "0x8A")]
		public static bool DrawAimAssistDebugInfo;

		// Token: 0x0400F9CB RID: 63947
		[Token(Token = "0x400F9CB")]
		[FieldOffset(Offset = "0x8B")]
		public static bool ChooseRegionEnabled;

		// Token: 0x0400F9CC RID: 63948
		[Token(Token = "0x400F9CC")]
		[FieldOffset(Offset = "0x8C")]
		public static bool TestModeEnabled;

		// Token: 0x0400F9CD RID: 63949
		[Token(Token = "0x400F9CD")]
		[FieldOffset(Offset = "0x8D")]
		public static bool EnableRemoteConsole;

		// Token: 0x0400F9CE RID: 63950
		[Token(Token = "0x400F9CE")]
		[FieldOffset(Offset = "0x90")]
		public static string UrgentAnnouncement;

		// Token: 0x0400F9CF RID: 63951
		[Token(Token = "0x400F9CF")]
		[FieldOffset(Offset = "0x98")]
		public static bool DebugHack;

		// Token: 0x0400F9D0 RID: 63952
		[Token(Token = "0x400F9D0")]
		[FieldOffset(Offset = "0x99")]
		public static bool garenaProduction;

		// Token: 0x0400F9D1 RID: 63953
		[Token(Token = "0x400F9D1")]
		[FieldOffset(Offset = "0xA0")]
		public static string garenaAppId;

		// Token: 0x0400F9D2 RID: 63954
		[Token(Token = "0x400F9D2")]
		[FieldOffset(Offset = "0xA8")]
		public static string garenaAppKeySandbox;

		// Token: 0x0400F9D3 RID: 63955
		[Token(Token = "0x400F9D3")]
		[FieldOffset(Offset = "0xB0")]
		public static string garenaAppKeyProduction;

		// Token: 0x0400F9D4 RID: 63956
		[Token(Token = "0x400F9D4")]
		public const string GOOGLE_CLIENT_ID = "185753624591-3sg2arfuus5i1anc2jcfarepnf6cdlaq.apps.googleusercontent.com";

		// Token: 0x0400F9D5 RID: 63957
		[Token(Token = "0x400F9D5")]
		[FieldOffset(Offset = "0xB8")]
		public static string garenaPushAppkeySandbox;

		// Token: 0x0400F9D6 RID: 63958
		[Token(Token = "0x400F9D6")]
		[FieldOffset(Offset = "0xC0")]
		public static string garenaPushAppkeyProduction;

		// Token: 0x0400F9D7 RID: 63959
		[Token(Token = "0x400F9D7")]
		[FieldOffset(Offset = "0xC8")]
		public static int NeedCheckLoginFailedCount;

		// Token: 0x0400F9D8 RID: 63960
		[Token(Token = "0x400F9D8")]
		[FieldOffset(Offset = "0xD0")]
		private static GameConfig.LocalConfig m_LocalConfig;

		// Token: 0x0400F9D9 RID: 63961
		[Token(Token = "0x400F9D9")]
		[FieldOffset(Offset = "0xD8")]
		private static DateTime APOCH_UTC;

		// Token: 0x0400F9DA RID: 63962
		[Token(Token = "0x400F9DA")]
		[FieldOffset(Offset = "0xE0")]
		private static readonly string[] _WebViewLogUrlSeparators;

		// Token: 0x0400F9DB RID: 63963
		[Token(Token = "0x400F9DB")]
		[FieldOffset(Offset = "0xE8")]
		private static string[] _WebViewLogUrls;

		// Token: 0x0400F9DC RID: 63964
		[Token(Token = "0x400F9DC")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11308BC", Offset = "0x11308BC")]
		private static bool <TestChangeClothIngame>k__BackingField;

		// Token: 0x0400F9DD RID: 63965
		[Token(Token = "0x400F9DD")]
		[FieldOffset(Offset = "0xF1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11308CC", Offset = "0x11308CC")]
		private static bool <TestAutoChangeClothInGame>k__BackingField;

		// Token: 0x020025E3 RID: 9699
		[Token(Token = "0x20025E3")]
		public enum EAppStore
		{
			// Token: 0x0400F9DF RID: 63967
			[Token(Token = "0x400F9DF")]
			GooglePlay,
			// Token: 0x0400F9E0 RID: 63968
			[Token(Token = "0x400F9E0")]
			Apple,
			// Token: 0x0400F9E1 RID: 63969
			[Token(Token = "0x400F9E1")]
			Official,
			// Token: 0x0400F9E2 RID: 63970
			[Token(Token = "0x400F9E2")]
			Huawei,
			// Token: 0x0400F9E3 RID: 63971
			[Token(Token = "0x400F9E3")]
			ThirdParty,
			// Token: 0x0400F9E4 RID: 63972
			[Token(Token = "0x400F9E4")]
			Samsung,
			// Token: 0x0400F9E5 RID: 63973
			[Token(Token = "0x400F9E5")]
			Trial,
			// Token: 0x0400F9E6 RID: 63974
			[Token(Token = "0x400F9E6")]
			GooglePlay_Max,
			// Token: 0x0400F9E7 RID: 63975
			[Token(Token = "0x400F9E7")]
			Apple_Max
		}

		// Token: 0x020025E4 RID: 9700
		[Token(Token = "0x20025E4")]
		private class LocalConfig
		{
			// Token: 0x0600C836 RID: 51254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C836")]
			[Address(RVA = "0x1873978", Offset = "0x1873978", VA = "0x7BBC073978")]
			public LocalConfig()
			{
			}

			// Token: 0x0400F9E8 RID: 63976
			[Token(Token = "0x400F9E8")]
			[FieldOffset(Offset = "0x10")]
			public string serverUrl;

			// Token: 0x0400F9E9 RID: 63977
			[Token(Token = "0x400F9E9")]
			[FieldOffset(Offset = "0x18")]
			public string CDNAddr;

			// Token: 0x0400F9EA RID: 63978
			[Token(Token = "0x400F9EA")]
			[FieldOffset(Offset = "0x20")]
			public string region;

			// Token: 0x0400F9EB RID: 63979
			[Token(Token = "0x400F9EB")]
			[FieldOffset(Offset = "0x28")]
			public string countryCode;

			// Token: 0x0400F9EC RID: 63980
			[Token(Token = "0x400F9EC")]
			[FieldOffset(Offset = "0x30")]
			public string verAddr;

			// Token: 0x0400F9ED RID: 63981
			[Token(Token = "0x400F9ED")]
			[FieldOffset(Offset = "0x38")]
			public bool skipVersionCheck;

			// Token: 0x0400F9EE RID: 63982
			[Token(Token = "0x400F9EE")]
			[FieldOffset(Offset = "0x39")]
			public bool skipResourceDownload;

			// Token: 0x0400F9EF RID: 63983
			[Token(Token = "0x400F9EF")]
			[FieldOffset(Offset = "0x40")]
			public string ipRegion;

			// Token: 0x0400F9F0 RID: 63984
			[Token(Token = "0x400F9F0")]
			[FieldOffset(Offset = "0x48")]
			public string fakeVersion;

			// Token: 0x0400F9F1 RID: 63985
			[Token(Token = "0x400F9F1")]
			[FieldOffset(Offset = "0x50")]
			public bool forceReview;

			// Token: 0x0400F9F2 RID: 63986
			[Token(Token = "0x400F9F2")]
			[FieldOffset(Offset = "0x58")]
			public string BillboardDesc;

			// Token: 0x0400F9F3 RID: 63987
			[Token(Token = "0x400F9F3")]
			[FieldOffset(Offset = "0x60")]
			public bool AnnouncementDebug;

			// Token: 0x0400F9F4 RID: 63988
			[Token(Token = "0x400F9F4")]
			[FieldOffset(Offset = "0x61")]
			public bool garenaOverride;

			// Token: 0x0400F9F5 RID: 63989
			[Token(Token = "0x400F9F5")]
			[FieldOffset(Offset = "0x62")]
			public bool garenaSandbox;

			// Token: 0x0400F9F6 RID: 63990
			[Token(Token = "0x400F9F6")]
			[FieldOffset(Offset = "0x63")]
			public bool gmsdkEnableDebugLog;

			// Token: 0x0400F9F7 RID: 63991
			[Token(Token = "0x400F9F7")]
			[FieldOffset(Offset = "0x64")]
			public bool legacyGuest;

			// Token: 0x0400F9F8 RID: 63992
			[Token(Token = "0x400F9F8")]
			[FieldOffset(Offset = "0x65")]
			public bool accountOverride;

			// Token: 0x0400F9F9 RID: 63993
			[Token(Token = "0x400F9F9")]
			[FieldOffset(Offset = "0x66")]
			public bool accountGuestAllowed;

			// Token: 0x0400F9FA RID: 63994
			[Token(Token = "0x400F9FA")]
			[FieldOffset(Offset = "0x67")]
			public bool debugInfoOverride;

			// Token: 0x0400F9FB RID: 63995
			[Token(Token = "0x400F9FB")]
			[FieldOffset(Offset = "0x68")]
			public bool debugInfoDisplay;

			// Token: 0x0400F9FC RID: 63996
			[Token(Token = "0x400F9FC")]
			[FieldOffset(Offset = "0x69")]
			public bool debugSkipRoomCheck;

			// Token: 0x0400F9FD RID: 63997
			[Token(Token = "0x400F9FD")]
			[FieldOffset(Offset = "0x6A")]
			public bool debugShowAccountDel;

			// Token: 0x0400F9FE RID: 63998
			[Token(Token = "0x400F9FE")]
			[FieldOffset(Offset = "0x6B")]
			public bool rebateCardOverride;

			// Token: 0x0400F9FF RID: 63999
			[Token(Token = "0x400F9FF")]
			[FieldOffset(Offset = "0x6C")]
			public bool rebateCardEnabled;

			// Token: 0x0400FA00 RID: 64000
			[Token(Token = "0x400FA00")]
			[FieldOffset(Offset = "0x6D")]
			public bool paymentBundleOverride;

			// Token: 0x0400FA01 RID: 64001
			[Token(Token = "0x400FA01")]
			[FieldOffset(Offset = "0x6E")]
			public bool paymentBundleEnabled;

			// Token: 0x0400FA02 RID: 64002
			[Token(Token = "0x400FA02")]
			[FieldOffset(Offset = "0x6F")]
			public bool paymentShopOverride;

			// Token: 0x0400FA03 RID: 64003
			[Token(Token = "0x400FA03")]
			[FieldOffset(Offset = "0x70")]
			public bool paymentShopEnabled;

			// Token: 0x0400FA04 RID: 64004
			[Token(Token = "0x400FA04")]
			[FieldOffset(Offset = "0x71")]
			public bool paymentShopFirstOverride;

			// Token: 0x0400FA05 RID: 64005
			[Token(Token = "0x400FA05")]
			[FieldOffset(Offset = "0x72")]
			public bool paymentShopFirst;

			// Token: 0x0400FA06 RID: 64006
			[Token(Token = "0x400FA06")]
			[FieldOffset(Offset = "0x78")]
			public string paymentShopCdnUrl;

			// Token: 0x0400FA07 RID: 64007
			[Token(Token = "0x400FA07")]
			[FieldOffset(Offset = "0x80")]
			public string paymentShopFallbackStrategy;

			// Token: 0x0400FA08 RID: 64008
			[Token(Token = "0x400FA08")]
			[FieldOffset(Offset = "0x88")]
			public bool paymentShopFalseFaulty;

			// Token: 0x0400FA09 RID: 64009
			[Token(Token = "0x400FA09")]
			[FieldOffset(Offset = "0x89")]
			public bool resetGuest;

			// Token: 0x0400FA0A RID: 64010
			[Token(Token = "0x400FA0A")]
			[FieldOffset(Offset = "0x90")]
			public string testOpenedByUrl;

			// Token: 0x0400FA0B RID: 64011
			[Token(Token = "0x400FA0B")]
			[FieldOffset(Offset = "0x98")]
			public string testOpenedByDeepLinkUrl;

			// Token: 0x0400FA0C RID: 64012
			[Token(Token = "0x400FA0C")]
			[FieldOffset(Offset = "0xA0")]
			public string testOpenedByWebViewUrl;

			// Token: 0x0400FA0D RID: 64013
			[Token(Token = "0x400FA0D")]
			[FieldOffset(Offset = "0xA8")]
			public string testOpenedByWebViewStyle;

			// Token: 0x0400FA0E RID: 64014
			[Token(Token = "0x400FA0E")]
			[FieldOffset(Offset = "0xB0")]
			public string testOpenedByBrowserUrl;

			// Token: 0x0400FA0F RID: 64015
			[Token(Token = "0x400FA0F")]
			[FieldOffset(Offset = "0xB8")]
			public uint prepareForNavigatePos;

			// Token: 0x0400FA10 RID: 64016
			[Token(Token = "0x400FA10")]
			[FieldOffset(Offset = "0xC0")]
			public string prepareForNavigateParam;

			// Token: 0x0400FA11 RID: 64017
			[Token(Token = "0x400FA11")]
			[FieldOffset(Offset = "0xC8")]
			public string testShareUrl;

			// Token: 0x0400FA12 RID: 64018
			[Token(Token = "0x400FA12")]
			[FieldOffset(Offset = "0xD0")]
			public string testInviteUrl;

			// Token: 0x0400FA13 RID: 64019
			[Token(Token = "0x400FA13")]
			[FieldOffset(Offset = "0xD8")]
			public string testPayMainUrl_Paid;

			// Token: 0x0400FA14 RID: 64020
			[Token(Token = "0x400FA14")]
			[FieldOffset(Offset = "0xE0")]
			public string testPayMainUrl_Unpaid;

			// Token: 0x0400FA15 RID: 64021
			[Token(Token = "0x400FA15")]
			[FieldOffset(Offset = "0xE8")]
			public string testPayItemUrl_iOS;

			// Token: 0x0400FA16 RID: 64022
			[Token(Token = "0x400FA16")]
			[FieldOffset(Offset = "0xF0")]
			public string testPayIAPButtonUrl_Android;

			// Token: 0x0400FA17 RID: 64023
			[Token(Token = "0x400FA17")]
			[FieldOffset(Offset = "0xF8")]
			public string testPaymentActivityImageUrl;

			// Token: 0x0400FA18 RID: 64024
			[Token(Token = "0x400FA18")]
			[FieldOffset(Offset = "0x100")]
			public string testPayAdImageUrl_Android;

			// Token: 0x0400FA19 RID: 64025
			[Token(Token = "0x400FA19")]
			[FieldOffset(Offset = "0x108")]
			public string testPayAdClickUrl_Android;

			// Token: 0x0400FA1A RID: 64026
			[Token(Token = "0x400FA1A")]
			[FieldOffset(Offset = "0x110")]
			public string versionOfIAPProducts;

			// Token: 0x0400FA1B RID: 64027
			[Token(Token = "0x400FA1B")]
			[FieldOffset(Offset = "0x118")]
			public string versionOfPaymentBundles;

			// Token: 0x0400FA1C RID: 64028
			[Token(Token = "0x400FA1C")]
			[FieldOffset(Offset = "0x120")]
			public string versionOfRebateCards;

			// Token: 0x0400FA1D RID: 64029
			[Token(Token = "0x400FA1D")]
			[FieldOffset(Offset = "0x128")]
			public ulong paymentBundleNextResetTime;

			// Token: 0x0400FA1E RID: 64030
			[Token(Token = "0x400FA1E")]
			[FieldOffset(Offset = "0x130")]
			public bool logoutStopTPNS;

			// Token: 0x0400FA1F RID: 64031
			[Token(Token = "0x400FA1F")]
			[FieldOffset(Offset = "0x131")]
			public bool showDebugLog;

			// Token: 0x0400FA20 RID: 64032
			[Token(Token = "0x400FA20")]
			[FieldOffset(Offset = "0x132")]
			public bool showProfilerLogs;

			// Token: 0x0400FA21 RID: 64033
			[Token(Token = "0x400FA21")]
			[FieldOffset(Offset = "0x133")]
			public bool debugHack;

			// Token: 0x0400FA22 RID: 64034
			[Token(Token = "0x400FA22")]
			[FieldOffset(Offset = "0x134")]
			public bool enableRemoteConsoleOverride;

			// Token: 0x0400FA23 RID: 64035
			[Token(Token = "0x400FA23")]
			[FieldOffset(Offset = "0x135")]
			public bool enableRemoteConsole;

			// Token: 0x0400FA24 RID: 64036
			[Token(Token = "0x400FA24")]
			[FieldOffset(Offset = "0x136")]
			public bool forceWebView;

			// Token: 0x0400FA25 RID: 64037
			[Token(Token = "0x400FA25")]
			[FieldOffset(Offset = "0x138")]
			public string testWebViewUrl;

			// Token: 0x0400FA26 RID: 64038
			[Token(Token = "0x400FA26")]
			[FieldOffset(Offset = "0x140")]
			public string testLiveTVUrl;

			// Token: 0x0400FA27 RID: 64039
			[Token(Token = "0x400FA27")]
			[FieldOffset(Offset = "0x148")]
			public string testBooyahTVUrl;

			// Token: 0x0400FA28 RID: 64040
			[Token(Token = "0x400FA28")]
			[FieldOffset(Offset = "0x150")]
			public string testRebateCardNotifyTime;

			// Token: 0x0400FA29 RID: 64041
			[Token(Token = "0x400FA29")]
			[FieldOffset(Offset = "0x158")]
			public string testPlayTestNotifyTime;

			// Token: 0x0400FA2A RID: 64042
			[Token(Token = "0x400FA2A")]
			[FieldOffset(Offset = "0x160")]
			public int testIAPBundleStoreID;

			// Token: 0x0400FA2B RID: 64043
			[Token(Token = "0x400FA2B")]
			[FieldOffset(Offset = "0x164")]
			public int testIAPBundleDuration;

			// Token: 0x0400FA2C RID: 64044
			[Token(Token = "0x400FA2C")]
			[FieldOffset(Offset = "0x168")]
			public int testMinutesOfNotifyBeforeIAPBundleEnds;

			// Token: 0x0400FA2D RID: 64045
			[Token(Token = "0x400FA2D")]
			[FieldOffset(Offset = "0x16C")]
			public bool testIAPBundleFirstTime;

			// Token: 0x0400FA2E RID: 64046
			[Token(Token = "0x400FA2E")]
			[FieldOffset(Offset = "0x16D")]
			public bool testIAPBundleAllPurchasable;

			// Token: 0x0400FA2F RID: 64047
			[Token(Token = "0x400FA2F")]
			[FieldOffset(Offset = "0x16E")]
			public bool forceIAPBundleFullyDisplay;

			// Token: 0x0400FA30 RID: 64048
			[Token(Token = "0x400FA30")]
			[FieldOffset(Offset = "0x16F")]
			public bool forcePlatformFriendReunion;

			// Token: 0x0400FA31 RID: 64049
			[Token(Token = "0x400FA31")]
			[FieldOffset(Offset = "0x170")]
			public bool testSparkEventOverride;

			// Token: 0x0400FA32 RID: 64050
			[Token(Token = "0x400FA32")]
			[FieldOffset(Offset = "0x171")]
			public bool testSparkEventEnable;

			// Token: 0x0400FA33 RID: 64051
			[Token(Token = "0x400FA33")]
			[FieldOffset(Offset = "0x172")]
			public bool testSparkEventOnEnterLobby;

			// Token: 0x0400FA34 RID: 64052
			[Token(Token = "0x400FA34")]
			[FieldOffset(Offset = "0x173")]
			public bool testSparkEventDebugMode;

			// Token: 0x0400FA35 RID: 64053
			[Token(Token = "0x400FA35")]
			[FieldOffset(Offset = "0x178")]
			public string testDeviceIdForGoogleAdMob;

			// Token: 0x0400FA36 RID: 64054
			[Token(Token = "0x400FA36")]
			[FieldOffset(Offset = "0x180")]
			public bool testAdMob;

			// Token: 0x0400FA37 RID: 64055
			[Token(Token = "0x400FA37")]
			[FieldOffset(Offset = "0x181")]
			public bool testAdMobOverride;

			// Token: 0x0400FA38 RID: 64056
			[Token(Token = "0x400FA38")]
			[FieldOffset(Offset = "0x188")]
			public string testRewardedVideoAdUnitId;

			// Token: 0x0400FA39 RID: 64057
			[Token(Token = "0x400FA39")]
			[FieldOffset(Offset = "0x190")]
			public bool forceEnableRewardedVideo;

			// Token: 0x0400FA3A RID: 64058
			[Token(Token = "0x400FA3A")]
			[FieldOffset(Offset = "0x191")]
			public bool forceEnableRewardVideoAfterMatch;

			// Token: 0x0400FA3B RID: 64059
			[Token(Token = "0x400FA3B")]
			[FieldOffset(Offset = "0x198")]
			public string testFreeGachaNotifyTime;

			// Token: 0x0400FA3C RID: 64060
			[Token(Token = "0x400FA3C")]
			[FieldOffset(Offset = "0x1A0")]
			public bool disableRandomDelayForNotifies;

			// Token: 0x0400FA3D RID: 64061
			[Token(Token = "0x400FA3D")]
			[FieldOffset(Offset = "0x1A4")]
			public int paymentBundleReloadInterval;

			// Token: 0x0400FA3E RID: 64062
			[Token(Token = "0x400FA3E")]
			[FieldOffset(Offset = "0x1A8")]
			public bool forceDisplayAllPaymentTabs;

			// Token: 0x0400FA3F RID: 64063
			[Token(Token = "0x400FA3F")]
			[FieldOffset(Offset = "0x1A9")]
			public bool screenshotForIAPBundles;

			// Token: 0x0400FA40 RID: 64064
			[Token(Token = "0x400FA40")]
			[FieldOffset(Offset = "0x1AA")]
			public bool loginLogVerbose;

			// Token: 0x0400FA41 RID: 64065
			[Token(Token = "0x400FA41")]
			[FieldOffset(Offset = "0x1AB")]
			public bool autoUIIntentsLogVerbose;

			// Token: 0x0400FA42 RID: 64066
			[Token(Token = "0x400FA42")]
			[FieldOffset(Offset = "0x1AC")]
			public bool uiWaitingLogVerbose;

			// Token: 0x0400FA43 RID: 64067
			[Token(Token = "0x400FA43")]
			[FieldOffset(Offset = "0x1AD")]
			public bool iapLogVerbose;

			// Token: 0x0400FA44 RID: 64068
			[Token(Token = "0x400FA44")]
			[FieldOffset(Offset = "0x1AE")]
			public bool rebateCardLogVerbose;

			// Token: 0x0400FA45 RID: 64069
			[Token(Token = "0x400FA45")]
			[FieldOffset(Offset = "0x1AF")]
			public bool localNotifyLogVerbose;

			// Token: 0x0400FA46 RID: 64070
			[Token(Token = "0x400FA46")]
			[FieldOffset(Offset = "0x1B0")]
			public bool gerLogVerbose;

			// Token: 0x0400FA47 RID: 64071
			[Token(Token = "0x400FA47")]
			[FieldOffset(Offset = "0x1B1")]
			public bool interAppLogVerbose;

			// Token: 0x0400FA48 RID: 64072
			[Token(Token = "0x400FA48")]
			[FieldOffset(Offset = "0x1B2")]
			public bool tpnsLogVerbose;

			// Token: 0x0400FA49 RID: 64073
			[Token(Token = "0x400FA49")]
			[FieldOffset(Offset = "0x1B3")]
			public bool mambetLogVerbose;

			// Token: 0x0400FA4A RID: 64074
			[Token(Token = "0x400FA4A")]
			[FieldOffset(Offset = "0x1B4")]
			public bool mambetDebugVoiceOverride;

			// Token: 0x0400FA4B RID: 64075
			[Token(Token = "0x400FA4B")]
			[FieldOffset(Offset = "0x1B5")]
			public bool mambetDebugVoice;

			// Token: 0x0400FA4C RID: 64076
			[Token(Token = "0x400FA4C")]
			[FieldOffset(Offset = "0x1B6")]
			public bool forceCrash;

			// Token: 0x0400FA4D RID: 64077
			[Token(Token = "0x400FA4D")]
			[FieldOffset(Offset = "0x1B7")]
			public bool firebaseLogVerbose;

			// Token: 0x0400FA4E RID: 64078
			[Token(Token = "0x400FA4E")]
			[FieldOffset(Offset = "0x1B8")]
			public bool firebaseSettingsOverride;

			// Token: 0x0400FA4F RID: 64079
			[Token(Token = "0x400FA4F")]
			[FieldOffset(Offset = "0x1B9")]
			public bool firebaseEnabled;

			// Token: 0x0400FA50 RID: 64080
			[Token(Token = "0x400FA50")]
			[FieldOffset(Offset = "0x1BA")]
			public bool firebaseMessagingEnabled;

			// Token: 0x0400FA51 RID: 64081
			[Token(Token = "0x400FA51")]
			[FieldOffset(Offset = "0x1BB")]
			public bool firebaseAnalyticsEnabled;

			// Token: 0x0400FA52 RID: 64082
			[Token(Token = "0x400FA52")]
			[FieldOffset(Offset = "0x1BC")]
			public bool firebaseCrashlyticsEnabled;

			// Token: 0x0400FA53 RID: 64083
			[Token(Token = "0x400FA53")]
			[FieldOffset(Offset = "0x1BD")]
			public bool firebaseMessagingSettingsOverride;

			// Token: 0x0400FA54 RID: 64084
			[Token(Token = "0x400FA54")]
			[FieldOffset(Offset = "0x1BE")]
			public bool firebaseMessagingUseUserProperties;

			// Token: 0x0400FA55 RID: 64085
			[Token(Token = "0x400FA55")]
			[FieldOffset(Offset = "0x1BF")]
			public bool firebaseMessagingUseTopics;

			// Token: 0x0400FA56 RID: 64086
			[Token(Token = "0x400FA56")]
			[FieldOffset(Offset = "0x1C0")]
			public bool firebaseCrashlyticsUnityLogTypesOverride;

			// Token: 0x0400FA57 RID: 64087
			[Token(Token = "0x400FA57")]
			[FieldOffset(Offset = "0x1C4")]
			public int firebaseCrashlyticsUnityLogTypes;

			// Token: 0x0400FA58 RID: 64088
			[Token(Token = "0x400FA58")]
			[FieldOffset(Offset = "0x1C8")]
			public bool disableCacheForFirebaseAnalytics;

			// Token: 0x0400FA59 RID: 64089
			[Token(Token = "0x400FA59")]
			[FieldOffset(Offset = "0x1C9")]
			public bool disableCacheForFirebaseMessaging;

			// Token: 0x0400FA5A RID: 64090
			[Token(Token = "0x400FA5A")]
			[FieldOffset(Offset = "0x1D0")]
			public string detectAndroidApplicationBundleIdentifier;

			// Token: 0x0400FA5B RID: 64091
			[Token(Token = "0x400FA5B")]
			[FieldOffset(Offset = "0x1D8")]
			public bool testChangeClothIngame;

			// Token: 0x0400FA5C RID: 64092
			[Token(Token = "0x400FA5C")]
			[FieldOffset(Offset = "0x1DC")]
			public float durationforEatingChicken;

			// Token: 0x0400FA5D RID: 64093
			[Token(Token = "0x400FA5D")]
			[FieldOffset(Offset = "0x1E0")]
			public bool GER_Override;

			// Token: 0x0400FA5E RID: 64094
			[Token(Token = "0x400FA5E")]
			[FieldOffset(Offset = "0x1E1")]
			public bool GER_Enabled;

			// Token: 0x0400FA5F RID: 64095
			[Token(Token = "0x400FA5F")]
			[FieldOffset(Offset = "0x1E4")]
			public int GER_Env;

			// Token: 0x0400FA60 RID: 64096
			[Token(Token = "0x400FA60")]
			[FieldOffset(Offset = "0x1E8")]
			public string GER_Region;

			// Token: 0x0400FA61 RID: 64097
			[Token(Token = "0x400FA61")]
			[FieldOffset(Offset = "0x1F0")]
			public bool GER_BypassAllFilters;

			// Token: 0x0400FA62 RID: 64098
			[Token(Token = "0x400FA62")]
			[FieldOffset(Offset = "0x1F8")]
			public string GER_SponsorId;

			// Token: 0x0400FA63 RID: 64099
			[Token(Token = "0x400FA63")]
			[FieldOffset(Offset = "0x200")]
			public string GER_ApiKey;

			// Token: 0x0400FA64 RID: 64100
			[Token(Token = "0x400FA64")]
			[FieldOffset(Offset = "0x208")]
			public string GER_EP;

			// Token: 0x0400FA65 RID: 64101
			[Token(Token = "0x400FA65")]
			[FieldOffset(Offset = "0x210")]
			public bool Subscription_Override;

			// Token: 0x0400FA66 RID: 64102
			[Token(Token = "0x400FA66")]
			[FieldOffset(Offset = "0x211")]
			public bool Subscription_RebateCard_Enabled;

			// Token: 0x0400FA67 RID: 64103
			[Token(Token = "0x400FA67")]
			[FieldOffset(Offset = "0x212")]
			public bool Subscription_ElitePass_Enabled;

			// Token: 0x0400FA68 RID: 64104
			[Token(Token = "0x400FA68")]
			[FieldOffset(Offset = "0x218")]
			public string Subscription_ProductIdentifier_WeekCard;

			// Token: 0x0400FA69 RID: 64105
			[Token(Token = "0x400FA69")]
			[FieldOffset(Offset = "0x220")]
			public string Subscription_ProductIdentifier_MonthCard;

			// Token: 0x0400FA6A RID: 64106
			[Token(Token = "0x400FA6A")]
			[FieldOffset(Offset = "0x228")]
			public string Subscription_ProductIdentifier_ElitePass;

			// Token: 0x0400FA6B RID: 64107
			[Token(Token = "0x400FA6B")]
			[FieldOffset(Offset = "0x230")]
			public int Subscription_GracePeriod_ProductId;

			// Token: 0x0400FA6C RID: 64108
			[Token(Token = "0x400FA6C")]
			[FieldOffset(Offset = "0x238")]
			public ulong Subscription_GracePeriod_ExpiryTime;

			// Token: 0x0400FA6D RID: 64109
			[Token(Token = "0x400FA6D")]
			[FieldOffset(Offset = "0x240")]
			public string ElitePassSubscribeStart;

			// Token: 0x0400FA6E RID: 64110
			[Token(Token = "0x400FA6E")]
			[FieldOffset(Offset = "0x248")]
			public string ElitePassSubscribeEnd;

			// Token: 0x0400FA6F RID: 64111
			[Token(Token = "0x400FA6F")]
			[FieldOffset(Offset = "0x250")]
			public bool ElitePassSubscribedOverride;

			// Token: 0x0400FA70 RID: 64112
			[Token(Token = "0x400FA70")]
			[FieldOffset(Offset = "0x251")]
			public bool ElitePassSubscribed;

			// Token: 0x0400FA71 RID: 64113
			[Token(Token = "0x400FA71")]
			[FieldOffset(Offset = "0x252")]
			public bool showPaymentFailureSignatureOverride;

			// Token: 0x0400FA72 RID: 64114
			[Token(Token = "0x400FA72")]
			[FieldOffset(Offset = "0x253")]
			public bool showPaymentFailureSignature;

			// Token: 0x0400FA73 RID: 64115
			[Token(Token = "0x400FA73")]
			[FieldOffset(Offset = "0x254")]
			public bool copyOpenID;

			// Token: 0x0400FA74 RID: 64116
			[Token(Token = "0x400FA74")]
			[FieldOffset(Offset = "0x258")]
			public string languageCheckFlag;

			// Token: 0x0400FA75 RID: 64117
			[Token(Token = "0x400FA75")]
			[FieldOffset(Offset = "0x260")]
			public string testProductIdentifier;

			// Token: 0x0400FA76 RID: 64118
			[Token(Token = "0x400FA76")]
			[FieldOffset(Offset = "0x268")]
			public bool TPNS_Override;

			// Token: 0x0400FA77 RID: 64119
			[Token(Token = "0x400FA77")]
			[FieldOffset(Offset = "0x269")]
			public bool TPNS;

			// Token: 0x0400FA78 RID: 64120
			[Token(Token = "0x400FA78")]
			[FieldOffset(Offset = "0x26A")]
			public bool TPNS_FCM;

			// Token: 0x0400FA79 RID: 64121
			[Token(Token = "0x400FA79")]
			[FieldOffset(Offset = "0x26B")]
			public bool TPNS_NoCache;

			// Token: 0x0400FA7A RID: 64122
			[Token(Token = "0x400FA7A")]
			[FieldOffset(Offset = "0x26C")]
			public bool TPNS_Preview;

			// Token: 0x0400FA7B RID: 64123
			[Token(Token = "0x400FA7B")]
			[FieldOffset(Offset = "0x26D")]
			public bool webViewOverride;

			// Token: 0x0400FA7C RID: 64124
			[Token(Token = "0x400FA7C")]
			[FieldOffset(Offset = "0x26E")]
			public bool webViewDisableJavaScriptInjection;

			// Token: 0x0400FA7D RID: 64125
			[Token(Token = "0x400FA7D")]
			[FieldOffset(Offset = "0x26F")]
			public bool webViewDisableMediaManipulationOnHideAndShowByJavaScript;

			// Token: 0x0400FA7E RID: 64126
			[Token(Token = "0x400FA7E")]
			[FieldOffset(Offset = "0x270")]
			public bool webViewProtect;

			// Token: 0x0400FA7F RID: 64127
			[Token(Token = "0x400FA7F")]
			[FieldOffset(Offset = "0x271")]
			public bool webViewPromptFaulty;

			// Token: 0x0400FA80 RID: 64128
			[Token(Token = "0x400FA80")]
			[FieldOffset(Offset = "0x272")]
			public bool webViewFallbackToBrowser;

			// Token: 0x0400FA81 RID: 64129
			[Token(Token = "0x400FA81")]
			[FieldOffset(Offset = "0x273")]
			public bool webViewFalseFaulty;

			// Token: 0x0400FA82 RID: 64130
			[Token(Token = "0x400FA82")]
			[FieldOffset(Offset = "0x274")]
			public bool webViewDeferredDisplay;

			// Token: 0x0400FA83 RID: 64131
			[Token(Token = "0x400FA83")]
			[FieldOffset(Offset = "0x278")]
			public float webViewLoadingProgressAnimationDuration;

			// Token: 0x0400FA84 RID: 64132
			[Token(Token = "0x400FA84")]
			[FieldOffset(Offset = "0x27C")]
			public float webViewPromptReloadDuration;

			// Token: 0x0400FA85 RID: 64133
			[Token(Token = "0x400FA85")]
			[FieldOffset(Offset = "0x280")]
			public string webViewJavaScriptName;

			// Token: 0x0400FA86 RID: 64134
			[Token(Token = "0x400FA86")]
			[FieldOffset(Offset = "0x288")]
			public bool webViewRunJavaScript;

			// Token: 0x0400FA87 RID: 64135
			[Token(Token = "0x400FA87")]
			[FieldOffset(Offset = "0x290")]
			public string webViewJavaScriptEcho;

			// Token: 0x0400FA88 RID: 64136
			[Token(Token = "0x400FA88")]
			[FieldOffset(Offset = "0x298")]
			public bool webViewLogConsoleMessages;

			// Token: 0x0400FA89 RID: 64137
			[Token(Token = "0x400FA89")]
			[FieldOffset(Offset = "0x299")]
			public bool webViewLog;

			// Token: 0x0400FA8A RID: 64138
			[Token(Token = "0x400FA8A")]
			[FieldOffset(Offset = "0x2A0")]
			public string webViewLogUrls;

			// Token: 0x0400FA8B RID: 64139
			[Token(Token = "0x400FA8B")]
			[FieldOffset(Offset = "0x2A8")]
			public string googleClientId;

			// Token: 0x0400FA8C RID: 64140
			[Token(Token = "0x400FA8C")]
			[FieldOffset(Offset = "0x2B0")]
			public int veteranReminderDays;

			// Token: 0x0400FA8D RID: 64141
			[Token(Token = "0x400FA8D")]
			[FieldOffset(Offset = "0x2B4")]
			public bool UMALogErrors;

			// Token: 0x0400FA8E RID: 64142
			[Token(Token = "0x400FA8E")]
			[FieldOffset(Offset = "0x2B5")]
			public bool UMALogDetails;

			// Token: 0x0400FA8F RID: 64143
			[Token(Token = "0x400FA8F")]
			[FieldOffset(Offset = "0x2B6")]
			public bool UMALogDetails3P;

			// Token: 0x0400FA90 RID: 64144
			[Token(Token = "0x400FA90")]
			[FieldOffset(Offset = "0x2B7")]
			public bool UMALogTimes;

			// Token: 0x0400FA91 RID: 64145
			[Token(Token = "0x400FA91")]
			[FieldOffset(Offset = "0x2B8")]
			public bool inAppReviewOverride;

			// Token: 0x0400FA92 RID: 64146
			[Token(Token = "0x400FA92")]
			[FieldOffset(Offset = "0x2B9")]
			public bool inAppReviewEnabled;

			// Token: 0x0400FA93 RID: 64147
			[Token(Token = "0x400FA93")]
			[FieldOffset(Offset = "0x2C0")]
			public string test_hook;
		}
	}
}
