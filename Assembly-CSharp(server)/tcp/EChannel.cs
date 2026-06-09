using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	[ProtoContract]
	public class EChannel
	{
		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x24A2D00", Offset = "0x24A2D00", VA = "0x7BBCCA2D00")]
		public EChannel()
		{
		}

		// Token: 0x0200045F RID: 1119
		[Token(Token = "0x200045F")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040014A9 RID: 5289
			[Token(Token = "0x40014A9")]
			Proto_NONE,
			// Token: 0x040014AA RID: 5290
			[Token(Token = "0x40014AA")]
			Proto_TEXT_MSG,
			// Token: 0x040014AB RID: 5291
			[Token(Token = "0x40014AB")]
			Proto_TEXT_MSG_NTF,
			// Token: 0x040014AC RID: 5292
			[Token(Token = "0x40014AC")]
			Proto_JOIN_CHANNEL,
			// Token: 0x040014AD RID: 5293
			[Token(Token = "0x40014AD")]
			Proto_LEAVE_CHANNEL,
			// Token: 0x040014AE RID: 5294
			[Token(Token = "0x40014AE")]
			Proto_JOIN_WORLD_CHAN_NTF
		}

		// Token: 0x02000460 RID: 1120
		[Token(Token = "0x2000460")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040014B0 RID: 5296
			[Token(Token = "0x40014B0")]
			ErrCode_SUSS,
			// Token: 0x040014B1 RID: 5297
			[Token(Token = "0x40014B1")]
			ErrCode_INVALIDCHANNELTYPE,
			// Token: 0x040014B2 RID: 5298
			[Token(Token = "0x40014B2")]
			ErrCode_ALREADYINCHANNEL,
			// Token: 0x040014B3 RID: 5299
			[Token(Token = "0x40014B3")]
			ErrCode_CREATEPLAYERFAIL,
			// Token: 0x040014B4 RID: 5300
			[Token(Token = "0x40014B4")]
			ErrCode_CREATECHANNELFAIL,
			// Token: 0x040014B5 RID: 5301
			[Token(Token = "0x40014B5")]
			ErrCode_MAXMEMBERLIMIT,
			// Token: 0x040014B6 RID: 5302
			[Token(Token = "0x40014B6")]
			ErrCode_NOCHANNEL,
			// Token: 0x040014B7 RID: 5303
			[Token(Token = "0x40014B7")]
			ErrCode_NOTINCHANNEL,
			// Token: 0x040014B8 RID: 5304
			[Token(Token = "0x40014B8")]
			ErrCode_REACHMSGLIMIT,
			// Token: 0x040014B9 RID: 5305
			[Token(Token = "0x40014B9")]
			ErrCode_WORLDCHANNELDISABLED,
			// Token: 0x040014BA RID: 5306
			[Token(Token = "0x40014BA")]
			ErrCode_CUSTOMMSGDISABLED,
			// Token: 0x040014BB RID: 5307
			[Token(Token = "0x40014BB")]
			ErrCode_RESERVATIONREACHLIMIT
		}

		// Token: 0x02000461 RID: 1121
		[Token(Token = "0x2000461")]
		[ProtoContract]
		public enum ChannelType
		{
			// Token: 0x040014BD RID: 5309
			[Token(Token = "0x40014BD")]
			ChannelType_GROUP,
			// Token: 0x040014BE RID: 5310
			[Token(Token = "0x40014BE")]
			ChannelType_CLAN,
			// Token: 0x040014BF RID: 5311
			[Token(Token = "0x40014BF")]
			ChannelType_WHISPER,
			// Token: 0x040014C0 RID: 5312
			[Token(Token = "0x40014C0")]
			ChannelType_ROOM,
			// Token: 0x040014C1 RID: 5313
			[Token(Token = "0x40014C1")]
			ChannelType_CHAMPIONSHIPTEAM,
			// Token: 0x040014C2 RID: 5314
			[Token(Token = "0x40014C2")]
			ChannelType_WORLD,
			// Token: 0x040014C3 RID: 5315
			[Token(Token = "0x40014C3")]
			ChannelType_GROUP_FAST
		}

		// Token: 0x02000462 RID: 1122
		[Token(Token = "0x2000462")]
		[ProtoContract]
		public enum MsgType
		{
			// Token: 0x040014C5 RID: 5317
			[Token(Token = "0x40014C5")]
			MsgType_DEFAULT,
			// Token: 0x040014C6 RID: 5318
			[Token(Token = "0x40014C6")]
			MsgType_FAST,
			// Token: 0x040014C7 RID: 5319
			[Token(Token = "0x40014C7")]
			MsgType_STICKY_SPEAKER,
			// Token: 0x040014C8 RID: 5320
			[Token(Token = "0x40014C8")]
			MsgType_RESERVATION
		}

		// Token: 0x02000463 RID: 1123
		[Token(Token = "0x2000463")]
		[ProtoContract]
		public enum MsgLimitType
		{
			// Token: 0x040014CA RID: 5322
			[Token(Token = "0x40014CA")]
			MsgLimitType_DEFAULT,
			// Token: 0x040014CB RID: 5323
			[Token(Token = "0x40014CB")]
			MsgLimitType_FAST
		}
	}
}
