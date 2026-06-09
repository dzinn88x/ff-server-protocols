using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	[ProtoContract]
	public class EFriend
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x24A2D30", Offset = "0x24A2D30", VA = "0x7BBCCA2D30")]
		public EFriend()
		{
		}

		// Token: 0x02000483 RID: 1155
		[Token(Token = "0x2000483")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001529 RID: 5417
			[Token(Token = "0x4001529")]
			Proto_NONE,
			// Token: 0x0400152A RID: 5418
			[Token(Token = "0x400152A")]
			Proto_REQUEST_NTF,
			// Token: 0x0400152B RID: 5419
			[Token(Token = "0x400152B")]
			Proto_CONFIRM_NTF,
			// Token: 0x0400152C RID: 5420
			[Token(Token = "0x400152C")]
			Proto_REMOVE_NTF,
			// Token: 0x0400152D RID: 5421
			[Token(Token = "0x400152D")]
			Proto_RELATED_FRIEND_ONLINE,
			// Token: 0x0400152E RID: 5422
			[Token(Token = "0x400152E")]
			Proto_RELATED_FRIEND_REQUEST_NTF,
			// Token: 0x0400152F RID: 5423
			[Token(Token = "0x400152F")]
			Proto_RELATED_FRIEND_CONFIRM_NTF,
			// Token: 0x04001530 RID: 5424
			[Token(Token = "0x4001530")]
			Proto_RELATED_FRIEND_DECLINE_NTF,
			// Token: 0x04001531 RID: 5425
			[Token(Token = "0x4001531")]
			Proto_RELATED_FRIEND_REQUEST_EXPIRE_NTF,
			// Token: 0x04001532 RID: 5426
			[Token(Token = "0x4001532")]
			Proto_INTIMACY_CHANGE_NTF
		}

		// Token: 0x02000484 RID: 1156
		[Token(Token = "0x2000484")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001534 RID: 5428
			[Token(Token = "0x4001534")]
			ErrCode_SUSS
		}
	}
}
