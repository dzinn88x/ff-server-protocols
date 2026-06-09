using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	[ProtoContract]
	public class WarmGameInfo
	{
		// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x24A1840", Offset = "0x24A1840", VA = "0x7BBCCA1840")]
		public WarmGameInfo()
		{
		}

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107454", Offset = "0x1107454")]
		public uint type;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107468", Offset = "0x1107468")]
		public uint level;
	}
}
