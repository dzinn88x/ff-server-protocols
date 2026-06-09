using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	[ProtoContract]
	public class EActivity
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x24A2CE8", Offset = "0x24A2CE8", VA = "0x7BBCCA2CE8")]
		public EActivity()
		{
		}

		// Token: 0x02000441 RID: 1089
		[Token(Token = "0x2000441")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400145E RID: 5214
			[Token(Token = "0x400145E")]
			Proto_NONE,
			// Token: 0x0400145F RID: 5215
			[Token(Token = "0x400145F")]
			Proto_UPDATE_NTF
		}

		// Token: 0x02000442 RID: 1090
		[Token(Token = "0x2000442")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001461 RID: 5217
			[Token(Token = "0x4001461")]
			ErrCode_SUSS
		}
	}
}
