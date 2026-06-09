using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200069C RID: 1692
	[Token(Token = "0x200069C")]
	[ProtoContract]
	public class EAuth
	{
		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x21B97D8", Offset = "0x21B97D8", VA = "0x7BBC9B97D8")]
		public EAuth()
		{
		}

		// Token: 0x0200069D RID: 1693
		[Token(Token = "0x200069D")]
		[ProtoContract]
		public enum ClientUsingVersion
		{
			// Token: 0x04002133 RID: 8499
			[Token(Token = "0x4002133")]
			ClientUsingVersion_NONE,
			// Token: 0x04002134 RID: 8500
			[Token(Token = "0x4002134")]
			ClientUsingVersion_NORMAL,
			// Token: 0x04002135 RID: 8501
			[Token(Token = "0x4002135")]
			ClientUsingVersion_MAX
		}
	}
}
