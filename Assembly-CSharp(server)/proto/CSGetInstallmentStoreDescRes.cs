using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	[ProtoContract]
	public class CSGetInstallmentStoreDescRes
	{
		// Token: 0x060025D3 RID: 9683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x21B4324", Offset = "0x21B4324", VA = "0x7BBC9B4324")]
		public CSGetInstallmentStoreDescRes()
		{
		}

		// Token: 0x04002A2E RID: 10798
		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11168C8", Offset = "0x11168C8")]
		public List<InstallmentStoreDesc> installment_stores;
	}
}
