using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
public class BaseTableItem : MonoBehaviour, ILayoutTableItem
{
	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1F8BA78", Offset = "0x1F8BA78", VA = "0x7BBC78BA78", Slot = "8")]
	public virtual void Init()
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1F8BB18", Offset = "0x1F8BB18", VA = "0x7BBC78BB18", Slot = "9")]
	public virtual void UnInit()
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1F8BB20", Offset = "0x1F8BB20", VA = "0x7BBC78BB20", Slot = "10")]
	public virtual Vector2 GetSize()
	{
		return default(Vector2);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1F8BC38", Offset = "0x1F8BC38", VA = "0x7BBC78BC38", Slot = "11")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132E64", Offset = "0x1132E64")]
	protected virtual void EditorExecute()
	{
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1F8BCFC", Offset = "0x1F8BCFC", VA = "0x7BBC78BCFC", Slot = "12")]
	public virtual bool SkipPadding()
	{
		return default(bool);
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1F8BD04", Offset = "0x1F8BD04", VA = "0x7BBC78BD04")]
	public BaseTableItem()
	{
	}

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIWidget m_Widget;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x20")]
	protected bool m_HasInit;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x21")]
	public bool m_SkipPadding;
}
