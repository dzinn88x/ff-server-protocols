using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000453 RID: 1107
	[Token(Token = "0x2000453")]
	[ProtoContract]
	public class EChampionship
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x24A2CF8", Offset = "0x24A2CF8", VA = "0x7BBCCA2CF8")]
		public EChampionship()
		{
		}

		// Token: 0x02000454 RID: 1108
		[Token(Token = "0x2000454")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400148C RID: 5260
			[Token(Token = "0x400148C")]
			Proto_NONE,
			// Token: 0x0400148D RID: 5261
			[Token(Token = "0x400148D")]
			Proto_REQUEST_JOIN_NTF,
			// Token: 0x0400148E RID: 5262
			[Token(Token = "0x400148E")]
			Proto_CONFIRM_ADD_NTF,
			// Token: 0x0400148F RID: 5263
			[Token(Token = "0x400148F")]
			Proto_REMOVE_MEMBER_NTF,
			// Token: 0x04001490 RID: 5264
			[Token(Token = "0x4001490")]
			Proto_INVITE_NTF,
			// Token: 0x04001491 RID: 5265
			[Token(Token = "0x4001491")]
			Proto_APPROVE_INVITATION_NTF,
			// Token: 0x04001492 RID: 5266
			[Token(Token = "0x4001492")]
			Proto_DISMISS_NTF,
			// Token: 0x04001493 RID: 5267
			[Token(Token = "0x4001493")]
			Proto_MATCH_END_NTF,
			// Token: 0x04001494 RID: 5268
			[Token(Token = "0x4001494")]
			Proto_FAKE_SUBMIT_NTF,
			// Token: 0x04001495 RID: 5269
			[Token(Token = "0x4001495")]
			Proto_DECLINE_INVITATION_NTF
		}

		// Token: 0x02000455 RID: 1109
		[Token(Token = "0x2000455")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001497 RID: 5271
			[Token(Token = "0x4001497")]
			ErrCode_SUSS
		}
	}
}
