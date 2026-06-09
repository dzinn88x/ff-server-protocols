using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
public class UIClanPrivilegeItemView : MonoBehaviour
{
	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000054")]
	public string title
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1C9E220", Offset = "0x1C9E220", VA = "0x7BBC49E220")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1C9E1E8", Offset = "0x1C9E1E8", VA = "0x7BBC49E1E8")]
		set
		{
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000641 RID: 1601 RVA: 0x00003240 File Offset: 0x00001440
	// (set) Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000055")]
	public float curBonus
	{
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1C9E360", Offset = "0x1C9E360", VA = "0x7BBC49E360")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1C9E250", Offset = "0x1C9E250", VA = "0x7BBC49E250")]
		set
		{
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000643 RID: 1603 RVA: 0x00003258 File Offset: 0x00001458
	// (set) Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000056")]
	public float nextBonus
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1C9E48C", Offset = "0x1C9E48C", VA = "0x7BBC49E48C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1C9E368", Offset = "0x1C9E368", VA = "0x7BBC49E368")]
		set
		{
		}
	}

	// Token: 0x17000057 RID: 87
	// (set) Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000057")]
	public bool hasNextLevel
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1C9E494", Offset = "0x1C9E494", VA = "0x7BBC49E494")]
		set
		{
		}
	}

	// Token: 0x17000058 RID: 88
	// (set) Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000058")]
	public string iconName
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1C9E4E4", Offset = "0x1C9E4E4", VA = "0x7BBC49E4E4")]
		set
		{
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x1C9E594", Offset = "0x1C9E594", VA = "0x7BBC49E594")]
	public void Show()
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x1C9E5CC", Offset = "0x1C9E5CC", VA = "0x7BBC49E5CC")]
	public void Hide()
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x1C9E620", Offset = "0x1C9E620", VA = "0x7BBC49E620")]
	public UIClanPrivilegeItemView()
	{
	}

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x18")]
	private float _curBonus;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x1C")]
	private float _nextBonus;

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x20")]
	public int _privilegeType;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UILabel _titleLabel;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UILabel _curBonusLabel;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UILabel _nextBonusLabel;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UISprite _icon;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	private const string _bonusFormat = "+{0}";
}
