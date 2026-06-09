using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F7 RID: 2295
	[Token(Token = "0x20008F7")]
	[ProtoContract]
	public class TeamInfo
	{
		// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x24A0DA4", Offset = "0x24A0DA4", VA = "0x7BBCCA0DA4")]
		public TeamInfo()
		{
		}

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11175FC", Offset = "0x11175FC")]
		public ulong team_id;

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117610", Offset = "0x1117610")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117610", Offset = "0x1117610")]
		public string team_name;

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117660", Offset = "0x1117660")]
		public ulong create_at;

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117674", Offset = "0x1117674")]
		public ulong captain_id;

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117688", Offset = "0x1117688")]
		public uint member_num;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111769C", Offset = "0x111769C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111769C", Offset = "0x111769C")]
		public string region;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11176EC", Offset = "0x11176EC")]
		public uint banner_id;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117700", Offset = "0x1117700")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117700", Offset = "0x1117700")]
		public string contact_info;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117750", Offset = "0x1117750")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117750", Offset = "0x1117750")]
		public string country_or_area;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11177A0", Offset = "0x11177A0")]
		public uint head_pic;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11177B4", Offset = "0x11177B4")]
		public ulong[] member_ids;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11177F0", Offset = "0x11177F0")]
		public uint limited_level;

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117804", Offset = "0x1117804")]
		public uint limited_ranking_point;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117818", Offset = "0x1117818")]
		public bool is_qualified;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111782C", Offset = "0x111782C")]
		public uint upper_limited_level;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117840", Offset = "0x1117840")]
		public uint upper_limited_ranking_point;
	}
}
