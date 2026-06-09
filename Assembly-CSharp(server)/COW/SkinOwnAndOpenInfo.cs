using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200202E RID: 8238
	[Token(Token = "0x200202E")]
	public class SkinOwnAndOpenInfo
	{
		// Token: 0x0600B7AD RID: 47021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7AD")]
		[Address(RVA = "0x1B39250", Offset = "0x1B39250", VA = "0x7BBC339250")]
		public SkinOwnAndOpenInfo()
		{
		}

		// Token: 0x0400B9B7 RID: 47543
		[Token(Token = "0x400B9B7")]
		[FieldOffset(Offset = "0x10")]
		public WeaponSkinData SkinData;

		// Token: 0x0400B9B8 RID: 47544
		[Token(Token = "0x400B9B8")]
		[FieldOffset(Offset = "0x18")]
		public bool IsOpening;

		// Token: 0x0400B9B9 RID: 47545
		[Token(Token = "0x400B9B9")]
		[FieldOffset(Offset = "0x19")]
		public bool HaveOwned;

		// Token: 0x0400B9BA RID: 47546
		[Token(Token = "0x400B9BA")]
		[FieldOffset(Offset = "0x1A")]
		public bool CanExchange;

		// Token: 0x0400B9BB RID: 47547
		[Token(Token = "0x400B9BB")]
		[FieldOffset(Offset = "0x20")]
		public List<WeaponSkinFeature> FeatureInThisLevel;

		// Token: 0x0400B9BC RID: 47548
		[Token(Token = "0x400B9BC")]
		[FieldOffset(Offset = "0x28")]
		public List<WeaponSkinFeature> Features;

		// Token: 0x0400B9BD RID: 47549
		[Token(Token = "0x400B9BD")]
		[FieldOffset(Offset = "0x30")]
		public uint RewardItem;
	}
}
