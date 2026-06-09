using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009EE RID: 2542
	[Token(Token = "0x20009EE")]
	[ProtoContract]
	public class PetSkinDesc
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F8")]
		[Address(RVA = "0x249F2B8", Offset = "0x249F2B8", VA = "0x7BBCC9F2B8")]
		public PetSkinDesc()
		{
		}

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C160", Offset = "0x111C160")]
		public uint skin_id;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C174", Offset = "0x111C174")]
		public uint pet_id;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C188", Offset = "0x111C188")]
		public uint pet_level;
	}
}
