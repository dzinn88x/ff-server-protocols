using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200085D RID: 2141
	[Token(Token = "0x200085D")]
	[ProtoContract]
	public class CSLotteryRes
	{
		// Token: 0x0600256B RID: 9579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x21B681C", Offset = "0x21B681C", VA = "0x7BBC9B681C")]
		public CSLotteryRes()
		{
		}

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112520", Offset = "0x1112520")]
		public List<ExchangedAward> lottery_goods;

		// Token: 0x04002807 RID: 10247
		[Token(Token = "0x4002807")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112534", Offset = "0x1112534")]
		public List<ExchangedAward> reward_goods;

		// Token: 0x04002808 RID: 10248
		[Token(Token = "0x4002808")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112548", Offset = "0x1112548")]
		public List<ExchangedAward> extra_one_goods;

		// Token: 0x04002809 RID: 10249
		[Token(Token = "0x4002809")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111255C", Offset = "0x111255C")]
		public uint lottery_count_weekly;

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112570", Offset = "0x1112570")]
		public long next_free_time;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112584", Offset = "0x1112584")]
		public uint limit_purchase_count_one;

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112598", Offset = "0x1112598")]
		public uint limit_purchase_count_ten;

		// Token: 0x0400280D RID: 10253
		[Token(Token = "0x400280D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11125AC", Offset = "0x11125AC")]
		public uint not_got_num;

		// Token: 0x0400280E RID: 10254
		[Token(Token = "0x400280E")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11125C0", Offset = "0x11125C0")]
		public uint first_draw_reward_num;

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11125D4", Offset = "0x11125D4")]
		public List<ExchangeItemNum> exchange_item_num;

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11125E8", Offset = "0x11125E8")]
		public bool has_big_reward;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11125FC", Offset = "0x11125FC")]
		public uint[] act_goods_ids;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112638", Offset = "0x1112638")]
		public uint act_progress;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111264C", Offset = "0x111264C")]
		public uint energy_gacha_buff_display_one;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112660", Offset = "0x1112660")]
		public uint energy_gacha_buff_display_ten;
	}
}
