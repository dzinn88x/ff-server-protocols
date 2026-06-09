using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CB RID: 2507
	[Token(Token = "0x20009CB")]
	[ProtoContract]
	public class ClothesDesc
	{
		// Token: 0x060026D5 RID: 9941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x21B8EE4", Offset = "0x21B8EE4", VA = "0x7BBC9B8EE4")]
		public ClothesDesc()
		{
		}

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B10C", Offset = "0x111B10C")]
		public uint id;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B120", Offset = "0x111B120")]
		public EInventory.ClothesType type;

		// Token: 0x04002D4D RID: 11597
		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B134", Offset = "0x111B134")]
		public bool is_default;

		// Token: 0x04002D4E RID: 11598
		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B148", Offset = "0x111B148")]
		public bool is_selected;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B15C", Offset = "0x111B15C")]
		public uint avatar_id;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B170", Offset = "0x111B170")]
		public uint cloth_set_id;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B184", Offset = "0x111B184")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B184", Offset = "0x111B184")]
		public string team_effect_male;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B1D4", Offset = "0x111B1D4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B1D4", Offset = "0x111B1D4")]
		public string team_effect_female;
	}
}
