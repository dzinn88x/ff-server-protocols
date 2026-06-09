using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E8 RID: 2536
	[Token(Token = "0x20009E8")]
	[ProtoContract]
	public class LegendClothUnlockDesc
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x21BB94C", Offset = "0x21BB94C", VA = "0x7BBC9BB94C")]
		public LegendClothUnlockDesc()
		{
		}

		// Token: 0x04002DD3 RID: 11731
		[Token(Token = "0x4002DD3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF30", Offset = "0x111BF30")]
		public uint set_id;

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF44", Offset = "0x111BF44")]
		public uint unlock_level;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF58", Offset = "0x111BF58")]
		public uint legend_cloth_id;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF6C", Offset = "0x111BF6C")]
		public EInventory.LegendClothCdtType cdt_type;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF80", Offset = "0x111BF80")]
		public uint cdt_value;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BF94", Offset = "0x111BF94")]
		public uint unlock_lead_emote;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BFA8", Offset = "0x111BFA8")]
		public uint unlock_booyah_emote;
	}
}
