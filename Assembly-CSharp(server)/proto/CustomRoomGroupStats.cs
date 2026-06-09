using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000688 RID: 1672
	[Token(Token = "0x2000688")]
	[ProtoContract]
	public class CustomRoomGroupStats
	{
		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x21B93CC", Offset = "0x21B93CC", VA = "0x7BBC9B93CC")]
		public CustomRoomGroupStats()
		{
		}

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B60", Offset = "0x1108B60")]
		public ulong group_id;

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B74", Offset = "0x1108B74")]
		public uint rank;

		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B88", Offset = "0x1108B88")]
		public uint score;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108B9C", Offset = "0x1108B9C")]
		public List<CustomRoomPlayerStats> members;

		// Token: 0x040020F2 RID: 8434
		[Token(Token = "0x40020F2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108BB0", Offset = "0x1108BB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108BB0", Offset = "0x1108BB0")]
		public string name;
	}
}
