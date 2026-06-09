using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	[ProtoContract]
	public class ScrollMarqueeDesc
	{
		// Token: 0x06002563 RID: 9571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x24A04A0", Offset = "0x24A04A0", VA = "0x7BBCCA04A0")]
		public ScrollMarqueeDesc()
		{
		}

		// Token: 0x040027B4 RID: 10164
		[Token(Token = "0x40027B4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112084", Offset = "0x1112084")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112084", Offset = "0x1112084")]
		public string language;

		// Token: 0x040027B5 RID: 10165
		[Token(Token = "0x40027B5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11120D4", Offset = "0x11120D4")]
		public uint order_in_this_language;

		// Token: 0x040027B6 RID: 10166
		[Token(Token = "0x40027B6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11120E8", Offset = "0x11120E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11120E8", Offset = "0x11120E8")]
		public string content;

		// Token: 0x040027B7 RID: 10167
		[Token(Token = "0x40027B7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112138", Offset = "0x1112138")]
		public long start_time;

		// Token: 0x040027B8 RID: 10168
		[Token(Token = "0x40027B8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111214C", Offset = "0x111214C")]
		public long end_time;

		// Token: 0x040027B9 RID: 10169
		[Token(Token = "0x40027B9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112160", Offset = "0x1112160")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112160", Offset = "0x1112160")]
		public string region;

		// Token: 0x040027BA RID: 10170
		[Token(Token = "0x40027BA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11121B0", Offset = "0x11121B0")]
		public uint gos_pos;

		// Token: 0x040027BB RID: 10171
		[Token(Token = "0x40027BB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11121C4", Offset = "0x11121C4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11121C4", Offset = "0x11121C4")]
		public string gos_url;

		// Token: 0x040027BC RID: 10172
		[Token(Token = "0x40027BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112214", Offset = "0x1112214")]
		public bool use_embedded_browser;

		// Token: 0x040027BD RID: 10173
		[Token(Token = "0x40027BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112228", Offset = "0x1112228")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112228", Offset = "0x1112228")]
		public string sub_go_pos;

		// Token: 0x040027BE RID: 10174
		[Token(Token = "0x40027BE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112278", Offset = "0x1112278")]
		public EAnnouncement.Platform platform;

		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111228C", Offset = "0x111228C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111228C", Offset = "0x111228C")]
		public string country_code;

		// Token: 0x040027C0 RID: 10176
		[Token(Token = "0x40027C0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11122DC", Offset = "0x11122DC")]
		public EAnnouncement.AboutMax using_version;

		// Token: 0x040027C1 RID: 10177
		[Token(Token = "0x40027C1")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11122F0", Offset = "0x11122F0")]
		public EAnnouncement.PhoneQuality active_phone_quality;
	}
}
