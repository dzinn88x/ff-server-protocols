using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	[ProtoContract]
	public class CSGetActGachaInfoRes
	{
		// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x21B1868", Offset = "0x21B1868", VA = "0x7BBC9B1868")]
		public CSGetActGachaInfoRes()
		{
		}

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11127A0", Offset = "0x11127A0")]
		public uint[] unlocked_pools;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11127DC", Offset = "0x11127DC")]
		public List<ActIds> act_ids;

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11127F0", Offset = "0x11127F0")]
		public uint act_progress;

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112804", Offset = "0x1112804")]
		public uint[] exchanged_reward_list;
	}
}
