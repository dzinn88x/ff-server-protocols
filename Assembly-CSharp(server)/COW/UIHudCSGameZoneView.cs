using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B7 RID: 9655
	[Token(Token = "0x20025B7")]
	public class UIHudCSGameZoneView : MonoBehaviour
	{
		// Token: 0x0600C69F RID: 50847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69F")]
		[Address(RVA = "0x19BA9C4", Offset = "0x19BA9C4", VA = "0x7BBC1BA9C4")]
		public void Init(uint zoneIdx)
		{
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A0")]
		[Address(RVA = "0x19BAA8C", Offset = "0x19BAA8C", VA = "0x7BBC1BAA8C")]
		private void OnZoneChanged(params object[] data)
		{
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A1")]
		[Address(RVA = "0x19BAB50", Offset = "0x19BAB50", VA = "0x7BBC1BAB50")]
		public UIHudCSGameZoneView()
		{
		}

		// Token: 0x0400F934 RID: 63796
		[Token(Token = "0x400F934")]
		[FieldOffset(Offset = "0x18")]
		public UISprite Zone;

		// Token: 0x0400F935 RID: 63797
		[Token(Token = "0x400F935")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ZoneIndex;
	}
}
