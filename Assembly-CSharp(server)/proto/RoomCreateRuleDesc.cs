using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	[ProtoContract]
	public class RoomCreateRuleDesc
	{
		// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x24A02E0", Offset = "0x24A02E0", VA = "0x7BBCCA02E0")]
		public RoomCreateRuleDesc()
		{
		}

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E884", Offset = "0x111E884")]
		public uint map_id;

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E898", Offset = "0x111E898")]
		public uint game_mode;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E8AC", Offset = "0x111E8AC")]
		public uint group_mode;

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E8C0", Offset = "0x111E8C0")]
		public uint[] members;

		// Token: 0x04002F18 RID: 12056
		[Token(Token = "0x4002F18")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E8FC", Offset = "0x111E8FC")]
		public uint[] spectators;

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E938", Offset = "0x111E938")]
		public uint room_type;

		// Token: 0x04002F1A RID: 12058
		[Token(Token = "0x4002F1A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E94C", Offset = "0x111E94C")]
		public uint min_member_cnt;
	}
}
