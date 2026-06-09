using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0E RID: 7694
	[Token(Token = "0x2001E0E")]
	public class WeaponSkinBaseInfo : CollectionBaseInfo
	{
		// Token: 0x0600A844 RID: 43076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A844")]
		[Address(RVA = "0x179D47C", Offset = "0x179D47C", VA = "0x7BBBF9D47C")]
		public WeaponSkinBaseInfo()
		{
		}

		// Token: 0x0600A845 RID: 43077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A845")]
		[Address(RVA = "0x179D484", Offset = "0x179D484", VA = "0x7BBBF9D484")]
		public WeaponSkinBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A846 RID: 43078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A846")]
		[Address(RVA = "0x179D6E8", Offset = "0x179D6E8", VA = "0x7BBBF9D6E8")]
		public static implicit operator WeaponSkinBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A847")]
		[Address(RVA = "0x179D758", Offset = "0x179D758", VA = "0x7BBBF9D758")]
		public static implicit operator WeaponSkinBaseInfo(WeaponSkinData data)
		{
			return null;
		}

		// Token: 0x0400ADB1 RID: 44465
		[Token(Token = "0x400ADB1")]
		[FieldOffset(Offset = "0x38")]
		public WeaponSkinData weapon_skin_data;

		// Token: 0x0400ADB2 RID: 44466
		[Token(Token = "0x400ADB2")]
		[FieldOffset(Offset = "0x40")]
		public uint weapon_id;
	}
}
