using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D6 RID: 2518
	[Token(Token = "0x20009D6")]
	[ProtoContract]
	public class WeaponSkinDesc
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x24A1868", Offset = "0x24A1868", VA = "0x7BBCCA1868")]
		public WeaponSkinDesc()
		{
		}

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B6C0", Offset = "0x111B6C0")]
		public uint item_id;

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B6D4", Offset = "0x111B6D4")]
		public uint weapon_id;

		// Token: 0x04002D87 RID: 11655
		[Token(Token = "0x4002D87")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B6E8", Offset = "0x111B6E8")]
		public bool is_show;
	}
}
