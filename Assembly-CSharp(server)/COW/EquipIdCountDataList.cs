using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001127 RID: 4391
	[Token(Token = "0x2001127")]
	public class EquipIdCountDataList
	{
		// Token: 0x060044A6 RID: 17574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x1B87668", Offset = "0x1B87668", VA = "0x7BBC387668")]
		public static EquipIdCountDataList Parse(string s)
		{
			return null;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A7")]
		[Address(RVA = "0x1B87804", Offset = "0x1B87804", VA = "0x7BBC387804")]
		public EquipIdCountDataList()
		{
		}

		// Token: 0x040054D0 RID: 21712
		[Token(Token = "0x40054D0")]
		[FieldOffset(Offset = "0x10")]
		public List<EquipIdCountData> Equips;
	}
}
