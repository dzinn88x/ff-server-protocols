using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	[ProtoContract]
	public class CSDrawClanLuckyBagRes
	{
		// Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x21B0FE4", Offset = "0x21B0FE4", VA = "0x7BBC9B0FE4")]
		public CSDrawClanLuckyBagRes()
		{
		}

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110838", Offset = "0x1110838")]
		public ulong account_id;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111084C", Offset = "0x111084C")]
		public ulong bag_id;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110860", Offset = "0x1110860")]
		public uint get_token_num;
	}
}
