using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200044C RID: 1100
	[Token(Token = "0x200044C")]
	[ProtoContract]
	public class EVeteranTask
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x24A2DC8", Offset = "0x24A2DC8", VA = "0x7BBCCA2DC8")]
		public EVeteranTask()
		{
		}

		// Token: 0x0200044D RID: 1101
		[Token(Token = "0x200044D")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400147E RID: 5246
			[Token(Token = "0x400147E")]
			Proto_NONE,
			// Token: 0x0400147F RID: 5247
			[Token(Token = "0x400147F")]
			Proto_UPDATE_NTF
		}

		// Token: 0x0200044E RID: 1102
		[Token(Token = "0x200044E")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001481 RID: 5249
			[Token(Token = "0x4001481")]
			ErrCode_SUSS
		}
	}
}
