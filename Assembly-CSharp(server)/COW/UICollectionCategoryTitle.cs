using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001524 RID: 5412
	[Token(Token = "0x2001524")]
	public class UICollectionCategoryTitle : MonoBehaviour, UITable2.IUITable2Item
	{
		// Token: 0x06005CFB RID: 23803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0x2098058", Offset = "0x2098058", VA = "0x7BBC898058", Slot = "5")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0x2098120", Offset = "0x2098120", VA = "0x7BBC898120", Slot = "4")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0x20981B8", Offset = "0x20981B8", VA = "0x7BBC8981B8", Slot = "6")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0x20981F4", Offset = "0x20981F4", VA = "0x7BBC8981F4")]
		public UICollectionCategoryTitle()
		{
		}

		// Token: 0x04007ED7 RID: 32471
		[Token(Token = "0x4007ED7")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Name;
	}
}
