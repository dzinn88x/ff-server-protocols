using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	[ProtoContract]
	public class EMail
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x24A2D60", Offset = "0x24A2D60", VA = "0x7BBCCA2D60")]
		public EMail()
		{
		}

		// Token: 0x020004CD RID: 1229
		[Token(Token = "0x20004CD")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040016C3 RID: 5827
			[Token(Token = "0x40016C3")]
			Proto_NONE,
			// Token: 0x040016C4 RID: 5828
			[Token(Token = "0x40016C4")]
			Proto_PUSH_NTF
		}

		// Token: 0x020004CE RID: 1230
		[Token(Token = "0x20004CE")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040016C6 RID: 5830
			[Token(Token = "0x40016C6")]
			ErrCode_SUSS
		}
	}
}
