using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	[ProtoContract]
	public class CSDownloadPlayerSettingsReq
	{
		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x21B0F80", Offset = "0x21B0F80", VA = "0x7BBC9B0F80")]
		public CSDownloadPlayerSettingsReq()
		{
		}

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109C40", Offset = "0x1109C40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109C40", Offset = "0x1109C40")]
		public string version;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109C90", Offset = "0x1109C90")]
		public SettingsTransferStatus transfer_status;
	}
}
