using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	[ProtoContract]
	public class CSGetEPTreasureBoxRewardRes
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x21B32DC", Offset = "0x21B32DC", VA = "0x7BBC9B32DC")]
		public CSGetEPTreasureBoxRewardRes()
		{
		}

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11187B8", Offset = "0x11187B8")]
		public uint treasurebox_id;
	}
}
