using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	[ProtoContract]
	public class OptionalBundleShow
	{
		// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x249EDA0", Offset = "0x249EDA0", VA = "0x7BBCC9EDA0")]
		public OptionalBundleShow()
		{
		}

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF84", Offset = "0x110DF84")]
		public uint id;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF98", Offset = "0x110DF98")]
		public List<OptionalBundleShowData> bundles;
	}
}
