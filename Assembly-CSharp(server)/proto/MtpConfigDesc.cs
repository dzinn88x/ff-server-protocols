using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	[ProtoContract]
	public class MtpConfigDesc
	{
		// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x249E540", Offset = "0x249E540", VA = "0x7BBCC9E540")]
		public MtpConfigDesc()
		{
		}

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EC08", Offset = "0x111EC08")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EC08", Offset = "0x111EC08")]
		public string region;

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EC58", Offset = "0x111EC58")]
		public bool enable;
	}
}
