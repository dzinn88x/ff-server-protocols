using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001126 RID: 4390
	[Token(Token = "0x2001126")]
	public class EquipIdCountData
	{
		// Token: 0x060044A4 RID: 17572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A4")]
		[Address(RVA = "0x1B87430", Offset = "0x1B87430", VA = "0x7BBC387430")]
		public static EquipIdCountData Parse(string s)
		{
			return null;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A5")]
		[Address(RVA = "0x1B87660", Offset = "0x1B87660", VA = "0x7BBC387660")]
		public EquipIdCountData()
		{
		}

		// Token: 0x040054CE RID: 21710
		[Token(Token = "0x40054CE")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054CF RID: 21711
		[Token(Token = "0x40054CF")]
		[FieldOffset(Offset = "0x14")]
		public int Count;
	}
}
