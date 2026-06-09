using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	[ProtoContract]
	public class MysteryBonusInfo
	{
		// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x249E604", Offset = "0x249E604", VA = "0x7BBCC9E604")]
		public MysteryBonusInfo()
		{
		}

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E150", Offset = "0x110E150")]
		public uint bonus_max;

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E164", Offset = "0x110E164")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110E164", Offset = "0x110E164")]
		public string start_time;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E1B4", Offset = "0x110E1B4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110E1B4", Offset = "0x110E1B4")]
		public string end_time;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E204", Offset = "0x110E204")]
		public uint start_time_stamp;

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E218", Offset = "0x110E218")]
		public uint end_time_stamp;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E22C", Offset = "0x110E22C")]
		public uint bonus_percent;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E240", Offset = "0x110E240")]
		public uint bonus_topup_times;
	}
}
