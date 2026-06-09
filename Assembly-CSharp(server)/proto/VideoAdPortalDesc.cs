using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	[ProtoContract]
	public class VideoAdPortalDesc
	{
		// Token: 0x06002795 RID: 10133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002795")]
		[Address(RVA = "0x24A16B8", Offset = "0x24A16B8", VA = "0x7BBCCA16B8")]
		public VideoAdPortalDesc()
		{
		}

		// Token: 0x040031B2 RID: 12722
		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123384", Offset = "0x1123384")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123384", Offset = "0x1123384")]
		public string region;

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11233D4", Offset = "0x11233D4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11233D4", Offset = "0x11233D4")]
		public string language;

		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123424", Offset = "0x1123424")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123424", Offset = "0x1123424")]
		public string video_url;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123474", Offset = "0x1123474")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123474", Offset = "0x1123474")]
		public string start_time;

		// Token: 0x040031B6 RID: 12726
		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11234C4", Offset = "0x11234C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11234C4", Offset = "0x11234C4")]
		public string end_time;

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123514", Offset = "0x1123514")]
		public long start_timestamp;

		// Token: 0x040031B8 RID: 12728
		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123528", Offset = "0x1123528")]
		public long end_timestamp;
	}
}
