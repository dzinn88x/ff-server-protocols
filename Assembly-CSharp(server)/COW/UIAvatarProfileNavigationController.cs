using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016C4 RID: 5828
	[Token(Token = "0x20016C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0BD4", Offset = "0x10F0BD4")]
	public class UIAvatarProfileNavigationController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x0001E450 File Offset: 0x0001C650
		[Token(Token = "0x1700091F")]
		public uint GetCurrentShowAvatarId
		{
			[Token(Token = "0x6006AD1")]
			[Address(RVA = "0x2079904", Offset = "0x2079904", VA = "0x7BBC879904")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x0001E468 File Offset: 0x0001C668
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x208DDC0", Offset = "0x208DDC0", VA = "0x7BBC88DDC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0001E480 File Offset: 0x0001C680
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0x208DE10", Offset = "0x208DE10", VA = "0x7BBC88DE10", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x0001E498 File Offset: 0x0001C698
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0x208DE18", Offset = "0x208DE18", VA = "0x7BBC88DE18", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0x208DE20", Offset = "0x208DE20", VA = "0x7BBC88DE20", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0x208E89C", Offset = "0x208E89C", VA = "0x7BBC88E89C")]
		private void InitTab()
		{
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x208E8A0", Offset = "0x208E8A0", VA = "0x7BBC88E8A0")]
		private void IniTabState()
		{
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0x208E960", Offset = "0x208E960", VA = "0x7BBC88E960")]
		private void RefreshAvatarExpireInfo()
		{
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0x208E8A8", Offset = "0x208E8A8", VA = "0x7BBC88E8A8")]
		private void RefreshContainerState(bool optionNotify = false)
		{
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x208ED6C", Offset = "0x208ED6C", VA = "0x7BBC88ED6C")]
		private void SetAwakenView(uint avatarID)
		{
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x208EE58", Offset = "0x208EE58", VA = "0x7BBC88EE58")]
		private void SetCurrentAwakenSelect(uint avatarID)
		{
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x208E95C", Offset = "0x208E95C", VA = "0x7BBC88E95C")]
		private void UpdateSpecialTabRedDot()
		{
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0x208EF30", Offset = "0x208EF30", VA = "0x7BBC88EF30")]
		private void RefreshTabVisible()
		{
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0x208EF34", Offset = "0x208EF34", VA = "0x7BBC88EF34", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x208FBF8", Offset = "0x208FBF8", VA = "0x7BBC88FBF8")]
		private void UpdateRealAvatarList()
		{
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0x20905A8", Offset = "0x20905A8", VA = "0x7BBC8905A8")]
		private void UpdateAvatarList(params object[] data)
		{
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0x208F7F4", Offset = "0x208F7F4", VA = "0x7BBC88F7F4")]
		private void TryShowReCommendSuit()
		{
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE2")]
		[Address(RVA = "0x208F4C8", Offset = "0x208F4C8", VA = "0x7BBC88F4C8")]
		private void TryShowGuide()
		{
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE3")]
		[Address(RVA = "0x209065C", Offset = "0x209065C", VA = "0x7BBC89065C", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE4")]
		[Address(RVA = "0x20906EC", Offset = "0x20906EC", VA = "0x7BBC8906EC", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE5")]
		[Address(RVA = "0x2090CC4", Offset = "0x2090CC4", VA = "0x7BBC890CC4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE6")]
		[Address(RVA = "0x209135C", Offset = "0x209135C", VA = "0x7BBC89135C")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0x20913F4", Offset = "0x20913F4", VA = "0x7BBC8913F4")]
		private bool IsBackNavigation(UINavigationData navigationData)
		{
			return default(bool);
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0x209140C", Offset = "0x209140C", VA = "0x7BBC89140C")]
		private void OnSelectAvatar(object[] data)
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0x2091410", Offset = "0x2091410", VA = "0x7BBC891410")]
		private void OnResetAvatarModel(object[] data)
		{
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0x2091500", Offset = "0x2091500", VA = "0x7BBC891500")]
		private void OnFullScreenPreviewClose(object[] data)
		{
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEB")]
		[Address(RVA = "0x2091504", Offset = "0x2091504", VA = "0x7BBC891504")]
		private void OnSelctedAvatarUpdate(params object[] data)
		{
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEC")]
		[Address(RVA = "0x208FD2C", Offset = "0x208FD2C", VA = "0x7BBC88FD2C")]
		private void OnSwitchShowAvatar(object[] data)
		{
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AED")]
		[Address(RVA = "0x20918A4", Offset = "0x20918A4", VA = "0x7BBC8918A4")]
		private void ShowAwakenAvatarExchangeView(bool forceHide = false)
		{
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AEE")]
		[Address(RVA = "0x208F794", Offset = "0x208F794", VA = "0x7BBC88F794")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140F8C", Offset = "0x1140F8C")]
		private IEnumerator CoResetAvatarIdle()
		{
			return null;
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0x2091528", Offset = "0x2091528", VA = "0x7BBC891528")]
		private void StartSuitPreview(uint avatarId, uint[] clothsIds)
		{
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0x20918A8", Offset = "0x20918A8", VA = "0x7BBC8918A8")]
		private void OnSwitchSuit(object[] data)
		{
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0x20918AC", Offset = "0x20918AC", VA = "0x7BBC8918AC")]
		private void ShowDebrisSourceTip(object[] data)
		{
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		[Token(Token = "0x6006AF2")]
		[Address(RVA = "0x2091A78", Offset = "0x2091A78", VA = "0x7BBC891A78", Slot = "40")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF3")]
		[Address(RVA = "0x2091ADC", Offset = "0x2091ADC", VA = "0x7BBC891ADC")]
		private void RefreshListShow(bool flag = false)
		{
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF4")]
		[Address(RVA = "0x2091CB4", Offset = "0x2091CB4", VA = "0x7BBC891CB4", Slot = "39")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0x2092278", Offset = "0x2092278", VA = "0x7BBC892278")]
		private void RefreshSpecialInfo()
		{
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0x2092334", Offset = "0x2092334", VA = "0x7BBC892334")]
		private void OnEquipSkill(object[] data)
		{
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0x2092414", Offset = "0x2092414", VA = "0x7BBC892414")]
		private void OnUnlockProfile(object[] data)
		{
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0x2092418", Offset = "0x2092418", VA = "0x7BBC892418")]
		private void OnOpenAvatarList(object[] data)
		{
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0x209241C", Offset = "0x209241C", VA = "0x7BBC89241C")]
		private void OnChooseAvatarClick()
		{
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0x2092420", Offset = "0x2092420", VA = "0x7BBC892420")]
		private void OnOpenAvatarListForLatest(object[] data)
		{
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0x2092424", Offset = "0x2092424", VA = "0x7BBC892424")]
		private void OnOpenSkillList(object[] data)
		{
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0x20925EC", Offset = "0x20925EC", VA = "0x7BBC8925EC")]
		private void OnOpenProfileDetail(object[] data)
		{
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFD")]
		[Address(RVA = "0x2091770", Offset = "0x2091770", VA = "0x7BBC891770")]
		private void RefreshAvatarProfileAndSuit(bool flag = true)
		{
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFE")]
		[Address(RVA = "0x20925F0", Offset = "0x20925F0", VA = "0x7BBC8925F0")]
		private void UpdateAvatarProfile(params object[] data)
		{
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFF")]
		[Address(RVA = "0x20926C8", Offset = "0x20926C8", VA = "0x7BBC8926C8")]
		private void OnSelectClick()
		{
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B00")]
		[Address(RVA = "0x20902CC", Offset = "0x20902CC", VA = "0x7BBC8902CC")]
		private void RefreshBottomBtnGroup()
		{
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B01")]
		[Address(RVA = "0x2092750", Offset = "0x2092750", VA = "0x7BBC892750")]
		private void OnGainAvatarClick()
		{
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B02")]
		[Address(RVA = "0x2093070", Offset = "0x2093070", VA = "0x7BBC893070")]
		private void OnExChangeAwakenAvatar(uint toAvatarID)
		{
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0x20931F0", Offset = "0x20931F0", VA = "0x7BBC8931F0")]
		private void OnExchangeToAwakenAvatar()
		{
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0x2093278", Offset = "0x2093278", VA = "0x7BBC893278")]
		private void OnExchangeToOriAvatar()
		{
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0x2092B58", Offset = "0x2092B58", VA = "0x7BBC892B58")]
		private void GainAvatar()
		{
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B06")]
		[Address(RVA = "0x2093300", Offset = "0x2093300", VA = "0x7BBC893300")]
		private void OnGainBundleBtnClick()
		{
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0x20935C8", Offset = "0x20935C8", VA = "0x7BBC8935C8")]
		private void onDressClick()
		{
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0x2093C48", Offset = "0x2093C48", VA = "0x7BBC893C48")]
		private void OnUseClick()
		{
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0x2093C50", Offset = "0x2093C50", VA = "0x7BBC893C50")]
		private void OnUseEx(bool callFromAvatarList = false)
		{
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0x2093CAC", Offset = "0x2093CAC", VA = "0x7BBC893CAC")]
		private void OnVaultBtnClick()
		{
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0x2093D44", Offset = "0x2093D44", VA = "0x7BBC893D44")]
		private void OnProfileBtnClick()
		{
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0x208ED68", Offset = "0x208ED68", VA = "0x7BBC88ED68")]
		private void RefreshVoiceBtnState()
		{
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x2093988", Offset = "0x2093988", VA = "0x7BBC893988")]
		private bool CanChangeClothes()
		{
			return default(bool);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0x2094100", Offset = "0x2094100", VA = "0x7BBC894100")]
		private void OnResetCurrentPreviewClothes(params object[] param)
		{
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0x208EC74", Offset = "0x208EC74", VA = "0x7BBC88EC74")]
		private bool CheckSuitIsABReady()
		{
			return default(bool);
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0x209424C", Offset = "0x209424C", VA = "0x7BBC89424C")]
		public UIAvatarProfileNavigationController()
		{
		}

		// Token: 0x0400870D RID: 34573
		[Token(Token = "0x400870D")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_CurrentShowAvatarID;

		// Token: 0x0400870E RID: 34574
		[Token(Token = "0x400870E")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_CurrentShowSuitID;

		// Token: 0x0400870F RID: 34575
		[Token(Token = "0x400870F")]
		[FieldOffset(Offset = "0xB8")]
		private UIAvatarProfileNavigationView m_View;

		// Token: 0x04008710 RID: 34576
		[Token(Token = "0x4008710")]
		[FieldOffset(Offset = "0xC0")]
		private UIAvatarProfileController m_AvatarProfileCtrl;

		// Token: 0x04008711 RID: 34577
		[Token(Token = "0x4008711")]
		[FieldOffset(Offset = "0xC8")]
		private UIChooseSkillWindowController m_ChooseSkillCtrl;

		// Token: 0x04008712 RID: 34578
		[Token(Token = "0x4008712")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelAvatarProfile m_AvatarProfileModel;

		// Token: 0x04008713 RID: 34579
		[Token(Token = "0x4008713")]
		[FieldOffset(Offset = "0xD8")]
		private UINavigationData m_CacheNavigationData;

		// Token: 0x04008714 RID: 34580
		[Token(Token = "0x4008714")]
		private const string m_DebrisTipKey = "TXT_PROFILE_DEBRIS_TIP";

		// Token: 0x04008715 RID: 34581
		[Token(Token = "0x4008715")]
		private const string VISIT_AVATAR_LIST = "VISIT_AVATAR_LIST";

		// Token: 0x04008716 RID: 34582
		[Token(Token = "0x4008716")]
		public const string FIRST_CHARA_KEY = "HAS_SEEN_CHARACTER";

		// Token: 0x04008717 RID: 34583
		[Token(Token = "0x4008717")]
		[FieldOffset(Offset = "0xE0")]
		private UICommonGuideController m_CommonGuideCtrl;

		// Token: 0x04008718 RID: 34584
		[Token(Token = "0x4008718")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_PlayVoiceDelayCall;

		// Token: 0x04008719 RID: 34585
		[Token(Token = "0x4008719")]
		[FieldOffset(Offset = "0xF0")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x0400871A RID: 34586
		[Token(Token = "0x400871A")]
		[FieldOffset(Offset = "0xF8")]
		private List<StandardSubTabItemViewData> m_SubTabDataList;

		// Token: 0x0400871B RID: 34587
		[Token(Token = "0x400871B")]
		[FieldOffset(Offset = "0x100")]
		private UIAvatarSuitRecommendItemController m_RecommendCtrl;

		// Token: 0x0400871C RID: 34588
		[Token(Token = "0x400871C")]
		[FieldOffset(Offset = "0x108")]
		private UIAvatarListShowController m_AvatarListShowCtrl;

		// Token: 0x0400871D RID: 34589
		[Token(Token = "0x400871D")]
		[FieldOffset(Offset = "0x110")]
		private bool m_FirstEntered;

		// Token: 0x020016C5 RID: 5829
		[Token(Token = "0x20016C5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0C0C", Offset = "0x10F0C0C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006B12 RID: 27410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B12")]
			[Address(RVA = "0x1E45944", Offset = "0x1E45944", VA = "0x7BBC645944")]
			public <>c()
			{
			}

			// Token: 0x06006B13 RID: 27411 RVA: 0x0001E510 File Offset: 0x0001C710
			[Token(Token = "0x6006B13")]
			[Address(RVA = "0x1E4594C", Offset = "0x1E4594C", VA = "0x7BBC64594C")]
			internal bool <TryShowReCommendSuit>b__34_0(AvatarSuit x)
			{
				return default(bool);
			}

			// Token: 0x06006B14 RID: 27412 RVA: 0x0001E528 File Offset: 0x0001C728
			[Token(Token = "0x6006B14")]
			[Address(RVA = "0x1E45978", Offset = "0x1E45978", VA = "0x7BBC645978")]
			internal bool <OnSwitchShowAvatar>b__45_0(AvatarSuit x)
			{
				return default(bool);
			}

			// Token: 0x0400871E RID: 34590
			[Token(Token = "0x400871E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarProfileNavigationController.<>c <>9;

			// Token: 0x0400871F RID: 34591
			[Token(Token = "0x400871F")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AvatarSuit> <>9__34_0;

			// Token: 0x04008720 RID: 34592
			[Token(Token = "0x4008720")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<AvatarSuit> <>9__45_0;
		}

		// Token: 0x020016C6 RID: 5830
		[Token(Token = "0x20016C6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0C1C", Offset = "0x10F0C1C")]
		private sealed class <CoResetAvatarIdle>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B15 RID: 27413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B15")]
			[Address(RVA = "0x1E459A4", Offset = "0x1E459A4", VA = "0x7BBC6459A4")]
			[DebuggerHidden]
			public <CoResetAvatarIdle>d__47(int <>1__state)
			{
			}

			// Token: 0x06006B16 RID: 27414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B16")]
			[Address(RVA = "0x1E459D0", Offset = "0x1E459D0", VA = "0x7BBC6459D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x0001E540 File Offset: 0x0001C740
			[Token(Token = "0x6006B17")]
			[Address(RVA = "0x1E459D4", Offset = "0x1E459D4", VA = "0x7BBC6459D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06006B18 RID: 27416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000920")]
			private object Current
			{
				[Token(Token = "0x6006B18")]
				[Address(RVA = "0x1E45AC8", Offset = "0x1E45AC8", VA = "0x7BBC645AC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B19")]
			[Address(RVA = "0x1E45AD0", Offset = "0x1E45AD0", VA = "0x7BBC645AD0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06006B1A RID: 27418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000921")]
			private object Current
			{
				[Token(Token = "0x6006B1A")]
				[Address(RVA = "0x1E45B38", Offset = "0x1E45B38", VA = "0x7BBC645B38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008721 RID: 34593
			[Token(Token = "0x4008721")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008722 RID: 34594
			[Token(Token = "0x4008722")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
