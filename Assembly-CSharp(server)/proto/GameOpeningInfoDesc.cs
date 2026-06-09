using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	[ProtoContract]
	public class GameOpeningInfoDesc
	{
		// Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x21BA800", Offset = "0x21BA800", VA = "0x7BBC9BA800")]
		public GameOpeningInfoDesc()
		{
		}

		// Token: 0x04002ED6 RID: 11990
		[Token(Token = "0x4002ED6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DFEC", Offset = "0x111DFEC")]
		public uint map_id;

		// Token: 0x04002ED7 RID: 11991
		[Token(Token = "0x4002ED7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E000", Offset = "0x111E000")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E000", Offset = "0x111E000")]
		public string name;

		// Token: 0x04002ED8 RID: 11992
		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E050", Offset = "0x111E050")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E050", Offset = "0x111E050")]
		public string start_time;

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E0A0", Offset = "0x111E0A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E0A0", Offset = "0x111E0A0")]
		public string end_time;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E0F0", Offset = "0x111E0F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E0F0", Offset = "0x111E0F0")]
		public string tips;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E140", Offset = "0x111E140")]
		public uint game_mode;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E154", Offset = "0x111E154")]
		public uint match_mode;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E168", Offset = "0x111E168")]
		public bool is_new;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E17C", Offset = "0x111E17C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E17C", Offset = "0x111E17C")]
		public string config_start_time;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E1CC", Offset = "0x111E1CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E1CC", Offset = "0x111E1CC")]
		public string config_end_time;

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E21C", Offset = "0x111E21C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E21C", Offset = "0x111E21C")]
		public string player_count_limit;

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E26C", Offset = "0x111E26C")]
		public uint level_visual_style;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E280", Offset = "0x111E280")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E280", Offset = "0x111E280")]
		public string difficulty;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E2D0", Offset = "0x111E2D0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E2D0", Offset = "0x111E2D0")]
		public string weekday;

		// Token: 0x04002EE4 RID: 12004
		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E320", Offset = "0x111E320")]
		public uint sort_id;

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E334", Offset = "0x111E334")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E334", Offset = "0x111E334")]
		public string visual_map;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E384", Offset = "0x111E384")]
		public uint tag;

		// Token: 0x04002EE7 RID: 12007
		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E398", Offset = "0x111E398")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E398", Offset = "0x111E398")]
		public string version;

		// Token: 0x04002EE8 RID: 12008
		[Token(Token = "0x4002EE8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E3E8", Offset = "0x111E3E8")]
		public bool is_random;

		// Token: 0x04002EE9 RID: 12009
		[Token(Token = "0x4002EE9")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E3FC", Offset = "0x111E3FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E3FC", Offset = "0x111E3FC")]
		public string match_mode_image;

		// Token: 0x04002EEA RID: 12010
		[Token(Token = "0x4002EEA")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E44C", Offset = "0x111E44C")]
		public bool is_force_random;

		// Token: 0x04002EEB RID: 12011
		[Token(Token = "0x4002EEB")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E460", Offset = "0x111E460")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E460", Offset = "0x111E460")]
		public string tips_parameter;

		// Token: 0x04002EEC RID: 12012
		[Token(Token = "0x4002EEC")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E4B0", Offset = "0x111E4B0")]
		public bool is_live_open;

		// Token: 0x04002EED RID: 12013
		[Token(Token = "0x4002EED")]
		[FieldOffset(Offset = "0xBC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E4C4", Offset = "0x111E4C4")]
		public uint live_effects_id;

		// Token: 0x04002EEE RID: 12014
		[Token(Token = "0x4002EEE")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E4D8", Offset = "0x111E4D8")]
		public bool max_only;
	}
}
