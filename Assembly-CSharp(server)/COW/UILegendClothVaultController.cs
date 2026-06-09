using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019DA RID: 6618
	[Token(Token = "0x20019DA")]
	public class UILegendClothVaultController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x0600886C RID: 34924 RVA: 0x00024BA0 File Offset: 0x00022DA0
		[Token(Token = "0x600886C")]
		[Address(RVA = "0x1E3D6AC", Offset = "0x1E3D6AC", VA = "0x7BBC63D6AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x00024BB8 File Offset: 0x00022DB8
		[Token(Token = "0x600886D")]
		[Address(RVA = "0x1E3D6FC", Offset = "0x1E3D6FC", VA = "0x7BBC63D6FC", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600886E")]
		[Address(RVA = "0x1E3D704", Offset = "0x1E3D704", VA = "0x7BBC63D704", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600886F")]
		[Address(RVA = "0x1E3D76C", Offset = "0x1E3D76C", VA = "0x7BBC63D76C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008870")]
		[Address(RVA = "0x1E3E434", Offset = "0x1E3E434", VA = "0x7BBC63E434", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008871")]
		[Address(RVA = "0x1E3E670", Offset = "0x1E3E670", VA = "0x7BBC63E670", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008872")]
		[Address(RVA = "0x1E3E9F8", Offset = "0x1E3E9F8", VA = "0x7BBC63E9F8", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008873")]
		[Address(RVA = "0x1E3E754", Offset = "0x1E3E754", VA = "0x7BBC63E754")]
		private void SetCdnPos(Vector2 vector)
		{
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008874")]
		[Address(RVA = "0x1E3F3C0", Offset = "0x1E3F3C0", VA = "0x7BBC63F3C0")]
		private void SetCdnPosX(float x)
		{
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008875")]
		[Address(RVA = "0x1E3E86C", Offset = "0x1E3E86C", VA = "0x7BBC63E86C")]
		private void SetCdnSize(int width, int height)
		{
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008876")]
		[Address(RVA = "0x1E3ECB0", Offset = "0x1E3ECB0", VA = "0x7BBC63ECB0")]
		private void ResetCdnBg()
		{
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008877")]
		[Address(RVA = "0x1E3F4D8", Offset = "0x1E3F4D8", VA = "0x7BBC63F4D8", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x00024BD0 File Offset: 0x00022DD0
		[Token(Token = "0x6008878")]
		[Address(RVA = "0x1E3F550", Offset = "0x1E3F550", VA = "0x7BBC63F550", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008879")]
		[Address(RVA = "0x1E3F594", Offset = "0x1E3F594", VA = "0x7BBC63F594")]
		public void SetData(LegendClothVaultPageType pageType, uint legendId = 1U)
		{
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600887A")]
		[Address(RVA = "0x1E3F0EC", Offset = "0x1E3F0EC", VA = "0x7BBC63F0EC")]
		private void RefreshView()
		{
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600887B")]
		[Address(RVA = "0x1E3E3D8", Offset = "0x1E3E3D8", VA = "0x7BBC63E3D8")]
		private void PrepareSlotItems()
		{
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600887C")]
		[Address(RVA = "0x1E4226C", Offset = "0x1E4226C", VA = "0x7BBC64226C")]
		private void PrepareSlotItem(UIModelAvatarBase.EWardrobeType wardrobeType)
		{
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x00024BE8 File Offset: 0x00022DE8
		[Token(Token = "0x600887D")]
		[Address(RVA = "0x1E3EB2C", Offset = "0x1E3EB2C", VA = "0x7BBC63EB2C")]
		private bool IfMatchGender()
		{
			return default(bool);
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600887E")]
		[Address(RVA = "0x1E3F858", Offset = "0x1E3F858", VA = "0x7BBC63F858")]
		private void RefreshTags(LegendClothData baseClothData)
		{
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600887F")]
		[Address(RVA = "0x1E41364", Offset = "0x1E41364", VA = "0x7BBC641364")]
		private void RefreshColorPanelColors(List<LegendClothData> data)
		{
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008880")]
		[Address(RVA = "0x1E424F4", Offset = "0x1E424F4", VA = "0x7BBC6424F4")]
		private void OnBtnColorPanelClick()
		{
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008881")]
		[Address(RVA = "0x1E425E0", Offset = "0x1E425E0", VA = "0x7BBC6425E0")]
		private void OnBtnHideColorPanelClick()
		{
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008882")]
		[Address(RVA = "0x1E42624", Offset = "0x1E42624", VA = "0x7BBC642624")]
		private void OnBtnPurchaseClick()
		{
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008883")]
		[Address(RVA = "0x1E426C0", Offset = "0x1E426C0", VA = "0x7BBC6426C0")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008884")]
		[Address(RVA = "0x1E42B5C", Offset = "0x1E42B5C", VA = "0x7BBC642B5C")]
		private void OnFeatureShow(params object[] data)
		{
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008885")]
		[Address(RVA = "0x1E425C8", Offset = "0x1E425C8", VA = "0x7BBC6425C8")]
		private void MoveAvatarLeft()
		{
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008886")]
		[Address(RVA = "0x1E42614", Offset = "0x1E42614", VA = "0x7BBC642614")]
		private void MoveAvatarMiddle()
		{
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008887")]
		[Address(RVA = "0x1E3EF38", Offset = "0x1E3EF38", VA = "0x7BBC63EF38")]
		private void SetAvatarPos(float x, float uix, bool instant = false)
		{
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008888")]
		[Address(RVA = "0x1E42F34", Offset = "0x1E42F34", VA = "0x7BBC642F34")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11436E0", Offset = "0x11436E0")]
		private IEnumerator MoveAvatar(float x, float uix)
		{
			return null;
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008889")]
		[Address(RVA = "0x1E41B04", Offset = "0x1E41B04", VA = "0x7BBC641B04")]
		private void SwitchPage(UILegendClothVaultController.ShowingSubPage showType)
		{
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888A")]
		[Address(RVA = "0x1E42FE4", Offset = "0x1E42FE4", VA = "0x7BBC642FE4")]
		private void SetAvatarPos(bool inputEnable, bool resetRotation)
		{
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888B")]
		[Address(RVA = "0x1E3FDE8", Offset = "0x1E3FDE8", VA = "0x7BBC63FDE8")]
		private void RefreshPropertyContainer()
		{
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888C")]
		[Address(RVA = "0x1E433AC", Offset = "0x1E433AC", VA = "0x7BBC6433AC")]
		private void OnBtnSlotChooseClick(params object[] data)
		{
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888D")]
		[Address(RVA = "0x1E3F774", Offset = "0x1E3F774", VA = "0x7BBC63F774")]
		private void TakeOnAll(int level = 0)
		{
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888E")]
		[Address(RVA = "0x1E439E8", Offset = "0x1E439E8", VA = "0x7BBC6439E8")]
		private void RefreshColorPanelSlotAllCurrentColor()
		{
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600888F")]
		[Address(RVA = "0x1E43998", Offset = "0x1E43998", VA = "0x7BBC643998")]
		private void CheckWearingAndTakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
		{
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008890")]
		[Address(RVA = "0x1E438C0", Offset = "0x1E438C0", VA = "0x7BBC6438C0")]
		private void TakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
		{
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008891")]
		[Address(RVA = "0x1E43520", Offset = "0x1E43520", VA = "0x7BBC643520")]
		private void TakeOnById(UIModelAvatarBase.EWardrobeType slot, uint itemId, int level)
		{
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008892")]
		[Address(RVA = "0x1E40E54", Offset = "0x1E40E54", VA = "0x7BBC640E54")]
		private void RefreshShowingPreviewAvatarCloth()
		{
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008893")]
		[Address(RVA = "0x1E44058", Offset = "0x1E44058", VA = "0x7BBC644058")]
		private void RefreshSlotPanel()
		{
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008894")]
		[Address(RVA = "0x1E44DB4", Offset = "0x1E44DB4", VA = "0x7BBC644DB4")]
		private void OnBtnSlotCancelClick(params object[] data)
		{
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008895")]
		[Address(RVA = "0x1E45100", Offset = "0x1E45100", VA = "0x7BBC645100")]
		private void OnAnimExit(params object[] data)
		{
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008896")]
		[Address(RVA = "0x1E44EA8", Offset = "0x1E44EA8", VA = "0x7BBC644EA8")]
		private void TakeOff(UIModelAvatarBase.EWardrobeType slot)
		{
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x00024C00 File Offset: 0x00022E00
		[Token(Token = "0x6008897")]
		[Address(RVA = "0x1E44B88", Offset = "0x1E44B88", VA = "0x7BBC644B88")]
		private bool CheckHaveWearing()
		{
			return default(bool);
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008898")]
		[Address(RVA = "0x1E44D40", Offset = "0x1E44D40", VA = "0x7BBC644D40")]
		private void RefreshConfirmBtn()
		{
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008899")]
		[Address(RVA = "0x1E45118", Offset = "0x1E45118", VA = "0x7BBC645118")]
		private List<uint> ClothIdListRemoveTargetSlot(List<uint> clothList, UIModelAvatarBase.EWardrobeType slotType)
		{
			return null;
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889A")]
		[Address(RVA = "0x1E452C0", Offset = "0x1E452C0", VA = "0x7BBC6452C0")]
		private void OnSwitchColor(params object[] data)
		{
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889B")]
		[Address(RVA = "0x1E453B0", Offset = "0x1E453B0", VA = "0x7BBC6453B0")]
		private void OnBtnFoldStoryClick()
		{
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889C")]
		[Address(RVA = "0x1E454F0", Offset = "0x1E454F0", VA = "0x7BBC6454F0")]
		private void OnBtnUnFoldStoryClick()
		{
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889D")]
		[Address(RVA = "0x1E45604", Offset = "0x1E45604", VA = "0x7BBC645604")]
		private void OnBtnColorPanelComponentHairClick()
		{
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889E")]
		[Address(RVA = "0x1E4560C", Offset = "0x1E4560C", VA = "0x7BBC64560C")]
		private void OnBtnColorPanelComponentFaceClick()
		{
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600889F")]
		[Address(RVA = "0x1E45614", Offset = "0x1E45614", VA = "0x7BBC645614")]
		private void OnBtnColorPanelComponentHeadAdditiveClick()
		{
		}

		// Token: 0x060088A0 RID: 34976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A0")]
		[Address(RVA = "0x1E4561C", Offset = "0x1E4561C", VA = "0x7BBC64561C")]
		private void OnBtnColorPanelComponentChestClick()
		{
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A1")]
		[Address(RVA = "0x1E45624", Offset = "0x1E45624", VA = "0x7BBC645624")]
		private void OnBtnColorPanelComponentLegsClick()
		{
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A2")]
		[Address(RVA = "0x1E4562C", Offset = "0x1E4562C", VA = "0x7BBC64562C")]
		private void OnBtnColorPanelComponentFeetClick()
		{
		}

		// Token: 0x060088A3 RID: 34979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A3")]
		[Address(RVA = "0x1E45634", Offset = "0x1E45634", VA = "0x7BBC645634")]
		private void OnBtnColorPanelComponentAllClick()
		{
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A4")]
		[Address(RVA = "0x1E4563C", Offset = "0x1E4563C", VA = "0x7BBC64563C")]
		public void OnGotoCharaBtnClick()
		{
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A5")]
		[Address(RVA = "0x1E43138", Offset = "0x1E43138", VA = "0x7BBC643138")]
		private void PickChoosingWardrobeType(UIModelAvatarBase.EWardrobeType choosingType)
		{
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A6")]
		[Address(RVA = "0x1E441A0", Offset = "0x1E441A0", VA = "0x7BBC6441A0")]
		private void RefreshColorPanelComponentStates()
		{
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088A7")]
		[Address(RVA = "0x1E44A50", Offset = "0x1E44A50", VA = "0x7BBC644A50")]
		private void RefreshColorPanelColorStates()
		{
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x00024C18 File Offset: 0x00022E18
		[Token(Token = "0x60088A8")]
		[Address(RVA = "0x1E45650", Offset = "0x1E45650", VA = "0x7BBC645650")]
		private bool SlotHaveItem(UIModelAvatarBase.EWardrobeType slotType)
		{
			return default(bool);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x00024C30 File Offset: 0x00022E30
		[Token(Token = "0x60088A9")]
		[Address(RVA = "0x1E43E90", Offset = "0x1E43E90", VA = "0x7BBC643E90")]
		private bool IsWearingWardrobeAtSlot(UIModelAvatarBase.EWardrobeType slotType)
		{
			return default(bool);
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088AA")]
		[Address(RVA = "0x1E4572C", Offset = "0x1E4572C", VA = "0x7BBC64572C")]
		public UILegendClothVaultController()
		{
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088AC")]
		[Address(RVA = "0x1E458A0", Offset = "0x1E458A0", VA = "0x7BBC6458A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143744", Offset = "0x1143744")]
		private void <OnUIInit>b__30_0()
		{
		}

		// Token: 0x040096D9 RID: 38617
		[Token(Token = "0x40096D9")]
		[FieldOffset(Offset = "0xB0")]
		private UILegendClothVaultView m_View;

		// Token: 0x040096DA RID: 38618
		[Token(Token = "0x40096DA")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040096DB RID: 38619
		[Token(Token = "0x40096DB")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x040096DC RID: 38620
		[Token(Token = "0x40096DC")]
		[FieldOffset(Offset = "0xC8")]
		private LegendClothVaultPageType m_PageType;

		// Token: 0x040096DD RID: 38621
		[Token(Token = "0x40096DD")]
		[FieldOffset(Offset = "0xCC")]
		private uint m_LegendId;

		// Token: 0x040096DE RID: 38622
		[Token(Token = "0x40096DE")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_IsMatchGender;

		// Token: 0x040096DF RID: 38623
		[Token(Token = "0x40096DF")]
		private const float MoveLeftPixel = -130f;

		// Token: 0x040096E0 RID: 38624
		[Token(Token = "0x40096E0")]
		private const float MiddlePixel = 0f;

		// Token: 0x040096E1 RID: 38625
		[Token(Token = "0x40096E1")]
		private const float MoveLeftPixelUI = -200f;

		// Token: 0x040096E2 RID: 38626
		[Token(Token = "0x40096E2")]
		private const float MiddlePixelUI = 0f;

		// Token: 0x040096E3 RID: 38627
		[Token(Token = "0x40096E3")]
		private const int UIStoryPanelBottomAnchorWhenFold = -184;

		// Token: 0x040096E4 RID: 38628
		[Token(Token = "0x40096E4")]
		private const int UIStoryPanelBottomAnchorWhenUnfold = -362;

		// Token: 0x040096E5 RID: 38629
		[Token(Token = "0x40096E5")]
		private const int DefaultShowLegendType = 1;

		// Token: 0x040096E6 RID: 38630
		[Token(Token = "0x40096E6")]
		private const uint InvalidClothId = 0U;

		// Token: 0x040096E7 RID: 38631
		[Token(Token = "0x40096E7")]
		private const uint DefaultAvatarIdFemale = 101000018U;

		// Token: 0x040096E8 RID: 38632
		[Token(Token = "0x40096E8")]
		private const uint DefaultAvatarIdMale = 102000012U;

		// Token: 0x040096E9 RID: 38633
		[Token(Token = "0x40096E9")]
		[FieldOffset(Offset = "0xD4")]
		private UIModelAvatarBase.EWardrobeType m_ChoosingWardrobeType;

		// Token: 0x040096EA RID: 38634
		[Token(Token = "0x40096EA")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<UIModelAvatarBase.EWardrobeType, UILegendClothVaultSlotItemController> m_SlotItems;

		// Token: 0x040096EB RID: 38635
		[Token(Token = "0x40096EB")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<UIModelAvatarBase.EWardrobeType, UISprite> m_DictSlotSpriteCurrentColor;

		// Token: 0x040096EC RID: 38636
		[Token(Token = "0x40096EC")]
		[FieldOffset(Offset = "0xE8")]
		private UITexture m_BgCdnTexture;

		// Token: 0x040096ED RID: 38637
		[Token(Token = "0x40096ED")]
		[FieldOffset(Offset = "0xF0")]
		private Vector2 m_BgCdnOriginalPos;

		// Token: 0x040096EE RID: 38638
		[Token(Token = "0x40096EE")]
		[FieldOffset(Offset = "0xF8")]
		private Vector2 m_BgCdnOriginalSize;

		// Token: 0x040096EF RID: 38639
		[Token(Token = "0x40096EF")]
		[FieldOffset(Offset = "0x100")]
		private Vector2 m_BgCdnScenePos;

		// Token: 0x040096F0 RID: 38640
		[Token(Token = "0x40096F0")]
		[FieldOffset(Offset = "0x108")]
		private Vector2 m_BgCdnSceneSize;

		// Token: 0x040096F1 RID: 38641
		[Token(Token = "0x40096F1")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_MovingAvatarCoroutine;

		// Token: 0x040096F2 RID: 38642
		[Token(Token = "0x40096F2")]
		[FieldOffset(Offset = "0x118")]
		private UILegendClothVaultController.ShowingSubPage m_CurrentSubPage;

		// Token: 0x040096F3 RID: 38643
		[Token(Token = "0x40096F3")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> UI3DOBJECT_NAMES;

		// Token: 0x020019DB RID: 6619
		[Token(Token = "0x20019DB")]
		public enum ShowingSubPage
		{
			// Token: 0x040096F5 RID: 38645
			[Token(Token = "0x40096F5")]
			Main,
			// Token: 0x040096F6 RID: 38646
			[Token(Token = "0x40096F6")]
			Emote,
			// Token: 0x040096F7 RID: 38647
			[Token(Token = "0x40096F7")]
			EnterTeamAnim,
			// Token: 0x040096F8 RID: 38648
			[Token(Token = "0x40096F8")]
			ParachuteAnim,
			// Token: 0x040096F9 RID: 38649
			[Token(Token = "0x40096F9")]
			ColorPanelPage
		}

		// Token: 0x020019DC RID: 6620
		[Token(Token = "0x20019DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F71F4", Offset = "0x10F71F4")]
		private sealed class <MoveAvatar>d__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060088AD RID: 34989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088AD")]
			[Address(RVA = "0x1CB0148", Offset = "0x1CB0148", VA = "0x7BBC4B0148")]
			[DebuggerHidden]
			public <MoveAvatar>d__55(int <>1__state)
			{
			}

			// Token: 0x060088AE RID: 34990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088AE")]
			[Address(RVA = "0x1CB0174", Offset = "0x1CB0174", VA = "0x7BBC4B0174", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060088AF RID: 34991 RVA: 0x00024C48 File Offset: 0x00022E48
			[Token(Token = "0x60088AF")]
			[Address(RVA = "0x1CB0178", Offset = "0x1CB0178", VA = "0x7BBC4B0178", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x060088B0 RID: 34992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B8")]
			private object Current
			{
				[Token(Token = "0x60088B0")]
				[Address(RVA = "0x1CB05B8", Offset = "0x1CB05B8", VA = "0x7BBC4B05B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060088B1 RID: 34993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088B1")]
			[Address(RVA = "0x1CB05C0", Offset = "0x1CB05C0", VA = "0x7BBC4B05C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x060088B2 RID: 34994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B9")]
			private object Current
			{
				[Token(Token = "0x60088B2")]
				[Address(RVA = "0x1CB0628", Offset = "0x1CB0628", VA = "0x7BBC4B0628", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040096FA RID: 38650
			[Token(Token = "0x40096FA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040096FB RID: 38651
			[Token(Token = "0x40096FB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040096FC RID: 38652
			[Token(Token = "0x40096FC")]
			[FieldOffset(Offset = "0x20")]
			public UILegendClothVaultController <>4__this;

			// Token: 0x040096FD RID: 38653
			[Token(Token = "0x40096FD")]
			[FieldOffset(Offset = "0x28")]
			public float x;

			// Token: 0x040096FE RID: 38654
			[Token(Token = "0x40096FE")]
			[FieldOffset(Offset = "0x2C")]
			public float uix;

			// Token: 0x040096FF RID: 38655
			[Token(Token = "0x40096FF")]
			[FieldOffset(Offset = "0x30")]
			private UIMaleAvatar <avatar>5__2;

			// Token: 0x04009700 RID: 38656
			[Token(Token = "0x4009700")]
			[FieldOffset(Offset = "0x38")]
			private Vector3 <pos>5__3;

			// Token: 0x04009701 RID: 38657
			[Token(Token = "0x4009701")]
			[FieldOffset(Offset = "0x44")]
			private Vector3 <panelPos>5__4;

			// Token: 0x04009702 RID: 38658
			[Token(Token = "0x4009702")]
			[FieldOffset(Offset = "0x50")]
			private float <cdnPosX>5__5;

			// Token: 0x04009703 RID: 38659
			[Token(Token = "0x4009703")]
			[FieldOffset(Offset = "0x54")]
			private int <minDeltaX>5__6;

			// Token: 0x04009704 RID: 38660
			[Token(Token = "0x4009704")]
			[FieldOffset(Offset = "0x58")]
			private int <movePerFrame>5__7;

			// Token: 0x04009705 RID: 38661
			[Token(Token = "0x4009705")]
			[FieldOffset(Offset = "0x5C")]
			private int <panelMovePerFrame>5__8;
		}
	}
}
