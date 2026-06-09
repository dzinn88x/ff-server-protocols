using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	[ProtoContract]
	public class PetFoodDesc
	{
		// Token: 0x060026F5 RID: 9973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x249F1B0", Offset = "0x249F1B0", VA = "0x7BBCC9F1B0")]
		public PetFoodDesc()
		{
		}

		// Token: 0x04002DE3 RID: 11747
		[Token(Token = "0x4002DE3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C070", Offset = "0x111C070")]
		public uint id;

		// Token: 0x04002DE4 RID: 11748
		[Token(Token = "0x4002DE4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C084", Offset = "0x111C084")]
		public uint exp;

		// Token: 0x04002DE5 RID: 11749
		[Token(Token = "0x4002DE5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C098", Offset = "0x111C098")]
		public uint[] suitable;
	}
}
