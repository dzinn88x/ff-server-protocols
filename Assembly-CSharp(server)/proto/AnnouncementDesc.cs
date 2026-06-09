using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200084C")]
	[ProtoContract]
	public class AnnouncementDesc
	{
		// Token: 0x06002561 RID: 9569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x21AF0F4", Offset = "0x21AF0F4", VA = "0x7BBC9AF0F4")]
		public AnnouncementDesc()
		{
		}

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11118B4", Offset = "0x11118B4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11118B4", Offset = "0x11118B4")]
		public string language;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111904", Offset = "0x1111904")]
		public uint order_in_this_language;

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111918", Offset = "0x1111918")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111918", Offset = "0x1111918")]
		public string title;

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111968", Offset = "0x1111968")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111968", Offset = "0x1111968")]
		public string image_url;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11119B8", Offset = "0x11119B8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11119B8", Offset = "0x11119B8")]
		public string fb_page_id;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111A08", Offset = "0x1111A08")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111A08", Offset = "0x1111A08")]
		public string image_url_for_lobby;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111A58", Offset = "0x1111A58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111A58", Offset = "0x1111A58")]
		public string link_url;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111AA8", Offset = "0x1111AA8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111AA8", Offset = "0x1111AA8")]
		public string desc;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111AF8", Offset = "0x1111AF8")]
		public long start_time;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111B0C", Offset = "0x1111B0C")]
		public long end_time;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111B20", Offset = "0x1111B20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111B20", Offset = "0x1111B20")]
		public string region;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111B70", Offset = "0x1111B70")]
		public uint id;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111B84", Offset = "0x1111B84")]
		public bool use_embedded_browser;

		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111B98", Offset = "0x1111B98")]
		public EAnnouncement.Platform platform;

		// Token: 0x0400279A RID: 10138
		[Token(Token = "0x400279A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111BAC", Offset = "0x1111BAC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111BAC", Offset = "0x1111BAC")]
		public string country_code;

		// Token: 0x0400279B RID: 10139
		[Token(Token = "0x400279B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111BFC", Offset = "0x1111BFC")]
		public EAnnouncement.AboutMax using_version;

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111C10", Offset = "0x1111C10")]
		public EAnnouncement.PhoneQuality active_phone_quality;

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111C24", Offset = "0x1111C24")]
		public uint gos_pos;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111C38", Offset = "0x1111C38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111C38", Offset = "0x1111C38")]
		public string sub_go_pos;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111C88", Offset = "0x1111C88")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111C88", Offset = "0x1111C88")]
		public string id_last_num;
	}
}
