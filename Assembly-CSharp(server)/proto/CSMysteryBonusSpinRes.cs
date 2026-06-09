using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	[ProtoContract]
	public class CSMysteryBonusSpinRes
	{
		// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x21B6BE8", Offset = "0x21B6BE8", VA = "0x7BBC9B6BE8")]
		public CSMysteryBonusSpinRes()
		{
		}

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E2A4", Offset = "0x110E2A4")]
		public uint bonus_percent;
	}
}
