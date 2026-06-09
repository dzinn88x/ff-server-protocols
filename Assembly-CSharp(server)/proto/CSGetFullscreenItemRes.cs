using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	[ProtoContract]
	public class CSGetFullscreenItemRes
	{
		// Token: 0x06002569 RID: 9577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x21B3C84", Offset = "0x21B3C84", VA = "0x7BBC9B3C84")]
		public CSGetFullscreenItemRes()
		{
		}

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112480", Offset = "0x1112480")]
		public List<FullscreenItemDesc> fullscreen_items;
	}
}
