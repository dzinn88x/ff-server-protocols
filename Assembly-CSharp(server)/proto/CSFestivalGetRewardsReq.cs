using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x20007BA")]
	[ProtoContract]
	public class CSFestivalGetRewardsReq
	{
		// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x21B13D8", Offset = "0x21B13D8", VA = "0x7BBC9B13D8")]
		public CSFestivalGetRewardsReq()
		{
		}

		// Token: 0x040025F7 RID: 9719
		[Token(Token = "0x40025F7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ED44", Offset = "0x110ED44")]
		public uint id;
	}
}
