using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	[ProtoContract]
	public class RedEnvelope
	{
		// Token: 0x060023AE RID: 9134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x249FDC4", Offset = "0x249FDC4", VA = "0x7BBCC9FDC4")]
		public RedEnvelope()
		{
		}

		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11083A4", Offset = "0x11083A4")]
		public uint id;

		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11083B8", Offset = "0x11083B8")]
		public uint cnt;
	}
}
