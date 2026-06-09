using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	[ProtoContract]
	public class PetRenameCostDesc
	{
		// Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0x249F244", Offset = "0x249F244", VA = "0x7BBCC9F244")]
		public PetRenameCostDesc()
		{
		}

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C0D4", Offset = "0x111C0D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C0D4", Offset = "0x111C0D4")]
		public string region;

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C124", Offset = "0x111C124")]
		public uint diamond_cost;
	}
}
