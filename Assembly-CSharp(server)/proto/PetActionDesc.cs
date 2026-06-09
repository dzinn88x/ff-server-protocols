using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	[ProtoContract]
	public class PetActionDesc
	{
		// Token: 0x060026F9 RID: 9977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x249F134", Offset = "0x249F134", VA = "0x7BBCC9F134")]
		public PetActionDesc()
		{
		}

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C19C", Offset = "0x111C19C")]
		public uint action_id;

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C1B0", Offset = "0x111C1B0")]
		public uint pet_id;

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C1C4", Offset = "0x111C1C4")]
		public uint pet_level;
	}
}
