using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	[ProtoContract]
	public class CSAnnouncementReq
	{
		// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x21B0348", Offset = "0x21B0348", VA = "0x7BBC9B0348")]
		public CSAnnouncementReq()
		{
		}

		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111774", Offset = "0x1111774")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111774", Offset = "0x1111774")]
		public string language;

		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11117C4", Offset = "0x11117C4")]
		public EAnnouncement.Os os;

		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11117D8", Offset = "0x11117D8")]
		public EAnnouncement.AndroidChannel android_channel;
	}
}
