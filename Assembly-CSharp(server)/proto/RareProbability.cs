using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	[ProtoContract]
	public class RareProbability
	{
		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x249FBA0", Offset = "0x249FBA0", VA = "0x7BBCC9FBA0")]
		public RareProbability()
		{
		}

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11085E8", Offset = "0x11085E8")]
		public uint rare;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11085FC", Offset = "0x11085FC")]
		public uint probability;
	}
}
