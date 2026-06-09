using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x2000848")]
	[ProtoContract]
	public class CSAnnouncementRes
	{
		// Token: 0x0600255D RID: 9565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x21B03A4", Offset = "0x21B03A4", VA = "0x7BBC9B03A4")]
		public CSAnnouncementRes()
		{
		}

		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11117EC", Offset = "0x11117EC")]
		public List<AnnouncementDesc> announcements;
	}
}
