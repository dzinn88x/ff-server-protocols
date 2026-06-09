using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	[ProtoContract]
	public class CSSettingsTransferRes
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x21B7694", Offset = "0x21B7694", VA = "0x7BBC9B7694")]
		public CSSettingsTransferRes()
		{
		}

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109B3C", Offset = "0x1109B3C")]
		public SettingsTransferStatus transfer_status;
	}
}
