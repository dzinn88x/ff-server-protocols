using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	[ProtoContract]
	public class EAntiAddiction
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x24A2CF0", Offset = "0x24A2CF0", VA = "0x7BBCCA2CF0")]
		public EAntiAddiction()
		{
		}

		// Token: 0x02000446 RID: 1094
		[Token(Token = "0x2000446")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001468 RID: 5224
			[Token(Token = "0x4001468")]
			Proto_NONE,
			// Token: 0x04001469 RID: 5225
			[Token(Token = "0x4001469")]
			Proto_HINT_NTF
		}

		// Token: 0x02000447 RID: 1095
		[Token(Token = "0x2000447")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x0400146B RID: 5227
			[Token(Token = "0x400146B")]
			ErrCode_SUSS
		}

		// Token: 0x02000448 RID: 1096
		[Token(Token = "0x2000448")]
		[ProtoContract]
		public enum TotalTimeBanMode
		{
			// Token: 0x0400146D RID: 5229
			[Token(Token = "0x400146D")]
			TotalTimeBanMode_NONE,
			// Token: 0x0400146E RID: 5230
			[Token(Token = "0x400146E")]
			TotalTimeBanMode_RANKING,
			// Token: 0x0400146F RID: 5231
			[Token(Token = "0x400146F")]
			TotalTimeBanMode_ALL
		}

		// Token: 0x02000449 RID: 1097
		[Token(Token = "0x2000449")]
		[ProtoContract]
		public enum AgeState
		{
			// Token: 0x04001471 RID: 5233
			[Token(Token = "0x4001471")]
			AgeState_NONE,
			// Token: 0x04001472 RID: 5234
			[Token(Token = "0x4001472")]
			AgeState_UNDER_AGE,
			// Token: 0x04001473 RID: 5235
			[Token(Token = "0x4001473")]
			AgeState_ADULT
		}
	}
}
