using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A1F RID: 6687
	[Token(Token = "0x2001A1F")]
	public class WeaponRackItemData
	{
		// Token: 0x06008C06 RID: 35846 RVA: 0x00025650 File Offset: 0x00023850
		[Token(Token = "0x6008C06")]
		[Address(RVA = "0x179D000", Offset = "0x179D000", VA = "0x7BBBF9D000")]
		public int CompareTo(WeaponRackItemData other)
		{
			return 0;
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C07")]
		[Address(RVA = "0x179D130", Offset = "0x179D130", VA = "0x7BBBF9D130")]
		public WeaponRackItemData()
		{
		}

		// Token: 0x040098B8 RID: 39096
		[Token(Token = "0x40098B8")]
		[FieldOffset(Offset = "0x10")]
		public WeaponSkinBaseInfo Info;

		// Token: 0x040098B9 RID: 39097
		[Token(Token = "0x40098B9")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEquipped;
	}
}
