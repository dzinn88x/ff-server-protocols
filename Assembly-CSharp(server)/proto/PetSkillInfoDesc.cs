using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F1 RID: 2545
	[Token(Token = "0x20009F1")]
	[ProtoContract]
	public class PetSkillInfoDesc
	{
		// Token: 0x060026FB RID: 9979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x249F2A8", Offset = "0x249F2A8", VA = "0x7BBCC9F2A8")]
		public PetSkillInfoDesc()
		{
		}

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C264", Offset = "0x111C264")]
		public uint skill_id;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C278", Offset = "0x111C278")]
		public uint source_type;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C28C", Offset = "0x111C28C")]
		public uint source_pet_id;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C2A0", Offset = "0x111C2A0")]
		public uint pet_id;
	}
}
