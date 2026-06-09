using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	[ProtoContract]
	public class ChestPriceDesc
	{
		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x21B8410", Offset = "0x21B8410", VA = "0x7BBC9B8410")]
		public ChestPriceDesc()
		{
		}

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124644", Offset = "0x1124644")]
		public uint chest_id;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124658", Offset = "0x1124658")]
		public uint coin_type;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112466C", Offset = "0x112466C")]
		public uint once_price;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124680", Offset = "0x1124680")]
		public uint ten_price;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124694", Offset = "0x1124694")]
		public long limit_start_time;

		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11246A8", Offset = "0x11246A8")]
		public long limit_end_time;

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11246BC", Offset = "0x11246BC")]
		public uint limit_num_one;

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11246D0", Offset = "0x11246D0")]
		public uint[] limit_price_one;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112470C", Offset = "0x112470C")]
		public uint limit_num_ten;

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124720", Offset = "0x1124720")]
		public uint[] limit_price_ten;

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112475C", Offset = "0x112475C")]
		public long discount_start_time;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124770", Offset = "0x1124770")]
		public long discount_end_time;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124784", Offset = "0x1124784")]
		public uint discount_price_one;

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124798", Offset = "0x1124798")]
		public uint discount_price_ten;

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11247AC", Offset = "0x11247AC")]
		public uint[] exchange_itemid;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11247E8", Offset = "0x11247E8")]
		public uint exchange_once_num;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11247FC", Offset = "0x11247FC")]
		public uint exchange_ten_num;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124810", Offset = "0x1124810")]
		public uint free_type;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124824", Offset = "0x1124824")]
		public uint free_cd;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124838", Offset = "0x1124838")]
		public uint once_num;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112484C", Offset = "0x112484C")]
		public uint ten_num;

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124860", Offset = "0x1124860")]
		public uint chest_sub_id;

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124874", Offset = "0x1124874")]
		public uint limit_num;

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124888", Offset = "0x1124888")]
		public uint limit_type;

		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112489C", Offset = "0x112489C")]
		public uint[] multi_once_price;

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11248D8", Offset = "0x11248D8")]
		public uint[] price_one_type;

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124914", Offset = "0x1124914")]
		public uint buff_up_price;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124928", Offset = "0x1124928")]
		public uint buff_reset_price;
	}
}
