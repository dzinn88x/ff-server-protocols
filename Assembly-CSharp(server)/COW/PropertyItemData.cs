using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BE9 RID: 7145
	[Token(Token = "0x2001BE9")]
	public class PropertyItemData
	{
		// Token: 0x06009B28 RID: 39720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B28")]
		[Address(RVA = "0x174FD30", Offset = "0x174FD30", VA = "0x7BBBF4FD30")]
		public PropertyItemData()
		{
		}

		// Token: 0x0400A197 RID: 41367
		[Token(Token = "0x400A197")]
		[FieldOffset(Offset = "0x10")]
		public List<int> Levels;

		// Token: 0x0400A198 RID: 41368
		[Token(Token = "0x400A198")]
		[FieldOffset(Offset = "0x18")]
		public WeaponSkinUpgradeInfoData FeatureData;
	}
}
