using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	[ProtoContract]
	public class CustomRoomPlayerStats
	{
		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x21B9450", Offset = "0x21B9450", VA = "0x7BBC9B9450")]
		public CustomRoomPlayerStats()
		{
		}

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B10", Offset = "0x1108B10")]
		public ulong account_id;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B24", Offset = "0x1108B24")]
		public uint kills;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B38", Offset = "0x1108B38")]
		public uint headshot;

		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B4C", Offset = "0x1108B4C")]
		public uint damage;
	}
}
