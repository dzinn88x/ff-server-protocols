using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x20008D2")]
	[ProtoContract]
	public class CSGetMysteryPoolInfoRes
	{
		// Token: 0x060025E0 RID: 9696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x21B4E38", Offset = "0x21B4E38", VA = "0x7BBC9B4E38")]
		public CSGetMysteryPoolInfoRes()
		{
		}

		// Token: 0x04002A54 RID: 10836
		[Token(Token = "0x4002A54")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D28", Offset = "0x1116D28")]
		public ulong account_id;

		// Token: 0x04002A55 RID: 10837
		[Token(Token = "0x4002A55")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D3C", Offset = "0x1116D3C")]
		public List<MysteryPoolStoreItem> normal_reward_list;

		// Token: 0x04002A56 RID: 10838
		[Token(Token = "0x4002A56")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D50", Offset = "0x1116D50")]
		public MysteryPoolStoreItem super_reward;

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D64", Offset = "0x1116D64")]
		public List<ClientMysteryShopSwitchDesc> pool_desc_list;
	}
}
