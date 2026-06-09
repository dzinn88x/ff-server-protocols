using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
[Attribute(Name = "ObsoleteAttribute", RVA = "0x10E1EA0", Offset = "0x10E1EA0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E1EA0", Offset = "0x10E1EA0")]
public class UIMultiPopMenuController : UIPopupWindowController
{
	// Token: 0x060004FF RID: 1279 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x1FBE9BC", Offset = "0x1FBE9BC", VA = "0x7BBC7BE9BC", Slot = "34")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x1FBE9C4", Offset = "0x1FBE9C4", VA = "0x7BBC7BE9C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x1FBEA14", Offset = "0x1FBEA14", VA = "0x7BBC7BEA14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x1FBEAF8", Offset = "0x1FBEAF8", VA = "0x7BBC7BEAF8")]
	private void OnClickeMask()
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x1FBEC20", Offset = "0x1FBEC20", VA = "0x7BBC7BEC20")]
	private void OnChoose()
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x1FBEB20", Offset = "0x1FBEB20", VA = "0x7BBC7BEB20")]
	private void Clear()
	{
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x1FBEF60", Offset = "0x1FBEF60", VA = "0x7BBC7BEF60")]
	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuListData> contents, Vector3 startOffset, bool needDefault = true, params string[] defaultIDs)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x1FBF4A0", Offset = "0x1FBF4A0", VA = "0x7BBC7BF4A0")]
	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuData> contents, Vector3 startOffset, bool needDefault = true, params string[] defaultIDs)
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x1FBF754", Offset = "0x1FBF754", VA = "0x7BBC7BF754")]
	private void ModifyStartPosition(Vector3 offset)
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x1FBF760", Offset = "0x1FBF760", VA = "0x7BBC7BF760")]
	private void OnChange()
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x1FBFE28", Offset = "0x1FBFE28", VA = "0x7BBC7BFE28")]
	private void OnClickMenuItem(int parentIndex, object data)
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x1FC09F8", Offset = "0x1FC09F8", VA = "0x7BBC7C09F8")]
	private bool IsInUse(string value)
	{
		return default(bool);
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x1FC0808", Offset = "0x1FC0808", VA = "0x7BBC7C0808")]
	private List<MultiPopMenuData> GetContent()
	{
		return null;
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x1FBEC9C", Offset = "0x1FBEC9C", VA = "0x7BBC7BEC9C")]
	private List<string> GetDestString()
	{
		return null;
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x1FC0BB8", Offset = "0x1FC0BB8", VA = "0x7BBC7C0BB8")]
	public UIMultiPopMenuController()
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x1FC0C70", Offset = "0x1FC0C70", VA = "0x7BBC7C0C70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E14", Offset = "0x1132E14")]
	private UIPopMenuController <SetData>b__18_0(Transform parent, Vector3 offset)
	{
		return null;
	}

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	private const float MAX_ITEM_COUNT = 4.5f;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget m_Widget;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0xA0")]
	private List<UIPopMenuController> m_SubMenus;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0xA8")]
	private List<string> m_DecisionContents;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0xB0")]
	private List<string> m_TempSelection;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0xB8")]
	private Func<Transform, Vector3, UIPopMenuController> m_OnOpenMenu;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0xC0")]
	private List<MultiPopMenuData> m_Contents;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_StartOffset;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0xD8")]
	private Action<List<string>> m_OnChoose;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0xE0")]
	private UIMultiPopMenuView m_View;

	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F00", Offset = "0x10E1F00")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1FBF498", Offset = "0x1FBF498", VA = "0x7BBC7BF498")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1FC0EEC", Offset = "0x1FC0EEC", VA = "0x7BBC7C0EEC")]
		internal bool <SetData>b__0(MultiPopMenuListData temp)
		{
			return default(bool);
		}

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x10")]
		public int curLayer;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<MultiPopMenuListData> <>9__0;
	}

	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F10", Offset = "0x10E1F10")]
	private sealed class <>c__DisplayClass20_0
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1FBFE20", Offset = "0x1FBFE20", VA = "0x7BBC7BFE20")]
		public <>c__DisplayClass20_0()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1FC0F30", Offset = "0x1FC0F30", VA = "0x7BBC7C0F30")]
		internal void <OnChange>b__1(object obj)
		{
		}

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x10")]
		public UIMultiPopMenuController <>4__this;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x18")]
		public int currentSelectCount;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x20")]
		public Action<object> <>9__1;
	}

	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F20", Offset = "0x10E1F20")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1FC0EDC", Offset = "0x1FC0EDC", VA = "0x7BBC7C0EDC")]
		public <>c()
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1FC0EE4", Offset = "0x1FC0EE4", VA = "0x7BBC7C0EE4")]
		internal void <OnChange>b__20_0()
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1FC0EE8", Offset = "0x1FC0EE8", VA = "0x7BBC7C0EE8")]
		internal void <OnClickMenuItem>b__21_0()
		{
		}

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIMultiPopMenuController.<>c <>9;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x8")]
		public static PopMenuDelegate <>9__20_0;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x10")]
		public static PopMenuDelegate <>9__21_0;
	}

	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F30", Offset = "0x10E1F30")]
	private sealed class <>c__DisplayClass21_0
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1FC0800", Offset = "0x1FC0800", VA = "0x7BBC7C0800")]
		public <>c__DisplayClass21_0()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1FC0F74", Offset = "0x1FC0F74", VA = "0x7BBC7C0F74")]
		internal void <OnClickMenuItem>b__1(object obj)
		{
		}

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x10")]
		public UIMultiPopMenuController <>4__this;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x18")]
		public int currentSelectCount;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x20")]
		public Action<object> <>9__1;
	}
}
