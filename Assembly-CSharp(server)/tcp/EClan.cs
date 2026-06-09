using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	[ProtoContract]
	public class EClan
	{
		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x24A2D10", Offset = "0x24A2D10", VA = "0x7BBCCA2D10")]
		public EClan()
		{
		}

		// Token: 0x0200046E RID: 1134
		[Token(Token = "0x200046E")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040014F0 RID: 5360
			[Token(Token = "0x40014F0")]
			Proto_NONE,
			// Token: 0x040014F1 RID: 5361
			[Token(Token = "0x40014F1")]
			Proto_REQUEST_JOIN_NTF,
			// Token: 0x040014F2 RID: 5362
			[Token(Token = "0x40014F2")]
			Proto_CONFIRM_ADD_NTF,
			// Token: 0x040014F3 RID: 5363
			[Token(Token = "0x40014F3")]
			Proto_REMOVE_MEMBER_NTF,
			// Token: 0x040014F4 RID: 5364
			[Token(Token = "0x40014F4")]
			Proto_INVITE_NTF,
			// Token: 0x040014F5 RID: 5365
			[Token(Token = "0x40014F5")]
			Proto_APPROVE_INVITATION_NTF,
			// Token: 0x040014F6 RID: 5366
			[Token(Token = "0x40014F6")]
			Proto_DISMISS_NTF,
			// Token: 0x040014F7 RID: 5367
			[Token(Token = "0x40014F7")]
			Proto_AUTO_JOIN_NTF,
			// Token: 0x040014F8 RID: 5368
			[Token(Token = "0x40014F8")]
			Proto_NEW_LUCKY_BAG_NTF,
			// Token: 0x040014F9 RID: 5369
			[Token(Token = "0x40014F9")]
			Proto_APPLY_FOR_DEPUTY_NTF,
			// Token: 0x040014FA RID: 5370
			[Token(Token = "0x40014FA")]
			Proto_DEPUTY_CAPTAIN_NTF
		}

		// Token: 0x0200046F RID: 1135
		[Token(Token = "0x200046F")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040014FC RID: 5372
			[Token(Token = "0x40014FC")]
			ErrCode_SUSS
		}
	}
}
