using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	[ProtoContract]
	public class CupTeamInfo
	{
		// Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x21B92BC", Offset = "0x21B92BC", VA = "0x7BBC9B92BC")]
		public CupTeamInfo()
		{
		}

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D340", Offset = "0x110D340")]
		public ulong team_id;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D354", Offset = "0x110D354")]
		public uint cup_type;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D368", Offset = "0x110D368")]
		public uint cup_id;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D37C", Offset = "0x110D37C")]
		public uint tier;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D390", Offset = "0x110D390")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D390", Offset = "0x110D390")]
		public string team_name;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D3E0", Offset = "0x110D3E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D3E0", Offset = "0x110D3E0")]
		public string country_or_area;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D430", Offset = "0x110D430")]
		public uint head_pic;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D444", Offset = "0x110D444")]
		public uint banner_id;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D458", Offset = "0x110D458")]
		public List<CupBattleRecord> records;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D46C", Offset = "0x110D46C")]
		public bool is_locked;

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D480", Offset = "0x110D480")]
		public ulong captain_id;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D494", Offset = "0x110D494")]
		public uint member_num;

		// Token: 0x0400250F RID: 9487
		[Token(Token = "0x400250F")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D4A8", Offset = "0x110D4A8")]
		public uint win_count;

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x4002510")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D4BC", Offset = "0x110D4BC")]
		public bool[] battle_record;
	}
}
