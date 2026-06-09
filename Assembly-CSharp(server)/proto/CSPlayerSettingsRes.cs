using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	[ProtoContract]
	public class CSPlayerSettingsRes
	{
		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x21B6F74", Offset = "0x21B6F74", VA = "0x7BBC9B6F74")]
		public CSPlayerSettingsRes()
		{
		}

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109BC8", Offset = "0x1109BC8")]
		public byte[] settings;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109BDC", Offset = "0x1109BDC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109BDC", Offset = "0x1109BDC")]
		public string version;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109C2C", Offset = "0x1109C2C")]
		public SettingsTransferStatus transfer_status;
	}
}
