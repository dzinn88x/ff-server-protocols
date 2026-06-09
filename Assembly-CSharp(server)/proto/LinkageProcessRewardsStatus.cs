using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	[ProtoContract]
	public class LinkageProcessRewardsStatus
	{
		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x21BBC40", Offset = "0x21BBC40", VA = "0x7BBC9BBC40")]
		public LinkageProcessRewardsStatus()
		{
		}

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11299DC", Offset = "0x11299DC")]
		public uint process_id;

		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11299F0", Offset = "0x11299F0")]
		public EPProcess_Status status;
	}
}
