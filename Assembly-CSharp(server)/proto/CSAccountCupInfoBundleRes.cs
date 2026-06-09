using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	[ProtoContract]
	public class CSAccountCupInfoBundleRes
	{
		// Token: 0x0600244B RID: 9291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x21B00A0", Offset = "0x21B00A0", VA = "0x7BBC9B00A0")]
		public CSAccountCupInfoBundleRes()
		{
		}

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA80", Offset = "0x110CA80")]
		public List<CSAccountCupInfoRes> account_infos;
	}
}
