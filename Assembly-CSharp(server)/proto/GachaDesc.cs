using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	[ProtoContract]
	public class GachaDesc
	{
		// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x21BA528", Offset = "0x21BA528", VA = "0x7BBC9BA528")]
		public GachaDesc()
		{
		}

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11129D0", Offset = "0x11129D0")]
		public uint chest_id;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11129E4", Offset = "0x11129E4")]
		public ClientChestType chest_type;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11129F8", Offset = "0x11129F8")]
		public List<GachaShowItemsWithJackpot> item_list_with_jackpot;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A0C", Offset = "0x1112A0C")]
		public List<ExtraRewardDesc> extra_rewards;
	}
}
