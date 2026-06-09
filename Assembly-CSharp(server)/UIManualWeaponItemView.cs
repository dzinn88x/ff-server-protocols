using System;
using COW;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public class UIManualWeaponItemView : MonoBehaviour
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x1CAB520", Offset = "0x1CAB520", VA = "0x7BBC4AB520")]
	private void Start()
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x1CAB61C", Offset = "0x1CAB61C", VA = "0x7BBC4AB61C")]
	public void SetData(ManualWeaponData data, bool hasUnlock, bool isSelect, Action<ManualWeaponData> callback)
	{
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x1CABB64", Offset = "0x1CABB64", VA = "0x7BBC4ABB64")]
	public void ClearData()
	{
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1CABB6C", Offset = "0x1CABB6C", VA = "0x7BBC4ABB6C")]
	public void Show()
	{
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x1CABBA4", Offset = "0x1CABBA4", VA = "0x7BBC4ABBA4")]
	public void Hide()
	{
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x1CABBDC", Offset = "0x1CABBDC", VA = "0x7BBC4ABBDC")]
	public void OnClick()
	{
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1CABCD8", Offset = "0x1CABCD8", VA = "0x7BBC4ABCD8")]
	public void OnClickBadge0()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x1CABE00", Offset = "0x1CABE00", VA = "0x7BBC4ABE00")]
	public UIManualWeaponItemView()
	{
	}

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIButton m_Button;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISprite m_Shadow;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UISprite m_Icon;

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_SelectMark;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_Tag;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x40")]
	public UIButton m_Badge0;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_BadgeSprite0;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x50")]
	private Action<ManualWeaponData> m_OnClickItem;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x58")]
	private ManualWeaponData m_Data;

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 m_OriginSize;
}
