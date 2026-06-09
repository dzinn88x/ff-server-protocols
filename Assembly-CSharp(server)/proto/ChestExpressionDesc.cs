using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	[ProtoContract]
	public class ChestExpressionDesc
	{
		// Token: 0x0600279F RID: 10143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x21B83AC", Offset = "0x21B83AC", VA = "0x7BBC9B83AC")]
		public ChestExpressionDesc()
		{
		}

		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11244DC", Offset = "0x11244DC")]
		public uint chest_id;

		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11244F0", Offset = "0x11244F0")]
		public uint chest_sub_id;

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124504", Offset = "0x1124504")]
		public uint color_id;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124518", Offset = "0x1124518")]
		public uint chest_model_id;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112452C", Offset = "0x112452C")]
		public uint show_model_male;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124540", Offset = "0x1124540")]
		public uint show_model_female;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124554", Offset = "0x1124554")]
		public uint chest_model_id2;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124568", Offset = "0x1124568")]
		public uint chest_activity;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112457C", Offset = "0x112457C")]
		public uint extra_reward_icon;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124590", Offset = "0x1124590")]
		public uint chest_hint_color;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11245A4", Offset = "0x11245A4")]
		public uint[] show_type;

		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11245E0", Offset = "0x11245E0")]
		public uint show_ui_color;

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11245F4", Offset = "0x11245F4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11245F4", Offset = "0x11245F4")]
		public string bag_icon;
	}
}
