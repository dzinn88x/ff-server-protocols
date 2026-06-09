using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	[ProtoContract]
	public class VeteranRewardItem
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x24A15FC", Offset = "0x24A15FC", VA = "0x7BBCCA15FC")]
		public VeteranRewardItem()
		{
		}

		// Token: 0x040025F8 RID: 9720
		[Token(Token = "0x40025F8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ED58", Offset = "0x110ED58")]
		public VeteranRewardDesc desc;

		// Token: 0x040025F9 RID: 9721
		[Token(Token = "0x40025F9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ED6C", Offset = "0x110ED6C")]
		public uint status;
	}
}
