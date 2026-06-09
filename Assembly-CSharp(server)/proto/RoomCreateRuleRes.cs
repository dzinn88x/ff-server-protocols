using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	[ProtoContract]
	public class RoomCreateRuleRes
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x24A0348", Offset = "0x24A0348", VA = "0x7BBCCA0348")]
		public RoomCreateRuleRes()
		{
		}

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB54", Offset = "0x111EB54")]
		public List<RoomCreateRuleDropDesc> room_create_rule_drops;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB68", Offset = "0x111EB68")]
		public List<RoomCreateRuleDesc> room_create_rules;
	}
}
