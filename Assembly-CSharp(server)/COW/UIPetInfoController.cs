using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AEE RID: 6894
	[Token(Token = "0x2001AEE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8EEC", Offset = "0x10F8EEC")]
	public class UIPetInfoController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x0600922B RID: 37419 RVA: 0x00026E50 File Offset: 0x00025050
		[Token(Token = "0x600922B")]
		[Address(RVA = "0x20D5EA4", Offset = "0x20D5EA4", VA = "0x7BBC8D5EA4", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600922C")]
		[Address(RVA = "0x20D5F28", Offset = "0x20D5F28", VA = "0x7BBC8D5F28", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x00026E68 File Offset: 0x00025068
		[Token(Token = "0x600922D")]
		[Address(RVA = "0x20D7874", Offset = "0x20D7874", VA = "0x7BBC8D7874")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x00026E80 File Offset: 0x00025080
		[Token(Token = "0x600922E")]
		[Address(RVA = "0x20D78C4", Offset = "0x20D78C4", VA = "0x7BBC8D78C4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600922F")]
		[Address(RVA = "0x20D78CC", Offset = "0x20D78CC", VA = "0x7BBC8D78CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009230")]
		[Address(RVA = "0x20D8B70", Offset = "0x20D8B70", VA = "0x7BBC8D8B70")]
		private void OnActionBtnClick()
		{
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009231")]
		[Address(RVA = "0x20D8DD8", Offset = "0x20D8DD8", VA = "0x7BBC8D8DD8")]
		private void OnSkinBtnClick()
		{
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009232")]
		[Address(RVA = "0x20D8F68", Offset = "0x20D8F68", VA = "0x7BBC8D8F68")]
		private void OnSkillBtnClick()
		{
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009233")]
		[Address(RVA = "0x20D8440", Offset = "0x20D8440", VA = "0x7BBC8D8440")]
		private void SetTitleBtnState(UIShowType type)
		{
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009234")]
		[Address(RVA = "0x20D911C", Offset = "0x20D911C", VA = "0x7BBC8D911C")]
		private void PlayAnimation(params object[] param)
		{
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009235")]
		[Address(RVA = "0x20D9A78", Offset = "0x20D9A78", VA = "0x7BBC8D9A78")]
		private void ChangeSkin(params object[] param)
		{
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009236")]
		[Address(RVA = "0x20D9B84", Offset = "0x20D9B84", VA = "0x7BBC8D9B84")]
		private void ChangeSelectSkill(params object[] param)
		{
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009237")]
		[Address(RVA = "0x20D9408", Offset = "0x20D9408", VA = "0x7BBC8D9408")]
		private void RefreshInfoContainer(CSSharedItemData inventoryItem)
		{
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009238")]
		[Address(RVA = "0x20D764C", Offset = "0x20D764C", VA = "0x7BBC8D764C")]
		private void LevelUpShow()
		{
		}

		// Token: 0x06009239 RID: 37433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009239")]
		[Address(RVA = "0x20D9C84", Offset = "0x20D9C84", VA = "0x7BBC8D9C84")]
		private void RefreshPriviewUIShow()
		{
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923A")]
		[Address(RVA = "0x20D9E0C", Offset = "0x20D9E0C", VA = "0x7BBC8D9E0C")]
		protected void HighLightItem(int itemIndex, UIEasyList grid, bool needClick = false, bool showTips = false)
		{
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923B")]
		[Address(RVA = "0x20DA07C", Offset = "0x20DA07C", VA = "0x7BBC8DA07C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923C")]
		[Address(RVA = "0x20D6BC4", Offset = "0x20D6BC4", VA = "0x7BBC8D6BC4")]
		private void RefreshPetList()
		{
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923D")]
		[Address(RVA = "0x20DA084", Offset = "0x20DA084", VA = "0x7BBC8DA084")]
		private void OnBuyPetClick()
		{
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923E")]
		[Address(RVA = "0x20DA21C", Offset = "0x20DA21C", VA = "0x7BBC8DA21C")]
		private void BuyPet()
		{
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923F")]
		[Address(RVA = "0x20D7650", Offset = "0x20D7650", VA = "0x7BBC8D7650")]
		public void CheckNewTag(params object[] param)
		{
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009240")]
		[Address(RVA = "0x20D8D94", Offset = "0x20D8D94", VA = "0x7BBC8D8D94")]
		private void ResetItemInfoShow()
		{
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009241")]
		[Address(RVA = "0x20DA55C", Offset = "0x20DA55C", VA = "0x7BBC8DA55C")]
		private void GotoPet(params object[] param)
		{
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009242")]
		[Address(RVA = "0x20DA834", Offset = "0x20DA834", VA = "0x7BBC8DA834")]
		private void RefreshDownLoadState(params object[] param)
		{
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009243")]
		[Address(RVA = "0x20DA91C", Offset = "0x20DA91C", VA = "0x7BBC8DA91C")]
		private void SetSelectBtnShow(params object[] param)
		{
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009244")]
		[Address(RVA = "0x20DA9F0", Offset = "0x20DA9F0", VA = "0x7BBC8DA9F0")]
		private void RefreshPetInfoPanel(params object[] param)
		{
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009245")]
		[Address(RVA = "0x20D7498", Offset = "0x20D7498", VA = "0x7BBC8D7498")]
		private void ShowGridInfoList(PetConfigInfo config)
		{
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009246")]
		[Address(RVA = "0x20D70E4", Offset = "0x20D70E4", VA = "0x7BBC8D70E4")]
		private void RefreshPetExpLabel(PetLevelUpNtf data)
		{
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009247")]
		[Address(RVA = "0x20DB410", Offset = "0x20DB410", VA = "0x7BBC8DB410")]
		private void RefreshMyPetInfoComponent(bool showFlag)
		{
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009248")]
		[Address(RVA = "0x20D71F4", Offset = "0x20D71F4", VA = "0x7BBC8D71F4")]
		private void RefreshMyPetFoodComponent()
		{
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009249")]
		[Address(RVA = "0x20DB6DC", Offset = "0x20DB6DC", VA = "0x7BBC8DB6DC")]
		private void UpdateProgressBar(int exp_own, int exp_lvUp)
		{
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924A")]
		[Address(RVA = "0x20DC1C0", Offset = "0x20DC1C0", VA = "0x7BBC8DC1C0")]
		private void UpdateProgressBarAnim(int exp_old, int exp_own, int start_lv, int end_lv)
		{
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924B")]
		[Address(RVA = "0x20DB6C8", Offset = "0x20DB6C8", VA = "0x7BBC8DB6C8")]
		private void StopProgressBarAnim()
		{
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600924C")]
		[Address(RVA = "0x20DC3F8", Offset = "0x20DC3F8", VA = "0x7BBC8DC3F8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11449FC", Offset = "0x11449FC")]
		private IEnumerator ProgressBarAnimation()
		{
			return null;
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924D")]
		[Address(RVA = "0x20DC46C", Offset = "0x20DC46C", VA = "0x7BBC8DC46C")]
		private void CheckMaxLevel(int newLevel)
		{
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924E")]
		[Address(RVA = "0x20D6F68", Offset = "0x20D6F68", VA = "0x7BBC8D6F68")]
		private void UpdateSelectBtn(proto.PetInfo info)
		{
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924F")]
		[Address(RVA = "0x20DB748", Offset = "0x20DB748", VA = "0x7BBC8DB748")]
		private void ShowActionList(List<PetActionData> dataList)
		{
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009250")]
		[Address(RVA = "0x20DBA64", Offset = "0x20DBA64", VA = "0x7BBC8DBA64")]
		private void ShowSkinList(List<PetSkinData> dataList)
		{
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009251")]
		[Address(RVA = "0x20D6D14", Offset = "0x20D6D14", VA = "0x7BBC8D6D14")]
		private void ShowCurrentSkillInfo(proto.PetInfo pet_info)
		{
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009252")]
		[Address(RVA = "0x20DBF00", Offset = "0x20DBF00", VA = "0x7BBC8DBF00")]
		private void ShowSkillList(List<PetSkillInfoData> dataList)
		{
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009253")]
		[Address(RVA = "0x20DC924", Offset = "0x20DC924", VA = "0x7BBC8DC924", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009254")]
		[Address(RVA = "0x20DCE3C", Offset = "0x20DCE3C", VA = "0x7BBC8DCE3C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009255")]
		[Address(RVA = "0x20DCF4C", Offset = "0x20DCF4C", VA = "0x7BBC8DCF4C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009256")]
		[Address(RVA = "0x20DD25C", Offset = "0x20DD25C", VA = "0x7BBC8DD25C")]
		private void CheckNeedSelectSkillGuide()
		{
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009257")]
		[Address(RVA = "0x20DB164", Offset = "0x20DB164", VA = "0x7BBC8DB164")]
		private void CheckPetFreeChangeName(proto.PetInfo PetInfo)
		{
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009258")]
		[Address(RVA = "0x20DD46C", Offset = "0x20DD46C", VA = "0x7BBC8DD46C", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009259")]
		[Address(RVA = "0x20DCE98", Offset = "0x20DCE98", VA = "0x7BBC8DCE98")]
		private void StopBGM(params object[] data)
		{
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925A")]
		[Address(RVA = "0x20DD534", Offset = "0x20DD534", VA = "0x7BBC8DD534")]
		private void OnCarryStateClick()
		{
		}

		// Token: 0x0600925B RID: 37467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925B")]
		[Address(RVA = "0x20D8828", Offset = "0x20D8828", VA = "0x7BBC8D8828")]
		private void InitShareSelfProfile()
		{
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925C")]
		[Address(RVA = "0x20DDA80", Offset = "0x20DDA80", VA = "0x7BBC8DDA80")]
		private void OnRenameClick()
		{
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925D")]
		[Address(RVA = "0x20DDB40", Offset = "0x20DDB40", VA = "0x7BBC8DDB40")]
		private void OnFeedPetLevelUpClick()
		{
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925E")]
		[Address(RVA = "0x20D7450", Offset = "0x20D7450", VA = "0x7BBC8D7450")]
		private void SetFeedButtonClickState(bool state)
		{
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600925F")]
		[Address(RVA = "0x20DDE98", Offset = "0x20DDE98", VA = "0x7BBC8DDE98")]
		private void OnBuyPetFoodClick()
		{
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x00026E98 File Offset: 0x00025098
		[Token(Token = "0x6009260")]
		[Address(RVA = "0x20DC288", Offset = "0x20DC288", VA = "0x7BBC8DC288")]
		private uint CalPetLevelUpFeedCount()
		{
			return 0U;
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x00026EB0 File Offset: 0x000250B0
		[Token(Token = "0x6009261")]
		[Address(RVA = "0x20DE270", Offset = "0x20DE270", VA = "0x7BBC8DE270")]
		private bool IsPetMaxLevel()
		{
			return default(bool);
		}

		// Token: 0x06009262 RID: 37474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009262")]
		[Address(RVA = "0x20DE2F4", Offset = "0x20DE2F4", VA = "0x7BBC8DE2F4", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009263")]
		[Address(RVA = "0x20DE388", Offset = "0x20DE388", VA = "0x7BBC8DE388", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009264")]
		[Address(RVA = "0x20DE3B8", Offset = "0x20DE3B8", VA = "0x7BBC8DE3B8")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009265")]
		[Address(RVA = "0x20DE540", Offset = "0x20DE540", VA = "0x7BBC8DE540", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009266")]
		[Address(RVA = "0x20DE734", Offset = "0x20DE734", VA = "0x7BBC8DE734", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009267")]
		[Address(RVA = "0x20DE928", Offset = "0x20DE928", VA = "0x7BBC8DE928")]
		private void OnShowPetClick()
		{
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00026EC8 File Offset: 0x000250C8
		[Token(Token = "0x6009268")]
		[Address(RVA = "0x20DEA8C", Offset = "0x20DEA8C", VA = "0x7BBC8DEA8C", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009269")]
		[Address(RVA = "0x20DEA94", Offset = "0x20DEA94", VA = "0x7BBC8DEA94")]
		public UIPetInfoController()
		{
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00026EE0 File Offset: 0x000250E0
		[Token(Token = "0x600926A")]
		[Address(RVA = "0x20DEAB4", Offset = "0x20DEAB4", VA = "0x7BBC8DEAB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144A60", Offset = "0x1144A60")]
		private bool <OnDataChanged>b__24_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x00026EF8 File Offset: 0x000250F8
		[Token(Token = "0x600926B")]
		[Address(RVA = "0x20DEAF0", Offset = "0x20DEAF0", VA = "0x7BBC8DEAF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144A70", Offset = "0x1144A70")]
		private bool <OnActionBtnClick>b__28_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x00026F10 File Offset: 0x00025110
		[Token(Token = "0x600926C")]
		[Address(RVA = "0x20DEB2C", Offset = "0x20DEB2C", VA = "0x7BBC8DEB2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144A80", Offset = "0x1144A80")]
		private bool <OnSkinBtnClick>b__29_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x00026F28 File Offset: 0x00025128
		[Token(Token = "0x600926D")]
		[Address(RVA = "0x20DEB68", Offset = "0x20DEB68", VA = "0x7BBC8DEB68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144A90", Offset = "0x1144A90")]
		private bool <OnSkillBtnClick>b__30_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x00026F40 File Offset: 0x00025140
		[Token(Token = "0x600926E")]
		[Address(RVA = "0x20DEBA4", Offset = "0x20DEBA4", VA = "0x7BBC8DEBA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144AA0", Offset = "0x1144AA0")]
		private bool <RefreshPriviewUIShow>b__37_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00026F58 File Offset: 0x00025158
		[Token(Token = "0x600926F")]
		[Address(RVA = "0x20DEBE0", Offset = "0x20DEBE0", VA = "0x7BBC8DEBE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144AB0", Offset = "0x1144AB0")]
		private bool <RefreshPetInfoPanel>b__48_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00026F70 File Offset: 0x00025170
		[Token(Token = "0x6009270")]
		[Address(RVA = "0x20DEC1C", Offset = "0x20DEC1C", VA = "0x7BBC8DEC1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144AC0", Offset = "0x1144AC0")]
		private bool <OnCarryStateClick>b__70_0(proto.PetInfo temp)
		{
			return default(bool);
		}

		// Token: 0x04009CDE RID: 40158
		[Token(Token = "0x4009CDE")]
		[FieldOffset(Offset = "0xB0")]
		private UIPetView m_View;

		// Token: 0x04009CDF RID: 40159
		[Token(Token = "0x4009CDF")]
		private const string PET_RENAME_TAG = "PET_ITEM_NEW_TAG";

		// Token: 0x04009CE0 RID: 40160
		[Token(Token = "0x4009CE0")]
		private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

		// Token: 0x04009CE1 RID: 40161
		[Token(Token = "0x4009CE1")]
		private const string PET_FOOD_SUFFICIENT = "[FFB300FF]{0}[-]/{1}";

		// Token: 0x04009CE2 RID: 40162
		[Token(Token = "0x4009CE2")]
		private const string PET_FOOD_INSUFFICIENT = "[EF3030FF]{0}[-]/{1}";

		// Token: 0x04009CE3 RID: 40163
		[Token(Token = "0x4009CE3")]
		[FieldOffset(Offset = "0xB8")]
		private uint current_show_pet_id;

		// Token: 0x04009CE4 RID: 40164
		[Token(Token = "0x4009CE4")]
		[FieldOffset(Offset = "0xBC")]
		private uint current_show_skin_id;

		// Token: 0x04009CE5 RID: 40165
		[Token(Token = "0x4009CE5")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelPet m_PetModel;

		// Token: 0x04009CE6 RID: 40166
		[Token(Token = "0x4009CE6")]
		[FieldOffset(Offset = "0xC8")]
		private UIPetAvatar pet_avatar;

		// Token: 0x04009CE7 RID: 40167
		[Token(Token = "0x4009CE7")]
		[FieldOffset(Offset = "0xD0")]
		private Item current_use_food;

		// Token: 0x04009CE8 RID: 40168
		[Token(Token = "0x4009CE8")]
		[FieldOffset(Offset = "0xD8")]
		private int anim_start_level;

		// Token: 0x04009CE9 RID: 40169
		[Token(Token = "0x4009CE9")]
		[FieldOffset(Offset = "0xDC")]
		private int anim_start_exp;

		// Token: 0x04009CEA RID: 40170
		[Token(Token = "0x4009CEA")]
		[FieldOffset(Offset = "0xE0")]
		private float anim_current_exp;

		// Token: 0x04009CEB RID: 40171
		[Token(Token = "0x4009CEB")]
		[FieldOffset(Offset = "0xE4")]
		private int anim_end_exp;

		// Token: 0x04009CEC RID: 40172
		[Token(Token = "0x4009CEC")]
		[FieldOffset(Offset = "0xE8")]
		private int anim_current_level;

		// Token: 0x04009CED RID: 40173
		[Token(Token = "0x4009CED")]
		[FieldOffset(Offset = "0xEC")]
		private bool anim_start_flag;

		// Token: 0x04009CEE RID: 40174
		[Token(Token = "0x4009CEE")]
		[FieldOffset(Offset = "0xF0")]
		private float anim_speed;

		// Token: 0x04009CEF RID: 40175
		[Token(Token = "0x4009CEF")]
		[FieldOffset(Offset = "0xF4")]
		private UIShowType Show_grid_flag;

		// Token: 0x04009CF0 RID: 40176
		[Token(Token = "0x4009CF0")]
		[FieldOffset(Offset = "0xF8")]
		private uint max_feed_count;

		// Token: 0x04009CF1 RID: 40177
		[Token(Token = "0x4009CF1")]
		[FieldOffset(Offset = "0xFC")]
		private uint next_level_feed_count;

		// Token: 0x04009CF2 RID: 40178
		[Token(Token = "0x4009CF2")]
		[FieldOffset(Offset = "0x100")]
		private UIPetNormalGridController m_normalGridController;

		// Token: 0x04009CF3 RID: 40179
		[Token(Token = "0x4009CF3")]
		[FieldOffset(Offset = "0x108")]
		private UIPetSkillGridController m_skillGridController;

		// Token: 0x04009CF4 RID: 40180
		[Token(Token = "0x4009CF4")]
		[FieldOffset(Offset = "0x110")]
		private UICommonGuideController m_PetLevelUpGuide;

		// Token: 0x04009CF5 RID: 40181
		[Token(Token = "0x4009CF5")]
		[FieldOffset(Offset = "0x118")]
		private UIUtils.ScreenshotType m_CurrentScreenshotType;

		// Token: 0x02001AEF RID: 6895
		[Token(Token = "0x2001AEF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F24", Offset = "0x10F8F24")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06009271 RID: 37489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009271")]
			[Address(RVA = "0x20DA82C", Offset = "0x20DA82C", VA = "0x7BBC8DA82C")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x06009272 RID: 37490 RVA: 0x00026F88 File Offset: 0x00025188
			[Token(Token = "0x6009272")]
			[Address(RVA = "0x20DEC58", Offset = "0x20DEC58", VA = "0x7BBC8DEC58")]
			internal bool <GotoPet>b__0(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009CF6 RID: 40182
			[Token(Token = "0x4009CF6")]
			[FieldOffset(Offset = "0x10")]
			public object[] param;
		}

		// Token: 0x02001AF0 RID: 6896
		[Token(Token = "0x2001AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F34", Offset = "0x10F8F34")]
		private sealed class <ProgressBarAnimation>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009273 RID: 37491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009273")]
			[Address(RVA = "0x20DC5A8", Offset = "0x20DC5A8", VA = "0x7BBC8DC5A8")]
			[DebuggerHidden]
			public <ProgressBarAnimation>d__56(int <>1__state)
			{
			}

			// Token: 0x06009274 RID: 37492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009274")]
			[Address(RVA = "0x20DEE7C", Offset = "0x20DEE7C", VA = "0x7BBC8DEE7C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009275 RID: 37493 RVA: 0x00026FA0 File Offset: 0x000251A0
			[Token(Token = "0x6009275")]
			[Address(RVA = "0x20DEE80", Offset = "0x20DEE80", VA = "0x7BBC8DEE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06009276 RID: 37494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A37")]
			private object Current
			{
				[Token(Token = "0x6009276")]
				[Address(RVA = "0x20DF210", Offset = "0x20DF210", VA = "0x7BBC8DF210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009277 RID: 37495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009277")]
			[Address(RVA = "0x20DF218", Offset = "0x20DF218", VA = "0x7BBC8DF218", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06009278 RID: 37496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A38")]
			private object Current
			{
				[Token(Token = "0x6009278")]
				[Address(RVA = "0x20DF280", Offset = "0x20DF280", VA = "0x7BBC8DF280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009CF7 RID: 40183
			[Token(Token = "0x4009CF7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009CF8 RID: 40184
			[Token(Token = "0x4009CF8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009CF9 RID: 40185
			[Token(Token = "0x4009CF9")]
			[FieldOffset(Offset = "0x20")]
			public UIPetInfoController <>4__this;
		}

		// Token: 0x02001AF1 RID: 6897
		[Token(Token = "0x2001AF1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F44", Offset = "0x10F8F44")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x06009279 RID: 37497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009279")]
			[Address(RVA = "0x20DC5D4", Offset = "0x20DC5D4", VA = "0x7BBC8DC5D4")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x0600927A RID: 37498 RVA: 0x00026FB8 File Offset: 0x000251B8
			[Token(Token = "0x600927A")]
			[Address(RVA = "0x20DECFC", Offset = "0x20DECFC", VA = "0x7BBC8DECFC")]
			internal bool <ShowActionList>b__0(PetActionInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009CFA RID: 40186
			[Token(Token = "0x4009CFA")]
			[FieldOffset(Offset = "0x10")]
			public PetActionData data;
		}

		// Token: 0x02001AF2 RID: 6898
		[Token(Token = "0x2001AF2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F54", Offset = "0x10F8F54")]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x0600927B RID: 37499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600927B")]
			[Address(RVA = "0x20DC674", Offset = "0x20DC674", VA = "0x7BBC8DC674")]
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x0600927C RID: 37500 RVA: 0x00026FD0 File Offset: 0x000251D0
			[Token(Token = "0x600927C")]
			[Address(RVA = "0x20DED48", Offset = "0x20DED48", VA = "0x7BBC8DED48")]
			internal bool <ShowSkinList>b__0(PetSkinData temp)
			{
				return default(bool);
			}

			// Token: 0x04009CFB RID: 40187
			[Token(Token = "0x4009CFB")]
			[FieldOffset(Offset = "0x10")]
			public proto.PetInfo info;
		}

		// Token: 0x02001AF3 RID: 6899
		[Token(Token = "0x2001AF3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F64", Offset = "0x10F8F64")]
		private sealed class <>c__DisplayClass60_1
		{
			// Token: 0x0600927D RID: 37501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600927D")]
			[Address(RVA = "0x20DC67C", Offset = "0x20DC67C", VA = "0x7BBC8DC67C")]
			public <>c__DisplayClass60_1()
			{
			}

			// Token: 0x0600927E RID: 37502 RVA: 0x00026FE8 File Offset: 0x000251E8
			[Token(Token = "0x600927E")]
			[Address(RVA = "0x20DED94", Offset = "0x20DED94", VA = "0x7BBC8DED94")]
			internal bool <ShowSkinList>b__1(PetSkinInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009CFC RID: 40188
			[Token(Token = "0x4009CFC")]
			[FieldOffset(Offset = "0x10")]
			public PetSkinData data;
		}

		// Token: 0x02001AF4 RID: 6900
		[Token(Token = "0x2001AF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8F74", Offset = "0x10F8F74")]
		private sealed class <>c__DisplayClass60_2
		{
			// Token: 0x0600927F RID: 37503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600927F")]
			[Address(RVA = "0x20DC720", Offset = "0x20DC720", VA = "0x7BBC8DC720")]
			public <>c__DisplayClass60_2()
			{
			}

			// Token: 0x06009280 RID: 37504 RVA: 0x00027000 File Offset: 0x00025200
			[Token(Token = "0x6009280")]
			[Address(RVA = "0x20DEDE0", Offset = "0x20DEDE0", VA = "0x7BBC8DEDE0")]
			internal bool <ShowSkinList>b__2(PetSkinData temp)
			{
				return default(bool);
			}

			// Token: 0x04009CFD RID: 40189
			[Token(Token = "0x4009CFD")]
			[FieldOffset(Offset = "0x10")]
			public PetData data;
		}
	}
}
