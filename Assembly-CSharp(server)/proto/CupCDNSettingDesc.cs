using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B51 RID: 2897
	[Token(Token = "0x2000B51")]
	[ProtoContract]
	public class CupCDNSettingDesc
	{
		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x21B9110", Offset = "0x21B9110", VA = "0x7BBC9B9110")]
		public CupCDNSettingDesc()
		{
		}

		// Token: 0x04003717 RID: 14103
		[Token(Token = "0x4003717")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E0B8", Offset = "0x112E0B8")]
		public uint cup_type;

		// Token: 0x04003718 RID: 14104
		[Token(Token = "0x4003718")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E0CC", Offset = "0x112E0CC")]
		public uint cup_id;

		// Token: 0x04003719 RID: 14105
		[Token(Token = "0x4003719")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E0E0", Offset = "0x112E0E0")]
		public bool is_animation_open;

		// Token: 0x0400371A RID: 14106
		[Token(Token = "0x400371A")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E0F4", Offset = "0x112E0F4")]
		public bool login_animation_resource;

		// Token: 0x0400371B RID: 14107
		[Token(Token = "0x400371B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E108", Offset = "0x112E108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E108", Offset = "0x112E108")]
		public string preview_resource;

		// Token: 0x0400371C RID: 14108
		[Token(Token = "0x400371C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E158", Offset = "0x112E158")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E158", Offset = "0x112E158")]
		public string lobby_resource;

		// Token: 0x0400371D RID: 14109
		[Token(Token = "0x400371D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E1A8", Offset = "0x112E1A8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E1A8", Offset = "0x112E1A8")]
		public string homepage_resource;

		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x400371E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E1F8", Offset = "0x112E1F8")]
		public bool is_notice_open;

		// Token: 0x0400371F RID: 14111
		[Token(Token = "0x400371F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E20C", Offset = "0x112E20C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E20C", Offset = "0x112E20C")]
		public string notice_cdn1;

		// Token: 0x04003720 RID: 14112
		[Token(Token = "0x4003720")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E25C", Offset = "0x112E25C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E25C", Offset = "0x112E25C")]
		public string notice_cdn2;

		// Token: 0x04003721 RID: 14113
		[Token(Token = "0x4003721")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E2AC", Offset = "0x112E2AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E2AC", Offset = "0x112E2AC")]
		public string notice_cdn3;

		// Token: 0x04003722 RID: 14114
		[Token(Token = "0x4003722")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E2FC", Offset = "0x112E2FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E2FC", Offset = "0x112E2FC")]
		public string notice_cdn4;

		// Token: 0x04003723 RID: 14115
		[Token(Token = "0x4003723")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E34C", Offset = "0x112E34C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E34C", Offset = "0x112E34C")]
		public string notice_cdn5;

		// Token: 0x04003724 RID: 14116
		[Token(Token = "0x4003724")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E39C", Offset = "0x112E39C")]
		public uint go_pos1;

		// Token: 0x04003725 RID: 14117
		[Token(Token = "0x4003725")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E3B0", Offset = "0x112E3B0")]
		public uint sub_pos1;

		// Token: 0x04003726 RID: 14118
		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E3C4", Offset = "0x112E3C4")]
		public uint go_pos2;

		// Token: 0x04003727 RID: 14119
		[Token(Token = "0x4003727")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E3D8", Offset = "0x112E3D8")]
		public uint sub_pos2;

		// Token: 0x04003728 RID: 14120
		[Token(Token = "0x4003728")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E3EC", Offset = "0x112E3EC")]
		public uint go_pos3;

		// Token: 0x04003729 RID: 14121
		[Token(Token = "0x4003729")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E400", Offset = "0x112E400")]
		public uint sub_pos3;

		// Token: 0x0400372A RID: 14122
		[Token(Token = "0x400372A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E414", Offset = "0x112E414")]
		public uint go_pos4;

		// Token: 0x0400372B RID: 14123
		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E428", Offset = "0x112E428")]
		public uint sub_pos4;

		// Token: 0x0400372C RID: 14124
		[Token(Token = "0x400372C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E43C", Offset = "0x112E43C")]
		public uint go_pos5;

		// Token: 0x0400372D RID: 14125
		[Token(Token = "0x400372D")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E450", Offset = "0x112E450")]
		public uint sub_pos5;
	}
}
