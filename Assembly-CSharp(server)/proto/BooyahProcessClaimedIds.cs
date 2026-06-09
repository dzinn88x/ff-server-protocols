using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	[ProtoContract]
	public class BooyahProcessClaimedIds
	{
		// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x21AFE1C", Offset = "0x21AFE1C", VA = "0x7BBC9AFE1C")]
		public BooyahProcessClaimedIds()
		{
		}

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106CAC", Offset = "0x1106CAC")]
		public uint[] ids;
	}
}
