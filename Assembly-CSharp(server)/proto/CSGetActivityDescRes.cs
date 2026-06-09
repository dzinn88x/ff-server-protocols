using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x20007C0")]
	[ProtoContract]
	public class CSGetActivityDescRes
	{
		// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x21B19CC", Offset = "0x21B19CC", VA = "0x7BBC9B19CC")]
		public CSGetActivityDescRes()
		{
		}

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EEC0", Offset = "0x110EEC0")]
		public List<ClientActivityDesc> activity_descs;

		// Token: 0x04002608 RID: 9736
		[Token(Token = "0x4002608")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EED4", Offset = "0x110EED4")]
		public List<ActivityFestivalDesc> activity_festivals;

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EEE8", Offset = "0x110EEE8")]
		public List<ClientActivityEntranceSwitchDesc> entrance_list;

		// Token: 0x0400260A RID: 9738
		[Token(Token = "0x400260A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EEFC", Offset = "0x110EEFC")]
		public List<ClientActivityBingoInfoDesc> bingo_info;

		// Token: 0x0400260B RID: 9739
		[Token(Token = "0x400260B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EF10", Offset = "0x110EF10")]
		public List<ActivityBingoRewardsDesc> bingo_rewards_info;

		// Token: 0x0400260C RID: 9740
		[Token(Token = "0x400260C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EF24", Offset = "0x110EF24")]
		public List<EventIntegretPageDesc> event_integret_pages;
	}
}
