using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B6 RID: 9654
	[Token(Token = "0x20025B6")]
	public class UIHudBombZoneView : MonoBehaviour
	{
		// Token: 0x0600C69D RID: 50845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69D")]
		[Address(RVA = "0x189E368", Offset = "0x189E368", VA = "0x7BBC09E368")]
		public void SetUIData(uint zoneIdx, float scale)
		{
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69E")]
		[Address(RVA = "0x189E44C", Offset = "0x189E44C", VA = "0x7BBC09E44C")]
		public UIHudBombZoneView()
		{
		}

		// Token: 0x0400F931 RID: 63793
		[Token(Token = "0x400F931")]
		[FieldOffset(Offset = "0x18")]
		public UISprite Zone;

		// Token: 0x0400F932 RID: 63794
		[Token(Token = "0x400F932")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ZoneIndex;

		// Token: 0x0400F933 RID: 63795
		[Token(Token = "0x400F933")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;
	}
}
