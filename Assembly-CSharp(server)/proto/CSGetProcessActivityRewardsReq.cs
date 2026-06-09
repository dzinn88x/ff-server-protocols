using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093B RID: 2363
	[Token(Token = "0x200093B")]
	[ProtoContract]
	public class CSGetProcessActivityRewardsReq
	{
		// Token: 0x06002649 RID: 9801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x21B5634", Offset = "0x21B5634", VA = "0x7BBC9B5634")]
		public CSGetProcessActivityRewardsReq()
		{
		}

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118E20", Offset = "0x1118E20")]
		public uint process_id;
	}
}
