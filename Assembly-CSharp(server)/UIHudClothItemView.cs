using System;
using COW;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x2000147")]
public class UIHudClothItemView : MonoBehaviour
{
	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1CA9F18", Offset = "0x1CA9F18", VA = "0x7BBC4A9F18")]
	private void Start()
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1CA9FCC", Offset = "0x1CA9FCC", VA = "0x7BBC4A9FCC")]
	public void SetData(InventoryClothInfo clothinfo)
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1CAA0FC", Offset = "0x1CAA0FC", VA = "0x7BBC4AA0FC")]
	private void OnClickItem()
	{
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x1CAA100", Offset = "0x1CAA100", VA = "0x7BBC4AA100")]
	public UIHudClothItemView()
	{
	}

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel itemID;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel itemName;

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton clickButton;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x30")]
	private uint itemid;
}
