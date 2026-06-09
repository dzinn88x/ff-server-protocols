using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class GridTableItem : BaseTableItem
{
	// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x275051C", Offset = "0x275051C", VA = "0x7BBCF5051C", Slot = "8")]
	public override void Init()
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x2750940", Offset = "0x2750940", VA = "0x7BBCF50940", Slot = "9")]
	public override void UnInit()
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000598")]
	[Address(RVA = "0x2750A04", Offset = "0x2750A04", VA = "0x7BBCF50A04")]
	public void UsePresetCount(int count)
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x2750A0C", Offset = "0x2750A0C", VA = "0x7BBCF50A0C", Slot = "10")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x2750C4C", Offset = "0x2750C4C", VA = "0x7BBCF50C4C", Slot = "11")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132E9C", Offset = "0x1132E9C")]
	protected override void EditorExecute()
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x2750E74", Offset = "0x2750E74", VA = "0x7BBCF50E74")]
	public GridTableItem()
	{
	}

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIGrid m_Grid;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_PadLeft;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_PadRight;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_PadBottom;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_PadUp;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector2 m_PresetRealItemSize;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 m_RealItemSize;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x50")]
	private int m_ActiveCount;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x54")]
	private int m_PresetCount;
}
