using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001635 RID: 5685
	[Token(Token = "0x2001635")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFDFC", Offset = "0x10EFDFC")]
	public class UIPVEWeaponPropertyController : UIBaseController
	{
		// Token: 0x0600666A RID: 26218 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		[Token(Token = "0x600666A")]
		[Address(RVA = "0x16E87C4", Offset = "0x16E87C4", VA = "0x7BBBEE87C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666B")]
		[Address(RVA = "0x16E8814", Offset = "0x16E8814", VA = "0x7BBBEE8814", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666C")]
		[Address(RVA = "0x16E89F8", Offset = "0x16E89F8", VA = "0x7BBBEE89F8")]
		public void RefreshWeaponPropertyScore(uint itemid, bool showDot = true, bool showBg = false)
		{
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600666D")]
		[Address(RVA = "0x16E9200", Offset = "0x16E9200", VA = "0x7BBBEE9200")]
		private string GetPropertyName(int idx)
		{
			return null;
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666E")]
		[Address(RVA = "0x16E9548", Offset = "0x16E9548", VA = "0x7BBBEE9548")]
		public UIPVEWeaponPropertyController()
		{
		}

		// Token: 0x04008429 RID: 33833
		[Token(Token = "0x4008429")]
		[FieldOffset(Offset = "0x58")]
		private UIPVEWeaponPropertyView m_View;

		// Token: 0x0400842A RID: 33834
		[Token(Token = "0x400842A")]
		[FieldOffset(Offset = "0x60")]
		private uint m_SelectedWeaponId;

		// Token: 0x0400842B RID: 33835
		[Token(Token = "0x400842B")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_PropertyList;

		// Token: 0x02001636 RID: 5686
		[Token(Token = "0x2001636")]
		public struct PVEProperty
		{
			// Token: 0x0600666F RID: 26223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600666F")]
			[Address(RVA = "0x11F0440", Offset = "0x11F0440", VA = "0x7BBB9F0440")]
			public PVEProperty(string desc, int v, int b)
			{
			}

			// Token: 0x0400842C RID: 33836
			[Token(Token = "0x400842C")]
			[FieldOffset(Offset = "0x0")]
			public string description;

			// Token: 0x0400842D RID: 33837
			[Token(Token = "0x400842D")]
			[FieldOffset(Offset = "0x8")]
			public int property_value;

			// Token: 0x0400842E RID: 33838
			[Token(Token = "0x400842E")]
			[FieldOffset(Offset = "0xC")]
			public int block_num;
		}
	}
}
