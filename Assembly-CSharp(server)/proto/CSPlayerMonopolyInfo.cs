using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A1 RID: 2465
	[Token(Token = "0x20009A1")]
	[ProtoContract]
	public class CSPlayerMonopolyInfo
	{
		// Token: 0x060026AF RID: 9903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x21B6E84", Offset = "0x21B6E84", VA = "0x7BBC9B6E84")]
		public CSPlayerMonopolyInfo()
		{
		}

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A2C0", Offset = "0x111A2C0")]
		public ulong account_id;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A2D4", Offset = "0x111A2D4")]
		public uint dice_number;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A2E8", Offset = "0x111A2E8")]
		public EMiniGame.MonopolyPlayerStatus player_status;

		// Token: 0x04002C82 RID: 11394
		[Token(Token = "0x4002C82")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A2FC", Offset = "0x111A2FC")]
		public uint current_index;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A310", Offset = "0x111A310")]
		public uint total_cycles;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A324", Offset = "0x111A324")]
		public MonopolyBoard monopoly_board;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A338", Offset = "0x111A338")]
		public List<TriggeredEvent> events;

		// Token: 0x04002C86 RID: 11398
		[Token(Token = "0x4002C86")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A34C", Offset = "0x111A34C")]
		public uint current_event;

		// Token: 0x04002C87 RID: 11399
		[Token(Token = "0x4002C87")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A360", Offset = "0x111A360")]
		public uint current_activity;

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A374", Offset = "0x111A374")]
		public uint buff_remain_time;
	}
}
