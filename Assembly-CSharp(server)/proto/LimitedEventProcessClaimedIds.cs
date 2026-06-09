using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	[ProtoContract]
	public class LimitedEventProcessClaimedIds
	{
		// Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x21BBA98", Offset = "0x21BBA98", VA = "0x7BBC9BBA98")]
		public LimitedEventProcessClaimedIds()
		{
		}

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106CE8", Offset = "0x1106CE8")]
		public uint[] ids;
	}
}
