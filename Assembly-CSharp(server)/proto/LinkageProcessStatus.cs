using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFB RID: 2811
	[Token(Token = "0x2000AFB")]
	[ProtoContract]
	public class LinkageProcessStatus
	{
		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x21BBC50", Offset = "0x21BBC50", VA = "0x7BBC9BBC50")]
		public LinkageProcessStatus()
		{
		}

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11299C8", Offset = "0x11299C8")]
		public List<LinkageProcessRewardsStatus> process_status;
	}
}
