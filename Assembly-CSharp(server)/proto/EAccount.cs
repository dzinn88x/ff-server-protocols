using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	[ProtoContract]
	public class EAccount
	{
		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x21B97B0", Offset = "0x21B97B0", VA = "0x7BBC9B97B0")]
		public EAccount()
		{
		}

		// Token: 0x02000573 RID: 1395
		[Token(Token = "0x2000573")]
		[ProtoContract]
		public enum PlatformType
		{
			// Token: 0x04001B35 RID: 6965
			[Token(Token = "0x4001B35")]
			PlatformType_VISITOR,
			// Token: 0x04001B36 RID: 6966
			[Token(Token = "0x4001B36")]
			PlatformType_GAS,
			// Token: 0x04001B37 RID: 6967
			[Token(Token = "0x4001B37")]
			PlatformType_BEETALK,
			// Token: 0x04001B38 RID: 6968
			[Token(Token = "0x4001B38")]
			PlatformType_GAFACEBOOK,
			// Token: 0x04001B39 RID: 6969
			[Token(Token = "0x4001B39")]
			PlatformType_GAGUEST,
			// Token: 0x04001B3A RID: 6970
			[Token(Token = "0x4001B3A")]
			PlatformType_VK,
			// Token: 0x04001B3B RID: 6971
			[Token(Token = "0x4001B3B")]
			PlatformType_FACEBOOK,
			// Token: 0x04001B3C RID: 6972
			[Token(Token = "0x4001B3C")]
			PlatformType_HUAWEI,
			// Token: 0x04001B3D RID: 6973
			[Token(Token = "0x4001B3D")]
			PlatformType_GOOGLE,
			// Token: 0x04001B3E RID: 6974
			[Token(Token = "0x4001B3E")]
			PlatformType_WECHAT,
			// Token: 0x04001B3F RID: 6975
			[Token(Token = "0x4001B3F")]
			PlatformType_APPLE,
			// Token: 0x04001B40 RID: 6976
			[Token(Token = "0x4001B40")]
			PlatformType_TWITTER,
			// Token: 0x04001B41 RID: 6977
			[Token(Token = "0x4001B41")]
			PlatformType_DELETE = 100,
			// Token: 0x04001B42 RID: 6978
			[Token(Token = "0x4001B42")]
			PlatformType_CHANGE_ACCOUNT
		}

		// Token: 0x02000574 RID: 1396
		[Token(Token = "0x2000574")]
		[ProtoContract]
		public enum BlacklistOpType
		{
			// Token: 0x04001B44 RID: 6980
			[Token(Token = "0x4001B44")]
			BlacklistOpType_NONE,
			// Token: 0x04001B45 RID: 6981
			[Token(Token = "0x4001B45")]
			BlacklistOpType_BAN_ACCOUNT,
			// Token: 0x04001B46 RID: 6982
			[Token(Token = "0x4001B46")]
			BlacklistOpType_BAN_DEVICE,
			// Token: 0x04001B47 RID: 6983
			[Token(Token = "0x4001B47")]
			BlacklistOpType_UNBAN_ACCOUNT,
			// Token: 0x04001B48 RID: 6984
			[Token(Token = "0x4001B48")]
			BlacklistOpType_UNBAN_DEVICE
		}

		// Token: 0x02000575 RID: 1397
		[Token(Token = "0x2000575")]
		[ProtoContract]
		public enum Role
		{
			// Token: 0x04001B4A RID: 6986
			[Token(Token = "0x4001B4A")]
			Role_NONE,
			// Token: 0x04001B4B RID: 6987
			[Token(Token = "0x4001B4B")]
			Role_GM,
			// Token: 0x04001B4C RID: 6988
			[Token(Token = "0x4001B4C")]
			Role_CONTESTANT,
			// Token: 0x04001B4D RID: 6989
			[Token(Token = "0x4001B4D")]
			Role_STREAMER = 4,
			// Token: 0x04001B4E RID: 6990
			[Token(Token = "0x4001B4E")]
			Role_REPLAY = 8,
			// Token: 0x04001B4F RID: 6991
			[Token(Token = "0x4001B4F")]
			Role_ROOMMASTER = 16,
			// Token: 0x04001B50 RID: 6992
			[Token(Token = "0x4001B50")]
			Role_ROOMPARTNER = 32,
			// Token: 0x04001B51 RID: 6993
			[Token(Token = "0x4001B51")]
			Role_PERSONAGE = 64,
			// Token: 0x04001B52 RID: 6994
			[Token(Token = "0x4001B52")]
			Role_COMPANY = 128,
			// Token: 0x04001B53 RID: 6995
			[Token(Token = "0x4001B53")]
			Role_PREPARATION = 256
		}

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		[ProtoContract]
		public enum BanReason
		{
			// Token: 0x04001B55 RID: 6997
			[Token(Token = "0x4001B55")]
			BanReason_UNKNOWN,
			// Token: 0x04001B56 RID: 6998
			[Token(Token = "0x4001B56")]
			BanReason_IN_GAME_AUTO,
			// Token: 0x04001B57 RID: 6999
			[Token(Token = "0x4001B57")]
			BanReason_REFUND,
			// Token: 0x04001B58 RID: 7000
			[Token(Token = "0x4001B58")]
			BanReason_OTHERS
		}

		// Token: 0x02000577 RID: 1399
		[Token(Token = "0x2000577")]
		[ProtoContract]
		public enum NewsType
		{
			// Token: 0x04001B5A RID: 7002
			[Token(Token = "0x4001B5A")]
			NewsType_NONE,
			// Token: 0x04001B5B RID: 7003
			[Token(Token = "0x4001B5B")]
			NewsType_RANK,
			// Token: 0x04001B5C RID: 7004
			[Token(Token = "0x4001B5C")]
			NewsType_LOTTERY,
			// Token: 0x04001B5D RID: 7005
			[Token(Token = "0x4001B5D")]
			NewsType_PURCHASE,
			// Token: 0x04001B5E RID: 7006
			[Token(Token = "0x4001B5E")]
			NewsType_TREASUREBOX,
			// Token: 0x04001B5F RID: 7007
			[Token(Token = "0x4001B5F")]
			NewsType_ELITEPASS,
			// Token: 0x04001B60 RID: 7008
			[Token(Token = "0x4001B60")]
			NewsType_EXCHANGESTORE,
			// Token: 0x04001B61 RID: 7009
			[Token(Token = "0x4001B61")]
			NewsType_BUNDLE,
			// Token: 0x04001B62 RID: 7010
			[Token(Token = "0x4001B62")]
			NewsType_LOTTERYSPECIALEXCHANGE,
			// Token: 0x04001B63 RID: 7011
			[Token(Token = "0x4001B63")]
			NewsType_OTHERS
		}

		// Token: 0x02000578 RID: 1400
		[Token(Token = "0x2000578")]
		[ProtoContract]
		public enum WarmGameType
		{
			// Token: 0x04001B65 RID: 7013
			[Token(Token = "0x4001B65")]
			WarmGameType_NONE,
			// Token: 0x04001B66 RID: 7014
			[Token(Token = "0x4001B66")]
			WarmGameType_FIRSTRECHARGE,
			// Token: 0x04001B67 RID: 7015
			[Token(Token = "0x4001B67")]
			WarmGameType_BOTPOINT
		}

		// Token: 0x02000579 RID: 1401
		[Token(Token = "0x2000579")]
		[ProtoContract]
		public enum DownloadType
		{
			// Token: 0x04001B69 RID: 7017
			[Token(Token = "0x4001B69")]
			DownloadType_NONE,
			// Token: 0x04001B6A RID: 7018
			[Token(Token = "0x4001B6A")]
			DownloadType_INSTANTGAME,
			// Token: 0x04001B6B RID: 7019
			[Token(Token = "0x4001B6B")]
			DownloadType_IOS,
			// Token: 0x04001B6C RID: 7020
			[Token(Token = "0x4001B6C")]
			DownloadType_HUAWEI,
			// Token: 0x04001B6D RID: 7021
			[Token(Token = "0x4001B6D")]
			DownloadType_XIAOMI,
			// Token: 0x04001B6E RID: 7022
			[Token(Token = "0x4001B6E")]
			DownloadType_SAMSUNG
		}

		// Token: 0x0200057A RID: 1402
		[Token(Token = "0x200057A")]
		[ProtoContract]
		public enum LoginType
		{
			// Token: 0x04001B70 RID: 7024
			[Token(Token = "0x4001B70")]
			LoginType_NORMAL,
			// Token: 0x04001B71 RID: 7025
			[Token(Token = "0x4001B71")]
			LoginType_DEBUG_ACCOUNT_ID,
			// Token: 0x04001B72 RID: 7026
			[Token(Token = "0x4001B72")]
			LoginType_DEBUG_NICKNAME
		}

		// Token: 0x0200057B RID: 1403
		[Token(Token = "0x200057B")]
		[ProtoContract]
		public enum CBSwitchStatus
		{
			// Token: 0x04001B74 RID: 7028
			[Token(Token = "0x4001B74")]
			CBSwitchStatus_NONE,
			// Token: 0x04001B75 RID: 7029
			[Token(Token = "0x4001B75")]
			CBSwitchStatus_CHECK_KEY,
			// Token: 0x04001B76 RID: 7030
			[Token(Token = "0x4001B76")]
			CBSwitchStatus_DONT_CHECK_KEY,
			// Token: 0x04001B77 RID: 7031
			[Token(Token = "0x4001B77")]
			CBSwitchStatus_DISABLE_MAX_LOGIN
		}

		// Token: 0x0200057C RID: 1404
		[Token(Token = "0x200057C")]
		[ProtoContract]
		public enum TrialSwitchStatus
		{
			// Token: 0x04001B79 RID: 7033
			[Token(Token = "0x4001B79")]
			TrialSwitchStatus_NONE,
			// Token: 0x04001B7A RID: 7034
			[Token(Token = "0x4001B7A")]
			TrialSwitchStatus_CHECK_KEY,
			// Token: 0x04001B7B RID: 7035
			[Token(Token = "0x4001B7B")]
			TrialSwitchStatus_DONT_CHECK_KEY
		}

		// Token: 0x0200057D RID: 1405
		[Token(Token = "0x200057D")]
		[ProtoContract]
		public enum NewbieChoice
		{
			// Token: 0x04001B7D RID: 7037
			[Token(Token = "0x4001B7D")]
			NewbieChoice_NONE,
			// Token: 0x04001B7E RID: 7038
			[Token(Token = "0x4001B7E")]
			NewbieChoice_NEW_PLAYER,
			// Token: 0x04001B7F RID: 7039
			[Token(Token = "0x4001B7F")]
			NewbieChoice_FPS_PLAYER,
			// Token: 0x04001B80 RID: 7040
			[Token(Token = "0x4001B80")]
			NewbieChoice_VETERAN,
			// Token: 0x04001B81 RID: 7041
			[Token(Token = "0x4001B81")]
			NewbieChoice_NEEDMOREINFO = 99
		}
	}
}
