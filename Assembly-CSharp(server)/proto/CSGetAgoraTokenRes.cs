using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	[ProtoContract]
	public class CSGetAgoraTokenRes
	{
		// Token: 0x06002589 RID: 9609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x21B1D0C", Offset = "0x21B1D0C", VA = "0x7BBC9B1D0C")]
		public CSGetAgoraTokenRes()
		{
		}

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111354C", Offset = "0x111354C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111354C", Offset = "0x111354C")]
		public string token;
	}
}
