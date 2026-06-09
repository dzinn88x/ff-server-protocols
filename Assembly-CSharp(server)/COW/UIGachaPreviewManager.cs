using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001816 RID: 6166
	[Token(Token = "0x2001816")]
	public class UIGachaPreviewManager
	{
		// Token: 0x0600780F RID: 30735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780F")]
		[Address(RVA = "0x206D92C", Offset = "0x206D92C", VA = "0x7BBC86D92C")]
		public void Init(UINetworkTexture texture)
		{
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007810")]
		[Address(RVA = "0x206DAA0", Offset = "0x206DAA0", VA = "0x7BBC86DAA0")]
		public void InitGachaPreviewManagerCtx()
		{
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007811")]
		[Address(RVA = "0x206DC80", Offset = "0x206DC80", VA = "0x7BBC86DC80")]
		public UIMaleAvatar GetCurrentGachaModel()
		{
			return null;
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007812")]
		[Address(RVA = "0x206DD04", Offset = "0x206DD04", VA = "0x7BBC86DD04")]
		public void ClearGachaPreviewManagerCtx()
		{
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007813")]
		[Address(RVA = "0x206DF88", Offset = "0x206DF88", VA = "0x7BBC86DF88")]
		public void SetPreviewSceneBorder(Vector3 left, Vector3 right)
		{
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007814")]
		[Address(RVA = "0x206DF98", Offset = "0x206DF98", VA = "0x7BBC86DF98")]
		public void RefreshPreviewSceneCtx(uint gachaID)
		{
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007815")]
		[Address(RVA = "0x206E2C8", Offset = "0x206E2C8", VA = "0x7BBC86E2C8")]
		public void RefreshPreviewScene(bool needSkipAnimation)
		{
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007816")]
		[Address(RVA = "0x206E7B8", Offset = "0x206E7B8", VA = "0x7BBC86E7B8")]
		public void SetAnimaionOver()
		{
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00021240 File Offset: 0x0001F440
		[Token(Token = "0x6007817")]
		[Address(RVA = "0x206E7C0", Offset = "0x206E7C0", VA = "0x7BBC86E7C0")]
		public bool IsPlayingFullScreenAnim()
		{
			return default(bool);
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007818")]
		[Address(RVA = "0x206E544", Offset = "0x206E544", VA = "0x7BBC86E544")]
		private void SkipModelAnim()
		{
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007819")]
		[Address(RVA = "0x206E7C8", Offset = "0x206E7C8", VA = "0x7BBC86E7C8")]
		public void SetCurrentSceneShowType(UIGachaSceneShowType showType)
		{
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00021258 File Offset: 0x0001F458
		[Token(Token = "0x600781A")]
		[Address(RVA = "0x206E928", Offset = "0x206E928", VA = "0x7BBC86E928")]
		public UIGachaSceneShowType GetCurrentSceneShowType()
		{
			return UIGachaSceneShowType.Normal;
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781B")]
		[Address(RVA = "0x206E930", Offset = "0x206E930", VA = "0x7BBC86E930")]
		public List<UIGachaSceneShowType> GetCurrentOtherShowType()
		{
			return null;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781C")]
		[Address(RVA = "0x206EAA0", Offset = "0x206EAA0", VA = "0x7BBC86EAA0")]
		public void ClosePreviewScene()
		{
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781D")]
		[Address(RVA = "0x206E380", Offset = "0x206E380", VA = "0x7BBC86E380")]
		public void RefreshPreviewScenePlayAnimation()
		{
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781E")]
		[Address(RVA = "0x206ED6C", Offset = "0x206ED6C", VA = "0x7BBC86ED6C")]
		private void ShowCDNSceneBg()
		{
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781F")]
		[Address(RVA = "0x206EE9C", Offset = "0x206EE9C", VA = "0x7BBC86EE9C")]
		private void ShowAnimationScene()
		{
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007820")]
		[Address(RVA = "0x206F678", Offset = "0x206F678", VA = "0x7BBC86F678")]
		public void OpenRewardPoolPreviewPanel(Vector3 left, Vector3 right)
		{
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007821")]
		[Address(RVA = "0x206EBE4", Offset = "0x206EBE4", VA = "0x7BBC86EBE4")]
		private void OpenPreviewScenePanel(Vector3 leftOffset, Vector3 rightOffset)
		{
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007822")]
		[Address(RVA = "0x206F764", Offset = "0x206F764", VA = "0x7BBC86F764")]
		public void UpdatePreviewScenePanel()
		{
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007823")]
		[Address(RVA = "0x206E6D4", Offset = "0x206E6D4", VA = "0x7BBC86E6D4")]
		public void SkipAllAnim()
		{
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007824")]
		[Address(RVA = "0x206F828", Offset = "0x206F828", VA = "0x7BBC86F828")]
		public void SkipPreviewFullScreenAnim()
		{
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x206DDE8", Offset = "0x206DDE8", VA = "0x7BBC86DDE8")]
		public void NotifyContentUIShow()
		{
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007826")]
		[Address(RVA = "0x206F860", Offset = "0x206F860", VA = "0x7BBC86F860")]
		public void NotifyContentUIHide()
		{
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007827")]
		[Address(RVA = "0x206F8FC", Offset = "0x206F8FC", VA = "0x7BBC86F8FC")]
		public void SetSwitchBtnActive(bool activeState)
		{
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00021270 File Offset: 0x0001F470
		[Token(Token = "0x6007828")]
		[Address(RVA = "0x206DDE0", Offset = "0x206DDE0", VA = "0x7BBC86DDE0")]
		public bool HasPreviewAnimation()
		{
			return default(bool);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007829")]
		[Address(RVA = "0x206F900", Offset = "0x206F900", VA = "0x7BBC86F900")]
		public void PlayPreviewAnimation()
		{
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782A")]
		[Address(RVA = "0x206FCF4", Offset = "0x206FCF4", VA = "0x7BBC86FCF4")]
		public void ClearAvatarOnly()
		{
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782B")]
		[Address(RVA = "0x206FD84", Offset = "0x206FD84", VA = "0x7BBC86FD84")]
		public void ShowPreviewRewardPoolItem(BaseItemInfo itemInfo)
		{
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782C")]
		[Address(RVA = "0x206DA04", Offset = "0x206DA04", VA = "0x7BBC86DA04")]
		private void InitShowBoostAvatarParams()
		{
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782D")]
		[Address(RVA = "0x206F2C4", Offset = "0x206F2C4", VA = "0x7BBC86F2C4")]
		private FullScreenAnimParams CreateFullScreenAnimParmas()
		{
			return null;
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782E")]
		[Address(RVA = "0x207042C", Offset = "0x207042C", VA = "0x7BBC87042C")]
		private void SetAvatarTransformInfo(AvatarTransformInfo avatarInfoA, AvatarTransformInfo avatarInfoB)
		{
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782F")]
		[Address(RVA = "0x206F418", Offset = "0x206F418", VA = "0x7BBC86F418")]
		private void RefreshPreivewAvatar()
		{
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007830")]
		[Address(RVA = "0x206E1AC", Offset = "0x206E1AC", VA = "0x7BBC86E1AC")]
		private void SetPreviewShowAvatar()
		{
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007831")]
		[Address(RVA = "0x20706F8", Offset = "0x20706F8", VA = "0x7BBC8706F8")]
		private void ShowComPositePreviewModel(GachaDesc desc)
		{
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007832")]
		[Address(RVA = "0x2071498", Offset = "0x2071498", VA = "0x7BBC871498")]
		private PlayDoubleAvatarAnimParams CreatePlayDoubleAvatarAnimParams(List<uint> idlistA, List<uint> idlistB, int doubleanimA = 1, int doubleanimB = 1, string doublespecialA = "", string doubleidleA = "", string doublespecialB = "", string doubleidleB = "")
		{
			return null;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007833")]
		[Address(RVA = "0x2071664", Offset = "0x2071664", VA = "0x7BBC871664")]
		private PlayDoubleAvatarAnimParams.AvatarAnimParams CreateAvatarAnimParams(List<uint> idlist, int doubleanim = 1, string doublespecial = "", string doubleidle = "")
		{
			return null;
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007834")]
		[Address(RVA = "0x207126C", Offset = "0x207126C", VA = "0x7BBC87126C")]
		private List<uint> Get1PModelList(GachaDesc desc)
		{
			return null;
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007835")]
		[Address(RVA = "0x2070D2C", Offset = "0x2070D2C", VA = "0x7BBC870D2C")]
		private void ShowSimplePreviewModel(GachaDesc desc)
		{
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007836")]
		[Address(RVA = "0x2071730", Offset = "0x2071730", VA = "0x7BBC871730")]
		private void CreateGachaAvatarModel(List<uint> idlist)
		{
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007837")]
		[Address(RVA = "0x206F4AC", Offset = "0x206F4AC", VA = "0x7BBC86F4AC")]
		private void TryPlayFullScreenAnim(FullscreenCgDesc data)
		{
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00021288 File Offset: 0x0001F488
		[Token(Token = "0x6007838")]
		[Address(RVA = "0x206FB94", Offset = "0x206FB94", VA = "0x7BBC86FB94")]
		private bool IsAllClothesOwned(uint animID)
		{
			return default(bool);
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007839")]
		[Address(RVA = "0x2071A64", Offset = "0x2071A64", VA = "0x7BBC871A64")]
		private List<uint> GetClotheIDListByAnim(int animID)
		{
			return null;
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783A")]
		[Address(RVA = "0x2071C2C", Offset = "0x2071C2C", VA = "0x7BBC871C2C")]
		private List<uint> ProcessAnimData(FullscreenCgDesc animData)
		{
			return null;
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783B")]
		[Address(RVA = "0x2071FD4", Offset = "0x2071FD4", VA = "0x7BBC871FD4")]
		private List<uint> DoProcessAnimData(CSSharedItemData data, List<uint> clothesID)
		{
			return null;
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783C")]
		[Address(RVA = "0x206DE84", Offset = "0x206DE84", VA = "0x7BBC86DE84")]
		private void DestoryAvatarModel()
		{
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783D")]
		[Address(RVA = "0x20705F8", Offset = "0x20705F8", VA = "0x7BBC8705F8")]
		private void PreviewManagerReset()
		{
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x000212A0 File Offset: 0x0001F4A0
		[Token(Token = "0x600783E")]
		[Address(RVA = "0x20702E4", Offset = "0x20702E4", VA = "0x7BBC8702E4")]
		private bool CheckItemABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783F")]
		[Address(RVA = "0x20720B8", Offset = "0x20720B8", VA = "0x7BBC8720B8")]
		public UIGachaPreviewManager()
		{
		}

		// Token: 0x04008E28 RID: 36392
		[Token(Token = "0x4008E28")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 TURNTABLEGACHADOUBLEANIMCAMERAROTATION;

		// Token: 0x04008E29 RID: 36393
		[Token(Token = "0x4008E29")]
		private const uint PREVIEWTYPELIMIT = 2U;

		// Token: 0x04008E2A RID: 36394
		[Token(Token = "0x4008E2A")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_CurrentGachaID;

		// Token: 0x04008E2B RID: 36395
		[Token(Token = "0x4008E2B")]
		[FieldOffset(Offset = "0x20")]
		private uint m_SimpleWeaponId;

		// Token: 0x04008E2C RID: 36396
		[Token(Token = "0x4008E2C")]
		[FieldOffset(Offset = "0x28")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008E2D RID: 36397
		[Token(Token = "0x4008E2D")]
		[FieldOffset(Offset = "0x30")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x04008E2E RID: 36398
		[Token(Token = "0x4008E2E")]
		[FieldOffset(Offset = "0x38")]
		private UIMaleAvatar m_GachaAvatarModel;

		// Token: 0x04008E2F RID: 36399
		[Token(Token = "0x4008E2F")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 AvatarPos;

		// Token: 0x04008E30 RID: 36400
		[Token(Token = "0x4008E30")]
		[FieldOffset(Offset = "0x50")]
		private ShowBoostAvatarParams m_ShowBoostAvatarParams;

		// Token: 0x04008E31 RID: 36401
		[Token(Token = "0x4008E31")]
		[FieldOffset(Offset = "0x58")]
		private UINetworkTexture m_CDNTextureComponent;

		// Token: 0x04008E32 RID: 36402
		[Token(Token = "0x4008E32")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 panelLeft;

		// Token: 0x04008E33 RID: 36403
		[Token(Token = "0x4008E33")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 panelRight;

		// Token: 0x04008E34 RID: 36404
		[Token(Token = "0x4008E34")]
		[FieldOffset(Offset = "0x78")]
		private bool m_ShowingAnimationFlag;

		// Token: 0x04008E35 RID: 36405
		[Token(Token = "0x4008E35")]
		[FieldOffset(Offset = "0x79")]
		private bool m_CurrentGachaIsFullScreenAnim;

		// Token: 0x04008E36 RID: 36406
		[Token(Token = "0x4008E36")]
		[FieldOffset(Offset = "0x7C")]
		private UIGachaSceneShowType m_CurrenGachaModelShow;

		// Token: 0x04008E37 RID: 36407
		[Token(Token = "0x4008E37")]
		[FieldOffset(Offset = "0x80")]
		private List<UIGachaSceneShowType> m_ShowTypeList;

		// Token: 0x02001817 RID: 6167
		[Token(Token = "0x2001817")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F35EC", Offset = "0x10F35EC")]
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x06007840 RID: 30784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007840")]
			[Address(RVA = "0x2071C24", Offset = "0x2071C24", VA = "0x7BBC871C24")]
			public <>c__DisplayClass58_0()
			{
			}

			// Token: 0x06007841 RID: 30785 RVA: 0x000212B8 File Offset: 0x0001F4B8
			[Token(Token = "0x6007841")]
			[Address(RVA = "0x20721A4", Offset = "0x20721A4", VA = "0x7BBC8721A4")]
			internal bool <GetClotheIDListByAnim>b__0(FullscreenCgDesc item)
			{
				return default(bool);
			}

			// Token: 0x04008E38 RID: 36408
			[Token(Token = "0x4008E38")]
			[FieldOffset(Offset = "0x10")]
			public int animID;
		}
	}
}
