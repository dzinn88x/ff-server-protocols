using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200163B RID: 5691
	[Token(Token = "0x200163B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFEDC", Offset = "0x10EFEDC")]
	public class UIRampageStoreController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006690 RID: 26256 RVA: 0x0001D460 File Offset: 0x0001B660
		[Token(Token = "0x6006690")]
		[Address(RVA = "0x1FF7AF4", Offset = "0x1FF7AF4", VA = "0x7BBC7F7AF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006691")]
		[Address(RVA = "0x1FF7B44", Offset = "0x1FF7B44", VA = "0x7BBC7F7B44", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006692")]
		[Address(RVA = "0x1FF7D0C", Offset = "0x1FF7D0C", VA = "0x7BBC7F7D0C")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006693")]
		[Address(RVA = "0x1FF7FB8", Offset = "0x1FF7FB8", VA = "0x7BBC7F7FB8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0001D478 File Offset: 0x0001B678
		[Token(Token = "0x6006694")]
		[Address(RVA = "0x1FF7FC0", Offset = "0x1FF7FC0", VA = "0x7BBC7F7FC0", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006695")]
		[Address(RVA = "0x1FF7FC8", Offset = "0x1FF7FC8", VA = "0x7BBC7F7FC8")]
		private void RefreshView()
		{
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006696")]
		[Address(RVA = "0x1FF8298", Offset = "0x1FF8298", VA = "0x7BBC7F8298")]
		private void OnTimeBtnClick()
		{
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006697")]
		[Address(RVA = "0x1FF829C", Offset = "0x1FF829C", VA = "0x7BBC7F829C")]
		private void OnTokenBtnClick()
		{
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006698")]
		[Address(RVA = "0x1FF7FF0", Offset = "0x1FF7FF0", VA = "0x7BBC7F7FF0")]
		private void RefreshCountDownTime()
		{
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006699")]
		[Address(RVA = "0x1FF8198", Offset = "0x1FF8198", VA = "0x7BBC7F8198")]
		private void RefreshBG()
		{
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669A")]
		[Address(RVA = "0x1FF7FEC", Offset = "0x1FF7FEC", VA = "0x7BBC7F7FEC")]
		private void RefreshToken()
		{
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669B")]
		[Address(RVA = "0x1FF82A0", Offset = "0x1FF82A0", VA = "0x7BBC7F82A0")]
		private void InitTab(UIRampageStoreController.TabItem item, LimitedEventStore storeDesc)
		{
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669C")]
		[Address(RVA = "0x1FF830C", Offset = "0x1FF830C", VA = "0x7BBC7F830C")]
		private void CreateTabs()
		{
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x1FF835C", Offset = "0x1FF835C", VA = "0x7BBC7F835C")]
		private void AdjustTabPos()
		{
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669E")]
		[Address(RVA = "0x1FF8558", Offset = "0x1FF8558", VA = "0x7BBC7F8558")]
		private void SelectTab()
		{
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669F")]
		[Address(RVA = "0x1FF855C", Offset = "0x1FF855C", VA = "0x7BBC7F855C")]
		private void ShowStoreRankUpGuide()
		{
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A0")]
		[Address(RVA = "0x1FF8560", Offset = "0x1FF8560", VA = "0x7BBC7F8560")]
		private void OnTabClick()
		{
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A1")]
		[Address(RVA = "0x1FF88F8", Offset = "0x1FF88F8", VA = "0x7BBC7F88F8")]
		private void RefreshEasyList(List<BigEventStoreCommodityDesc> dataList, bool sort = true)
		{
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A2")]
		[Address(RVA = "0x1FF89A0", Offset = "0x1FF89A0", VA = "0x7BBC7F89A0", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x0001D490 File Offset: 0x0001B690
		[Token(Token = "0x60066A3")]
		[Address(RVA = "0x1FF89FC", Offset = "0x1FF89FC", VA = "0x7BBC7F89FC", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A4")]
		[Address(RVA = "0x1FF8A40", Offset = "0x1FF8A40", VA = "0x7BBC7F8A40", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060066A5 RID: 26277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A5")]
		[Address(RVA = "0x1FF8B2C", Offset = "0x1FF8B2C", VA = "0x7BBC7F8B2C", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A6")]
		[Address(RVA = "0x1FF8B5C", Offset = "0x1FF8B5C", VA = "0x7BBC7F8B5C")]
		public UIRampageStoreController()
		{
		}

		// Token: 0x04008443 RID: 33859
		[Token(Token = "0x4008443")]
		[FieldOffset(Offset = "0xAC")]
		private float TabOffset;

		// Token: 0x04008444 RID: 33860
		[Token(Token = "0x4008444")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsDark;

		// Token: 0x04008445 RID: 33861
		[Token(Token = "0x4008445")]
		[FieldOffset(Offset = "0xB1")]
		private bool isShowedUnlockTips;

		// Token: 0x04008446 RID: 33862
		[Token(Token = "0x4008446")]
		private const int MAXTABNUM = 4;

		// Token: 0x04008447 RID: 33863
		[Token(Token = "0x4008447")]
		[FieldOffset(Offset = "0xB8")]
		private UIRampageStoreView m_View;

		// Token: 0x04008448 RID: 33864
		[Token(Token = "0x4008448")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelRampage m_ModelRampage;

		// Token: 0x04008449 RID: 33865
		[Token(Token = "0x4008449")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400844A RID: 33866
		[Token(Token = "0x400844A")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, UIRampageStoreController.TabItem> m_ToggleBtnLevelDict;

		// Token: 0x0400844B RID: 33867
		[Token(Token = "0x400844B")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIRampageStoreController.TabItem> m_TabItemList;

		// Token: 0x0400844C RID: 33868
		[Token(Token = "0x400844C")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_CurrentTab;

		// Token: 0x0200163C RID: 5692
		[Token(Token = "0x200163C")]
		public class TabItem : UIInnerView
		{
			// Token: 0x060066A7 RID: 26279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066A7")]
			[Address(RVA = "0x1E075F0", Offset = "0x1E075F0", VA = "0x7BBC6075F0", Slot = "4")]
			public override void BindVars(GameObject ui)
			{
			}

			// Token: 0x060066A8 RID: 26280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066A8")]
			[Address(RVA = "0x1E0776C", Offset = "0x1E0776C", VA = "0x7BBC60776C")]
			public TabItem()
			{
			}

			// Token: 0x0400844D RID: 33869
			[Token(Token = "0x400844D")]
			[FieldOffset(Offset = "0x28")]
			public UISprite Icon;

			// Token: 0x0400844E RID: 33870
			[Token(Token = "0x400844E")]
			[FieldOffset(Offset = "0x30")]
			public GameObject Lock;

			// Token: 0x0400844F RID: 33871
			[Token(Token = "0x400844F")]
			[FieldOffset(Offset = "0x38")]
			public UIToggleButton ToggleBtn;

			// Token: 0x04008450 RID: 33872
			[Token(Token = "0x4008450")]
			[FieldOffset(Offset = "0x40")]
			public UINetworkTexture Texture;

			// Token: 0x04008451 RID: 33873
			[Token(Token = "0x4008451")]
			[FieldOffset(Offset = "0x48")]
			public GameObject UnLockAnim;

			// Token: 0x04008452 RID: 33874
			[Token(Token = "0x4008452")]
			[FieldOffset(Offset = "0x50")]
			public GameObject Mask;

			// Token: 0x04008453 RID: 33875
			[Token(Token = "0x4008453")]
			[FieldOffset(Offset = "0x58")]
			public GameObject Light;

			// Token: 0x04008454 RID: 33876
			[Token(Token = "0x4008454")]
			[FieldOffset(Offset = "0x60")]
			public GameObject EffectShine;

			// Token: 0x04008455 RID: 33877
			[Token(Token = "0x4008455")]
			[FieldOffset(Offset = "0x68")]
			public Animation AnimationScale;

			// Token: 0x04008456 RID: 33878
			[Token(Token = "0x4008456")]
			[FieldOffset(Offset = "0x70")]
			public bool Selected;
		}
	}
}
