using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	[ProtoContract]
	public class ENotification
	{
		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x21B9888", Offset = "0x21B9888", VA = "0x7BBC9B9888")]
		public ENotification()
		{
		}

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		[ProtoContract]
		public enum ChangeMatchInfoEvent
		{
			// Token: 0x04001D8A RID: 7562
			[Token(Token = "0x4001D8A")]
			ChangeMatchInfoEvent_NONE,
			// Token: 0x04001D8B RID: 7563
			[Token(Token = "0x4001D8B")]
			ChangeMatchInfoEvent_GROUPSTART,
			// Token: 0x04001D8C RID: 7564
			[Token(Token = "0x4001D8C")]
			ChangeMatchInfoEvent_CREATEROOM,
			// Token: 0x04001D8D RID: 7565
			[Token(Token = "0x4001D8D")]
			ChangeMatchInfoEvent_JOINROOM,
			// Token: 0x04001D8E RID: 7566
			[Token(Token = "0x4001D8E")]
			ChangeMatchInfoEvent_SPECTATEROOM,
			// Token: 0x04001D8F RID: 7567
			[Token(Token = "0x4001D8F")]
			ChangeMatchInfoEvent_JOINGROUPBYCODE,
			// Token: 0x04001D90 RID: 7568
			[Token(Token = "0x4001D90")]
			ChangeMatchInfoEvent_GROUPJOIN,
			// Token: 0x04001D91 RID: 7569
			[Token(Token = "0x4001D91")]
			ChangeMatchInfoEvent_GROUPLEAVE,
			// Token: 0x04001D92 RID: 7570
			[Token(Token = "0x4001D92")]
			ChangeMatchInfoEvent_GROUPINVITE,
			// Token: 0x04001D93 RID: 7571
			[Token(Token = "0x4001D93")]
			ChangeMatchInfoEvent_GROUPCREATE,
			// Token: 0x04001D94 RID: 7572
			[Token(Token = "0x4001D94")]
			ChangeMatchInfoEvent_CREATEBATCHROOM
		}

		// Token: 0x020005D4 RID: 1492
		[Token(Token = "0x20005D4")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001D96 RID: 7574
			[Token(Token = "0x4001D96")]
			ErrCode_SUSS,
			// Token: 0x04001D97 RID: 7575
			[Token(Token = "0x4001D97")]
			ErrCode_GROUPSTATUS
		}
	}
}
