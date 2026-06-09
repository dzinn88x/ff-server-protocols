using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D0 RID: 2256
	[Token(Token = "0x20008D0")]
	[ProtoContract]
	public class CSGetMysteryShopInfoRes
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x21B4ED4", Offset = "0x21B4ED4", VA = "0x7BBC9B4ED4")]
		public CSGetMysteryShopInfoRes()
		{
		}

		// Token: 0x04002A4C RID: 10828
		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C4C", Offset = "0x1116C4C")]
		public ulong account_id;

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C60", Offset = "0x1116C60")]
		public uint discount;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C74", Offset = "0x1116C74")]
		public uint cur_pool_id;

		// Token: 0x04002A4F RID: 10831
		[Token(Token = "0x4002A4F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C88", Offset = "0x1116C88")]
		public uint another_pool_id;

		// Token: 0x04002A50 RID: 10832
		[Token(Token = "0x4002A50")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116C9C", Offset = "0x1116C9C")]
		public bool switch_open;

		// Token: 0x04002A51 RID: 10833
		[Token(Token = "0x4002A51")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116CB0", Offset = "0x1116CB0")]
		public uint discount_show;
	}
}
