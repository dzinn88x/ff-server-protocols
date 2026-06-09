using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class MinWidgetTableItem : BaseTableItem
{
	// Token: 0x060005AD RID: 1453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x228E8F8", Offset = "0x228E8F8", VA = "0x7BBCA8E8F8", Slot = "8")]
	public override void Init()
	{
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x228EB6C", Offset = "0x228EB6C", VA = "0x7BBCA8EB6C", Slot = "9")]
	public override void UnInit()
	{
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x228ED28", Offset = "0x228ED28", VA = "0x7BBCA8ED28", Slot = "10")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x228F15C", Offset = "0x228F15C", VA = "0x7BBCA8F15C", Slot = "11")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132F8C", Offset = "0x1132F8C")]
	protected override void EditorExecute()
	{
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x228F394", Offset = "0x228F394", VA = "0x7BBCA8F394")]
	public ILayoutTableItem GetSelectedItem()
	{
		return null;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x228F3C0", Offset = "0x228F3C0", VA = "0x7BBCA8F3C0")]
	public MinWidgetTableItem()
	{
	}

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] m_WidgetGOs;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ELayoutType m_SizType;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x38")]
	private List<ILayoutTableItem> m_Widgets;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x40")]
	private ILayoutTableItem m_MinHorizontal;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x48")]
	private ILayoutTableItem m_MinVertical;
}
