using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AC RID: 2476
	[Token(Token = "0x20009AC")]
	[ProtoContract]
	public class CSGetEnergyGachaBuffRes
	{
		// Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x21B32EC", Offset = "0x21B32EC", VA = "0x7BBC9B32EC")]
		public CSGetEnergyGachaBuffRes()
		{
		}

		// Token: 0x04002C9B RID: 11419
		[Token(Token = "0x4002C9B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A568", Offset = "0x111A568")]
		public uint buff_display_one;

		// Token: 0x04002C9C RID: 11420
		[Token(Token = "0x4002C9C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A57C", Offset = "0x111A57C")]
		public uint buff_display_ten;
	}
}
