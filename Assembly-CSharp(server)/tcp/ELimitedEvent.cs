using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	[ProtoContract]
	public class ELimitedEvent
	{
		// Token: 0x06001EBC RID: 7868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x24A2D50", Offset = "0x24A2D50", VA = "0x7BBCCA2D50")]
		public ELimitedEvent()
		{
		}

		// Token: 0x020004C1 RID: 1217
		[Token(Token = "0x20004C1")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040016A4 RID: 5796
			[Token(Token = "0x40016A4")]
			Proto_NONE,
			// Token: 0x040016A5 RID: 5797
			[Token(Token = "0x40016A5")]
			Proto_RAMPAGE_POINTS_UPDATE_NTF,
			// Token: 0x040016A6 RID: 5798
			[Token(Token = "0x40016A6")]
			Proto_ADD_MONEY_HEIST_HELP_NTF,
			// Token: 0x040016A7 RID: 5799
			[Token(Token = "0x40016A7")]
			Proto_SPEED_FROM_TASK_CHANGE_NTF,
			// Token: 0x040016A8 RID: 5800
			[Token(Token = "0x40016A8")]
			Proto_GOLIATH_AFK_GROUP_UPDATE_NTF,
			// Token: 0x040016A9 RID: 5801
			[Token(Token = "0x40016A9")]
			Proto_SUPERCAR_RECEIVE_HELP_NTF = 7
		}

		// Token: 0x020004C2 RID: 1218
		[Token(Token = "0x20004C2")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040016AB RID: 5803
			[Token(Token = "0x40016AB")]
			ErrCode_SUSS
		}
	}
}
