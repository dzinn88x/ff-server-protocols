using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	[ProtoContract]
	public class GameDropRate
	{
		// Token: 0x06002777 RID: 10103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x21BA720", Offset = "0x21BA720", VA = "0x7BBC9BA720")]
		public GameDropRate()
		{
		}

		// Token: 0x040030D8 RID: 12504
		[Token(Token = "0x40030D8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121CA0", Offset = "0x1121CA0")]
		public uint drop_id;

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121CB4", Offset = "0x1121CB4")]
		public uint drop_count;

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121CC8", Offset = "0x1121CC8")]
		public uint weight;
	}
}
