using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000849 RID: 2121
	[Token(Token = "0x2000849")]
	[ProtoContract]
	public class CSScrollMarqueeReq
	{
		// Token: 0x0600255E RID: 9566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x21B7508", Offset = "0x21B7508", VA = "0x7BBC9B7508")]
		public CSScrollMarqueeReq()
		{
		}

		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111800", Offset = "0x1111800")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111800", Offset = "0x1111800")]
		public string lang_name;

		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111850", Offset = "0x1111850")]
		public EAnnouncement.Os os;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111864", Offset = "0x1111864")]
		public EAnnouncement.AndroidChannel android_channel;
	}
}
