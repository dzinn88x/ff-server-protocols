using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	[ProtoContract]
	public class CSGetBackpackReq
	{
		// Token: 0x06002489 RID: 9353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x21B228C", Offset = "0x21B228C", VA = "0x7BBC9B228C")]
		public CSGetBackpackReq()
		{
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x21B2294", Offset = "0x21B2294", VA = "0x7BBC9B2294", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x21B2390", Offset = "0x21B2390", VA = "0x7BBC9B2390", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DB88", Offset = "0x110DB88")]
		public uint item_type;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DB9C", Offset = "0x110DB9C")]
		public bool is_login;
	}
}
