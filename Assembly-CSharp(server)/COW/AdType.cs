using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001DA6 RID: 7590
	[Token(Token = "0x2001DA6")]
	public enum AdType
	{
		// Token: 0x0400ABA1 RID: 43937
		[Token(Token = "0x400ABA1")]
		AdType_NONE,
		// Token: 0x0400ABA2 RID: 43938
		[Token(Token = "0x400ABA2")]
		AdType_MALL,
		// Token: 0x0400ABA3 RID: 43939
		[Token(Token = "0x400ABA3")]
		AdType_TOKEN,
		// Token: 0x0400ABA4 RID: 43940
		[Token(Token = "0x400ABA4")]
		AdType_GACHA,
		// Token: 0x0400ABA5 RID: 43941
		[Token(Token = "0x400ABA5")]
		AdType_EP,
		// Token: 0x0400ABA6 RID: 43942
		[Token(Token = "0x400ABA6")]
		AdType_MALLBG,
		// Token: 0x0400ABA7 RID: 43943
		[Token(Token = "0x400ABA7")]
		AdType_GIFTBG,
		// Token: 0x0400ABA8 RID: 43944
		[Token(Token = "0x400ABA8")]
		AdType_REBATE_CARD,
		// Token: 0x0400ABA9 RID: 43945
		[Token(Token = "0x400ABA9")]
		AdType_PAYMENT_WINDOW_UNPAID,
		// Token: 0x0400ABAA RID: 43946
		[Token(Token = "0x400ABAA")]
		AdType_PAYMENT_WINDOW_PAID,
		// Token: 0x0400ABAB RID: 43947
		[Token(Token = "0x400ABAB")]
		AdType_LOBBY_ACTIVITY,
		// Token: 0x0400ABAC RID: 43948
		[Token(Token = "0x400ABAC")]
		AdType_LOBBY_ADS,
		// Token: 0x0400ABAD RID: 43949
		[Token(Token = "0x400ABAD")]
		AdType_MALL_WEAPON_BG,
		// Token: 0x0400ABAE RID: 43950
		[Token(Token = "0x400ABAE")]
		AdType_LOADING,
		// Token: 0x0400ABAF RID: 43951
		[Token(Token = "0x400ABAF")]
		AdType_GACHA_ACTIVITY_BG1,
		// Token: 0x0400ABB0 RID: 43952
		[Token(Token = "0x400ABB0")]
		AdType_GACHA_ACTIVITY_BG2,
		// Token: 0x0400ABB1 RID: 43953
		[Token(Token = "0x400ABB1")]
		AdType_FLIPCARD_PRIZEHINT,
		// Token: 0x0400ABB2 RID: 43954
		[Token(Token = "0x400ABB2")]
		AdType_ACTIVITY_MAX,
		// Token: 0x0400ABB3 RID: 43955
		[Token(Token = "0x400ABB3")]
		AdType_PreLogin,
		// Token: 0x0400ABB4 RID: 43956
		[Token(Token = "0x400ABB4")]
		AdType_ACTIVITY_INTRODUCTION,
		// Token: 0x0400ABB5 RID: 43957
		[Token(Token = "0x400ABB5")]
		AdType_GACHA_SPLASHBANNER,
		// Token: 0x0400ABB6 RID: 43958
		[Token(Token = "0x400ABB6")]
		AdType_FULLSCREENCG,
		// Token: 0x0400ABB7 RID: 43959
		[Token(Token = "0x400ABB7")]
		AdType_FORGEBG,
		// Token: 0x0400ABB8 RID: 43960
		[Token(Token = "0x400ABB8")]
		AdType_PAYMENT_BONUS,
		// Token: 0x0400ABB9 RID: 43961
		[Token(Token = "0x400ABB9")]
		AdType_PAYMENT_SHOP_HW,
		// Token: 0x0400ABBA RID: 43962
		[Token(Token = "0x400ABBA")]
		AdType_INSTALLMENT_TUTORIAL,
		// Token: 0x0400ABBB RID: 43963
		[Token(Token = "0x400ABBB")]
		AdType_EP_MAINBG,
		// Token: 0x0400ABBC RID: 43964
		[Token(Token = "0x400ABBC")]
		AdType_ACTIVITY_MAINBG,
		// Token: 0x0400ABBD RID: 43965
		[Token(Token = "0x400ABBD")]
		AdType_AVATAR_SPLASHBANNER = 29,
		// Token: 0x0400ABBE RID: 43966
		[Token(Token = "0x400ABBE")]
		AdType_Second_Charge,
		// Token: 0x0400ABBF RID: 43967
		[Token(Token = "0x400ABBF")]
		AdType_ACTIVITY_OVERVIEW,
		// Token: 0x0400ABC0 RID: 43968
		[Token(Token = "0x400ABC0")]
		AdType_ACTIVITY_OVERVIEW_NAVIGATION,
		// Token: 0x0400ABC1 RID: 43969
		[Token(Token = "0x400ABC1")]
		AdType_CHAMPIONSHIP_BG = 34,
		// Token: 0x0400ABC2 RID: 43970
		[Token(Token = "0x400ABC2")]
		AdType_VETERAN_BUNDLE_BG,
		// Token: 0x0400ABC3 RID: 43971
		[Token(Token = "0x400ABC3")]
		AdType_VETERAN_SIGNIN_BG,
		// Token: 0x0400ABC4 RID: 43972
		[Token(Token = "0x400ABC4")]
		AdType_INTEGRATE_OVERVIEW,
		// Token: 0x0400ABC5 RID: 43973
		[Token(Token = "0x400ABC5")]
		AdType_NEWPLAYER_LEVELUP,
		// Token: 0x0400ABC6 RID: 43974
		[Token(Token = "0x400ABC6")]
		AdType_NEWPLAYER_SIGNIN,
		// Token: 0x0400ABC7 RID: 43975
		[Token(Token = "0x400ABC7")]
		AdType_PAYMENT_BUTTON,
		// Token: 0x0400ABC8 RID: 43976
		[Token(Token = "0x400ABC8")]
		AdType_PAYMENT_FIRSTTIME_WINDOW = 46,
		// Token: 0x0400ABC9 RID: 43977
		[Token(Token = "0x400ABC9")]
		AdType_PAYMENT_SHOP_THIRD_PARTY,
		// Token: 0x0400ABCA RID: 43978
		[Token(Token = "0x400ABCA")]
		AdType_EASTER_EXCHANGE_BG,
		// Token: 0x0400ABCB RID: 43979
		[Token(Token = "0x400ABCB")]
		AdType_ACTIVITY_DEFAULT_BG,
		// Token: 0x0400ABCC RID: 43980
		[Token(Token = "0x400ABCC")]
		AdType_GACHA_CDN_TITLE,
		// Token: 0x0400ABCD RID: 43981
		[Token(Token = "0x400ABCD")]
		AdType_GROWTH_FUND_AD,
		// Token: 0x0400ABCE RID: 43982
		[Token(Token = "0x400ABCE")]
		AdType_MONEY_HEIST,
		// Token: 0x0400ABCF RID: 43983
		[Token(Token = "0x400ABCF")]
		AdType_FULL_SCREEN_PREVIEW,
		// Token: 0x0400ABD0 RID: 43984
		[Token(Token = "0x400ABD0")]
		AdType_WAITINGROOM_3YEAR,
		// Token: 0x0400ABD1 RID: 43985
		[Token(Token = "0x400ABD1")]
		AdType_THREEYEARFESTIVAL_UNLIMIT_JACKPOT,
		// Token: 0x0400ABD2 RID: 43986
		[Token(Token = "0x400ABD2")]
		AdType_THREEYEARFESTIVAL_LIMIT_JACKPOT,
		// Token: 0x0400ABD3 RID: 43987
		[Token(Token = "0x400ABD3")]
		AdType_GACHA_SHOW_BG,
		// Token: 0x0400ABD4 RID: 43988
		[Token(Token = "0x400ABD4")]
		AdType_Activity_ScrollView,
		// Token: 0x0400ABD5 RID: 43989
		[Token(Token = "0x400ABD5")]
		AdType_LEGEND_CLOTH_BG,
		// Token: 0x0400ABD6 RID: 43990
		[Token(Token = "0x400ABD6")]
		AdType_IAP_BUNDLE,
		// Token: 0x0400ABD7 RID: 43991
		[Token(Token = "0x400ABD7")]
		AdType_SPLASH_LIVE
	}
}
