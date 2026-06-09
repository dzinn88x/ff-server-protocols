using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E9 RID: 2537
	[Token(Token = "0x20009E9")]
	[ProtoContract]
	public class PetDesc
	{
		// Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x249F144", Offset = "0x249F144", VA = "0x7BBCC9F144")]
		public PetDesc()
		{
		}

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BFBC", Offset = "0x111BFBC")]
		public uint id;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BFD0", Offset = "0x111BFD0")]
		public EInventory.RareType rare_type;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BFE4", Offset = "0x111BFE4")]
		public uint max_level;
	}
}
