using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6E RID: 2670
	[Token(Token = "0x2000A6E")]
	[ProtoContract]
	public class TreasureTable
	{
		// Token: 0x06002778 RID: 10104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x24A1354", Offset = "0x24A1354", VA = "0x7BBCCA1354")]
		public TreasureTable()
		{
		}

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121CDC", Offset = "0x1121CDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121CDC", Offset = "0x1121CDC")]
		public string region;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121D2C", Offset = "0x1121D2C")]
		public uint id;

		// Token: 0x040030DD RID: 12509
		[Token(Token = "0x40030DD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121D40", Offset = "0x1121D40")]
		public uint item_id;

		// Token: 0x040030DE RID: 12510
		[Token(Token = "0x40030DE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121D54", Offset = "0x1121D54")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121D54", Offset = "0x1121D54")]
		public string name;

		// Token: 0x040030DF RID: 12511
		[Token(Token = "0x40030DF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121DA4", Offset = "0x1121DA4")]
		public uint start_time;

		// Token: 0x040030E0 RID: 12512
		[Token(Token = "0x40030E0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121DB8", Offset = "0x1121DB8")]
		public uint end_time;

		// Token: 0x040030E1 RID: 12513
		[Token(Token = "0x40030E1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121DCC", Offset = "0x1121DCC")]
		public uint quantity;

		// Token: 0x040030E2 RID: 12514
		[Token(Token = "0x40030E2")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121DE0", Offset = "0x1121DE0")]
		public uint daily_quantity;

		// Token: 0x040030E3 RID: 12515
		[Token(Token = "0x40030E3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121DF4", Offset = "0x1121DF4")]
		public bool is_festival_item;
	}
}
