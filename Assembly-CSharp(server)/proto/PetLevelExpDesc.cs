using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009EA RID: 2538
	[Token(Token = "0x20009EA")]
	[ProtoContract]
	public class PetLevelExpDesc
	{
		// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x249F23C", Offset = "0x249F23C", VA = "0x7BBCC9F23C")]
		public PetLevelExpDesc()
		{
		}

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BFF8", Offset = "0x111BFF8")]
		public uint lv;

		// Token: 0x04002DDE RID: 11742
		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C00C", Offset = "0x111C00C")]
		public uint exp_normal;

		// Token: 0x04002DDF RID: 11743
		[Token(Token = "0x4002DDF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C020", Offset = "0x111C020")]
		public uint exp_good;

		// Token: 0x04002DE0 RID: 11744
		[Token(Token = "0x4002DE0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C034", Offset = "0x111C034")]
		public uint exp_rare;

		// Token: 0x04002DE1 RID: 11745
		[Token(Token = "0x4002DE1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C048", Offset = "0x111C048")]
		public uint exp_epic;

		// Token: 0x04002DE2 RID: 11746
		[Token(Token = "0x4002DE2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C05C", Offset = "0x111C05C")]
		public uint exp_legend;
	}
}
