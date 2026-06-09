using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001736 RID: 5942
	[Token(Token = "0x2001736")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1BAC", Offset = "0x10F1BAC")]
	internal class UICollectionController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06006F57 RID: 28503 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x209B288", Offset = "0x209B288", VA = "0x7BBC89B288")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F58")]
		[Address(RVA = "0x209B2D8", Offset = "0x209B2D8", VA = "0x7BBC89B2D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F59")]
		[Address(RVA = "0x209CD70", Offset = "0x209CD70", VA = "0x7BBC89CD70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5A")]
		[Address(RVA = "0x209D14C", Offset = "0x209D14C", VA = "0x7BBC89D14C")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x0001F410 File Offset: 0x0001D610
		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0x209D1E4", Offset = "0x209D1E4", VA = "0x7BBC89D1E4", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0x209D1EC", Offset = "0x209D1EC", VA = "0x7BBC89D1EC", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5D")]
		[Address(RVA = "0x209DF30", Offset = "0x209DF30", VA = "0x7BBC89DF30", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5E")]
		[Address(RVA = "0x209DFCC", Offset = "0x209DFCC", VA = "0x7BBC89DFCC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x0001F428 File Offset: 0x0001D628
		[Token(Token = "0x6006F5F")]
		[Address(RVA = "0x209DFD4", Offset = "0x209DFD4", VA = "0x7BBC89DFD4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F60")]
		[Address(RVA = "0x209CA44", Offset = "0x209CA44", VA = "0x7BBC89CA44")]
		private void InitToggles()
		{
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x209DFDC", Offset = "0x209DFDC", VA = "0x7BBC89DFDC")]
		private void SetProfilePreviewPos(ECollectionType cType)
		{
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x209E194", Offset = "0x209E194", VA = "0x7BBC89E194")]
		private void OnBannerToggleClick()
		{
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x209E750", Offset = "0x209E750", VA = "0x7BBC89E750")]
		private void OnHeadPicToggleClick()
		{
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x209E780", Offset = "0x209E780", VA = "0x7BBC89E780")]
		private void OnLootBoxToggleClick()
		{
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x209E78C", Offset = "0x209E78C", VA = "0x7BBC89E78C")]
		private void OnBackPackToggleClick()
		{
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x209E798", Offset = "0x209E798", VA = "0x7BBC89E798")]
		private void OnParachuteToggleClick()
		{
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x209E7A4", Offset = "0x209E7A4", VA = "0x7BBC89E7A4")]
		private void OnSkyboardToggleClick()
		{
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F68")]
		[Address(RVA = "0x209E7B0", Offset = "0x209E7B0", VA = "0x7BBC89E7B0")]
		private void OnFlightToggleClick()
		{
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F69")]
		[Address(RVA = "0x209E7BC", Offset = "0x209E7BC", VA = "0x7BBC89E7BC")]
		private void OnWeaponToggleClick()
		{
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0x209E7C8", Offset = "0x209E7C8", VA = "0x7BBC89E7C8")]
		private void OnVehicleSkinToggleClick()
		{
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0x209E7D4", Offset = "0x209E7D4", VA = "0x7BBC89E7D4")]
		private void OnEmoteToggleClick()
		{
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0x209E7E0", Offset = "0x209E7E0", VA = "0x7BBC89E7E0")]
		private void OnPinToggleClick()
		{
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0x209E1C4", Offset = "0x209E1C4", VA = "0x7BBC89E1C4")]
		private void OnToggleClick(ECollectionType cType, CSSharedItemDataManager.CollectionSubType cSubType)
		{
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0x209F868", Offset = "0x209F868", VA = "0x7BBC89F868")]
		private void UpdateCollectionUI(ECollectionType cType, CSSharedItemDataManager.CollectionSubType cSubType)
		{
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x209F560", Offset = "0x209F560", VA = "0x7BBC89F560")]
		private void LocalSaveReadStatus()
		{
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x209FBC4", Offset = "0x209FBC4", VA = "0x7BBC89FBC4")]
		private void HideUI()
		{
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F71")]
		[Address(RVA = "0x209D670", Offset = "0x209D670", VA = "0x7BBC89D670")]
		private void UpdatePreviewUIParams()
		{
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F72")]
		[Address(RVA = "0x209FC6C", Offset = "0x209FC6C", VA = "0x7BBC89FC6C")]
		private void Update()
		{
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F73")]
		[Address(RVA = "0x209E858", Offset = "0x209E858", VA = "0x7BBC89E858")]
		private void RefreshPreviewBtnsUI()
		{
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F74")]
		[Address(RVA = "0x209FF24", Offset = "0x209FF24", VA = "0x7BBC89FF24")]
		private void UpdateEmoteLabels()
		{
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F75")]
		[Address(RVA = "0x20A028C", Offset = "0x20A028C", VA = "0x7BBC8A028C")]
		private void OnBtnLv1Click()
		{
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x20A02C8", Offset = "0x20A02C8", VA = "0x7BBC8A02C8")]
		private void OnBtnLv2Click()
		{
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F77")]
		[Address(RVA = "0x20A02E4", Offset = "0x20A02E4", VA = "0x7BBC8A02E4")]
		private void OnBtnLv3Click()
		{
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F78")]
		[Address(RVA = "0x20A02FC", Offset = "0x20A02FC", VA = "0x7BBC8A02FC")]
		private void OnSourceTypeMenuClick()
		{
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x20A056C", Offset = "0x20A056C", VA = "0x7BBC8A056C")]
		private void InitSourceTypeCategory()
		{
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7A")]
		private void SplitSourceTypeCategories<T>(Dictionary<string, List<T>> categorys, List<T> items, UICollectionController.GetItemSourceType getItemSourceType)
		{
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7B")]
		private void SplitSourceTypeCategories<T>(Dictionary<string, List<T>> categorys, List<T> items, UICollectionController.GetItemSourceType2 getItemSourceType)
		{
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x209EDA0", Offset = "0x209EDA0", VA = "0x7BBC89EDA0")]
		private void UpdateDefualtSourceType()
		{
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0x20A0CE8", Offset = "0x20A0CE8", VA = "0x7BBC8A0CE8")]
		private void UpdateSourceType(object targetSourceType)
		{
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7E")]
		private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true, bool resetScroll = true)
		{
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x20A1200", Offset = "0x20A1200", VA = "0x7BBC8A1200")]
		public void UpdatePin(uint pinId, bool isPinItem = false)
		{
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F80")]
		[Address(RVA = "0x20A144C", Offset = "0x20A144C", VA = "0x7BBC8A144C")]
		private void UpdateBriefBanner(uint bannerId)
		{
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F81")]
		[Address(RVA = "0x20A162C", Offset = "0x20A162C", VA = "0x7BBC8A162C", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F82")]
		[Address(RVA = "0x20A1708", Offset = "0x20A1708", VA = "0x7BBC8A1708", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F83")]
		[Address(RVA = "0x2096FA8", Offset = "0x2096FA8", VA = "0x7BBC896FA8")]
		public void OnBannerItemSelected(BannerBaseInfo data)
		{
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F84")]
		[Address(RVA = "0x20A1738", Offset = "0x20A1738", VA = "0x7BBC8A1738")]
		public void OnHeadPicItemSelected(HeadPicBaseInfo data)
		{
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F85")]
		[Address(RVA = "0x209912C", Offset = "0x209912C", VA = "0x7BBC89912C")]
		public void OnPinItemSelected(PinBaseInfo data, bool isPinItem = false)
		{
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F86")]
		[Address(RVA = "0x2098C94", Offset = "0x2098C94", VA = "0x7BBC898C94")]
		public void OnLootBoxItemSelected(LootBoxBaseInfo data)
		{
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F87")]
		[Address(RVA = "0x2098EA4", Offset = "0x2098EA4", VA = "0x7BBC898EA4")]
		public void OnParachuteItemSelected(ParachuteBaseInfo data)
		{
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F88")]
		[Address(RVA = "0x2098F7C", Offset = "0x2098F7C", VA = "0x7BBC898F7C")]
		public void OnSkyboardItemSelected(SkyboardBaseInfo data)
		{
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0x2099054", Offset = "0x2099054", VA = "0x7BBC899054")]
		public void OnFlightItemSelected(FlightBaseInfo data)
		{
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8A")]
		[Address(RVA = "0x2098D6C", Offset = "0x2098D6C", VA = "0x7BBC898D6C")]
		public void OnBackPackItemSelected(BackPackBaseInfo data)
		{
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8B")]
		[Address(RVA = "0x209D874", Offset = "0x209D874", VA = "0x7BBC89D874")]
		public void OnEmoteItemSelected(EmoteBaseInfo data, bool isSelect)
		{
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0x209D0A0", Offset = "0x209D0A0", VA = "0x7BBC89D0A0")]
		private void RecycleEmoteAvatar()
		{
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0x20A19EC", Offset = "0x20A19EC", VA = "0x7BBC8A19EC")]
		public UIMaleAvatar GetCurrentAvatar()
		{
			return null;
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0x20A19F4", Offset = "0x20A19F4", VA = "0x7BBC8A19F4")]
		private void OnClickEmoteSlot(params object[] _data)
		{
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0x20A1B68", Offset = "0x20A1B68", VA = "0x7BBC8A1B68")]
		private void RefreshUIBySelectedEmoteSlot(uint emoteID)
		{
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F90")]
		[Address(RVA = "0x209EED8", Offset = "0x209EED8", VA = "0x7BBC89EED8")]
		private void Refresh2DPreview()
		{
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x209F2AC", Offset = "0x209F2AC", VA = "0x7BBC89F2AC")]
		private void RefreshItemPreview()
		{
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F92")]
		[Address(RVA = "0x20A02A8", Offset = "0x20A02A8", VA = "0x7BBC8A02A8")]
		private void SetItemView(BackPackBaseInfo data)
		{
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x20A1960", Offset = "0x20A1960", VA = "0x7BBC8A1960")]
		private void SetItemView(LootBoxBaseInfo data)
		{
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0x20A197C", Offset = "0x20A197C", VA = "0x7BBC8A197C")]
		private void SetItemView(ParachuteBaseInfo data)
		{
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F95")]
		[Address(RVA = "0x20A1998", Offset = "0x20A1998", VA = "0x7BBC8A1998")]
		private void SetItemView(SkyboardBaseInfo data)
		{
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F96")]
		[Address(RVA = "0x20A19B4", Offset = "0x20A19B4", VA = "0x7BBC8A19B4")]
		private void SetItemView(FlightBaseInfo data)
		{
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F97")]
		[Address(RVA = "0x20A2270", Offset = "0x20A2270", VA = "0x7BBC8A2270")]
		private void SetItemView(VehicleSkinBaseInfo data)
		{
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F98")]
		[Address(RVA = "0x20A19D0", Offset = "0x20A19D0", VA = "0x7BBC8A19D0")]
		private void SetItemView(EmoteBaseInfo data)
		{
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F99")]
		[Address(RVA = "0x20A1E20", Offset = "0x20A1E20", VA = "0x7BBC8A1E20")]
		private void ResetItemPreview()
		{
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9A")]
		[Address(RVA = "0x20A1E5C", Offset = "0x20A1E5C", VA = "0x7BBC8A1E5C")]
		private void Update3DPreview(uint collectionId)
		{
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0x20A228C", Offset = "0x20A228C", VA = "0x7BBC8A228C")]
		private void Update3DPreview(uint collectionId, ECollectionLevel level)
		{
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9C")]
		[Address(RVA = "0x20A2470", Offset = "0x20A2470", VA = "0x7BBC8A2470")]
		private void OnEquipBtnClick()
		{
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0x20A26B0", Offset = "0x20A26B0", VA = "0x7BBC8A26B0")]
		private void OnUnEquipBtnClick()
		{
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x0001F440 File Offset: 0x0001D640
		[Token(Token = "0x6006F9E")]
		[Address(RVA = "0x20A26F8", Offset = "0x20A26F8", VA = "0x7BBC8A26F8")]
		public uint GetCurrentEmoteIndex()
		{
			return 0U;
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x0001F458 File Offset: 0x0001D658
		[Token(Token = "0x6006F9F")]
		[Address(RVA = "0x20A2798", Offset = "0x20A2798", VA = "0x7BBC8A2798")]
		public uint GetCurrentEmoteId()
		{
			return 0U;
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x0001F470 File Offset: 0x0001D670
		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0x20A2838", Offset = "0x20A2838", VA = "0x7BBC8A2838")]
		public uint GetFirstEmoteId()
		{
			return 0U;
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA1")]
		[Address(RVA = "0x20A28D8", Offset = "0x20A28D8", VA = "0x7BBC8A28D8")]
		private void OnHelpButtonClicked()
		{
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0x20A2AA4", Offset = "0x20A2AA4", VA = "0x7BBC8A2AA4")]
		private void RefreshEquipBtn()
		{
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x209C6F8", Offset = "0x209C6F8", VA = "0x7BBC89C6F8")]
		private void SetEquipBtnStatus(bool isOwned = true, bool isEquiped = false)
		{
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA4")]
		[Address(RVA = "0x20A1104", Offset = "0x20A1104", VA = "0x7BBC8A1104")]
		private void SetUnEquipBtnStatus(bool isOwned = true, bool isEquiped = false)
		{
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA5")]
		[Address(RVA = "0x209C8E4", Offset = "0x209C8E4", VA = "0x7BBC89C8E4")]
		private void UpdatePreview()
		{
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA6")]
		[Address(RVA = "0x20A3094", Offset = "0x20A3094", VA = "0x7BBC8A3094")]
		public void SetEmoteShowState(bool flag)
		{
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA7")]
		[Address(RVA = "0x209E810", Offset = "0x209E810", VA = "0x7BBC89E810")]
		public void SetEmotepreview(bool flag)
		{
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA8")]
		[Address(RVA = "0x20A30DC", Offset = "0x20A30DC", VA = "0x7BBC8A30DC")]
		private void OnEmoteCheckClick()
		{
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA9")]
		[Address(RVA = "0x20A31F4", Offset = "0x20A31F4", VA = "0x7BBC8A31F4")]
		private void OnCallsignBtnToggled()
		{
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAA")]
		[Address(RVA = "0x20A3368", Offset = "0x20A3368", VA = "0x7BBC8A3368", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x0001F488 File Offset: 0x0001D688
		[Token(Token = "0x6006FAB")]
		[Address(RVA = "0x20A3824", Offset = "0x20A3824", VA = "0x7BBC8A3824", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAC")]
		[Address(RVA = "0x20A38C8", Offset = "0x20A38C8", VA = "0x7BBC8A38C8")]
		public void OnStartDragEmoteInSlot(params object[] data)
		{
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAD")]
		[Address(RVA = "0x20A390C", Offset = "0x20A390C", VA = "0x7BBC8A390C")]
		public void OnEndDragEmoteInSlot(params object[] data)
		{
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAE")]
		[Address(RVA = "0x20A3950", Offset = "0x20A3950", VA = "0x7BBC8A3950")]
		public UICollectionController()
		{
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0x20A4490", Offset = "0x20A4490", VA = "0x7BBC8A4490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11414B0", Offset = "0x11414B0")]
		private void <OnUIInit>b__55_0()
		{
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x20A45EC", Offset = "0x20A45EC", VA = "0x7BBC8A45EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11414C0", Offset = "0x11414C0")]
		private PopMenuData <OnSourceTypeMenuClick>b__87_0(string item)
		{
			return null;
		}

		// Token: 0x0400898B RID: 35211
		[Token(Token = "0x400898B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] m_TabNameArray;

		// Token: 0x0400898C RID: 35212
		[Token(Token = "0x400898C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ETipsType[] m_TabTipArray;

		// Token: 0x0400898D RID: 35213
		[Token(Token = "0x400898D")]
		[FieldOffset(Offset = "0xB0")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x0400898E RID: 35214
		[Token(Token = "0x400898E")]
		[FieldOffset(Offset = "0xB8")]
		private UIStandardTabController m_TabCtrl;

		// Token: 0x0400898F RID: 35215
		[Token(Token = "0x400898F")]
		[FieldOffset(Offset = "0xC0")]
		private UICollectionView m_View;

		// Token: 0x04008990 RID: 35216
		[Token(Token = "0x4008990")]
		[FieldOffset(Offset = "0xC8")]
		private ECollectionType m_CurrentCollectionType;

		// Token: 0x04008991 RID: 35217
		[Token(Token = "0x4008991")]
		[FieldOffset(Offset = "0xCC")]
		private ECollectionLevel m_CurrentCollectionLevel;

		// Token: 0x04008992 RID: 35218
		[Token(Token = "0x4008992")]
		[FieldOffset(Offset = "0xD0")]
		private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionSubType;

		// Token: 0x04008993 RID: 35219
		[Token(Token = "0x4008993")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04008994 RID: 35220
		[Token(Token = "0x4008994")]
		[FieldOffset(Offset = "0xE0")]
		private UIBaseProfileInfoController m_ProfilePreview;

		// Token: 0x04008995 RID: 35221
		[Token(Token = "0x4008995")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_SelectedBanner;

		// Token: 0x04008996 RID: 35222
		[Token(Token = "0x4008996")]
		[FieldOffset(Offset = "0xF0")]
		private BannerBaseInfo m_SelectedBannerData;

		// Token: 0x04008997 RID: 35223
		[Token(Token = "0x4008997")]
		[FieldOffset(Offset = "0xF8")]
		private HeadPicBaseInfo m_SelectedHeadPicData;

		// Token: 0x04008998 RID: 35224
		[Token(Token = "0x4008998")]
		[FieldOffset(Offset = "0x100")]
		private uint m_SelectedHeadPic;

		// Token: 0x04008999 RID: 35225
		[Token(Token = "0x4008999")]
		[FieldOffset(Offset = "0x104")]
		private uint m_SelectedLootBox;

		// Token: 0x0400899A RID: 35226
		[Token(Token = "0x400899A")]
		[FieldOffset(Offset = "0x108")]
		private LootBoxBaseInfo m_SelectedLootBoxData;

		// Token: 0x0400899B RID: 35227
		[Token(Token = "0x400899B")]
		[FieldOffset(Offset = "0x110")]
		private uint m_SelectedBackPack;

		// Token: 0x0400899C RID: 35228
		[Token(Token = "0x400899C")]
		[FieldOffset(Offset = "0x118")]
		private BackPackBaseInfo m_SelectedBackPackData;

		// Token: 0x0400899D RID: 35229
		[Token(Token = "0x400899D")]
		[FieldOffset(Offset = "0x120")]
		private uint m_SelectedParachute;

		// Token: 0x0400899E RID: 35230
		[Token(Token = "0x400899E")]
		[FieldOffset(Offset = "0x128")]
		private ParachuteBaseInfo m_SelectedParachuteData;

		// Token: 0x0400899F RID: 35231
		[Token(Token = "0x400899F")]
		[FieldOffset(Offset = "0x130")]
		private uint m_SelectedSkyboard;

		// Token: 0x040089A0 RID: 35232
		[Token(Token = "0x40089A0")]
		[FieldOffset(Offset = "0x138")]
		private SkyboardBaseInfo m_SelectedSkyboardData;

		// Token: 0x040089A1 RID: 35233
		[Token(Token = "0x40089A1")]
		[FieldOffset(Offset = "0x140")]
		private uint m_SelectedFlight;

		// Token: 0x040089A2 RID: 35234
		[Token(Token = "0x40089A2")]
		[FieldOffset(Offset = "0x148")]
		private FlightBaseInfo m_SelectedFlightData;

		// Token: 0x040089A3 RID: 35235
		[Token(Token = "0x40089A3")]
		[FieldOffset(Offset = "0x150")]
		private uint m_SelectedEmote;

		// Token: 0x040089A4 RID: 35236
		[Token(Token = "0x40089A4")]
		[FieldOffset(Offset = "0x158")]
		private EmoteBaseInfo m_SelectedEmoteData;

		// Token: 0x040089A5 RID: 35237
		[Token(Token = "0x40089A5")]
		[FieldOffset(Offset = "0x160")]
		private uint m_SelectedPin;

		// Token: 0x040089A6 RID: 35238
		[Token(Token = "0x40089A6")]
		[FieldOffset(Offset = "0x168")]
		private PinBaseInfo m_SelectedPinData;

		// Token: 0x040089A7 RID: 35239
		[Token(Token = "0x40089A7")]
		[FieldOffset(Offset = "0x170")]
		private UIEmoteListController m_EmoteListCtrl;

		// Token: 0x040089A8 RID: 35240
		[Token(Token = "0x40089A8")]
		[FieldOffset(Offset = "0x178")]
		private string m_MyAccountId;

		// Token: 0x040089A9 RID: 35241
		[Token(Token = "0x40089A9")]
		[FieldOffset(Offset = "0x180")]
		private UIEasyList m_CurGrid;

		// Token: 0x040089AA RID: 35242
		[Token(Token = "0x40089AA")]
		[FieldOffset(Offset = "0x188")]
		private GameObject m_Preview3DItem;

		// Token: 0x040089AB RID: 35243
		[Token(Token = "0x40089AB")]
		[FieldOffset(Offset = "0x190")]
		private RenderTexture m_ItemPreviewRenderTexture;

		// Token: 0x040089AC RID: 35244
		[Token(Token = "0x40089AC")]
		[FieldOffset(Offset = "0x198")]
		public uint m_3dPreviewCollectionId;

		// Token: 0x040089AD RID: 35245
		[Token(Token = "0x40089AD")]
		[FieldOffset(Offset = "0x1A0")]
		private UIWeaponController m_WeaponCtrl;

		// Token: 0x040089AE RID: 35246
		[Token(Token = "0x40089AE")]
		[FieldOffset(Offset = "0x1A8")]
		private UIVehicleMainController m_VehicleCtrl;

		// Token: 0x040089AF RID: 35247
		[Token(Token = "0x40089AF")]
		[FieldOffset(Offset = "0x1B0")]
		private UIPopMenuBigController m_Pop;

		// Token: 0x040089B0 RID: 35248
		[Token(Token = "0x40089B0")]
		[FieldOffset(Offset = "0x1B8")]
		private UIModelLadderMatch m_LadderModel;

		// Token: 0x040089B1 RID: 35249
		[Token(Token = "0x40089B1")]
		[FieldOffset(Offset = "0x1C0")]
		private float m_PreviewX;

		// Token: 0x040089B2 RID: 35250
		[Token(Token = "0x40089B2")]
		private const string EmoteGuideKey = "COLLECTION_EMOTE_FIRST_GUIDE";

		// Token: 0x040089B3 RID: 35251
		[Token(Token = "0x40089B3")]
		[FieldOffset(Offset = "0x1C8")]
		private string m_CurrentSourceType;

		// Token: 0x040089B4 RID: 35252
		[Token(Token = "0x40089B4")]
		[FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<BannerBaseInfo>> m_BannerSourceTypeCategories;

		// Token: 0x040089B5 RID: 35253
		[Token(Token = "0x40089B5")]
		[FieldOffset(Offset = "0x1D8")]
		private Dictionary<string, List<HeadPicBaseInfo>> m_HeadPicSourceTypeCategories;

		// Token: 0x040089B6 RID: 35254
		[Token(Token = "0x40089B6")]
		[FieldOffset(Offset = "0x1E0")]
		private Dictionary<string, List<LootBoxBaseInfo>> m_LootBoxSourceTypeCategories;

		// Token: 0x040089B7 RID: 35255
		[Token(Token = "0x40089B7")]
		[FieldOffset(Offset = "0x1E8")]
		private Dictionary<string, List<BackPackBaseInfo>> m_BackPackSourceTypeCategories;

		// Token: 0x040089B8 RID: 35256
		[Token(Token = "0x40089B8")]
		[FieldOffset(Offset = "0x1F0")]
		private Dictionary<string, List<ParachuteBaseInfo>> m_ParachuteSourceTypeCategories;

		// Token: 0x040089B9 RID: 35257
		[Token(Token = "0x40089B9")]
		[FieldOffset(Offset = "0x1F8")]
		private Dictionary<string, List<SkyboardBaseInfo>> m_SkyboardSourceTypeCategories;

		// Token: 0x040089BA RID: 35258
		[Token(Token = "0x40089BA")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<string, List<FlightBaseInfo>> m_FlightSourceTypeCategories;

		// Token: 0x040089BB RID: 35259
		[Token(Token = "0x40089BB")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<string, List<EmoteBaseInfo>> m_EmoteSourceTypeCategories;

		// Token: 0x040089BC RID: 35260
		[Token(Token = "0x40089BC")]
		[FieldOffset(Offset = "0x210")]
		private Dictionary<string, List<PinBaseInfo>> m_PinSourceTypeCategories;

		// Token: 0x040089BD RID: 35261
		[Token(Token = "0x40089BD")]
		[FieldOffset(Offset = "0x218")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x040089BE RID: 35262
		[Token(Token = "0x40089BE")]
		[FieldOffset(Offset = "0x220")]
		private List<ECollectionType> m_CollectionTypeList;

		// Token: 0x040089BF RID: 35263
		[Token(Token = "0x40089BF")]
		[FieldOffset(Offset = "0x228")]
		private Dictionary<ECollectionType, Action> m_CollectionActionDict;

		// Token: 0x040089C0 RID: 35264
		[Token(Token = "0x40089C0")]
		[FieldOffset(Offset = "0x230")]
		private UIMaleAvatar m_EmoteAvatar;

		// Token: 0x040089C1 RID: 35265
		[Token(Token = "0x40089C1")]
		[FieldOffset(Offset = "0x10")]
		private static List<string> m_SourceTypes;

		// Token: 0x040089C2 RID: 35266
		[Token(Token = "0x40089C2")]
		[FieldOffset(Offset = "0x18")]
		private static string[] PinSourceTypeStrings;

		// Token: 0x02001737 RID: 5943
		// (Invoke) Token: 0x06006FB3 RID: 28595
		[Token(Token = "0x2001737")]
		private delegate ESourceType GetItemSourceType(object item);

		// Token: 0x02001738 RID: 5944
		// (Invoke) Token: 0x06006FB7 RID: 28599
		[Token(Token = "0x2001738")]
		private delegate EPinSourceType GetItemSourceType2(object item);

		// Token: 0x02001739 RID: 5945
		[Token(Token = "0x2001739")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1BE4", Offset = "0x10F1BE4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006FBB RID: 28603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006FBB")]
			[Address(RVA = "0x20A47C8", Offset = "0x20A47C8", VA = "0x7BBC8A47C8")]
			public <>c()
			{
			}

			// Token: 0x06006FBC RID: 28604 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
			[Token(Token = "0x6006FBC")]
			[Address(RVA = "0x20A47D0", Offset = "0x20A47D0", VA = "0x7BBC8A47D0")]
			internal int <OnUIInit>b__55_1(ECollectionType x, ECollectionType y)
			{
				return 0;
			}

			// Token: 0x06006FBD RID: 28605 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
			[Token(Token = "0x6006FBD")]
			[Address(RVA = "0x20A4898", Offset = "0x20A4898", VA = "0x7BBC8A4898")]
			internal ESourceType <InitSourceTypeCategory>b__88_0(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FBE RID: 28606 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
			[Token(Token = "0x6006FBE")]
			[Address(RVA = "0x20A4A44", Offset = "0x20A4A44", VA = "0x7BBC8A4A44")]
			internal ESourceType <InitSourceTypeCategory>b__88_1(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FBF RID: 28607 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
			[Token(Token = "0x6006FBF")]
			[Address(RVA = "0x20A4BF0", Offset = "0x20A4BF0", VA = "0x7BBC8A4BF0")]
			internal ESourceType <InitSourceTypeCategory>b__88_2(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC0 RID: 28608 RVA: 0x0001F500 File Offset: 0x0001D700
			[Token(Token = "0x6006FC0")]
			[Address(RVA = "0x20A4D9C", Offset = "0x20A4D9C", VA = "0x7BBC8A4D9C")]
			internal ESourceType <InitSourceTypeCategory>b__88_3(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC1 RID: 28609 RVA: 0x0001F518 File Offset: 0x0001D718
			[Token(Token = "0x6006FC1")]
			[Address(RVA = "0x20A4F48", Offset = "0x20A4F48", VA = "0x7BBC8A4F48")]
			internal ESourceType <InitSourceTypeCategory>b__88_4(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC2 RID: 28610 RVA: 0x0001F530 File Offset: 0x0001D730
			[Token(Token = "0x6006FC2")]
			[Address(RVA = "0x20A50F4", Offset = "0x20A50F4", VA = "0x7BBC8A50F4")]
			internal ESourceType <InitSourceTypeCategory>b__88_5(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC3 RID: 28611 RVA: 0x0001F548 File Offset: 0x0001D748
			[Token(Token = "0x6006FC3")]
			[Address(RVA = "0x20A52A0", Offset = "0x20A52A0", VA = "0x7BBC8A52A0")]
			internal ESourceType <InitSourceTypeCategory>b__88_6(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC4 RID: 28612 RVA: 0x0001F560 File Offset: 0x0001D760
			[Token(Token = "0x6006FC4")]
			[Address(RVA = "0x20A544C", Offset = "0x20A544C", VA = "0x7BBC8A544C")]
			internal ESourceType <InitSourceTypeCategory>b__88_7(object item)
			{
				return ESourceType.ALL;
			}

			// Token: 0x06006FC5 RID: 28613 RVA: 0x0001F578 File Offset: 0x0001D778
			[Token(Token = "0x6006FC5")]
			[Address(RVA = "0x20A55F8", Offset = "0x20A55F8", VA = "0x7BBC8A55F8")]
			internal EPinSourceType <InitSourceTypeCategory>b__88_8(object item)
			{
				return EPinSourceType.Default;
			}

			// Token: 0x040089C3 RID: 35267
			[Token(Token = "0x40089C3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICollectionController.<>c <>9;

			// Token: 0x040089C4 RID: 35268
			[Token(Token = "0x40089C4")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ECollectionType> <>9__55_1;

			// Token: 0x040089C5 RID: 35269
			[Token(Token = "0x40089C5")]
			[FieldOffset(Offset = "0x10")]
			public static UICollectionController.GetItemSourceType <>9__88_0;

			// Token: 0x040089C6 RID: 35270
			[Token(Token = "0x40089C6")]
			[FieldOffset(Offset = "0x18")]
			public static UICollectionController.GetItemSourceType <>9__88_1;

			// Token: 0x040089C7 RID: 35271
			[Token(Token = "0x40089C7")]
			[FieldOffset(Offset = "0x20")]
			public static UICollectionController.GetItemSourceType <>9__88_2;

			// Token: 0x040089C8 RID: 35272
			[Token(Token = "0x40089C8")]
			[FieldOffset(Offset = "0x28")]
			public static UICollectionController.GetItemSourceType <>9__88_3;

			// Token: 0x040089C9 RID: 35273
			[Token(Token = "0x40089C9")]
			[FieldOffset(Offset = "0x30")]
			public static UICollectionController.GetItemSourceType <>9__88_4;

			// Token: 0x040089CA RID: 35274
			[Token(Token = "0x40089CA")]
			[FieldOffset(Offset = "0x38")]
			public static UICollectionController.GetItemSourceType <>9__88_5;

			// Token: 0x040089CB RID: 35275
			[Token(Token = "0x40089CB")]
			[FieldOffset(Offset = "0x40")]
			public static UICollectionController.GetItemSourceType <>9__88_6;

			// Token: 0x040089CC RID: 35276
			[Token(Token = "0x40089CC")]
			[FieldOffset(Offset = "0x48")]
			public static UICollectionController.GetItemSourceType <>9__88_7;

			// Token: 0x040089CD RID: 35277
			[Token(Token = "0x40089CD")]
			[FieldOffset(Offset = "0x50")]
			public static UICollectionController.GetItemSourceType2 <>9__88_8;
		}
	}
}
