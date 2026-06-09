using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8F RID: 2703
	[Token(Token = "0x2000A8F")]
	[ProtoContract]
	public class AdvertDesc
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x21AEEFC", Offset = "0x21AEEFC", VA = "0x7BBC9AEEFC")]
		public AdvertDesc()
		{
		}

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123618", Offset = "0x1123618")]
		public uint id;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112362C", Offset = "0x112362C")]
		public uint type;

		// Token: 0x040031C6 RID: 12742
		[Token(Token = "0x40031C6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123640", Offset = "0x1123640")]
		public uint sort_id;

		// Token: 0x040031C7 RID: 12743
		[Token(Token = "0x40031C7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123654", Offset = "0x1123654")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123654", Offset = "0x1123654")]
		public string language;

		// Token: 0x040031C8 RID: 12744
		[Token(Token = "0x40031C8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11236A4", Offset = "0x11236A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11236A4", Offset = "0x11236A4")]
		public string advertisment_url;

		// Token: 0x040031C9 RID: 12745
		[Token(Token = "0x40031C9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11236F4", Offset = "0x11236F4")]
		public uint ad_start_time;

		// Token: 0x040031CA RID: 12746
		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123708", Offset = "0x1123708")]
		public uint ad_end_time;

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112371C", Offset = "0x112371C")]
		public uint go_pos;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123730", Offset = "0x1123730")]
		public uint sub_type;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123744", Offset = "0x1123744")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123744", Offset = "0x1123744")]
		public string sub_go_pos;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123794", Offset = "0x1123794")]
		public bool external_for_official_website;

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11237A8", Offset = "0x11237A8")]
		public bool go_to_switch;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11237BC", Offset = "0x11237BC")]
		public uint small_start_time;
	}
}
