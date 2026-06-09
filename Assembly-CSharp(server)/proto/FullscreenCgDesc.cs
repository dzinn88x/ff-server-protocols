using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	[ProtoContract]
	public class FullscreenCgDesc
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x21BA48C", Offset = "0x21BA48C", VA = "0x7BBC9BA48C")]
		public FullscreenCgDesc()
		{
		}

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11237D0", Offset = "0x11237D0")]
		public uint id;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11237E4", Offset = "0x11237E4")]
		public uint anim_id;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11237F8", Offset = "0x11237F8")]
		public uint anim_type;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112380C", Offset = "0x112380C")]
		public uint system_pos;

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123820", Offset = "0x1123820")]
		public uint go_pos;

		// Token: 0x040031D6 RID: 12758
		[Token(Token = "0x40031D6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123834", Offset = "0x1123834")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123834", Offset = "0x1123834")]
		public string fullscreen_resource_id;

		// Token: 0x040031D7 RID: 12759
		[Token(Token = "0x40031D7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123884", Offset = "0x1123884")]
		public uint first_model_id;

		// Token: 0x040031D8 RID: 12760
		[Token(Token = "0x40031D8")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123898", Offset = "0x1123898")]
		public uint first_model_cloth1;

		// Token: 0x040031D9 RID: 12761
		[Token(Token = "0x40031D9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11238AC", Offset = "0x11238AC")]
		public uint first_model_cloth2;

		// Token: 0x040031DA RID: 12762
		[Token(Token = "0x40031DA")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11238C0", Offset = "0x11238C0")]
		public uint first_model_cloth3;

		// Token: 0x040031DB RID: 12763
		[Token(Token = "0x40031DB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11238D4", Offset = "0x11238D4")]
		public uint first_model_cloth4;

		// Token: 0x040031DC RID: 12764
		[Token(Token = "0x40031DC")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11238E8", Offset = "0x11238E8")]
		public uint first_model_cloth5;

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11238FC", Offset = "0x11238FC")]
		public uint second_model_id;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123910", Offset = "0x1123910")]
		public uint second_model_cloth1;

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123924", Offset = "0x1123924")]
		public uint second_model_cloth2;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123938", Offset = "0x1123938")]
		public uint second_model_cloth3;

		// Token: 0x040031E1 RID: 12769
		[Token(Token = "0x40031E1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112394C", Offset = "0x112394C")]
		public uint second_model_cloth4;

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123960", Offset = "0x1123960")]
		public uint second_model_cloth5;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123974", Offset = "0x1123974")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123974", Offset = "0x1123974")]
		public string first_model_female_idle;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11239C4", Offset = "0x11239C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11239C4", Offset = "0x11239C4")]
		public string first_model_female_special;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123A14", Offset = "0x1123A14")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123A14", Offset = "0x1123A14")]
		public string first_model_male_idle;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123A64", Offset = "0x1123A64")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123A64", Offset = "0x1123A64")]
		public string first_model_male_special;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123AB4", Offset = "0x1123AB4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123AB4", Offset = "0x1123AB4")]
		public string second_model_female_idle;

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123B04", Offset = "0x1123B04")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123B04", Offset = "0x1123B04")]
		public string second_model_female_special;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123B54", Offset = "0x1123B54")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123B54", Offset = "0x1123B54")]
		public string second_model_male_idle;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123BA4", Offset = "0x1123BA4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123BA4", Offset = "0x1123BA4")]
		public string second_model_male_special;

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123BF4", Offset = "0x1123BF4")]
		public List<string> skin_resource_list;
	}
}
