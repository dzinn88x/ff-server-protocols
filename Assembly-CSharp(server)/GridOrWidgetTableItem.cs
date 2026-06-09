using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012A RID: 298
[Token(Token = "0x200012A")]
public class GridOrWidgetTableItem : BaseTableItem
{
	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x2750194", Offset = "0x2750194", VA = "0x7BBCF50194", Slot = "8")]
	public override void Init()
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x27502AC", Offset = "0x27502AC", VA = "0x7BBCF502AC", Slot = "9")]
	public override void UnInit()
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x275038C", Offset = "0x275038C", VA = "0x7BBCF5038C", Slot = "10")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x2750514", Offset = "0x2750514", VA = "0x7BBCF50514")]
	public GridOrWidgetTableItem()
	{
	}

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_WidgetGO;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GridTableItem m_Grid;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ELayoutType m_SizType;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x40")]
	private ILayoutTableItem m_Widget;
}
