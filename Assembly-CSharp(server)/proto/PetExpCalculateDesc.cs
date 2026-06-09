using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009ED RID: 2541
	[Token(Token = "0x20009ED")]
	[ProtoContract]
	public class PetExpCalculateDesc
	{
		// Token: 0x060026F7 RID: 9975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0x249F14C", Offset = "0x249F14C", VA = "0x7BBCC9F14C")]
		public PetExpCalculateDesc()
		{
		}

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C138", Offset = "0x111C138")]
		public uint game_mode;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C14C", Offset = "0x111C14C")]
		public uint base_factor;
	}
}
