using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000479 RID: 1145
	[Token(Token = "0x2000479")]
	[ProtoContract]
	public class EElitePass
	{
		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x24A2D20", Offset = "0x24A2D20", VA = "0x7BBCCA2D20")]
		public EElitePass()
		{
		}

		// Token: 0x0200047A RID: 1146
		[Token(Token = "0x200047A")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001515 RID: 5397
			[Token(Token = "0x4001515")]
			Proto_NONE,
			// Token: 0x04001516 RID: 5398
			[Token(Token = "0x4001516")]
			Proto_CHALLENGE_COMPLETE_NTF,
			// Token: 0x04001517 RID: 5399
			[Token(Token = "0x4001517")]
			Proto_ACCOUNT_EP_LEVEL_UP,
			// Token: 0x04001518 RID: 5400
			[Token(Token = "0x4001518")]
			Proto_QUEST_COMPLETE_NTF
		}

		// Token: 0x0200047B RID: 1147
		[Token(Token = "0x200047B")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x0400151A RID: 5402
			[Token(Token = "0x400151A")]
			ErrCode_SUSS
		}
	}
}
