using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B13 RID: 6931
	[Token(Token = "0x2001B13")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9424", Offset = "0x10F9424")]
	public class UIPreviewItemController : UIBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x0600935E RID: 37726 RVA: 0x000272A0 File Offset: 0x000254A0
		[Token(Token = "0x600935E")]
		[Address(RVA = "0x216FCD4", Offset = "0x216FCD4", VA = "0x7BBC96FCD4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x000272B8 File Offset: 0x000254B8
		[Token(Token = "0x600935F")]
		[Address(RVA = "0x216FD24", Offset = "0x216FD24", VA = "0x7BBC96FD24")]
		public uint GetItemid()
		{
			return 0U;
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x000272D0 File Offset: 0x000254D0
		[Token(Token = "0x6009360")]
		[Address(RVA = "0x216FD2C", Offset = "0x216FD2C", VA = "0x7BBC96FD2C", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009361 RID: 37729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009361")]
		[Address(RVA = "0x216FD90", Offset = "0x216FD90", VA = "0x7BBC96FD90", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009362")]
		[Address(RVA = "0x217045C", Offset = "0x217045C", VA = "0x7BBC97045C")]
		private void RefreshOnly3dItem(uint itemid, uint currentid)
		{
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009363")]
		[Address(RVA = "0x21709A4", Offset = "0x21709A4", VA = "0x7BBC9709A4")]
		private void OnTreasureBoxProbabilityClick()
		{
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009364")]
		[Address(RVA = "0x2170A9C", Offset = "0x2170A9C", VA = "0x7BBC970A9C")]
		public void SetTreasureBoxID(uint id)
		{
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009365")]
		[Address(RVA = "0x21706E0", Offset = "0x21706E0", VA = "0x7BBC9706E0")]
		public void ShowInstallmentInfoBtn(bool show)
		{
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009366")]
		[Address(RVA = "0x2170C60", Offset = "0x2170C60", VA = "0x7BBC970C60")]
		private void OnInstallmentInfoBtnClick()
		{
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009367")]
		[Address(RVA = "0x2170DF4", Offset = "0x2170DF4", VA = "0x7BBC970DF4")]
		public void ShowInstallmentInfo(bool show)
		{
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009368")]
		[Address(RVA = "0x217117C", Offset = "0x217117C", VA = "0x7BBC97117C")]
		public void ShowIPTag()
		{
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009369")]
		[Address(RVA = "0x21713DC", Offset = "0x21713DC", VA = "0x7BBC9713DC")]
		public void ShowIPTag(uint id)
		{
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936A")]
		[Address(RVA = "0x217163C", Offset = "0x217163C", VA = "0x7BBC97163C")]
		public void ShowForgeAwardBtn(bool show, ResourceID iconRes)
		{
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936B")]
		[Address(RVA = "0x2171790", Offset = "0x2171790", VA = "0x7BBC971790")]
		private void OnForgeAwardBtnClick()
		{
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936C")]
		[Address(RVA = "0x217013C", Offset = "0x217013C", VA = "0x7BBC97013C")]
		private void ShowTreasureBoxProbabilityTips(List<RareProbability> probability)
		{
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936D")]
		[Address(RVA = "0x2171918", Offset = "0x2171918", VA = "0x7BBC971918", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936E")]
		[Address(RVA = "0x2173534", Offset = "0x2173534", VA = "0x7BBC973534")]
		public void SetZoomBtnOverride(UIButton ZoomBtn)
		{
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936F")]
		[Address(RVA = "0x2173538", Offset = "0x2173538", VA = "0x7BBC973538")]
		public void SetGachaSwitchVisible(bool flag)
		{
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009370")]
		[Address(RVA = "0x21736F8", Offset = "0x21736F8", VA = "0x7BBC9736F8")]
		public void SetBackpackSwitchVisible(bool flag)
		{
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009371")]
		[Address(RVA = "0x21738D0", Offset = "0x21738D0", VA = "0x7BBC9738D0")]
		public void ClearBackpck()
		{
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009372")]
		[Address(RVA = "0x217392C", Offset = "0x217392C", VA = "0x7BBC97392C")]
		private void OnupdateScrollview(params object[] data)
		{
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009373")]
		[Address(RVA = "0x21739E8", Offset = "0x21739E8", VA = "0x7BBC9739E8")]
		private void OnWeaponSkillClick()
		{
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009374")]
		[Address(RVA = "0x2173C44", Offset = "0x2173C44", VA = "0x7BBC973C44", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009375")]
		[Address(RVA = "0x2172B18", Offset = "0x2172B18", VA = "0x7BBC972B18")]
		private void InitBackPackBtnList()
		{
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009376")]
		[Address(RVA = "0x2172E78", Offset = "0x2172E78", VA = "0x7BBC972E78")]
		private void InitWeaponSkinUpgradeBtnList()
		{
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009377")]
		[Address(RVA = "0x2173E0C", Offset = "0x2173E0C", VA = "0x7BBC973E0C")]
		public void SetWeaponSkinUpgradeLevel(bool isMaxLv)
		{
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009378")]
		[Address(RVA = "0x2173E68", Offset = "0x2173E68", VA = "0x7BBC973E68")]
		private void OnAlignmentClick()
		{
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009379")]
		[Address(RVA = "0x21740A8", Offset = "0x21740A8", VA = "0x7BBC9740A8")]
		private void OnbtnSkillClick()
		{
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937A")]
		[Address(RVA = "0x21745B4", Offset = "0x21745B4", VA = "0x7BBC9745B4")]
		private void OnWeaponSkinBtnClick()
		{
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937B")]
		[Address(RVA = "0x2173178", Offset = "0x2173178", VA = "0x7BBC973178")]
		private void InitHairStyleBtnList()
		{
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937C")]
		[Address(RVA = "0x2174610", Offset = "0x2174610", VA = "0x7BBC974610")]
		private void OnBtnZoomClick()
		{
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937D")]
		[Address(RVA = "0x21746B0", Offset = "0x21746B0", VA = "0x7BBC9746B0")]
		private void OnBtnMagnifierClick()
		{
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937E")]
		[Address(RVA = "0x21749F0", Offset = "0x21749F0", VA = "0x7BBC9749F0")]
		public void SetMagnifierState(bool zoom)
		{
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937F")]
		[Address(RVA = "0x2174A80", Offset = "0x2174A80", VA = "0x7BBC974A80")]
		private void OnbackpckBtnSwitchClick()
		{
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009380")]
		[Address(RVA = "0x2174ED0", Offset = "0x2174ED0", VA = "0x7BBC974ED0")]
		private void OnBtnSwitchClick()
		{
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009381")]
		[Address(RVA = "0x2175298", Offset = "0x2175298", VA = "0x7BBC975298")]
		public void SwitchShowPreview()
		{
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009382")]
		[Address(RVA = "0x2175704", Offset = "0x2175704", VA = "0x7BBC975704")]
		public void RefreshNotificationState()
		{
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009383")]
		[Address(RVA = "0x217581C", Offset = "0x217581C", VA = "0x7BBC97581C")]
		public void OnBtnNotificationClick()
		{
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009384")]
		[Address(RVA = "0x21758C4", Offset = "0x21758C4", VA = "0x7BBC9758C4")]
		public void ClickDefaultBackPack()
		{
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009385")]
		[Address(RVA = "0x2175920", Offset = "0x2175920", VA = "0x7BBC975920")]
		private void OnBtnHairStyleConClick()
		{
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009386")]
		[Address(RVA = "0x2175AD4", Offset = "0x2175AD4", VA = "0x7BBC975AD4")]
		private void OnBtnSpreadCLick()
		{
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009387")]
		[Address(RVA = "0x2175C5C", Offset = "0x2175C5C", VA = "0x7BBC975C5C")]
		private void OnBtnHairStyleRConClick()
		{
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009388")]
		[Address(RVA = "0x2175E10", Offset = "0x2175E10", VA = "0x7BBC975E10")]
		public void ClickDefaultHairStyle()
		{
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009389")]
		[Address(RVA = "0x2176084", Offset = "0x2176084", VA = "0x7BBC976084")]
		public void SetCommonPanel(Vector3 left, Vector3 right, bool needZoom, EFrontendUIType uitype)
		{
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938A")]
		[Address(RVA = "0x2178190", Offset = "0x2178190", VA = "0x7BBC978190")]
		public void SetCollecionBag(bool flag)
		{
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x000272E8 File Offset: 0x000254E8
		[Token(Token = "0x600938B")]
		[Address(RVA = "0x217819C", Offset = "0x217819C", VA = "0x7BBC97819C")]
		public double GetModelX()
		{
			return 0.0;
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938C")]
		[Address(RVA = "0x21708DC", Offset = "0x21708DC", VA = "0x7BBC9708DC")]
		public void SetSpIconPos()
		{
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938D")]
		[Address(RVA = "0x2170AA4", Offset = "0x2170AA4", VA = "0x7BBC970AA4")]
		public void SetDefaultIconPos()
		{
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938E")]
		[Address(RVA = "0x2172A80", Offset = "0x2172A80", VA = "0x7BBC972A80")]
		public void InitTreaboxOpenState()
		{
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938F")]
		[Address(RVA = "0x21781A8", Offset = "0x21781A8", VA = "0x7BBC9781A8")]
		public void RefreshTreasureBox()
		{
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009390")]
		[Address(RVA = "0x21781B0", Offset = "0x21781B0", VA = "0x7BBC9781B0")]
		public void SetTreasureBoxProbabilityState(bool show)
		{
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009391")]
		[Address(RVA = "0x2178230", Offset = "0x2178230", VA = "0x7BBC978230")]
		public void SetModelX(Vector3 pos)
		{
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009392")]
		[Address(RVA = "0x2178350", Offset = "0x2178350", VA = "0x7BBC978350")]
		public void SetPanelWidth(int width, bool left, Vector3 trans, bool needZoom, EFrontendUIType uitype)
		{
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009393")]
		[Address(RVA = "0x2178C84", Offset = "0x2178C84", VA = "0x7BBC978C84")]
		public void CreatePreview2dItem()
		{
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009394")]
		[Address(RVA = "0x2178F94", Offset = "0x2178F94", VA = "0x7BBC978F94")]
		public void ClosePreview2dItem()
		{
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009395")]
		[Address(RVA = "0x217902C", Offset = "0x217902C", VA = "0x7BBC97902C")]
		public void ShowPreview2DItem(bool show = true)
		{
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009396")]
		[Address(RVA = "0x21790F0", Offset = "0x21790F0", VA = "0x7BBC9790F0")]
		public void SetSpecial2dItemUIdata(BaseItemInfo data, EFrontendUIType type)
		{
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009397")]
		[Address(RVA = "0x2179138", Offset = "0x2179138", VA = "0x7BBC979138")]
		public void Set2dItemUIdata(CSSharedItemData data, EFrontendUIType type)
		{
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009398")]
		[Address(RVA = "0x2179180", Offset = "0x2179180", VA = "0x7BBC979180")]
		public void Set2dItemLeftAnchor(int biasLeft, int biasRight, int biasTop, int biasBottom)
		{
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009399")]
		[Address(RVA = "0x21791E0", Offset = "0x21791E0", VA = "0x7BBC9791E0")]
		public void Set2dItemRightAnchor()
		{
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939A")]
		[Address(RVA = "0x2179210", Offset = "0x2179210", VA = "0x7BBC979210")]
		public void Set2dItemScale(int num = 1)
		{
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939B")]
		[Address(RVA = "0x21792F0", Offset = "0x21792F0", VA = "0x7BBC9792F0")]
		public void SetLowPostion()
		{
		}

		// Token: 0x0600939C RID: 37788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939C")]
		[Address(RVA = "0x21794A4", Offset = "0x21794A4", VA = "0x7BBC9794A4")]
		public void SetSpRightPosition()
		{
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939D")]
		[Address(RVA = "0x21794A8", Offset = "0x21794A8", VA = "0x7BBC9794A8")]
		private void SetOriginRightPostion()
		{
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939E")]
		[Address(RVA = "0x2179764", Offset = "0x2179764", VA = "0x7BBC979764")]
		public void SetSpecialData(string name, string desc, bool flag)
		{
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600939F")]
		[Address(RVA = "0x217A16C", Offset = "0x217A16C", VA = "0x7BBC97A16C")]
		private void RefreshHairStyleItemByLv(int level)
		{
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A0")]
		[Address(RVA = "0x217A2E8", Offset = "0x217A2E8", VA = "0x7BBC97A2E8")]
		private void RefreshCollectionItemByLv(ECollectionLevel collectionLevel)
		{
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A1")]
		[Address(RVA = "0x217A450", Offset = "0x217A450", VA = "0x7BBC97A450")]
		public void RefreshWeaponSkinUpgradeItemByLv(ECollectionLevel collectionLevel)
		{
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A2")]
		[Address(RVA = "0x217A6D4", Offset = "0x217A6D4", VA = "0x7BBC97A6D4")]
		public void RefreshCollectionBackPack()
		{
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A3")]
		[Address(RVA = "0x217A78C", Offset = "0x217A78C", VA = "0x7BBC97A78C")]
		public void CloseUIExceptMagn()
		{
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A4")]
		[Address(RVA = "0x217AEFC", Offset = "0x217AEFC", VA = "0x7BBC97AEFC")]
		public void CLoseALLUI()
		{
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A5")]
		[Address(RVA = "0x217B744", Offset = "0x217B744", VA = "0x7BBC97B744")]
		public void CloseUIInGacha()
		{
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A6")]
		[Address(RVA = "0x217BB84", Offset = "0x217BB84", VA = "0x7BBC97BB84")]
		public void SetItemData(uint id)
		{
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A7")]
		[Address(RVA = "0x217CE60", Offset = "0x217CE60", VA = "0x7BBC97CE60")]
		public void SetNewQuaityIcon(uint id)
		{
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x00027300 File Offset: 0x00025500
		[Token(Token = "0x60093A8")]
		[Address(RVA = "0x217D050", Offset = "0x217D050", VA = "0x7BBC97D050")]
		private Color32 GetSkillBgColor(char type)
		{
			return default(Color32);
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093A9")]
		[Address(RVA = "0x217D0B8", Offset = "0x217D0B8", VA = "0x7BBC97D0B8")]
		public void SetNewQuaitySpIcon(EInventory.AwardType type)
		{
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AA")]
		[Address(RVA = "0x217A6CC", Offset = "0x217A6CC", VA = "0x7BBC97A6CC")]
		public void SetItemID(uint id)
		{
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AB")]
		[Address(RVA = "0x217D280", Offset = "0x217D280", VA = "0x7BBC97D280")]
		public void CloseBundlePreview()
		{
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AC")]
		[Address(RVA = "0x217D2DC", Offset = "0x217D2DC", VA = "0x7BBC97D2DC")]
		public void RefreshBundlePreviewTab(List<BaseItemInfo> list, CSSharedItemDataManager.ItemType type, bool flag, bool isOwned, [Optional] ShowBoostAvatarParams showBoostAvatarParams, bool showPreviewScrollView = true)
		{
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AD")]
		[Address(RVA = "0x217D814", Offset = "0x217D814", VA = "0x7BBC97D814")]
		public void SetRefreshBundleFlag(bool flag)
		{
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AE")]
		[Address(RVA = "0x217D820", Offset = "0x217D820", VA = "0x7BBC97D820")]
		public void RefreshCratePreviewTab(List<BaseItemInfo> list)
		{
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093AF")]
		[Address(RVA = "0x217D904", Offset = "0x217D904", VA = "0x7BBC97D904")]
		public void ReRearrangePreviewTab()
		{
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B0")]
		[Address(RVA = "0x2179AC0", Offset = "0x2179AC0", VA = "0x7BBC979AC0")]
		private void SetOriginal()
		{
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B1")]
		[Address(RVA = "0x217D948", Offset = "0x217D948", VA = "0x7BBC97D948")]
		private void OnCloseTips()
		{
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B2")]
		[Address(RVA = "0x217D9BC", Offset = "0x217D9BC", VA = "0x7BBC97D9BC")]
		private void OnCloseWeaponSkinTips()
		{
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B3")]
		[Address(RVA = "0x217DA18", Offset = "0x217DA18", VA = "0x7BBC97DA18")]
		private void OnShowIconBtnClick()
		{
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B4")]
		[Address(RVA = "0x217DBE4", Offset = "0x217DBE4", VA = "0x7BBC97DBE4")]
		private void OnGotoWeaponSkinUpgraderClick()
		{
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B5")]
		[Address(RVA = "0x217DDC0", Offset = "0x217DDC0", VA = "0x7BBC97DDC0")]
		private void OnWeaponSkinUpgradeInfoIconClick()
		{
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B6")]
		[Address(RVA = "0x217E688", Offset = "0x217E688", VA = "0x7BBC97E688")]
		private void OnNotificationIconBtnClick()
		{
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B7")]
		[Address(RVA = "0x217E854", Offset = "0x217E854", VA = "0x7BBC97E854")]
		private void OnDownloadBtnClick()
		{
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B8")]
		[Address(RVA = "0x217EAD8", Offset = "0x217EAD8", VA = "0x7BBC97EAD8")]
		private void OnPvpToggleClick()
		{
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093B9")]
		[Address(RVA = "0x217ED9C", Offset = "0x217ED9C", VA = "0x7BBC97ED9C")]
		private void OnPveToggleClick()
		{
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093BA")]
		[Address(RVA = "0x217EAE4", Offset = "0x217EAE4", VA = "0x7BBC97EAE4")]
		private void ShowPropertyContainer(bool isVisible, UIPreviewItemController.PropertyType pType)
		{
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093BB")]
		[Address(RVA = "0x217A168", Offset = "0x217A168", VA = "0x7BBC97A168")]
		private void SetRenderText()
		{
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093BC")]
		[Address(RVA = "0x217EE60", Offset = "0x217EE60", VA = "0x7BBC97EE60")]
		public void SetItemDescYPos(float nameposY, float descposY)
		{
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x00027318 File Offset: 0x00025518
		[Token(Token = "0x60093BD")]
		[Address(RVA = "0x217F094", Offset = "0x217F094", VA = "0x7BBC97F094")]
		public Vector2 GetItemNameWorldPos()
		{
			return default(Vector2);
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x00027330 File Offset: 0x00025530
		[Token(Token = "0x60093BE")]
		[Address(RVA = "0x217F1E4", Offset = "0x217F1E4", VA = "0x7BBC97F1E4")]
		public Vector2 GetItemDescWorldPos()
		{
			return default(Vector2);
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x00027348 File Offset: 0x00025548
		[Token(Token = "0x60093BF")]
		[Address(RVA = "0x217F334", Offset = "0x217F334", VA = "0x7BBC97F334")]
		public Vector2 GetItemDownloadBtnPos()
		{
			return default(Vector2);
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C0")]
		[Address(RVA = "0x217D638", Offset = "0x217D638", VA = "0x7BBC97D638")]
		private void SetBundleText()
		{
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093C1")]
		[Address(RVA = "0x217F3CC", Offset = "0x217F3CC", VA = "0x7BBC97F3CC")]
		public GameObject GetItemDesc()
		{
			return null;
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C2")]
		[Address(RVA = "0x217F3F8", Offset = "0x217F3F8", VA = "0x7BBC97F3F8")]
		public void DisVisbleIconTableInfo()
		{
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C3")]
		[Address(RVA = "0x217F608", Offset = "0x217F608", VA = "0x7BBC97F608")]
		public void RefreshItemDesc(uint itemid)
		{
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C4")]
		[Address(RVA = "0x217BBB4", Offset = "0x217BBB4", VA = "0x7BBC97BBB4")]
		public void RefreshItemView()
		{
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x00027360 File Offset: 0x00025560
		[Token(Token = "0x60093C5")]
		[Address(RVA = "0x2180900", Offset = "0x2180900", VA = "0x7BBC980900")]
		public bool CheckIDInvaild(uint itemid)
		{
			return default(bool);
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C6")]
		[Address(RVA = "0x2180950", Offset = "0x2180950", VA = "0x7BBC980950")]
		public void SetItemDesc(string name, string description)
		{
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C7")]
		[Address(RVA = "0x2180C48", Offset = "0x2180C48", VA = "0x7BBC980C48")]
		public void DisplayWeaponPropertyScore(bool show)
		{
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C8")]
		[Address(RVA = "0x2180F84", Offset = "0x2180F84", VA = "0x7BBC980F84")]
		public void RefreshWeaponPropertyScore(uint itemid, EFrontendUIType uitype = EFrontendUIType.Mall)
		{
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093C9")]
		[Address(RVA = "0x2181C24", Offset = "0x2181C24", VA = "0x7BBC981C24")]
		public void RefreshVehicleSkinPropertyScore(uint itemid, EFrontendUIType uitype = EFrontendUIType.Mall)
		{
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093CA")]
		[Address(RVA = "0x2182960", Offset = "0x2182960", VA = "0x7BBC982960")]
		public void SetWeaponPropertyVisible(bool isVisible)
		{
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x00027378 File Offset: 0x00025578
		[Token(Token = "0x60093CB")]
		[Address(RVA = "0x217EDA8", Offset = "0x217EDA8", VA = "0x7BBC97EDA8")]
		public bool SetWeaponPvpPropertyScoreVisble(bool isVisble)
		{
			return default(bool);
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093CC")]
		[Address(RVA = "0x2181B2C", Offset = "0x2181B2C", VA = "0x7BBC981B2C")]
		public void SetWeaponSkinUpgradeLevelVisble(bool isVisble)
		{
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093CD")]
		[Address(RVA = "0x21829A8", Offset = "0x21829A8", VA = "0x7BBC9829A8")]
		public void SetBackPackIconVisble(bool isVisble)
		{
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093CE")]
		[Address(RVA = "0x2182A10", Offset = "0x2182A10", VA = "0x7BBC982A10")]
		public void SetHairStyleIconVisble(bool isVisble)
		{
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093CF")]
		[Address(RVA = "0x2182A78", Offset = "0x2182A78", VA = "0x7BBC982A78")]
		public void SetMagnifierVisble(bool isVisble)
		{
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00027390 File Offset: 0x00025590
		[Token(Token = "0x60093D0")]
		[Address(RVA = "0x2182B30", Offset = "0x2182B30", VA = "0x7BBC982B30")]
		public bool GetMagnifierState()
		{
			return default(bool);
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D1")]
		[Address(RVA = "0x2182B38", Offset = "0x2182B38", VA = "0x7BBC982B38")]
		public void SetSkillVisble(bool isVisble)
		{
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D2")]
		[Address(RVA = "0x2182BE8", Offset = "0x2182BE8", VA = "0x7BBC982BE8")]
		public void SetAlignmentVisble(bool show)
		{
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D3")]
		[Address(RVA = "0x2182C48", Offset = "0x2182C48", VA = "0x7BBC982C48")]
		public void RefreshRealItemid(uint itemid)
		{
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D4")]
		[Address(RVA = "0x2182C54", Offset = "0x2182C54", VA = "0x7BBC982C54")]
		public void RefreshCurrentItemId(uint itemid)
		{
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D5")]
		[Address(RVA = "0x2181BA0", Offset = "0x2181BA0", VA = "0x7BBC981BA0")]
		private void RefreshScoreGrid(params object[] data)
		{
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D6")]
		private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true)
		{
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093D7")]
		[Address(RVA = "0x2182C5C", Offset = "0x2182C5C", VA = "0x7BBC982C5C", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D8")]
		[Address(RVA = "0x2182D54", Offset = "0x2182D54", VA = "0x7BBC982D54", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093D9")]
		[Address(RVA = "0x2182D84", Offset = "0x2182D84", VA = "0x7BBC982D84")]
		public void HideDetails(bool v)
		{
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DA")]
		[Address(RVA = "0x2182D90", Offset = "0x2182D90", VA = "0x7BBC982D90")]
		public void SetSwithBtnVisble(bool need_show, UIPreviewItemController.SwitchType type = UIPreviewItemController.SwitchType.Gun)
		{
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DB")]
		[Address(RVA = "0x2182EEC", Offset = "0x2182EEC", VA = "0x7BBC982EEC")]
		public void SetNotificationBtnVisble(bool need_show, bool needCombine = false)
		{
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DC")]
		[Address(RVA = "0x2183A00", Offset = "0x2183A00", VA = "0x7BBC983A00")]
		public void SetShowIconVisble(bool need_show)
		{
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DD")]
		[Address(RVA = "0x2183CEC", Offset = "0x2183CEC", VA = "0x7BBC983CEC")]
		public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
		{
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DE")]
		[Address(RVA = "0x2183FD8", Offset = "0x2183FD8", VA = "0x7BBC983FD8")]
		public void ShowAvatarSkill(uint avatarID)
		{
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DF")]
		[Address(RVA = "0x2184544", Offset = "0x2184544", VA = "0x7BBC984544")]
		public void ShowAvatarAlignment(uint avatarID)
		{
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E0")]
		[Address(RVA = "0x21847A4", Offset = "0x21847A4", VA = "0x7BBC9847A4")]
		public void ShowPetSkill(uint petid)
		{
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E1")]
		[Address(RVA = "0x2184D94", Offset = "0x2184D94", VA = "0x7BBC984D94")]
		public void ShowAvatarDefaultPVEWeapon(uint avatarId)
		{
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x000273A8 File Offset: 0x000255A8
		[Token(Token = "0x60093E2")]
		[Address(RVA = "0x21850E4", Offset = "0x21850E4", VA = "0x7BBC9850E4")]
		public bool GetHotFixShow()
		{
			return default(bool);
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E3")]
		[Address(RVA = "0x218513C", Offset = "0x218513C", VA = "0x7BBC98513C")]
		public void SetHotFixTextShow(bool show)
		{
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E4")]
		[Address(RVA = "0x2175184", Offset = "0x2175184", VA = "0x7BBC975184")]
		private void SwithChange(UIPreviewItemController.SwitchType type)
		{
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E5")]
		[Address(RVA = "0x21735E4", Offset = "0x21735E4", VA = "0x7BBC9735E4")]
		private void GachaSwitchChange(UIPreviewItemController.SwitchType type)
		{
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E6")]
		[Address(RVA = "0x2173764", Offset = "0x2173764", VA = "0x7BBC973764")]
		private void BackPackSwitchChange(UIPreviewItemController.BackpackSwithType type)
		{
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E7")]
		[Address(RVA = "0x2185348", Offset = "0x2185348", VA = "0x7BBC985348")]
		public void SetTweenEnabled(bool enabled)
		{
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E8")]
		[Address(RVA = "0x2174D40", Offset = "0x2174D40", VA = "0x7BBC974D40")]
		public void SetZoomBtnVisible(bool showzoomspr, bool showplayspr = true)
		{
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E9")]
		[Address(RVA = "0x2185410", Offset = "0x2185410", VA = "0x7BBC985410")]
		public void SetPanelDepth(int depth)
		{
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093EA")]
		[Address(RVA = "0x2185458", Offset = "0x2185458", VA = "0x7BBC985458")]
		public UIPreviewItemController()
		{
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093EB")]
		[Address(RVA = "0x2185640", Offset = "0x2185640", VA = "0x7BBC985640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B30", Offset = "0x1144B30")]
		private void <ShowInstallmentInfo>b__57_0()
		{
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093EC")]
		[Address(RVA = "0x218573C", Offset = "0x218573C", VA = "0x7BBC98573C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B40", Offset = "0x1144B40")]
		private void <OnUIInit>b__63_0(int length)
		{
		}

		// Token: 0x04009D92 RID: 40338
		[Token(Token = "0x4009D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

		// Token: 0x04009D93 RID: 40339
		[Token(Token = "0x4009D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool EnableOptionalDownloadRefresh;

		// Token: 0x04009D94 RID: 40340
		[Token(Token = "0x4009D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private UIPreviewItemController.PropertyType m_PropertyType;

		// Token: 0x04009D95 RID: 40341
		[Token(Token = "0x4009D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIPreviewItemView m_View;

		// Token: 0x04009D96 RID: 40342
		[Token(Token = "0x4009D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private uint m_Itemid;

		// Token: 0x04009D97 RID: 40343
		[Token(Token = "0x4009D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private uint m_CurrentItemid;

		// Token: 0x04009D98 RID: 40344
		[Token(Token = "0x4009D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private EFrontendUIType m_UiType;

		// Token: 0x04009D99 RID: 40345
		[Token(Token = "0x4009D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int panelwidth;

		// Token: 0x04009D9A RID: 40346
		[Token(Token = "0x4009D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool onleft;

		// Token: 0x04009D9B RID: 40347
		[Token(Token = "0x4009D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool onCenter;

		// Token: 0x04009D9C RID: 40348
		[Token(Token = "0x4009D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool m_HideDetails;

		// Token: 0x04009D9D RID: 40349
		[Token(Token = "0x4009D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		private bool m_NeedZoom;

		// Token: 0x04009D9E RID: 40350
		[Token(Token = "0x4009D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool isShowOwned;

		// Token: 0x04009D9F RID: 40351
		[Token(Token = "0x4009D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private uint m_RealId;

		// Token: 0x04009DA0 RID: 40352
		[Token(Token = "0x4009DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIRoot m_UIRoot;

		// Token: 0x04009DA1 RID: 40353
		[Token(Token = "0x4009DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIPreviewItemController.SwitchType m_Swithtype;

		// Token: 0x04009DA2 RID: 40354
		[Token(Token = "0x4009DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private UIPreviewItemController.BackpackSwithType m_BackSwithType;

		// Token: 0x04009DA3 RID: 40355
		[Token(Token = "0x4009DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_ModelPosX;

		// Token: 0x04009DA4 RID: 40356
		[Token(Token = "0x4009DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool m_MagnifierState;

		// Token: 0x04009DA5 RID: 40357
		[Token(Token = "0x4009DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<UIToggleButton> m_BackPackBtnL;

		// Token: 0x04009DA6 RID: 40358
		[Token(Token = "0x4009DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<UIToggleButton> m_BackPackBtnR;

		// Token: 0x04009DA7 RID: 40359
		[Token(Token = "0x4009DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<UIToggleButton> m_HairStyleBtnL;

		// Token: 0x04009DA8 RID: 40360
		[Token(Token = "0x4009DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<UIToggleButton> m_HairStyleBtnR;

		// Token: 0x04009DA9 RID: 40361
		[Token(Token = "0x4009DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Dictionary<UIModelAvatarBase.EClothGenderType, string> m_GenderSpr;

		// Token: 0x04009DAA RID: 40362
		[Token(Token = "0x4009DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UIWeaponKillNotificationItemController m_KillNotification;

		// Token: 0x04009DAB RID: 40363
		[Token(Token = "0x4009DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UI2dCommonController m_2dPreviewitem;

		// Token: 0x04009DAC RID: 40364
		[Token(Token = "0x4009DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private uint m_WeaponScoreOpen;

		// Token: 0x04009DAD RID: 40365
		[Token(Token = "0x4009DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ShowBoostAvatarParams m_ShowBoostAvatarParmas;

		// Token: 0x04009DAE RID: 40366
		[Token(Token = "0x4009DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIPVEWeaponPropertyController m_SelectedWeaponPveProperty;

		// Token: 0x04009DAF RID: 40367
		[Token(Token = "0x4009DAF")]
		private const uint AVATARNAMECOLOR = 4290380031U;

		// Token: 0x04009DB0 RID: 40368
		[Token(Token = "0x4009DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIModelMall m_ModelMall;

		// Token: 0x04009DB1 RID: 40369
		[Token(Token = "0x4009DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_TreasureBoxOpenState;

		// Token: 0x04009DB2 RID: 40370
		[Token(Token = "0x4009DB2")]
		private const uint m_itemClothFemaleMin = 203000578U;

		// Token: 0x04009DB3 RID: 40371
		[Token(Token = "0x4009DB3")]
		private const uint m_itemClothFemaleMax = 203999999U;

		// Token: 0x04009DB4 RID: 40372
		[Token(Token = "0x4009DB4")]
		private const uint m_itemClothMaleMin = 211000343U;

		// Token: 0x04009DB5 RID: 40373
		[Token(Token = "0x4009DB5")]
		private const uint m_itemClothMaleMax = 211999999U;

		// Token: 0x04009DB6 RID: 40374
		[Token(Token = "0x4009DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UIClickMask m_ClickMask;

		// Token: 0x04009DB7 RID: 40375
		[Token(Token = "0x4009DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Color32 m_Green;

		// Token: 0x04009DB8 RID: 40376
		[Token(Token = "0x4009DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Color32 m_Yellow;

		// Token: 0x04009DB9 RID: 40377
		[Token(Token = "0x4009DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Color32 m_Red;

		// Token: 0x04009DBA RID: 40378
		[Token(Token = "0x4009DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool m_CurrentItemState;

		// Token: 0x04009DBB RID: 40379
		[Token(Token = "0x4009DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private uint m_TreasureBoxID;

		// Token: 0x04009DBC RID: 40380
		[Token(Token = "0x4009DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool m_CollectionBag;

		// Token: 0x04009DBD RID: 40381
		[Token(Token = "0x4009DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private AvatarSkillData m_SkillData;

		// Token: 0x04009DBE RID: 40382
		[Token(Token = "0x4009DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool m_RefreshBundleTab;

		// Token: 0x02001B14 RID: 6932
		[Token(Token = "0x2001B14")]
		public enum SwitchType
		{
			// Token: 0x04009DC0 RID: 40384
			[Token(Token = "0x4009DC0")]
			Gun,
			// Token: 0x04009DC1 RID: 40385
			[Token(Token = "0x4009DC1")]
			Person
		}

		// Token: 0x02001B15 RID: 6933
		[Token(Token = "0x2001B15")]
		public enum BackpackSwithType
		{
			// Token: 0x04009DC3 RID: 40387
			[Token(Token = "0x4009DC3")]
			Backpack,
			// Token: 0x04009DC4 RID: 40388
			[Token(Token = "0x4009DC4")]
			Person
		}

		// Token: 0x02001B16 RID: 6934
		[Token(Token = "0x2001B16")]
		public enum PropertyType
		{
			// Token: 0x04009DC6 RID: 40390
			[Token(Token = "0x4009DC6")]
			None,
			// Token: 0x04009DC7 RID: 40391
			[Token(Token = "0x4009DC7")]
			Pve,
			// Token: 0x04009DC8 RID: 40392
			[Token(Token = "0x4009DC8")]
			Pvp,
			// Token: 0x04009DC9 RID: 40393
			[Token(Token = "0x4009DC9")]
			VehicleSkin
		}

		// Token: 0x02001B17 RID: 6935
		[Token(Token = "0x2001B17")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F945C", Offset = "0x10F945C")]
		private sealed class <>c__DisplayClass149_0
		{
			// Token: 0x060093ED RID: 37869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60093ED")]
			[Address(RVA = "0x2180940", Offset = "0x2180940", VA = "0x7BBC980940")]
			public <>c__DisplayClass149_0()
			{
			}

			// Token: 0x060093EE RID: 37870 RVA: 0x000273C0 File Offset: 0x000255C0
			[Token(Token = "0x60093EE")]
			[Address(RVA = "0x2185788", Offset = "0x2185788", VA = "0x7BBC985788")]
			internal bool <RefreshItemDesc>b__0(PetInfo x)
			{
				return default(bool);
			}

			// Token: 0x04009DCA RID: 40394
			[Token(Token = "0x4009DCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint petId;
		}

		// Token: 0x02001B18 RID: 6936
		[Token(Token = "0x2001B18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F946C", Offset = "0x10F946C")]
		private sealed class <>c__DisplayClass150_0
		{
			// Token: 0x060093EF RID: 37871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60093EF")]
			[Address(RVA = "0x2180948", Offset = "0x2180948", VA = "0x7BBC980948")]
			public <>c__DisplayClass150_0()
			{
			}

			// Token: 0x060093F0 RID: 37872 RVA: 0x000273D8 File Offset: 0x000255D8
			[Token(Token = "0x60093F0")]
			[Address(RVA = "0x21857C4", Offset = "0x21857C4", VA = "0x7BBC9857C4")]
			internal bool <RefreshItemView>b__0(PetInfo x)
			{
				return default(bool);
			}

			// Token: 0x04009DCB RID: 40395
			[Token(Token = "0x4009DCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PetSkinData petdata;
		}
	}
}
