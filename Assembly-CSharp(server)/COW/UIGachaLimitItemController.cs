using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001808 RID: 6152
	[Token(Token = "0x2001808")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3424", Offset = "0x10F3424")]
	public class UIGachaLimitItemController : UIBaseController
	{
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[Token(Token = "0x1700095E")]
		public int Index
		{
			[Token(Token = "0x600779D")]
			[Address(RVA = "0x2062A68", Offset = "0x2062A68", VA = "0x7BBC862A68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095F")]
		public BaseItemInfo Info
		{
			[Token(Token = "0x600779E")]
			[Address(RVA = "0x2062A58", Offset = "0x2062A58", VA = "0x7BBC862A58")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[Token(Token = "0x600779F")]
		[Address(RVA = "0x2065534", Offset = "0x2065534", VA = "0x7BBC865534")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A0")]
		[Address(RVA = "0x2065584", Offset = "0x2065584", VA = "0x7BBC865584", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00021108 File Offset: 0x0001F308
		[Token(Token = "0x60077A1")]
		[Address(RVA = "0x20622E4", Offset = "0x20622E4", VA = "0x7BBC8622E4")]
		public bool isOwnedorRemoved()
		{
			return default(bool);
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00021120 File Offset: 0x0001F320
		[Token(Token = "0x60077A2")]
		[Address(RVA = "0x2062A60", Offset = "0x2062A60", VA = "0x7BBC862A60")]
		public uint GetGachaItemID()
		{
			return 0U;
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A3")]
		[Address(RVA = "0x20604C8", Offset = "0x20604C8", VA = "0x7BBC8604C8")]
		public void SetCurrentItemState(GachaLimitItemState state)
		{
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A4")]
		[Address(RVA = "0x2065708", Offset = "0x2065708", VA = "0x7BBC865708")]
		private void OnBtnTipClick()
		{
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A5")]
		[Address(RVA = "0x206587C", Offset = "0x206587C", VA = "0x7BBC86587C")]
		private void OnChooseClick()
		{
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A6")]
		[Address(RVA = "0x2060900", Offset = "0x2060900", VA = "0x7BBC860900")]
		public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
		{
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A7")]
		[Address(RVA = "0x2065B68", Offset = "0x2065B68", VA = "0x7BBC865B68")]
		public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
		{
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A8")]
		[Address(RVA = "0x2060D44", Offset = "0x2060D44", VA = "0x7BBC860D44")]
		public void ShowView(UIGachaLimitItemController.ViewStage stage, float alpha = 1f)
		{
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A9")]
		[Address(RVA = "0x2065D48", Offset = "0x2065D48", VA = "0x7BBC865D48")]
		private void PlaySelectedAudio()
		{
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AA")]
		[Address(RVA = "0x2065DE4", Offset = "0x2065DE4", VA = "0x7BBC865DE4")]
		private void PlayGetRewardAudio()
		{
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AB")]
		[Address(RVA = "0x2065E80", Offset = "0x2065E80", VA = "0x7BBC865E80", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AC")]
		[Address(RVA = "0x2065E88", Offset = "0x2065E88", VA = "0x7BBC865E88", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AD")]
		[Address(RVA = "0x2065E90", Offset = "0x2065E90", VA = "0x7BBC865E90")]
		public UIGachaLimitItemController()
		{
		}

		// Token: 0x04008DF4 RID: 36340
		[Token(Token = "0x4008DF4")]
		[FieldOffset(Offset = "0x58")]
		private uint m_GachaID;

		// Token: 0x04008DF5 RID: 36341
		[Token(Token = "0x4008DF5")]
		[FieldOffset(Offset = "0x60")]
		private UIGachaLimitItemView m_View;

		// Token: 0x04008DF6 RID: 36342
		[Token(Token = "0x4008DF6")]
		[FieldOffset(Offset = "0x68")]
		private GachaLimitItemState m_CurrentState;

		// Token: 0x04008DF7 RID: 36343
		[Token(Token = "0x4008DF7")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_gachaItemID;

		// Token: 0x04008DF8 RID: 36344
		[Token(Token = "0x4008DF8")]
		[FieldOffset(Offset = "0x70")]
		private int m_Idx;

		// Token: 0x04008DF9 RID: 36345
		[Token(Token = "0x4008DF9")]
		[FieldOffset(Offset = "0x78")]
		private BaseItemInfo m_Info;

		// Token: 0x02001809 RID: 6153
		[Token(Token = "0x2001809")]
		public enum ViewStage
		{
			// Token: 0x04008DFB RID: 36347
			[Token(Token = "0x4008DFB")]
			NORMAL,
			// Token: 0x04008DFC RID: 36348
			[Token(Token = "0x4008DFC")]
			TRANSLUCENT,
			// Token: 0x04008DFD RID: 36349
			[Token(Token = "0x4008DFD")]
			HIGHLIGHT,
			// Token: 0x04008DFE RID: 36350
			[Token(Token = "0x4008DFE")]
			SELECTED,
			// Token: 0x04008DFF RID: 36351
			[Token(Token = "0x4008DFF")]
			GET_REWARD
		}
	}
}
