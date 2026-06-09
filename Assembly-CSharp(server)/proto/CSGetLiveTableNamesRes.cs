using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	[ProtoContract]
	public class CSGetLiveTableNamesRes
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F1")]
		[Address(RVA = "0x21B4790", Offset = "0x21B4790", VA = "0x7BBC9B4790")]
		public CSGetLiveTableNamesRes()
		{
		}

		// Token: 0x04002A88 RID: 10888
		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117318", Offset = "0x1117318")]
		public List<LiveTableNameDesc> live_table_name_list;
	}
}
