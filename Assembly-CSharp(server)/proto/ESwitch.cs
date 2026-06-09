using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005BA RID: 1466
	[Token(Token = "0x20005BA")]
	[ProtoContract]
	public class ESwitch
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x21B9B64", Offset = "0x21B9B64", VA = "0x7BBC9B9B64")]
		public ESwitch()
		{
		}

		// Token: 0x020005BB RID: 1467
		[Token(Token = "0x20005BB")]
		[ProtoContract]
		public enum SwitchFunc
		{
			// Token: 0x04001D07 RID: 7431
			[Token(Token = "0x4001D07")]
			SwitchFunc_NONE,
			// Token: 0x04001D08 RID: 7432
			[Token(Token = "0x4001D08")]
			SwitchFunc_LOTTERY_PR,
			// Token: 0x04001D09 RID: 7433
			[Token(Token = "0x4001D09")]
			SwitchFunc_TREASURE_BOX_PR,
			// Token: 0x04001D0A RID: 7434
			[Token(Token = "0x4001D0A")]
			SwitchFunc_SPECIAL_STORE_ICON,
			// Token: 0x04001D0B RID: 7435
			[Token(Token = "0x4001D0B")]
			SwitchFunc_GIFT_STORE_IOS,
			// Token: 0x04001D0C RID: 7436
			[Token(Token = "0x4001D0C")]
			SwitchFunc_EXCHANGE_STORE_IOS,
			// Token: 0x04001D0D RID: 7437
			[Token(Token = "0x4001D0D")]
			SwitchFunc_LEVEL_LIMITED_FOR_SPLASH_BANNER,
			// Token: 0x04001D0E RID: 7438
			[Token(Token = "0x4001D0E")]
			SwitchFunc_AD_REWARDED_VIDEO_ENTRANCE,
			// Token: 0x04001D0F RID: 7439
			[Token(Token = "0x4001D0F")]
			SwitchFunc_PRELOAD_REWARDED_VIDEO_UNDER_WIFI,
			// Token: 0x04001D10 RID: 7440
			[Token(Token = "0x4001D10")]
			SwitchFunc_FINISHED_TOPUP_ICON_SHOW = 10,
			// Token: 0x04001D11 RID: 7441
			[Token(Token = "0x4001D11")]
			SwitchFunc_TP_TICK,
			// Token: 0x04001D12 RID: 7442
			[Token(Token = "0x4001D12")]
			SwitchFunc_PVE_WEAPON_INFO_SHOW,
			// Token: 0x04001D13 RID: 7443
			[Token(Token = "0x4001D13")]
			SwitchFunc_CATAPULT_USING,
			// Token: 0x04001D14 RID: 7444
			[Token(Token = "0x4001D14")]
			SwitchFunc_LIVE_SHOW,
			// Token: 0x04001D15 RID: 7445
			[Token(Token = "0x4001D15")]
			SwitchFunc_TP_INFO,
			// Token: 0x04001D16 RID: 7446
			[Token(Token = "0x4001D16")]
			SwitchFunc_SP_UNITY,
			// Token: 0x04001D17 RID: 7447
			[Token(Token = "0x4001D17")]
			SwitchFunc_MYSTERY_BONUS = 18,
			// Token: 0x04001D18 RID: 7448
			[Token(Token = "0x4001D18")]
			SwtichFunc_AFTER_MATCH_REWARD_AD = 20,
			// Token: 0x04001D19 RID: 7449
			[Token(Token = "0x4001D19")]
			SwtichFunc_CHAMPIONSHIP_ENTRANCE,
			// Token: 0x04001D1A RID: 7450
			[Token(Token = "0x4001D1A")]
			SwtichFunc_NATIONAL_FLAG,
			// Token: 0x04001D1B RID: 7451
			[Token(Token = "0x4001D1B")]
			SwitchFunc_ACTIVENESS_LEVEL,
			// Token: 0x04001D1C RID: 7452
			[Token(Token = "0x4001D1C")]
			SwitchFunc_SPLASH_BANNER_MAX_NUM = 25,
			// Token: 0x04001D1D RID: 7453
			[Token(Token = "0x4001D1D")]
			SwitchFunc_CHAT_WORLD_CHANNEL,
			// Token: 0x04001D1E RID: 7454
			[Token(Token = "0x4001D1E")]
			SwitchFunc_GROUP_SHOW_LEFT,
			// Token: 0x04001D1F RID: 7455
			[Token(Token = "0x4001D1F")]
			SwitchFunc_XM_ENABLE_PAYMENT_SHOP,
			// Token: 0x04001D20 RID: 7456
			[Token(Token = "0x4001D20")]
			SwitchFunc_XM_PAYMENT_SHOP_FIRST,
			// Token: 0x04001D21 RID: 7457
			[Token(Token = "0x4001D21")]
			SwitchFunc_HW_ENABLE_PAYMENT_SHOP,
			// Token: 0x04001D22 RID: 7458
			[Token(Token = "0x4001D22")]
			SwitchFunc_HW_PAYMENT_SHOP_FIRST,
			// Token: 0x04001D23 RID: 7459
			[Token(Token = "0x4001D23")]
			SwitchFunc_XM_ENABLE_PAYMENT_GP,
			// Token: 0x04001D24 RID: 7460
			[Token(Token = "0x4001D24")]
			SwitchFunc_HW_ENABLE_PAYMENT_HW,
			// Token: 0x04001D25 RID: 7461
			[Token(Token = "0x4001D25")]
			SwitchFunc_CHECK_ADDRESS,
			// Token: 0x04001D26 RID: 7462
			[Token(Token = "0x4001D26")]
			SwitchFunc_SS_ENABLE_PAYMENT_SHOP,
			// Token: 0x04001D27 RID: 7463
			[Token(Token = "0x4001D27")]
			SwitchFunc_SS_PAYMENT_SHOP_FIRST,
			// Token: 0x04001D28 RID: 7464
			[Token(Token = "0x4001D28")]
			SwitchFunc_SS_ENABLE_SS_IAP,
			// Token: 0x04001D29 RID: 7465
			[Token(Token = "0x4001D29")]
			SwitchFunc_OPTIONALDOWNLOAD_AUTORESUME,
			// Token: 0x04001D2A RID: 7466
			[Token(Token = "0x4001D2A")]
			SwitchFunc_TP_DATA,
			// Token: 0x04001D2B RID: 7467
			[Token(Token = "0x4001D2B")]
			SwitchFunc_ENABLE_GENERIC_3RD_PARTY_IAP_EVENT,
			// Token: 0x04001D2C RID: 7468
			[Token(Token = "0x4001D2C")]
			SwitchFunc_ENABLE_GENERIC_3RD_PARTY_IAP_BUNDLE,
			// Token: 0x04001D2D RID: 7469
			[Token(Token = "0x4001D2D")]
			SwitchFunc_CHECK_PLATFORM_MEM_VALUE,
			// Token: 0x04001D2E RID: 7470
			[Token(Token = "0x4001D2E")]
			SwitchFunc_LIVE_WEB_SYSTEM,
			// Token: 0x04001D2F RID: 7471
			[Token(Token = "0x4001D2F")]
			SwitchFunc_LOTTERY_ENTRANCE_HIDE,
			// Token: 0x04001D30 RID: 7472
			[Token(Token = "0x4001D30")]
			SwitchFunc_SHARE_BUTTON_HIDE,
			// Token: 0x04001D31 RID: 7473
			[Token(Token = "0x4001D31")]
			SwitchFunc_SOCIAL_SIGNATURE_HIDE,
			// Token: 0x04001D32 RID: 7474
			[Token(Token = "0x4001D32")]
			SwitchFunc_NEW_TEAM_UI,
			// Token: 0x04001D33 RID: 7475
			[Token(Token = "0x4001D33")]
			SwitchFunc_ESTIMATED_TIME,
			// Token: 0x04001D34 RID: 7476
			[Token(Token = "0x4001D34")]
			SwitchFunc_LOTTERY_AND_EP_BROADCAST,
			// Token: 0x04001D35 RID: 7477
			[Token(Token = "0x4001D35")]
			SwitchFunc_INTIMACY,
			// Token: 0x04001D36 RID: 7478
			[Token(Token = "0x4001D36")]
			SwitchFunc_OPTIONALDOWNLOAD_AUTO_DOWNLOAD,
			// Token: 0x04001D37 RID: 7479
			[Token(Token = "0x4001D37")]
			SwitchFunc_SPLASH_BANNER_INTEGRET_PAGE_ORDER,
			// Token: 0x04001D38 RID: 7480
			[Token(Token = "0x4001D38")]
			SwitchFunc_CUP_PROTOCOL,
			// Token: 0x04001D39 RID: 7481
			[Token(Token = "0x4001D39")]
			SwitchFunc_COMPETITION_ENTRANCE,
			// Token: 0x04001D3A RID: 7482
			[Token(Token = "0x4001D3A")]
			SwitchFunc_CHAT_CAN_REPORT
		}
	}
}
