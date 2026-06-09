using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	[ProtoContract]
	public class CSPlayerSettingsReq
	{
		// Token: 0x060023F6 RID: 9206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x21B6F18", Offset = "0x21B6F18", VA = "0x7BBC9B6F18")]
		public CSPlayerSettingsReq()
		{
		}

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109B50", Offset = "0x1109B50")]
		public byte[] settings;

		// Token: 0x040022A0 RID: 8864
		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109B64", Offset = "0x1109B64")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109B64", Offset = "0x1109B64")]
		public string version;

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109BB4", Offset = "0x1109BB4")]
		public SettingsTransferStatus transfer_status;
	}
}
