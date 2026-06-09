using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001266 RID: 4710
	[Token(Token = "0x2001266")]
	public class AutoFireWeaponData : MonoBehaviour
	{
		// Token: 0x060048F9 RID: 18681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x15539A4", Offset = "0x15539A4", VA = "0x7BBBD539A4")]
		public AutoFireWeaponData()
		{
		}

		// Token: 0x040071E1 RID: 29153
		[Token(Token = "0x40071E1")]
		[FieldOffset(Offset = "0x18")]
		public string ModelResID;

		// Token: 0x040071E2 RID: 29154
		[Token(Token = "0x40071E2")]
		[FieldOffset(Offset = "0x20")]
		public string FireEffectResID;

		// Token: 0x040071E3 RID: 29155
		[Token(Token = "0x40071E3")]
		[FieldOffset(Offset = "0x28")]
		public string GunTraceResID;

		// Token: 0x040071E4 RID: 29156
		[Token(Token = "0x40071E4")]
		[FieldOffset(Offset = "0x30")]
		public Transform ModelContainer;

		// Token: 0x040071E5 RID: 29157
		[Token(Token = "0x40071E5")]
		[FieldOffset(Offset = "0x38")]
		public int Damage;

		// Token: 0x040071E6 RID: 29158
		[Token(Token = "0x40071E6")]
		[FieldOffset(Offset = "0x3C")]
		public int GroupId;
	}
}
