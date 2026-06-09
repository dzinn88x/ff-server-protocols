using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E1E58", Offset = "0x10E1E58")]
public class UICustomizedWrapContent : MonoBehaviour
{
	// Token: 0x060004C8 RID: 1224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x1C9ED08", Offset = "0x1C9ED08", VA = "0x7BBC49ED08", Slot = "4")]
	protected virtual void Start()
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x1C9EE10", Offset = "0x1C9EE10", VA = "0x7BBC49EE10", Slot = "5")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x1C9EE1C", Offset = "0x1C9EE1C", VA = "0x7BBC49EE1C", Slot = "6")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132D94", Offset = "0x1132D94")]
	public virtual void SortBasedOnScrollMovement()
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x1C9F130", Offset = "0x1C9F130", VA = "0x7BBC49F130", Slot = "7")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132DCC", Offset = "0x1132DCC")]
	public virtual void SortAlphabetically()
	{
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x1C9EFE8", Offset = "0x1C9EFE8", VA = "0x7BBC49EFE8")]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x1C9F2E4", Offset = "0x1C9F2E4", VA = "0x7BBC49F2E4", Slot = "8")]
	protected virtual void ResetChildPositions()
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x1C9F448", Offset = "0x1C9F448", VA = "0x7BBC49F448")]
	public void RefreshChildren()
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x1C9F518", Offset = "0x1C9F518", VA = "0x7BBC49F518", Slot = "9")]
	public virtual void WrapContent()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x1C9FCA8", Offset = "0x1C9FCA8", VA = "0x7BBC49FCA8")]
	private void OnValidate()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x1C9FCCC", Offset = "0x1C9FCCC", VA = "0x7BBC49FCCC", Slot = "10")]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1CA05C4", Offset = "0x1CA05C4", VA = "0x7BBC4A05C4")]
	public UICustomizedWrapContent()
	{
	}

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x18")]
	public int itemSize;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x1C")]
	public bool cullContent;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x20")]
	public int minIndex;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x24")]
	public int maxIndex;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x28")]
	public bool hideInactive;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x30")]
	public UICustomizedWrapContent.OnInitializeItem onInitializeItem;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x38")]
	protected Transform mTrans;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x40")]
	protected UIPanel mPanel;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x48")]
	protected UIScrollView mScroll;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x50")]
	protected bool mHorizontal;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x51")]
	protected bool mFirstTime;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x58")]
	protected List<Transform> mChildren;

	// Token: 0x02000107 RID: 263
	// (Invoke) Token: 0x060004D4 RID: 1236
	[Token(Token = "0x2000107")]
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);
}
