using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x20007C1")]
	[ProtoContract]
	public class CSGetActivityInfoRes
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x21B1B08", Offset = "0x21B1B08", VA = "0x7BBC9B1B08")]
		public CSGetActivityInfoRes()
		{
		}

		// Token: 0x0400260D RID: 9741
		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EF38", Offset = "0x110EF38")]
		public List<ActivityInfo> activitys;
	}
}
