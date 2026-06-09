using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	[ProtoContract]
	public class CSBuyChatItemsReq
	{
		// Token: 0x0600248D RID: 9357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x21B04EC", Offset = "0x21B04EC", VA = "0x7BBC9B04EC")]
		public CSBuyChatItemsReq()
		{
		}

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DBEC", Offset = "0x110DBEC")]
		public uint currency_type;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC00", Offset = "0x110DC00")]
		public uint item_id;
	}
}
