using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008EC RID: 2284
	[Token(Token = "0x20008EC")]
	[ProtoContract]
	public class CSGetManualWeaponRewardReq
	{
		// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x21B4ACC", Offset = "0x21B4ACC", VA = "0x7BBC9B4ACC")]
		public CSGetManualWeaponRewardReq()
		{
		}

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117494", Offset = "0x1117494")]
		public uint quantity_period;
	}
}
