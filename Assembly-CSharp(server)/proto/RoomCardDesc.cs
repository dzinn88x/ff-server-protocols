using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	[ProtoContract]
	public class RoomCardDesc
	{
		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x24A02D8", Offset = "0x24A02D8", VA = "0x7BBCCA02D8")]
		public RoomCardDesc()
		{
		}

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB7C", Offset = "0x111EB7C")]
		public uint card_id;

		// Token: 0x04002F2E RID: 12078
		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB90", Offset = "0x111EB90")]
		public ERoom.CardType card_type;
	}
}
