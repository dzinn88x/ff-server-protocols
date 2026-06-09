using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	[ProtoContract]
	public class EMatchmaking
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x24A2D78", Offset = "0x24A2D78", VA = "0x7BBCCA2D78")]
		public EMatchmaking()
		{
		}

		// Token: 0x020004D8 RID: 1240
		[Token(Token = "0x20004D8")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040016D5 RID: 5845
			[Token(Token = "0x40016D5")]
			Proto_NONE,
			// Token: 0x040016D6 RID: 5846
			[Token(Token = "0x40016D6")]
			Proto_START,
			// Token: 0x040016D7 RID: 5847
			[Token(Token = "0x40016D7")]
			Proto_CANCEL,
			// Token: 0x040016D8 RID: 5848
			[Token(Token = "0x40016D8")]
			Proto_GROUPSTART,
			// Token: 0x040016D9 RID: 5849
			[Token(Token = "0x40016D9")]
			Proto_GROUPCANCEL,
			// Token: 0x040016DA RID: 5850
			[Token(Token = "0x40016DA")]
			Proto_MATCHMAKINGSUSS_NTF,
			// Token: 0x040016DB RID: 5851
			[Token(Token = "0x40016DB")]
			Proto_DROPMATCH,
			// Token: 0x040016DC RID: 5852
			[Token(Token = "0x40016DC")]
			Proto_GAMEOPENINGINFO,
			// Token: 0x040016DD RID: 5853
			[Token(Token = "0x40016DD")]
			Proto_CHECKINGAMEPLAYER,
			// Token: 0x040016DE RID: 5854
			[Token(Token = "0x40016DE")]
			Proto_CLEARINGAMEPLAYER,
			// Token: 0x040016DF RID: 5855
			[Token(Token = "0x40016DF")]
			Proto_ANTIADDICTION_NFT,
			// Token: 0x040016E0 RID: 5856
			[Token(Token = "0x40016E0")]
			Proto_START_NTF
		}

		// Token: 0x020004D9 RID: 1241
		[Token(Token = "0x20004D9")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040016E2 RID: 5858
			[Token(Token = "0x40016E2")]
			ErrCode_SUSS,
			// Token: 0x040016E3 RID: 5859
			[Token(Token = "0x40016E3")]
			ErrCode_ALREADYINMATCHMAKING,
			// Token: 0x040016E4 RID: 5860
			[Token(Token = "0x40016E4")]
			ErrCode_CREATEPLAYERFAIL,
			// Token: 0x040016E5 RID: 5861
			[Token(Token = "0x40016E5")]
			ErrCode_JOINSINGLEPOOLFAIL,
			// Token: 0x040016E6 RID: 5862
			[Token(Token = "0x40016E6")]
			ErrCode_JOINMULTIPOOLFAIL,
			// Token: 0x040016E7 RID: 5863
			[Token(Token = "0x40016E7")]
			ErrCode_NOGAMESERVERAVAILABLE,
			// Token: 0x040016E8 RID: 5864
			[Token(Token = "0x40016E8")]
			ErrCode_INITMATCHFAIL,
			// Token: 0x040016E9 RID: 5865
			[Token(Token = "0x40016E9")]
			ErrCode_LOGINGAMESERVERTIMEOUT,
			// Token: 0x040016EA RID: 5866
			[Token(Token = "0x40016EA")]
			ErrCode_MMTIMEOUT,
			// Token: 0x040016EB RID: 5867
			[Token(Token = "0x40016EB")]
			ErrCode_NOSUCHPOOL,
			// Token: 0x040016EC RID: 5868
			[Token(Token = "0x40016EC")]
			ErrCode_MAPNOTOPEN,
			// Token: 0x040016ED RID: 5869
			[Token(Token = "0x40016ED")]
			ErrCode_INVALIDRANDOMMAPCONFIG,
			// Token: 0x040016EE RID: 5870
			[Token(Token = "0x40016EE")]
			ErrCode_RANKINGMATCHLEVELLIMIT,
			// Token: 0x040016EF RID: 5871
			[Token(Token = "0x40016EF")]
			ErrCode_NOTQUALIFIEDFORFREEWTA,
			// Token: 0x040016F0 RID: 5872
			[Token(Token = "0x40016F0")]
			ErrCode_INVALIDWTACURRENCYTYPE,
			// Token: 0x040016F1 RID: 5873
			[Token(Token = "0x40016F1")]
			ErrCode_NOTENOUGHMONEYFORWTA,
			// Token: 0x040016F2 RID: 5874
			[Token(Token = "0x40016F2")]
			ErrCode_NEGATIVEGEMS,
			// Token: 0x040016F3 RID: 5875
			[Token(Token = "0x40016F3")]
			ErrCode_ANTIADDICTIONBAN,
			// Token: 0x040016F4 RID: 5876
			[Token(Token = "0x40016F4")]
			ErrCode_NOTQUALIFIEDFORCHAMP,
			// Token: 0x040016F5 RID: 5877
			[Token(Token = "0x40016F5")]
			ErrCode_NOTQUALIFIEDFORTRAIN,
			// Token: 0x040016F6 RID: 5878
			[Token(Token = "0x40016F6")]
			ErrCode_MAPINVALIDFORSOMEMEMBERS,
			// Token: 0x040016F7 RID: 5879
			[Token(Token = "0x40016F7")]
			ErrCode_EMULATORNOTQUALIFIED,
			// Token: 0x040016F8 RID: 5880
			[Token(Token = "0x40016F8")]
			ErrCode_EMULATORRECONNNOTQUALIFIED,
			// Token: 0x040016F9 RID: 5881
			[Token(Token = "0x40016F9")]
			ErrCode_CSRANKINGBANNED,
			// Token: 0x040016FA RID: 5882
			[Token(Token = "0x40016FA")]
			ErrCode_RANKINGMATCHREGISTERTIMELIMIT
		}

		// Token: 0x020004DA RID: 1242
		[Token(Token = "0x20004DA")]
		[ProtoContract]
		public enum PlayerState
		{
			// Token: 0x040016FC RID: 5884
			[Token(Token = "0x40016FC")]
			PlayerState_MATCHMAKING,
			// Token: 0x040016FD RID: 5885
			[Token(Token = "0x40016FD")]
			PlayerState_LOADING,
			// Token: 0x040016FE RID: 5886
			[Token(Token = "0x40016FE")]
			PlayerState_INGAME,
			// Token: 0x040016FF RID: 5887
			[Token(Token = "0x40016FF")]
			PlayerState_INGAME_CAN_RECONNECT
		}

		// Token: 0x020004DB RID: 1243
		[Token(Token = "0x20004DB")]
		[ProtoContract]
		public enum LevelVisualStyle
		{
			// Token: 0x04001701 RID: 5889
			[Token(Token = "0x4001701")]
			LevelVisualStyle_NORMAL,
			// Token: 0x04001702 RID: 5890
			[Token(Token = "0x4001702")]
			LevelVisualStyle_NIGHT,
			// Token: 0x04001703 RID: 5891
			[Token(Token = "0x4001703")]
			LevelVisualStyle_SNOW
		}
	}
}
