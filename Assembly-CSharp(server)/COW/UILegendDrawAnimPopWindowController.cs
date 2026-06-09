using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200182F RID: 6191
	[Token(Token = "0x200182F")]
	public class UILegendDrawAnimPopWindowController : UIPopupWindowController, IEasyList
	{
		// Token: 0x0600790C RID: 30988 RVA: 0x00021510 File Offset: 0x0001F710
		[Token(Token = "0x600790C")]
		[Address(RVA = "0x1CB3740", Offset = "0x1CB3740", VA = "0x7BBC4B3740")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790D")]
		[Address(RVA = "0x1CB3790", Offset = "0x1CB3790", VA = "0x7BBC4B3790", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790E")]
		[Address(RVA = "0x1CB3920", Offset = "0x1CB3920", VA = "0x7BBC4B3920", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790F")]
		[Address(RVA = "0x1CB3A04", Offset = "0x1CB3A04", VA = "0x7BBC4B3A04")]
		public void SetGachaID(uint gachaID)
		{
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007910")]
		[Address(RVA = "0x1CB3A2C", Offset = "0x1CB3A2C", VA = "0x7BBC4B3A2C")]
		private void RefreshEasyListView()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007911")]
		[Address(RVA = "0x1CB4080", Offset = "0x1CB4080", VA = "0x7BBC4B4080")]
		private void DOScroll()
		{
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007912")]
		[Address(RVA = "0x1CB43E4", Offset = "0x1CB43E4", VA = "0x7BBC4B43E4")]
		private void OnFinished()
		{
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007913")]
		[Address(RVA = "0x1CB4688", Offset = "0x1CB4688", VA = "0x7BBC4B4688", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007914")]
		[Address(RVA = "0x1CB46B8", Offset = "0x1CB46B8", VA = "0x7BBC4B46B8", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x00021528 File Offset: 0x0001F728
		[Token(Token = "0x6007915")]
		[Address(RVA = "0x1CB47D8", Offset = "0x1CB47D8", VA = "0x7BBC4B47D8", Slot = "37")]
		public override bool IgnoreEsc()
		{
			return default(bool);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007916")]
		[Address(RVA = "0x1CB47E0", Offset = "0x1CB47E0", VA = "0x7BBC4B47E0")]
		public UILegendDrawAnimPopWindowController()
		{
		}

		// Token: 0x04008E93 RID: 36499
		[Token(Token = "0x4008E93")]
		[FieldOffset(Offset = "0x94")]
		private uint m_GachaID;

		// Token: 0x04008E94 RID: 36500
		[Token(Token = "0x4008E94")]
		[FieldOffset(Offset = "0x98")]
		private uint m_DelayCallID;

		// Token: 0x04008E95 RID: 36501
		[Token(Token = "0x4008E95")]
		[FieldOffset(Offset = "0x9C")]
		private int m_ListCount;

		// Token: 0x04008E96 RID: 36502
		[Token(Token = "0x4008E96")]
		[FieldOffset(Offset = "0xA0")]
		private float m_TotalTime;

		// Token: 0x04008E97 RID: 36503
		[Token(Token = "0x4008E97")]
		[FieldOffset(Offset = "0xA4")]
		private float m_StayTimeAfterAnimEnd;

		// Token: 0x04008E98 RID: 36504
		[Token(Token = "0x4008E98")]
		[FieldOffset(Offset = "0xA8")]
		private UILegendDrawAnimPopWindowView m_View;

		// Token: 0x04008E99 RID: 36505
		[Token(Token = "0x4008E99")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelGacha m_Model;

		// Token: 0x04008E9A RID: 36506
		[Token(Token = "0x4008E9A")]
		[FieldOffset(Offset = "0xB8")]
		private int m_TargetIndex;

		// Token: 0x04008E9B RID: 36507
		[Token(Token = "0x4008E9B")]
		[FieldOffset(Offset = "0xC0")]
		private List<BaseItemInfo> gachaShowItems;

		// Token: 0x02001830 RID: 6192
		[Token(Token = "0x2001830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3844", Offset = "0x10F3844")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06007917 RID: 30999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007917")]
			[Address(RVA = "0x1CB43DC", Offset = "0x1CB43DC", VA = "0x7BBC4B43DC")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06007918 RID: 31000 RVA: 0x00021540 File Offset: 0x0001F740
			[Token(Token = "0x6007918")]
			[Address(RVA = "0x1CB496C", Offset = "0x1CB496C", VA = "0x7BBC4B496C")]
			internal bool <RefreshEasyListView>b__0(BaseItemInfo x)
			{
				return default(bool);
			}

			// Token: 0x04008E9C RID: 36508
			[Token(Token = "0x4008E9C")]
			[FieldOffset(Offset = "0x10")]
			public List<GachaShowItem> lotteriesSorted;
		}

		// Token: 0x02001831 RID: 6193
		[Token(Token = "0x2001831")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3854", Offset = "0x10F3854")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600791A RID: 31002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791A")]
			[Address(RVA = "0x1CB48C8", Offset = "0x1CB48C8", VA = "0x7BBC4B48C8")]
			public <>c()
			{
			}

			// Token: 0x0600791B RID: 31003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791B")]
			[Address(RVA = "0x1CB48D0", Offset = "0x1CB48D0", VA = "0x7BBC4B48D0")]
			internal void <OnFinished>b__15_0()
			{
			}

			// Token: 0x04008E9D RID: 36509
			[Token(Token = "0x4008E9D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILegendDrawAnimPopWindowController.<>c <>9;

			// Token: 0x04008E9E RID: 36510
			[Token(Token = "0x4008E9E")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__15_0;
		}
	}
}
