using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001812 RID: 6162
	[Token(Token = "0x2001812")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F35A4", Offset = "0x10F35A4")]
	public class UIGachaPreviewController : UIBaseController, IEasyList
	{
		// Token: 0x06007800 RID: 30720 RVA: 0x00021210 File Offset: 0x0001F410
		[Token(Token = "0x6007800")]
		[Address(RVA = "0x206C7F8", Offset = "0x206C7F8", VA = "0x7BBC86C7F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007801")]
		[Address(RVA = "0x206C848", Offset = "0x206C848", VA = "0x7BBC86C848", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007802")]
		[Address(RVA = "0x206CADC", Offset = "0x206CADC", VA = "0x7BBC86CADC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007803")]
		[Address(RVA = "0x206CBF4", Offset = "0x206CBF4", VA = "0x7BBC86CBF4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007804")]
		[Address(RVA = "0x206CD14", Offset = "0x206CD14", VA = "0x7BBC86CD14", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007805")]
		[Address(RVA = "0x206CDA8", Offset = "0x206CDA8", VA = "0x7BBC86CDA8", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007806")]
		[Address(RVA = "0x206CDAC", Offset = "0x206CDAC", VA = "0x7BBC86CDAC")]
		protected void ClosePanel(params object[] param)
		{
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007807")]
		[Address(RVA = "0x206CDB4", Offset = "0x206CDB4", VA = "0x7BBC86CDB4", Slot = "30")]
		public virtual void RefreshView(uint gachaId)
		{
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007808")]
		[Address(RVA = "0x206D2F0", Offset = "0x206D2F0", VA = "0x7BBC86D2F0")]
		private void OnBtnProbabilityClick()
		{
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007809")]
		[Address(RVA = "0x206D3A0", Offset = "0x206D3A0", VA = "0x7BBC86D3A0")]
		private void ShowRareProbabilityTips(params object[] param)
		{
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780A")]
		[Address(RVA = "0x206D638", Offset = "0x206D638", VA = "0x7BBC86D638", Slot = "31")]
		public virtual void HighLightItemByIndex(int index, bool needScroll = true)
		{
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780B")]
		[Address(RVA = "0x206D774", Offset = "0x206D774", VA = "0x7BBC86D774", Slot = "32")]
		public virtual void HighLightItemByID(uint itemID, bool needScroll = true)
		{
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780C")]
		[Address(RVA = "0x206D8E0", Offset = "0x206D8E0", VA = "0x7BBC86D8E0")]
		public UIGachaPreviewController()
		{
		}

		// Token: 0x04008E1A RID: 36378
		[Token(Token = "0x4008E1A")]
		[FieldOffset(Offset = "0x58")]
		private float m_ScorllViewOffest;

		// Token: 0x04008E1B RID: 36379
		[Token(Token = "0x4008E1B")]
		[FieldOffset(Offset = "0x60")]
		private UIGachaPreviewView m_View;

		// Token: 0x04008E1C RID: 36380
		[Token(Token = "0x4008E1C")]
		[FieldOffset(Offset = "0x68")]
		protected UIModelGacha m_ModelGacha;

		// Token: 0x04008E1D RID: 36381
		[Token(Token = "0x4008E1D")]
		[FieldOffset(Offset = "0x70")]
		protected uint m_GachaId;

		// Token: 0x04008E1E RID: 36382
		[Token(Token = "0x4008E1E")]
		[FieldOffset(Offset = "0x78")]
		private List<GachaShowItem> m_Infolist;

		// Token: 0x04008E1F RID: 36383
		[Token(Token = "0x4008E1F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_refreshFinish;

		// Token: 0x02001813 RID: 6163
		[Token(Token = "0x2001813")]
		public enum Type
		{
			// Token: 0x04008E21 RID: 36385
			[Token(Token = "0x4008E21")]
			NORMAL,
			// Token: 0x04008E22 RID: 36386
			[Token(Token = "0x4008E22")]
			LUCKYBAG
		}

		// Token: 0x02001814 RID: 6164
		[Token(Token = "0x2001814")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F35DC", Offset = "0x10F35DC")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x0600780D RID: 30733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600780D")]
			[Address(RVA = "0x206D8D8", Offset = "0x206D8D8", VA = "0x7BBC86D8D8")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x0600780E RID: 30734 RVA: 0x00021228 File Offset: 0x0001F428
			[Token(Token = "0x600780E")]
			[Address(RVA = "0x206D8F0", Offset = "0x206D8F0", VA = "0x7BBC86D8F0")]
			internal bool <HighLightItemByID>b__0(GachaShowItem item)
			{
				return default(bool);
			}

			// Token: 0x04008E23 RID: 36387
			[Token(Token = "0x4008E23")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}
	}
}
