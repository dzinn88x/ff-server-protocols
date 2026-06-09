using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	[ProtoContract]
	public class SplashBannerDesc
	{
		// Token: 0x06002562 RID: 9570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x24A0778", Offset = "0x24A0778", VA = "0x7BBCCA0778")]
		public SplashBannerDesc()
		{
		}

		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111CD8", Offset = "0x1111CD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111CD8", Offset = "0x1111CD8")]
		public string region;

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111D28", Offset = "0x1111D28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111D28", Offset = "0x1111D28")]
		public string language;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111D78", Offset = "0x1111D78")]
		public uint id;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111D8C", Offset = "0x1111D8C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111D8C", Offset = "0x1111D8C")]
		public string name;

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111DDC", Offset = "0x1111DDC")]
		public uint sort_id;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111DF0", Offset = "0x1111DF0")]
		public long start_time;

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111E04", Offset = "0x1111E04")]
		public long end_time;

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111E18", Offset = "0x1111E18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111E18", Offset = "0x1111E18")]
		public string image_url;

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111E68", Offset = "0x1111E68")]
		public uint gos_pos;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111E7C", Offset = "0x1111E7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111E7C", Offset = "0x1111E7C")]
		public string gos_url;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111ECC", Offset = "0x1111ECC")]
		public bool use_embedded_browser;

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111EE0", Offset = "0x1111EE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111EE0", Offset = "0x1111EE0")]
		public string sub_go_pos;

		// Token: 0x040027AC RID: 10156
		[Token(Token = "0x40027AC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111F30", Offset = "0x1111F30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111F30", Offset = "0x1111F30")]
		public string video_url;

		// Token: 0x040027AD RID: 10157
		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111F80", Offset = "0x1111F80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111F80", Offset = "0x1111F80")]
		public string bg_img_url;

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111FD0", Offset = "0x1111FD0")]
		public uint type;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111FE4", Offset = "0x1111FE4")]
		public EAnnouncement.Platform platform;

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111FF8", Offset = "0x1111FF8")]
		public uint weight;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111200C", Offset = "0x111200C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111200C", Offset = "0x111200C")]
		public string country_code;

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111205C", Offset = "0x111205C")]
		public EAnnouncement.AboutMax using_version;

		// Token: 0x040027B3 RID: 10163
		[Token(Token = "0x40027B3")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112070", Offset = "0x1112070")]
		public EAnnouncement.PhoneQuality active_phone_quality;
	}
}
