using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E1 RID: 2529
	[Token(Token = "0x20009E1")]
	[ProtoContract]
	public class MysteryBonusRatesDesc
	{
		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x249E660", Offset = "0x249E660", VA = "0x7BBCC9E660")]
		public MysteryBonusRatesDesc()
		{
		}

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BB5C", Offset = "0x111BB5C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BB5C", Offset = "0x111BB5C")]
		public string region;

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BBAC", Offset = "0x111BBAC")]
		public uint pool_id;

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BBC0", Offset = "0x111BBC0")]
		public uint bonus_percent;

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BBD4", Offset = "0x111BBD4")]
		public uint weight;
	}
}
